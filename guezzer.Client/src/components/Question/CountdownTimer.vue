<template>
    <div class="CountDownTimer">
      <span id="minutes">{{ minutes }}</span>
      <span id="middle">:</span>
      <span id="seconds">{{ seconds }}</span>

      <!-- program the seconds to the bar -->
      <v-progress-linear height="20" color="indigo darken-2" class="timerWidth" v-model="valueDeterminate"></v-progress-linear> 

    </div>
</template>

<script>

export default {
  data() {
    return {
      timerId: null,
      totalTime: 10,
      valueDeterminate: 20,
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
      this.totalTime = 10;
    },
    
    countdown() 
    { 
      if (this.totalTime == 0) 
      {
         this.$parent.checkAnswer(this.noAnswerObject);
      }
  
      else
      {
        this.totalTime--;
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

