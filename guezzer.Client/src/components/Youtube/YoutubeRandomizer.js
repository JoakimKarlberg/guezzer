

export default {

     methods:{
          GetSelectedCategory: function(selectedCategory){

               switch (selectedCategory) {
                    case "Music":
                         return GetRandomValue(musicCategoryList);    

                    case "Random":
                         return GetRandomValue(randomCategoryList);

                    case "Funny":
                         return GetRandomValue(funnyCategoryList);
                    default:
                         break;
               }
          },
          GetRandomOrder: function(){
               let orderList = ["date","rating","relevance","title","videoCount","viewCount"];
               return GetRandomValue(orderList);
          }      
     }
}

function GetRandomValue(array){
     return array[Math.floor(Math.random() * array.length)];;
}

let randomCategoryList = ["all","music","funny","cats","epic fails","gaming",
"sport","tv","dance","cartoon","travel","irl","programming","weather",
"christmas", "rick and morty", "animals","cats", "dogs","fails","puppies"];

let musicCategoryList = ["music metal","music classical","music reggae", "music jazz", "music house", 
"music pop", "music hard rock", "music R&B",
"music singer/songwriter","music opera","music asian pop","electronic music","music christmas songs"];

let funnyCategoryList = ["funny fails", "funny animals", "funny clowns", "funny pranks", "funny moments", "funny videos",
"funny laugh", "funny songs", "funny babies", "funny languages", "funny drunk people", "funny people",
"funny news fail"];



