
let side1 = parseFloat(prompt("Enter the length of side 1:"));
let side2 = parseFloat(prompt("Enter the length of side 2:"));
let side3 = parseFloat(prompt("Enter the length of side 3:"));


function determineTriangleType(a, b, c) {
    if (a <= 0 || b <= 0 || c <= 0) {
        return "Invalid input. All side lengths must be positive numbers.";
    }
    if (a === b && b === c) {
        return "The triangle is Equilateral.";
    } else if (a === b || b === c || a === c) {
        return "The triangle is Isosceles.";
    } else {
        return "The triangle is Scalene.";
    }
}


console.log(determineTriangleType(side1, side2, side3));
