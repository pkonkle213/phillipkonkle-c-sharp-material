import Vue from 'vue'
import VueRouter from 'vue-router'

import ProductReviewView from '../views/ProductReviewView.vue';
import About from '../views/About.vue';
import NotFound from '../views/NotFound.vue';
import Table from '../views/TableView.vue';
import New from '../views/AddView.vue';

Vue.use(VueRouter)

const routes = [
  {
    path: '/',
    name: 'Home',
    component: ProductReviewView
  },
  {
    path: '/about',
    name: 'About',
    component: About
  },
  {
    path: '/table',
    name: 'Table',
    component: Table
  },
  {
    path: '/new',
    name: 'New',
    component: New
  },
  {
    path: '*', // * means anything matches this
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
