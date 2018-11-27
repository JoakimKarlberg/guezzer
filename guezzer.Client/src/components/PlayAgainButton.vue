<template>
     <div class="PlayAgainButton">
        <button v-on:click="PlayAgainButton">Play Again</button>
    </div>
</template>

<script>
export default {
  name: 'PlayAgainButton',
  methods: {
    PlayAgainButton(){
    console.log('Play again button works')
   }
  }
};
</script>

<style scoped>

</style>