using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work2
{
    internal class PlanetCatalog
    {
        public List<string> catalog = new List<string>();

        public void GetAPlanet (params string[] Planets)
        {
            foreach (string planet in Planets)
            {
                catalog.Add(planet);
            }
            int i = 0;
            foreach (var item in catalog)
            {
                i ++;
                var selectedPlanet = GetAPlanet(item, i);
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

        public (int SerialNumber, int EquatorLength, string Error) GetAPlanet(string name, int i)
        {
            if (i == 3)
            {
                return (0, 0, "Вы спрашиваете слишком часто");
            }
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
