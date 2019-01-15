<template>
  <div class="home">
    <v-container>
      <v-layout align-center justify-center row fill-height>
        <v-flex xs12 lg6>

          <v-layout justify-center>
            <img src="../assets/guezzerlogo.png" class="mt-4">
          </v-layout>

          <v-layout justify-center>
            <div>
              <all-top-lists class="mx-5 mb-3"/>
            </div>
          </v-layout>

        </v-flex>
      </v-layout>
    </v-container>
  </div>
</template>

<script>
  import AllTopLists from '@/components/AllTopLists.vue'

  export default {
    components: {
        AllTopLists
      },
    name: 'TopListPage',
    data() {
      return {
      }
    }
  };
</script>

<style scoped>
  @media screen and (max-width: 720px) {
  .container{
    flex-direction: column;
  }
}
</style>
