<template>
    <thead>
        <tr>
            <slot name="th-cols">
                <th v-for="name in colNames" scope="col"> {{ name }}</th>
                <th>Actions</th>
            </slot>
        </tr>
    </thead>
</template>

<script>
export default {
    props: ['colletion'],
    computed: {
        colNames() {
            const item = this.colletion[0];
            let names = [];
            for (let key in item) names.push(key);
            return names;
        }
    }
}
</script>