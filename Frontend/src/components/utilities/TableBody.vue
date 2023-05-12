<template>
    <tbody>
        <tr v-for="item in collection">
            <td v-for="data in item">{{ data }}</td>
        </tr>
        <tr v-if="!collection.length">
            <td>There is no data to display! Register at least one element.</td>
        </tr>
    </tbody>
</template>

<script>
export default {
    props: ['collection']
}
</script>