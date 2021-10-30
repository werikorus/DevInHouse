function AskingUser(){
  let surname  = prompt('Qual o seu sobrenome?');
  let name = prompt('E o seu nome?');
  
  let msg = `Bem vindo! ${name} ${surname}`;
  window.alert(msg);

  let paragrafo = document.getElementById("paragrafo");

  paragrafo.innerText = `${msg}`;
  console.log(msg);
};