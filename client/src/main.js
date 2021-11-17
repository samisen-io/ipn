import { createApp } from 'vue'
import App from './App.vue'
import "bootstrap/dist/css/bootstrap.min.css"
import "bootstrap"
import VueGeolocation from 'vue3-geolocation';
createApp(App).use(VueGeolocation).mount('#app')
