function displayMonthName() {
   
    let monthNumber = parseInt(prompt("Enter a month number (1-12):"));

    if (isNaN(monthNumber) || monthNumber < 1 || monthNumber > 12) {
        console.log("Please enter a valid month number between 1 and 12.");
        return;
    }

    
    let monthName;
    switch (monthNumber) {
        case 1:
            monthName = "January";
            break;
        case 2:
            monthName = "February";
            break;
        case 3:
            monthName = "March";
            break;
        case 4:
            monthName = "April";
            break;
        case 5:
            monthName = "May";
            break;
        case 6:
            monthName = "June";
            break;
        case 7:
            monthName = "July";
            break;
        case 8:
            monthName = "August";
            break;
        case 9:
            monthName = "September";
            break;
        case 10:
            monthName = "October";
            break;
        case 11:
            monthName = "November";
            break;
        case 12:
            monthName = "December";
            break;
        default:
            monthName = "Invalid month";
            break;
    }

    
    console.log(`The month is ${monthName}.`);
}


displayMonthName();
