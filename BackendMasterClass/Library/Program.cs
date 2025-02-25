public class program
{
	public static void Main(string[] args)
	{
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
}
