function isPerfectSquare() {
    
    let number = parseInt(prompt("Enter a number to check if it's a perfect square:"));

    
    if (isNaN(number) || number < 0) {
        console.log("Please enter a valid, non-negative number.");
        return;
    }

   
    let squareRoot = Math.sqrt(number);

    
    if (squareRoot === Math.floor(squareRoot)) {
        console.log(`${number} is a perfect square.`);
    } else {
        console.log(`${number} is not a perfect square.`);
    }
}


isPerfectSquare();
