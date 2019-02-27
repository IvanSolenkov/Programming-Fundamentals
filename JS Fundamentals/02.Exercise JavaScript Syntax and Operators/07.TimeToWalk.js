function timeToWalk(numberOfSteps, steps, speedInKmH) {
    let distanceInMeters = numberOfSteps * steps;

    let speedMeterInSecond = speedInKmH / 3.6;

    let timeSecond = Math.round(distanceInMeters / speedMeterInSecond);

    let rest = Math.floor(distanceInMeters / 500);
    timeSecond += rest * 60;

    let seconds = timeSecond % 60;
    let minutes = (timeSecond - seconds) / 60;
    let hours = Math.floor((timeSecond - seconds) / 3600);

    formatTheOutput(hours,minutes,seconds);

    function formatTheOutput(hours,minutes,seconds) {
        if(hours < 10){
            hours = '0' + hours;
        }
        if(minutes < 10){
            minutes = '0' + minutes;
        }
        if(seconds < 10){
            seconds = '0' + seconds;
        }

        console.log(`${hours}:${minutes}:${seconds}`)
    }
}


timeToWalk(4000, 0.60, 5);