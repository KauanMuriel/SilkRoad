<template>
    <list-base :service="service">

    </list-base>
</template>

<script>
import ListBase from '../../components/base/ListBase.vue';
import DriverService from '../../services/DriverDataService';

export default {
    components: {
        ListBase
    },
    data() {
        return {
            service: DriverService
        }
    }
}
</script>