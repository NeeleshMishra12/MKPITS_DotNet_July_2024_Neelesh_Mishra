function decimalToBinary() {
    
    let decimalNumber = parseInt(prompt("Enter a decimal number to convert it to binary:"));

    
    if (isNaN(decimalNumber) || decimalNumber < 0) {
        console.log("Please enter a valid non-negative integer.");
        return;
    }

    let binaryNumber = ""; 

    
    do {
        let remainder = decimalNumber % 2; 
        binaryNumber = remainder + binaryNumber; 
        decimalNumber = Math.floor(decimalNumber / 2); 
    } while (decimalNumber > 0); 

    
    console.log(`The binary representation is: ${binaryNumber}`);
}


decimalToBinary();
