//Yo! 
//This is a javascript function i wrote to ask the youtube api for videos. 
//Here you decide what parameters to get from a youtube video. 
//This function is used in "VideoItem.vue" under created to instantiate the function

let axios = require('axios');
let Base_URL = "https://www.googleapis.com/youtube/v3/search";

module.exports = function(options, callback) {
    if (!options.apiKey) {
        throw new Error('Youtube search would require a key');
    }

    let params = {
        part: 'snippet',
        key: options.apiKey,
        q: options.searchWord,
        maxResults: (options.maxResults) ? options.maxResults : 1,
        type: 'video'
    };

    axios.get(Base_URL, {params})
        .then(response => {
            if(callback) { callback(response.data.items) }
        })
        .catch(error => console.error(error));
}