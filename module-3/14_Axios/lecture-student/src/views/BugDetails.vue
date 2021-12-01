<template>
  <div v-if="bug">
      <nav aria-label="breadcrumb">
        <ol class="breadcrumb">
            <li class="breadcrumb-item">
                <router-link v-bind:to="{name: 'BugsList'}">All Bugs</router-link>
            </li>
            <li class="breadcrumb-item active" aria-current="page">Bug Details</li>
        </ol>
      </nav>

      <h1>{{ bug.title}}</h1>

      <div class="badges">
        <priority-badge :bug="bug" />
        <status-badge :bug="bug" />
      </div>
      
      <p>
          {{bug.description}}
      </p>

      <p v-if="bug.resolution">
          <strong>Resolution:</strong>
          {{bug.resolution}}
      </p>

      <router-link class="btn btn-primary" 
                   v-bind:to="{name: 'BugEdit', params: {id: bug.id}}">
          Edit
      </router-link>

      <button class="btn btn-danger"
                  v-on:click="deleteBug">
          Delete
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
    data() {
        return {    
            bug: undefined
        }
    },
    methods: {
        deleteBug() {
            let confirmed = confirm('Are you sure you want to delete this bug? This cannot be undone.');

            if (confirmed) {
                this.$store.commit('DELETE_BUG', this.bug.id);

                this.$router.push({name: 'BugsList'});
            }
        }
    },
    created() {
        console.log('Bug Details loaded', this.$route);

        let bugId = parseInt(this.$route.params.id);

        this.bug = this.$store.state.bugs.find(bug => bug.id === bugId);

        if (!this.bug) {
            this.$router.push({name: 'NotFound'});
        }
    }
}
</script>

<style lang="scss">
    .btn {
        margin-right: 1rem;
    }

    .badges {
        margin-bottom: 1rem;
    }
</style>