<template>

  <v-toolbar app flat class="red darken-4 white--text">
    <v-toolbar-title>
      <router-link to="/" class="white--text noUnderline">
        <span router-link :to="{name: 'LandingPage'}" class="font-weight-heavy">G</span><span class="font-weight-light">uezzer</span>
      </router-link>
    </v-toolbar-title>
    
    <top-list-button/>

    <v-spacer></v-spacer>

      <v-btn flat color="white">
        <span>Exit</span>
        <v-icon right>exit_to_app</v-icon>
      </v-btn>

  </v-toolbar>

</template>

<script>
import TopListButton from '@/components/TopListButton.vue'

export default {
  name: 'Header',
  components: {
        TopListButton
    },
};
</script>

<style scoped>
  .noUnderline{
    text-decoration: none;
  }
</style>
