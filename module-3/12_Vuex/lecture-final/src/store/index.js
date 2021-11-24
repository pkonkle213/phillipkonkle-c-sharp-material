import Vue from 'vue'
import Vuex from 'vuex'

Vue.use(Vuex)

export default new Vuex.Store({
  
  // This will scold us if we try to use Vuex incorrectly
  strict: true, // Set to false when you actually ship your application

  // State is the shared data the components have access to
  state: {
    isVueMagical: false,
    reviews: [
      {
        reviewer: "Malcolm Gladwell",
        title: "What a book!",
        review: "It certainly is a book. I mean, I can see that. Pages kept together with glue and there's writing on it, in some language.",
        rating: 3,
        favorited: false
      },
      {
        reviewer: "Tim Ferriss",
        title: "Had a cigar party started in less than 4 hours.",
        review: "It should have been called the four hour cigar party. That's amazing. I have a new idea for muse because of this.",
        rating: 4,
        favorited: false
      },
      {
        reviewer: "Ramit Sethi",
        title: "What every new entrepreneurs needs. A door stop.",
        review: "When I sell my courses, I'm always telling people that if a book costs less than $20, they should just buy it. If they only learn one thing from it, it was worth it. Wish I learned something from this book.",
        rating: 1,
        favorited: false
      },
      {
        reviewer: "Gary Vaynerchuk",
        title: "And I thought I could write",
        review: "There are a lot of good, solid tips in this book. I don't want to ruin it, but prelighting all the cigars is worth the price of admission alone.",
        rating: 3,
        favorited: false
      }
    ]
  },

  // Mutations are special methods that respond to events by modifying the state
  mutations: {
    REVIEW_ADDED(state, newReview) {
      state.reviews.unshift(newReview);
    },
    CHANGE_FAVORITE(state, payload) {
      let review = state.reviews.find(r => r.reviewer === payload.reviewer);

      if (review) {
        review.favorited = payload.isFavorite;
      }
    }
  }
})
