<script setup>
import { RouterView } from 'vue-router'
</script>

<template>
    <TheHeader/>

    <main class="wrapper">
      <RouterView />
    </main>

</template>

<script>
import TheHeader from './components/layout/TheHeader.vue';


export default {
  components: {
    TheHeader
  }
}
</script>

<style>
  @import url('https://fonts.googleapis.com/css2?family=Ubuntu:wght@400;700&display=swap');

  * {
    box-sizing: border-box;
    margin: 0;
    padding: 0;
    font-family: 'Ubuntu', sans-serif;
  }

  #central-div {
    width: 100vw;
    height: 100vh;
    display: flex;
  }

  .wrapper {
    height: 100%;
    width: 100%;
    background-color: #495579;
    display: flex;
    justify-content: center;
    align-items: center;
  }

  #app {
    display: flex;
    flex-direction: column;
    overflow: hidden;
    height: 100vh;
    background-color: #495579;
  }

</style>
