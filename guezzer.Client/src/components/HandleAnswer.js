let maxValue = 1000000;
let rightOption = null;

export default {

    methods: {

        GetRightOption: function (rightAnswer, objectAnswers) {

            objectAnswers.forEach(option => {

                let trimmedStartValue = Trim(option.startValue);
                let trimmedEndValue = Trim(option.endValue);

                if (trimmedStartValue <= rightAnswer &&
                    trimmedEndValue >= rightAnswer || (option.startValue == "More than" && rightAnswer > maxValue)) {

                    rightOption = option;
                }

            });

            return rightOption;
        },

        CheckAnswer: function (rightOption, answer) {

            if (rightOption.endValue == answer.endValue)
                return true;
            else {
                return false;
            }
        }
    }
}

function Trim(string) {
    return parseInt(string.replace(/\s+/g, ''));
}