function GetAndShowName(){
  let informed = false;

  while(!informed){
    var name = prompt('Olá! Qual o seu nome?');

    if(name!==''){
      window.alert(`Bem vindo! ${name}`);
      informed = true;
    }else{
      window.alert('Para continuarmos, precisamos do seu nome.');
      informed = false;
    };
  };
  
  document.body.innerHTML = `<h1>Bem vindo! ${name}</h1>`;
}