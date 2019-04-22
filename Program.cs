using System;

namespace DesafioPizzaria1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool sair = false;
            int contadorUsuarios = 0;
            Usuario[] usuarios = new Usuario[4];
            
            do{
                System.Console.WriteLine("-------------------------------");
                System.Console.WriteLine("| Bem Vindo à nossa Pizzaria! |");
                System.Console.WriteLine("| Digite uma das opções:      |");
                System.Console.WriteLine("|   1. Cadastro de Usuários   |");
                System.Console.WriteLine("|   2. Efetuar Login          |");
                System.Console.WriteLine("|   3. Listar os usuários     |");
                System.Console.WriteLine("|   9. Sair                   |");
                System.Console.WriteLine("-------------------------------");
                

                int option = int.Parse(Console.ReadLine());
                
                switch (option){
                    case 1:
                        //Fazer Cadastro
                        if(contadorUsuarios<4){
                            Usuario u = new Usuario();
                            System.Console.WriteLine("Você solicitou para cadastrar usuários!");

                            System.Console.WriteLine("Digite seu nome");
                            u.Nome = Console.ReadLine();
                            System.Console.WriteLine("Digite seu Id:");
                            u.Id = Console.ReadLine();
                            do{
                                System.Console.WriteLine("Digite seu email");
                                u.Email = Console.ReadLine();
                            
                                if(u.ChecarSeEmailEValido()){
                                    System.Console.WriteLine("E-mail válido!");
                                }else{
                                    System.Console.WriteLine("Email inválido, por Favor, refaça!");
                                }
                            }while(!u.ChecarSeEmailEValido());

                            
                            
                            do{
                                System.Console.WriteLine("Digite sua senha");
                                //u.Senha(Console.ReadLine());
                                u.Senha = Console.ReadLine();

                                if(u.ChecarSeSenhaEValida()){
                                    System.Console.WriteLine("Senha Válida");
                                }else{
                                    System.Console.WriteLine("Senha inválida, Digite mais de 6 caracteres.");
                                }
                            }while(!u.ChecarSeSenhaEValida());

                            u.Data = DateTime.Now;

                            usuarios[contadorUsuarios] = u;
                            contadorUsuarios++;

                            Console.ForegroundColor = ConsoleColor.Green;
                            System.Console.WriteLine("Cadastro efetuado com sucesso!");
                            Console.ResetColor();
                        }
                    break;

                    case 2:
                        //Fazer login - metodo que tem id e senha
                        System.Console.WriteLine("Você solicitou fazer login!");
                        System.Console.WriteLine("Entre com seu Id");
                        string idDeUsuario = Console.ReadLine();
                        System.Console.WriteLine("Entre com sua senha");
                        string senhaDeUsuario = Console.ReadLine();

                        bool achou;
                        for (int i = 0; i < usuarios.Length; i++){
                           if(usuarios[i] != null && usuarios[i].Id == idDeUsuario  && usuarios[i].Senha == senhaDeUsuario){
                                System.Console.WriteLine($"Seja Bem vindo {usuarios[i].Nome}");
                                achou = true;
                                break;
                            }
                            //continue;   
                        }


                        // foreach (var us in usuarios){
                        //     if(us != null && idDeUsuario.Equals(us.Id) && senhaDeUsuario.Equals(us.Senha)){
                        //         System.Console.WriteLine($"Seja Bem vindo {us.Nome}");
                        //         //break;
                        //     }else if (us != null && idDeUsuario.Equals(us.Id) && us.Senha != senhaDeUsuario){ 
                        //         System.Console.WriteLine("Id ou senha incorretos!");
                        //     }
                        //     else{
                        //         System.Console.WriteLine("Cadastro não efetuado. Por favor, Cadastre-se!");
                        //     }
                        //     //continue;
                        // }



                       

                    break;

                    case 3:
                        //Listar Usuários
                        if(contadorUsuarios == 0){
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            System.Console.WriteLine("Não há Usuário Cadastrado");
                            Console.ResetColor ();

                            System.Console.WriteLine("Aperte a tecla ENTER para voltar ao menu.");
                            Console.ReadLine();
                            continue;
                        }else{
                            foreach (var us in usuarios){
                                System.Console.WriteLine("---------------");
                                System.Console.WriteLine($"Id: {us.Id}");
                                System.Console.WriteLine($"Nome: {us.Nome}");
                                System.Console.WriteLine($"E-mail: {us.Email}");
                                System.Console.WriteLine("---------------");
                                System.Console.WriteLine("Aperte enter para continuar");
                            }

                        }


                    break;

                    case 9:
                        //Sair
                        System.Console.WriteLine("Você solicitou sair! Até mais!");
                        sair = true;
                    break;

                    default:
                        System.Console.WriteLine("Opção inválida,por favor, tente novamente.");
                    break;
                }
            }while(!sair);
        }
    }
}
