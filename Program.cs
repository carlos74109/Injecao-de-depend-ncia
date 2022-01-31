using InjecaoDependencia.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InjecaoDependencia
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Seu nome: ");
            string nome =  Console.ReadLine();

            Console.WriteLine("Voce é da Bahia, São Paulo ou Minas Gerais(B/S/M)?");
            string estado = Console.ReadLine();

            Console.WriteLine("Valor do seu pagamento: ");
            double pagamento = double.Parse(Console.ReadLine());
            
            if(estado == "B")
            {
            PagamentoTaxa pagTaxa = new PagamentoTaxa(nome, 1000, new TaxaBA());
            Console.WriteLine(pagTaxa);
            }else if(estado == "S")
            {
                PagamentoTaxa pagTaxa = new PagamentoTaxa(nome, 1000, new TaxaSP());
                Console.WriteLine(pagTaxa);
            }else if(estado == "M")
            {
                PagamentoTaxa pagTaxa = new PagamentoTaxa(nome, 1000, new TaxaMg());
                Console.WriteLine(pagTaxa);
            }

        }
    }
}
