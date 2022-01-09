import { Pessoa } from './Pessoa.js';

export class Funcionario extends Pessoa{
  get cargo() {
    return this._cargo;
  }
  set cargo(value) {
    this._cargo = value;
  }

  get salario(){
    return this._salario;
  }
  set salario(value){
    this._salario = value;
  }


  constructor(nome, cpf, cargo, salario){
    super(nome, cpf);
    this._cargo = cargo;
    this._salario = salario;
  }

}