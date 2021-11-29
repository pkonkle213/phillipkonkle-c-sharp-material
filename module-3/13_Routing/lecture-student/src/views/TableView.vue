<template>
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
            <tr v-for="review of reviewsToDisplay" v-bind:key="review.reviewer" v-bind:class="{'favorite': review.favorited}">
                <td>{{review.reviewer}}</td>
                <td>{{review.title}}</td>
                <td>{{review.rating}}</td>
                <td>{{review.review}}</td>
            </tr>
        </tbody>
    </table>
</template>

<script>
export default {
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