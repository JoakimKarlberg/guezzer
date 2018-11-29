<template>
     <div class="display-result">
        <h1>{{msg}}</h1>

        <div class="score-box">{{score}}</div>
    </div>
</template>

<script>
export default {
  name: 'DisplayResult',
  data() {
    return {
      msg: "Your result: ",
      score: "5/10"
    }
  },
  methods: {
    Result(score){
      return this.score;
    }
  }
};
</script>

<style scoped>
.display-result {
  padding: 20px;
}
.score-box{
  font-size: 5rem;
  padding: 0.4rem;
  border-style: solid;
  width: fit-content;
  margin: auto;
}
</style>