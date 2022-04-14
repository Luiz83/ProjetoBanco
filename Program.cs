using ProjetoBanco.Models;
namespace ProjetoBanco;

public class Program
{
    static void Main(string[] args)
    {
        
        Titular titular = new Titular();
        ContaBancaria conta = new ContaBancaria(1000, titular, 12076, "338680");
        bool continuar = true;

        Console.WriteLine("Qual conta deseja usar? 1 - Conta Corrente  / 2 - Conta Poupança");
            var opcao = int.Parse(Console.ReadLine());
            if (opcao == 1)
            {
                conta = new ContaCorrente(1000, titular, 12076, "338680", 2000);
            }
            else if (opcao == 2)
            {
                conta = new ContaPoupanca(1000, titular, 12076, "338680", 1);
            }
        do
        {
            Console.WriteLine("Qual operacao deseja fazer? 1 - Sacar  / 2 - Depositar");
            opcao = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual o valor da operacao?");
            var valor = double.Parse(Console.ReadLine());
            if (opcao == 1)
            {
                conta.Sacar(valor);
                conta.ExibirSaldo();
            }
            else if (opcao == 2)
            {
                conta.Depositar(valor);
                conta.ExibirSaldo();
            }

            Console.WriteLine("Qual operacao deseja fazer outra operacao?? 1 - Sim  / 2 - Nao");
            opcao = int.Parse(Console.ReadLine());
            if (opcao == 1)
            {
                continuar = true;
            }
            else if (opcao == 2)
            {
                continuar = false;
            }

        } while (continuar == true);
    }
}