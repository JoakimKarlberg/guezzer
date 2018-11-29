<template>
  <div class="categoryPage">
    <h1>{{quizTitle}}</h1>
    <SelectCategory style="margin-top: 100px;"></SelectCategory>

    <div class="card" style="width: 50%; margin-top: 60px;">
      <div class="card-body" >
        <h5 class="card-title">Special title if we want it</h5>
        <QuizDescription></QuizDescription>
      </div>
    </div>
    <BeginQuizButton></BeginQuizButton>
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
      quizTitle: "Youtube Randomizer"
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