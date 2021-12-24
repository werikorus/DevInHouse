export class Endereco{
  _logradouro;
  get logradouro() {
    return this._logradouro;
  }
  set logradouro(value) {
    this._logradouro = value;
  }
  _numero;
  get numero() {
    return this._numero;
  }
  set numero(value) {
    this._numero = value;
  }

  _cidade;
  get cidade() {
    return this._cidade;
  }
  set cidade(value) {
    this._cidade = value;
  }

  _estado;
  get estado() {
    return this._estado;
  }
  set estado(value) {
    this._estado = value;
  }

  _pais;
  get pais() {
    return this._pais;
  }
  set pais(value) {
    this._pais = value;
  }

  _cep;
  get cep() {
    return this._cep;
  }
  set cep(value) {
    this._cep = value;
  }

  constructor (logradouro, numero, cidade, estado, pais, cep){
                    
    const atributes = [logradouro, numero, cidade, estado, pais, cep];
    
    try{
      for(var i=0;i<=atributes.length-1;i++){
        if(typeof(atributes[i])!=="string")throw new Error("Endereço inválido!");
      };

      if(!validarCEP(cep))throw new Error("Formato de CPF é inválido!");
      
    }catch(e){
      alert(e.message)
    }

    console.log(atributes);
         
    this._logradouro = logradouro
    this._numero = numero
    this._cidade = cidade 
    this._estado = estado
    this._pais = pais
    this._cep = cep
  };

  retiraVazios(text){
     return strTexto.replace(/^s+|s+$/g, '');
  }
  
  validarCEP (cep){
    var objER = /^[0-9]{5}-[0-9]{3}$/;
    cep = retiraVazios(cep);

    if(cep.length>0){
      return objER.test(cep);
    }else{
      return false;
    }        
  }
};