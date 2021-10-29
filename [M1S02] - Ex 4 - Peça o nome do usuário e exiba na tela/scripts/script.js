function GetAndShowName(){
  let informed = false;

  while(!informed){
    let name = prompt('Olá! Qual o seu nome?');

    if(name===''){
      window.alert(`Bem vindo! ${name}`);
      informed = true;
    }else{
      window.alert('Para continuarmos, precisamos do seu nome.');
      informed = false;
    };

  };
}