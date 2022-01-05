import { Cliente } from "./Cliente";
export class Conta {
  get numeroDaConta() {
    return this._numeroDaConta;
  }
  set numeroDaConta(value) {
    this._numeroDaConta = value;
  }

  get saldo() {
    return this._saldo;
  }
  set saldo(value) {
    this._saldo = value;
  }

  get cliente() {
    return this._cliente;
  }
  set cliente(value) {
    this._cliente = value;
  }

  constructor (numeroDaConta, saldo, cliente){
    try{

      if(!typeof(numeroDaConta!=="string")||
         !typeof(saldo!=="number")||
         !(cliente instanceof Cliente)
      )new Error("Dados da conta são inválidos!");


      if(saldo<0) new Error("O saldo da conta não pode ser menor que 0!");

    }catch(e){
      alert(e.message);
    }

    this._numeroDaConta = numeroDaConta;
    this._saldo = saldo;
    this._cliente = new Cliente();
  };
  
}