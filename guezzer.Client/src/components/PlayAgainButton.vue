<template>
     <div class="button-container">
        <button class="btn btn-primary" v-on:click="PlayAgainButton">Play Again?</button>
    </div>
</template>

<script>
export default {
  name: 'PlayAgainButton',
  methods: {
    PlayAgainButton(){
    console.log('Play again button also works')
   }
  }
};
</script>

<style scoped>
.button-container{
  margin-top: 50px;
  position:relative;
  float:right;
}
</style>