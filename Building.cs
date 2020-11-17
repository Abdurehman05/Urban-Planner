using System;

namespace Planner
{
    public class Buliding
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

        public Buliding(string address)
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

    }
}