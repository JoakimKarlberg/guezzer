let maxValue = 1000000;

export default {

    methods:{
        
         GetRightOption: function(rightAnswer,objectAnswers) {
            
            objectAnswers.forEach(option => {

                let trimmedStartValue = Trim(option.startValue);
                let trimmedEndValue = Trim(option.endValue);

                if(trimmedStartValue <=rightAnswer &&
                trimmedEndValue >= rightAnswer || (option.startValue == "More than" && rightAnswer > maxValue)) {
                    
                    console.log(option);
                    return option;
            }

            });
            
         },

         CheckAnswer: function(rightOption,answer){

            
         },
    }
}

function Trim (string){
    return parseInt(string.replace(/\s+/g, ''));
}