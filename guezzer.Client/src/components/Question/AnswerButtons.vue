<template>
     <div class="AnswerButtons">
         <v-btn class="deep-purple darken-2 white--text btn-primary btn-1 mt-4" :disabled="checkIfQuestionStarted" v-for="(objectAnswer,index) in objectAnswers" :key="index" @click="$emit('answerButtonClicked', objectAnswer)">{{ objectAnswer.startValue+ ' - ' +objectAnswer.endValue }}</v-btn>
    </div>
</template>




<script>

export default {
    data() {
        return  {
             objectAnswers: [{'startValue':'0','endValue':'1000'},
             {'startValue':'1001','endValue':'100 000'},{'startValue':'100 001','endValue':'1000 000'},
             {'startValue':'More than','endValue':'1000 000 '}]
        }
    },

    props: {
      startQuestion: Boolean
    },

    computed: {
    checkIfQuestionStarted() {
      if(this.startQuestion === true)
        return false;
      else
        return true;
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