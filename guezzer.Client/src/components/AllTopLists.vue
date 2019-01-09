<template>
  <div>
    <li v-for="category in groupedCategories" :key="category.id">
      <h3 class="blue darken-2 white--text pl-3 py-1">{{header}} {{category[0].category}}</h3>
      <h4>{{name}}{{score}}</h4>
      <ul>
        <li v-for="item of category" :key="item.id">
          {{item.name}}
          {{item.score}}
        </li>
      </ul>
    </li>
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
      header: 'Toplist for category ',
      name: 'Name ',
      score: ' Score'
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
    groupedCategories: function () {
      if(!this.results) 
      {
        return [];
      } 
      else 
      {
        var ordered = _.orderBy(this.results, 'score', 'desc').slice(0, 10); 
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
  li{
    list-style-type: none;
  }
  ul{
    padding: 5px;
  }
</style>


