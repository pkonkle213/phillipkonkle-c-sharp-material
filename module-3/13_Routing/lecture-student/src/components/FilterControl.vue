<template>
    <div class="well-display">
      <!-- The average button -->
      <div class="well" 
           v-on:click="clearFilter" 
           title="Show all reviews">
        <span class="amount">{{ averageRating }}</span>
        Average Rating
      </div>

      <!-- Add 5 filter buttons -->
      <filter-button v-for="i of 5"
                     v-bind:key="i"
                     v-bind:rating="i" />
    </div>  
</template>

<script>
import FilterButton from './FilterButton.vue'

export default {
  components: {
      FilterButton
  },
  methods: {
    clearFilter() {
      console.log('Clear filter clicked');

      // Commit a mutation named 'CLEAR_FILTER'. This lives in Vuex's mutations.
      this.$store.commit('CLEAR_FILTER');
    },
  },
  computed: {
    averageRating() {
      let sum = this.$store.state.reviews.reduce((currentSum, review) => {
        return currentSum + review.rating;
      }, 0);
      return (sum / this.$store.state.reviews.length).toFixed(2);
    }
  }
}
</script>

<style>
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
div.well:hover {
  background-color: lemonchiffon;
  cursor: pointer;
}
</style>