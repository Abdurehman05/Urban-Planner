using System;
using System.Collections.Generic;
namespace Planner
{
    public class City
    {
        public string CityName { get; set; }
        public string Mayor { get; set; }
        public int YearEstablished { get; set; }
        public List<Building> buildings = new List<Building>();

        public void AddBuilding(Building building)
        {
            buildings.Add(building);
        }


    }
}