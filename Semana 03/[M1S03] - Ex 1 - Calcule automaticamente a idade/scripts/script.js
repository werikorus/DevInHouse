function Calc(button){
  const value1 = document.getElementById('n1').value;
  const value2 = document.getElementById('n2').value;
  var op = button.value;

  if(!(value1==="")||!(value2==="")){
    var total = eval(`${value1}${op}${value2}`);
    var viewTotal = document.getElementById('totalCalc');
    viewTotal.value = `${(total)}`;
    console.log(total);
  }else{
    alert('Para calcular, informe números válidos!');
  };
}; 

function Clear(){
  viewTotal.value = '';
}