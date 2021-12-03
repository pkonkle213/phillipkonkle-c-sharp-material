<template>
  <div class="home">
    <h1>Current Matt-isms</h1>
    <p>These are things Matt currently says or is saying or has said or we claim he has said.</p>

    <div class="alert alert-danger" role="alert"
         v-if="showError">
      {{ errorMessage }}
    </div>

    <ul class="list-group">
      <mattism-list-item 
          v-for="ism of mattisms"
          v-bind:key="ism.id"
          v-bind:ism="ism"
          />
    </ul>

    <form v-if="isLoggedIn" v-on:submit.prevent="addItem()">
      <h2 class="mt-4">Add a Saying</h2>
      <div class="form-group">
        <label for="saying">Saying</label>
        <input type="text" 
               id="saying" 
               required
               maxlength="150"
               class="form-control"
               v-model.trim="itemToAdd.text"
               placeholder="Enter a Mattism here...">
      </div>
      <div class="form-group">
        <label for="frequency">Frequency</label>
        <select class="form-control" required id="frequency" v-model="itemToAdd.frequency">
          <option value="Low">Low</option>
          <option value="High">High</option>
          <option value="Sociopathic">Sociopathic</option>
        </select>
      </div>
      <button type="submit" class="btn btn-primary">
        Add
      </button>
    </form>

  </div>
</template>

<script>
import MattismListItem from '../components/MattismListItem.vue';
import MattService from '../services/MattService.js';

export default {
  components: { 
    MattismListItem 
  },
  name: "home",
  data() {
    return {
      mattisms: [],
      showError: false,
      errorMessage: '',
      itemToAdd: {
        text: '',
        frequency: 'High'
      }
    }
  },
  methods: {
    addItem() {
      console.log("Add item clicked");
      MattService.addSaying(this.itemToAdd)
        .then(response => {
          const newItem = response.data;
          this.mattisms.push(newItem);

          // Clear out the saying for the next one
          this.itemToAdd.text = '';
        })
        .catch(response => {
          console.error("Couldn't add saying", response);
          this.showError = true;
          this.errorMessage = "Couldn't add saying. Please try again.";
        })
    }
  },
  computed: {
    isLoggedIn() {
      return this.$store.state.token;
    },
    isAdmin() {
      return this.$store.state.user && 
             this.$store.state.user.role === 'admin';
    }
  },
  created() {
    MattService
      .getAllSayings()
      .then(response => {
        this.mattisms = response.data;
      })
      .catch(response => {
        console.error("Could not get sayings", response);
        this.showError = true;
        this.errorMessage = "Couldn't load sayings. Please refresh the page and try again.";
      });
  }
};
</script>