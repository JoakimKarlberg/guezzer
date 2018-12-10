<template>
  <v-radio-group row>
    <v-radio color="red darken-3" label="Funny" value="funny" v-on:change="emitToParent"></v-radio>
    <v-radio color="orange darken-3" label="Music" value="music" v-on:change="emitToParent"></v-radio>
    <v-radio color="yellow darken-1" label="Random" value="random" v-on:change="emitToParent"></v-radio>
  </v-radio-group>

  <!-- <div class="SelectCategory">

      <input type="radio" id="categoryFunny" name="customRadioButton"
      v-on:change="emitToParent" value="funny">
      <label for="categoryFunny">Funny</label>
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
  </div> -->

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