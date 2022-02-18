var Lista = [];
var Input = document.getElementById('textInput');

function InsertItem(){
  const description = document.getElementById('textInput').value;

  if(description.length!=0){ 
    const item = document.createElement("OPTION");
    const text = document.createTextNode(description);
          item.appendChild(text);

    console.log(description.length);

    let select = document.getElementById('lista');
        select.appendChild(item);
  
    Input.innerText = '';

  }else{
     alert('Informe uma item para sua lista');
     const input = document.getElementById('textInput').focus();  
  };

  Lista.push(`${Lista.length+1} - ${description}`);
  console.log(Lista);

};

function SalvarLista(){
  if(Lista.length != undefined ||Lista != []){
    localStorage.setItem('lista',JSON.stringify(Lista)); 
    alert('Lista salva com sucesso!');
  }else{
    alert('Ainda não há itens na sua lista!');
  }

};