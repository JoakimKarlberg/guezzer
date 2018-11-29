export default {
     data:{ 
          categoryList: ["all","music","funny","cats","epic fails"],
          orderList: ["date","rating","relevance","title","videoCount","viewCount"]
     }
     ,
     methods:{
          GetRandomValue:function(array){
          return array[Math.floor(Math.random() * array.length)];;
     }}
}