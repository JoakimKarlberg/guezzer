<template>
    <div>
        <Result></Result>
        <SubmitScore></SubmitScore>
        <PlayAgainButton></PlayAgainButton>
        <HomeButton></HomeButton>
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

</style>