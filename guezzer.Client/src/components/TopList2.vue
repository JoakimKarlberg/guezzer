<template>
    <div class="TopList">
        <h3>{{ header }}</h3>
     <table class="table table-striped">
      <thead>
        <tr>
          <th>Name</th>
          <th>Score</th>
          <th>category</th>
        </tr>
      </thead>
      <tbody>
        <tr v-for="result in resultList" :key="result.id">
          <td>{{ result.player }}</td>
          <td>{{ result.score }}</td>
          <td>{{ result.category }}</td>  
        </tr>
      </tbody>
    </table>
    </div>
</template>

<script>
import _ from 'lodash'
import results from './ResultApi/GetResult.js'

export default {
  name: 'TopList2', 
  props: ['results'],
  data() {
    return {
       header: "Top score for category: ",
       resultList: results.data().results
    }
  },
  computed: {
    orderedResults: function () {
    return _.orderBy(this.results, 'score', 'desc').slice(0,10)
    }
  }
}
</script>

<style scoped>

</style>


