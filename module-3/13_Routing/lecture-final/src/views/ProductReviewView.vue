<template>
  <div class="main">
    <!-- Page Header -->
    <product-info v-bind:name="$store.state.productName" 
                  v-bind:description="$store.state.productDescription" />

    <!-- Filter / data controls -->
    <p class="help">Click on a rating below to filter the list of reviews. Click on the Average Rating button to show all reviews.</p>

    <!-- This holds everything related to filtering -->
    <filter-control />

    <!-- Show Add Item -->
    <a href="#" 
       v-if="!$store.state.isAddFormVisible" 
       v-on:click.prevent="$store.commit('TOGGLE_ADD_FORM_VISIBLE')">
       Add New Item
    </a>

    <!-- Add new items form -->
    <add-review-form v-show="$store.state.isAddFormVisible" />

    <!-- Reviews list - This should be a component -->
    <review-list-item v-for="rev in filteredReviews"
                      v-bind:key="rev.reviewer"
                      v-bind:review="rev" />

  </div>
</template>

<script>
import ProductInfo from '../components/ProductInfo.vue'
import ReviewListItem from '../components/ReviewListItem.vue'
import AddReviewForm from '../components/AddReviewForm.vue'
import FilterControl from '../components/FilterControl.vue'

export default {
  components: {
    ProductInfo,
    ReviewListItem,
    AddReviewForm,
    FilterControl
  },
  computed: {
    filteredReviews() {
      return this.$store.state.reviews.filter(rev => {
        let filterRating = this.$store.state.ratingToFilterTo;
        return filterRating === undefined || rev.rating === filterRating;
      });
    }
  }
};
</script>

<style scoped>
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