<template>
  <book-details v-bind:book="book" />
</template>

<script>
import BookDetails from '../components/BookDetails.vue';

export default {
    name: 'SelectedBook',
    components: {
        BookDetails
    },
    computed: {
        book() {
            const bookIsbn = this.$route.params.isbn;
            return this.$store.state.books.find(b => b.isbn === bookIsbn);
        }
    }
}
</script>

<style>

</style>