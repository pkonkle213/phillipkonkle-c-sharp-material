<template>
  <div class="card" v-bind:class="{read:book.read}">
    <h2 class="book-title">{{book.title}}</h2>
    <img v-if="book.isbn" v-bind:src="'http://covers.openlibrary.org/b/isbn/' + book.isbn + '-M.jpg'" />
    <h3 class="book-author">{{book.author}}</h3>
    <input type="button" value="Mark Read" v-if="!book.read" v-on:click="markRead($event, true)">
    <input type="button" value="Mark Unread" v-if="book.read" v-on:click="markRead($event, false)">
  </div>
</template>

<script>
export default {
    name: 'book-card',
    props: {
      book: Object
    },
    methods: {
        markRead(event, bool) {
            let payload = {
                isbn: this.book.isbn,
                read: bool
            }

            this.$store.commit('MARK_READ',payload);
        }
    }
}
</script>

<style>
.card {
    border: 2px solid black;
    border-radius: 10px;
    width: 250px;
    height: 550px;
    margin: 20px;
}

.card.read {
    background-color: lightgray;
}

.card .book-title {
    font-size: 1.5rem;
}

.card .book-author {
    font-size: 1rem;
}
</style>