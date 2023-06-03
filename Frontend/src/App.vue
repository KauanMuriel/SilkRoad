<script setup>
import { RouterView } from 'vue-router'
</script>

<template>
    <TheHeader/>
    <LoginPage v-if="!isUserAuthenticated" @authentication="toggleAuthentication"/>
    <main class="wrapper">
      <RouterView />
    </main>

</template>

<script>
import TheHeader from './components/layout/TheHeader.vue';
import LoginPage from './views/LoginView.vue';

export default {
  components: {
    TheHeader,
    LoginPage
  },
  data() {
    return {
      isUserAuthenticated: false
    }
  },
  methods: {
    toggleAuthentication() {
      this.isUserAuthenticated = true;
    }
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
    display: flex;
    justify-content: center;
    align-items: center;
  }

  #app {
    display: flex;
    flex-direction: column;
    overflow: hidden;
    height: 100vh;
    background-color: #2f3e46;
  }

</style>
