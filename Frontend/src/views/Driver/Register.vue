<template>
    <card-base>
        <div id="title-div">
            <h2>Novo motorista</h2>
        </div>
        <form action="">
            <div class="row">
                <div class="item col-8">
                    <label for="input-name">Nome</label>
                    <input type="text" id="input-name" v-model="driver.name">
                </div>
                <div class="item col-4">
                    <label for="input-phone">Telefone</label>
                    <input type="text" id="input-phone">
                </div>
            </div>
            <div class="row">
                <div class="item col-4">
                    <label for="input-cpf">CPF</label>
                    <input type="text" id="input-cpf" v-model="driver.CPF">
                </div>
                <div class="item col-4">
                    <label for="input-cnh">CNH</label>
                    <input type="text" id="input-cnh" v-model="driver.CNH">
                </div>
                <div class="item col-4">
                    <label for="input-admin">Admin</label>
                    <input type="checkbox" id="input-cnh" v-model="driver.Admin">
                </div>
            </div>
        </form>
        <div id="actions-form">
            <button class="btn btn-danger" @click="$router.back()">Cancelar</button>
            <button class="btn btn-success" @click="registerDriver" >Cadastrar</button>
        </div>
    </card-base>
</template>

<script>
import ButtonBase from '../../components/base/ButtonBase.vue';
import CardBase from '../../components/base/CardBase.vue';
import DriverDataService from '../../services/DriverDataService';

export default {
    data() {
        return {
            DriverDataService,
            driver : {
                name: "",
                CPF: "",
                CNH: "",
                Admin: false
            }
        }
    },
    components: {
        ButtonBase,
        CardBase
    },
    props: ['title'],
    methods: {
        registerDriver()
        {
            const data = {
                name: this.driver.name,
                CPF: this.driver.CPF,
                CNH: this.driver.CNH,
                Admin: this.driver.Admin
            };

            DriverDataService.register(data);
        }
    }
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