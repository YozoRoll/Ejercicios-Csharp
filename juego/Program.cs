// Librerias que nos permiten utilizar sintaxis basica //

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace juego
{
    internal class Program
    {

        static string[] palabrasSecretas = { "java", "phyton", "css", "html", "javascript" };
        static int vidas = 6;

        static void Main(string[] args)
        {

            string palabra = palabrasSecretas[palabraRandom.Next(palabrasSecretas.Length)]; // Determina la palabra aleatoria
            string mostrarPalabraSecreta = new string('_', palabra.Length); //Muestra la palabra aleatoria

            Console.WriteLine("Bienvenido al juego del ahorcado"); // Mensaje de bienvenida

            while (vidas > 0 && mostrarPalabraSecreta.Contains("_")) // Bucle principal del juego
            {
                Console.WriteLine("PalabraSecreta: " + mostrarPalabraSecreta); // Muestra la palabra hasta lo que el jugador tenga adivinado
                Console.WriteLine("Vidas restantes: " + vidas); // Muestra las vidas del jugador
                Console.WriteLine("Ingresa una letra: "); // Le pide al jugador ingresar una letra
                char letra = Console.ReadLine()[0];

                string PalabraTemporal = ""; // variable temporal que iremos llenando con las nuevas versiones
                bool acerto = false; // lo usaremos para saber si el jugar acerto o no

                for (int i = 0; i < palabra.Length; i++) 
                {
                    if (palabra[i] == letra)
                    {
                        PalabraTemporal += letra;
                        acerto = true;
                    }
                    else
                    {
                        PalabraTemporal += mostrarPalabraSecreta[i];
                    }
                 }

                if (!acerto)
                {
                    vidas--;
                    Console.WriteLine("Letra incorrecta. ");
                }
                else
                {
                    Console.WriteLine("Bien!");
                }

                mostrarPalabraSecreta = PalabraTemporal;

                }

                if (mostrarPalabraSecreta == palabra)
            {
                Console.WriteLine("Ganaste! La palabra era: " + palabra);
            }
                else
            {
                Console.WriteLine("Perdiste! La palabra era: " + palabra);
            }

            }

        
    
        // Metodo para elegir una palabra random //
        static Random palabraRandom = new Random();
        


    }
}
