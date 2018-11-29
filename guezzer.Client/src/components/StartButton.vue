<template>
    <div>
        <button class="startButton"> Start </button>
    </div>
</template>

<script>
export default {
    name: 'StartButton',
}
</script>

<style scoped>
    .startButton{
        background-color: #4CAF50;
        border: none;
        color: white;
        padding: 15px 32px;
        text-align: center;
        border-radius: 6px;
        display: inline-block;
        font-size: 30px;
        -webkit-transition-duration: 0.4s; 
        transition-duration: 0.4s;
    }
    .startButton:hover {
    background-color :#d01313;
    }
</style>