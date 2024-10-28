function calculatePower() {
    
    let base = parseFloat(prompt("Enter the base number:"));
    let exponent = parseInt(prompt("Enter the exponent (non-negative integer):"));

   
    if (isNaN(base) || isNaN(exponent) || exponent < 0) {
        console.log("Please enter a valid base and a non-negative integer for the exponent.");
        return;
    }

    let result = 1; 

   
    for (let i = 0; i < exponent; i++) {
        result *= base; 
    }

  
    console.log(`${base} raised to the power of ${exponent} is: ${result}`);
}


calculatePower();
