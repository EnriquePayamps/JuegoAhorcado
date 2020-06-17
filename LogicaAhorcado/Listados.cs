using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LogicaAhorcado
{
    public static class Listados
    {
        private static Random random = new Random();
        private static List<string> animales = new List<string> {
            "Perro",
            "Gato",
            "Caballo",
            "Elefante",
            "Hipopotamo",
            "Tiguere",
            "Leopardo",
            "Vaca",
            "Burro",
            "Leon"
        };

        public static string GetAnimal {
            get => animales[random.Next(animales.Count-1)];
        }

        /*public void listadoFrutas()
        {
            List<String> Frutas = new List<string>();
            var random = new Random();
            Frutas.Add("Manzana");
            Frutas.Add("Pera");
            Frutas.Add("Mango");
            Frutas.Add("Limon");
            Frutas.Add("Papaya");
            Frutas.Add("Banana");
            Frutas.Add("Zapote");
            Frutas.Add("Naranja");
            Frutas.Add("Lechosa");
            Frutas.Add("Sandia");
            int index = random.Next(Frutas.Count);
        }

        public void listadoCarros()
        {
            List<String> Carros = new List<string>();
            var random = new Random();
            Carros.Add("Audi");
            Carros.Add("Lexus");
            Carros.Add("Honda");
            Carros.Add("Mazda");
            Carros.Add("Kia");
            Carros.Add("Toyota");
            Carros.Add("Nissan");
            Carros.Add("Ford");
            Carros.Add("Jeep");
            Carros.Add("Porsche");
            int index = random.Next(Carros.Count);
        }
        */
    }
}
