<template>
     <div class="AnswerButtons">
         <button class="btn btn-primary" v-for="(objectAnswer,index) in objectAnswers" :key="index" @click="$emit('answerButtonClicked', objectAnswer)">{{ objectAnswer.startValue+ ' - ' +objectAnswer.endValue }}</button>
    </div>
</template>




<script>
import 'bootstrap/dist/css/bootstrap.css'
import 'bootstrap-vue/dist/bootstrap-vue.css'

export default {
    data() {
        return  {
             objectAnswers: [{'startValue':'0','endValue':'1000'},
             {'startValue':'1001','endValue':'100 000'},{'startValue':'100 001','endValue':'1000 000'},
             {'startValue':'More than','endValue':'1000 000 '}]
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