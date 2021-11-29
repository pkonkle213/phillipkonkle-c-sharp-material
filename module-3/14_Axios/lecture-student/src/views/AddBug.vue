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
        <button type="submit" class="btn btn-success">
            Add
        </button>
      </form>
  </div>
</template>

<script>
export default {
    data() {
        return {
            newBug: {
                title: '',
                description: '',
                resolution: '',
                isOpen: true,
                priority: 2,
            }
        }
    },
    methods: {
        addBug() {
            this.$store.commit('ADD_BUG', this.newBug);

            this.$router.push({name: 'BugsList'});
        }
    }
}
</script>

<style>

</style>