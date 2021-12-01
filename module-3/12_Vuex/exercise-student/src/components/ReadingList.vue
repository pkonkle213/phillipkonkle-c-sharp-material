<template>
  <div class="book-container">
    <book-card  v-for="b in books" v-bind:key="b.isbn" v-bind:book="b"/>
  </div>
</template>

<script>
import BookCard from './BookCard.vue';
export default {
  components: {
    BookCard,
  },
  name: 'reading-list',
  computed: {
    books() {
      return this.$store.state.books;
    }
  }
}
</script>

<style>
.book-container {
    display:flex;
    justify-content: space-evenly;
    flex-wrap: wrap;
}
</style>