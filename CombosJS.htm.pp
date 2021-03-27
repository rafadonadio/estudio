<html >
<head>
    <title>Prueba combos por javascript</title>
</head>

<script>
function  SetCombo(c1){
	//alert('hola');
	var valueC1 = c1.value;
	var cbo2 = document.getElementById("combo2");
	var i;
	for(i=cbo2.options.length-1;i>=0;i--)
	{
		cbo2.remove(i);
	}
	for(i=0;i<20;i++)
	{
		var optn = document.createElement("OPTION");
		optn.text = valueC1 +" ."+ i;
		optn.value = valueC1 + i;
		cbo2.options.add(optn);
	}
	SetHora();
}
function SetHora()
{	
	dd =new Date();
	var fecha = document.getElementById('hora').innerHTML = dd.toLocaleString()+":"+dd.getMilliseconds();
}
</script>
<body onload="document.getElementById('combo1').focus(); SetHora();">
Primer combo
<select id=combo1 name="combo1" onchange="SetCombo(this);">
	<option value=1>1</option>
	<option value=2>2</option>
	<option value=3>3</option>
	<option value=4>4</option>
	<option value=5>5</option>
	<option value=6>6</option>
	<option value=7>7</option>
	<option value=8>8</option>
	<option value=9>9</option>
	<option value=10>10</option>
</select>
<br />
Segundo combo
<select id=combo2 name="combo2">
	<option value=1>1.1</option>
	<option value=2>1.2</option>
	<option value=3>1.3</option>
</select>
<br>
Fecha y Hora<div id=hora></div>
</body>
</html>
