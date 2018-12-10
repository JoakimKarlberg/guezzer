<template>
     <div class="AnswerButtons">
        <v-flex>
            <v-btn class="red darken-4 white--text btn-primary" v-for="(answer,index) in answers" :key="index" @click="$emit('answerButtonClicked')">{{ answer }}</v-btn>
        </v-flex>
    </div>
</template>




<script>

export default {
    data() {
        return  {
             answers: ['0-1000', '1001-10000','10001-100 000', 'More than 100 000']
        }
    }
};
</script>

<style scoped>

.btn-primary {
    width: 300px;
    margin: 15px 30px;
    
}

</style>