<template>
    <div
      v-bind:class="{ 
            review: true,
            favorited: review.favorited 
          }"
    >
      <h4>{{ review.reviewer }}</h4>
      <div class="rating">
        <img
          src="../assets/star.png"
          v-bind:title="review.rating + ' Star Review'"
          class="ratingStar"
          v-for="n in review.rating"
          v-bind:key="n"
        />
      </div>
      <h3>{{ review.title }}</h3>

      <p>{{ review.review }}</p>

      <p>
        Favorite?
        <input type="checkbox" v-on:change="handleChecked($event)" />
      </p>
    </div>
</template>

<script>
// Need review
export default {
    props: {
        review: Object
    },
    methods: {
      handleChecked(event) {

        const isChecked = event.target.checked;

        console.log('Checked: ' + isChecked + " for reviewer " + 
          this.review.reviewer);

        // Reviewer
        // Whether or not it should be a favorited review
        let payload = {
          reviewer: this.review.reviewer,
          isFavorite: isChecked
        }

        this.$store.commit('CHANGE_FAVORITE', payload);
      }
    }
}
</script>

<style>

</style>