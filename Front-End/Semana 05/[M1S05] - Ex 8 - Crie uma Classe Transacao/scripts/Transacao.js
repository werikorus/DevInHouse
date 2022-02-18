import { Conta } from "./Conta";

export class Transacao {
  get conta() {
    return this._conta;
  }
  set conta(value) {
    this.conta = value;
  }

  get valorDaTransacao() {
    return this._valorDaTransacao;
  }
  set valorDaTransacao(value) {
    this.valorDaTransacao = value;
  }

  constructor (conta, valorDaTransacao){
    try{

      if(!(conta instanceof Conta))new Error("Conta inválida!");

    }catch(e){
      alert(e.message);
    }

    this._conta = new Conta();
    this._valorDaTransacao = valorDaTransacao;
  };
}