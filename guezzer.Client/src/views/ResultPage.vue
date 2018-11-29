<template>
    <div class="wrapper">
        <div class="container">
        <result></result>
        <submit-score></submit-score>
        <div class="wrapper">
            <div class="container">
            <play-again-button></play-again-button>
            </div>
            <div class="container">
            <home-button></home-button>
            </div>
        </div>
        </div>
        <div class="container">
            <top-list></top-list> 
        </div>
    </div>
</template>

<script>
    import Result from '@/components/Result.vue'
    import SubmitScore from '@/components/SubmitScore.vue'
    import PlayAgainButton from '@/components/PlayAgainButton.vue'
    import HomeButton from '@/components/HomeButton.vue'
    import TopList from '@/components/TopList.vue'

    export default {
    components: {
        Result,
        SubmitScore,
        PlayAgainButton,
        HomeButton,
        TopList
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