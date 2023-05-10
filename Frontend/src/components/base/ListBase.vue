<template>
    <card-base>
        <slot name="list-body">
            <table class="table">
                <table-head :collection="collection"></table-head>
                <table-body :collection="collection"></table-body>
            </table>
        </slot>
    </card-base>
</template>

<script>
import CardBase from './CardBase.vue';
import TableHead from '../utilities/TableHead.vue';
import TableBody from '../utilities/TableBody.vue';

export default {
    components: {
        CardBase,
        TableHead,
        TableBody
    },
    data() {
        return {
            collection: []
        }
    },
    props: { 
        service: {
            type: Object,
            required: true
        }
    },
    methods: {
        getCollection() {
            this.service.list().then(response => {
                this.collection = response.data;
            });
        }
    },
    mounted() {
        this.getCollection();
    }
}
</script>

<style scoped>
.table {
    width: 80%;
}


</style>