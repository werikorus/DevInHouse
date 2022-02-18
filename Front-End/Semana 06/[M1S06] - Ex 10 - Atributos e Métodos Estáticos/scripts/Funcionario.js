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

  imprime (){
    console.log(`Nome do funcionário: ${this.nome} - Cargo: ${this.cargo}`);
  }
 

  static calcularSalarios(){
    let total = 0.0;

    const wk = [...this.salario];
    console.log(wk);
    
    const reducer = (previousValue, currentValue) => previousValue + currentValue;

     total = wk.reduce(reducer);
  
    console.log("Total de salários: R$", total.toFixed(2));
  };

}