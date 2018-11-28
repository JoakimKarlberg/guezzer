export default {GetRandomCategory}

function GetRandomCategory() {

     let categoriesList = ["all","music","funny"]
     
     var randomCategory = categoriesList[Math.floor(Math.random() * categoriesList.length)];

     return randomCategory;     
    }