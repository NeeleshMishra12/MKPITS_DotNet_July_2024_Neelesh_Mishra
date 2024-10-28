function atmMachine() {
    
    let balance = 1000;

    while (true) {
       
        let choice = prompt("Welcome to the ATM!\nPlease select an option:\n1. Check Balance\n2. Deposit\n3. Withdraw\n4. Exit");

       
        choice = parseInt(choice);

       
        switch (choice) {
            case 1:
              
                console.log(`Your current balance is: $${balance.toFixed(2)}`);
                break;

            case 2:
                
                let depositAmount = parseFloat(prompt("Enter amount to deposit:"));
                if (isNaN(depositAmount) || depositAmount <= 0) {
                    console.log("Please enter a valid amount.");
                } else {
                    balance += depositAmount;
                    console.log(`Deposit successful! Your new balance is: $${balance.toFixed(2)}`);
                }
                break;

            case 3:
               
                let withdrawAmount = parseFloat(prompt("Enter amount to withdraw:"));
                if (isNaN(withdrawAmount) || withdrawAmount <= 0) {
                    console.log("Please enter a valid amount.");
                } else if (withdrawAmount > balance) {
                    console.log("Insufficient balance.");
                } else {
                    balance -= withdrawAmount;
                    console.log(`Withdrawal successful! Your new balance is: $${balance.toFixed(2)}`);
                }
                break;

            case 4:
               
                console.log("Thank you for using the ATM. Goodbye!");
                return; 

            default:
               
                console.log("Invalid option. Please select a valid option.");
        }
    }
}


atmMachine();
