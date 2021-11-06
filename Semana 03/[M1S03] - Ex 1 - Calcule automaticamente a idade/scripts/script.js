function CalcPA(){
  var number1 = parseInt(prompt('Valor inicial: '));
  var raiz = parseInt(prompt('Raíz: '));
  var msg = 'P.A = ';
  var total = number1; 

  for(i=1; i<=10; i++){
    msg += ` ${total},`;
    total += raiz;
  };

  let paragrafo = document.getElementById('paragrafo');
  paragrafo.innerText = `Valor inicial: ${number1}\n Raiz: ${raiz}\n${msg}`;
};