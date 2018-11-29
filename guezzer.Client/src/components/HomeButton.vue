<template>
     <div class="button-container">
        <button class="btn btn-primary" v-on:click="HomeButton">Home Page</button>
    </div>
</template>

<script>
export default {
  name: 'HomeButton',
  methods: {
    HomeButton(){
    console.log('WOW! Home button is clickable')
   }
  }
};
</script>

<style scoped>
.button-container{
  margin-top: 50px;
  position:relative;
  float:left;
}
</style>