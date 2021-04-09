using System;


namespace console_banco
{
    class Program
    {
        static void Main(string[] args)
        {
           // Console.WriteLine("Hello World!");
           // var key = Console.ReadLine();
           // Console.WriteLine(key);
           Conta conta = new Conta(TipoConta.PessoaFisica,"Carlos",1,0,0);
           conta.setNome("Carlos");
           Console.WriteLine(conta.ToString());
        }
    }
}
