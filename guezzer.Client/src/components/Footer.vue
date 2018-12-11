<template>
     <div class="footer">
       Copyright grej blabla. Vanlig info som brukar stå <br/>
      <p>
      <a href="#/">Landing page</a> |
      <a href="#/Resultpage">Result Page</a> |
      <a href="#/Categorypage">Category Page</a> |
      <a href="#/YoutubePage">Try the Youtube Test Page</a> |
      <a href="#/QuestionPage">Check out the question page</a>
      </p>
    </div>
</template>

<script>
export default {
  name: 'Footer'
};
</script>

<style scoped>
.footer {
    position: relative;
    padding: 10px;
    left: 0;
    bottom: 0;
    height: 100px;
    width: 100%;
    overflow: hidden;
    border-top: 1px solid black;
    text-align: left;
}
</style>