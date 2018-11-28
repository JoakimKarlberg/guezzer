<template>
     <div class="AnswerButtons">
         <button class="btn btn-primary"  v-for="answer in answers" @click="checkAnswer">{{ answer }}</button>
    </div>
</template>




<script>
export default {
    data() {
        return  {
             answers: ['0-1000', '1001-10000', '10001-100000', 'More than 100000'],
        }
    },

    methods: {
    async checkAnswer(){
        
   }
  }
};
</script>