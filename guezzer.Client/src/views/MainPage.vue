<template>
    <div class="MainPage">
        <img src="../assets/guezzerlogo.png">
        <h1>{{msg}}</h1>
        <ul>
            <li>
            <a href="https://github.com/JoakimKarlberg/guezzer" target="_blank">
            Projects Github Repository
            </a>
            </li>
        </ul>
    </div>
</template>


<script>
export default {
  name: 'MainPage',
  data() {
    return {
      msg: "Welcome to the Guezzer Main Page!"
    }
  }
};
</script>

<style scoped>
h1,
h2 {
  font-weight: normal;
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
