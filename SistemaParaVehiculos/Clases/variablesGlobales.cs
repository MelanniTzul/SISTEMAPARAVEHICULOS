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
        

        public static DataTable baseDatosGlobal { get; set; } = new DataTable();

        public static string ruta{ get;} = new string("C:\\Users\\Melanni Tzul\\Desktop\\Curso .NET\\Net c#\\SistemaParaVehiculos\\vehiculos.txt");
        public static string rutaDueno { get;} = new string("C:\\Users\\Melanni Tzul\\Desktop\\Curso .NET\\Net c#\\SistemaParaVehiculos\\vehiculos\\Dueño.txt");

        public static string rutaModelo { get; } = new string("C:\\Users\\Melanni Tzul\\Desktop\\Curso .NET\\Net c#\\SistemaParaVehiculos\\Modelo.txt");

    }



}
