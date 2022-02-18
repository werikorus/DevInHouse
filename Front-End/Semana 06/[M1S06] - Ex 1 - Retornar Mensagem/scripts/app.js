import { Endereco } from './Endereco.js';
import { Cliente } from './Cliente.js';

const myForm = document.getElementById('myForm');
      myForm.addEventListener('submit', saveCustomer);


const mensagemOla = (nome) =>{
      alert('Olá mundo!');
};
      
window.onload = mensagemOla('Werik');      

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
