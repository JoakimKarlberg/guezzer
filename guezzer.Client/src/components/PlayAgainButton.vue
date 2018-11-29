<template>
     <div class="button-container">
       <router-link to="/CategoryPage" tag="button" class="btn btn-primary">Play again?</router-link>
    </div>
</template>

<script>
export default {
  name: 'PlayAgainButton'
};
</script>

<style scoped>
.button-container{
  margin-top: 50px;
  position:relative;
  float:right;
}
</style>