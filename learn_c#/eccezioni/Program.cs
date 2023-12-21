using System;

namespace eccezioni {
	class Program {
		static void Main() {
			int[] x = {0, 1, 4, 2};
			try {							// prova a fare quel pezzo di codice alrimenti fa il catch
				x[4] = 11;
			} catch {
				Console.WriteLine("\nImpossibile fare quella mossa");
			}

			int[] y = {1, 2, 3, 4, 5};
			try {
				y[4] = 11;
				Console.WriteLine("\nFatto");
			} catch {
				Console.WriteLine("\nImpossibile");
			}
		}
	}
}
