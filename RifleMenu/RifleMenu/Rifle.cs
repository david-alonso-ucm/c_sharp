using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoRifle
{
    class Rifle
    {
        string Nombre;
        Recamara miRecamara;

        //si una función no definimos su constructor, el programa al ejecutarse crea un constructor por defecto
        //el constructor por defecto es un constructor que no recibe parámetros y que no tiene cuerpo de programa
        //ejemplo:
        /*  public Rifle() { }   */

        public Rifle() {
            int _maxBalas;
            Console.WriteLine("Creando nuevo rifle...");
            Console.Write("Inserta la capacidad de balas que tiene este rifle: ");
            while (!int.TryParse(Console.ReadLine(), out _maxBalas)) {
                Console.Write("Valor incorrecto, inserta de nuevo: ");
            }

            if (_maxBalas > 10)
            {
                Console.Write("Como máximo, un rifle puede tener 10 balas. Se establece a 10 la capacidad del rifle");
                _maxBalas = 10;
            }
            else if (_maxBalas <= 0) {
                Console.Write("Como mínimo, un rifle debe tener 1 bala. Se establece a 1 la capacidad del rifle");
                _maxBalas = 1;
            }

            miRecamara = new Recamara(_maxBalas);

        }

        public int MunicionEnRecamara() {

            int balas = miRecamara.NumBalas;

            miRecamara.NumBalas = 7;

            //int balas = miRecamara.getNumBalas(); //tengo que darle valor a esa variable
            //devuelve cuántas balas quedan en la recamara; 
            return balas;
        }
        public void RecargarRifle() {
            bool completo = false;
            
            while(!completo) {
                completo = miRecamara.Recargar();
            }
            Console.WriteLine("Tu arma ya esta recargada");
        }
        public void VaciarRecamara() {
            bool vacio = false;

            while (!vacio)
            {
                vacio = miRecamara.Sacar();
            }
            Console.WriteLine("Tu arma ya esta vacia");
        }
        public void Disparar() {
            //dispara una bala COMPLETADO
            if (miRecamara.Disparar()) //si existen balas
            {

                Console.WriteLine("PUM!!");

            }
            else //SI NO QUEDAN BALAS O SE ENCASQUILLA
            {
                Console.WriteLine("No se puede disparar!!");
            }
        }


        public void DispararRafaga() {
            //llama a la función disparar hasta que no queden balas en la recamára COMPLETADO

            do
            {
                Disparar();
            } while (miRecamara.NumBalas > 0);
            
        }
    }
}
