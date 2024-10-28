function countDigits() {
    
    let number = prompt("Enter a number:");

   
    if (isNaN(number) || number.trim() === "") {
        console.log("Please enter a valid number.");
        return;
    }

    
    let digitCount = number.replace("-", "").length;

   
    console.log(`The number of digits in ${number} is: ${digitCount}`);
}


countDigits();
