<template>

    <div class="CountDownTimer">
      <v-progress-linear height="20" color="blue darken-1" class="timerWidth" v-model.number="valueDeterminate"></v-progress-linear> 
    </div>

</template>

<script>
 
export default {
  data() {
    return {
      timerId: null,
      totalTime: 20,
      timeRemaining: 0,
      valueDeterminate: 100,
      pointStreakTracker: 0,
      noAnswerObject: {'startValue':'','endValue':''}
    }
  },

  methods: {
    startTimer() {
      this.timerId = setInterval(() => this.countdown(), 1000);
    },

    stopTimer() {
      clearInterval(this.timerId);
      this.timerId = null;
    },
    
    refreshTimer() {
      this.totalTime = 20;
      this.valueDeterminate = 100;
    },

    generateCorrectScore(){
      console.log("right answer");
      this.pointStreakTracker++;
      console.log(this.pointStreakTracker);

      if(this.timeRemaining >= 10){
        this.$parent.score+=15;
        console.log("15, time left: " + this.timeRemaining);
      }
      else if(this.timeRemaining >= 5 && this.timeRemaining < 10){
        this.$parent.score+=10;
        console.log("10, time left: " + this.timeRemaining);
      }
      else if(this.timeRemaining > 0 && this.timeRemaining < 5){
        this.$parent.score+=5;
        console.log("5, time left: " + this.timeRemaining);
      }
  },
   
    countdown() 
    {     
        this.totalTime--;
        this.timeRemaining = this.totalTime;

        if (this.totalTime == 0) 
        {
         this.$parent.checkAnswer(this.noAnswerObject);
         this.$parent.getNewQuestion();
        }

        if (this.totalTime == 15)
        {
          this.$emit('alertQuestionPage')
        }

        if (this.totalTime <= 15) 
        {
          this.valueDeterminate -= 6.666;
        }
    },

    formatTime(time) {
      return (time < 10 ? '0' : '') + time;
    }
  },

  computed: {
    minutes() {
      let minutes = Math.floor(this.totalTime / 60);
      return this.formatTime(minutes);
    },
    seconds() {
      let seconds = this.totalTime - (this.minutes * 60);
      return this.formatTime(seconds);
    }
  },  
}
</script>

<style scoped>
  .timerWidth{
    width: 642px;
  }
</style>

