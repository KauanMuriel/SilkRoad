<template>
    <ListBase :service="service"/>
</template>

<script>
import VehicleDataService from '../../services/VehicleDataService';
import ListBase from '../../components/base/ListBase.vue';

export default {
    components: {
        ListBase
    },
    data() {
        return {
            service: VehicleDataService,
        }
    }
}
</script>