<template>
    <form-base title="Novo veículo">
        <template #form-body>
            <div class="row">
                <div class="item col-4">
                    <label for="input-renavam">Renavam</label>
                    <input type="text" name="input-renavam" id="input-renavam">
                </div>
                <div class="item col-4">
                    <label for="input-placa">Placa</label>
                    <input type="text" name="input-placa" id="input-placa">
                </div>
                <div class="item col-4">
                    <label for="input-ano-modelo">Ano do modelo</label>
                    <input type="date" name="input-ano-modelo" id="input-ano-modelo">
                </div>
            </div>
            <div class="row">
                <div class="item col-6">
                    <label for="input-tipo">Ano de entrada</label>
                    <input type="date" name="input-tipo" id="input-tipo">
                </div>
                <div class="item col-6">
                    <label for="input-tipo">Modelo</label>
                    <input type="text" name="input-tipo" id="input-tipo">
                </div>
            </div>
        </template>
    </form-base>
</template>

<script>
import FormBase from '../../components/base/FormBase.vue';

export default {
    data() {
        return {

        }
    },
    components: {
        FormBase
    }
}
</script>