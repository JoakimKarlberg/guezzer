const axios = require('axios');
const url = 'http://localhost:53268/api/Players';


module.exports = function(){
    axios.put(irl, {
        Name: 'Blabla'
      })
      .then(response => {
        console.log(response);
      })
      .catch(error => console.log(err));
}
