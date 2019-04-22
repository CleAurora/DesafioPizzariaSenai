using System;
namespace DesafioPizzaria1
{
    public class Usuario
    {
        public string Id {get; set;}
        public string Nome {get; set;}
        public string Email {get; set;}
        public string Senha {get; set;}
        public DateTime Data {get; set;}


        //Fazer um método para validar email (conter @ e .) e validar senha (mínimo 6 caracteres) - usar no cadastro e no login

        public bool ChecarSeEmailEValido(){
            return Email.IndexOf('@')!=-1 && Email.IndexOf('.')!=-1;
        }

        // public void SetSenha(string password){
        //     Senha = password;
        // }

        public bool ChecarSeSenhaEValida(){
            return Senha.Length > 5;
        }


        // Fazer método para comparar valores inseridos com usuários cadastrados e mostrar Bem vindo ______

        // Fazer método para listar usuários
    }
}