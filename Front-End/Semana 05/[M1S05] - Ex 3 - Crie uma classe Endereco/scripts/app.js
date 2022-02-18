import { Endereco } from './Endereco.js';

const myForm = document.getElementById('myForm');
      myForm.addEventListener('submit', saveAdress);

function saveAdress(event){
  event.preventDefault();

    const formData = new FormData(myForm);
  
    const logradouro = formData.get('logradouro');
    const numero = formData.get('numero');
    const cidade = formData.get('cidade');
    const estado = formData.get('estado');
    const pais = formData.get('pais');
    const cep = formData.get('cep');
  
    var newAdress = new Endereco(logradouro, numero, cidade, estado, pais, cep);
  
    const p = document.getElementById('paragrafo');

    p.innerHTML = '<strong>Endereço salvo com sucesso!</strong>'
  
    myForm.innerText = `Rua: ${newAdress.logradouro}
                      Número: ${newAdress.numero}
                      Cidade: ${newAdress.cidade}
                      Estado: ${newAdress.estado}
                      País: ${newAdress.pais}
                      Cep: ${newAdress.cep}`;
};


