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
        <tr v-for="result in results" :key="result.id">
          <td>{{ result.name }}</td>
          <td>{{ result.score }}</td>
          <td>{{ result.category }}</td>
        </tr>
      </tbody>
    </table>
    </div>
</template>

// <script>
// import axios from 'axios'
// import GetResult from './ResultApi/GetResult.js'

// export default {
//     name: 'TopList',
//     data() {
//     return {
//        header: "Top score for category: ",
//        results: []
//       }
//     },
//     methods: {
//     getResult: function() {//getResult function should be called in template? make a list from this??
//       GetResult()
//     }
//   }
// }
// </script>

<script>
import axios from 'axios'
const url = 'http://localhost:5000/api/Results';

export default {
  name: 'TopList',
  data () {
    return {
      results: {},
      header: 'Toplist for category'
    }
  },
  created () {
    axios.get(url)
      .then(response => {
        console.log(response.data)
        this.results = response.data
      })
      .catch(err => {
        console.log(err)
      })
  }
}
</script>


<style scoped>

</style>


