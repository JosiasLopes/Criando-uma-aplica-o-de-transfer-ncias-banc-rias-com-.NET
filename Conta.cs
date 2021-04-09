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

        public override string ToString() => "nome: "+this.nome+" tipo de conta: "+this.tipoconta+"saldo: "+this.saldo+" credido: "+this.credito;

    }

}