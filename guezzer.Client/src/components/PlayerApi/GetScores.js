const axios = require('axios');
const url = 'http://localhost:5000/api/Results';

module.exports = function (callback) {

    axios.get(url)
        .then(response => {
            if(callback)
            callback(response.data)
            console.log(response.data);
        })
        .catch(err => {
            console.log(err)
        })

}