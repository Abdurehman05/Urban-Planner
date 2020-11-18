using System;
using System.Collections.Generic;

namespace Planner
{
    public class Building
    {
        private string _designer = "Abdu Kemal";
        private DateTime _dateConstructed;
        private string _address = "1323 Jupitor Rd";
        private string _owner = "Kassa Property";
        public int Stories { get; set; }
        public double Width { get; set; }
        public double Depth { get; set; }

        public double Volume
        {
            get
            {
                return Width * Depth * (3 * Stories);
            }
        }

        public Building(string address)
        {
            _address = address;
        }

        public void Construct()
        {
            _dateConstructed = DateTime.Now;
        }

        public void Purchase(string name)
        {
            _owner = name;
        }
        public void Display()
        {
            Console.WriteLine(
        $@"
            {_address}
         ---------------
    Designed by {_designer}
    Constructed on {_dateConstructed}
    Owned by {_owner}
    {Volume} cubic meters of space");
        }
    }
}