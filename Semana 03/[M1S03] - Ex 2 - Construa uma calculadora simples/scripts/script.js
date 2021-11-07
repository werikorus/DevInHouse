function Calc(button){
  const value1 = parseInt(document.getElementById('n1').value);
  const value2 = parseInt(document.getElementById('n2').value);
  var op = button.value;

  if(isNaN(value1)||isNaN(value2)){
    alert('Para calcular, informe números válidos!');
  }else{
    var total = eval(`${value1}${op}${value2}`);
    var viewTotal = document.getElementById('totalCalc');
    viewTotal.value = `${total}`;
    console.log(total);
  };
}; 