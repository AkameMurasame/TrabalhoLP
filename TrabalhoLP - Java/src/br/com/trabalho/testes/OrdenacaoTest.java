package br.com.trabalho.testes;

import br.com.trabalho.algoritimos.Ordenacao;
import junit.framework.TestCase;

public class OrdenacaoTest extends TestCase {

	public void TesteOrdenação() {
		int[] intArray = new int[] { 9, 5, 2, 3, 1, 7, 6, 4, 8, 10, 15, 12, 14, 11, 13, 20, 17, 19, 16, 18 };
		Ordenacao ordenacao = new Ordenacao();
		int[] ordenado = ordenacao.insertionSort(intArray);
		System.out.print(ordenado);
	}
}
