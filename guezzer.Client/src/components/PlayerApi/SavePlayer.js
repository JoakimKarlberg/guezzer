const axios = require('axios');
const url = 'http://localhost:5000/api/Players';


module.exports = function(playerName){
       axios({
         method: 'put',
         url: url,
         data:{
           Name: playerName
         }
       })
       .then(results => console.log(results));
}
