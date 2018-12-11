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
             {'startValue':'1001','endValue':'10000'},{'startValue':'10001','endValue':'100000'},
             {'startValue':'More than','endValue':'100000'}]
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