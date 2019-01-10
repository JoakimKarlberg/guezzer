<template>
    <div class="VideoItem">
        <div class="YoutubeCover">
        <!-- This is the vue-youtube dudeman. All it needs to play a video is the ID of the youtube video-->
        <youtube :video-id="fetchedVideoId" ref="youtube" @playing="playing" @error="handleError"  :player-vars="playerVars"></youtube>
    </div>
    </div>
</template>

<script>
import Search from './Search.js'
import GetStatistics from './GetStatistics.js'
import YoutubeApiKey from 'C:/GuezzerAppSecrets.js' // should not be stored locally eventually
import YoutubeRandomizer from './YoutubeRandomizer.js'
import { EventBus } from '@/components/Youtube/event-bus.js';

export default {
    data () {
        return {
            fetchedVideoId: null,
            playerVars: {
                autoplay: 1,
                controls: 0,
                disablekb: 1,
            },
            viewCount: null,
            videoList: []
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

      handleError(){
          this.getVideo();
      }, 
      
      getVideo() {
      
      // Here the Search.js-function is called when the component is created.
      // This is a request to the youtube-API and basically gets the youtube ID that is used in the ':video-id="fetchedVideoId"' binding in the HTML.
      Search({
            apiKey: YoutubeApiKey, 
            searchWord: YoutubeRandomizer.methods.GetSelectedCategory(this.category), // This little cutie simulates searching 'cats' on youtube and picking first video - should be randomized
            sortOrder: YoutubeRandomizer.methods.GetRandomOrder()
        }, response => this.getYoutubeViewCounts(response.id.videoId)); // should not return only Id. Should return the whole response instead so you can get the data you want from the youtube request.

        },
    getYoutubeViewCounts(videoId) {
        this.fetchedVideoId = videoId;

        GetStatistics ({
         apiKey: YoutubeApiKey, 
         videoId: this.fetchedVideoId,
        }, response => this.handleViewCounts(response));
    },

    handleViewCounts(viewCountResponse) {
        this.viewCount = viewCountResponse;
        this.$emit('passViewCount', this.viewCount)
    },

    checkIfVideoAlreadyPlayed(){
        if(this.videoList.includes(this.fetchedVideoId))
        {
            this.getVideo();
        }
        else
        {
            this.videoList.push(this.fetchedVideoId);
        }
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

<style scoped>
.YoutubeCover{
  pointer-events: none;
}
</style>