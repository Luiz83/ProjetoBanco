namespace ProjetoBanco.Models
{
    public class ContaBancaria
    {
        private double Saldo {get;set;}
        private Titular Titular {get;set;}
        private int Agencia {get;set;}
        private string NumeroConta {get;set;}

        public ContaBancaria(double saldo,Titular titular, int agencia, string conta){
            SetSaldo(saldo);
            SetTitular(titular);
            SetAgencia(agencia);
            SetNumeroConta(conta);
        }

        public double GetSaldo(){
            return Saldo;
        }
        public void SetSaldo(double saldo){
            Saldo = saldo;
        }

        public Titular GetTitular(){
            return Titular;
        }
        public void SetTitular(Titular titular){
            Titular = titular;
        }

        public int GetAgencia(){
            return Agencia;
        }
        public void SetAgencia(int agencia){
            Agencia = agencia;
        }

        public string GetNumeroConta(){
            return NumeroConta;
        }
        public void SetNumeroConta(string numeroConta){
            NumeroConta = numeroConta;
        }

        public void Sacar(double valor){
            Saldo = Saldo - valor;
        }

        public void Depositar(double valor){
            Saldo = Saldo + valor;
        }

        public virtual void ExibirSaldo(){
            Console.WriteLine("Seu saldo atual é de: " + Saldo);
        }
    }
}