<template>
    <div class="wrapper">
        <div class="container">
        <Result></Result>
        <SubmitScore></SubmitScore>
        <div class="wrapper">
            <div class="container">
            <PlayAgainButton></PlayAgainButton>
            </div>
            <div class="container">
            <HomeButton></HomeButton>
            </div>
        </div>
        </div>
        <div class="container">
        HiscoreList top 10 component for played category is to be inserted here
        </div>
    </div>
</template>

<script>
    import Result from '@/components/Result.vue'
    import SubmitScore from '@/components/SubmitScore.vue'
    import PlayAgainButton from '@/components/PlayAgainButton.vue'
    import HomeButton from '@/components/HomeButton.vue'

    export default {
    components: {
        Result,
        SubmitScore,
        PlayAgainButton,
        HomeButton
        }
    }
</script>

<style scoped>
.wrapper {
    display: flex;
}
.container {
    padding: 5px;
}
</style>