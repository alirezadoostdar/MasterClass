using System.Globalization;
using System.Runtime.CompilerServices;

public class Trip
{
    public Trip(string tripNo, Bus bus, Path path, double basePrice, DateTime tripDate)
    {
        TripPath = path;
        Bus = bus;
        date = tripDate;
        BasePrice = basePrice;
        TripNo = tripNo;
    }
    public string TripNo { get; private set; }
    public Bus Bus { get; private set; }
    public Path TripPath{ get; private set; }
    public DateTime date { get; private set; }
    public int SoldSeat { get; private set; }
    public int RemainSeat => Bus.Seats - SoldSeat;
    public double BasePrice { get; private set; }
    public double Price
    {
        get { return BasePrice * (1 + Bus.Rate); }
    }
    public double CancellationFee => Price * Bus.ReturnRate; 
    public double ReturnPrice => Price * (1 - Bus.ReturnRate);
    public bool IsAvailable => date > DateTime.Now;

    public void sell()
    {
        SoldSeat++;
    }
    public void Return()
    {
        SoldSeat--;
    }
    public override string ToString()
	{
        return $"Trip No.:{TripNo} From: {TripPath.Source} To: {TripPath.Destination}\n" +
            $" Date: {date.ToShamsi()} Time: {date.ToString("HH:mm")} \n" +
       $"Price: {Price} Remain Seat: {RemainSeat} \n" +
       $" Notice: the cancellation fee is {CancellationFee}\n" +
       $"----------------------------------------------------------------------------------";
	}

}

public static class ShamsiDate
{
    public static string ToShamsi(this DateTime date)
    {
        PersianCalendar pc = new PersianCalendar();
        int year = pc.GetYear(date);
        int month = pc.GetMonth(date);
        int day = pc.GetDayOfMonth(date);
        return $"{year}/{month.ToString("00")}/{day.ToString("00")}";
    }
}
