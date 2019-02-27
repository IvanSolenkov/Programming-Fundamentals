function greatestCommonDivisor(firstNumber, secondNumber) {
    if(firstNumber === 0){
        console.log(secondNumber);
    }
    while (secondNumber !== 0){
        if(firstNumber > secondNumber){
            firstNumber = firstNumber - secondNumber;
        }else{
            secondNumber = secondNumber - firstNumber;
        }
    }
    console.log(firstNumber);
}



greatestCommonDivisor(2154, 458);