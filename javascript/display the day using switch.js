function getDayOfWeek() {
    
    let dayNumber = parseInt(prompt("Enter a number (1-7) for the day of the week:\n1 for Sunday\n2 for Monday\n3 for Tuesday\n4 for Wednesday\n5 for Thursday\n6 for Friday\n7 for Saturday"));

   
    if (isNaN(dayNumber) || dayNumber < 1 || dayNumber > 7) {
        console.log("Please enter a valid number between 1 and 7.");
        return;
    }

    let dayName;

    
    switch (dayNumber) {
        case 1:
            dayName = "Sunday";
            break;
        case 2:
            dayName = "Monday";
            break;
        case 3:
            dayName = "Tuesday";
            break;
        case 4:
            dayName = "Wednesday";
            break;
        case 5:
            dayName = "Thursday";
            break;
        case 6:
            dayName = "Friday";
            break;
        case 7:
            dayName = "Saturday";
            break;
        default:
            console.log("Invalid day number.");
            return;
    }

 
    console.log(`The day of the week is ${dayName}.`);
}


getDayOfWeek();
