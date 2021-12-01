<template>
  <div>
      <h1>New Bug</h1>

      <form v-on:submit.prevent="addBug">
        <div class="mb-3">
            <label for="title" class="form-label">Title</label>
            <input type="text" class="form-control" id="title" 
                    v-model.trim="newBug.title"
                   required 
                   placeholder="Enter a bug title">
        </div>
        <div class="mb-3">
            <label for="description" class="form-label">Description</label>
            <textarea class="form-control" id="description" rows="3"
                      v-model.trim="newBug.description"></textarea>
        </div>          
        <div class="mb-3">
            <label for="priority" class="form-label">Priority</label>
            <select id="priority" class="form-select" v-model.number="newBug.priority">
                <option value="1">1 - Very Low</option>
                <option value="2">2 - Low</option>
                <option value="3">3 - Medium</option>
                <option value="4">4 - High</option>
                <option value="5">5 - Critical</option>
            </select>
        </div>
        <!-- <div class="mb-3">
            <label for="resolution" class="form-label">Resolution</label>
            <textarea class="form-control" id="resolution" rows="3"></textarea>
        </div>           -->
        <button type="submit" class="btn btn-success"
                v-bind:disabled="isSaving">
            <span v-if="isSaving" 
                  class="spinner-border spinner-border-sm" 
                  role="status" 
                  aria-hidden="true"></span>
            Add
        </button>
      </form>
  </div>
</template>

<script>
import BugsService from '../services/BugsService.js';

export default {
    data() {
        return {
            newBug: {
                title: '',
                description: '',
                resolution: '',
                isOpen: true,
                priority: 2,
            },
            isSaving: false
        }
    },
    methods: {
        addBug() {
            // Don't allow double click on save
            if (this.isSaving) return;

            this.isSaving = true;

            BugsService.addBug(this.newBug)
                .then(response => {
                    // We want the ID of the item from the server
                    this.$store.commit('ADD_BUG', response.data);

                    this.$router.push({name: 'BugsList'});
                })
                .catch(response => {
                    console.error(response);
                    alert('Could not save the item. Contact support for more information.');
                    this.isSaving = false;
                })
        }
    }
}
</script>

<style>

</style>