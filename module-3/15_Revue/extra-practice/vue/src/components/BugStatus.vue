<template>
  <div class="me-2">
    <span class="badge bg-primary" 
          v-if="bug.isOpen"
          v-bind:title="bug.description">
        Open
    </span>
    <span class="badge bg-success" 
          v-if="!bug.isOpen"
          v-bind:title="bug.resolution">
        Closed
    </span>      
  </div>
</template>

<script>
export default {
    props: {
        bug: Object
    }
}
</script>

<style scoped>

div {
    display: inline-block;
}

</style>