using Moq;
using System;
using Trabalho.Net.Core.Algoritimos.Concrete;
using Xunit;
using Xunit.Abstractions;

namespace TrabalhoLp.Net.Core
{
    public class UnitTest1
    {
        private readonly ITestOutputHelper output;//ITestOutputHelper permite que escrevamos logs dos testes executados
        public UnitTest1(ITestOutputHelper outputHelper)
        {
            output = outputHelper;
        }

        [Fact(DisplayName = "Fibonacci")]
        public void Fibonacci()
        {
            var data = DateTime.Now;
            var fibonacci = new Fibonacci();
            int numero = 15;
            var resultado = fibonacci.fib(numero);
            output.WriteLine("Fibonacci foi executado {0:hh:mm:ss.fff tt}, resultado: " + resultado, data);
            //fibonacci.Verify(r => r.fib(numero), Times.Once);
        }

        [Fact(DisplayName = "Fatorial")]
        public void Fatorial()
        {
            var data = DateTime.Now;
            var fatorial = new Fatorial();
            long numero = 30;
            var resultado = fatorial.fatorial(numero);
            output.WriteLine("Fatorial foi executado {0:hh:mm:ss.fff tt}, resultado: " + resultado, data);
            //fatorial.Verify(r => r.fatorial(numero), Times.Once);
        }

        [Fact(DisplayName = "Ordenacao")]
        public void Ordenacao()
        {
            var data = DateTime.Now;
            var ordenacao = new Ordenacao();
            int[] intArray = new int[] { 9, 5, 2, 3, 1, 7, 6, 4, 8, 10, 15, 12, 14, 11, 13, 20, 17, 19, 16, 18 };
            var ordenado = ordenacao.insertionSort(intArray);
            output.WriteLine("Ordenacao foi executado {0:hh:mm:ss.fff tt}, resultado: " + ordenado, data);
            //fibonacci.Verify(r => r.insertionSort(intArray), Times.Once);
        }
    }
}
