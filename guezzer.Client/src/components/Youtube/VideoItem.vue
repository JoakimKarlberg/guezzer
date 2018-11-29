<template>
    <div class="VideoItem">
        <h1>Video!</h1>
        <h5>id: {{fetchedVideoId}}</h5>
        <!-- This is the vue-youtube dudeman. All it needs to play a video is the ID of the youtube video-->
        <youtube :video-id="fetchedVideoId" ref="youtube" @playing="playing"></youtube>
        <br>
        <button @click="playVideo"> Play </button>
        <button @click="pauseVideo"> Pause </button>
    </div>
</template>

<script>
import Search from './Search.js'
import YoutubeApiKey from 'C:/GuezzerAppSecrets.js' // should not be stored locally eventually
import YoutubeRandomizer from './YoutubeRandomizer.js'



export default {
    data () {
        return {
            fetchedVideoId: null
        }
    },
    //These methods are a part of the vue-youtube package that allows youtube-play functionality. It's really good!
    //Here's the documentation: https://www.npmjs.com/package/vue-youtube 
    //Supports stuff like autoplay and things. 
    methods: {
      async playVideo(){
        await this.player.playVideo();
      },
      async pauseVideo(){
        await this.player.pauseVideo();  
      },
      playing(){
        console.log('We are watching!'); 
      }
    },
    computed: {
      player(){
        return this.$refs.youtube.player;
      }
    },
    created () {
      
      // Here the Search.js-function is called when the component is created.
      // This is a request to the youtube-API and basically gets the youtube ID that is used in the ':video-id="fetchedVideoId"' binding in the HTML.
      Search({
            apiKey: YoutubeApiKey, 
            searchWord: YoutubeRandomizer.methods.GetRandomValue(YoutubeRandomizer.data.categoryList), // This little cutie simulates searching 'cats' on youtube and picking first video - should be randomized
            sortOrder: YoutubeRandomizer.methods.GetRandomValue(YoutubeRandomizer.data.orderList)
        }, response => this.fetchedVideoId = response[0].id.videoId); // should not return only Id. Should return the whole response instead so you can get the data you want from the youtube request.
    }
}
</script>
