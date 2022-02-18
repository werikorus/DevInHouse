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
  
  static executarTransacao(){
    try{
      if (conta==""||contaTransferencia==""){
        new Error("Conta ou Conta-transferência não foi informado!")
      }else{
        
        if (conta!==""&&contaTransferencia==""){
          this.deposito(this.conta, this._valorDaTransacao);
        }else{
          this.transferencia(this.conta, this._valorDaTransacao);
        }
      };

    }catch(e)
    {
      alert(e);
    }
  };
  
  static transferencia(contaDestino, valor){ 
    contaTransferencia = contaDestino;
    
    try{
      if(valor > 300) new Error("O valor da transação não pode ser maior que R$ 300,00!");

      let contaReceptor =  new Conta(contaDestino, valor, "Cliente Transferência");
    }
    catch(e){
      alert(e);
    }
  };
    
  static deposito(contaDestino, valor){ 
    contaTransferencia = contaDestino;
    
    try{
      if(valor > 300) new Error("O valor da transação não pode ser maior que R$ 300,00!");

      let contaReceptor =  new Conta(contaDestino, valor, "Cliente Deposito");
    }
    catch(e){
      alert(e);
    }
  };
  
}
