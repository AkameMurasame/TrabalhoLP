package br.com.trabalho.testes;

import br.com.trabalho.algoritimos.Fatorial;
import junit.framework.TestCase;

public class FatorialTest extends TestCase {

	public void TesteFatorial() {
		long numero = 30L;
		Fatorial fatorial = new Fatorial();
		long resultado = fatorial.fatorial(numero);
		System.out.print(resultado);
	}
}
