<template>
    <div class="QuestionPage">
       <question-title></question-title>
       <video-item class=video></video-item>
       <div class="container">
       <answer-buttons class="answerButtons"></answer-buttons>
       <countdown-timer class="countdownTimer"></countdown-timer>
       </div>


    </div>

</template>


<script>
import QuestionTitle from '@/components/Question/QuestionTitle.vue'
import AnswerButtons from '@/components/Question/AnswerButtons.vue'
import VideoItem from '@/components/Question/VideoItem.vue'
import CountdownTimer from '@/components/Question/CountdownTimer.vue';

export default {
    components: {
        QuestionTitle,
        AnswerButtons,
        VideoItem,
        CountdownTimer,
    },
};

</script>

<style scoped>

.container {
    margin-top: 15px;
    display: flex;
    justify-content: center;

}

.answerButtons {
    width: 50%;
}

.countdownTimer {
    margin-top: 55px;

}

</style>
