<template>
     <div class="Result">
        <img src="../assets/guezzerlogo.png">

        <h1>{{msg}}</h1>
    </div>
</template>

<script>
export default {
  name: 'Result',
  data() {
    return {
      msg: "Your result: 5/10"
    }
  }
};
</script>

<style scoped>
.Result {
  padding: 20px;
}
</style>