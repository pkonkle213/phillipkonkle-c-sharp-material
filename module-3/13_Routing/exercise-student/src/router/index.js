import Vue from 'vue';
import VueRouter from 'vue-router';

import Home from '../views/Home.vue';
import MyBooks from '../views/MyBooks.vue';
import NewBook from '../views/NewBook.vue';
import SelectedBook from '../views/SelectedBook.vue';

Vue.use(VueRouter);

const routes = [
  {
    path: '/',
    name: 'Home',
    component: Home
  },
  {
    path: '/myBooks',
    name: 'MyBooks',
    component: MyBooks
  },
  {
    path: '/addBook',
    name: 'NewBook',
    component: NewBook
  },
  {
    path: '/book/:isbn',
    name: 'SelectedBook',
    component: SelectedBook
  },
];

const router = new VueRouter({
  mode: 'history',
  routes
});

export default router;
