<template>
     <div class="SubmitScore">
        <h1>{{saveScoreMsg}} </h1><br/>
        <div class="enterName">{{enterNameMsg}}
        <input type="text" value="enter name here..."> <br/>
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
    console.log('is work')
   }
  }
};
</script>

<style scoped>
.SubmitScore{
  paddingp: 10px;
}
.enterName{
  padding-bottom: 15px;
}
</style>