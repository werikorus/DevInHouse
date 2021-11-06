function Confirm(){
  if (window.confirm("Você deseja realmente realizar essa ação?")) {
    window.alert('Feito!');
  }else{
    window.alert('Cancelado!')
  }
}