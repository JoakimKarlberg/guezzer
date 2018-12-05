<template>
     <div class="button-container">
        <!-- <button class="btn btn-primary" v-on:click="BeginQuizButton">Begin</button> -->
        <router-link :to="{name: 'QuestionPage', params: {category: this.selectedCategory}}" tag="button" class="btn btn-primary">Begin</router-link>
        <i class="fas fa-arrow-right"></i>
    </div>
</template>

<script>

import { EventBus } from "./Youtube/event-bus.js";

export default {
  data(){
    return {
      selectedCategory: ''
    }
  },
  name: 'BeginQuizButton',
  methods: {
    BeginQuizButton(category){
    console.log('Begin Quiz with category ' + category)
   }
  },
  created(){
    EventBus.$on('change', (selected) => {

     this.selectedCategory = selected
    });
  }
};
</script>

<style scoped>
.button-container{
  position: absolute;
    top: 70%;
    right: 20%;
}
</style>