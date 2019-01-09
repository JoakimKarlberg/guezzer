<template>
    <div class="QuestionPage">
        <v-container>
            <v-layout align-center justify-center row fill-height>
                <v-flex xs12 md12 lg8 xl6> 
                    
                    <question-title class="mb-2 mt-4" :questionIndex="questionIndex"></question-title> 
                    <v-layout>
                        <h4 class="mb-2 text-lg-right"> Category: {{category}}</h4>
                    </v-layout>

                    <video-item class="videoItem" ref="video" :category="category" @passViewCount="getViewCounts"></video-item>

                    <v-layout justify-center>
                        <v-flex> 
                            <countdown-timer v-on:alertQuestionPage="onQuestionStarted" class="countdownTimer" ref="timer"></countdown-timer>
                        </v-flex>
                    </v-layout>

                    <answer-buttons class="answerButtons" :startQuestion='startQuestion' @answerButtonClicked="checkAnswer"></answer-buttons>                      

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
import HandleAnswer from '@/components/HandleAnswer.js'
import router from '../router'
import { EventBus } from '@/components/Youtube/event-bus.js';

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
            category: ' ',
            viewCount: '',
            score: 0,
            startQuestion: false
        }
    },
    created() {
        this.category = this.$route.params.category;
        let self = this;
        EventBus.$on('playVideo', function () {
            self.$refs.timer.startTimer();
        })
    },
    methods: {

        getViewCounts(viewCount) {
            this.viewCount = viewCount;
        },
        onQuestionStarted(){
            this.startQuestion = true;
        },

        checkAnswer(answer) {

            this.$refs.timer.stopTimer();
            this.startQuestion = false;


            if (this.questionIndex >= this.numberOfQuestions)
            {  
            this.$router.push({ name: 'ResultPage', params: {score: this.score, category: this.category}});
            }

            else
            {
            this.$refs.video.getVideo();
            this.$refs.timer.refreshTimer();
            this.questionIndex++
            if(HandleAnswer.methods.CheckAnswer(this.viewCount, answer)){
            this.score++
            }
            }

        }
    },
    
    beforeRouteLeave (to, from, next) {
        this.$refs.timer.stopTimer();
        EventBus.$off('playVideo');
        next();
        
        
    }
};
</script>
