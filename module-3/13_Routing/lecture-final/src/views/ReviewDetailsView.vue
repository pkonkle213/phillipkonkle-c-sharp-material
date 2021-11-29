<template>
  <review-list-item v-bind:review="review" />
</template>

<script>
import ReviewListItem from '../components/ReviewListItem.vue';

export default {
    name: 'ReviewDetails',
    components: {
        ReviewListItem
    },
    computed: {
        review() {
            const reviewerName = this.$route.params.reviewer;

            return this.$store.state.reviews.find(r => r.reviewer === reviewerName);
        }
    }
}
</script>

<style>
    img {
        height: 37px;
    }
</style>