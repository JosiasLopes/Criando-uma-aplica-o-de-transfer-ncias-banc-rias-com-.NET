using System;
using System.Collections.Generic;


namespace console_banco
{
    class Program
    {
        static List<Conta> listaConta = new List<Conta>();

        /*
        O método Criar conta é responsável por coletar os dados do console
        e alocar esses dados em um nova objeto Conta e adiciona-lo na Lista de Contas
        
        
        */

        static void CriarConta(){
            int numero = 0;
            Console.WriteLine("Digite um nome par o titular da conta");
            var nome = Console.ReadLine();
            Console.WriteLine("Digite um Tipo de Conta 1 para Pessoa Fisica 2 para Pessoa Jurídica");
            var tipo = Console.ReadLine();
            TipoConta tipoConta = TipoConta.PessoaFisica;
            if(tipo=="1"){
                 tipoConta = TipoConta.PessoaFisica;
            }else{
              tipoConta = TipoConta.PessoaJuridica;  
            }
            Console.WriteLine("Digite um numero de Conta");
            try{
                numero = Int32.Parse(Console.ReadLine());
            }catch(FormatException){
                 Console.WriteLine("São permidos somente numeros inteiros não negativos");
            }
            

            //caso a pesquisa retorne null quer dizer que não existe essa conta
            //então podemos adiciona-la na lista caso contrario não sera adicionada nenhuma conta 
            if(pesquisaConta(numero)==null){
                Console.WriteLine("Digite um valor para saldo inicial");
            float saldo = float.Parse(Console.ReadLine());
            listaConta.Add(new Conta(tipoConta,nome,numero,saldo,0));

            }else{
                Console.WriteLine("Já existe um conta com o numero informado");
            }
                
        
            
        }

         /*
        O método Transferir pesquisa 
        as contas existentes na lista de contas, e atraves da entrada do usuario
        coleta os dados para que sejam efetuadas as transferencias
        
        */
        static void Transferir(){
            int numero = 0;
            int numero2 = 0;
            Console.WriteLine("Digite um numero de Conta 1");
            try{
                numero = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Digite um numero de Conta 2");
                numero2 = Int32.Parse(Console.ReadLine());
            }catch(FormatException){
                 Console.WriteLine("São permidos somente numeros inteiros não negativos");
            }
            
            try{
                 Conta contaA = pesquisaConta(numero);
                Conta contaB = pesquisaConta(numero2);
                Console.WriteLine("Digite o valor que deseja transferir");
                float valor = float.Parse(Console.ReadLine());
                contaA.Transferir(valor,contaB);

            contaA.ToString();
            contaB.ToString();
            }catch(NullReferenceException){
                 Console.WriteLine("Conta não encontrada");
               
            }
           
        }

        static void listarContas(){
            if(listaConta.Count>0){
                 foreach(Conta c in listaConta){
                 Console.WriteLine(c.ToString());
            }
            }else{
                Console.WriteLine("A lista de contas está vazia");
            }
           
        }

        static Conta pesquisaConta(int numero){
            return listaConta.Find(x => x.getNumero()==numero);
        }

        static void Sacar(){
            try{

            Console.WriteLine("Digite o numero da conta");
            int numero = Int32.Parse(Console.ReadLine());
            Conta conta = pesquisaConta(numero);
                try{
                    Console.WriteLine("Digite o valor a ser sacado");
                    float saldo = float.Parse(Console.ReadLine());
                    conta.Sacar(saldo);
                }catch(FormatException){
                    Console.WriteLine("São permitidos apenas numeros");
                }

            }catch(NullReferenceException){
                Console.WriteLine("Conta não encontrada");
            }
          
        }

        static void Depositar(){
            try{

            Console.WriteLine("Digite o numero da conta");
            int numero = Int32.Parse(Console.ReadLine());
            Conta conta = pesquisaConta(numero);
                try{
                    Console.WriteLine("Digite o valor a ser depositado");
                    float saldo = float.Parse(Console.ReadLine());
                    conta.Depositar(saldo);
                }catch(FormatException){
                    Console.WriteLine("São permitidos apenas numeros");
                }

            }catch(NullReferenceException){
                Console.WriteLine("Conta não encontrada");
            }
          
        }

        private static string ObterUsuario(){
            Console.WriteLine();
            Console.WriteLine("1 - Listar Contas");
            Console.WriteLine("2 - Criar nova Conta");
            Console.WriteLine("3 - Transferir");
            Console.WriteLine("4 - Sacar");
            Console.WriteLine("5 - Depositar");
            Console.WriteLine("x - Sair");
            Console.WriteLine("C - Limpar a Tela");
            Console.WriteLine();
            return Console.ReadLine().ToUpper();
        }
        private static void Escolher(){
           string opcao = "";
            //Console.WriteLine("4 - Sacar"+opcao);
           while(opcao!="x" || opcao!="X"){
               opcao = ObterUsuario();
               switch (opcao)
                {
                    case "1":
                        listarContas();
                        break;
                    case "2":
                        CriarConta();
                        break;
                    case "3":
                    Transferir();
                        break;
                    case "4":
                    Sacar();
                        break;
                    case "5":
                    Depositar();
                        break;
                    case "C":
                        Console.Clear();
                        break;
                     case "X":
                     Console.WriteLine("Saindo...");
                     Environment.Exit(0);

                        break;
                    default:
                    opcao = "X";
                        break;
                }
           }
        }   
        static void Main(string[] args)
        {
           
           Escolher();

         
        }
    }
}
