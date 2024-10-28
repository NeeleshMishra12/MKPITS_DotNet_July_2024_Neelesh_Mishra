function generateFibonacci() {
    
    let n = parseInt(prompt("Enter the number of terms for the Fibonacci series:"));

    
    if (isNaN(n) || n <= 0) {
        console.log("Please enter a valid positive integer.");
        return;
    }

    let fibonacciSeries = []; 
    let a = 0; 
    let b = 1; 
    let count = 0; 

    
    do {
        fibonacciSeries.push(a); 
        let nextTerm = a + b; 
        a = b; 
        b = nextTerm; 
        count++; 
    } while (count < n); 

    
    console.log(`Fibonacci series up to ${n} terms:`, fibonacciSeries.join(", "));
}


generateFibonacci();
