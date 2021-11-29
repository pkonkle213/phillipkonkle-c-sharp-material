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
      <p>
          {{bug.description}}
      </p>

      <h2>
          Status:
          <span v-if="bug.isOpen">Open</span>
          <span v-if="!bug.isOpen">Closed</span>
      </h2>

      <p>
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
export default {
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
</style>