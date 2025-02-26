using System.Runtime.InteropServices;
using System.Text;
using System.Transactions;
using Travel.Controller;

public static class program
{
	public static void Main(string[] args)
	{
		TripController trip = new();
		TicketController ticket = new();

		for (; ; )
		{
			Console.WriteLine("1-Show available trip");
			Console.WriteLine("2-Buy ticket");
			Console.WriteLine("3-return ticket");
			Console.WriteLine("4-Show total sell");
			Console.WriteLine("5-Show total sell of trip");
			Console.WriteLine("6-Exit");

			var selectedItem = Console.ReadLine();

			switch (selectedItem)
			{
				case "1":
					Console.WriteLine(trip.GetAvailableTrip());
					break;
				case "2":
					{
						Console.WriteLine("Enter trip numbet");
						var tripNo = Console.ReadLine();
						Console.WriteLine("Enter first name");
						var name = Console.ReadLine();
						Console.WriteLine("Enter last name");
						var family = Console.ReadLine();
						Console.WriteLine(ticket.SellTicket(tripNo, name, family).ToMessage());
					}
					break;
				case "3":
					{
						Console.WriteLine("Enter ticket numbet");
						var ticketNo = Convert.ToInt32(Console.ReadLine());
						Console.WriteLine(ticket.ReturnTicket(ticketNo).ToMessage());
					}
					break;
				case "4":
					Console.WriteLine(ticket.TotalSell().ToMessage());
					break;
				case "5":
					{
						Console.WriteLine("Enter trip numbet");
						var tripNo = Console.ReadLine();
						Console.WriteLine(ticket.TotalSellByTrip(tripNo).ToMessage());
					}
					break;
				case "6":
					Environment.Exit(0);
					break;
				default:
					break;
			}
		}
	}
}



















public static class Messeage
{
	public static string ToMessage(this string message)
	{
		StringBuilder sb = new StringBuilder();
		sb.AppendLine("***************************************************");
		sb.AppendLine(message);
		sb.AppendLine("***************************************************");
		return sb.ToString();
	}
}
