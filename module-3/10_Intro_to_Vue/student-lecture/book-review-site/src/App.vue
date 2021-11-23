<template>
  <div id="app">
   <h1>Hello Vue.js</h1>
   <h2>Intro</h2>
   <p>This is a paragraph</p>
    <product-reviews />
    <!-- <HelloWorld msg="Welcome to your Vue.js App"/> -->
  </div>
</template>

<script>
// import HelloWorld from './components/HelloWorld.vue'
import ProductReviews from './components/ProductReviews.vue'

export default {
    name: 'App',
    components: {
        // HelloWorld,
        ProductReviews
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
  margin-top: 60px;
}
</style>
