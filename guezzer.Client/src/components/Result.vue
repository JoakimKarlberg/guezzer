<template>
     <div class="Result">
        <h1>{{msg}}</h1>

        <div class="score-box">{{score}}</div>
    </div>
</template>

<script>
export default {
  name: 'Result',
  data() {
    return {
      msg: "Your result: ",
      score: "5/10"
    }
  }
};
</script>

<style scoped>
.Result {
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