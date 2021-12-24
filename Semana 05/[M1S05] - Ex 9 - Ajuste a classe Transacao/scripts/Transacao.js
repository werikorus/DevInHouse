import { Conta } from "./Conta";

export class Transacao {
  get conta() {
    return this._conta;
  }
  set conta(value) {
    this.conta = value;
  }

  get idDeTransacao() {
    return this._idDeTransacao ;
  }
  set idDeTransacao (value) {
    this.idDeTransacao += value;
  }
  
  get contaTransferencia() {
    return this._contaTransferencia ;
  }
  set contaTransferencia (value) {
    this.contaTransferencia += value;
  }

  get valorDaTransacao() {
    return this._valorDaTransacao;
  }
  set valorDaTransacao(value) {
    this.valorDaTransacao = value;
  }

  get data() {
    return this._data ;
  }
  set data (value) {
    this.data += value;
  }
  
  constructor (conta, idDeTransacao, contaTransferencia, valorDaTransacao, data){
    try{

      if(!(conta instanceof Conta))new Error("Conta inválida!");

    }catch(e){
      alert(e.message);
    }

    this._conta = new Conta();
    this._valorDaTransacao = valorDaTransacao;
    this._idDeTransacao = idDeTransacao;
    this._contaTransferencia = contaTransferencia;
    this._data = data;
  };

  static transferencia(contaDestino){
    contaTransferencia = contaDestino;
  }
}