<template>
    <div class="list">
        <h3>{{ header }} {{ category }}</h3>
        <label for="score">{{score}}</label>
        <ul>
            <li>{{ score }}</li>
            <li>Hello</li>
            <li>Hello</li>
            <li>Hello</li>
            <li>Hello</li>
            <GetResult></GetResult>
        </ul>
    </div>
</template>

<script>
import GetResult from './ResultApi/GetResult.js'

export default {
    name: 'TopList',
    components: { //here comes the response from GetResult.js
        GetResult
    },
    data() {
    return {
        //properties defined here
      header: "Top score for category: ",
      category: "",
      playerName: "",
      score: "",
      topList: [] // playerName + score 
      };
    },
    methods: {
    getResult: function() {
        console.log('JALLLLAAA' + this.score);
      GetResult(this.playerName, this.category, this.score)
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


