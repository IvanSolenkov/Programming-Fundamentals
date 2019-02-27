function fitnessRates(dayOfWeek,service,time) {
    let totalPrice = 0;
    let firstTime = 8.00;
    let secondTime = 15.00;
    let thirdTime = 22.00;

    if (dayOfWeek === "Monday" || dayOfWeek === "Tuesday" || dayOfWeek === "Wednesday" || dayOfWeek === "Thursday" || dayOfWeek === "Friday") {
        if (service === "Fitness") {
            if (time >= firstTime && time <= secondTime) {
                totalPrice += 5.00;
            } else if (time > secondTime && time <= thirdTime) {
                totalPrice += 7.50;
            }
        } else if (service === "Sauna") {
            if (time >= firstTime && time <= secondTime) {
                totalPrice += 4.00;
            } else if (time > secondTime && time <= thirdTime) {
                totalPrice += 6.50;
            }
        } else if (service === "Instructor") {
            if (time >= firstTime && time <= secondTime) {
                totalPrice += 10.00;
            } else if (time > secondTime && time <= thirdTime) {
                totalPrice += 12.50;
            }
        }
    } else if (dayOfWeek === "Saturday" || dayOfWeek === "Sunday") {
        if (service === "Fitness") {
            if (time >= firstTime && time <= secondTime) {
                totalPrice += 8.00;
            } else if (time > secondTime && time <= thirdTime) {
                totalPrice += 8.00;
            }
        } else if (service === "Sauna") {
            if (time >= firstTime && time <= secondTime) {
                totalPrice += 7.00;
            } else if (time > secondTime && time <= thirdTime) {
                totalPrice += 7.00;
            }
        } else if (service === "Instructor") {
            if (time >= firstTime && time <= secondTime) {
                totalPrice += 15.00;
            } else if (time > secondTime && time <= thirdTime) {
                totalPrice += 15.00;
            }
        }
    }
    console.log(totalPrice);
}



fitnessRates('Monday', 'Sauna', '15.30');