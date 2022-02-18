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

    }catch(e){
      alert(e.message)
    }
         
    this._nome = nome
    this._cpf = cpf
    this._endereco = new Endereco();
  };

};