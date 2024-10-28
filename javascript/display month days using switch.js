function calculateDaysInMonth() {
    
    let monthNumber = parseInt(prompt("Enter a month number (1-12):"));
    let year = parseInt(prompt("Enter a year:"));

   
    if (isNaN(monthNumber) || monthNumber < 1 || monthNumber > 12 || isNaN(year) || year < 1) {
        console.log("Please enter a valid month number (1-12) and a positive year.");
        return;
    }

    let daysInMonth;

   
    switch (monthNumber) {
        case 1: 
        case 3: 
        case 5: 
        case 7: 
        case 8: 
        case 10: 
        case 12: 
            daysInMonth = 31;
            break;
        case 4: 
        case 6: 
        case 9: 
        case 11: 
            daysInMonth = 30;
            break;
        case 2: 
            if ((year % 4 === 0 && year % 100 !== 0) || (year % 400 === 0)) {
                daysInMonth = 29; 
            } else {
                daysInMonth = 28; 
            }
            break;
        default:
            console.log("Invalid month number.");
            return;
    }

  
    console.log(`The month ${monthNumber} in the year ${year} has ${daysInMonth} days.`);
}


calculateDaysInMonth();
