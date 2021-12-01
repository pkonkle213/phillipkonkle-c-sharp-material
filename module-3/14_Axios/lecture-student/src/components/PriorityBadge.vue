<template>
    <span v-bind:class="{
            badge: true,
            'bg-secondary': priority === 1,
            'bg-info': priority === 2,
            'bg-primary': priority === 3,
            'bg-warning': priority === 4,
            'bg-danger': priority === 5,
        }">
        Priority: {{priority}}
    </span>
</template>

<script>
export default {
    name: 'PriorityBadge',
    props: {
        bug: Object
    },
    computed: {
        priority() {
            return this.bug.priority;
        }
    }
}
</script>

<style>
.badge {
    margin-right: 0.25rem;
}
</style>