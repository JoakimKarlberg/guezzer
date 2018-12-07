<template>
    <v-card-actions class="justify-center">
        <v-btn 
            depressed 
            class="green white--text" 
            large 
            tag="button" 
            router-link to="/CategoryPage">
            <v-icon large>play_arrow</v-icon>
            <span>Play</span>
        </v-btn>
    </v-card-actions>
</template>

<script>
export default {
    name: 'StartButton'
 }
</script>

play_arrow