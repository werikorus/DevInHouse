class Retangulo{
  constructor (altura, largura){
    this.altura = altura;
    this.largura = largura;
  };

  calcularArea(){
    const total = this.altura * this.largura;
    return total.toFixed(2);
  }
};