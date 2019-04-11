using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppImpostoRenda.Models
{
    interface IRegraDeCalculo
    {
        Imposto Calcula(decimal salario);
    }
}
