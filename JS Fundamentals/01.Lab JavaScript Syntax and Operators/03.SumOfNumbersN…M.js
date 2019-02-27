function sumOfNumbers(n, m) {
    let num1 = +n;
    let num2 = +m;
    let result = 0;

    for (let i = num1; i <= num2; i++) {
        result += i;
    }
    console.log(result);
}



sumOfNumbers('1', '5');