function categorizeBMI() {
   
    let weight = parseFloat(prompt("Enter your weight in kilograms:"));
    let height = parseFloat(prompt("Enter your height in meters:"));

   
    if (isNaN(weight) || isNaN(height) || weight <= 0 || height <= 0) {
        console.log("Please enter valid positive numbers for weight and height.");
        return;
    }
  
    let bmi = weight / (height * height);

    let category;
    if (bmi < 18.5) {
        category = "Underweight";
    } else if (bmi >= 18.5 && bmi < 24.9) {
        category = "Normal weight";
    } else if (bmi >= 25 && bmi < 29.9) {
        category = "Overweight";
    } else {
        category = "Obese";
    }

   
   
    console.log(`Your BMI is ${bmi.toFixed(1)}, which falls into the category: ${category}`);
}

categorizeBMI();
