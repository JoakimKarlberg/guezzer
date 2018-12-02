<template>
    <div class="CountDownTimer">
        <span id="minutes">{{ minutes }}</span>
        <span id="middle">:</span>
        <span id="seconds">{{ seconds }}</span>
    </div>
</template>

<script>

export default {
  data() {
    return {
      timer: null,
      totalTime: 20
    }
  },

  methods: {
    startTimer() {
      this.timer = setInterval(() => this.countdown(), 1000);
    },

    refreshTimer() {
      this.totalTime = 20;
    },

    countdown() {
      if(this.totalTime >= 1){
        this.totalTime--;
      } else{
        this.totalTime = 0;
        this.$parent.checkAnswer();
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

  created () {
      this.startTimer();
  }
}
</script>
