<template>
  <div id="app">
    <!-- Navigation Header -->
    <div id="nav">     
      <!-- <a href="/" class="router-link-exact-active">List View</a> | -->
      <router-link v-bind:to="{name: 'Home'}">List View</router-link>
      <!-- <a href="/table">Table View</a> | -->
      <router-link v-bind:to="{name: 'Table'}"> | Table View</router-link>
      <!-- <a href="/add-review">Add Review</a> | -->
      <router-link v-bind:to="{name: 'New'}"> | Add Review</router-link>
      <!-- <a href="/about">About this Application</a> -->
      <router-link v-bind:to="{name: 'About'}"> | About</router-link>
    </div>

    <!--Currently active page - this gets replaced by the active page in a route -->
    <!-- <product-review-view /> -->
    <router-view />
  </div>
</template>

<script>
// import ProductReviewView from './views/ProductReviewView.vue'

export default {
  components: {
    // ProductReviewView
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
