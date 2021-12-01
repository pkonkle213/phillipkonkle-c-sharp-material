<template>
  <div>
      <nav aria-label="breadcrumb">
        <ol class="breadcrumb">
            <li class="breadcrumb-item">
                <router-link v-bind:to="{name: 'BugsList'}">All Bugs</router-link>
            </li>
            <li class="breadcrumb-item">
                <router-link v-bind:to="{name: 'BugDetails', params:{id: bug.id}}">Bug Details</router-link>
            </li>
            <li class="breadcrumb-item active" aria-current="page">Edit</li>
        </ol>
      </nav>

      <h1>Edit Bug</h1>

      <loading v-if="isLoading" />

      <form v-on:submit.prevent="saveBug" v-show="!isLoading">
        <div class="mb-3">
            <label for="title" class="form-label">Title</label>
            <input type="text" class="form-control" id="title" 
                    v-model.trim="bug.title"
                   required 
                   placeholder="Enter a bug title">
        </div>
        <div class="mb-3">
            <label for="description" class="form-label">Description</label>
            <textarea class="form-control" id="description" rows="3"
                      v-model.trim="bug.description"></textarea>
        </div>          
        <div class="mb-3">
            <label for="priority" class="form-label">Priority</label>
            <select id="priority" class="form-select" v-model.number="bug.priority">
                <option value="1">1 - Very Low</option>
                <option value="2">2 - Low</option>
                <option value="3">3 - Medium</option>
                <option value="4">4 - High</option>
                <option value="5">5 - Critical</option>
            </select>
        </div>
        <div class="form-check mb-3">
            <input class="form-check-input" type="checkbox" value="" id="isOpen" 
                    v-model="bug.isOpen">
            <label class="form-check-label" for="isOpen">
                Is Open?
            </label>
        </div>
        <div class="mb-3">
            <label for="resolution" class="form-label">Resolution</label>
            <textarea class="form-control" id="resolution" rows="3"
                      v-model.trim="bug.resolution"></textarea>
        </div>
        <button type="submit" class="btn btn-success"
                v-bind:disabled="isSaving">
            <span v-if="isSaving" 
                  class="spinner-border spinner-border-sm" 
                  role="status" 
                  aria-hidden="true"></span>
            Update
        </button>
        <router-link class="btn btn-secondary" 
                     v-if="!isSaving"
                     v-bind:to="{name: 'BugDetails', params:{id: bug.id}}">
            Cancel
        </router-link>
      </form>
  </div>
</template>

<script>
import BugsService from '../services/BugsService.js';
import Loading from '../components/Loading.vue';

export default {
    data() {
        return {
            bug: {},
            isSaving: false,
            isLoading: true
        }
    },
    components: {
        Loading,
    },
    created() {
        let bugId = parseInt(this.$route.params.id);

        BugsService.getBug(bugId)
            .then(response => { // Handles 200's, 300's?, 100's?
                this.bug = response.data;
                this.isLoading = false;
            })
            .catch(response => { // Handles 400's, 500's
                console.error('Failed to fetch bug details', response);

                this.$router.push({name: 'NotFound'});
            });        
    },    
    methods: {
        saveBug() {
            this.isSaving = true;

            BugsService.updateBug(this.bug)
                .then(response => {
                    this.$store.commit('UPDATE_BUG', response.data);

                    this.$router.push({name: 'BugDetails', params: {id: response.data.id}});
                })
                .catch(response => {
                    console.error('Could not save', response);

                    alert('Could not save the bug. Please contact support');

                    this.isSaving = false;
                })
        }
    }
}
</script>

<style>
form .btn {
    margin-right: 1rem;
}
</style>