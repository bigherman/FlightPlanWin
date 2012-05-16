﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;

namespace AirfieldModel
{
	public class Airfield
	{
		public int AirfieldID { get; set; }
		public string Name { get; set; }
		public string ICAO { get; set; }
		public string Country { get; set; }
		public decimal Latitude { get; set; }
		public decimal Longitude { get; set; }
		public int Tilecol { get; set; }
		public int Tilerow { get; set; }
		[NotMappedAttribute]
		public string Observation { get; set; }
	}
}
