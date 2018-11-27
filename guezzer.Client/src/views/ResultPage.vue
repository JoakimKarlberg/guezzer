<template>
    <div>
        <Result></Result>
        <SubmitScore></SubmitScore>
        <div class="container">
            <div class="item1">
            <PlayAgainButton></PlayAgainButton>
            </div>
            <div class="item2">
            <HomeButton></HomeButton>
            </div>
        </div>
    </div>
</template>

<script>
    import Result from '@/components/Result.vue'
    import SubmitScore from '@/components/SubmitScore.vue'
    import PlayAgainButton from '@/components/PlayAgainButton.vue'
    import HomeButton from '@/components/HomeButton.vue'
    import 'bootstrap/dist/css/bootstrap.css'
    import 'bootstrap-vue/dist/bootstrap-vue.css'

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
.container {
    display: flex;
}
.item1 { 
    padding: 5px;   
}
.item2 {
    padding: 5px;  
}
</style>