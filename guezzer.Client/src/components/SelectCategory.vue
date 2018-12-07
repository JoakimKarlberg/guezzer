<template>
  <div class="SelectCategory">
    <h5>Select Category</h5>
    <div>
      <input type="radio" id="categoryFunny" name="customRadioButton"
      v-on:change="emitToParent" value="funny">
      <label for="categoryFunny">Funny</label>
    </div>
    <div>
      <input type="radio" id="categoryMusic" name="customRadioButton"
      v-on:change="emitToParent" value="music">
      <label for="categoryMusic">Music</label>
    </div>
    <div>
      <input type="radio" id="categoryAll" name="customRadioButton"
       v-on:change="emitToParent" value="random">
      <label for="categoryAll">Random</label>
    </div>
  </div>
</template>


<script>

import { EventBus } from './Youtube/event-bus.js';

export default {
  name: "SelectCategory",
  data() {
    return {
      childMessage : ''
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