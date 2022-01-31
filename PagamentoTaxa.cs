using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InjecaoDependencia.Entidades
{
    internal class PagamentoTaxa
    {
        public double pagamento;
        public string nome;

        ITaxa taxaInterface; 
        public PagamentoTaxa(string nome, double pagamento, ITaxa taxaInterface)
        {
            this.pagamento = pagamento;
            this.nome = nome;
            this.taxaInterface = taxaInterface;
        }

        public double pagamentoTaxa()
        {
            return taxaInterface.taxa(pagamento);
        }

        public override string ToString()
        {
            return "Ola " + nome + ", seu valor da taxa a pagar é: " + pagamentoTaxa();
        }


    }
}
