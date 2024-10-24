
function isPalindrome(str) {
    let reversed = str.split('').reverse().join('');
    return str === reversed;
}

// Example usage
console.log(isPalindrome("racecar")); 
console.log(isPalindrome("hello")); 
