//Problema "troco"
//Fazer um programa para calcular o troco no processo de pagamento de um produto de uma mercearia.
//O programa deve ler o preço unitário do produto, a quantidade de unidades compradas deste produto,
//e o valor em dinheiro dado pelo cliente (suponha que haja dinheiro suficiente). Seu programa deve
//mostrar o valor do troco a ser devolvido ao cliente. 

using System.Globalization;

namespace CalculoTroco
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double precoProduto, dinheiroRecebido, trocoRecebido;
            int quantidadeComprada;

            CultureInfo CI = CultureInfo.InvariantCulture;
 
            Console.Write("Preço unitário do produto: ");
            precoProduto = double.Parse(Console.ReadLine(), CI);

            Console.Write("Quantidade comprada: ");
            quantidadeComprada = int.Parse(Console.ReadLine());

            Console.Write("Dinheiro recebido: ");
            dinheiroRecebido = double.Parse(Console.ReadLine(), CI);

            trocoRecebido = dinheiroRecebido - precoProduto * quantidadeComprada;

            Console.Write($"TROCO = {trocoRecebido.ToString("F2", CI)}");
        }
    }
}
