<template>
     <div class="button-container">
        <button class="btn btn-primary" v-on:click="BeginQuizButton">Begin</button>
        <i class="fas fa-arrow-right"></i>
    </div>
</template>

<script>
export default {
  name: 'BeginQuizButton',
  methods: {
    BeginQuizButton(category){
    console.log('Begin Quiz with category ' + category)
   }
  }
};
</script>

<style scoped>
.button-container{
  position: absolute;
    top: 70%;
    right: 20%;
}
</style>