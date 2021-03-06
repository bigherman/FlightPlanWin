﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FlightPlanModel;
using System.Data.Entity;
using System.IO;

namespace FlightPlanWin
{
    class FlightPlanContextInitializer : CreateDatabaseIfNotExists<FlightPlanContext>
    {
        protected override void Seed(FlightPlanContext context)
        {
            var airfields = File.ReadAllLines("assets/airfields.csv")
                   .Skip(1)
                   .Select(x => x.Split(','))
                   .Select(x => new Airfield {
                       Name = x[0],
                       ICAO = x[1],
                       Country = x[2],
                       Latitude = decimal.Parse(x[3],System.Globalization.CultureInfo.InvariantCulture),
                       Longitude = decimal.Parse(x[4],System.Globalization.CultureInfo.InvariantCulture),
                       Tilecol = int.Parse(x[5]),
                       Tilerow = int.Parse(x[6])
                   });
            foreach (Airfield airfield in airfields) {
                context.Airfields.Add(airfield);
            }
            base.Seed(context);
        }
    }
}
