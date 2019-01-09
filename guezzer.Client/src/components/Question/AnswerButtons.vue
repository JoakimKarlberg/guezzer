<template>
     <div class="AnswerButtons">
         <v-btn class= "white--text btn-primary btn-1 mt-4" v-bind:class="classObject" :disabled="checkIfQuestionStarted" v-for="(objectAnswer,index) in objectAnswers" :key="index" @click="onButtonClicked(objectAnswer)">{{ objectAnswer.startValue+ ' - ' +objectAnswer.endValue }}</v-btn>
    </div>
</template>




<script>



export default {
    data() {
        return  {
             objectAnswers: [{'startValue':'0','endValue':'1000'},
             {'startValue':'1001','endValue':'100 000'},{'startValue':'100 001','endValue':'1000 000'},
             {'startValue':'More than','endValue':'1000 000 '}],

             isCorrectColour:false,
             isNormalColour: true,
             isWrongColour:false,

        }
    },

    props: {
      startQuestion: Boolean,
      rightAnswer: Boolean
    },

    computed: {
    checkIfQuestionStarted() {
      if(this.startQuestion === true)
        return false;
      else
        return true;
    },
    
    classObject: function () {
    return {
      'deep-purple darken-2': this.isNormalColour && !this.isCorrectColour && !this.isWrongColour,
      'red': this.isCorrectColour
    }
    }
    },
    methods: {
      onButtonClicked(answer){
        this.$emit('answerButtonClicked', answer);
      

      }
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