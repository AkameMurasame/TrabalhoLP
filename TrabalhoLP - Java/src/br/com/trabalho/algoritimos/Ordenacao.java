package br.com.trabalho.algoritimos;

public class Ordenacao {

	public int[] insertionSort(int[] arr) {
		int j;
		int arrkey;
		int i;

		for (j = 1; j < arr.length; j++) {
			arrkey = arr[j];
			for (i = j - 1; (i >= 0) && (arr[i] > arrkey); i--) {
				arr[i + 1] = arr[i];
			}
			arr[i + 1] = arrkey;
		}

		return arr;
	}
}
