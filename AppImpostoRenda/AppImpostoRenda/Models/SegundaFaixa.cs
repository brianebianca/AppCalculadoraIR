using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppImpostoRenda.Models
{
    public class SegundaFaixa : IRegraDeCalculo
    {
        public Imposto Calcula(decimal salario)
        {
            return new Imposto(salario, new decimal(0.15), new decimal(354.80));
        }
    }
}
