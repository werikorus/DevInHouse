function Check(){
  const cron = setInterval(()=>{GetAtualSeason()}, 1000);
};

function GetAtualSeason(){
  const date = new Date();
  const day = date.getDate();
  const month = date.getMonth()+1;
  const year = date.getFullYear();
  const hour = date.getHours();
  const min  = date.getMinutes();

  const summer = ((day>=21||day<=21)&&(month>=12)&&(month<=3));
  const autumn = ((day>=22||day<=21)&&(month>=3)&&(month<=12)); 
  const winter = ((day>=22||day<=21)&&(month>=6)&&(month<=9));
  const spring = ((day<=21||day>=22)&&(month>=9)&&(month<=12));

  const verao = (summer?"Estamos no Versão":"");
  const outono = (autumn?"Estamos no Outono":"");
  const inverno = (winter?"Estamos no Inverno":"");
  const primavera = (spring?"Estamos na Primavera":"");

  const displaySeason = document.getElementById('seasonText');
 
  var imagem = document.getElementById('imgSeason');
  var imgsrc = '';

  switch(false){
    case summer:{
      imgsrc = "/assets/season/verao.jpg";
      displaySeason.innerText = verao};

    case autumn:{
      imgsrc = "/assets/season/outono.jpg";
      displaySeason.innerText = outono};

    case winter:{
      imgsrc = "/assets/season/inverno.jpg";
      displaySeason.innerText = inverno};

    case spring:{
      imgsrc = "/assets/season/primavera.jpg";
      displaySeason.innerText = primavera};
  };

  imagem.src = imgsrc;
     
  const today = `${day}/${month}/${year}`;
  const atualTime = `${hour}:${min}`;
  
  const displayDate = document.getElementById('today');
  const displayTime = document.getElementById('time');
  displayDate.innerText = `${today}`;
  displayTime.innerText = `${atualTime}`;
};