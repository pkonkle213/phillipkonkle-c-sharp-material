<template>
  <div class="main">
    <!-- Page Header - This could be a component -->
    <review-header v-bind:productName="name" 
                   v-bind:productDesc="description" />

    <!-- Filter / data controls -->
    <p class="help">Click on a rating below to filter the list of reviews. Click on the Average Rating button to show all reviews.</p>
    <div class="well-display">
      <div class="well" @click.stop="clearFilter" title="Show all reviews">
        <span class="amount">{{ averageRating }}</span>
        Average Rating
      </div>

      <!-- These should be a component -->
      <div class="well" 
           v-on:click="filterToStarRating(1)" 
           :class="{active: ratingToFilterTo === 1}" 
           title="Show 1 Star Reviews">
        <span class="amount">{{ numberOfOneStarReviews }}</span>
        1 Star Review{{ numberOfOneStarReviews === 1 ? '' : 's' }}
      </div>

      <div class="well" 
           v-on:click="filterToStarRating(2)" 
           v-bind:class="{active: ratingToFilterTo === 2}"
           title="Show 2 Star Reviews">
        <span class="amount">{{ numberOfTwoStarReviews }}</span>
        2 Star Review{{ numberOfTwoStarReviews === 1 ? '' : 's' }}
      </div>

      <div class="well" 
           v-on:click="filterToStarRating(3)" 
           v-bind:class="{active: ratingToFilterTo === 3}"  
           title="Show 3 Star Reviews">
        <span class="amount">{{ numberOfThreeStarReviews }}</span>
        3 Star Review{{ numberOfThreeStarReviews === 1 ? '' : 's' }}
      </div>

      <div class="well" 
           v-on:click.stop="filterToStarRating(4)" 
           v-bind:class="{active: ratingToFilterTo === 4}"  
           title="Show 4 Star Reviews">
        <span class="amount">{{ numberOfFourStarReviews }}</span>
        4 Star Review{{ numberOfFourStarReviews === 1 ? '' : 's' }}
      </div>

      <div class="well" 
           v-on:click.stop="filterToStarRating(5)" 
           v-bind:class="{active: ratingToFilterTo === 5}"  
           title="Show 5 Star Reviews">
        <span class="amount">{{ numberOfFiveStarReviews }}</span>
        5 Star Review{{ numberOfFiveStarReviews === 1 ? '' : 's' }}
      </div>
    </div>

    <add-review-form />

    <!-- Reviews list - This should be a component -->
    <review 
            v-for="r in filteredReviews"
            v-bind:key="r.id"
            v-bind:review="r" />
  </div>
</template>

<script>
import ReviewHeader from './ReviewHeader.vue';
import Review from './Review.vue';
import AddReviewForm from './AddReviewForm.vue';

export default {
  components: {
    ReviewHeader,
    Review,
    AddReviewForm
  },
  data() {
    return {
      name: "Cigar Parties for Dummies",
      description:
        "Host and plan the perfect cigar party for all of your squirrelly friends.",
      ratingToFilterTo: undefined,
    };
  },
  methods: {
    clearFilter() {
      console.log('Clear filter clicked');
      this.ratingToFilterTo = undefined; // Clear out our filter
    },
    filterToStarRating(rating) {
      console.log('Filter to rating', rating);
      this.ratingToFilterTo = rating;
    },
  },
  computed: {
    reviews() {
      // this.$store is the object we export from store/index.js
      return this.$store.state.reviews;
    },
    filteredReviews() {
      return this.reviews.filter(rev => {
        return this.ratingToFilterTo === undefined || rev.rating === this.ratingToFilterTo;
      });
    },
    averageRating() {
      let sum = this.reviews.reduce((currentSum, review) => {
        return currentSum + review.rating;
      }, 0);
      return (sum / this.reviews.length).toFixed(2);
    },
    numberOfOneStarReviews() {
      return this.reviews.reduce((currentCount, review) => {
        return currentCount + (review.rating === 1);
      }, 0);
    },
    numberOfTwoStarReviews() {
      return this.reviews.reduce((currentCount, review) => {
        return currentCount + (review.rating === 2);
      }, 0);
    },
    numberOfThreeStarReviews() {
      return this.reviews.reduce((currentCount, review) => {
        return currentCount + (review.rating === 3);
      }, 0);
    },
    numberOfFourStarReviews() {
      return this.reviews.reduce((currentCount, review) => {
        return currentCount + (review.rating === 4);
      }, 0);
    },
    numberOfFiveStarReviews() {
      return this.reviews.reduce((currentCount, review) => {
        return currentCount + (review.rating === 5);
      }, 0);
    }
  }
};
</script>

<style>
div.main {
  margin: 1rem 0;
}

div.main div.well-display {
  display: flex;
  justify-content: space-around;
}

div.main div.well-display div.well {
  display: inline-block;
  width: 15%;
  border: 1px black solid;
  border-radius: 6px;
  text-align: center;
  margin: 0.25rem;
}

div.main div.well-display div.well span.amount {
  color: darkslategray;
  display: block;
  font-size: 2.5rem;
}

div.main div.review {
  border: 1px black solid;
  border-radius: 6px;
  padding: 1rem;
  margin: 10px;
}

div.main div.review.favorited {
  background-color: lightyellow;
}

div.main div.review div.rating {
  height: 2rem;
  display: inline-block;
  vertical-align: top;
  margin: 0 0.5rem;
}

div.main div.review div.rating img {
  height: 100%;
}

div.main div.review p {
  margin: 20px;
}

div.main div.review h3 {
  display: inline-block;
}

div.main div.review h4 {
  font-size: 1rem;
}

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
div.well.active {
  background-color: #b5b5ff;
}
.help {
  font-size: 75%;
  color: rgb(121, 121, 121);
}
div.well:hover {
  background-color: lemonchiffon;
  cursor: pointer;
}
</style>