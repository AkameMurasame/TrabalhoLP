package br.com.trabalho.algoritimos;

public class Fatorial {
	public long fatorial(long num) {
		if (num <= 1)
			return 1;
		else
			return num * fatorial(num - 1);
	}
}