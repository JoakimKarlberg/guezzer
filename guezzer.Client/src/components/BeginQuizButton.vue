<template>
  <v-btn
    color="success"
    x-large
    router-link :to="{name: 'QuestionPage', 
    params: {category: this.selectedCategory}}" 
    tag="button"
    :disabled="radioButtonValue">
    <span>begin</span>
    <v-icon x-large>forward</v-icon>
  </v-btn>
</template>

<script>

import { EventBus } from "./Youtube/event-bus.js";

export default {
  data(){
    return {
      selectedCategory: ' '
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
  },
  computed:{
    radioButtonValue: function(){
      if(this.selectedCategory === ' ')
        return true;
      else
        return false;
    }
  }
};
</script>
