function Calcular(tipo){
  let inicial = parseInt(document.getElementById('inicial').value);
  let raiz = parseInt(document.getElementById('raiz').value);
  let eltotal = document.getElementById('total');

  if(!isNaN(inicial)||!isNaN(raiz)){

    let total = 1;

    switch (tipo) {
      case 1:{
        var msg = 'P.A = ';

        for(let i=1; i<=10; i++){
          msg += ` ${total},`;
          total += raiz;
        };
      }
      break;
  
      case 2:{
        var msg = 'P.G = ';

        for(let i=1; i<=10; i++){
          msg += ` ${total},`;
          total *= raiz;
        };
      }
      break;
      
    };
    
    eltotal.innerText = msg.substring(0, msg.length-1);
  }else{
    alert('Informe um número válido!');
  };
}
