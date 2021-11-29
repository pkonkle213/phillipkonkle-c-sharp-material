<template>
    <div class="well" 
        v-on:click="filterToStarRating(rating)" 
        v-bind:class="{active: $store.state.ratingToFilterTo === rating}" 
        v-bind:title="toolTip">
    <span class="amount">{{ numberOfReviews }}</span>
        {{ rating }} Star Review{{ numberOfReviews === rating ? '' : 's' }}
    </div>  
</template>

<script>
export default {
    props: {
        rating: Number
    },
    methods: {
        filterToStarRating(rating) {
            console.log('Filter to rating', rating);

            this.$store.commit('SET_FILTER', rating);
        },        
    },
    computed: {
        toolTip() {
            return 'Show ' + this.rating + ' Star Reviews';
        },
        numberOfReviews() {
            return this.$store.state.reviews.reduce((currentCount, review) => {
                return currentCount + (review.rating === this.rating);
            }, 0);
        },        
    }
}
</script>

<style>
div.main div.well-display div.well span.amount {
  color: darkslategray;
  display: block;
  font-size: 2.5rem;
}
</style>