function InsertItem(){
  const description = document.getElementById('textInput').value;

  if(description.length!=0){ 
  const item = document.createElement("OPTION");
  const text = document.createTextNode(description);
        item.appendChild(text);
        
  console.log(description.length);

  let select = document.getElementById('lista');
      select.appendChild(item);
  }else{
     alert('Informe uma item para sua lista');
     const input = document.getElementById('textInput').focus();  
  }
};