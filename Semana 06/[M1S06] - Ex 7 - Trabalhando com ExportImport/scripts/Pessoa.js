export  class Pessoa{
  get nome() {
    return this._nome;
  }
  set nome(value) {
    this._nome = value;
  }

  get cpf(){
    return this._cpf = cpf;
  }
  set cpf(value){
    this._cpf = value;
  }

  constructor(nome, cpf){
    this._nome = nome;
    this._cpf = cpf;
  };

  imprime(){
    console.log(`${this._nome} - ${this._cpf}`);
  }

};