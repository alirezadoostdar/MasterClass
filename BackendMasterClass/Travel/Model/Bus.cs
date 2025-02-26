public class Bus
{
	public int Code { get; set; }
	public string Title { get; set; }
	public double Rate { get; set; }
	public double ReturnRate { get; set; }
    public int Seats { get; set; }
	public static Bus CreateNormal()
	{
		Bus normalBus = new();
		normalBus.Code = 10;
		normalBus.Title = "Normal";
		normalBus.Rate = 0;
		normalBus.ReturnRate = 0.3;
		normalBus.Seats = 40;
		return normalBus;
	}

	public static Bus CreateVip()
	{
		Bus vipBus = new();
		vipBus.Code = 10;
		vipBus.Title = "VIP";
		vipBus.Rate = 0.5;
		vipBus.ReturnRate = 0.3;
		vipBus.Seats = 25;
		return vipBus;
	}
}