<template>
  <div class="SelectCategory">
    <h5>Select Category</h5>
    <div class="custom-control custom-radio custom-control-inline">
      <input type="radio" id="categoryAll" name="customRadioButton" class="custom-control-input" 
       v-on:change="emitToParent" value="random">
      <label class="custom-control-label" for="categoryAll">All</label>
    </div>
    <div class="custom-control custom-radio custom-control-inline">
      <input type="radio" id="categoryMusic" name="customRadioButton" class="custom-control-input"
      v-on:change="emitToParent" value="music">
      <label class="custom-control-label" for="categoryMusic">Music</label>
    </div>
    <div class="custom-control custom-radio custom-control-inline">
      <input type="radio" id="categoryFunny" name="customRadioButton" class="custom-control-input"
      v-on:change="emitToParent" value="funny">
      <label class="custom-control-label" for="categoryFunny">Funny</label>
    </div>
  </div>
</template>


<script>

import { EventBus } from './Youtube/event-bus.js';

export default {
  name: "SelectCategory",
  data() {
    return {
      childMessage : ' '
    }
  }
  ,
  methods: {
    emitToParent:function(event){
      EventBus.$emit('change',event.target.value)
    }
  }
}
</script>

<style scoped>

</style>