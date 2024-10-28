function calculateSeriesSum() {

    let N = parseInt(prompt("Enter a positive integer N to find the sum of the series 1 + 1/2 + 1/3 + ... + 1/N:"));

  
    if (isNaN(N) || N <= 0) {
        console.log("Please enter a valid positive integer.");
        return;
    }

    let sum = 0; 

    
    for (let i = 1; i <= N; i++) {
        sum += 1 / i; // Add the reciprocal of i to the sum
    }

  
    console.log(`The sum of the series 1 + 1/2 + 1/3 + ... + 1/${N} is: ${sum}`);
}


calculateSeriesSum();
