using System;
using MySql.Data.MySqlClient;
	
namespace prac6
{
	
	class Menu
	{
		public static void Main (string[] args)
		{
			Console.WriteLine("M E N U");
			
			Console.WriteLine("1.- Ver\n2.- Agregar\n3.- Editar");
			Console.WriteLine("4.- Eliminar\n5.- Salir\n");
			Console.WriteLine("Introduce la opción deseada: ");
        	int opc = Convert.ToInt32(Console.ReadLine());
	    	//int opc = 5;
			
			
			switch(opc)
			{
			
			case 1:
			
				Console.WriteLine("VER");	
				
				
				Console.WriteLine("Dame el ID: ");
				String id=Console.ReadLine();
				
				Console.WriteLine("\nDame el código: ");
				String codigo=Console.ReadLine();
				
				Console.WriteLine("\nDame el Nombre: ");
				String nombre=Console.ReadLine();
				
				Profesor ver = new Profesor();
				ver.mostrarTodos();
				
				break;
					
			case 2:
				Console.WriteLine("AGREGAR");		
				
				Console.WriteLine("\nDame el Codigo: ");
			    String codigo1=Console.ReadLine();
			    
			    Console.WriteLine("\nDame el Nombre: ");
			    String nombre1=Console.ReadLine();
			   
				Profesor agregar = new Profesor();	
				agregar.insertarRegistroNuevo(codigo1, nombre1);
	
				break;
					
			case 3:
				Console.WriteLine("EDITAR");	
				
				Console.WriteLine("Dame el ID: ");
				String id2=Console.ReadLine();
				
				Console.WriteLine("\nDame el código: ");
				String codigo3=Console.ReadLine();
				
				Profesor editar = new Profesor();
				editar.editarCodigoRegistro(id2, codigo3);
					
				break;
					
			case 4:
				Console.WriteLine("ELIMINAR");	
				
				Console.WriteLine("Dame el ID: ");
				String id3=Console.ReadLine();
				
				Profesor elimina = new Profesor();	
				elimina.eliminarRegistroPorId(id3);
					
				break;
							
			case 5:
				
				Console.WriteLine("SALIR");
				
				break;
				
			}
			Console.Write("Press any key to continue . . . ");
					Console.ReadKey(true);
			
		}
	}
}