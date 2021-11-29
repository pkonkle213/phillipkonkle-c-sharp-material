<template>
    <section>
    <!-- Show Add Item -->
    <a href="#" 
       v-if="!isAddFormVisible" 
       v-on:click.prevent="isAddFormVisible = true">
       Add New Item
    </a>

    <!-- Add new items form -->
    <form v-show="isAddFormVisible"
          v-on:submit.prevent="handleSave"
      > <!-- v-show keeps it in the DOM, but adds display: none. This is ALWAYS a good idea for forms -->
      <div class="form-element">
        <label for="reviewer">Name:</label>
        <input id="reviewer" type="text" v-model="newReview.reviewer" />
      </div>
      <input type="hidden" value="YourUserIDGoesHere" />
      <div class="form-element">
        <label for="title">Title:</label>
        <input id="title" type="text" v-model="newReview.title" />
      </div>
      <div class="form-element">
        <label for="rating">Rating:</label>
        <select id="rating" v-model.number="newReview.rating">
          <option value="1">1 Star</option>
          <option value="2">2 Stars</option>
          <option value="3">3 Stars</option>
          <option value="4">4 Stars</option>
          <option value="5">5 Stars</option>
        </select>
      </div>
      <div class="form-element">
        <label for="review">Review:</label>
        <textarea id="review" v-model="newReview.review"></textarea>
      </div>
      <input type="submit" value="Save" v-bind:disabled="isSaveDisabled"> <!-- v-on:click.prevent="handleSave" -->
      <input type="button" value="Cancel" v-on:click="isAddFormVisible = false">
    </form>
    </section>
</template>

<script>
export default {
    data() {
        return {
            isAddFormVisible: false,
            newReview: {}
        }
    },
    computed: {
        isSaveDisabled() {
            return this.newReview.title === '';
        },
    },
    methods: {
      handleSave(event) {
        console.log('Save was clicked!', event);

        // Identify an object representing the new review
        let reviewToAdd = this.newReview;

        // Add the new review to the reviews array
        console.log(reviewToAdd);
        this.$store.commit('REVIEW_ADDED', reviewToAdd);

        // Clear the form for the next addition (and prevents odd bugs in adding data multiple times)
        this.newReview = {
            rating: 1,
            title: '',
            review: '',
            reviewer: ''
        }

        // Hide the form
        this.isAddFormVisible = false;
      },
    }
}
</script>

<style>

</style>