let maxValue = 1000000;

export default {

    methods:{
         
         CheckAnswer: function(rightAnswer,answer){

            console.log('rightAnswer' +rightAnswer);
            console.log('startValue' + (answer.startValue).replace(/\s+/g, ''));
            console.log('endvalue' + (answer.endValue).replace(/\s+/g, ''));


            if(parseInt((answer.startValue).replace(/\s+/g, '')) <=parseInt(rightAnswer) &&
             parseInt((answer.endValue).replace(/\s+/g, '')) >= parseInt(rightAnswer)){
                return 'Du hade rätt';
            }
            else
            {
              return 'Du hade fel';
            }
         }      
    }
}