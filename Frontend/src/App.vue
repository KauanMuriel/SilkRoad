<script setup>
import { RouterView } from 'vue-router'
</script>

<template>

  <div id="central-div">
    
    <TheHeader/>

    <main class="wrapper">
      <RouterView />
    </main>

  </div>

    <TheFooter/>
</template>

<script>
import TheHeader from './components/layout/TheHeader.vue';
import TheFooter from './components/layout/TheFooter.vue';

export default {
  components: {
    TheHeader,
    TheFooter
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
    height: 95vh;
    display: flex;
  }

  .wrapper {
    height: 100%;
    width: 85%;
    background-color: #495579;
    display: flex;
    justify-content: center;
    align-items: center;
  }

  #app {
    display: flex;
    flex-direction: column;
  }

</style>
