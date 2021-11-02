function AskingUser(){
  let op = prompt('Informe um tipo de cálculo: \n +  -  *  /');

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
  
  let result = eval(`${value1} ${op} ${value2}`);

  let msg = `Operação: ${op} \n Primeiro valor: ${value1}\n Segundo valor: ${value2}\n`;
  msg += `O resultado do seu cálculo é: ${result}`;
  alert(msg);

  document.getElementById('paragrafo').innerText = msg;
};
