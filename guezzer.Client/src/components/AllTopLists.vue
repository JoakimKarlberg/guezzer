<template>
<div>
  <div class="tabless" v-for="category in groupedCategories" :key="category.id">
	<h3 class="blue darken-2 white--text pl-3 py-1">{{ header }} {{ category[0].category }}</h3>
    <table>
      <thead>
        <tr>
          <th>Rank</th>
          <th>Player</th>
          <th>Score</th>
        </tr>
      </thead>
      <tbody>
        <tr v-for="(item, index) of category.slice(0, 10)" :key="item.id">
          <td>{{ startIndexAtOne(index) }}</td>
          <td>{{ item.name }}</td>
          <td>{{ item.score }}</td>
        </tr>
      </tbody>
    </table> 
  </div>
</div>
</template>

<script>
import _ from 'lodash'
import axios from 'axios'
const url = 'http://localhost:5000/api/Results';

export default {
  name: 'AllTopLists',
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
  methods: {
    startIndexAtOne: function (index) {
      return index+1
    }
  },
  computed: {
    groupedCategories: function () {
      if(!this.results) 
      {
        return [];
      } 
      else 
      {
        var ordered = _.orderBy(this.results, 'score', 'desc');
        return _.groupBy(ordered, 'category');
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


