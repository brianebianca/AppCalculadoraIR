using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppImpostoRenda.Models
{
    public class Isento : IRegraDeCalculo
    {
        public Imposto Calcula(decimal salario)
        {
            return new Imposto(salario, new decimal(0.0), new decimal(0.0));
        }
    }
}
