<template>
  <div class="TopList">
    <h3 class="blue darken-2 white--text py-1" id="header-size">{{ this.category }} high scores </h3>
     <table>
      <thead>
        <tr>
          <th>Rank</th>
          <th>Player</th>
          <th>Score</th>
        </tr>
      </thead>
      <tbody>
        <tr v-for="(result, index) in topTenResults" :key="result.id">
          <td>{{ startIndexAtOne(index) }}</td>
          <td>{{ result.name }}</td>
          <td>{{ result.score }}</td>
        </tr>
      </tbody>
    </table>
  </div>
</template>

<script>
import _ from 'lodash'
import axios from 'axios'
import GetScores from './PlayerApi/GetScores.js'
const url = 'http://localhost:5000/api/Results';


export default {
  name: 'TopList',
  props:['category'],
  data () {
    return {
      results: null
    }
  },
  created () {
    this.getScores();
  },
  methods: {
    startIndexAtOne: function (index) {
      return index+1
    },
    getScores() {
      GetScores(response => this.results = response);
    }

  },
  computed: {
    topTenResults: function () {
      return (!this.results ? [] : _.orderBy(this.results.filter(score => score.category === this.category), ['score', 'date'], 'desc').slice(0, 10));
    }
  }
}
</script>

<style scoped>
   table{ 
    text-align: center; 
    vertical-align: middle;
    margin: auto; 
  }
  .TopList{
    padding: 15px;
    text-align: center; 
    vertical-align: middle;
  }
  #header-size{
    font-size: large;
    margin-left: auto;
    margin-right: auto;
    width: 200px;
  }
  
</style>


