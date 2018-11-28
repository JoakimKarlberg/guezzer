<template>
    <div class="LandingPage">
        <img src="../assets/guezzerlogo.png">
        <h1>{{msg}}</h1>
        <start-button></start-button>
        <top-list></top-list>
        <top-list></top-list>
        <top-list></top-list>
    </div>
</template>


<script>
import StartButton from '@/components/StartButton.vue'
import TopList from '@/components/TopList.vue'

export default {
  components: {
      StartButton,
      TopList
    },
  name: 'LandingPage',
  data() {
    return {
      msg: "Welcome to Guezzer!"
    }
  }
};
</script>

<style scoped>
h1,
h2 {
  font-weight: normal;
  font-size: 300%;
}
ul {
  list-style-type: none;
  padding: 0;
}
li {
  display: inline-block;
  margin: 0 10px;
}
a {
  color: #42b983;
}
</style>
