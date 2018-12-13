<template>
    <div class="TopList">
        <h3>{{ header }}</h3>
        <!-- <h3>{{ playedCategory }}</h3> -->
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
export default {
  name: 'TopList',
  props:['category'],
  data () {
    return {
      results: {},
      header: 'Toplist'
      //,playedCategory: this.category
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
      console.log('SELECTED CATEGORY IS: ' + this.category);

      // ta ut scores från den kategorin som spelats
      if(this.getTopTenResults.includes(this.category))
      {
        return _.orderBy(this.results, 'score', 'desc').slice(0, 10)
      }
    }
  }
}
</script>

<style scoped>

</style>


