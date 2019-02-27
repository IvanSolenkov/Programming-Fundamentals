function sameNumbers(input) {
    let numbers = input.toString().split('').map(Number);

    let equal = numbers.every( (val, i, arr) => val === arr[0]);
    let totalAmountOfNumbers = numbers.reduce((a, b) => a + b, 0);

    console.log(equal);
    console.log(totalAmountOfNumbers);
}
sameNumbers(2222222);