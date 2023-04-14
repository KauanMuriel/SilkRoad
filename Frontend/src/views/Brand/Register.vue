<template>
    <form-base title="Nova marca" @confirmation="registerNew()">
        <div class="row">
            <div class="item">
                <label for="input-name">Nome</label>
                <input type="text" name="input-name" id="input-name">
            </div>
        </div>
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

        }
    },
    methods: {
        registerNew(response) {
            
        }
    }
}
</script>