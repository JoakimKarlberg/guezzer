<template>
     <div class="HomeButton">
        <button v-on:click="HomeButton">Home</button>
    </div>
</template>

<script>
export default {
  name: 'HomeButton',
  data() {
    return {
      msg: ""
    }
  }
};
</script>

<style scoped>

</style>