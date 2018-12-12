let maxValue = 1000000;

export default {

    methods:{
         
         CheckAnswer: function(rightAnswer,answer){

            let trimmedStartValue = parseInt(Trim(answer.startValue));
            let trimmedEndValue = parseInt(Trim(answer.endValue));

            if(trimmedStartValue <=rightAnswer &&
             trimmedEndValue >= rightAnswer) {
                return 'Du hade rätt';
            }
            else
            {
              return 'Du hade fel';
            }
         }      
    }
}

function Trim (string){
    return string.replace(/\s+/g, '');
}