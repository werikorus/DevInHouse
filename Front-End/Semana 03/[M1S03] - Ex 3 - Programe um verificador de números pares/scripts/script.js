function Check(){
  const number = parseInt(document.getElementById('number').value);
  const viewResult = document.getElementById('rec');

  if(!isNaN(number)){
    const total = number%2;
    const result = (total==0)?"Par":"Ímpar";
    
    const button = '<button> <a href="/"  style="text-decoration:none;">Voltar </a></button>';
    const msg = `O número ${number} é <strong>${result}</strong> ${button}`;
    viewResult.innerHTML = msg;
    
  }else{
    alert('Informe um número válido!');
  }
 
  return result;
}; 