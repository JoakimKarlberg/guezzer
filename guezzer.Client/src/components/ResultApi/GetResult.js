import axios from 'axios'
const url = 'http://localhost:5000/api/Results';

export default {
  name: 'GetResult',
  data () {
    return {
      results: {}
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





// const axios = require('axios');
// const url = 'http://localhost:5000/api/Results';

// module.exports = function(){
//        axios({
//          method: 'get',
//          url: url,
//          data() {
//             return {
//                 results: []
//             }
//          }
//        })
//        .then(response => {
//          this.results = response.data
//          console.log(this.results)
//         });
// }
