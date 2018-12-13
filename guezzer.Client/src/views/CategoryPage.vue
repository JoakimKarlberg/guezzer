<template>
  <div class="categoryPage">

    <v-container>
      <v-layout align-center justify-center row fill-height>
        <v-flex xs12 md6>

        <v-layout justify-center>
          <h1 class="mt-5">{{quizTitle}}</h1>
        </v-layout>

        <v-layout justify-center>
          <v-icon class="mb-5">arrow_downward</v-icon>
        </v-layout>

        <v-layout justify-center>
          <SelectCategory/>
        </v-layout>

        <v-flex>
          <v-card color="blue-grey lighten-1" class="white--text mt-5">
            <v-card-title primary-title>
            <div>
            <div class="headline">Instructions</div>
            <QuizDescription/>
            </div>
            </v-card-title>
          </v-card>
        </v-flex>

        <v-layout align-end justify-end class="mt-5">
          <BeginQuizButton/>
        </v-layout>

      </v-flex>
    </v-layout>
  </v-container>

  </div>
</template>

<script>
import BeginQuizButton from "@/components/BeginQuizButton.vue";
import QuizDescription from "@/components/QuizDescription.vue";
import SelectCategory from "@/components/SelectCategory.vue";

export default {
  name: "CategoryPage",
  data() {
    return {
      quizTitle: "Select the category you want to play"
    };
  },
  components: {
    BeginQuizButton,
    SelectCategory,
    QuizDescription
  }
};

</script>

<style scoped>
h1,
h2 {
  font-weight: normal;
  margin-bottom: 50px;
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
.card {
  /* Added this to center the card */
  margin: 0 auto;
  float: none;
  margin-bottom: 10px;
}
</style>