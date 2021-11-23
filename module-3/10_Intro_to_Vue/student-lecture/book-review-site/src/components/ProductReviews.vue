<template>
  <section>
      <h2>Product Reviews for {{productName}}</h2>
      <p>
          There are {{numReviews}} reviews for this product with an 
          average review score of {{averageScore.toFixed(2)}}
      </p>

      <div class="formGroup">
          <label for="search">Search: </label>
          <input type="text" id="search" placeholder="Type to search" v-model="searchText"> <!-- v-model is an instance of two way binding -->
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

      <p>Searching for {{searchText}} on items with a minimum rating of {{minRating}}.</p>

      <article v-for="review in filteredReviews" v-bind:key="review.id" v-bind:title="review.name" v-bind:class="{
          'supersus': review.rating < 2,
          'featured': review.rating > 4
      }">
            <h3>{{review.name}}</h3>
            <div>
                Rating: {{review.rating}}
                <img src="../assets/logo.png" v-for="num in review.rating" v-bind:key="num" alt="The Vue.js logo pretending to be a star">
            </div>
            <p>{{review.text}}</p>                
      </article>
  </section>
</template>

<script>
export default {
    data() {
        // Returns the starting state (data) of the component
        return {
            searchText:'',
            minRating: 1,
            productName: 'High Quality H2O',
            reviews: [
                {id: 1, name: "Matt Eland", rating: 5, text: "A perfect gift for a waterboy"},
                {id: 2, name: "Kevin Teos", rating: 1, text: "Seriously guys?"},
                {id: 3, name: "Vinny Sanfillipo", rating: 3, text: "Does it help you get a job?"},
                {id: 4, name: "John Fulton", rating: 3, text: "I'd rate it higher but I'm on vacation"},
            ]
        }
    },
    computed: {
        numReviews() {
            return this.reviews.length;
        },
        averageScore() {
            let sum = 0;
            this.reviews.forEach (r => {
                sum += r.rating;
            });
                
            let average = sum / this.numReviews;
            return average;
        },
        filteredReviews() {
            return this.reviews.filter(review => {
                if (review.rating < this.minRating) {
                    return false;
                }

                if (!review.text.toLowerCase().includes(this.searchText.toLowerCase())){
                    return false;
                }
                return true;
            })
        }
    }
}
</script>

// Scoped makes the styles stay on this page
<style scoped>
p {
    font-style: italic;
}

This affects all of the page

h2 {
    color: blue;
}
.formGroup {
    margin-bottom: 1rem;
}
article img {
    height: 40px;
}
article {
    border: 1px solid black;
    margin-top: 1rem;
    border-radius: 50px;
}
.supersus {
    background-color: rgb(212, 132, 132);
    font-weight: bold;
    border-color: red;
    border-width: 5pm;
    color: black;
}
.featured {
    background-color: lemonchiffon;
    border-width: 5px;
}
</style>
