<template>
    <div class="TopList">
        <h3>{{ header }} {{ category }}</h3>
     <table class="table table-striped">
      <thead>
        <tr>
          <th>Name</th>
          <th>Score</th>
          <th>Category</th>
        </tr>
      </thead>
      <tbody>
        <tr v-for="result in getTopTenResults" :key="result.id">
          <td>{{ result.name }}</td>
          <td>{{ result.score }}</td>
          <td>{{ result.category }}</td>
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
  name: 'TopList',
  props:['category'],
  data () {
    return {
      results: null,
      header: 'Toplist for category: '
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
    getTopTenResults: function () {
      this.category = 'Funny';

      if(!this.results) 
      {
        return [];
      } 
      else 
      {
        return _.orderBy(this.results.filter(score => score.category === this.category), 'score', 'desc').slice(0, 10);
      }
    }
  }
}
</script>

<style scoped>

</style>


