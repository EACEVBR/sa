namespace ConsoleApp4
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Введите число палиндром: ");
			int num = int.Parse(Console.ReadLine());
			string numStr = num.ToString();
			if (numStr[numStr.Length / 2] == '0')
			{
				Console.WriteLine(num - (num.ToString().Length));
			}
			else {

				Console.WriteLine((num.ToString().Length % 2 == 0) ? 
						( num - Math.Pow(10, num.ToString().Length / 2 - 1) - Math.Pow(10, num.ToString().Length / 2)) 
						: num - Math.Pow(10, num.ToString().Length / 2));
			
			} 
		}
	}
}