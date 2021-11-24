<template>
  <div id="app">
    <div id="nav">     
      <a href="/" class="router-link-exact-active">List View</a> |
      <a href="/table">Table View</a> |
      <a href="/add-review">Add Review</a> |
      <a href="/about">About this Application</a>
    </div>
    <product-review-view />
  </div>
</template>

<script>
import ProductReviewView from './views/ProductReviewView.vue'

export default {
  components: {
    ProductReviewView
  }
}
</script>

<style>
#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
  max-width: 800px;
  margin: 60px auto 0 auto;
}

#nav {
  padding: 30px;
}

#nav a {
  font-weight: bold;
  color: #2c3e50;
}

#nav a.router-link-exact-active {
  color: #42b983;
}
</style>
