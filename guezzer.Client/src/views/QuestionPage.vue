<template>
    <div class="QuestionPage">
        <v-container>
            <v-layout align-center justify-center row fill-height>
                <v-flex xs12 md12 lg8 xl6> 
                    
                    <question-title class="mb-2 mt-4" :questionIndex="questionIndex"></question-title>
                    <video-item class="videoItem" ref="video" :category="category"></video-item>
                    <answer-buttons class="answerButtons" @answerButtonClicked="checkAnswer"></answer-buttons>  
                    
                    <v-layout>
                        <countdown-timer class="countdownTimer" ref="timer"></countdown-timer>
                    </v-layout>

                </v-flex>
            </v-layout>            
        </v-container>

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

