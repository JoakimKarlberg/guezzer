// Import dependencies
import Vue from 'vue'
import VueYoutube from 'vue-youtube'
import Router from 'vue-router'
import Vuetify from 'vuetify'
import 'vuetify/dist/vuetify.min.css'

Vue.use(Router)
Vue.use(VueYoutube)
Vue.use(Vuetify)

// Import pages
import LandingPage from '@/views/LandingPage'
import ResultPage from '@/views/ResultPage'
import CategoryPage from '@/views/CategoryPage'
import QuestionPage from '@/views/QuestionPage'
import TopListPage from '@/views/TopListPage'

// Here we create the routes
// First you need to import the component, then specify the name of the route and which component to bind it to
export default new Router({
  mode: 'history',
  routes: [
    {
      path: '/',
      name: 'LandingPage',
      component: LandingPage
    },
    {
      path: '/begin-quiz/',
      name: 'CategoryPage',
      component: CategoryPage
    },
    {
      path: '/question-for-category/:category/',
      name: 'QuestionPage',
      component: QuestionPage
    },
    {
      path: '/result-for-category/:category/',
      name: 'ResultPage',
      component: ResultPage
    },
    {
      path: '/highscores-for-all-categories/',
      name: 'TopListPage',
      component: TopListPage
    }
  ]
})