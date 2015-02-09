/*....By : Robinson Mann
 *..Date : 2/3/2015
 *.About : Contians all the classes need for any of the foodserivces
 *         API calls, aswell as associated factory methods. 
 **********************/

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net;
using System.Text;
using Newtonsoft.Json;

// todo: Get Newtonsoft.Json to ignore _ when mapping to objects

namespace UWaterlooAPI.FoodServices
{
	public class Date
	{
		public int? Week { get; set; }
		public int? Year { get; set; }
		public string Start { get; set; }
		public string End { get; set; }
	}

	public class Outlet {
		public string Outlet_Name { get; set; }
		public int? Outlet_Id { get; set; }
		public IEnumerable<OutletMenu> Menu { get; set; }
		public string Notes { get; set; }
	}

	public class OutletMenu
	{
		public string Date { get; set; }
		public string Day { get; set; }
		public Meals Meals { get; set; }
		public string notes { get; set; }
	}

	public class Meals
	{
		public IEnumerable<Meal> Lunch { get; set; }
		public IEnumerable<Meal> Dinner { get; set; }
	}

	public class Meal
	{
		public string Product_Name { get; set; }
		public string Diet_Type { get; set; }
		public string Product_Id { get; set; }
	}
	
	public class WeeklyFoodMenu
	{
		public Date Date { get; set; }

		public IEnumerable<Outlet> Outlets;
	}

	public class NoteEncapsulated
	{
		public Date Date { get; set; }
		public string OutletName { get; set; }
		public int OutletId { get; set; }
		public string Note { get; set; }
	}

	public class Notes
	{
		public IEnumerable<NoteEncapsulated> notes;
	}
	
	public class Diet 
	{
		public int DietId {get;set;}
		public string DietType {get;set;}

	}

	public class Diets
	{
		public IEnumerable<Diet> diets;
	}

	public class OutletMore
	{
		public int? OutletId { get; set; }
		public string OutletName { get; set; }
		public bool? HasBreakfast { get; set; }
		public bool? HasLunch { get; set; }
		public bool? HasDinner { get; set; }
	}

	public class OutletsMore 
	{
		public IEnumerable<OutletMore> Outlets;
	}

	public class FoodServicesApiService
	{
		private readonly string _apiKey;

		public FoodServicesApiService(string apiKey)
		{
			_apiKey = apiKey;
		}
		
		/// <summary>
		/// todo 
		/// </summary>
		/// <param name="apiKey">Your UWaterloo API Key</param>
		/// <returns></returns>
		public UWaterlooApi.ApiCall<WeeklyFoodMenu> Menu()
		{
			// TODO: Make this compliant to ISO Standards. The offical API documentation is unclear in what, if any, standards it follows
			var DateTimeUtcNow = DateTime.UtcNow;

			var request = string.Format("https://api.uwaterloo.ca/v2/foodservices/{0}/{1}/menu.json?key={2}",
				DateTimeUtcNow.Year,
				CultureInfo.GetCultureInfo("en").Calendar.GetWeekOfYear(DateTimeUtcNow, CalendarWeekRule.FirstDay, DayOfWeek.Monday),
				_apiKey);

			var json = new WebClient().DownloadString(request);

			var returnObject = JsonConvert.DeserializeObject<UWaterlooApi.ApiCall<WeeklyFoodMenu>>(json);
			return returnObject;
		}

		/// <summary>
		/// todo
		/// </summary>
		/// <returns></returns>^
		public UWaterlooApi.ApiCall<Notes> Notes()
		{
			UWaterlooApi.ApiCall<Notes> notes = new UWaterlooApi.ApiCall<Notes>();
			return notes;
		}

		/// <summary>
		/// todo
		/// </summary>
		/// <returns></returns>
		public UWaterlooApi.ApiCall<Diets> Diets()
		{
			UWaterlooApi.ApiCall<Diets> diets = new UWaterlooApi.ApiCall<Diets>();
			return diets;
		}

		/// <summary>
		/// todo
		/// </summary>
		/// <returns> GET /foodservices/outlets </returns>
		public UWaterlooApi.ApiCall<OutletMore> Outlets() 
		{
			return null;
		}

	}
}