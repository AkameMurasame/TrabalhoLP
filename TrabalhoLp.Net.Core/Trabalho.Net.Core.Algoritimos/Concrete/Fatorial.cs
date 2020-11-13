using System;
using System.Collections.Generic;
using System.Text;

namespace Trabalho.Net.Core.Algoritimos.Concrete
{
    public class Fatorial
    {
		public long fatorial(long num)
		{
			if (num <= 1)
				return 1;
			else
				return num * fatorial(num - 1);
		}
	}
}
