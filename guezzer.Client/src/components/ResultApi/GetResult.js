import axios from 'axios'
const url = 'http://localhost:5000/api/Results';

export default {
  data () {
    return {
      results: []
    }
  },
  mounted() {
    this.results = [
      {
        id: "d023c5e3-ca3c-4d97-933a-1112a8516eee",
        score: 9001,
        updated: "2018-12-07T13:48:33.6366278",
        player: "Johanna",
        category: "Funny"
      },
      {
        id: "398b65fb-e741-4801-be49-926b111ec871",
        score: 99,
        updated: "2018-12-11T11:13:42.8312936",
        player: "Johanna",
        category: "Music"
      }
    ];
  },
  created () {
    axios.get(url)
      .then(response => {
        console.log(response.data)
        //this.results = response.data
        response.data
      })
      .catch(err => {
        console.log(err)
      })
  }
}
