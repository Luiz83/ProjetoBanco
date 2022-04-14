namespace ProjetoBanco.Models
{
    public class ContaPoupanca : ContaBancaria
    {
        private double TaxaJuros { get; set; }

        public ContaPoupanca(double saldo,Titular titular, int agencia, string conta, double taxa) : base (saldo,titular,agencia,conta){
            SetSaldo(saldo);
            SetTitular(titular);
            SetAgencia(agencia);
            SetNumeroConta(conta);
            SetTaxaJuros(taxa);
        }

        public double GetTaxaJuros()
        {
            return TaxaJuros;
        }

        public void SetTaxaJuros(double taxaJuros)
        {
            TaxaJuros = taxaJuros;
        }

        public void AtualizarSaldo(double saldo, double taxaJuros)
        {
            saldo = GetSaldo();
            SetSaldo(saldo + (saldo * (taxaJuros / 100)));
        }
    }
}