function Check(){
  const cron = setInterval(()=>{GetAtualHour()}, 1000);
};

function GetAtualHour(){
  const date = new Date();
  const hour = date.getHours();
  const min = date.getMinutes();
  const atualTime = `${hour}:${min}`;

  const displayTime = document.getElementById('displayTime');
  displayTime.innerText = `${atualTime}`;
}; 