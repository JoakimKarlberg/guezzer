let maxValue = 1000000;

export default {

    methods:{
         
         CheckAnswer: function(rightAnswer,answer){

            console.log(answer.startValue)

            if(parseInt(answer.startValue)<=parseInt(rightAnswer) &&
             parseInt(answer.endValue)>= parseInt(rightAnswer)){
                return 'Du hade rätt';
            }
            else
            {
              return 'Du hade fel';
            }
         }      
    }
}