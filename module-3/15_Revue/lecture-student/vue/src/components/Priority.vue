<template>
    <span v-bind:class="{
        badge: true,
        'me-2': true,
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
    props: {
        priority: Number,
    }
}
</script>