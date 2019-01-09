<template>

    <div class="CountDownTimer">
      <v-progress-linear height="20" color="indigo darken-2" class="timerWidth" v-model.number="valueDeterminate"></v-progress-linear> 
    </div>

</template>

<script>
 
export default {
  data() {
    return {
      timerId: null,
      totalTime: 20,
      valueDeterminate: 100,
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
    
    countdown() 
    { 
    
        this.totalTime--;

        if (this.totalTime == 0) 
        {
         this.$parent.checkAnswer(this.noAnswerObject);
        }

        if (this.totalTime == 15)
        {
          this.$emit('alertQuestionPage')
   
        }

        if (this.totalTime <= 15) {
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

