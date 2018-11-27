<template>
     <div class="SubmitScore">
        {{msg}}
        <input type="text" value="enter name here...">
        <button v-on:click="submitScoreButton">Submit Score</button>
    </div>
</template>

<script>
export default {
  name: 'SubmitScore',
  data() {
    return {
      msg: "Enter your name:"
    }
  }
};
</script>

<style scoped>

</style>