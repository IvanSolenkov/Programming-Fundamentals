function solve(orders) {
    let totalPrice = 0;
    for (let order of orders) {
        let hasMilk = false;
        let orderPrice = 0;
        let splittedOrderElement = order.split(', ');
        let sugar = +splittedOrderElement[splittedOrderElement.length - 1];
        let insertedCoins = splittedOrderElement[0];
        let typeOfDrink = splittedOrderElement[1];
        if(typeOfDrink === "coffee"){
            if(splittedOrderElement[2] === "caffeine"){
                orderPrice+=0.80;
            } else{
                orderPrice+=0.90;
            }
            if(splittedOrderElement.length === 5){
                hasMilk = true;
            }
        }else{
            orderPrice+=0.80;
            if(splittedOrderElement.length === 4){
                hasMilk = true;
            }
        }
        if(hasMilk){
            orderPrice += Math.ceil(orderPrice * 0.1) / 10;
        }
        if(+sugar !== 0){
            orderPrice+=0.10;
        }
        if(insertedCoins < orderPrice){
            let neededMoney = orderPrice - insertedCoins;
            console.log(`Not enough money for ${typeOfDrink}. Need ${neededMoney.toFixed(2)}$ more.`);
        }else{
            let change = insertedCoins - orderPrice;
            totalPrice += orderPrice;
            console.log(`You ordered ${typeOfDrink}. Price: ${orderPrice.toFixed(2)}$ Change: ${change.toFixed(2)}$`);
        }
    }
    console.log(`Income Report: ${totalPrice.toFixed(2)}$`);
}

coffeeMachine();