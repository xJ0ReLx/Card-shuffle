using System;
using System.Collections.Generic; // For list
using System.Linq;

namespace Loteria_Mexicana
{
    class Loteria_Mexicana  
    {
        static void Main(string[] args)
        {

            // Console windows title

            Console.Title = "Simulador baraja loteria mexicana.";

            // variables

            Random sacaCarta = new Random();
            int contCartas = 0;
            int restCartas = 54;

            // Begin

            Console.WriteLine("¿Estamos listos?");
            Console.WriteLine("Se va y se corre con...");
            Console.ReadLine();

            List<string> baraja = new List<string>
            {
                "La rana",
                "La chalupa",
                "El venado",
                "El borracho",
                "La luna",
                "La dama",
                "El diablo",
                "El bandolon",
                "El violoncello",
                "El apache",
                "La palma",
                "La mano",
                "La estrella",
                "El barril",
                "El catrin",
                "La maceta",
                "El musico",
                "La escalera",
                "La rosa",
                "El valiente",
                "El alacran",
                "La araña",
                "El soldado",
                "El sol",
                "El pino",
                "El arbol",
                "La botella",
                "El gallo",
                "La sandia",
                "El melon",
                "El negrito",
                "El mundo",
                "La calavera",
                "El cazo",
                "El cantarito",
                "El camaron",
                "La garza",
                "El pescado",
                "La muerte",
                "La pera",
                "La campana",
                "El corazon",
                "La corona",
                "Las jaras",
                "EL pajaro",
                "El gorrito",
                "El paraguas",
                "El tambor",
                "La sirena",
                "El nopal",
                "La bandera",
                "La bota",
                "EL cotorro",
                "El arpa",
            };

            var carta = baraja.OrderBy(x => sacaCarta.Next());

            foreach (var c in carta)
            {
                
                Console.WriteLine("***************");
                Console.WriteLine(" "+c);
                Console.WriteLine("***************");
                contCartas++;
                restCartas--;
                Console.WriteLine("Cartas sacadas: "+ contCartas);
                Console.WriteLine(("Cartas en la baraja: "+restCartas));
                Console.WriteLine("Presiona cualquier tecla para siguiente carta.");
                Console.ReadLine();

            }

            Console.WriteLine("Se termino la baraja");
            Console.WriteLine("Cantidad de cartas sacadas: "+ contCartas);
            Console.ReadLine();
        }
    }
}