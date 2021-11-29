import Vue from 'vue'
import VueRouter from 'vue-router'

import ProductReviewView from '../views/ProductReviewView.vue';
import About from '../views/About.vue';
import NotFound from '../views/NotFound.vue';
import AddView from '../views/AddView.vue';
import TableView from '../views/TableView.vue';
import ReviewDetailsView from '../views/ReviewDetailsView.vue';

Vue.use(VueRouter)

// Things people can navigate to
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
    component: TableView
  },
  {
    path: '/reviews/:reviewer',
    name: 'ReviewDetails',
    component: ReviewDetailsView
  },
  {
    path: '/new',
    name: 'New',
    component: AddView
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
