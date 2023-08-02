using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work3
{
    internal class PlanetCatalog
    {
        public List<string> catalog = new List<string>();
        delegate bool PlanetValidator(string name);

        public static bool PlanetValidator1 (string name)
        {
            return true;
        }
        PlanetValidator planetValidator = PlanetValidator1;


        public void GetAPlanet(params string[] Planets)
        {
            foreach (string planet in Planets)
            {
                catalog.Add(planet);
            }
            foreach (var item in catalog)
            {
                var selectedPlanet = GetAPlanet(item, planetValidator);
                if (selectedPlanet.SerialNumber == 0)
                {
                    Console.WriteLine(item);
                    Console.WriteLine(selectedPlanet.Error);
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine($"Название планеты - {item}");
                    Console.WriteLine($"Длина Экватора {selectedPlanet.EquatorLength}");
                    Console.WriteLine($"Порядковый номер от солнца {selectedPlanet.SerialNumber}");
                    Console.WriteLine();
                }
            }
        }

        public (int SerialNumber, int EquatorLength, string Error) GetAPlanet(string name, Delegate planetValidator)
        {
            var planetData = new Planet();
            planetData.name = name;
            var serialNumber = planetData.serialNumber;
            var equatorLength = planetData.equatorLength;
            if (serialNumber == 0 || equatorLength == 0)
            {
                return (serialNumber, equatorLength, "Не удалось найти планету");
            }
            return (serialNumber, equatorLength, "");
        }
    }
}
