var Lista = [];
var Input = document.getElementById('textInput');

function InsertItem(){
  const description = document.getElementById('textInput').value;

  if(description.length!=0){   
    Lista.push(`${Lista.length+1} - ${description}`);
    CriarElementos(description);

  }else{
     alert('Informe uma item para sua lista');
     Input.focus();  
  };

};

function CriarElementos(description) {
  const item = document.createElement("OPTION");
  const text = document.createTextNode(description);
  item.appendChild(text);

  let select = document.getElementById('lista');
  select.appendChild(item);

}

function SalvarLista(){
  if(Lista.length != undefined ||Lista != []){
    localStorage.setItem('lista',JSON.stringify(Lista)); 
    alert('Lista salva com sucesso!');
  }else{
    alert('Ainda não há itens na sua lista!');
  }

};

function CarregarLista(){
  Lista = JSON.parse(localStorage.getItem('lista'))||[];

  for(var i=0; i<Lista.length-1; i++){
    CriarElementos(Lista[i]);
  };
   
};
