// Import dependencies
import Vue from 'vue'
import VueYoutube from 'vue-youtube'
import Router from 'vue-router'
import BootstrapVue from 'bootstrap-vue'
import 'bootstrap/dist/css/bootstrap.css'
import 'bootstrap-vue/dist/bootstrap-vue.css'
import Vuetify from 'vuetify'
import 'vuetify/dist/vuetify.min.css'

Vue.use(Router)
Vue.use(VueYoutube)
Vue.use(BootstrapVue); 
Vue.use(Vuetify)

// Import pages
import LandingPage from '@/views/LandingPage'
import YoutubePage from '@/views/YoutubePage'
import ResultPage from '@/views/ResultPage'
import CategoryPage from '@/views/CategoryPage'
import QuestionPage from '@/views/QuestionPage'

// Here we create the routes
// First you need to import the component, then specify the name of the route and which component to bind it to
export default new Router({
  routes: [
    {
      path: '/',
      name: 'LandingPage',
      component: LandingPage
    },
    {
      path: '/YoutubePage',
      name: 'YoutubePage',
      component: YoutubePage
    },
    {
      path: '/ResultPage',
      name: 'ResultPage',
      component: ResultPage
    },
    {
      path: '/CategoryPage',
      name: 'CategoryPage',
      component: CategoryPage
    },
    {
      path: '/QuestionPage/:category',
      name: 'QuestionPage',
      component: QuestionPage
    },

  ]
})