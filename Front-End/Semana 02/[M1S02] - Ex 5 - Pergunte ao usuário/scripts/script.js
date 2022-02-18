function AskingUser(){
  let name = prompt('Olá! Qual o seu nome?');
  let age  = prompt('Idade:');
  let practiceSport = confirm('Pratica esporte?');
  
  let msg = `Seu nome é ${name}, tem ${age} anos de idade e ${practiceSport?"pratica":"não pratica"} esportes.`;
  let msgSport = `${practiceSport? "Continue praticando esportes.":"Você precisa praticar esportes."}`
  let finalMsg = `${msg} \n ${msgSport}`;

  let paragrafo = document.getElementById("paragrafo");

  paragrafo.innerText = finalMsg;
  console.log(finalMsg);
};