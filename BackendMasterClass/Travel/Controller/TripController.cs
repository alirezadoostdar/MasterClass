using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel.Controller
{
	public class TripController
	{
        public static List<Trip> TripList = new List<Trip>()
		{
			new Trip("ST22610", Bus.CreateNormal(), Path.ShirazToTehran(), 100_000, new DateTime(2025,2,26,10,30,0)),
			new Trip("ST22817", Bus.CreateVip(), Path.ShirazToTehran(), 100_000, new DateTime(2025,2,28,17,40,0)),
			new Trip("AT22712", Bus.CreateNormal(), Path.AhvazToTehran(), 120_000, new DateTime(2025,2,27,12,20,0)),
			new Trip("AT30108", Bus.CreateVip(), Path.AhvazToTehran(), 120_000, new DateTime(2025,3,1,8,30,0)),
			new Trip("ST30106", Bus.CreateNormal(), Path.ShirazToTehran(), 100_000, new DateTime(2025,3,1,6,30,0)),
		};

		public string GetAvailableTrip()
		{
			StringBuilder sb = new StringBuilder();
			foreach (var trip in TripList)
			{
				if (trip.IsAvailable)
					sb.AppendLine(trip.ToString());
			}
			return sb.ToString();	
		}

		public Trip GetTrip(string tripNo)
		{
			foreach (var trip in TripList)
			{
				if (trip.TripNo == tripNo)
					return trip;
			}
			return null;
		}
    }
}
