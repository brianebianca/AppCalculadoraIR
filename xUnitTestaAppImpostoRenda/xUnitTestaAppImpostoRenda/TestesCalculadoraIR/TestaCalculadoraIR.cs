using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Xunit.Abstractions;
using AppImpostoRenda.Models;

namespace xUnitTestaAppImpostoRenda.TestesCalculadoraIR
{
    public class TestaCalculadoraIR
    {
        CalculadoraImposto calculadora;

        public TestaCalculadoraIR()
        {
            this.calculadora = new CalculadoraImposto();
        }

        [Fact]
        public void TestaImpostoIsento()
        {
            decimal salario = new decimal(1903.98);
            Imposto impostoCalculado = calculadora.CalcularImposto(salario);
            decimal valorEsperadoParcelaDeduzir = new decimal(0);

            Assert.Equal(impostoCalculado.parcelaDeduzir, valorEsperadoParcelaDeduzir);            
        }

        [Fact]
        public void TestaImpostoPrimeiraFaixa()
        {
            decimal salario = new decimal(1903.99);
            Imposto impostoCalculado = calculadora.CalcularImposto(salario);
            decimal valorEsperadoParcelaDeduzir = new decimal(142.8);

            Assert.Equal(impostoCalculado.parcelaDeduzir, valorEsperadoParcelaDeduzir);
        }

        [Fact]
        public void TestaImpostoSegundaFaixa()
        {
            decimal salario = new decimal(2826.66);
            Imposto impostoCalculado = calculadora.CalcularImposto(salario);
            decimal valorEsperadoParcelaDeduzir = new decimal(354.8);

            Assert.Equal(impostoCalculado.parcelaDeduzir, valorEsperadoParcelaDeduzir);
        }

        [Fact]
        public void TestaImpostoTerceiraFaixa()
        {
            decimal salario = new decimal(3751.06);
            Imposto impostoCalculado = calculadora.CalcularImposto(salario);
            decimal valorEsperadoParcelaDeduzir = new decimal(636.13);

            Assert.Equal(impostoCalculado.parcelaDeduzir, valorEsperadoParcelaDeduzir);
        }

        [Fact]
        public void TestaImpostoQuartaFaixa()
        {
            decimal salario = new decimal(4664.69);
            Imposto impostoCalculado = calculadora.CalcularImposto(salario);
            decimal valorEsperadoParcelaDeduzir = new decimal(869.36);

            Assert.Equal(impostoCalculado.parcelaDeduzir, valorEsperadoParcelaDeduzir);
        }
    }
}
