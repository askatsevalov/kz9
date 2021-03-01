<template>
  <div>
    <div class="my-container">
      <h1 class="main-title">
        Нейросетевое раскрашивание черно-белых фотографий
      </h1>
      <button class="start-button button" @click="start">
        <span class="text">Сделать фото цветным</span>
      </button>
    </div>
    <!-- <footer class="footer">
      <div class="content has-text-centered">
        САЛАМ ЭТО КАЦ И УЗБЕК
      </div>
    </footer> -->

    <div v-if="step == 'load'" class="modal is-active is-clipped">
      <div class="modal-background"></div>
      <div class="load-modal modal-content is-clipped">
        <div class="box">
          <h1 class="title is-size-4">Загрузите черно-белое фото</h1>
          <vue2Dropzone
            ref="myDropzone"
            id="dropzone"
            :options="dropzoneOptions"
            :useCustomSlot="true"
            v-on:vdropzone-max-files-exceeded="removeExtraPhoto"
            v-on:vdropzone-success="fileUploaded"
            v-on:vdropzone-error="removeBadPhoto"
          >
            <div
              class="dz-message is-flex is-flex-direction-column is-justify-content-center"
            >
              <span>Переместите изображение в данную область</span>
              <div>
                <svg style="width:200px;height:200px" viewBox="0 0 24 24">
                  <path
                    fill="currentColor"
                    d="M19.35,10.04C18.67,6.59 15.64,4 12,4C9.11,4 6.6,5.64 5.35,8.04C2.34,8.36 0,10.91 0,14A6,6 0 0,0 6,20H19A5,5 0 0,0 24,15C24,12.36 21.95,10.22 19.35,10.04M19,18H6A4,4 0 0,1 2,14C2,11.95 3.53,10.24 5.56,10.03L6.63,9.92L7.13,8.97C8.08,7.14 9.94,6 12,6C14.62,6 16.88,7.86 17.39,10.43L17.69,11.93L19.22,12.04C20.78,12.14 22,13.45 22,15A3,3 0 0,1 19,18M8,13H10.55V16H13.45V13H16L12,9L8,13Z"
                  />
                </svg>
              </div>
            </div>
          </vue2Dropzone>
          <button
            v-show="readyToColorize"
            class="colorize-button button"
            @click="colorize"
          >
            <span class="text">Сделать фото цветным</span>
          </button>
        </div>
      </div>
      <button
        class="modal-close is-large"
        aria-label="close"
        @click="step = ''"
      ></button>
    </div>
    <div v-if="step == 'wait'" class="modal is-active is-clipped">
      <div class="modal-background"></div>
      <div class="wait-modal modal-content is-clipped">
        <div
          class="box is-flex is-flex-direction-column is-justify-content-center"
        >
          <span>Нейросеть обрабатывает фотографию, пожалуйста подождите</span>
          <progress class="progress is-small is-info mt-5"></progress>
        </div>
      </div>
      <button
        class="modal-close is-large"
        aria-label="close"
        @click="step = ''"
      ></button>
    </div>
    <div v-if="step == 'error'" class="modal is-active is-clipped">
      <div class="modal-background"></div>
      <div class="error-modal modal-content is-clipped">
        <div
          class="box is-flex is-flex-direction-column is-justify-content-center"
        >
          <span>Произошла ошибка, повторите попытку</span>
          <button class="button is-ghost mt-5" @click="colorize">
            Повторить
          </button>
        </div>
      </div>
      <button
        class="modal-close is-large"
        aria-label="close"
        @click="step = ''"
      ></button>
    </div>
    <div v-if="step == 'result'" class="modal is-active is-clipped">
      <div class="modal-background"></div>
      <div class="result-modal modal-content is-clipped">
        <div class="box">
          <h1 class="title is-size-4">Готово</h1>
          <figure class="image">
            <img class="result" :src="photoUrl" />
          </figure>
          <div
            class="is-flex is-flex-direction-row is-justify-content-space-between is-align-items-center mt-4"
          >
            <div class="field m-0">
              <label class="mr-2" for="switchRoundedOutlinedInfo">До</label>
              <input
                id="switchRoundedOutlinedInfo"
                type="checkbox"
                name="switchRoundedOutlinedInfo"
                class="switch is-rounded is-info"
                v-model="showOuput"
              />
              <label for="switchRoundedOutlinedInfo">После</label>
            </div>
            <a
              class="button is-ghost"
              :download="outputPhoto.name"
              :href="`/storage/${outputPhoto.name}`"
            >
              Скачать результат
            </a>
          </div>
        </div>
      </div>
      <button
        class="modal-close is-large"
        aria-label="close"
        @click="step = ''"
      ></button>
    </div>

    <div
      v-show="notificationVisibility"
      class="my-notification notification is-danger"
    >
      <button class="delete" @click="notificationVisibility = false"></button>
      {{ notificationMessage }}
    </div>
  </div>
</template>

<script>
import vue2Dropzone from "vue2-dropzone";

export default {
  name: "App",
  components: {
    vue2Dropzone,
  },
  data() {
    return {
      dropzoneOptions: {
        url: "api/colorizer/",
        thumbnailWidth: 300,
        acceptedFiles: "image/*",
        maxFiles: 1,
      },
      step: "",
      notificationVisibility: false,
      readyToColorize: false,
      modalTitle: "",
      notificationMessage: "",
      inputPhoto: {
        name: ""
      },
      outputPhoto: {
        name: ""
      },
      showOuput: true,
    };
  },
  computed: {
    photoUrl() {
      return `/storage/${
        this.showOuput ? this.outputPhoto.name : this.inputPhoto.name
      }`;
    },
  },
  methods: {
    start() {
      this.readyToColorize = false;
      this.step = "load";
    },
    async colorize() {
      this.step = "wait";
      this.showOuput = true;
      var response = await this.axios.post(
        `/api/colorizer/${this.inputPhoto.id}`
      );
      if (response.status == 200) {
        this.outputPhoto = response.data;
        this.step = "result";
      } else {
        this.outputPhoto = null;
        this.step = "error";
      }
    },
    fileUploaded(file, response) {
      this.inputPhoto = response;
      this.readyToColorize = true;
    },
    removeBadPhoto(file) {
      this.notificationMessage =
        "Загруженное фото не подходит! Попробуйте другое...";
      this.notificationVisibility = true;
      this.$refs.myDropzone.removeFile(file);
    },
    removeExtraPhoto(file) {
      this.notificationMessage = "Можно загружать только одно фото за раз!";
      this.notificationVisibility = true;
      this.$refs.myDropzone.removeFile(file);
    },
  },
};
</script>

<style lang="scss">
html {
  overflow-y: hidden !important;
  background-image: url("./assets/images/bg.jpg");
  -webkit-background-size: cover;
  -moz-background-size: cover;
  -o-background-size: cover;
  background-size: cover;
  height: 100vh;
  font-family: "Gotham Pro" !important;
}
.my-container {
  margin-right: 80px;
  margin-left: 80px;
}
.main-title {
  font-style: normal;
  font-weight: 900;
  font-size: 72px;
  line-height: 72px;
  max-width: 600px;
  margin-top: 120px;
}
.start-button {
  margin-top: 80px;
  background: linear-gradient(90deg, #3981aa 0%, #3966aa 50%, #3949aa 100%);
  border-radius: 2px;
  width: 305px;
  height: 60px !important;

  .text {
    text-align: center;
    color: #ffffff;
    font-style: normal;
    font-weight: 600;
    font-size: 16px;
    line-height: 20px;
  }
}
.colorize-button {
  margin-top: 20px;
  background: linear-gradient(90deg, #3981aa 0%, #3966aa 50%, #3949aa 100%);
  border-radius: 2px;
  width: 100%;
  height: 60px !important;

  .text {
    text-align: center;
    color: #ffffff;
    font-style: normal;
    font-weight: 600;
    font-size: 16px;
    line-height: 20px;
  }
}
.load-modal {
  max-width: 400px;
}
.wait-modal {
  max-width: 600px;
  .box {
    height: 280px;
    padding-left: 150px;
    padding-right: 150px;
    text-align: center;
  }
}
.error-modal {
  max-width: 600px;
  .box {
    height: 280px;
    padding-left: 100px;
    padding-right: 100px;
    text-align: center;
  }
}
.footer {
  position: absolute;
  bottom: 0;
  right: 0;
  left: 0;
  padding: 1rem !important;
  background-color: rgba($color: #eeeeee, $alpha: 0.8);
}
#dropzone {
  border: 2px dashed #2b2f31;
  box-sizing: border-box;
  border-radius: 2px;
  height: 300px;
}
.my-notification {
  position: absolute !important;
  left: 5%;
  top: 5%;
  width: 30vw;
  z-index: 1000;
}
.result {
  max-height: 80vh;
}
</style>
