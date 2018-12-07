
let axios = require('axios');
let Base_URL = "https://www.googleapis.com/youtube/v3/videos";


module.exports = function(options, callback) {
    if (!options.apiKey) {
        throw new Error('Youtube search would require a key');
    }

    let params = {
        id: options.videoId,
        part: 'statistics',
        key: options.apiKey, 
    };

    axios.get(Base_URL, {params})
        .then(response => {
            if(callback) { callback(response.data.items) }
        })
        .catch(error => console.error(error));
}
