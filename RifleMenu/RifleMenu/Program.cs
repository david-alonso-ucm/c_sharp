using System;

namespace ProyectoRifle
{
    class Program
    {
        static void Main(string[] args)
        {

            Rifle rifle1 = new Rifle();
            Rifle rifle2 = new Rifle();

            rifle1.Disparar();

            Menu menu = new Menu();
            menu.Accion(rifle1);

            menu.Accion(rifle2);



        }
    }
}
