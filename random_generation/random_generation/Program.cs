using System;

namespace random_generation
{
	class MainClass
	{
		public static void Main (string[] args) {
			int p;
			p = 10;
			int count = 1;
			int[,] array = new int[p - 1, p - 1];
			for (int i = 0; i < p - 1; i++) {
				for (int j = 0; j < p - 1; j++) {
					array [i, j] = count;
					count++;
				}
			}
			var b = array;
			// закон изменения: A[i][1] = B[i][n] * pow((A[i][n]), n) + .. + B[i][1]*A[i][1] (mod p) for any i (1..n)
			//A[1][j] = B[n][j] * pow(A[n][j]), n) + .. + B[1][j] * A[1][j] (mod p) or any i (j..n)


			}
	}
}
