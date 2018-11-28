<template>
  <div id="app">
    <router-view/> 
        <br>
    <hr>
   <a href="#/QuestionPage"> QuestionPage</a> | <a href="#/"> Go to Main page | </a><a href="#/YoutubePage">Try the Youtube Page</a>
  </div>
</template>

<script>
export default {
  name: 'App'
}
</script>

<style>
#app {
  font-family: 'Avenir', Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
  margin-top: 60px;
}
</style>
