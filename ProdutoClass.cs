using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace resolvendo
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEmEstoque()
        {
            return  Preco * Quantidade;

        }


        public void AdicionarProdutos(int quantidade)
        {
            Quantidade = Quantidade + quantidade;
            
        }

        public void RemoverProdutos(int remover)
        {
            Quantidade = Quantidade - remover;
        }


        public override string ToString()
        {
            return Nome
                + ",$"
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ","
                + Quantidade
                + " Unidades, Total: $ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }

        



    }
}
