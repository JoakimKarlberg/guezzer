<template>
  <v-radio-group row>
    <v-radio color="red darken-3" label="Funny" value="funny" v-on:change="emitToParent"></v-radio>
    <v-radio color="orange darken-3" label="Music" value="music" v-on:change="emitToParent"></v-radio>
    <v-radio color="yellow darken-1" label="Random" value="random" v-on:change="emitToParent"></v-radio>
  </v-radio-group>
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