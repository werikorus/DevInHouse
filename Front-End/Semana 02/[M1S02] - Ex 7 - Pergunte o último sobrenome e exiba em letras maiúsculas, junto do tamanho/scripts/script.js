function AskingUser(){
  let lastSurname  = prompt('Qual o seu último sobrenome?');
  let quantidade = lastSurname.length;

  msg = `Olá, ${lastSurname.toUpperCase()}. Seu sobrenome contém ${quantidade} letras.`;
  window.alert(msg);

  document.getElementById("paragrafo").innerText = msg;
  
};