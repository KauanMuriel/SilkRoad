<template>
        <card-base>
        <div id="title-div">
            <h2>{{ title }}</h2>
        </div>
        <form action="">
        <slot name="form-body">

        </slot>
    </form>
    <div id="actions-form">
            <button class="btn btn-danger" @click="result(false)">Cancelar</button>
            <button class="btn btn-success" @click="result(true)" >Cadastrar</button>
        </div>        
</card-base>
        
</template>

<script>
import CardBase from './CardBase.vue';

export default {
    components: {
        CardBase
    },
    props: ['title'],
    emits: ['confirmation'],
    methods: {
        result(response) {
            this.$emit("confirmation", {
                response : response
            });
        }
    }
}
</script>

<style scoped>
    #title-div {
        width: 100%;
        height: 10%;
        display: flex;
        padding: 2% 6%;
        justify-content: space-between;
    }

    #actions-form {
        width: 100%;
        height: 10%;
        display: flex;
        justify-content: flex-end;
    }

    .row {
        display: flex;
        padding: 3% 6%;
    }
    .item {
        display: flex;
        flex-direction: column;
        padding: 0 2%;
    }

    form {
        height: 80%;
        width: 80%;
        display: flex;
        flex-direction: column;
        margin-top: 10%;
    }

    input {
        height: 3.5vh;
    }

    button {
        height: 70%;
        margin: 0 1% 0 0.5%;
    }
    </style>