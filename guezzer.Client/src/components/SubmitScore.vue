<template>
     <div class="score-container">
        <h2>{{saveScoreMsg}} </h2>
        <div class="enter-name-field">
          {{enterNameMsg}}
        <input id="name" @keyup.enter="submitScoreButton" v-model="nameInput"  type="text">
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
      saveScoreMsg: "Save score?",
      nameInput: ''
    }
  },
  methods: {
    submitScoreButton(name, score){
    console.log('Well done ' + this.nameInput + '! You have submitted your score: ' + score)
    return name = this.nameInput;
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