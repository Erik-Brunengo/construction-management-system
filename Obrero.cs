using System;
using System.Collections;

namespace Proyecto_uno
{

    public class Obrero
    {


        //Atributo Protegido.
        protected string nya;
        protected int dni;
        protected int numeroLegajo;
        protected double sueldo;
        protected string cargo;
        private static int legajos = 0;

        //Constructor.
        public Obrero(){}
        
        public Obrero(string nya, int dni, double sueldo, string cargo)
        {
            this.nya = nya;
            this.dni = dni;
            this.numeroLegajo = ++legajos;
            this.sueldo = sueldo;
            this.cargo = cargo;
            
        }

        //Propiedades.
        public string Nya { get { return nya; } set { nya = value; } }
        public int Dni { get { return dni; } set { dni = value; } }
        public int NumeroLegajo { get { return numeroLegajo; } set { numeroLegajo = value; } }
        public double Sueldo { get { return sueldo; } set { sueldo = value; } }
        public string Cargo { get { return cargo; } set { cargo = value; } }
        

        //Métodos.

        public virtual void Mostrar()
        {
            
            Console.WriteLine("~");
            Console.WriteLine("-Nombre y apellido: "+ nya);
            Console.WriteLine(" Dni: "+dni);
            Console.WriteLine(" Numero Legajo: "+ numeroLegajo);
            Console.WriteLine(" Sueldo: "+ sueldo);
            Console.WriteLine(" Cargo: "+ cargo);
            
        }

    }

}
