<template>
     <div class="AnswerButton">
         <v-btn class= "white--text btn-primary btn-1 mt-4" v-bind:class="classObject" :disabled="checkIfQuestionStarted" @click="onButtonClicked(objectAnswer)">{{this.objectAnswer.startValue}} - {{this.objectAnswer.endValue}}</v-btn>
    </div>
</template>

<script>

export default {
    data() {
        return  {
             objectAnswers: []
        }
    },

    props: {
      newQuestion: Boolean,
      startQuestion: Boolean,
      rightAnswer: Boolean,
      objectAnswer: Object
    },

    computed: {
    checkIfQuestionStarted() {
      if(this.startQuestion === true)
        return false;
      else
        return true;
    },
    
    classObject() {

      return {
      'deep-purple darken-2': this.newQuestion,
      'green': this.rightAnswer,
      'red' : !this.rightAnswer
    }
    }
    },

    methods: {
      onButtonClicked(answer){
        this.$emit('answerButtonClicked', answer);
        this.$emit('getNewQuestion');
      

      }
    },

    created() {
        this.$emit('passObjectAnswers', this.objectAnswers);
    }

}

</script>

<style scoped>
.btn-primary {
    width: 305px;
}
@media screen and (max-width: 788px) {
  .btn-primary {
    width: 620px;
  }
}
</style>