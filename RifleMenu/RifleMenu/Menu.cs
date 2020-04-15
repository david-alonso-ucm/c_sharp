using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoRifle
{
    class Menu
    {
        

        public int Seleccion()
        {
                    int seleccion;
                    Console.Clear();
           
                    Console.WriteLine("Bienvenido al viejo oeste. ¿Que quieres hacer?");
                    Console.WriteLine("1- Disparar");
                    Console.WriteLine("2- Recargar");
                    Console.WriteLine("3- Disparar ráfaga");
                    Console.WriteLine("4- Sacar bala de la recámara");
                    Console.WriteLine("5- Mostrar estadísticas");
                    Console.WriteLine("6- Salir");

                while (!int.TryParse(Console.ReadLine(), out seleccion) || seleccion < 1 || seleccion > 5) {
                    Console.Write("Valor incorrecto, inserte de nuevo: ");
                }

            

            return seleccion;
        }
        public void Accion(Rifle _Rifle) 
        {
            Rifle r = _Rifle;
            int seleccion; 
            
            
            while ( (seleccion = Seleccion())  !=   5) { 
                switch (seleccion)
                {
                    case 1: 
                        r.Disparar();//Disparar
                        break;
                    case 2:
                        r.RecargarRifle();
                        break;
                    case 3:
                        r.DispararRafaga();
                        break;
                    case 4:
                        r.VaciarRecamara();
                        break;

                }

                Console.ReadKey();

            }
           
        } 
    }
}
