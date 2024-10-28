function calculateTotalCost() {
   
    let item1Price = parseFloat(prompt("Enter the price of item 1:"));
    let item1Quantity = parseInt(prompt("Enter the quantity of item 1:"));

    let item2Price = parseFloat(prompt("Enter the price of item 2:"));
    let item2Quantity = parseInt(prompt("Enter the quantity of item 2:"));

    let item3Price = parseFloat(prompt("Enter the price of item 3:"));
    let item3Quantity = parseInt(prompt("Enter the quantity of item 3:"));

    if (
        isNaN(item1Price) || isNaN(item1Quantity) || item1Price < 0 || item1Quantity < 0 ||
        isNaN(item2Price) || isNaN(item2Quantity) || item2Price < 0 || item2Quantity < 0 ||
        isNaN(item3Price) || isNaN(item3Quantity) || item3Price < 0 || item3Quantity < 0
    ) {
        console.log("Please enter valid prices and quantities for all items.");
        return;
    }

  
    let subtotal = (item1Price * item1Quantity) + (item2Price * item2Quantity) + (item3Price * item3Quantity);

   
    const taxRate = 0.08; // 8% tax
    const tipRate = 0.15; // 15% tip

    
    let tax = subtotal * taxRate;
    let tip = subtotal * tipRate;

   
    let totalCost = subtotal + tax + tip;

   
    console.log(`Subtotal: $${subtotal.toFixed(2)}`);
    console.log(`Tax (8%): $${tax.toFixed(2)}`);
    console.log(`Tip (15%): $${tip.toFixed(2)}`);
    console.log(`Total Cost: $${totalCost.toFixed(2)}`);
}


calculateTotalCost();
