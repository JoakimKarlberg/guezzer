<template>
    <div class="QuestionPage">
       <question-title :questionIndex="questionIndex"></question-title>
       <video-item class="videoItem" ref="video"></video-item>
       <div class="container">
       <answer-buttons class="answerButtons" @answerButtonClicked="checkAnswer"></answer-buttons>
       <countdown-timer class="countdownTimer"></countdown-timer>
       </div>


    </div>

</template>


<script>
import QuestionTitle from '@/components/Question/QuestionTitle.vue'
import AnswerButtons from '@/components/Question/AnswerButtons.vue'
import VideoItem from '@/components/Youtube/VideoItem.vue'
import CountdownTimer from '@/components/Question/CountdownTimer.vue';

export default {
    components: {
        QuestionTitle,
        AnswerButtons,
        VideoItem,
        CountdownTimer,
    },
    
    data() {
        return {
            questionIndex: 1
        }
    },

    methods: {
    checkAnswer(){
        this.$refs.video.getVideo();
        this.questionIndex++
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
