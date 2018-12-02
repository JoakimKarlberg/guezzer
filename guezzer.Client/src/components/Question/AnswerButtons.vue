<template>
     <div class="AnswerButtons">
         <button class="btn btn-primary" v-for="(answer,index) in answers" :key="index" @click="$emit('answerButtonClicked')">{{ answer }}</button>
    </div>
</template>




<script>
import 'bootstrap/dist/css/bootstrap.css'
import 'bootstrap-vue/dist/bootstrap-vue.css'

export default {
    data() {
        return  {
             answers: ['0-1000', '1001-10000','10001-100000', 'More than 100000']
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