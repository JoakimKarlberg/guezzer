<template>
  <div class="QuizDescription">
      <p>{{description}}</p>
  </div>
</template>

<script>
export default {
  name: "QuizDescription",
  data (){
    return {
      description: 'You will be presented with ten youtube videos and your job is to guess how many views the video has. The videos will start automatically, but you will have five seconds to watch them before the countdown timer start. The faster you answer, the more points you will receive. If you manage to get three questions right in a row, you will be awarded with 50 bonus points. Good luck!'
    }
  }
};
</script>
