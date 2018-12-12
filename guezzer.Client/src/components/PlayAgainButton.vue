<template>
  <v-btn depressed class="green white--text" large tag="button" router-link to="/CategoryPage">
    <v-icon left large>play_arrow</v-icon>
    <span>Play again?</span>
  </v-btn>  

</template>
    

<script>
  export default {
    name: 'PlayAgainButton'
  };
</script>
