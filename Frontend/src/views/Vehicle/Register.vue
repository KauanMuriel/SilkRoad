<template>
    <form-base title="Novo veículo" @confirmation="registerNew">
        <template #form-body>
            <div class="row">
                <div class="item col-4">
                    <label for="input-renavam">Renavam</label>
                    <input type="text" name="input-renavam" id="input-renavam" v-model="renavam">
                </div>
                <div class="item col-4">
                    <label for="input-sign">Placa</label>
                    <input type="text" name="input-sign" id="input-sign" v-model="plate">
                </div>
                <div class="item col-4">
                    <label for="input-model-year">Ano do modelo</label>
                    <input type="date" name="input-model-year" id="input-model-year" v-model="modelYear">
                </div>
            </div>
            <div class="row">
                <div class="item col-3">
                    <label for="input-entry-year">Ano de entrada</label>
                    <input type="date" name="input-entry-year" id="input-entry-year" v-model="entryYear">
                </div>
                <div class="item col-4">
                    <label for="input-brand">Marca</label>
                    <select name="input-brands" id="input-brands" class="col-12" v-model="brandSelected" @click="getBrands">
                        <option v-for="brand in brands" :value="brand.id" :key="brand.id">{{ brand.name }}</option>
                    </select>
                </div>
                <div class="item col-5">
                    <label for="input-model">Modelo</label>
                    <select name="input-models" id="input-models" class="col-12" v-model="modelSelected" @click="getModels">
                        <option v-for="model in modelsOfBrand" :value="model.id" :key="model.id">{{ model.name }}</option>
                    </select>
                </div>
            </div>
        </template>
    </form-base>
</template>

<script>
import FormBase from '../../components/base/FormBase.vue';
import BrandService from '../../services/BrandDataService';
import ModelService from '../../services/ModelDataService';
import VehicleService from '../../services/VehicleDataService';

export default {
    data() {
        return {
            brands: [],
            models: [],
            modelsOfBrand: [],
            brandSelected: null,
            modelSelected: null,
            renavam: null,
            plate: null,
            modelYear: null,
            entryYear: null
        }
    },
    components: {
        FormBase
    },
    methods: {
        getBrands() {
            if (this.brands.length <= 0) {
                BrandService.list().then(response => {
                    this.brands = response.data;
                });
            }
        },
        async getModels() {
            if (this.models.length <= 0) {
                await ModelService.list().then(response => {
                    this.models = response.data;
                })
            }
            this.groupModelsOfBrand();
        },
        groupModelsOfBrand() {
            this.modelsOfBrand = this.models.filter(model => model.brandId == this.brandSelected);
        },
        registerNew() {
            const data = {
                renavam: this.renavam,
                plate: this.plate,
                year: this.modelYear,
                entryDate: this.entryYear,
                modelId: this.modelSelected.id
            };
            VehicleService.register(data);
        }
    }
}
</script>

<style scoped>

select {
        height: 3.5vh
    }
</style>