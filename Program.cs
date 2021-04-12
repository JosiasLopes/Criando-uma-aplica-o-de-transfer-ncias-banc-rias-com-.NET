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
           Conta conta = new Conta(TipoConta.PessoaFisica,"Carlos",10,10,0);
           Conta conta2 = new Conta(TipoConta.PessoaFisica,"João",11,10,0);
           conta.setNome("Carlos");
           Console.WriteLine(conta.ToString());
          // conta.Sacar(4);
          // conta.Depositar(0);
           conta.Transferir(3,conta2);
           Console.WriteLine(conta.ToString());
           Console.WriteLine(conta2.ToString());
        }
    }
}
