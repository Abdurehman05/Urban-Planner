using System;

namespace Planner
{
    class Program
    {
        static void Main(string[] args)
        {
            Building FiveOneTwoEigth = new Building("512 8th Avenue")
            {
                Width = 800,
                Depth = 80,
                Stories = 3,

            };

            Building CapitalHill = new Building("8383 Rosa L Parks Blv")
            {
                Width = 100,
                Depth = 40,
                Stories = 4,
            };
            Building Satdium = new Building("323 1st St")
            {

                Width = 1000,
                Depth = 50,
                Stories = 3,
            };


            FiveOneTwoEigth.Construct();
            FiveOneTwoEigth.Purchase("Andy Stawrt");

            CapitalHill.Construct();
            CapitalHill.Purchase("Steve Jobs");

            Satdium.Construct();
            Satdium.Purchase("Smith Micheale");

            City Nashville = new City();
            Nashville.AddBuilding(FiveOneTwoEigth);
            Nashville.AddBuilding(CapitalHill);
            Nashville.AddBuilding(Satdium);

            Nashville.CityInfo();

            foreach (Building building in Nashville.buildings)
            {
                building.Display();
            }

        }

    }
}
