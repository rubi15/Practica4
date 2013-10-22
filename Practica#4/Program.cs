using System.IO;
using System;
using System.Collections;

namespace Practica_4
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			try{
				
			
				string URL;
				Console.WriteLine("Ingrese el URL del archivo que decea ver:");
				URL = Console.ReadLine();
				StreamReader read= new StreamReader(URL);
				
				string document= read.ReadLine();
				ArrayList lista= new ArrayList();
				
				while(document != null){
					persona Persona= new persona();
					
					string[] arr= document.Split(',');
					
					Persona.id=int.Parse(arr[0]);
					Persona.nombre= arr[1];
					Persona.domicilio=arr[2];
					Persona.telefono=arr[3];
					
					lista.Add(Persona);
					document=read.ReadLine();
				
				}read.Close();
				
				for(int i=0; i<=lista.Count-1; i++){
					
					persona Persona=(persona)lista[i];
					
					Console.WriteLine("id:" + Persona.id);
					Console.WriteLine("nombre " +Persona.nombre);
					Console.WriteLine("domocilio " +Persona.domicilio);
					Console.WriteLine("telefono "+Persona.telefono);
						
				}
			    
				Console.ReadKey();
			}catch(Exception e){			
				
				Console.WriteLine("\t* Error *\n No se encontro el Archivo.");
		
			Console.ReadKey(true);
			}
		}
	}
}