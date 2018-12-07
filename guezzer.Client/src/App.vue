<template>
<v-app class="grey lighten-3">
  <Header/>
    <v-component>
      <router-view/>
    </v-component>
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

