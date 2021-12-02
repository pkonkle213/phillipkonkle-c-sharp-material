<template>
  <div>
      <h1>Bugs List</h1>

      <loading v-if="isLoading" />

      <!-- List all existing bugs in a table -->
      <table v-if="hasBugs && !isLoading">
          <thead>
              <tr>
                  <th>Id</th>
                  <th>Title</th>
                  <th>Priority</th>
                  <th>Status</th>
              </tr>
          </thead>
          <tbody>
              <tr v-for="bug of allBugs" v-bind:key="bug.id">
                  <th>{{bug.id}}</th>
                  <td>
                      <router-link v-bind:to="{name: 'BugDetails', params: {id: bug.id}}">
                        {{bug.title}}
                      </router-link>
                  </td>
                  <td>
                    <priority v-bind:priority="bug.priority" />
                  </td>
                  <td>
                    <bug-status v-bind:bug="bug" />
                  </td>
              </tr>
          </tbody>
      </table>

      <!-- Show message if no bugs exist -->
      <p v-if="!hasBugs && !isLoading">
          No bugs exist! Ship it!
      </p>

      <button type="button" 
              class="btn btn-primary mt-3"
              v-if="!isLoading"
              v-on:click="addBug">
              New Bug
      </button>
  </div>
</template>

<script>
import BugsService from '../services/BugsService.js';
import Loading from '../components/Loading.vue';
import BugStatus from '../components/BugStatus.vue';
import Priority from '../components/Priority.vue';

export default {
    name: 'bugs-list',
    components: {
      Loading,
      BugStatus,
      Priority
    },
    data() {
      return {
        isLoading: true
      }
    },
    computed: {
        allBugs() {
            return this.$store.state.bugs;
        },
        hasBugs() {
            return this.allBugs.length > 0;
        }
    },
    methods: {
        addBug() {
            this.$router.push({name: 'NewBug'});
        }
    },
    created() {
      BugsService.getAllBugs() // result is a promise
        .then(response => { // Then is called when the promise is resolved
          this.$store.commit('LOADED_BUGS', response.data);
          
          this.isLoading = false;
        })
        .catch(response => {
          console.error('Could not fetch bugs', response);

          alert('The list of bugs could not be fetched. Please contact support if the problem persists.');

          this.isLoading = false;
        });
    }
}
</script>

<style lang="scss">

@import '../styles/colors.scss';

table {
    width: 100%;
}

table thead th {
    text-align: left;
}

table a {
    color: $dark;
}

table {
  border: 1px solid $light;
  width: 100%;
  border-collapse: collapse;
}
table td, table th {
  border: 1px solid $light;
  padding: 3px 2px;
}
table tbody td {
  font-size: 13px;
}
table tr:nth-child(even) {
  background: $accentLight;
}
table thead {
  background: $accentDark;
  color: $light;
  border-bottom: 5px solid $light;
}
table thead th {
  font-size: 17px;
  font-weight: bold;
  color: $light;
  text-align: left;
  border-left: 2px solid $light;
}
table thead th:first-child {
  border-left: none;
}

</style>