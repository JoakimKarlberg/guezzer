<template>
     <div class="AnswerButtons">
        <v-btn class="red darken-3 white--text btn-primary btn-1 mt-3" @click="$emit('answerButtonClicked')">0-1000</v-btn>
        <v-btn class="light-green darken-3 white--text btn-primary btn-2 mt-3" @click="$emit('answerButtonClicked')">1001-10000</v-btn>
        <v-btn class="blue-grey darken-1 white--text btn-primary btn-3 mt-4" @click="$emit('answerButtonClicked')">10001-100 000</v-btn>
        <v-btn class="teal white--text btn-primary btn-4 mt-4" @click="$emit('answerButtonClicked')">More than 100 000</v-btn>
    </div>
</template>

<style scoped>
.btn-primary {
    width: 305px;
}
@media screen and (max-width: 788px) {
  .btn-primary {
    width: 620px;
  }
}
</style>