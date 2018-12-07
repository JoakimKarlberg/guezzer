<template>
  <div class="home">
    <v-card-actions class="justify-center">
      <!-- <h1 class="red--text text--darken-3 display-3">{{msg}}</h1>      -->
    </v-card-actions>
        <v-card-actions class="justify-center">
          <img src="../assets/guezzerlogo.png">
          </v-card-actions>
    <start-button/>
    <div class="container">
        <top-list></top-list>
        <top-list></top-list>
        <top-list></top-list>
    </div>
  </div>
</template>


<script>
  import StartButton from '@/components/StartButton.vue'
  import TopList from '@/components/TopList.vue'

  export default {
    components: {
        StartButton,
        TopList
      },
    name: 'LandingPage',
    data() {
      return {
        msg: "Welcome to " 
      }
    }
  };
</script>

<style scoped>
  .container{
    display: flex;
    flex-direction: row;
    justify-content: center;
  }
</style>
