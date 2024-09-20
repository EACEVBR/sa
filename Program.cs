namespace ConsoleApp4
{
	internal class Program
	{
		public static int[][] ReshapeMatrix(int[][] mat, int r, int c)
		{
			int m = mat.Length; 
			int n = mat[0].Length; 
			int[][] reshapedMatrix = new int[r][];
			for (int i = 0; i < r; i++)
			{
				reshapedMatrix[i] = new int[c];
			}
			for (int i = 0; i < m * n; i++)
			{
				reshapedMatrix[i / c][i % c] = mat[i / n][i % n];
			}
			return reshapedMatrix;
		}

		static void Main(string[] args)
		{
			int[][] mat = new int[][]
			{
			new int[] {1, 2},
			new int[] {3, 4}
			};
			int rows = mat.Length;
			int cols = mat[0].Length;
			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < cols; j++)
				{
					Console.Write(mat[i][j] + " ");
				}
				Console.WriteLine();
			}
			int r = 1, c = 4;
			int[][] reshaped = ReshapeMatrix(mat, r, c);
			int rowss = reshaped.Length;
			int colss = reshaped[0].Length;
			for (int i = 0; i < rowss; i++)
			{
				for (int j = 0; j < colss; j++)
				{
					Console.Write(reshaped[i][j] + " "); 
				}
				Console.WriteLine(); 
			}
		}
	}
}