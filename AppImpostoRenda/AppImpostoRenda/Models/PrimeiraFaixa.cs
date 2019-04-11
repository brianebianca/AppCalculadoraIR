using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppImpostoRenda.Models
{
    public class PrimeiraFaixa : IRegraDeCalculo
    {
        public Imposto Calcula(decimal salario)
        {
            return new Imposto(salario, new decimal(0.075), new decimal(142.8));
        }
    }
}
