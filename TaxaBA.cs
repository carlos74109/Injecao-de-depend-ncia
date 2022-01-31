using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InjecaoDependencia.Entidades
{
    internal class TaxaBA : ITaxa
    {
        public double taxa(double taxa)
        {
            return taxa * 0.30;
        }
    }
}
