<template>
  <div class="score-box">{{this.score}}</div>
</template>

<script>
export default {
  name: 'DisplayResult',
  props: ['score'],
  
  methods: {
    Result(score){
      return this.score;
    }
  }
};
</script>

<style scoped>
  .score-box{
    font-size: 5rem;
    padding: 0.4rem;
    border-style: solid;
}
</style>