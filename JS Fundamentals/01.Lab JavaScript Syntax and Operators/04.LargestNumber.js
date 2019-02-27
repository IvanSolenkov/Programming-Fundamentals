function largestNumber(firstNumber, secondNumber, thirdNumber) {
    let result = 0;
    if(firstNumber > secondNumber && firstNumber > thirdNumber){
        result = firstNumber;
    }else if(secondNumber > firstNumber && secondNumber > thirdNumber){
        result = secondNumber;
    }else if(thirdNumber > firstNumber && thirdNumber > secondNumber){
        result = thirdNumber;
    }
    console.log(`The largest number is ${result}.`)
}


largestNumber(5, -3, 16);