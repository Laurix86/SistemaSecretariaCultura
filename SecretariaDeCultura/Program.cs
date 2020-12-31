
using System;
using System.Windows.Forms;
using ClasesSecretaria;

namespace SecretariaDeCultura
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        /// 
        public static ColeccionObras colObras;
        public static ColeccionArtistas colArtistas;
        public static ColeccionCentros colCentros;
        public static ColeccionPrestamos colPrestamos;
        public static string[] listaProvincias;
        

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            colObras = new ColeccionObras();
            colArtistas = new ColeccionArtistas();
            colCentros = new ColeccionCentros();
            colPrestamos = new ColeccionPrestamos();
            listaProvincias = new string[] {"CABA", "BUENOS AIRES", "TIERRA DEL FUEGO",
                "SANTA CRUZ", "CHUBUT", "RIO NEGRO", "NEUQUEN", "LA PAMPA", "MENDOZA", "SAN LUIS", "CORDOBA", "ENTRE RIOS", "SANTA FE",
            "SAN JUAN", "LA RIOJA", "CATAMARCA", "TUCUMAN", "SANTIAGO DEL ESTERO", "CORRIENTES", "MISIONES", "CHACO", "FORMOSA", "SALTA", "JUJUY" };
            Application.Run(new frmInicio());
        }
    }
}
