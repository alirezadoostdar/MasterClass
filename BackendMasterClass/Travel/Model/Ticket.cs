public class Ticket
{
    private Ticket(Trip trip, string name, string family)
    {
        Trip = trip;
		Name = name;
		Family = family;
    }
    public int Code { get; private set; }
	public string Name { get; private set; }
	public string Family { get; private set; }
	public double Price { get; private set; }
	public Trip Trip { get;private set; }
    public int	Sign { get; private set; }

	public static Ticket Sell(Trip trip, string name, string family)
	{
		var ticket = new Ticket(trip, name, family);
		ticket.Sign = (int)TicketType.Sell;
		ticket.Code = new Random().Next(100, 1000);
		ticket.Price = trip.Price;
		return ticket;
	}

	public static Ticket Return(Trip trip, string name, string family,int code)
	{
		var ticket = new Ticket(trip, name, family);
		ticket.Sign = (int)TicketType.Return;
		ticket.Code = code;
		ticket.Price = trip.ReturnPrice;
		return ticket;
	}
}

public enum TicketType
{
	Sell = 1,
	Return = -1
}


