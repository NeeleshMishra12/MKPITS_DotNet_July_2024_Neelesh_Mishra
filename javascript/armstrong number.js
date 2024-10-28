function isArmstrong(num) {
  
    let strNum = num.toString();
    let length = strNum.length;
    let sum = 0;

   
    for (let digit of strNum) {
        sum += Math.pow(parseInt(digit), length);
    }

   
    return sum === num;
}

function findArmstrongNumbers() {
        let N = parseInt(prompt("Enter a positive integer N to find Armstrong numbers between 1 and N:"));

 
    if (isNaN(N) || N < 1) {
        console.log("Please enter a valid positive integer.");
        return;
    }

    console.log(`Armstrong numbers between 1 and ${N}:`);
    
    
    for (let i = 1; i <= N; i++) {
        if (isArmstrong(i)) {
            console.log(i); // Print the Armstrong number
        }
    }
}

findArmstrongNumbers();
