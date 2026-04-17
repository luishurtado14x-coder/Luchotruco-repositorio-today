/*
 * Creado por SharpDevelop.
 * Usuario: usuario
 * Fecha: 17/4/2026
 * Hora: 2:32 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.IO;

namespace wetetwy
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			
		//directorio
		
		string rutaRaiz = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"Datos_iujo");
		string rutaReportes =  Path.Combine(rutaRaiz, "Reportes");
		Console.Write(rutaReportes);
		
		if (!Directory.Exists(rutaReportes)){
			
			Directory.CreateDirectory(rutaReportes);
			
			Console.WriteLine(" \n directorio creado");
					
		}
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}