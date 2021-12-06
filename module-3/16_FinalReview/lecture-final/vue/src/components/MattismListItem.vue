<template>
  <li
    class="list-group-item list-group-item-dark d-flex justify-content-between align-items-center"
  >
    {{ ism.text }}
    <span
      v-bind:class="{
        badge: true,
        'badge-pill': true,
        'badge-dark': ism.frequency === 'Sociopathic',
        'badge-danger': ism.frequency === 'High',
        'badge-primary': ism.frequency === 'Low',
      }"
    >
      {{ ism.frequency }}
    </span>
  </li>
</template>

<script>
export default {
    props: {
        ism: Object,
    }
};
</script>

<style>
</style>