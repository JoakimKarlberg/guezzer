export default {
     data:{ 
          categoryList: ["all","music","funny","cats","epic fails","gaming",
          "sport","tv","dance","cartoon","travel","irl","programming","weather",
          "christmas", "rick and morty", "animals","cats", "dogs","fails","puppies"],
          
          orderList: ["date","rating","relevance","title","videoCount","viewCount"]
     }
     ,
     methods:{
          GetRandomValue:function(array){
          return array[Math.floor(Math.random() * array.length)];;
     }}
}