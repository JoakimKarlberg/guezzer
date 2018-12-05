const axios = require('axios');
const url = 'http://localhost:5000/api/Results';


module.exports = function(playerName, category, score){
       axios({
         method: 'put',
         url: url,
         data:{
           Name: playerName,
           Category: category,
           Score: score
         }
       })
       .then(results => console.log(results));
}