const axios = require('axios');
const url = 'http://localhost:5000/api/Results';


module.exports = function(options,callback){
       axios({
         method: 'put',
         url: url,
         data:{
           Name: options.nameInput,
           Category: options.category,
           Score: options.score
         }
       })
       .then(response => {
            if(callback)
            callback(response)
            console.log(response);
        })
        .catch(err => {
            console.log(err)
        })

}