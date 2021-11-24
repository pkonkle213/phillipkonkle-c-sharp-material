<template>
    <header>
        <h2>Product Reviews for {{ productName }}</h2>
        <p class="description">{{ productDesc }}</p>
    </header>
</template>

<script>
export default {
    // Props come from OUTSIDE of the component
    props: {
        productName: String,
        productDesc: String,
    },
    // props: ['productName', 'productDesc'],
    // Data is INTERNAL data to the component
    // Similar to a field / class variable or a C# property
    data() {
        return {
            name: 'Test',
            description: 'Test Description'
        }
    }
}
</script>

<style>

</style>