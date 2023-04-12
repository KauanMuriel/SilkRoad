<template>
    <card-base>
        <div id="title-div">
            <h2>{{ title }}</h2>
        </div>
        <form action="">
            <div class="row">
                <div class="item col-8">
                    <label for="input-name">Nome</label>
                    <input type="text" id="input-name">
                </div>
                <div class="item col-4">
                    <label for="input-phone">Telefone</label>
                    <input type="text" id="input-phone">
                </div>
            </div>
            <div class="row">
                <div class="item col-4">
                    <label for="input-cpf">CPF</label>
                    <input type="text" id="input-cpf">
                </div>
                <div class="item col-4">
                    <label for="input-cnh">CNH</label>
                    <input type="text" id="input-cnh">
                </div>
            </div>
        </form>
        <div id="actions-form">
            <button class="btn btn-danger" @click="$router.back()">Cancelar</button>
            <button class="btn btn-success">Cadastrar</button>
        </div>
    </card-base>
</template>

<script>
import ButtonBase from './ButtonBase.vue';
import CardBase from './CardBase.vue';

export default {
    data() {
        return {

        }
    },
    components: {
        ButtonBase,
        CardBase
    },
    props: ['title']
}
</script>

<style>
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