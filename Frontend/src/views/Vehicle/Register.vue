<template>
    <form-base title="Novo veículo">
        <template #form-body>
            <div class="row">
                <div class="item col-4">
                    <label for="input-renavam">Renavam</label>
                    <input type="text" name="input-renavam" id="input-renavam">
                </div>
                <div class="item col-4">
                    <label for="input-sign">Placa</label>
                    <input type="text" name="input-sign" id="input-sign">
                </div>
                <div class="item col-4">
                    <label for="input-model-year">Ano do modelo</label>
                    <input type="date" name="input-model-year" id="input-model-year">
                </div>
            </div>
            <div class="row">
                <div class="item col-3">
                    <label for="input-entry-year">Ano de entrada</label>
                    <input type="date" name="input-entry-year" id="input-entry-year">
                </div>
                <div class="item col-4">
                    <label for="input-brand">Marca</label>
                    <select name="brands" id="brands" @click="getBrands" v-model="brandSelected">
                        <option v-for="brand in brands" :value="brand.id">{{ brand.name }}</option>
                    </select>
                </div>
                <div class="item col-5">
                    <label for="input-model">Modelo</label>
                    <select name="models" id="models" :value="brandSelected">

                    </select>
                </div>
            </div>
        </template>
    </form-base>
</template>

<script>
import FormBase from '../../components/base/FormBase.vue';
import BrandService from '../../services/BrandDataService';

export default {
    data() {
        return {
            brands: [],
            brandSelected: null
        }
    },
    components: {
        FormBase
    },
    methods: {
        async getBrands() {
            if (this.brands.length <= 0) {
                BrandService.list().then(response => {
                    this.brands = response.data;
                });
            }
        }
    }
}
</script>

<style scoped>

select {
        height: 3.5vh
    }
</style>