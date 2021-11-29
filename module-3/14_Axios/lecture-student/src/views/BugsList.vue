<template>
  <div>
      <h1>Bugs List</h1>

      <!-- List all existing bugs in a table -->
      <table v-if="hasBugs">
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
                      <priority-badge :bug="bug" />
                  </td>
                  <td>
                      <status-badge :bug="bug" /> 
                  </td>
              </tr>
          </tbody>
      </table>

      <!-- Show message if no bugs exist -->
      <p v-if="!hasBugs">
          No bugs exist! Ship it!
      </p>

      <button type="button" 
              class="btn btn-primary mt-3"
              v-on:click="addBug">
              New Bug
      </button>
  </div>
</template>

<script>
import PriorityBadge from '../components/PriorityBadge.vue';
import StatusBadge from '../components/StatusBadge.vue';

export default {
  components: {
     PriorityBadge,
     StatusBadge 
  },
  name: 'bugs-list',
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
  }
}
</script>

<style lang="scss">

$accentDark: #3D5A80;
$accentLight: #98C1D9;
$background: #E0FBFC;
$danger: #EE6C4D;
$dark: #293241;
$light: white;

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
  a:hover {
    color: $accentDark !important;
  }
}
table tr:nth-child(odd) {
  a:hover {
    color: $accentDark !important;
  }
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