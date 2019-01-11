<template>
<div class="header">
<h3 class="deep-purple darken-2 white--text py-3" id="header-size">{{ header }}</h3>
  <div class="all-top-lists">
    <div class="top-list" v-for="category in groupedCategories" :key="category.id">
	  <h3 class="blue darken-2 white--text py-1">{{ category[0].category }}</h3>
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
      header: 'High scores'
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
        return [];
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
  table{ 
    text-align: center; 
    vertical-align: middle;
    margin: auto; 
  }
  .all-top-lists{
    display: flex;
    flex-direction: row;
    justify-content: center;
   
  }
  .top-list{
    padding: 15px;
    text-align: center; 
    vertical-align: middle;
  }
  .header{
     margin-top: 50px;
     justify-content: center;
     text-align: center;
  }
  #header-size{
    font-size: x-large;
  }
</style>


