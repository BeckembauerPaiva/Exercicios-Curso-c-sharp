using System;


namespace FileFileInfo.Entities
{
    internal class AluguelDeVeiculos
    {
        public DateTime InicioRetirada { get; set; }
        public DateTime FimEntrega { get; set; }
        public Veiculo Veiculo { get; set; }//assosiações 
        public NotaDePagamento NotaDePagamento { get; set; }

        public AluguelDeVeiculos(DateTime inicioRetirada, DateTime fimEntrega, Veiculo veiculo)//construtor sem nota de pagamento
            //pois será iniciado como nulo pois só sera processada quando alugar o veiculo
        {
            InicioRetirada = inicioRetirada;
            FimEntrega = fimEntrega;
            Veiculo = veiculo;
            NotaDePagamento = null;//desencargo de consciencia
        }




    }
}
