import Vue from 'vue'
import './plugins/axios'
import App from './App.vue'

import 'bulma/css/bulma.min.css';
import 'bulma-switch/dist/css/bulma-switch.min.css'
import 'vue2-dropzone/dist/vue2Dropzone.min.css';

Vue.config.productionTip = false

new Vue({
  render: h => h(App),
}).$mount('#app')
