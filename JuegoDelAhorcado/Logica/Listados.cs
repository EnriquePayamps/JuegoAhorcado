using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoDelAhorcado.Logica
{
    class Listados
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

        public static string NombreAnimal
        {
            get => animales[random.Next(animales.Count - 1)];
        }

        private static List<string> frutas = new List<string>
        {
            "Manzana",
             "Pera",
            "Mango",
            "Limon",
            "Papaya",
            "Banana",
            "Zapote",
            "Naranja",
            "Lechosa",
            "Sandia"
        };
        public static string NombreFruta 
        {
            get => frutas[random.Next(frutas.Count - 1)];
        }

        private static List<string> carros = new List<string> 
        {
            "Audi",
            "Lexus",
            "Honda",
            "Mazda",
            "Kia",
            "Toyota",
            "Nissan",
            "Ford",
            "Jeep",
            "Porsche",
        };
        public static string NombreCarro
        {
            get => carros[random.Next(carros.Count - 1)];
        }
    }
}
