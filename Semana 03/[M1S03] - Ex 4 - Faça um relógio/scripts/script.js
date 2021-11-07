function Check(){
  const date = new Date();
  const hour = date.getHours();
  const minutes = date.getMinutes();
  const atualTime = `${hour}:${minutes}`;

  const displayTime = document.getElementById('displayTime');
  displayTime.innerText = `${atualTime}`;
}; 