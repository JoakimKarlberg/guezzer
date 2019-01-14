<template>
  <v-flex xs12 md12 lg8 xl6>
    <form>
      <v-text-field required v-model="nameInput" :counter="10" label="Enter your name:"></v-text-field>
      <v-btn class="red darken-3 white--text" depressed v-on:click="submitResult" :disabled="checkTextLength">
        <span>Submit Result</span>
        <v-icon right>send</v-icon>
      </v-btn>
    </form>
  </v-flex>
</template>

<script>
// import SavePlayer from './PlayerApi/SavePlayer.js'
import SaveResult from './ResultApi/SaveResult.js'
import GetScores from './PlayerApi/GetScores.js'
export default {
  name: "SubmitScore",
  data() {
    return {
      nameInput: ""
    };
  },
  
  props:['category','score'],
  
  methods: {
    submitResult: function() {
      // SavePlayer(this.nameInput)
      SaveResult(this.nameInput, this.category, this.score);
      this.$emit("submitButtonClicked");
    }
  },
  computed:{
      checkTextLength: function(){
        if(this.nameInput.length > 10 || this.nameInput.length <= 0)
          return true;
        else
          return false;
    }
  }
};
</script>