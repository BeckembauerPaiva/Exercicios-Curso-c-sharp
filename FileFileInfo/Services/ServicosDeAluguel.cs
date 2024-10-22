using System;
using FileFileInfo.Entities;


namespace FileFileInfo.Services
{
    internal class ServicosDeAluguel
    {
        public double PrecoPorHora { get;private set; }
        public double PrecoPorDia { get;private set; }

        private ITaxServices _taxaDeImportacao;
        public ServicosDeAluguel(double precoPorHora, double precoPorDia,ITaxServices taxServices)
        {
            PrecoPorHora = precoPorHora;
            PrecoPorDia = precoPorDia;
            _taxaDeImportacao = taxServices;//Inversão de controle por meio de injeção de dependencia.
        }
        

        //methodo para processar a nota usando o objeto (AluguelDeVeiculos)

        public void ProcessadorDeNota(AluguelDeVeiculos aluguelDeVeiculos)
        {
            TimeSpan DuracaoDoAluguel = aluguelDeVeiculos.FimEntrega.Subtract(aluguelDeVeiculos.InicioRetirada);

            double basePagamento = 0.0;
            if(DuracaoDoAluguel.TotalHours <= 12.0)
            {
                basePagamento = PrecoPorHora + Math.Ceiling(DuracaoDoAluguel.TotalHours);

            }
            else
            {
                basePagamento = PrecoPorDia + Math.Ceiling(DuracaoDoAluguel.TotalDays);
            }
            double Tax = _taxaDeImportacao.Tax(basePagamento);

            aluguelDeVeiculos.NotaDePagamento = new NotaDePagamento(basePagamento, Tax);
        }
    }
}
