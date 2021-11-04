var paragrafo = '';
var atualHour='';
var cron ='';

function GetAtualHours(){
  let date = new Date();
  let hour = date.getHours();
  let minute = date.getMinutes();

  atualHour = `${hour}:${minute}`;
  console.log(atualHour);
  paragrafo.innerHTML = '';
  
  let msg = `\nHora atual: `;
  paragrafo = document.getElementById('paragrafo');
  paragrafo.innerText += msg;
  paragrafo.innerHTML += `<strong>${atualHour}</strong>`;

  return atualHour;
};

function ShowHoursToUser(){
  const atualHour = GetAtualHours();  
  alert(`Bem vindo!\nHora atual: ${atualHour}`);
};

function checkSate(){
  cron = setInterval(()=>{GetAtualHours()}, 1000);
};