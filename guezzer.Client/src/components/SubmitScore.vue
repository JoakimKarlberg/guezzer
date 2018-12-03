<template>
     <div class="score-container">
        <h2>{{saveScoreMsg}} </h2>
        <div class="enter-name-field">
          {{enterNameMsg}}
        <input id="name" v-model="nameInput"  type="text">
        </div>
        <button class="btn btn-success" v-on:click="submitPlayer">Submit Score</button>
    </div>
</template>

<script>
import axios from 'axios';
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
    submitPlayer: function (){

      axios({
        method: 'put',
        url: 'http://localhost:53268/api/Players',
        data:{
          Name: this.nameInput
        }
      });

      // axios.put('http://localhost:53268/api/Players', {Name: this.nameInput})
      // .then((response => {console.log(response)
      // })
      // .catch(error => console.log("hello" + error)));
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