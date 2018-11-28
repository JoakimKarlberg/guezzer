import Vue from 'vue'
import VueYoutube from 'vue-youtube'
import Router from 'vue-router'
import LandingPage from '@/views/LandingPage'
import YoutubePage from '@/views/YoutubePage'
import ResultPage from '@/views/ResultPage'
import BootstrapVue from 'bootstrap-vue'

Vue.use(BootstrapVue);

Vue.use(Router)
Vue.use(VueYoutube)
Vue.use(LandingPage)

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
    }

  ]
})
