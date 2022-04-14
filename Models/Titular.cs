namespace ProjetoBanco.Models
{
    public class Titular
    {
        private string Nome { get; set; }
        public string Cpf { get; set; }

        public Titular(){
            SetNome("Luiz");
            SetCpf("40676699847");
        }

        public string GetNome()
        {
            return Nome.ToUpper();
        }

        public void SetNome(string nome)
        {
            Nome = Nome;
        }

        public void SetCpf(string cpf)
        {
            if (cpf.Length == 11)
            {
                Cpf = cpf;
            }
        }

        public string GetCpf()
        {
            return Cpf;
        }
    }
}