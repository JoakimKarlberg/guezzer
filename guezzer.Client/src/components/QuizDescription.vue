<template>
  <div class="QuizDescription">
      <p>{{description}}</p>
  </div>
</template>

<script>
export default {
  name: "QuizDescription",
  data (){
    return {
      description: 'this is the quiz description. This could text could come from the api with a request to the database, or something, this is the quiz description. This could text could come from the api with a request to the database, or something'
    }
  }
};
</script>
