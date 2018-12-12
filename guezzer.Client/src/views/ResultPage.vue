<template>
    <div class="wrapper">
        <div class="container">
        <display-result></display-result>
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
            <top-list2></top-list2>
        </div>
    </div>
</template>

<script>
    import DisplayResult from '@/components/DisplayResult.vue'
    import SubmitScore from '@/components/SubmitScore.vue'
    import PlayAgainButton from '@/components/PlayAgainButton.vue'
    import HomeButton from '@/components/HomeButton.vue'
    import TopList from '@/components/TopList.vue'
    import TopList2 from '@/components/TopList2.vue'

    export default {
    components: {
        DisplayResult,
        SubmitScore,
        PlayAgainButton,
        HomeButton,
        TopList,
        TopList2
        }
    }
</script>

<style scoped>
.wrapper {
    display: flex;
}
.container {
    padding: 10px;
}
</style>