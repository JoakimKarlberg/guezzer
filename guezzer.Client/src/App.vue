<template>
  <div id="app">
    <Header></Header>
    <router-view/>
    <!-- <div class="tempFooter">
      <hr>
      <p>
      <a href="#/">Landing page</a> |
      <a href="#/Resultpage">Result Page</a> |
      <a href="#/Categorypage">Category Page</a>
      <a href="#/YoutubePage">Try the Youtube Test Page</a>
      </p>
    </div> -->

  <Footer>Footer</Footer>
  </div>
</template>

<script>
import Footer from '@/components/Footer.vue'
import Header from '@/components/Header.vue'

export default {
  components: {
        Footer,
        Header
        },
  name: "App"
};
</script>

<style>
#app {
  font-family: "Avenir", Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
  margin-top: 60px;
}
/* .tempFooter{
    position: absolute;
    left: 0;
    bottom: 0;
    height: 100px;
    width: 100%;
    overflow: hidden;
} */
</style>
