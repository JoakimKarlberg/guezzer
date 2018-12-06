<template>
    <div class="QuestionPage">
       <question-title :questionIndex="questionIndex"></question-title>
       <video-item class="videoItem" ref="video" :category="category"></video-item>
       <div class="container">
       <answer-buttons class="answerButtons" @answerButtonClicked="checkAnswer"></answer-buttons>
       <countdown-timer class="countdownTimer" ref="timer"></countdown-timer>
       </div>
    </div>

</template>


<script>
import QuestionTitle from '@/components/Question/QuestionTitle.vue'
import AnswerButtons from '@/components/Question/AnswerButtons.vue'
import VideoItem from '@/components/Youtube/VideoItem.vue'
import CountdownTimer from '@/components/Question/CountdownTimer.vue';
import router from '../router'

export default {
    components: {
        QuestionTitle,
        AnswerButtons,
        VideoItem,
        CountdownTimer,
    },
    
    data() {
        return {
            questionIndex: 1,
            numberOfQuestions: 10,
            category: ''
        }
    },
    created(){
        this.category = this.$route.params.category;
    },
    methods: {
        checkAnswer(){

            if (this.questionIndex >= this.numberOfQuestions)
            {
            this.$refs.timer.stopTimer();
            this.$router.push({ name: 'ResultPage' });
            }

            else
            {
            this.$refs.video.getVideo();
            this.$refs.timer.refreshTimer();
            this.questionIndex++
            }
        }
    }
};

</script>

<style scoped>

.container {
    display: flex;
    justify-content: center;
    margin-bottom: 20px;

}

.answerButtons {
    width: 50%;
}

.videoItem {
    margin: 20px;
}

.countdownTimer {
    margin-top: 55px;

}

</style>
