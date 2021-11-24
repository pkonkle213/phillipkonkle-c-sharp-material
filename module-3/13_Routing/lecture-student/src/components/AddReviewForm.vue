<template>
    <form v-on:submit.prevent="handleSave"
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
      <input type="button" value="Cancel" v-on:click="$store.commit('TOGGLE_ADD_FORM_VISIBLE')">
    </form>  
</template>

<script>
export default {
    data() {
        return {
            newReview: {
                rating: 1,
                title: '', // v-model="newReview.title"
                review: '',
                reviewer: ''
            },
        };
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

            // Add the new review to the reviews array (at the beginning)
            //this.$store.state.reviews.splice(0, 0, reviewToAdd); // Start at beginning, delete nothing, add the review
            this.$store.commit('ADD_REVIEW', reviewToAdd);

            // Clear the form for the next addition (and prevents odd bugs in adding data multiple times)
            this.newReview = {
                rating: 1,
                title: '',
                review: '',
                reviewer: ''
            }

            // Hide the form
            this.$store.commit('TOGGLE_ADD_FORM_VISIBLE');
        },        
    }
}
</script>

<style>
div.form-element {
  margin-top: 10px;
}
div.form-element > label {
  display: block;
}
div.form-element > input, div.form-element > select {
  height: 30px;
  width: 300px;
}
div.form-element > textarea {
  height: 60px;
  width: 300px;
}
form > input[type=button] {
  width: 100px;
}
form > input[type=submit] {
  width: 100px;
  margin-right: 10px;
}
</style>