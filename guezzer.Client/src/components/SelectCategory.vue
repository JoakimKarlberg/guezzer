<template>
  <div class="SelectCategory">
    <h5>Select Category</h5>
    <div class="custom-control custom-radio custom-control-inline">
      <input type="radio" id="categoryAll" name="customRadioButton" class="custom-control-input">
      <label class="custom-control-label" for="categoryAll">All</label>
    </div>
    <div class="custom-control custom-radio custom-control-inline">
      <input type="radio" id="categoryMusic" name="customRadioButton" class="custom-control-input">
      <label class="custom-control-label" for="categoryMusic">Music</label>
    </div>
    <div class="custom-control custom-radio custom-control-inline">
      <input type="radio" id="categoryFunny" name="customRadioButton" class="custom-control-input">
      <label class="custom-control-label" for="categoryFunny">Funny</label>
    </div>
  </div>
</template>

<script>
export default {
  name: "SelectCategory",
};
</script>

<style scoped>

</style>