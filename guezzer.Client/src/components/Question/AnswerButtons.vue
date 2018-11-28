<template>
     <div class="AnswerButtons">
         <button class="btn btn-primary"  v-for="answer in answersFirstRow" @click="checkAnswer">{{ answer }}</button>
         <div style='clear:both'></div>
         <button class="btn btn-primary"  v-for="answer in answersSecondRow" @click="checkAnswer">{{ answer }}</button>
    </div>
</template>




<script>
import 'bootstrap/dist/css/bootstrap.css'
import 'bootstrap-vue/dist/bootstrap-vue.css'

export default {
    data() {
        return  {
             answersFirstRow: ['0-1000', '1001-10000', ],
             answersSecondRow: ['10001-100000', 'More than 100000']
        }
    },

    methods: {
    async checkAnswer(){
        
   }
  }
};
</script>

<style scoped>

.btn-primary {
    width: 30%;
    margin: 15px 30px;
    
}

</style>