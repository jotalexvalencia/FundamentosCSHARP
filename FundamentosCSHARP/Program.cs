﻿using System;
using FundamentosCSHARP.Models;
using System.Text.Json;
using System.Text.Json.Serialization;
namespace FundamentosCSHARP
{
    class Program
    {
        static void Main(string[] args)
        {
            //byte numero = 255; // 0 -255 no permite negativos
            //sbyte numero2 = -128; // 0 - 255 puedo poner números negativos se reduce desde -128 hasta 127
            //uint numero3 = 0; // positivos la u
            //byte? numero4 = null;//permite null

            //var persona = new { nombre = "Héctor", apellido = "De León", };
            //Console.WriteLine(persona.nombre);

            //// 2 clases objetos y constructores
            //Bebida bebida = new Bebida("Coca cola", 1000);
            //bebida.Beberse(500);
            //Console.WriteLine(bebida.Cantidad);

            //Cerveza cerveza = new Cerveza(500);
            //cerveza.Beberse(10); 

            // 3 arreglos y listas

            //int[] numeros = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 }; // datos por defecto

            //for (int i = 0; i < numeros.Length; i++)
            //{
            //    Console.WriteLine("iteración: "+i+" - "+numeros[i]);

            //} 

            //foreach (var numero in numeros)
            //{
            //    Console.WriteLine(numero);
            //}
            //Console.WriteLine("*********************************************************************************************");
            //List<int> lista = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 }; // lista
            //lista.Add(9);
            //lista.Add(0);
            //lista.Remove(2);

            //foreach (var numero in lista)
            //{
            //    Console.WriteLine("elemento: "+numero);
            //}
            ////Queue<int> queue = new Queue<int>(); // cola

            //List<Cerveza> cervezas = new List<Cerveza>() { new Cerveza(10, "Cerveza premium") };
            //cervezas.Add(new Cerveza(500));
            //Cerveza erdinger = new Cerveza(500, "Cervez de trigo");
            //cervezas.Add(erdinger);

            //foreach (var cerveza in cervezas)
            //{
            //    Console.WriteLine("cerveza: " + cerveza.Nombre  );
            //}

            // 4-interfaces

            //var bebidaAlcholoica = new Cerveza(100);
            //MostrarRecomendacion(bebidaAlcholoica);
            //List<string> hola = new List<string>();

            // 5-conexiones a base de datos, obtener informacion

            //CervezaBD cervezaBD = new CervezaBD();
            //var cervezas = cervezaBD.Get();

            //foreach (var cerveza in cervezas)
            //{
            //    Console.WriteLine(cerveza.Nombre);
            //}

            // 6-conexión a bd, crear, editar, eliminar

            CervezaBD cervezaBD = new CervezaBD();

            //// insertamos nueva cerveza // se crea un universo con las llaves
            //{
            //    Cerveza cerveza = new Cerveza(29, "Club Colombia");
            //    cerveza.Marca = "Bavaria";
            //    cerveza.Alcohol = 15;

            //    cervezaBD.Add(cerveza);
            //}
            // editar una cerveza
            //{
            //    Cerveza cerveza = new Cerveza(5, "Pale ale");
            //    cerveza.Marca = "Minerva";
            //    cerveza.Alcohol = 5;

            //    cervezaBD.Edit(cerveza, 5);
            //}
            // eliminar una cerveza
            ////{

            ////    cervezaBD.Delete(5);
            ////}


            ////// obtener todas las cervezas
            ////var cervezas = cervezaBD.Get();

            ////foreach (var cerveza in cervezas)
            ////{
            ////    Console.WriteLine(cerveza.Nombre);
            ////}
            ///

            // 07 Serialización de objetos y deserializacion de JSON

            // serializacion

            //Cerveza cerveza = new Cerveza(10, "Cerveza");
            //string miJson = JsonSerializer.Serialize(cerveza);
            //File.WriteAllText("objeto.txt", miJson);

            //deserializacion
            string miJson = File.ReadAllText("objeto.txt");
            Cerveza cerveza = JsonSerializer.Deserialize<Cerveza>(miJson);

        }

        //static void MostrarRecomendacion(IBebidaAlcoholica bebida)
        //{
        //    bebida.MaxRecomendado();
        //}
    }
}

