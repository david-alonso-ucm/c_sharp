using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoRifle
{
    public class Recamara
    {
        //ENCAPSULAMIENTO
        //private: solo será accesible desde dentro de la propia clase
        //public: es accesible desde cualquier clase

        public int DisparosCorrectos { get; private set; }
        private int DisparosFallidos;
        private int DisparosRealizados; // DisparosCorrectos + DisparosFallidos
        public int NumBalas { 
                              get { return NumBalas; }
                              set { if (value < 0) NumBalas = 0;
                                    else if (value > 10) NumBalas = 10;
                                    else NumBalas = value;
                                   }
                            }



        private int MaxBalas;

        //MÉTODO CONSTRUCTOR
        //es un método que se llama igual que clase
        //es un método que siempre es public
        //es un método que no devulve valor de retorno, porque siempre retorna el objeto construido
        //este método se ejecuta cuando creamos un objeto de esa clase

        public Recamara(int _maxBalas) {
            //el constructor se utiliza para dejar en estado inicial a ese objeto
            DisparosCorrectos = 0;
            DisparosFallidos = 0;
            DisparosRealizados = 0;
            NumBalas = 0;
            MaxBalas = _maxBalas;
            Recargar();
        }

        public int getNumBalas() {
            return NumBalas;
        }

        public void setNumBalas(int n) {

            if (n > 0)
                NumBalas = n;
            else
                NumBalas = 0;
        }


        public bool Disparar() {

            bool disparo_exito = false;
            Random generador = new Random();

            int probabilidad = generador.Next(1, 11); //genera aleatorio entre 1 y 10

            //70% de los disparos son correctos, un 30% son fallidos
            if (probabilidad <= 3 || NumBalas == 0)
            {
                ++DisparosFallidos; 

            } else
            {
                 Sacar();
                ++DisparosCorrectos;
                disparo_exito = true;
             }

            ++DisparosRealizados; 

            return disparo_exito; 


        } // Disparar 1 bala

        public bool Recargar() {
            bool recarga_completa = false; 
            if (NumBalas < MaxBalas) {
                ++NumBalas;
            }

            if (NumBalas == MaxBalas)
                recarga_completa = true;

            return recarga_completa;
        } // Recargar 1 bala
        public bool Sacar() {
            bool vacio = false;
            if (NumBalas > 0)
            {
                --NumBalas;
            }

            if (NumBalas == 0)
                vacio = true;

            return vacio;
        }   // Sacar 1 bala de la recamara
       
    }
}
