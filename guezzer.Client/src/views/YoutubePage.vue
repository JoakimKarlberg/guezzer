<template>
    <div class="YoutubePage">
       <h1>{{msg}}</h1>
        <video-item></video-item>
    </div>

</template>

<script>
import VideoItem from '@/components/Youtube/VideoItem.vue'

export default {
    components: {
        VideoItem
    },
  name: 'YoutubePage',
  data() {
    return {
        msg: "Welcome to the YoutubePage Page!",
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
    }
  }
</script>

<style scoped>
h1,
h2 {
  font-weight: normal;
}
ul {
  list-style-type: none;
  padding: 0;
}
li {
  display: inline-block;
  margin: 0 10px;
}
a {
  color: #42b983;
}
</style>
