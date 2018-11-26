<template>
    <div class="VideoItem">
        <h1>Video!</h1>
        <h5>id: {{fetchedVideoId}}</h5>
        <youtube :video-id="fetchedVideoId" ref="youtube" @playing="playing"></youtube>
        <br>
        <button @click="playVideo"> Play </button>
        <button @click="pauseVideo"> Pause </button>
    </div>
</template>

<script>
import Search from './Search.js'

export default {
    data () {
        return {
            fetchedVideoId: null
        }
    },
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
      Search({
            apiKey: 'AIzaSyCB_0o3EEfZcY4l76Zc-Y82R2yl1LiOQmg', // this little bad boy needs to be hidden in some way
            searchWord: 'cats' // this little cutie simulates searching 'cats' on youtube and picking first video - should be randomized
        }, response => this.fetchedVideoId = response[0].id.videoId); // should not return only Id. Needs to return the whole response
    }
}
</script>
