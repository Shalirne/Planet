

namespace Planet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Venus = new
            {
                name = "Венера",
                serialNumber = 2,
                equatorLength = 38025,
                previousPlanet = ""
            };
            var Earth = new
            {
                name = "Земля",
                serialNumber = 3,
                equatorLength = 40075,
                previousPlanet = Venus
            };
            var Mars = new
            {
                name = "Марс",
                serialNumber = 4,
                equatorLength = 21344,
                previousPlanet = Earth
            };
            var VenusAgain = new
            {
                Venus
            };
            Console.WriteLine($"Планета - {Venus.name} " +
                $"\nПорядковый номер от солнца - {Venus.serialNumber} " +
                $"\nДлина экватора - {Venus.equatorLength} " +
                $"\nссылка на предыдущую планету {Venus.previousPlanet} " +
                $"\nЭквивалента ли планета Венере?{Venus.Equals(Venus)}" +
                $"  \n" +
                $"  \n");

            Console.WriteLine($"Планета - {Earth.name} " +
                $"\nПорядковый номер от солнца - {Earth.serialNumber} " +
                $"\nДлина экватора - {Earth.equatorLength} " +
                $"\nссылка на предыдущую планету {Earth.previousPlanet} " +
                $"\nЭквивалента ли планета Венере?{Earth.Equals(Venus)}" +
                $" \n" +
                $" \n");

            Console.WriteLine($"Планета - {Mars.name} " +
                $"\nПорядковый номер от солнца - {Mars.serialNumber} " +
                $"\nДлина экватора - {Mars.equatorLength} " +
                $"\nссылка на предыдущую планету {Mars.previousPlanet} " +
                $"\nЭквивалента ли планета Венере?{Mars.Equals(Venus)}" +
                $"\n" +
                $"\n");

            Console.WriteLine($"Планета - {VenusAgain.Venus.name} " +
                $"\nПорядковый номер от солнца - {VenusAgain.Venus.serialNumber} " +
                $"\nДлина экватора - {VenusAgain.Venus.equatorLength} " +
                $"\nссылка на предыдущую планету {VenusAgain.Venus.previousPlanet} " +
                $"\nЭквивалента ли планета Венере?{VenusAgain.Venus.Equals(Venus)}" +
                $" \n" +
                $"  \n");

        }
    }
}