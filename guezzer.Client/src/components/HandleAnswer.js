let maxValue = 1000000;

export default {

    methods:{
        
         
         CheckAnswer: function(rightAnswer,answer){

            let trimmedStartValue = Trim(answer.startValue);
            let trimmedEndValue = Trim(answer.endValue);

            if(trimmedStartValue <=rightAnswer &&
             trimmedEndValue >= rightAnswer || (answer.startValue == "More than" && rightAnswer > maxValue)) {
 
                return true;
            }
            else
            {
              return false;
            }
         }      
    }
}

function Trim (string){
    return parseInt(string.replace(/\s+/g, ''));
}