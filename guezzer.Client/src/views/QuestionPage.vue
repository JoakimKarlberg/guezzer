<template>
    <div class="QuestionPage">
       <question-title></question-title>
       <video-item></video-item>
       </br>
       <answer-buttons></answer-buttons>
       </br>
        <countdown-timer></countdown-timer>
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
