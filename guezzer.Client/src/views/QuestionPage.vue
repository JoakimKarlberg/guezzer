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
                            <countdown-timer class="countdownTimer" ref="timer"></countdown-timer>
                        </v-flex>
                    </v-layout>

                    <answer-buttons class="answerButtons" @answerButtonClicked="checkAnswer"></answer-buttons>                      

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
            category: ' '
        }
    },
    created(){
        this.category = this.$route.params.category;
    },
    methods: {

        getViewCounts(viewCount) {
            this.viewCount = viewCount;
        },

        checkAnswer(answer){

            this.$refs.timer.stopTimer();
            this.score =  HandleAnswer.methods.CheckAnswer(this.viewCount, answer);
            console.log(this.score);

            if (this.questionIndex >= this.numberOfQuestions)
            {
            EventBus.$off('playVideo');   
            this.$router.push({ name: 'ResultPage', params: {score: this.score, category: this.category}});
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
