<template>
    <div
      class="review"
      v-bind:class="{ favorited: review.favorited }">
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

      <button v-if="!review.favorited"
              v-on:click="markAsFavorite">Mark as Favorite</button>
    </div>
</template>

<script>
export default {
    props: {
        review: Object
    },
    methods: {
        markAsFavorite() {
            this.$store.commit('MARK_AS_FAVORITE', this.review.reviewer)
        }
    }
}
</script>

<style>
div.main .review {
  border: 1px black solid;
  border-radius: 6px;
  padding: 1rem;
  margin: 10px;
}

div.main .review.favorited {
  background-color: lightyellow;
}

div.main .review div.rating {
  height: 2rem;
  display: inline-block;
  vertical-align: top;
  margin: 0 0.5rem;
}

div.main .review div.rating img {
  height: 100%;
}

div.main .review p {
  margin: 20px;
}

div.main .review h3 {
  display: inline-block;
}

div.main .review h4 {
  font-size: 1rem;
}

</style>