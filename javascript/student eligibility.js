function checkAdmissionEligibility() {
   
    let examScore = parseFloat(prompt("Enter your entrance exam score (out of 100):"));
    let gpa = parseFloat(prompt("Enter your previous academic performance (GPA, out of 4.0):"));

    if (isNaN(examScore) || isNaN(gpa) || examScore < 0 || examScore > 100 || gpa < 0 || gpa > 4.0) {
        console.log("Please enter valid scores: exam score between 0-100 and GPA between 0-4.0.");
        return;
    }

   
    const requiredExamScore = 70;
    const requiredGPA = 3.0;

    if (examScore >= requiredExamScore && gpa >= requiredGPA) {
        console.log("Congratulations! You are eligible for admission.");
    } else if (examScore >= requiredExamScore) {
        console.log("Your entrance exam score is sufficient, but your GPA does not meet the requirement.");
    } else if (gpa >= requiredGPA) {
        console.log("Your GPA meets the requirement, but your entrance exam score is insufficient.");
    } else {
        console.log("Unfortunately, you do not meet the eligibility criteria for admission.");
    }
}

checkAdmissionEligibility();
