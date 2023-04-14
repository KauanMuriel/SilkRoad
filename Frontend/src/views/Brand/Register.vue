<template>
    <form-base title="Nova marca" @confirmation="registerNew">
        <template #form-body>
            <div class="row">
                <div class="item col-12">
                    <label for="input-name">Nome</label>
                    <input type="text" name="input-name" id="input-name" v-model="brand.name">
                </div>
            </div>
        </template>
    </form-base >
</template>

<script>
import FormBase from '../../components/base/FormBase.vue';
import service from '../../services/BrandDataService';

export default {
    components:{
        FormBase
    },
    data() {
        return {
            brand : {
                name : ''
            }
        }
    },
    methods: {
        registerNew(confirmation) {
            if(confirmation.response) {
                const data = {
                    name : this.brand.name
                }

                service.register(data);
            }
        }
    }
}
</script>