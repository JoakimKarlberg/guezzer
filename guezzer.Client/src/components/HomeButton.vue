<template>
     <div class="button-container">
       <router-link to="/" tag="button" class="btn btn-primary">Home Page</router-link>
    </div>
</template>

<script>
export default {
  name: 'HomeButton'
};
</script>

<style scoped>
.button-container{
  margin-top: 50px;
  position: relative;
  float: left;
}
</style>