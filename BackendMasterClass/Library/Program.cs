using System.ComponentModel;

public class program
{
	public static void Main(string[] args)
	{

        Console.WriteLine(CalculatePowSum(1,3));

        for (; ; )
		{
			Console.WriteLine("1) Search Book");
			Console.WriteLine("2) Rent Book");
			Console.WriteLine("3) Return Book");
			Console.WriteLine("4) Exit");

			var userSelectedItem = Console.ReadLine();
			switch (userSelectedItem)
			{
				case "1":
					Console.WriteLine("Please enter book Title");
					break;
				case "2":
					Console.WriteLine("rent Book");
					break;
				case "3":
					Console.WriteLine("return book");
					break;
				case "4":
					Environment.Exit(0);
					break;
				default:
					Console.WriteLine("Invalid input data");
					break;
			}
		}
	}

	public double CalculatePowSum(int i, int j)
	{
		if (i < 0 || j < 0 || j < i)
			throw new ArgumentOutOfRangeException();
		
		double sum = 0;
		for (int n = i; n <= j ; n++ )
		{
			sum += Math.Pow(n,n);
		}

		return sum;
	}

}
