package br.com.trabalho.testes;

import br.com.trabalho.algoritimos.Fibonacci;
import junit.framework.TestCase;

public class FibonacciTest extends TestCase {
	public void TesteFibonacci() {
		int numero = 15;
		Fibonacci fibonacci = new Fibonacci();
		int resultado = fibonacci.fib(numero);
		System.out.print(resultado);
	}
}
