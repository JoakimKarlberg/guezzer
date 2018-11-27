<template>
     <div class="PlayAgainButton">
        <button v-on:click="PlayAgainButton">Play Again</button>
    </div>
</template>

<script>
export default {
  name: 'PlayAgainButton',
  data() {
    return {
      msg: ""
    }
  }
};
</script>

<style scoped>

</style>