<template>
  <div class="score-container">
    <h2>{{saveScoreMsg}}</h2>
    <div class="enter-name-field">
      {{enterNameMsg}}
      <input id="name" v-model="nameInput" type="text">
    </div>
    <button class="btn btn-success" v-on:click="submitResult">Submit Result</button>
  </div>
</template>

<script>
import SavePlayer from './PlayerApi/SavePlayer.js'
export default {
  name: "SubmitScore",
  data() {
    return {
      enterNameMsg: "Enter your name:",
      saveScoreMsg: "Save score?",
      nameInput: ""
    };
  },
  methods: {
    submitResult: function() {
      SavePlayer(this.nameInput)
      //SaveResult(this.resultScore) // Here the score is saved from the DisplayResult component. 
    }
  }
};
</script>

<style scoped>
.score-container {
  padding: 10px;
}
.enter-name-field {
  padding-bottom: 15px;
}
</style>