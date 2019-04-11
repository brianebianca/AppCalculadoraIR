using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppImpostoRenda.Models
{
    public class QuartaFaixa : IRegraDeCalculo
    {
        public Imposto Calcula(decimal salario)
        {
            return new Imposto(salario, new decimal(0.275), new decimal(869.36));
        }
    }
}
