<template>
  <section>
      <table>
          <thead>
              <tr>
                  <th>Reviewer</th>
                  <th>Title</th>
                  <th># Stars</th>
                  <th>Text</th>
              </tr>
          </thead>
          <tbody>
              <tr v-for="review of reviewsToDisplay"
                  v-bind:key="review.reviewer"
                  v-bind:class="{'favorite': review.favorited}">
                  <td>
                      <router-link v-bind:to="{name: 'ReviewDetails', 
                                               params: {reviewer: review.reviewer}}">
                        {{review.reviewer}}
                      </router-link>
                  </td>
                  <td>{{review.title}}</td>
                  <td>{{review.rating}}</td>
                  <td>{{review.review.substring(0, 35)}}</td>
              </tr>
          </tbody>
      </table>
  </section>
</template>

<script>
export default {
    name: 'TableView',
    computed: {
        reviewsToDisplay() {
            return this.$store.state.reviews;
        }
    }
}
</script>

<style>

table {
    width: 100%;
    text-align: left;
}

tr.favorite {
    background-color: lemonchiffon;
}

</style>