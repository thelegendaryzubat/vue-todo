<template>
  <img alt="Vue logo" src="./assets/logo.png">
  <ToDo/>
</template>

<script lang="ts">
import { defineComponent } from 'vue'
import ToDo from './components/HelloWorld.vue'

export default defineComponent({
  name: 'App',
  components: {
    ToDo
  }
})
</script>

<style>
#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
  margin-top: 60px;
}
</style>
