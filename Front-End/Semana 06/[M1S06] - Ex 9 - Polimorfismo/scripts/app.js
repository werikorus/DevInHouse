import { Endereco } from './Endereco.js';
import { Cliente } from './Cliente.js';
import { Pessoa } from './Pessoa.js';
import { Funcionario } from './Funcionario.js';

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

// [M1S06] - Ex 7 - Trabalhando com Export/Import
const p1 = new Pessoa("Werik Santos", "024.485.533-53");
const p2 = new Pessoa("Ester Carvalho Alencar", "434.744.483-05");
const p3 = new Pessoa("Isaac Carvalho Santos", "864.452.789-07")

p1.imprime();
p2.imprime();
p3.imprime();

const funcionarios = [
  new Funcionario(p1.nome, p1.cpf, "Software Developer", 4613.15),
  new Funcionario(p2.nome, p2.cpf, "Designer", 2456.45),
  new Funcionario(p3.nome, p3.cpf, "Software Developer", 4561.43)
];


function calcularSalarios(workers){
  let total = 0.0;

  for(let i=0; i<=workers.length-1; i++){ 
    total = total + workers[i].salario;
  };
  
  console.log("Total de salários: R$", total.toFixed(2));
};

calcularSalarios(funcionarios);

funcionarios.forEach(item => item.imprime());

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

