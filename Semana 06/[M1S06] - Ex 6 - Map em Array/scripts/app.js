import { Endereco } from './Endereco.js';
import { Cliente } from './Cliente.js';

var arrayNumeros = [1, 2, 3, 4, 5, 6, 7, 8, 9];
console.log(arrayNumeros);

const arrayQuadrados = arrayNumeros.map(function(num){
  return num ** 2;
});

console.log("Número quadrado: " + arrayQuadrados);

const encontrado = arrayNumeros.find(item => item > 5);

console.log("Número encontrado: " + encontrado);

const mensagemOla = (nome) =>{
  if(nome!=''){
    alert('Olá, ' + nome);
  }else{
    alert('Bem vindo usuário!');
  }
};

window.onload = mensagemOla('Werik');

const verificaImpar = (value) => {
  return (value%2)==1;
}

const arrayImpares = arrayNumeros.filter(verificaImpar);
console.log("Números ímpares: " + arrayImpares);

const inverteNumeros = () => {
  const arrayInvertido = [];
  arrayInvertido.push(arrayNumeros.reverse());
  console.log(arrayInvertido);
};

window.onload = inverteNumeros();

const myForm = document.getElementById('myForm');
      myForm.addEventListener('submit', saveCustomer);

function saveCustomer(event){
  event.preventDefault();

    const formData = new FormData(myForm);

    const nomeCliente = formData.get('nome');
    const cpfCliente =  formData.get('cpf');
    const numeroCelularCliente = formData.get('numeroCelular');
     
    const logradouro = formData.get('logradouro');
    const numero = formData.get('numero');
    const cidade = formData.get('cidade');
    const estado = formData.get('estado');
    const pais = formData.get('pais');
    const cep = formData.get('cep');

    const address = new Endereco(logradouro, numero, cidade, estado, pais, cep);
    const newCustomer = new Cliente(nomeCliente, cpfCliente, numeroCelularCliente, address);

    const p = document.getElementById('paragrafo');
          p.innerHTML = '<strong>Cadastro salvo com sucesso!</strong>'

    myForm.innerText = `Nome:${newCustomer.nome}
                        Cpf:${newCustomer.cpf}
                        Número celular:${newCustomer.numeroCelular}
                        Rua: ${newCustomer.endereco.logradouro}
                        Número: ${newCustomer.endereco.numero}
                        Cidade: ${newCustomer.endereco.cidade}
                        Estado: ${newCustomer.endereco.estado}
                        País: ${newCustomer.endereco.pais}
                        Cep: ${newCustomer.endereco.cep}`;
};
