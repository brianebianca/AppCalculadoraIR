using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppImpostoRenda.Models
{
    public class CalculadoraImposto
    {
        public CalculadoraImposto() { }

        public Imposto CalcularImposto(decimal salario)
        {
            if (salario.CompareTo(new decimal(1903.99)) == -1)
                return  new Isento().Calcula(salario);
            else if (salario.CompareTo(new decimal(1903.98)) == 1 && salario.CompareTo(new decimal(2826.66)) == -1)
                return new PrimeiraFaixa().Calcula(salario);
            else if (salario.CompareTo(new decimal(2826.65)) == 1 && salario.CompareTo(new decimal(3751.06)) == -1)
                return new SegundaFaixa().Calcula(salario);
            else if (salario.CompareTo(new decimal(3751.05)) == 1 && salario.CompareTo(new decimal(4664.69)) == -1)
                return new TerceiraFaixa().Calcula(salario);
            else if (salario.CompareTo(new decimal(4664.68)) == 1)
                return new QuartaFaixa().Calcula(salario);
            else
                return new Isento().Calcula(salario);
        }
    }
}
