<template>
     <div class="score-container">
        <h2>{{saveScoreMsg}} </h2>
        <div class="enter-name-field">
          {{enterNameMsg}}
        <input type="text" value="">
        </div>
        <button class="btn btn-success" v-on:click="submitScoreButton">Submit Score</button>
    </div>
</template>

<script>
export default {
  name: 'SubmitScore',
  data() {
    return {
      enterNameMsg: "Enter your name:",
      saveScoreMsg: "Save score?"
    }
  },
  methods: {
    submitScoreButton(){
    console.log('subtmitScoreButton works fine')
   }
  }
};
</script>

<style scoped>
.score-container{
  padding: 10px;
}
.enter-name-field{
  padding-bottom: 15px;
}
</style>