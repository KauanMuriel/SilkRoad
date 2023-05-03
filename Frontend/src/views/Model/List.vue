<template>
    <card-base>
        <div id="row-brands">
            <label for="input-brand">Marcas</label>
            <select name="input-brand" id="input-brand">
                <option v-for="brand in brandColletion" :value="brand.id" :key="brand.id">{{ brand.name }}</option>
            </select>
        
        </div>
    </card-base>
</template>

<script>
import CardBase from '../../components/base/CardBase.vue';
import BrandService from '../../services/BrandDataService';

export default {
    components: {
        CardBase
    },
    data() {
        return {
            brandService: BrandService,
            brandColletion: []
        }
    },
    methods: {
        getBrands() {
            this.brandService.list().then(response => {
                this.brandColletion = response.data;
            })
        }
    },
    mounted() {
        this.getBrands();
    }
}
</script>

<style scoped>
#row-brands {
    display: flex;
    flex-direction: column;
    width: 40%;
}
</style>