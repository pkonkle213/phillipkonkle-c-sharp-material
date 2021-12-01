<template>
  <span>
    <span class="badge bg-primary" v-if="bug.isOpen" v-bind:title="bug.description">
        Open
    </span>
    <span class="badge bg-success" v-if="!bug.isOpen" v-bind:title="bug.resolution">
        Closed
    </span>
  </span>
</template>

<script>
export default {
    name: 'StatusBadge',
    props: {
        bug: Object
    }
}
</script>

<style>

</style>