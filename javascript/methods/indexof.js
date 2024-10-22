<!DOCTYPE html>
<html>
<body>
<h1>JavaScript Arrays</h1>
<h2>The indexOf() Method</h2>

<p id="demo"></p>

<script>
const fruits =  [ "Apple","Orange","Mango"];
let position = fruits.indexOf("Apple") ;

document.getElementById("demo").innerHTML = "Apple is found in position " + position;
</script>

</body>
</html>
