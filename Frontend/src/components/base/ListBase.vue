<template>
    <card-base>
        <slot name="list-body">
            <table class="table">
                <table-head :collection="collection"></table-head>
                <tbody>
                    <tr>
                        <th scope="row">1</th>
                        <td>Mark</td>
                        <td>Otto</td>
                        <td>@mdo</td>
                    </tr>
                    <tr>
                        <th scope="row">2</th>
                        <td>Jacob</td>
                        <td>Thornton</td>
                        <td>@fat</td>
                    </tr>
                    <tr>
                        <th scope="row">3</th>
                        <td colspan="2">Larry the Bird</td>
                        <td>@twitter</td>
                    </tr>
                </tbody>
            </table>
        </slot>
    </card-base>
</template>

<script>
import CardBase from './CardBase.vue';
import TableHead from '../utilities/TableHead.vue';

export default {
    components: {
        CardBase,
        TableHead
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
    created() {
        this.getCollection();
    },
    mounted() {
    }
}
</script>