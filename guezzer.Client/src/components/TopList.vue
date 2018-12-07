<template>
    <div class="list">
        <h3>{{ header }} {{ category }}</h3>
        <ul>
            <li>Hello</li>
            <li>Hello</li>
            <li>Hello</li>
            <li>Hello</li>
        </ul>
    </div>
</template>

<script>
import GetResult from './ResultApi/GetResult.js'

export default {
    name: 'TopList',
    data() {
    return {
      header: "Top score for category: ",
      category: "",
      playerName: "",
      score: null
      };
    },
  methods: {
    getResult: function() {
      GetResult(playerName, category, score) // Is hardcoded wight now for testing
    }
  }
}
</script>

<style scoped>
    li{
        list-style-type: none;
    }  
    ul{
        display:inline-block;
        border:3px solid #000;
        padding:20px;
    }
    .list{
        padding: 1%;
    }
</style>


