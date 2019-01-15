<template>
  <v-btn depressed class="primary white--text" large tag="button" router-link :to="{name: 'LandingPage'}">
    <v-icon left large>home</v-icon>
    <span>Home page</span>
  </v-btn>  
</template>

<script>
  export default {
    name: 'HomeButton'
  };
</script>
