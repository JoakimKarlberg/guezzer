<template>
  <div class="SelectCategory"> 

      <label class="container">Music
        <input type="radio" id="categoryMusic" name="customRadioButton" v-on:change="emitToParent" value="Music">
        <span class="checkmark"></span>
      </label>
    
    <label class="container">Funny
      <input type="radio" id="categoryFunny" name="customRadioButton"
      v-on:change="emitToParent" value="Funny">
      <span class="checkmark"></span>
    </label>

    <label class="container">Random
      <input type="radio" id="categoryAll" name="customRadioButton"
      v-on:change="emitToParent" value="Random">
      <span class="checkmark"></span>
    </label>

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
  .container {
    position: relative;
    padding-left: 33px;
    margin-bottom: 5px;
    cursor: pointer;
    font-size: 16px;
    -webkit-user-select: none;
    -moz-user-select: none;
    -ms-user-select: none;
    user-select: none;
  }
  .container input {
    position: absolute;
    opacity: 0;
    cursor: pointer;
  }
  .checkmark {
    position: absolute;
    top: 22px;
    left: 0;
    height: 25px;
    width: 25px;
    border-radius: 50%;
    background-color: #ccc;
  }
  .container input:checked ~ .checkmark {
    background-color: rgb(165, 11, 23);
  }
  .checkmark:after {
    content: "";
    position: absolute;
    display: none;
  }
  .container input:checked ~ .checkmark:after {
    display: block;
  } 
  .container .checkmark:after {
    top: 9px;
    left: 9px;
    width: 8px;
    height: 8px;
    border-radius: 50%;
    background: white;
  }

@media screen and (max-width: 960px) {
  .checkmark {
    position: absolute;
    top: 14px;
    left: 0;
  }
}
</style>
