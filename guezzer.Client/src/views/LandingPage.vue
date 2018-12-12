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

          <v-layout row wrap>
            <v-flex xs12>
              <top-list/>
              <top-list/>
              <top-list/>
            </v-flex>
          </v-layout>

        </v-flex>
      </v-layout>
    </v-container>
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
      }
    }
  };
</script>