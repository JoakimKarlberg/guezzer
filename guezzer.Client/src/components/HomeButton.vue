<template>
     <div class="HomeButton">
        <button v-on:click="HomeButton">Home</button>
    </div>
</template>

<script>
export default {
  name: 'HomeButton',
  methods: {
    HomeButton(){
    console.log('Home button works')
   }
  }
};
</script>

<style scoped>

</style>