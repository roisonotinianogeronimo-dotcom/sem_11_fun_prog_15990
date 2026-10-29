using System;
using System.IO;

namespace ejrcicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MI PRIMER ARCHIVO");
            
            EscribirArchivo();
            LeerArchivo();

            Console.ReadKey();
        }
        static public void EscribirArchivo()
        {
            //abre el archivo
            StreamWriter escritor = new StreamWriter("archivo.txt");

            //opera el acrhivo
            escritor.Write("HOLA MUNDO");

            //cerrar el archivo
            escritor.Close();
        }
        static public void LeerArchivo()
        {
            //abrir el archivo
            StreamReader lector = new StreamReader("archivo.txt");

            //opera el acrhivo
            string data = lector.ReadLine();
            Console.WriteLine(data);
           
            //cerrar el archivo
            lector.Close();
        }
    }
}
