export default {
     data:{ 
          randomCategoryList: ["all","music","funny","cats","epic fails","gaming",
          "sport","tv","dance","cartoon","travel","irl","programming","weather",
          "christmas", "rick and morty", "animals","cats", "dogs","fails","puppies"],
          
          orderList: ["date","rating","relevance","title","videoCount","viewCount"],

          musicCategoryList: ["metal","classical","reggae", "jazz", "house", "pop", "hard rock", "R&B",
          "singer/songwriter","opera","asian pop","electronic music","christmas songs"]
     }
     ,
     methods:{
          GetRandomValue:function(array){
          return array[Math.floor(Math.random() * array.length)];;
     }}
}