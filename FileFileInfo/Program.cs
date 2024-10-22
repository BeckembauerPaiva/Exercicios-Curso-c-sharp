using System;

using System.Globalization;

using FileFileInfo.Entities;
using FileFileInfo.Services;


namespace EstudosEmCsharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com os dados do aluguel:");
            Console.Write("Modelo do veiculo: ");
            string Modelo = Console.ReadLine();
            Console.Write("Data de Retirada do veiculo (dd/MM/yyyy hh:mm): ");
            DateTime Retirada = DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy HH:mm",CultureInfo.InvariantCulture);
            //data com mascara de formatação 
            Console.Write("Data de Entrega do veiculo (dd/MM/yyyy hh:mm): ");
            DateTime Entrega = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            Console.Write("Entre com o Preço por hora: ");
            double PrecoHora = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("Entre com o Preço por dia: ");
            double PrecoDia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //instanciando construtor assosiado a classe veiculo
            AluguelDeVeiculos aluguelDeVeiculos = new AluguelDeVeiculos(Retirada, Entrega,new Veiculo(Modelo));

            //instanciando servicoDeAluguel

            ServicosDeAluguel servicosDeAluguel = new ServicosDeAluguel(PrecoHora, PrecoDia,new TaxaDeImportacaoBrazil());
            servicosDeAluguel.ProcessadorDeNota(aluguelDeVeiculos);

            Console.WriteLine("NOTA:");
            Console.WriteLine(aluguelDeVeiculos.NotaDePagamento);
        }
    }
}