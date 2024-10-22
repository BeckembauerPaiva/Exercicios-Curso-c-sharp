


namespace FileFileInfo.Services
{
    class TaxaDeImportacaoBrazil : ITaxServices//nao é herança
    //Classe responsavel apenas para caucular a taxa
    {
        public double Tax(double valor)//assinatura compativel com interface
        {
            if (valor <= 100.0)
            {
                return valor * 0.2;
            }
            else
            {
                return valor * 0.15;
            }
        }
    }
}
