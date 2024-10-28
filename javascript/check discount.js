function checkDiscountEligibility() {
    
    let purchaseAmount = parseFloat(prompt("Enter your total purchase amount:"));
    
   
    if (isNaN(purchaseAmount) || purchaseAmount < 0) {
        console.log("Please enter a valid purchase amount.");
        return;
    }

    let discount = 0;

   
    if (purchaseAmount >= 500) {
        discount = 20; 
    } else if (purchaseAmount >= 200) {
        discount = 10; 
    } else {
        discount = 0; 
    }

   
    if (discount > 0) {
        console.log(`You are eligible for a ${discount}% discount!`);
    } else {
        console.log("You are not eligible for a discount.");
    }
}

checkDiscountEligibility();
