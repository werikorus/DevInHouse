import { Endereco } from "./Endereco.js";

export class Cliente{
  _nome;
  get nome() {
    return this._nome;
  }
  set nome(value) {
    this._nome = value;
  }
  _cpf;
  get cpf() {
    return this._cpf;
  }
  set cpf(value) {
    this._cpf = value;
  }

  _numeroCelular;
  get numeroCelular() {
    return this._numeroCelular;
  }
  set numeroCelular(value) {
    this._numeroCelular = value;
  }

  _endereco;
  get endereco() {
    return this._endereco;
  }
  set endereco(value) {
    this._endereco = value;
  }

  constructor (nome, cpf, numeroCelular, endereco){
                    
    const atributes = [nome, cpf, numeroCelular, endereco];

    try{
      for(var i=0;i<=atributes[2];i++){
        if(typeof(atributes[i])!=="string")throw new Error("Dados do clientes estão inválidos!");
      };
      if(!(endereco instanceof Endereco)){
        throw new Error("Endereço inválido!");
      }

      if(!Cliente.validarCPF(cpf))throw new Error("CPF inválido!");

    }catch(e){
      alert(e.message)
    }
         
    this._nome = nome
    this._cpf = cpf
    this._endereco = new Endereco();
    
  };

  static validarCPF(strCPF){
    let Soma;
    let Resto;

    Soma = 0;

    if(strCPF == "00000000000") return false;

    for(i=1; i<=9; i++){
      Soma += parseInt(strCPF.substring(i-1, i))*(11-i);
    };

    Resto = (Soma * 10)%11;

    if((Resto == 10)||(Resto == 11)){
      Resto = 0;
    }

    if(Resto != parseInt(strCPF.substring(9, 10))) return false;

    Soma = 0;

    for(i=1; i<=10;i++){
      Soma += parseInt(strCPF.substring(i-1, i))*(12-i);
    };
    Resto = (Soma * 10) % 11;

    if((Resto ==10)||(Resto==11)){
      Resto = 0;
    }; 

    if(Resto != parseInt(strCPF.substring(10, 11))){
      return false;
    }else{
      return true;
    }
  }
};