﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Programa que muestra los datos personales
namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Estableciendo los colores de las letras y el fondo de la consola
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            //Se limpia la pantalla antes de mostar los datos
            Console.Clear();
            //Area de impresion de los datos
            Console.WriteLine("<<<<<<<<<<<<<*INFORMACION PERSONAL*>>>>>>>>>>>>>");
            Console.Write("\n    Nombre(s): Miguel Angel");
            Console.Write("\n    Apellido(s): Garcia Desena");
            Console.Write("\n    Apodo: Papotico");
            Console.Write("\n    Fecha de nacimiento: 03/09/1994");
            Console.Write("\n    Telefono: (809) 524-6232");
            Console.Write("\n    Movil: (809) 907-1662");
            Console.Write("\n    Pais: Republica Dominicana");
            Console.Write("\n    Ciudad: Santa Cruz");
            Console.Write("\n    Direcion: C/ Manolo Ortiz, #03, Los Block, Villa Central");
            Console.Write("\n    Lugar de trabajo: UCATEBA");
            Console.Write("\n    Sueldo: N/A");
            //Pausa durante la ejecucion del programa
            Console.ReadKey();
        }
    }
}
