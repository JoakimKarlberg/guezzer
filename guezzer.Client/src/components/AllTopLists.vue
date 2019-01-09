<template>
    <div class="AllTopLists">
    <li v-for="category in groupedCategories" :key="category.id">
      <h3 class="blue darken-2 white--text pl-3 py-1">{{header}} {{category.category}}</h3>
      <ul>
        <li v-for="item of category" :key="item.id">
          {{item.name}}
          {{item.score}}
          {{item.category}}
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
      header: 'Toplist for category '
    }
  },
  created () {
    axios.get(url)
      .then(response => {
        this.results = response.data
        console.log(this.results)
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
        var grouped = _.groupBy(this.results, 'category')
        console.log(grouped);
        return grouped;
        
        //_.orderBy(this.grouped.filter(score => score.category === 'Funny'), 'score', 'desc').slice(0, 10);
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
</style>


