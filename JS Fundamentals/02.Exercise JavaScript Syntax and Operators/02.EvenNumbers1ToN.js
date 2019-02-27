function evenNumbers1ToN(inputNumber) {
    for (let i = 1; i <= inputNumber; i++) {
        if(i % 2 === 0){
            console.log(i);
        }
    }
}

evenNumbers1ToN('4');