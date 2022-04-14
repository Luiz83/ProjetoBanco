namespace ProjetoBanco.Models
{
    public class ContaCorrente : ContaBancaria
    {
        private double LimiteCredito { get; set; }

        public ContaCorrente(double saldo,Titular titular, int agencia, string conta, double limite) : base (saldo,titular,agencia,conta){
            SetLimiteCredito(limite);
        }

        public double GetLimiteCredito(){
            return LimiteCredito;
        }

        public void SetLimiteCredito(double limiteCredito){
            LimiteCredito = limiteCredito;
        }

        public override void ExibirSaldo(){
            var saldo = GetSaldo();
            var SaldoLimite = saldo + LimiteCredito;
            Console.WriteLine("Seu saldo atual é de: " + SaldoLimite);
        }
    }
}