<!DOCTYPE html>
<html>
<body>
<h1>JavaScript Arrays</h1>
<h2>The reverse() Method</h2>
<p>The reverse() method reverses the elements in an array:</p>

<p id="demo1"></p>
<p id="demo2"></p>

<script>
// Create and display an array:
const fruits = ["Banana", "Orange", "Apple", "Mango"];
document.getElementById("demo1").innerHTML = fruits;

// Reverse the array:
fruits.reverse();

document.getElementById("demo2").innerHTML = fruits;
</script>

</body>
</html>
