<!DOCTYPE html>
<html>
<body>
<h1>JavaScript Arrays</h1>
<h2>The lastIndexOf() Method</h2>

<p id="demo"></p>

<script>
const fruits = ["Apple", "Orange", "Apple", "Mango"];
let position = fruits.lastIndexOf("Apple") ;

document.getElementById("demo").innerHTML = "Apple is found in position " + position;
</script>

</body>
</html>
