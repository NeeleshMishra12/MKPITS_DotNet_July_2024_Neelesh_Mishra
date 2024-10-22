<!DOCTYPE html>
<html>
<body>
<h1>JavaScript Arrays</h1>
<h2>The find() Method</h2>

<p id="demo"></p>

<script>
const numbers = [4, 9, 19, 25, 29];
let first = numbers.find(myFunction);

document.getElementById("demo").innerHTML = "First number over 18 is " + first;

function myFunction(value, index, array) {
  return value > 18;
}
</script>

</body>
</html>
