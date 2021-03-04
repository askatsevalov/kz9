<template>
  <div>
    <nav
      class="navbar is-fixed-top is-transparent my-container"
      :class="{ 'bottom-border': showNavbarShadow }"
    >
      <div class="navbar-brand">
        <a class="logo navbar-item" href="#main-section">
          <svg
            width="80%"
            height="80%"
            viewBox="0 0 52 64"
            fill="none"
            xmlns="http://www.w3.org/2000/svg"
          >
            <path
              d="M6.98644 57V55.836L9.87844 53.376C10.4704 52.88 10.8784 52.472 11.1024 52.152C11.3344 51.824 11.4504 51.476 11.4504 51.108C11.4504 50.708 11.3224 50.392 11.0664 50.16C10.8104 49.92 10.4864 49.8 10.0944 49.8C9.72644 49.8 9.39444 49.9 9.09844 50.1C8.81044 50.3 8.49444 50.62 8.15044 51.06L7.10644 50.244C7.53844 49.636 7.98244 49.192 8.43844 48.912C8.90244 48.624 9.49044 48.48 10.2024 48.48C11.0264 48.48 11.6944 48.712 12.2064 49.176C12.7184 49.64 12.9744 50.252 12.9744 51.012C12.9744 51.34 12.9344 51.636 12.8544 51.9C12.7744 52.156 12.6304 52.42 12.4224 52.692C12.2224 52.956 12.0024 53.2 11.7624 53.424C11.5304 53.64 11.2064 53.92 10.7904 54.264L9.06244 55.704H13.0584V57H6.98644ZM17.5978 57.144C16.6618 57.144 15.8818 56.824 15.2578 56.184C14.6338 55.544 14.3218 54.764 14.3218 53.844C14.3218 52.932 14.6338 52.152 15.2578 51.504C15.8898 50.856 16.6738 50.532 17.6098 50.532C18.6338 50.532 19.4778 50.896 20.1418 51.624L19.2418 52.596C18.7378 52.068 18.1898 51.804 17.5978 51.804C17.0778 51.804 16.6418 52.004 16.2898 52.404C15.9458 52.796 15.7738 53.276 15.7738 53.844C15.7738 54.42 15.9498 54.904 16.3018 55.296C16.6618 55.688 17.1178 55.884 17.6698 55.884C18.2538 55.884 18.8018 55.62 19.3138 55.092L20.1898 55.956C19.8458 56.34 19.4698 56.636 19.0618 56.844C18.6618 57.044 18.1738 57.144 17.5978 57.144ZM24.3615 57.144C23.4015 57.144 22.6015 56.824 21.9615 56.184C21.3215 55.544 21.0015 54.764 21.0015 53.844C21.0015 52.924 21.3255 52.144 21.9735 51.504C22.6215 50.856 23.4255 50.532 24.3855 50.532C25.3455 50.532 26.1455 50.852 26.7855 51.492C27.4335 52.132 27.7575 52.916 27.7575 53.844C27.7575 54.756 27.4335 55.536 26.7855 56.184C26.1375 56.824 25.3295 57.144 24.3615 57.144ZM24.3855 55.884C24.9615 55.884 25.4255 55.688 25.7775 55.296C26.1295 54.904 26.3055 54.42 26.3055 53.844C26.3055 53.276 26.1215 52.796 25.7535 52.404C25.3855 52.004 24.9215 51.804 24.3615 51.804C23.7935 51.804 23.3335 52 22.9815 52.392C22.6295 52.784 22.4535 53.268 22.4535 53.844C22.4535 54.404 22.6375 54.884 23.0055 55.284C23.3735 55.684 23.8335 55.884 24.3855 55.884ZM29.3202 57V48.24H30.7722V57H29.3202ZM35.6818 57.144C34.7218 57.144 33.9218 56.824 33.2818 56.184C32.6418 55.544 32.3218 54.764 32.3218 53.844C32.3218 52.924 32.6458 52.144 33.2938 51.504C33.9418 50.856 34.7458 50.532 35.7058 50.532C36.6658 50.532 37.4658 50.852 38.1058 51.492C38.7538 52.132 39.0778 52.916 39.0778 53.844C39.0778 54.756 38.7538 55.536 38.1058 56.184C37.4578 56.824 36.6498 57.144 35.6818 57.144ZM35.7058 55.884C36.2818 55.884 36.7458 55.688 37.0978 55.296C37.4498 54.904 37.6258 54.42 37.6258 53.844C37.6258 53.276 37.4418 52.796 37.0738 52.404C36.7058 52.004 36.2418 51.804 35.6818 51.804C35.1138 51.804 34.6538 52 34.3018 52.392C33.9498 52.784 33.7738 53.268 33.7738 53.844C33.7738 54.404 33.9578 54.884 34.3258 55.284C34.6938 55.684 35.1538 55.884 35.7058 55.884ZM40.5565 57V50.664H42.0085V52.092C42.4565 51.012 43.2045 50.496 44.2525 50.544V52.08H44.1685C43.5125 52.08 42.9885 52.296 42.5965 52.728C42.2045 53.152 42.0085 53.772 42.0085 54.588V57H40.5565Z"
              fill="#B9C2EB"
            />
            <path
              d="M16.0252 40C16.343 40 16.6419 39.8489 16.8304 39.5931L25.7143 27.5325L12.2008 2.21176C11.7753 1.41454 10.5945 1.54579 10.3545 2.41698L0.34869 38.7344C0.173266 39.3711 0.652321 40 1.31277 40H16.0252Z"
              fill="url(#paint0_linear)"
            />
            <path
              d="M39.2278 2.21176C39.6532 1.41454 40.8341 1.54578 41.0741 2.41698L51.0799 38.7344C51.2553 39.3711 50.7763 40 50.1158 40H35.4034C35.0856 40 34.7867 39.8489 34.5982 39.5931L25.7143 27.5325L39.2278 2.21176Z"
              fill="#B9C2EB"
            />
            <defs>
              <linearGradient
                id="paint0_linear"
                x1="12.8571"
                y1="0"
                x2="12.8571"
                y2="40"
                gradientUnits="userSpaceOnUse"
              >
                <stop stop-color="#397EAA" />
                <stop offset="0.515625" stop-color="#91B1C8" />
                <stop offset="1" stop-color="#AD48D0" />
              </linearGradient>
            </defs>
          </svg>
        </a>
      </div>
      <div class="navbar-menu navbar-end">
        <div id="navbar-content" class="navbar-item">
          <div class="field is-grouped">
            <p class="control">
              <a class="button is-ghost dark-link" href="#about-nn-section">
                <span>
                  О нейросети
                </span>
              </a>
            </p>
            <p class="control">
              <a class="button is-ghost dark-link" href="#about-us-section">
                <span>
                  О нас
                </span>
              </a>
            </p>
            <p class="control">
              <a class="button is-ghost dark-link" href="#feedback-section">
                <span>
                  Обратная связь
                </span>
              </a>
            </p>
          </div>
        </div>
      </div>
    </nav>
    <div class="fullheight">
      <div class="main my-container" @scroll="onScroll">
        <section id="main-section" class="level columns">
          <div class="column is-half is-full-touch has-text-centered-touch">
            <h1 class="main-title is-size-2-mobile">
              Нейросетевое раскрашивание черно-белых фотографий
            </h1>
            <button class="start-button button" @click="start">
              <span class="text">Сделать фото цветным</span>
            </button>
          </div>
          <div
            class="column is-half is-flex is-flex-direction-row is-align-items-center is-hidden-touch is-hidden-desktop-only is-hidden-widescreen-only"
          >
            <figure class="image bird-image">
              <img src="./assets/images/bird.png" />
            </figure>
          </div>
        </section>
        <section id="about-nn-section" class="section">
          <h1 class="section-title has-text-centered mb-3">
            Как работает наша нейросеть?
          </h1>
          <h2 class="subtitle pl-3 has-text-justified">
            От других нейросетей, работающих с изображениями, наша отличается
            тем, что для неё важно расположение пикселей. У раскрашивающих
            нейросетей размер изображения или соотношение сторон остаётся
            неизменным. А у сетей других типов изображение искажается по мере
            приближения к окончательной версии.
          </h2>
          <h2 class="subtitle pl-3 has-text-justified">
            Слой пулинга с функцией максимума, применяемый в классифицирующих
            сетях, увеличивает плотность информации, но при этом искажает
            картинку. Он оценивает только информацию, а не макет изображения. А
            в раскрашивающих сетях для уменьшения ширины и высоты вдвое мы
            используем шаг 2 (stride of 2). Плотность информации тоже
            увеличивается, но картинка не искажается.
          </h2>
          <h2 class="subtitle pl-3 has-text-justified">
            Также наша нейросеть отличается от прочих слоями повышения
            дискретизации (upsampling) и сохранением соотношения сторон
            изображения. Классифицирующие сети заботятся только об итоговой
            классификации, поэтому постепенно уменьшают размер и качество
            картинки по мере её прогона через нейросеть.
          </h2>
          <image-compare
            before="https://psv4.userapi.com/c520036/u144579648/docs/d10/3d7df2ff482a/ChB.jpg?extra=8qJGAnU7-tKLm3ZfOGMyozYEf3vbwkPrSElj6yh_qpWsWq0R8rFbNcKeBJUMpgZT_Gbw53-I-5Rbe9EmNdZtkD4lFAGG_HDa-sMh-mGyttkqVBKkCjLlceXgF6yzpjsDJ8-UB0kwgDsc1C7rGDeFEn4"
            after="https://psv4.userapi.com/c520036/u144579648/docs/d41/906ac5986f8e/Tsvet.jpg?extra=c0WufRmRAu567msuKKSk7PPMg6bAD-UblFEu1Vn4OyOj5jZdJSpl-itTTzRD_iHATrmgsq_qI4Eunxb00KZuEQz85SE_a9j69-gEpt5FOfdw_NuNF1o-I7QThzPcNLvgXC4ORWEvVGgTV6IF40zc9v8"
          >
            <i aria-hidden="true" slot="icon-left">
              <svg style="width:24px;height:24px" viewBox="0 0 24 24">
                <path
                  fill="white"
                  d="M15.41,16.58L10.83,12L15.41,7.41L14,6L8,12L14,18L15.41,16.58Z"
                />
              </svg>
            </i>
            <i aria-hidden="true" slot="icon-right">
              <svg style="width:24px;height:24px" viewBox="0 0 24 24">
                <path
                  fill="white"
                  d="M8.59,16.58L13.17,12L8.59,7.41L10,6L16,12L10,18L8.59,16.58Z"
                /></svg></i
          ></image-compare>
        </section>
        <section id="about-us-section" class="section">
          <h1 class="section-title has-text-centered mb-3">
            Наша команда
          </h1>
          <div class="columns">
            <div class="column is-offset-1 is-4">
              <figure class="image">
                <img src="./assets/images/kats.jpg" />
              </figure>
              <h1 class="title mt-5 dark-link">Кацевалов Артем</h1>
              <h2 class="subtitle dark-link">Backend и Frontend разработчик</h2>
            </div>
            <div class="column is-4 is-offset-2">
              <figure class="image">
                <img src="./assets/images/uzbek.jpg" />
              </figure>
              <h1 class="title mt-5 dark-link">Амуров Артем</h1>
              <h2 class="subtitle dark-link">
                Дизайнер и разработчик нейросети
              </h2>
            </div>
          </div>
        </section>
        <section id="feedback-section" class="section columns">
          <div class="column is-6">
            <h1 class="section-title">
              Нашли ошибку или знаете, как улучшить наш сервис? Тогда,
              пожалуйста, оставьте свою почту
            </h1>
            <div>
              <input
                class="input is-large email-input"
                type="text"
                placeholder="Введите свой Email"
              />
              <button class="send-button button is-large is-fullwidth">
                Отправить
              </button>
            </div>
          </div>
          <div class="column is-4 is-offset-2">
            <h1 class="section-title">
              Наши контакты
            </h1>
            <a
              class="is-flex is-flex-direction-row is-align-content-center mt-5"
              href="https://vk.com/askatsevalov"
              target="_blank"
              ><svg style="width:24px;height:24px" viewBox="0 0 24 24">
                <path
                  fill="currentColor"
                  d="M15.07 2H8.93C3.33 2 2 3.33 2 8.93V15.07C2 20.67 3.33 22 8.93 22H15.07C20.67 22 22 20.67 22 15.07V8.93C22 3.33 20.67 2 15.07 2M18.15 16.27H16.69C16.14 16.27 15.97 15.82 15 14.83C14.12 14 13.74 13.88 13.53 13.88C13.24 13.88 13.15 13.96 13.15 14.38V15.69C13.15 16.04 13.04 16.26 12.11 16.26C10.57 16.26 8.86 15.32 7.66 13.59C5.85 11.05 5.36 9.13 5.36 8.75C5.36 8.54 5.43 8.34 5.85 8.34H7.32C7.69 8.34 7.83 8.5 7.97 8.9C8.69 11 9.89 12.8 10.38 12.8C10.57 12.8 10.65 12.71 10.65 12.25V10.1C10.6 9.12 10.07 9.03 10.07 8.68C10.07 8.5 10.21 8.34 10.44 8.34H12.73C13.04 8.34 13.15 8.5 13.15 8.88V11.77C13.15 12.08 13.28 12.19 13.38 12.19C13.56 12.19 13.72 12.08 14.05 11.74C15.1 10.57 15.85 8.76 15.85 8.76C15.95 8.55 16.11 8.35 16.5 8.35H17.93C18.37 8.35 18.47 8.58 18.37 8.89C18.19 9.74 16.41 12.25 16.43 12.25C16.27 12.5 16.21 12.61 16.43 12.9C16.58 13.11 17.09 13.55 17.43 13.94C18.05 14.65 18.53 15.24 18.66 15.65C18.77 16.06 18.57 16.27 18.15 16.27Z"
                /></svg
              ><span class="ml-3"></span>ВКонтакте</a
            >
            <a
              class="is-flex is-flex-direction-row is-align-content-center mt-3"
              href="https://facebook.com/askatsevalov"
              target="_blank"
              ><svg style="width:24px;height:24px" viewBox="0 0 24 24">
                <path
                  fill="currentColor"
                  d="M12 2.04C6.5 2.04 2 6.53 2 12.06C2 17.06 5.66 21.21 10.44 21.96V14.96H7.9V12.06H10.44V9.85C10.44 7.34 11.93 5.96 14.22 5.96C15.31 5.96 16.45 6.15 16.45 6.15V8.62H15.19C13.95 8.62 13.56 9.39 13.56 10.18V12.06H16.34L15.89 14.96H13.56V21.96A10 10 0 0 0 22 12.06C22 6.53 17.5 2.04 12 2.04Z"
                /></svg
              ><span class="ml-3"></span>Facebook</a
            >
            <a
              class="is-flex is-flex-direction-row is-align-content-center mt-3"
              href="https://github.com/askatsevalov"
              target="_blank"
              ><svg style="width:24px;height:24px" viewBox="0 0 24 24">
                <path
                  fill="currentColor"
                  d="M12,2A10,10 0 0,0 2,12C2,16.42 4.87,20.17 8.84,21.5C9.34,21.58 9.5,21.27 9.5,21C9.5,20.77 9.5,20.14 9.5,19.31C6.73,19.91 6.14,17.97 6.14,17.97C5.68,16.81 5.03,16.5 5.03,16.5C4.12,15.88 5.1,15.9 5.1,15.9C6.1,15.97 6.63,16.93 6.63,16.93C7.5,18.45 8.97,18 9.54,17.76C9.63,17.11 9.89,16.67 10.17,16.42C7.95,16.17 5.62,15.31 5.62,11.5C5.62,10.39 6,9.5 6.65,8.79C6.55,8.54 6.2,7.5 6.75,6.15C6.75,6.15 7.59,5.88 9.5,7.17C10.29,6.95 11.15,6.84 12,6.84C12.85,6.84 13.71,6.95 14.5,7.17C16.41,5.88 17.25,6.15 17.25,6.15C17.8,7.5 17.45,8.54 17.35,8.79C18,9.5 18.38,10.39 18.38,11.5C18.38,15.32 16.04,16.16 13.81,16.41C14.17,16.72 14.5,17.33 14.5,18.26C14.5,19.6 14.5,20.68 14.5,21C14.5,21.27 14.66,21.59 15.17,21.5C19.14,20.16 22,16.42 22,12A10,10 0 0,0 12,2Z"
                /></svg
              ><span class="ml-3"></span>Github</a
            >
          </div>
        </section>
        <footer>
          <div class="content p-5">
            <p>
              © 2color | 2021 | Кацевалов Артем и Амуров Артём
            </p>
          </div>
        </footer>
      </div>
    </div>

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
                v-model="showOutput"
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
        name: "",
      },
      outputPhoto: {
        name: "",
      },
      showOutput: true,
      showNavbarShadow: false,
    };
  },
  computed: {
    photoUrl() {
      return `/storage/${
        this.showOutput ? this.outputPhoto.name : this.inputPhoto.name
      }`;
    },
  },
  methods: {
    onScroll() {
      const currentScrollPosition = document.getElementsByClassName("main")[0]
        .scrollTop;
      if (currentScrollPosition < 0) {
        return;
      }
      this.showNavbarShadow = currentScrollPosition > 0;
    },
    start() {
      this.readyToColorize = false;
      this.step = "load";
    },
    async colorize() {
      this.step = "wait";
      this.showOutput = true;
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
@font-face {
  font-family: "Gilroy";
  font-weight: 400;
  src: local("Gilroy"),
    url(./assets/fonts/Gilroy-Regular.ttf) format("truetype");
}

@font-face {
  font-family: "Gilroy";
  font-weight: 900;
  src: local("Gilroy"),
    url(./assets/fonts/Gilroy-Extra-Bold.ttf) format("truetype");
}
html {
  overflow-y: hidden !important;
  & * {
    font-family: "Gilroy" !important;
  }
}
.bottom-border {
  box-shadow: 0px 0px 4px 1px darkgray;
  transition: 0.2s;
}
.dark-link {
  color: #1f2c58 !important;
  font-size: 22px !important;
  line-height: 20px !important;
}
.my-container {
  @media screen and (min-width: 768px) {
    padding-right: 80px;
    padding-left: 80px;
  }
  overflow-y: auto;
  scroll-behavior: smooth;
  color: #1f2c58;
}
.main-title {
  font-style: normal;
  font-weight: 900;
  font-size: 100px;
  line-height: 100px;
  width: 100%;
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
  border: 2px dashed #b9c2eb;
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
.navbar {
  height: 120px;
}
#main-section {
  margin-top: 50px;
}
#about-nn-section {
  margin-top: 150px;
}
.logo {
  width: 120px;
  height: 100%;
}
.main {
  overflow-y: auto;
  overflow-x: hidden;
  height: 100%;
  flex: 1;
}

.main::-webkit-scrollbar {
  width: 0.25rem;
}

.main::-webkit-scrollbar-track {
  background: ghostwhite;
}

.main::-webkit-scrollbar-thumb {
  background: hsl(0, 0%, 29%);
}
.fullheight {
  height: calc(100vh - 120px);
  margin-top: 120px;
}
.section-title {
  font-size: 40px;
  font-weight: 900;
}
.email-input {
  margin-top: 40px;
  background-color: #e7e8ef !important;
  border: none !important;
}
.send-button {
  margin-top: 24px;
  background-color: #3981aa !important;
  color: #fff !important;
}
</style>
