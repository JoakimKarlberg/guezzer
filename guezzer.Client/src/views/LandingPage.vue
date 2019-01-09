<template>
  <div class="home">
    <v-container>
      <v-layout align-center justify-center row fill-height>
        <v-flex xs12 lg6>

          <v-layout justify-center>
            <img src="../assets/guezzerlogo.png" class="mt-4">
          </v-layout>

          <v-layout justify-center>
            <start-button class="mt-5"/>
          </v-layout>

          <!-- <v-layout justify-center>
            <div class="container">
                <top-list class="mx-5 mb-3"/>
                <top-list class="mx-5 mb-3"/>
                <top-list class="mx-5 mb-3"/>
            </div>
          </v-layout> -->

          <v-layout justify-center>
            <div class="container">
                  <all-top-lists class="mx-5 mb-3" v-for="result in results" :key="result.id">
                    {{ result.type }} 
                  </all-top-lists>
            </div>
          </v-layout>

        </v-flex>
      </v-layout>
    </v-container>
  </div>
</template>


<script>
  import StartButton from '@/components/StartButton.vue'
  import AllTopLists from '@/components/AllTopLists.vue'
  import axios from 'axios'
  const url = 'http://localhost:5000/api/Categories';

  export default {
    components: {
        StartButton,
        AllTopLists
      },
    name: 'LandingPage',
    data() {
      return {
        results: null
      }
    },
    created () {
    axios.get(url)
      .then(response => {
        this.results = response.data
      })
      .catch(err => {
        console.log(err)
      })
    }
  };
</script>

<style scoped>
  .container{
    display: flex;
    flex-direction: row;
    justify-content: center;
    margin-top: 50px;
  }

  @media screen and (max-width: 720px) {
  .container{
    flex-direction: column;
  }
}
</style>
