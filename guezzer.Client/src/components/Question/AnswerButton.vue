<template>
  <div class="AnswerButton">
    <v-btn
      class="white--text btn-primary btn-1 mt-4"
      v-bind:class="classObject"
      v-bind:style="styleObject"
      :disabled="checkIfQuestionStarted"
      @click="onButtonClicked(objectAnswer)"
    >{{this.objectAnswer.startValue}} - {{this.objectAnswer.endValue}}</v-btn>
  </div>
</template>

<script>
export default {
  data() {
    return {
      isActive: false,
      isCorrect: false,
      hasAnswered: false
    };
  },
  props: {
    newQuestion: Boolean,
    startQuestion: Boolean,
    rightAnswer: Boolean,
    objectAnswer: Object,
    rightOption: Object
  },
  computed: {
    checkIfQuestionStarted() {
      if (this.startQuestion === true) {
        this.isActive = false;
        this.isCorrect = false;

        if (this.objectAnswer.endValue === this.rightOption.endValue) {
          this.isCorrect = true;
        }

        return false;
      } else return true;
    },
    classObject() {
      return {
        "deep-purple darken-2": this.newQuestion,
        'green': this.rightAnswer && this.isActive || this.isCorrect && !this.newQuestion,
        'red': !this.rightAnswer && this.isActive
      };
    },
    styleObject() {
      return {
        'pointer-events': !this.newQuestion ? 'none' : null
      }
      
    }
  },

  methods: {
    onButtonClicked(answer) {
      this.$emit("answerButtonClicked", answer);
      this.$emit("getNewQuestion");
      this.isActive = true;
    }
  }
};
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