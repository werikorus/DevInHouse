function AskingUser(){

  var operations = ['+','-','*','/'];
  var validOperation = false;

  // primeiro, validamos o tipo de operação: 
  while(!validOperation){
    var op = prompt('Informe um tipo de cálculo: \n +  -  *  /');
    if(operations.includes(op)){
      validOperation = true;
    }else{
      alert('Operação inválida!');
      validOperation = false;
    }
  };

  // válida a operação, agora vamos validar os números:
  var validNumber = false;
  while(!validNumber){
    var value1 = prompt('Informe o primeiro valor a ser calculado: ');
    if(!value1||isNaN(value1) || ((op=='/') && value1==0)){
      alert('Primeiro valor inválido!');
      validNumber = false;
      continue;
    }else{
      validNumber = true;
    };

    var value2 = prompt('Informe o segundo valor a ser calculado: ');
    if(!value2 || isNaN(value2) || ((op=='/') && value2==0)){
      alert('Segundo valor inválido!');
      validNumber = false;
      continue;
    }else{
      validNumber = true;
    }
    
  };
  
  // e por fim, fazer o cálculo de acordo com a operação e os números:
  let result = eval(`${value1} ${op} ${value2}`);
  

  // feito os cálculos, mostramos ao usuário o resultado;
  let msg = `Operação: ${op} \n Primeiro valor: ${value1}\n Segundo valor: ${value2}\n`;
  msg += `O resultado do seu cálculo é: ${result}`;

  alert(msg);
  document.getElementById('paragrafo').innerText = msg;
};