const axios = require('axios');
const url = 'http://localhost:53268/api/Players';


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
