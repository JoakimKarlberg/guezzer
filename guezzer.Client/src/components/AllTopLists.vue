<template>
    <div class="AllTopLists">
        <h3 class="blue darken-2 white--text pl-3 py-1">{{ header }} {{ this.category }} </h3>
     <table>
      <thead>
        <tr>
          <th>Name</th>
          <th>Score</th>
        </tr>
      </thead>
      <tbody>
        <tr v-for="result in results" :key="result.id">
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
const url = 'http://localhost:5000/api/Results';

export default {
  name: 'AllTopLists',
  props:['category'],
  data () {
    return {
      results: null,
      header: 'Toplist for category '
    }
  },
  created () {
    axios.get(url)
      .then(response => {
        this.results = response.data
      })
      .catch(err => {
        console.log(err)
      })
  },
  computed: {
    topTenResults: function () {
        console.log(this.results_request)
      if(!this.results_request) 
      {
        return [];
      } 
      else 
      {
          
        return _.orderBy(this.results_request.filter(score => score.category === this.category), 'score', 'desc').slice(0, 10);
      }
    }
  }
}
</script>

<style scoped>
  th{
    margin-right: 20px;
  }
</style>


