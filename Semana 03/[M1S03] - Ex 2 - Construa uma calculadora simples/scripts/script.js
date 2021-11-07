function CalcAge(){
  let today = Date.parse(new Date());
  let birth = Date.parse(document.getElementById('bornDate').value);
  let difInTicks   = Math.abs(today-birth);
  let convertInDays = Math.ceil(difInTicks/(1000*60*60*24));
  let age = (convertInDays/365.25).toFixed();

  if(isNaN(age)){
    alert('Para calcular, informe uma data válida!');
  }else{
    let view = document.getElementById('rec');
    let paragrafo = document.getElementById('paragrafo');
    paragrafo.innerText = '';
    view.innerHTML  = `Sua idade é: <strong>${age}</strong>\n`;
    view.innerHTML += '<button> <a href="/"  style="text-decoration:none;">voltar </a></button>'
  };
}; 