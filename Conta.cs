
using System;
namespace console_banco {
    public class Conta {

        public Conta (TipoConta tipoconta, string nome, int numero, double saldo, double credito) {
            this.tipoconta = tipoconta;
            this.nome = nome;
            this.numero = numero;
            this.saldo = saldo;
            this.credito = credito;

        }
        private TipoConta tipoconta { get; set; }
        private string nome { get; set; }
        private int numero { get; set; }
        private double saldo { get; set; }
        private double credito { get; set; }

        public string getNome () {
            return this.nome;
        }
        public void setNome (string nome) {
            
            this.nome = nome;
        }

        public int getNumero () {
            return this.numero;
        }
        public void setNumero (int numero) {
            if(numero<=0){
                this.numero = 1;
            }else this.numero = numero;
        }

        public TipoConta getTipoConta () {
            return this.tipoconta;
        }
        public void seTipoConta (int tipo) {
           if(tipo == 1){
               this.tipoconta = TipoConta.PessoaFisica;
           }else{
               this.tipoconta = TipoConta.PessoaJuridica;
           }
        }

        public double getSaldo () {
            return this.saldo;
        }
        public void setSaldo (double saldo) {
            this.saldo = saldo;
        }

        public double getCredito () {
            return this.credito;
        }
        public void setNumero (double credito) {
            this.credito = credito;
        }

        public override string ToString() => "nome: "+this.nome+" tipo de conta: "+this.tipoconta+" saldo: "+this.saldo+" credito: "+this.credito;

        public void Sacar(double valor){
            if(this.saldo>0 && valor>0 && this.saldo>=valor){
                this.saldo -= valor;
              
            }else{
                Console.WriteLine("Nao foi possivel efetuar a transicao no valor de: "+valor); 
            }
        }

        public void Depositar(double valor){
             if(valor>0){
                this.saldo += valor;
              
            }else{
                Console.WriteLine("Nao foi possivel efetuar a transicao no valor de: "+valor); 
            }
        }

        public void Transferir(double valor,Conta destino){
           if(destino.getNumero()>0 && destino.getNumero()!=this.getNumero()){
               
               this.Sacar(valor);
               destino.Depositar(valor);
           }else{
               Console.WriteLine("O numero da conta esta incorreto");
           }

        }

    }

}