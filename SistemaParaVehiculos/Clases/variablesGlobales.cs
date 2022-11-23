using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaParaVehiculos.Clases
{
    internal class variablesGlobales
    {
        public static string ruta{ get;} = new string("C:\\Users\\Melanni Tzul\\Desktop\\Curso .NET\\Net c#\\SistemaParaVehiculos\\vehiculos.txt");
        public static string rutaDueno { get;} = new string("C:\\Users\\Melanni Tzul\\Desktop\\Curso .NET\\Net c#\\SistemaParaVehiculos\\vehiculos\\Dueño.txt");

        public static string rutaModelo { get; } = new string("C:\\Users\\Melanni Tzul\\Desktop\\Curso .NET\\Net c#\\SistemaParaVehiculos\\Modelo.txt");


        //Rutas de formulario 1 vehiculo
        public static string rutaYear { get; } = new string("C:\\Users\\Melanni Tzul\\Desktop\\Curso .NET\\Net c#\\SistemaParaVehiculos\\archivosTxtVehiculos\\year.txt");
        public static string rutaCondicion { get; } = new string("C:\\Users\\Melanni Tzul\\Desktop\\Curso .NET\\Net c#\\SistemaParaVehiculos\\archivosTxtVehiculos\\Condicion.txt");
        public static string rutaMarca { get; } = new string("C:\\Users\\Melanni Tzul\\Desktop\\Curso .NET\\Net c#\\SistemaParaVehiculos\\archivosTxtVehiculos\\Marca.txt");
        public static string rutaModeloo { get; } = new string("C:\\Users\\Melanni Tzul\\Desktop\\Curso .NET\\Net c#\\SistemaParaVehiculos\\archivosTxtVehiculos\\Modelos.txt");

        public static string rutaEstado { get; } = new string("C:\\Users\\Melanni Tzul\\Desktop\\Curso .NET\\Net c#\\SistemaParaVehiculos\\archivostxtDueño//Estado.txt");
        public static string rutaGenero { get; } = new string("C:\\Users\\Melanni Tzul\\Desktop\\Curso .NET\\Net c#\\SistemaParaVehiculos\\archivostxtDueño\\Genero.txt");
    }



}
