function AskingUser(){
  let anoNasc = prompt('Qual o seu ano de nascimento?');
  let anoAtual=  prompt('Qual o ano atual?');
  let idade = anoAtual - anoNasc;

  let msg = `Ano de nascimento: ${anoNasc} \n Ano atual: ${anoAtual} \n`
   msg += `Sua idade é ${idade}  ou ${idade+1}`;

  alert(msg);

  document.getElementById('paragrafo').innerText = msg;
};