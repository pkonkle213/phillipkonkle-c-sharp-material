<template>
  <div>
    <loading v-if="isLoading" />
    <div v-if="bug && !isLoading">
      <nav aria-label="breadcrumb">
        <ol class="breadcrumb">
          <li class="breadcrumb-item">
            <router-link v-bind:to="{ name: 'BugsList' }">All Bugs</router-link>
          </li>
          <li class="breadcrumb-item active" aria-current="page">
            Bug Details
          </li>
        </ol>
      </nav>

      <div class="card">
        <h5 class="card-header">
          <span>{{ bug.title }}</span>
          <span class="bug-badges">
            <bug-status v-bind:bug="bug" />
            <priority v-bind:priority="bug.priority" />
          </span>
        </h5>
        <div class="card-body">
          <!-- <h5 class="card-title">Special title treatment</h5> -->
          <p class="card-text">
            {{ bug.description }}
          </p>
          <p class="card-text">
            {{ bug.resolution }}
          </p>
          <router-link
            class="btn btn-primary"
            v-bind:to="{ name: 'BugEdit', params: { id: bug.id } }"
          >
            Edit
          </router-link>

          <button
            class="btn btn-danger"
            v-bind:disabled="isDeleting"
            v-on:click="deleteBug"
          >
            <span
              v-if="isDeleting"
              class="spinner-border spinner-border-sm"
              role="status"
              aria-hidden="true"
            ></span>
            Delete
          </button>
        </div>
      </div>
    </div>
  </div>
</template>

<script>
import BugsService from "../services/BugsService.js";
import Loading from "../components/Loading.vue";
import BugStatus from "../components/BugStatus.vue";
import Priority from "../components/Priority.vue";

export default {
  data() {
    return {
      bug: undefined,
      isLoading: true,
      isDeleting: false,
    };
  },
  components: {
    Loading,
    BugStatus,
    Priority,
  },
  methods: {
    deleteBug() {
      // TODO: Showing this confirm button is yucky. Do something better instead.
      let confirmed = confirm(
        "Are you sure you want to delete this bug? This cannot be undone."
      );

      if (confirmed) {
        this.isDeleting = true;

        BugsService.deleteBug(this.bug.id)
          .then(() => {
            this.$store.commit("DELETE_BUG", this.bug.id);

            this.$router.push({ name: "BugsList" });
          })
          .catch((response) => {
            this.isDeleting = false;

            console.error("Could not delete", response);

            alert("Could not delete the bug. It may already be deleted.");
          });
      }
    },
  },
  created() {
    console.log("Bug Details loaded", this.$route);

    let bugId = parseInt(this.$route.params.id);

    BugsService.getBug(bugId)
      .then((response) => {
        // Handles 200's, 300's?, 100's?
        this.bug = response.data;
        this.isLoading = false;
      })
      .catch((response) => {
        // Handles 400's, 500's
        console.error("Failed to fetch bug details", response);

        this.$router.push({ name: "NotFound" });
      });
  },
};
</script>

<style lang="scss">
.btn {
  margin-right: 1rem;
}

.card-header {
    display: flex;
    flex-direction: row;
    justify-content: space-between;
}
</style>