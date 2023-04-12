<template>
    <section>
        <div id="home-img"></div>
        <h1>Silk Road</h1>
        <p>Software de gestão de frotas</p>
    </section>
</template>

<script>
export default {
    
}
</script>

<style scoped>
    #home-img {
        width: 35vh;
        height: 35vh;
        background-image: url('../assets/icons/garage-icon.svg');
        background-size: cover;
        background-position: center;
    }

    section {
        display: flex;
        flex-direction: column;
        align-items: center;
        color: #FFFBEB;
    }

    p {
        font-size:20px;
    }
</style>