using sintaxeIdentacao.Models;
using sintaxeIdentacao.Acessorios;
using System.Runtime.InteropServices;
using sintaxeIdentacao.ID;


Pessoa pessoaAmericana = new Pessoa(); //Classe pessoa
Phone Telefone = new Phone(); //classe Phone
Clock Relogio = new Clock(); 
Usuario RegistroUsuario = new Usuario();

//Dados do usuário 
pessoaAmericana.Nome = "Lima";
pessoaAmericana.Idade = 28;
pessoaAmericana.Apresetar();

//Registro do telefone
//inforPhone.Numero = 0;
//inforPhone.Marca = "";
//inforPhone.ChipeOperadora = 0;

Telefone.Characters();
Relogio.Exposition();
RegistroUsuario.DataRegister();

