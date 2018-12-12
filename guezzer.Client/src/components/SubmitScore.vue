<template>
  <v-flex xs12 md12 lg8 xl6>
    <form>
      <v-text-field required v-model="nameInput" :counter="50" :error-messages="nameErrors" label="Enter your name:"></v-text-field>
      <v-btn class="red darken-3 white--text" depressed v-on:click="submitResult">
        <span>Submit Result</span>
        <v-icon right>send</v-icon>
      </v-btn>
      <p>{{this.score}}</p>
      <p>{{this.category}}</p>
    </form>
  </v-flex>
</template>

<script>
import SavePlayer from './PlayerApi/SavePlayer.js'
import SaveResult from './ResultApi/SaveResult.js'
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
      SavePlayer(this.nameInput)
      SaveResult(this.nameInput, this.category, this.score) // Is hardcoded wight now for testing
    }
  }
};
</script>