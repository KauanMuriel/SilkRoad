<template>
    <button :class="classButton">{{ buttonText }}</button>
</template>

<script>
export default {
    data() {
        return {

        }
    },
    computed: {
        classButton() {
        return {
            'btn-danger': this.type === "delete",
            'btn-success': this.type === "confirm" 
            }
        }
    },
    props: ['buttonText', 'type']
}
</script>

<style scoped>
button {
    border: none;
    padding: 15px;
    border-radius: 10px;
}

.btn-success {
    background-color: #00B8A9;
}

.btn-danger {
    background-color: #F6416C;
}
</style>