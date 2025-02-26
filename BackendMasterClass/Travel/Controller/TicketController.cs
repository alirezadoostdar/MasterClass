using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Travel.Controller;

public class TicketController
{
	public static List<Ticket> tickets = new List<Ticket>();

	private TripController tripController = new TripController();
	public string SellTicket(string tripNo, string name, string family)
	{
		var trip = tripController.GetTrip(tripNo);
		if (trip == null) return "Trip not found";

		if (!trip.IsAvailable) return "This trip is not available";

		if (trip.RemainSeat == 0) return "trip is full";

		var tiket = Ticket.Sell(trip, name, family);
		trip.sell();
		tickets.Add(tiket);
		return $"Your ticket by number {tiket.Code} confirmed successfully";
	}

	public string ReturnTicket(int ticketNo)
	{
		if (GetTicket(ticketNo, TicketType.Return) is not null)
			return $"Ticket number {ticketNo} already returend";

		var ticket = GetTicket(ticketNo, TicketType.Sell);
		if (ticket is null)
			return $"Ticket number {ticketNo} not found";


		var returnTicket = Ticket.Return(ticket.Trip, ticket.Name, ticket.Family, ticket.Code);
		var trip = tripController.GetTrip(ticket.Trip.TripNo);
		trip.Return();
		tickets.Add(returnTicket);
		return $"Your ticket by number {ticket.Code} returned successfully";
	}

	public Ticket GetTicket(int ticketNo, TicketType ticketType)
	{
		foreach (var ticket in tickets)
		{
			if (ticket.Code == ticketNo && ticket.Sign == (int)ticketType)
				return ticket;
		}
		return null;
	}

	public string TotalSell()
	{
		double total = 0;
		foreach(var ticket in tickets)
		{
			total += ticket.Price * ticket.Sign;
		}
		return $"Total sell amount is {total}";
	}

	public string TotalSellByTrip(string tripNo)
	{
		var trip = tripController.GetTrip(tripNo);
		if (trip is null)
			return $"Trip number is not valid";

		double total = 0;
		foreach (var ticket in tickets)
		{
			if (ticket.Trip.TripNo == tripNo)
				total += ticket.Price * ticket.Sign;
		}
		return $"Total Sell amount is {total}";
	}
}
