
function calculateRoots(a, b, c) {
   
    let discriminant = b * b - 4 * a * c;
    let root1, root2;

    // Check the nature of the roots based on the discriminant
    if (discriminant > 0) {
        // Two real and distinct roots
        root1 = (-b + Math.sqrt(discriminant)) / (2 * a);
        root2 = (-b - Math.sqrt(discriminant)) / (2 * a);
        console.log(`The roots are real and distinct: ${root1} and ${root2}`);
    } else if (discriminant === 0) {
        // One real root (both roots are the same)
        root1 = root2 = -b / (2 * a);
        console.log(`The roots are real and equal: ${root1}`);
    } else {
        // Complex roots
        let realPart = -b / (2 * a);
        let imaginaryPart = Math.sqrt(-discriminant) / (2 * a);
        console.log(`The roots are complex: ${realPart} + ${imaginaryPart}i and ${realPart} - ${imaginaryPart}i`);
    }
}

// Prompt the user for coefficients a, b, and c
let a = parseFloat(prompt("Enter the coefficient a (a ≠ 0): "));
let b = parseFloat(prompt("Enter the coefficient b: "));
let c = parseFloat(prompt("Enter the coefficient c: "));

// Check if 'a' is zero, as it would not be a quadratic equation
if (a === 0) {
    console.log("The coefficient 'a' cannot be zero in a quadratic equation.");
} else {
    // Call the function to calculate roots
    calculateRoots(a, b, c);
}
