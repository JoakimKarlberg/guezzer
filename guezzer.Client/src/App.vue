<template>
<v-app class="white font">
  <Header/>
    <v-container pa-5>
      <router-view/>
    </v-container>
  <Footer/>
</v-app>
</template>

<script>
import Footer from '@/components/Footer.vue'
import Header from '@/components/Header.vue'

export default {
  components: {
        Footer,
        Header
        },
  name: "App"
};
</script>
