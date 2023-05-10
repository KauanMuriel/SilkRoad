<template>
    <tbody>
        <tr v-for="item in collection">
            <td v-for="data in item">{{ data }}</td>
        </tr>
    </tbody>
</template>

<script>
export default {
    props: ['collection'],
    computed: {
        colDatas() {
            const item = this.collection[0];
            let names = [];
            for (let i = 0; i < item.length; i++) {
                names.push(item[i]);
            } 
            return names;
        }
    }
}
</script>