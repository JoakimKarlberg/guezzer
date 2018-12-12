<template>

  <v-toolbar app flat class="red darken-4 white--text">
    <v-toolbar-title>
      <router-link to="/" class="white--text noUnderline">
        <span router-link to="/" class="font-weight-heavy">G</span><span class="font-weight-light">uezzer</span>
      </router-link>
    </v-toolbar-title>
    
    <v-btn flat color="white">
      <v-icon left>format_list_numbered</v-icon>
      <span>Top lists</span>
    </v-btn>

    <v-spacer></v-spacer>

      <v-btn flat color="white">
        <span>Exit</span>
        <v-icon right>exit_to_app</v-icon>
      </v-btn>

  </v-toolbar>

</template>

  <!-- <v-header app class="grey--text" height="auto">
    <img src="../assets/guezzerlogo.png" >
    <v-divider>
    </v-divider>
  </v-header> -->

<script>
export default {
  name: 'Header'
};
</script>

<style scoped>
  .noUnderline{
    text-decoration: none;
  }
</style>
