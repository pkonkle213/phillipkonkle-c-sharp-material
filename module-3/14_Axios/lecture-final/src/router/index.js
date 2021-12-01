import Vue from 'vue'
import VueRouter from 'vue-router'
import Home from '../views/Home.vue'
import BugList from '../views/BugsList.vue'
import BugDetails from '../views/BugDetails.vue'
import AddBug from '../views/AddBug.vue'
import NotFound from '../views/NotFound.vue'
import BugEdit from '../views/EditBug.vue'

Vue.use(VueRouter)

const routes = [
  {
    path: '/',
    name: 'Home',
    component: Home
  },
  {
    path: '/bugs',
    name: 'BugsList',
    component: BugList
  },
  {
    path: '/bugs/new',
    name: 'NewBug',
    component: AddBug,
  },
  {
    path: '/bugs/:id/edit',
    name: 'BugEdit',
    component: BugEdit
  },
  {
    path: '/bugs/:id',
    name: 'BugDetails',
    component: BugDetails,
  },
  {
    path: '/about',
    name: 'About',
    // route level code-splitting
    // this generates a separate chunk (about.[hash].js) for this route
    // which is lazy-loaded when the route is visited.
    component: () => import(/* webpackChunkName: "about" */ '../views/About.vue')
  },
  {
    path: '*',
    name: 'NotFound',
    component: NotFound
  }
]

const router = new VueRouter({
  mode: 'history',
  base: process.env.BASE_URL,
  routes
})

export default router
