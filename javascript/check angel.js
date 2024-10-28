function categorizeAngle() {
  
    let angle = parseFloat(prompt("Enter the angle measure in degrees:"));

    
    if (isNaN(angle) || angle < 0 || angle > 180) {
        console.log("Please enter a valid angle between 0 and 180 degrees.");
        return;
    }

    
    if (angle > 0 && angle < 90) {
        console.log("The angle is acute.");
    } else if (angle === 90) {
        console.log("The angle is a right angle.");
    } else if (angle > 90 && angle < 180) {
        console.log("The angle is obtuse.");
    } else if (angle === 180) {
        console.log("The angle is straight.");
    } else {
        console.log("The angle is neither acute, right, obtuse, nor straight.");
    }
}


categorizeAngle();
