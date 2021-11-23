<template>
  <section>
      <h2>Product Reviews for {{ productName }}</h2>
      <p>
          There are {{ numReviews }} reviews for this product with an 
          average review score of {{ averageScore.toFixed(2) }}
      </p>

      <div class="formGroup">
          <label for="search">Search: </label>
          <input type="text" 
                 id="search" 
                 placeholder="Type to search"
                 v-model="searchText" > <!-- Bind to data's searchText -->
      </div>

      <div class="formGroup">
          <label for="minRating">Minimum Rating: </label>
          <select id="minRating" v-model.number="minRating">
              <option value="1">1 Star</option>
              <option value="2">2 Stars</option>
              <option value="3">3 Stars</option>
              <option value="4">4 Stars</option>
              <option value="5">5 Stars</option>
          </select>
      </div>

      <p>
          Searching for {{ searchText }} on items with a minimum rating of 
          {{ minRating }}.
      </p>

      <!-- All of our reviews go after this point -->
      <article v-for="review in filteredReviews" v-bind:key="review.id"
               v-bind:title="review.name"
               v-bind:class="{
                   'review': true,
                   'suspicious': review.rating < 2,
                   'featured': review.rating >= 5
               }">
          <h3>
              {{ review.name }}
          </h3>
          <div>
              Rating: 
              <img src="../assets/logo.png" 
                   v-for="num in review.rating" v-bind:key="num"
                   alt="The Vue.js logo pretending to be a star">
          </div>
          <p>
              {{ review.text }}
          </p>
      </article>

  </section>
</template>

<script>
// This is essentially a C# class
export default {
    // These are all basically C# properties
    data() {
        // Returns the starting state (data) of the component
        return {
            searchText: '',
            minRating: 1,
            productName: 'High Quality H2O',
            reviews: [
                { id: 1, name: "Matt Eland", rating: 5, text: "A perfect gift for a water boy"},
                { id: 2, name: "Kevin Teos", rating: 1, text: "Seriously guys?"},
                { id: 3, name: "Vinny Sanfillipo", rating: 3, text: "Does it help you get a job?"},
                { id: 4, name: "John Fulton", rating: 3, text: "I'd rate it higher but I'm on vacation"},
            ],
        }
    },
    // The equivalent of derived properties in C# (get-only properties)
    computed: {
        numReviews() {
            return this.reviews.length;
        },
        averageScore() {
            let sum = 0;

            this.reviews.forEach(r => {
                sum += r.rating;
            });

            let average = sum / this.numReviews;

            return average;
        },
        filteredReviews() {
            return this.reviews.filter(review => {
                // Exclude anything that doesn't match the query
                if (this.searchText && 
                    !review.text.toLowerCase().includes(this.searchText.toLowerCase())) {
                    return false;
                }

                if (review.rating < this.minRating) {
                    return false; // The item is below the minimum, so don't include it
                }

                // Nothing prevented me from displaying this item
                return true;
            });
        }
    }
}
</script>

<!-- Scoped says these styles can't bleed up into app.vue -->
<style scoped>
    p {
        font-style: italic;
    }

    h2 {
        color: navy;
    }

    .formGroup {
        margin-bottom: 1rem;
    }

    article img {
        height: 37px;
    }

    article {
        border: 1px solid black;
        background-color: lavender;
        margin-bottom: 1rem;
        border-radius: 15px;
    }

    .suspicious {
        background-color: rgb(212, 132, 132);
        font-weight: bold;
        border-color: red;
        border-width: 5px;
        color: black;
    }

    .featured {
        background-color: lemonchiffon;
        border-width: 2px;
    }
</style>