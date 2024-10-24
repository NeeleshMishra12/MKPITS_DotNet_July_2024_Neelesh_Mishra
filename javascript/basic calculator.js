// Basic Calculator Function
function calculator(a, b, operation) {
    switch (operation) {
        case 'add':
            return a + b;
        case 'subtract':
            return a - b;
        case 'multiply':
            return a * b;
        case 'divide':
            return a / b;
        default:
            return "Invalid operation";
    }
}

// Example usage
console.log(calculator(10, 5, 'add'));
console.log(calculator(10, 5, 'divide')); 
