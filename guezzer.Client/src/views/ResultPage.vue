<template>
  <div class="resultPage">
    <v-container>
      <v-layout align-center justify-center row fill-height>
        <v-flex xs12 md6>

          <v-layout justify-center class="mt-3">
            <h1 class="display-3">Your result:</h1>
          </v-layout>

          <v-layout justify-center class="mt-5">
            <display-result/>
          </v-layout>

            <v-layout justify-center class="mt-5">
            <h3 class="headline">Do you want to save your score?</h3>
          </v-layout>

          <v-layout justify-center class="mt-3">
            <submit-score :score="score" :category="category"/>
          </v-layout>

          <v-layout justify-center class="mt-5">
            <play-again-button/>
            <home-button/>
          </v-layout>          

          <top-list/>

        </v-flex>
      </v-layout>
    </v-container>

    </div>
</template>

<script>
    import DisplayResult from '@/components/DisplayResult.vue'
    import SubmitScore from '@/components/SubmitScore.vue'
    import PlayAgainButton from '@/components/PlayAgainButton.vue'
    import HomeButton from '@/components/HomeButton.vue'
    import TopList from '@/components/TopList.vue'
    import router from '../router'

    export default {
    components: {
        DisplayResult,
        SubmitScore,
        PlayAgainButton,
        HomeButton,
        TopList
    },
    data() {
      return {
        category: '',
        score: 0
      }
    },
    created(){
        this.score = this.$route.params.score;
        this.category = this.$route.params.category;
    },

    }
</script>
