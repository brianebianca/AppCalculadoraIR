using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppImpostoRenda.Models
{
    public class Imposto
    {
        public decimal salario { get; set; }
        public decimal aliquota { get; set; }
        public decimal parcelaDeduzir { get; set; }
        public decimal impostoRetido { get; set; }

        public Imposto(decimal salario, decimal aliquota, decimal parcelaDeduzir)
        {
            this.salario = salario;
            this.aliquota = aliquota;
            this.parcelaDeduzir = parcelaDeduzir;
            impostoRetido = (salario * aliquota) - parcelaDeduzir;
        }
    }
}
