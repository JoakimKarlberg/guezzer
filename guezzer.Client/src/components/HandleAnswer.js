let maxValue = 1000000;
let scoreCounter = 0;

export default {

    methods:{
        
         
         CheckAnswer: function(rightAnswer,answer){

            let trimmedStartValue = Trim(answer.startValue);
            let trimmedEndValue = Trim(answer.endValue);

            if(trimmedStartValue <=rightAnswer &&
             trimmedEndValue >= rightAnswer || (answer.startValue == "More than" && rightAnswer > maxValue)) {
                scoreCounter++; 
                return scoreCounter;
            }
            else
            {
              return scoreCounter;
            }
         }      
    }
}

function Trim (string){
    return parseInt(string.replace(/\s+/g, ''));
}