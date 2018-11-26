import Vue from 'vue'
import VueYoutube from 'vue-youtube'
import Router from 'vue-router'
import MainPage from '@/components/MainPage'
import YoutubePage from '@/components/Youtube/YoutubePage'

Vue.use(Router)
Vue.use(VueYoutube)

// Here we create the routes
// First you need to import the component, then specify the name of the route and which component to bind it to
export default new Router({
  routes: [
    {
      path: '/',
      name: 'MainPage',
      component: MainPage
    },
    {
      path: '/YoutubePage',
      name: 'YoutubePage',
      component: YoutubePage
    }
  ]
})
