<template>
    <div class="VideoItem">
        <!-- This is the vue-youtube dudeman. All it needs to play a video is the ID of the youtube video-->
        <youtube :video-id="fetchedVideoId" ref="youtube" @playing="playing"></youtube>
    </div>
</template>

<script>
import Search from './Search.js'
import YoutubeApiKey from 'C:/GuezzerAppSecrets.js' // should not be stored locally eventually
import YoutubeRandomizer from './YoutubeRandomizer.js'
import { EventBus } from '@/components/Youtube/event-bus.js';

export default {
    data () {
        return {
            fetchedVideoId: null
        }
    },
    
    props:['category'],
    
    //These methods are a part of the vue-youtube package that allows youtube-play functionality. It's really good!
    //Here's the documentation: https://www.npmjs.com/package/vue-youtube 
    //Supports stuff like autoplay and things. 
    methods: {
      playing(){
        EventBus.$emit("playVideo"); 
      },
      
      getVideo() {
      
      // Here the Search.js-function is called when the component is created.
      // This is a request to the youtube-API and basically gets the youtube ID that is used in the ':video-id="fetchedVideoId"' binding in the HTML.
      Search({
            apiKey: YoutubeApiKey, 
            searchWord: YoutubeRandomizer.methods.GetSelectedCategory(this.category), // This little cutie simulates searching 'cats' on youtube and picking first video - should be randomized
            sortOrder: YoutubeRandomizer.methods.GetRandomOrder()
        }, response => this.fetchedVideoId = response.id.videoId); // should not return only Id. Should return the whole response instead so you can get the data you want from the youtube request.
    }
    },
    computed: {
      player(){
        return this.$refs.youtube.player;
      }
    },
    created () {
        this.getVideo();
    }
}
</script>