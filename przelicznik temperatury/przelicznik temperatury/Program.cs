using System;

namespace przelicznik_temperatury
{
    class Temperatura
    {
        private double Celsjusz;

        public Temperatura(double C)
        {
            Celsjusz = C;
        }
        public double CelsjuszToFahrenheit()
        {
            return (1.8 * Celsjusz) + 32;
        }
        public double CelsjuszToKelvin()
        {
            return Celsjusz + 273.15;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj temperaturę w stopniach Celsjusza: ");
            double Celsjusz = double.Parse(Console.ReadLine());
            Temperatura temperatura1 = new Temperatura(Celsjusz);
            Console.WriteLine("Temperatura w stopniach Fahrenheita: {0} " ,temperatura1.CelsjuszToFahrenheit());
            Console.WriteLine("Temperatura w stopniach Kelwina: {0} ", temperatura1.CelsjuszToKelvin());
            Console.ReadKey();
        }
    }
}
