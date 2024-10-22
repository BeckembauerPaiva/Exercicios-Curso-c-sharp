using System.Globalization;


namespace FileFileInfo.Entities
{
    internal class NotaDePagamento
    {
        public double BasePagamento { get; set; }
        public double Taxa { get; set; }

        public NotaDePagamento(double basePagamento,double taxa)
        {
            Taxa = taxa;
            BasePagamento = basePagamento;

            
        }

        public double TotalPagamento
        {
            get { return BasePagamento + Taxa; }//propriedade cauculada
        }

        public override string ToString() //informações da nota 
        {
            return "Pagamento base: "
                + BasePagamento.ToString("F2", CultureInfo.InvariantCulture)
                + "\nTaxa: "
                + Taxa.ToString("F2", CultureInfo.InvariantCulture)
                + "\nTotal a pagar: "
                + TotalPagamento.ToString("F2", CultureInfo.InvariantCulture);
                
        }
    }
}
