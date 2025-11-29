using System;
using System.Collections;

namespace Proyecto_uno
{
	class Program{
		
		public static void Main(string[] args){
			//CREACION DE LA EMPRESA
			EmpresaConstructora empresa1 = new EmpresaConstructora("Todo Terreno", "Argentina");
			
			CargarDatos(empresa1);

			//MENÚ.
			
			mostrarMenú();

			Console.Write("Ingrese una opcion: ");

			string opcion = Console.ReadLine().ToLower();
			Console.WriteLine("");
			while (opcion != "ñ"){
				
				switch (opcion){
						
						
					case "a"://CASO A:CONTRATAR UN OBRERO NUEVO A LA EMPRESA
						CaseA(empresa1);
						break;
						
						
					case "b"://CASO B:ELIMINAR OBRERO
						CaseB(empresa1);
						break;
						
					case "c"://CASO C: ASIGNAR OBRERO A GRUPO
						CaseC(empresa1);
						break;
						
					case "d"://CASO D: ELIMINAR OBRERO DE UN GRUPO
						CaseD(empresa1);
						break;
						
					case "e"://CASO E: CONTRATAR UN JEFE DE OBRA NUEVO A LA EMPRESA
						CaseE(empresa1);
						break;

					case "f":// CASO F: ELIMINAR UN JEFE DE OBRA
						CaseF(empresa1);
						break;
						
					case "g"://CASO G: ASIGNAR JEFE A UN GRUPO
						CaseG(empresa1);
						break;
						
					case "h"://CASO H: ELIMINAR JEFE DE UN GRUPO
						CaseH(empresa1);
						break;
						
					case "i"://CASO I: ASIGNAR JEFE A UNA OBRA
						CaseI(empresa1);
						break;
						
					case "j"://CASO J: ELIMINAR JEFE DE UNA OBRA
						CaseJ(empresa1);
						break;
						
					case "k"://CASO K: CREAR OBRA NUEVA
						CaseK(empresa1);
						break;
						
					case "l"://CASO L: MODIFICAR EL ESTADO DE AVANCE DE UNA OBRA.
						CaseL(empresa1);
						break;
						
					case "m":// CASO m: ASIGNAR GRUPO A OBRA
						CaseM(empresa1);
						break;
						
						
						
					case "n"://IMPRESIONES
						//SUBMENU DE IMPRESION
						MostrarSubMenuImpresion();
						
						Console.Write("Ingrese una opción: ");
						string opciong = Console.ReadLine().ToLower();
						
						Console.WriteLine("═════════════════════════════════════════════════════════════════════════════");
						Console.WriteLine();
						while (opciong != "k"){
							
							switch (opciong){
									
								case "a": //MOSTRAR LISTA DE OBREROS
									CaseASubMenu(empresa1);
									break;

								case "b"://MOSTRAR LISTA DE GRUPOS
									CaseBSubMenu(empresa1);
									break;

								case "c"://MOSTRAR LISTA JEFES DE OBRA
									CaseCSubMenu(empresa1);
									break;

								case "d"://MOSTRAR LISTA DE OBRAS EN EJECUCION
									CaseDSubMenu(empresa1);
									break;

								case "e"://MOSTRAR LISTA DE OBRAS FINALIZADAS
									CaseESubMenu(empresa1);
									break;

								case "f":// MOSTRAR LISTADO DE ESTADO DE AVANCE DE OBRAS SIN FINALIZAR
									CaseFSubMenu(empresa1);
									break;
									
								case "g"://MOSTRAR LOS INTEGRANTES DE UN GRUPO
									CaseGSubMenu(empresa1);
									break;
									
								case "h"://MOSTRAR OBRAS FINALIZADAS DE TIPO...
									CaseHSubMenu(empresa1);
									break;
									
								case "i"://MOSTRAR OBRAS EN EJECUCIÓN DE TIPO...
									CaseISubMenu(empresa1);
									break;
									
								case "j"://MOSTRAR OBRAS POR PRECIO DE FORMA ORDENADA
									CaseJSubMenu(empresa1);
									break;
									
								case "k":
									break;
								default:
									Console.WriteLine("═════════════════════════════════════════════════════════════════════════════");
									Console.WriteLine("Opción invalida.");
									Console.WriteLine("═════════════════════════════════════════════════════════════════════════════");
									Console.WriteLine("");
									break;
							}
							//SUBMENU DE IMPRESION.
							
							MostrarSubMenuImpresion();
							Console.Write("Ingrese una opción: ");
							opciong = Console.ReadLine();
							Console.WriteLine("═════════════════════════════════════════════════════════════════════════════");

						}
						break;

					case "ñ":
						break;

					default:
						Console.WriteLine("═════════════════════════════════════════════════════════════════════════════");
						Console.WriteLine("OPCION DEL MENÚ INVALIDA: Elija una opcion del menú correcta:");
						Console.WriteLine("═════════════════════════════════════════════════════════════════════════════");
						Console.WriteLine("");
						break;

				}

				mostrarMenú();

				Console.Write("Ingrese una opción: ");
				opcion = Console.ReadLine().ToLower();
				Console.WriteLine("");

			}
			
			

			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);

			
		}


		//MÉTODO DONDE MUESTA EL MENÚ.
		
		public static void mostrarMenú()
		{
			Console.WriteLine("╔═════════════════════════════════════════════════════════════════════════════╗");
			Console.WriteLine("║                               MENÚ PRINCIPAL                                ║");
			Console.WriteLine("║═════════════════════════════════════════════════════════════════════════════║");
			Console.WriteLine("a) Contratar un Obrero nuevo para la Empresa.");
			Console.WriteLine("b) Elminar un Obrero de la Empresa.");
			Console.WriteLine("c) Asignar Obrero a Grupo.");
			Console.WriteLine("d) Eliminar Obrero de un Grupo.");
			Console.WriteLine("e) Contratar a un Jefe de Obra nuevo a la Empresa.");
			Console.WriteLine("f) Dar de baja un Jefe de Obra.");
			Console.WriteLine("g) Asignar Jefe a un Grupo.");
			Console.WriteLine("h) Eliminar Jefe de un Grupo.");
			Console.WriteLine("i) Asignar Jefe a una Obra.");
			Console.WriteLine("j) Eliminar Jefe de una Obra.");
			Console.WriteLine("k) Crear Obra nueva.");
			Console.WriteLine("l) Modificar el Estado de Avance de una Obra.");
			Console.WriteLine("m) Asignar Grupo a Obra.");
			Console.WriteLine("n) Submenú de impresión.");
			Console.WriteLine("ñ) Salir.");

			Console.WriteLine ("═════════════════════════════════════════════════════════════════════════════");
		}

		//CARGAR DATOS
		public static void CargarDatos(EmpresaConstructora empresa1){
			

			empresa1.AgregarObraEnEjecucion(new Obra("Juan Pérez", 40587416, "construcción", 0, 7450500.00, null));
			empresa1.AgregarObraEnEjecucion(new Obra("Ada Wong", 36699001, "remodelación", 0, 200000.00, null));
			empresa1.AgregarObraEnEjecucion(new Obra("Cassandra Dimitrescu", 29677444, "ampliación", 0, 150000.00, null));
			empresa1.AgregarObraEnEjecucion(new Obra("Heisenberg", 15787454, "construcción", 0, 9000000.00, null));

			for (int a = 1; a < 9; a++)
			{
				empresa1.AgregarGrupos(new GrupoObreros(a,null, null));

			}

			empresa1.AgregarObrero(new Obrero("Pablo Rodriguez", 21856743, 300000, "capataz"));
			empresa1.AgregarObrero(new Obrero("Leon Kennedy", 24963754, 400000, "albañil"));
			empresa1.AgregarObrero(new Obrero("Carlos Oliveira", 32458967, 300000, "peón"));
			empresa1.AgregarObrero(new Obrero("Luis Serra", 35698412, 500000, "plomero"));
			empresa1.AgregarObrero(new Obrero("Chris Redfield", 23002445, 600000, "electricista"));

			((GrupoObreros)empresa1.ListaGrupoObreros[1]).AsignarObrero((Obrero)empresa1.ListaObrero[0]);
			((GrupoObreros)empresa1.ListaGrupoObreros [2]).AsignarObrero((Obrero)empresa1.ListaObrero [1]);
			((GrupoObreros)empresa1.ListaGrupoObreros[3]).AsignarObrero((Obrero)empresa1.ListaObrero[2]);
			((GrupoObreros)empresa1.ListaGrupoObreros[5]).AsignarObrero((Obrero)empresa1.ListaObrero[4]);
			((GrupoObreros)empresa1.ListaGrupoObreros[4]).AsignarObrero((Obrero)empresa1.ListaObrero[3]);

			empresa1.AgregarJefeDeObra(new JefeDeObra(200000, ((GrupoObreros)empresa1.ListaGrupoObreros[1]), "James Thunderland", 23669753, 1000000, "supervisor"));
			empresa1.AgregarJefeDeObra(new JefeDeObra(300000, ((GrupoObreros)empresa1.ListaGrupoObreros[3]), "Albert Wesker", 15963874, 1000000, "coordinador"));
			empresa1.AgregarJefeDeObra(new JefeDeObra(200000, ((GrupoObreros)empresa1.ListaGrupoObreros[4]), "Alcina Dimitrescu", 15258741, 2000000, "control de calidad"));

			((GrupoObreros)empresa1.ListaGrupoObreros[1]).AsignarJefeDeObra((JefeDeObra)empresa1.ListaJefesDeObra[0]);
			((GrupoObreros)empresa1.ListaGrupoObreros[3]).AsignarJefeDeObra((JefeDeObra)empresa1.ListaJefesDeObra[1]);
			((GrupoObreros)empresa1.ListaGrupoObreros[4]).AsignarJefeDeObra((JefeDeObra)empresa1.ListaJefesDeObra[2]);

		}
		
		//OPCIÓN A: MENÚ.
		public static void CaseA(EmpresaConstructora empresa){
			try{
				Console.WriteLine("═════════════════════════════════════════════════════════════════════════════");
				Console.WriteLine("CONTRATAR UN OBRERO NUEVO A LA EMPRESA");
				Console.WriteLine("═════════════════════════════════════════════════════════════════════════════");
				Console.WriteLine();
				
				Console.Write("¿Desea contratar un obrero?[s/n]: ");
				string sino= Console.ReadLine().ToLower();
				while (sino != "s" && sino != "n"){
					Console.Write("Por favor, ingrese [s] para confirmar o [n] para cancelar: ");
					sino= Console.ReadLine().ToLower();
				}
				if(sino=="n"){
					Console.WriteLine("Operación cancelada.");
					return;
				}
				do{
					
					Console.Write("Ingrese el nombre y apellido del nuevo obrero: ");
					string NYA = Console.ReadLine();

					Console.Write("Ingrese el DNI del obrero (8 dígitos): ");
					int DNI = int.Parse(Console.ReadLine());
					
					while (DNI < 10000000){
						Console.WriteLine("═════════════════════════════════════════════════════════════════════════════");
						Console.WriteLine("El DNI ingresado no es válido. Debe contener 8 dígitos. Intente nuevamente.");
						Console.WriteLine("═════════════════════════════════════════════════════════════════════════════");
						Console.Write("Ingrese el DNI del obrero: ");
						DNI = int.Parse(Console.ReadLine());

					}
					while (DNI > 10000000){
						Console.WriteLine("═════════════════════════════════════════════════════════════════════════════");
						Console.Write("El Dni ("+ DNI+ ") que ha ingresado es correcto?[s/n]: ");
						string opcsi= Console.ReadLine().ToLower();
						Console.WriteLine("═════════════════════════════════════════════════════════════════════════════");
						while (opcsi != "s" && opcsi != "n"){
							Console.Write("Por favor, ingrese [s] para confirmar o [n] para omitir la asignación a un grupo: ");
							opcsi= Console.ReadLine().ToLower();
						}
						if(opcsi == "s"){
							
							VerificacionDelDniObrero(empresa.ListaObrero,DNI);
							
							Console.Write("Ingrese el sueldo del obrero: ");
							double SUELDO = double.Parse(Console.ReadLine());

							while (SUELDO < 0){
								Console.WriteLine("═════════════════════════════════════════════════════════════════════════════");
								Console.WriteLine("El sueldo no puede ser negativo. Por favor, ingresa un valor mayor o igual a 0");
								Console.WriteLine("═════════════════════════════════════════════════════════════════════════════");
								Console.Write("Ingrese el sueldo del obrero: ");
								SUELDO = double.Parse(Console.ReadLine());

							}
							Console.WriteLine("");
							Console.WriteLine("Cargos disponibles para el obrero:");
							Console.WriteLine("═════════════════════════════════════════════════════════════════════════════");
							Console.WriteLine("-capataz");
							Console.WriteLine("-albañil");
							Console.WriteLine("-peón");
							Console.WriteLine("-plomero");
							Console.WriteLine("-electricista\n");
							Console.WriteLine("═════════════════════════════════════════════════════════════════════════════");
							Console.Write("Ingrese el cargo del obrero: ");
							string CARGO = Console.ReadLine().ToLower();

							while (CARGO != "capataz" && CARGO != "albañil" && CARGO != "peón" && CARGO != "peon" && CARGO != "plomero" && CARGO != "electricista"){
								
								Console.WriteLine("Cargo no disponible. Por favor, ingrese un cargo disponible.");
								Console.Write("Ingrese el cargo del obrero: ");
								CARGO = Console.ReadLine().ToLower();
							}
							//FUNCION PARA CONTRATAR OBRERO

							ContratarObrero(NYA, DNI, SUELDO, CARGO, empresa);
							Console.WriteLine("═════════════════════════════════════════════════════════════════════════════");
							Console.WriteLine ("¡Operación realizada con éxito!");
							Console.WriteLine ("El obrero " + NYA +" (DNI: "+ DNI +")"+ " ha sido contrado correctamente.");
							Console.WriteLine("═════════════════════════════════════════════════════════════════════════════");

							return;
						}
						
						Console.Write("Ingrese el DNI del Obrero correctamente: ");
						DNI = int.Parse(Console.ReadLine());
						
						
					}
				}
				while(sino != "n");
			}
			catch (OcurrioUnErrorException e){
				Console.WriteLine("ERROR: "+ e.motivo);
			}
			catch (OverflowException){
				Console.WriteLine ("Error: El número ingresado está fuera de los límites permitidos.");
			}
			catch (FormatException){
				Console.WriteLine ("Error: Entrada no válida.");
			}
			catch (Exception){
				Console.WriteLine ("Se produjo un error inesperado. Por favor, intente nuevamente.");
			}
			
		}
		public static void VerificacionDelDniObrero(ArrayList ListaObreros,int dniIngresado){
			foreach (Obrero elem in ListaObreros){
				if(elem.Dni == dniIngresado){
					throw new OcurrioUnErrorException("Este obrero ya se encuentra en la empresa.");
				}
				
			}
		}
		public static void ContratarObrero(string nya, int dni, double sueldo, string cargo, EmpresaConstructora empresa1){
			
			
			Obrero nuevoObrero = new Obrero(nya, dni, sueldo, cargo);
			//llamamos al metodo AgregarObrero que se encuentra en la clase EmpresaConstructora
			empresa1.AgregarObrero(nuevoObrero);
			
			Console.Write("¿Desea asignar al obrero a un grupo existente?[s/n]: ");
			string opciona = Console.ReadLine().ToLower();
			
			while (opciona != "s" && opciona != "n"){
				
				Console.Write("Por favor, ingrese [s] para confirmar o [n] para omitir la asignación a un grupo: ");
				
				opciona = Console.ReadLine().ToLower();
			}

			if (opciona == "s")
			{
				Console.WriteLine ("Grupos disponibles:");
				Console.WriteLine("═════════════════════════════════════════════════════════════════════════════");
				MostrarListaGruposConObra(empresa1);
				Console.WriteLine("═════════════════════════════════════════════════════════════════════════════");
				Console.Write("Ingrese el código del grupo al que desea asignar al obrero (presione [0] para cancelar: ");
				int CODIGO = int.Parse(Console.ReadLine());
				
				if (CODIGO != 0)
				{
					while (CODIGO < 0 || CODIGO > 8 )
					{
						Console.Write("Código ingresado incorrecto. Ingrese un código de un grupo (presione [0] para cancelar: ");
						
						CODIGO = int.Parse(Console.ReadLine());

					}
					foreach (GrupoObreros elem in empresa1.ListaGrupoObreros)
					{
						if (CODIGO == elem.NumeroGrupo)
						{
							elem.AsignarObrero(nuevoObrero);
						}
					}
				}
				
				
				
				if (CODIGO == 0)
					Console.WriteLine ("El obrero no ha sido asignado a ningún grupo.");
			}
			else
			{
				Console.WriteLine("═════════════════════════════════════════════════════════════════════════════");
				Console.WriteLine("No se ha asignado a ningún grupo.");
				Console.WriteLine("═════════════════════════════════════════════════════════════════════════════");
			}

			
		}
		public static void MostrarListaGruposConObra(EmpresaConstructora empresa1)
		{
			foreach (GrupoObreros elem in empresa1.ListaGrupoObreros)
			{
				elem.Mostrar();
				ImprimirObrasAsignadas(elem);
				
			}
			
		}
		public static void ImprimirObrasAsignadas(GrupoObreros grupito){
			Console.WriteLine("Obras Asignadas al Grupo: ");
			if(grupito.CantidadObras ==0){
				Console.WriteLine("No se encuentran obras asignadas a este grupo.");
			}
			if(grupito.CantidadObras >0){
				foreach(Obra elem in grupito.ListaDeObras){
					if(elem != null){
						elem.Mostrar();
					}
				}
			}
		}
		
		//OPCIÓN B: MENÚ.
		public static void CaseB(EmpresaConstructora empresa){
			try
			{
				Console.WriteLine("═════════════════════════════════════════════════════════════════════════════");
				Console.WriteLine("ELIMINAR UN OBRERO DE LA EMPRESA");
				Console.WriteLine("═════════════════════════════════════════════════════════════════════════════");

				Console.Write("¿Desea eliminar un Obrero de la empresa?[s/n]: ");
				string sino2= Console.ReadLine().ToLower();
				while (sino2 != "s" && sino2 != "n"){
					Console.Write("Por favor, ingrese [s] para confirmar o [n] para cancelar: ");
					sino2= Console.ReadLine().ToLower();
				}
				if(sino2=="n"){
					Console.WriteLine("Operación cancelada.");
					return;
				}
				do{
					MostrarListaObrerosNombreLegajo(empresa.ListaObrero);
					
					Console.WriteLine();
					int legajoObrero;
					do{
						Console.Write("Ingrese el número de legajo del obrero que desea eliminar(para salir presione [0]): ");
						legajoObrero = int.Parse(Console.ReadLine());
						if( legajoObrero !=0){
							Obrero obrero = empresa.BuscarObrero(legajoObrero);

							if (obrero != null){
								
								string confirmar;
								Console.Write("Seguro que quiere eliminar a: " + obrero.Nya + "(" + obrero.NumeroLegajo+ ")[s/n]:");
								confirmar = Console.ReadLine().ToLower();
								while (confirmar != "s" && confirmar != "n")
								{
									Console.Write("Por favor Ingrese [s] para confirmar o [n] para cancelar:");
									confirmar = Console.ReadLine().ToLower();
								}
								if (confirmar == "s")
								{
									JefeDeObra jefe = new JefeDeObra();
									
									Console.WriteLine("═════════════════════════════════════════════════════════════════════════════");
									Console.WriteLine("El obrero: "+ obrero.Nya+ "("+ obrero.NumeroLegajo+") fue eliminado con exito.");
									Console.WriteLine("═════════════════════════════════════════════════════════════════════════════");
									
									EliminarObreroEmpresa(legajoObrero,empresa);
									return;
								}
							}
							else
							{
								Console.WriteLine("═════════════════════════════════════════════════════════════════════════════");
								Console.WriteLine("El legajo " + legajoObrero + " no esta asignado a ningún obrero.");
								Console.WriteLine("═════════════════════════════════════════════════════════════════════════════");
							}
							
						}
						else
							Console.Write ("No se ha eliminado ningún obrero. Regresando al menú principal...");
						
					} while (legajoObrero != 0);

					Console.WriteLine("");
					
				}while(sino2!="n");
				
			}
			catch (OverflowException)
			{
				Console.WriteLine ("ERROR: El número ingresado está fuera de los límites permitidos. Por favor, introduzca un número válido.");
			}
			catch (FormatException)
			{
				Console.WriteLine ("ERROR: Entrada no válida. Por favor, ingresa un número entero válido.");
				
			}
			catch (Exception)
			{
				Console.WriteLine ("Se produjo un error inesperado. Por favor, intente nuevamente.");
			}
			
			
		}
		public static void EliminarObreroEmpresa(int legajoObrero, EmpresaConstructora empresa)
		{
			Obrero obrero = empresa.BuscarObrero (legajoObrero);
			foreach (GrupoObreros grupo in empresa.ListaGrupoObreros)
			{
				
				grupo.eliminarObrero(obrero);
				
				
			}
			JefeDeObra jefe = empresa.BuscarJefe (legajoObrero);
			
			if (jefe != null)
			{
				empresa.EliminarJefeEmpresa (jefe);
				
				
				
				foreach (GrupoObreros grupo in empresa.ListaGrupoObreros)
				{
					
					if (grupo.JefeObra == jefe)
					{
						
						grupo.EliminarJefe(jefe);
						break;
					}
				}
				
				foreach (Obra obra in empresa.ListaObrasEnEjecucion)
				{
					if (obra.JefeObra == jefe)
					{
						obra.JefeObra = null;
					}
				}
			}
			empresa.EliminarObrero(obrero);
		}
		public static void MostrarListaObrerosNombreLegajo(ArrayList listaObrero){
			Console.WriteLine("OBREROS/JEFE :[NOMBRE, APELLIDO Y NÚMERO DE LEGAJO]\n");

			foreach (Obrero obrero in listaObrero){
				if (obrero is JefeDeObra){
					
					Console.WriteLine("-Jefe de obra: " + obrero.Nya + ", " + obrero.NumeroLegajo);
				}
				else{
					Console.WriteLine("-Obrero: " + obrero.Nya + ", " + obrero.NumeroLegajo);
				}
			}
		}
		
		//OPCIÓN C: MENÚ.
		public static void CaseC(EmpresaConstructora empresa){
			
			Console.WriteLine("═════════════════════════════════════════════════════════════════════════════");
			Console.WriteLine( " ASIGNAR OBRERO A GRUPO");
			Console.WriteLine("═════════════════════════════════════════════════════════════════════════════");
			try{
				Console.Write("¿Desea Asignar un Obrero al Grupo?[s/n]: ");
				string sino2= Console.ReadLine().ToLower();
				while (sino2 != "s" && sino2 != "n"){
					Console.Write("Por favor, ingrese [s] para confirmar o [n] para cancelar: ");
					sino2= Console.ReadLine().ToLower();
				}
				if(sino2=="n"){
					Console.WriteLine("Operación cancelada.");
					return;
				}
				if (sino2 == "s")
				{
					Console.WriteLine ("Obreros sin grupo asignado: ");
					Console.WriteLine("═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═");
					
					
					MostrarObreroSinAsignar(empresa.ListaObrero, empresa.ListaGrupoObreros);
					
					Console.WriteLine("═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═");
					Console.Write ("Ingrese el número de legajo del obrero que desea asignar(presione [0] para salir): ");
					int legajo = int.Parse(Console.ReadLine ());
					
					if (legajo != 0){
						
						Obrero legajoEncontrado = LegajoObreroSinAsignar(legajo, empresa.ListaObrero,empresa.ListaGrupoObreros);
						
						while (legajoEncontrado == null && legajo !=0){
							
							Console.WriteLine ("El legajo (" + legajo + ") no está asignado a ningún obrero.");
							Console.Write("Ingrese numero de legajo del obrero que desea asignar (presione [0] para salir): ");
							legajo = int.Parse(Console.ReadLine ());
							
							legajoEncontrado =LegajoObreroSinAsignar(legajo, empresa.ListaObrero,empresa.ListaGrupoObreros);
							
						}
						if (legajo != 0){
							Console.WriteLine ("Grupos de obreros.");
							Console.WriteLine("═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═");
							
							MostrarListaGruposObrerosCodigo(empresa.ListaGrupoObreros);
							
							Console.WriteLine("═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═");
							Console.Write ("Ingrese el numero del grupo al que desea asignarlo: ");
							int numeroGrupo = int.Parse (Console.ReadLine());
							
							if (numeroGrupo != 0){
								while (numeroGrupo < 0 || numeroGrupo > 8 ){
									
									Console.Write("Código ingresado incorrecto. Ingrese un código de un grupo (presione [0] para cancelar): ");
									
									numeroGrupo = int.Parse(Console.ReadLine());

								}
								if (numeroGrupo != 0){
									
									AsignarObreroAlGrupo(legajo, numeroGrupo, empresa.ListaObrero,empresa.ListaGrupoObreros);
									
									Console.WriteLine ("¡El obrero " + legajoEncontrado.Nya + " asignado al grupo ("+numeroGrupo + ") con exito!");
								}
								else{
									
									Console.WriteLine ("El obrero no se ha asignado a ningún grupo.");
								}
								
							}
							else{
								
								Console.WriteLine ("El obrero no se ha asignado a ningún grupo.");
							}
							
						}
						else
						{
							Console.WriteLine ("Ningún obrero se ha asignado a ningún grupo de obreros.");
						}
					}
					else
					{
						Console.WriteLine ("Ningun obrero se ha asignado a ningún grupo de obreros.");
					}
					
				}
			}
			catch (OverflowException)
			{
				Console.WriteLine ("ERROR: El número ingresado está fuera de los límites permitidos. Por favor, introduzca un número válido.");
			}
			catch (FormatException)
			{
				Console.WriteLine ("ERROR: Entrada no válida. Por favor, ingresa un número entero válido.");
				
			}
			catch (Exception)
			{
				Console.WriteLine ("Se produjo un error inesperado. Por favor, intente nuevamente.");
			}
		}
		public static void MostrarObreroSinAsignar ( ArrayList listaObreros, ArrayList listaGrupos )
		{
			bool encontrado = true;
			Obrero obreroAsignado = null;
			foreach (Obrero obrero in listaObreros)
			{
				encontrado = true;
				
				foreach (GrupoObreros grupo in listaGrupos)
				{
					obreroAsignado = (grupo.BuscarObrero (obrero.NumeroLegajo));
					
					if (obreroAsignado != null)
					{
						encontrado = false;
						break;
					}
				}
				
				if (encontrado)
				{
					if (obrero is JefeDeObra)
					{
						
					}
					else
						obrero.Mostrar();
					
				}
				
			}
		}
		public static Obrero LegajoObreroSinAsignar (int legajo, ArrayList listaObrero, ArrayList listaGrupo)
		{
			bool encontrado = true;
			Obrero obreroAsignado = null;
			foreach (Obrero obrero in listaObrero)
			{
				encontrado = true;
				
				foreach (GrupoObreros grupo in listaGrupo)
				{
					obreroAsignado = (grupo.BuscarObrero (obrero.NumeroLegajo));
					
					if (obreroAsignado != null)
					{
						encontrado = false;
						break;
					}
				}
				
				if (encontrado)
				{
					if (obrero is JefeDeObra)
					{
						
					}
					else
					{
						if (obrero.NumeroLegajo == legajo)
							return obrero;
					}
					
					
				}
				
			}
			
			return null;
		}
		public static void MostrarListaGruposObrerosCodigo(ArrayList listaGrupo)
		{
			foreach (GrupoObreros grupo in listaGrupo)
			{
				Console.WriteLine("-Grupo: " + grupo.NumeroGrupo);
			}
		}
		public static void AsignarObreroAlGrupo (int legajo, int numeroGrupo, ArrayList listaObrero, ArrayList listaGrupo)
		{
			foreach (Obrero obrero in listaObrero)
			{
				if (obrero.NumeroLegajo == legajo)
				{
					((GrupoObreros)listaGrupo[numeroGrupo-1]).AsignarObrero (obrero);
					
				}
			}
		}
		
		//OPCIÓN D: MENÚ.
		public static void CaseD(EmpresaConstructora empresa){
			Console.WriteLine("═════════════════════════════════════════════════════════════════════════════");
			Console.WriteLine("ELIMINAR OBRERO DE UN GRUPO");
			Console.WriteLine("═════════════════════════════════════════════════════════════════════════════");
			Console.WriteLine("");
			try{
				Console.Write("¿Desea Eliminar un Obrero de un Grupo?[s/n]: ");
				string sino4= Console.ReadLine().ToLower();
				while (sino4 != "s" && sino4 != "n"){
					Console.Write("Por favor, ingrese [s] para confirmar o [n] para cancelar: ");
					sino4= Console.ReadLine().ToLower();
				}
				if(sino4=="n"){
					Console.WriteLine("Operación cancelada.");
					return;
				}
				if ( sino4 == "s")
				{
					
					MostrarListaGruposObrerosCodigo(empresa.ListaGrupoObreros);
					
					Console.WriteLine();
					Console.Write("Ingrese el código del grupo al que quiera eliminar los obreros: ");
					int numerogrupo = int.Parse(Console.ReadLine());
					
					GrupoObreros grupito = empresa.BuscarGrupo(numerogrupo);
					
					if (grupito == null){
						
						Console.WriteLine("Grupo no encontrado.");
						return;
					}
					
					MostrarListaIntegrantesObra(numerogrupo,empresa.ListaGrupoObreros);
					
					Console.WriteLine();
					int legajoObreroxd;
					do{
						Console.Write("Ingrese el legajo del obrero para sacarlo del grupo seleccionado ([0] para cancelar): ");
						legajoObreroxd = int.Parse(Console.ReadLine());
						
						if(legajoObreroxd ==0){
							Console.WriteLine("Se canceló la eliminacion del Obrero.");
							break;
						}
						
						Obrero obreroxd = grupito.BuscarObrero(legajoObreroxd);
						if(obreroxd== null){
							Console.WriteLine("Obrero no encontrado.");
							continue;
						}
						Console.Write("¿Está seguro que quiere eliminar al integrante? "+ obreroxd.Nya+" (Legajo: " + obreroxd.NumeroLegajo + ")[s/n]: ");
						
						string ss=Console.ReadLine().ToLower();
						while (ss != "s" && ss != "n"){
							
							Console.Write("Por favor, ingrese [s] para confirmar o [n] para omitir la asignación a un grupo: ");
							
							ss= Console.ReadLine().ToLower();
						}
						if(ss == "s"){
							grupito.EliminarObrero(obreroxd);
							return;
							
						}
						
						else{
							Console.WriteLine("No se ha eliminado el obrero del grupo.");
						}
						
					}while(legajoObreroxd !=0);
				}
			}
			catch (FormatException){
				Console.WriteLine ("Error: Entrada no válida.");
			}
			catch (Exception)
			{
				Console.WriteLine ("Se produjo un error inesperado. Por favor, intente nuevamente.");
			}
			
		}
		public static void MostrarListaIntegrantesObra(int codigo,ArrayList ListaGrupo)
		{
			foreach (GrupoObreros elem in ListaGrupo)
			{

				if (codigo == elem.NumeroGrupo)
				{
					if (elem.JefeObra != null)
					{
						elem.Mostrar();
						
					}
					else
					{
						Console.WriteLine("Sin jefe de obra asignado.");
					}

					Console.WriteLine("");

					if (elem.ListaIntregrantes.Count > 0)
					{
						Console.WriteLine("Integrantes: ");
						
						elem.ImprimirIntegrantes();
					}
					else
					{
						Console.WriteLine("Sin obreros asignados.");
					}
				}

			}
		}
		
		//OPCIÓN E: MENÚ.
		public static void CaseE(EmpresaConstructora empresa){
			try{
				Console.WriteLine("═════════════════════════════════════════════════════════════════════════════");
				Console.WriteLine("CONTRATAR UN JEFE DE OBRA NUEVO A LA EMPRESA");
				Console.WriteLine("═════════════════════════════════════════════════════════════════════════════");
				Console.WriteLine("");
				Console.Write("¿Desea contratar un Jefe de Obra a la Empresa?[s/n]: ");
				string sinoe= Console.ReadLine().ToLower();
				while (sinoe != "s" && sinoe != "n"){
					Console.Write("Por favor, ingrese [s] para confirmar o [n] para cancelar: ");
					sinoe= Console.ReadLine().ToLower();
				}
				if(sinoe=="n")
				{
					Console.WriteLine("Operación cancelada.");
					return;
				}
				if (sinoe == "s")
				{
					Console.Write("Ingrese nombre y apellido del jefe de obra: ");
					string NYAJEFE = Console.ReadLine();

					Console.Write("Ingrese el DNI del jefe de obra (8 dígitos): ");
					int DNIJEFE = int.Parse(Console.ReadLine());

					while (DNIJEFE < 10000000)
					{

						Console.WriteLine("El DNI ingresado no es válido. Debe contener 8 dígitos. Intente nuevamente.");
						Console.Write("Ingrese el DNI del jefe de obra: ");
						DNIJEFE = int.Parse(Console.ReadLine());

					}
					while (DNIJEFE > 10000000){
						Console.WriteLine("═════════════════════════════════════════════════════════════════════════════");
						Console.Write("El Dni ("+ DNIJEFE+ ") que ha ingresado es correcto?(s/n): ");
						string opcsi= Console.ReadLine().ToLower();
						Console.WriteLine("═════════════════════════════════════════════════════════════════════════════");
						
						if(opcsi == "s"){
							
							VerificacionDelDniObrero(empresa.ListaJefesDeObra,DNIJEFE);
							
							Console.Write("Ingrese el sueldo del jefe de obra: ");
							double SUELDOJEFE = double.Parse(Console.ReadLine());

							while (SUELDOJEFE < 0){
								Console.WriteLine("El sueldo no puede ser negativo. Por favor, ingresa un valor mayor o igual a 0");
								Console.Write("Ingrese el sueldo del jefe de obra: ");
								SUELDOJEFE = double.Parse(Console.ReadLine());
							}
							
							Console.WriteLine("");
							Console.WriteLine("Cargos disponibles para el jefe de obra:");
							Console.WriteLine("-capataz principal");
							Console.WriteLine("-supervisor de obra");
							Console.WriteLine("-seguridad e higiene");
							Console.WriteLine("-lider de albañilería");
							Console.WriteLine("-jefe de demolición\n");
							Console.WriteLine("");
							Console.Write("Ingrese cargo del jefe de obra: ");
							string CARGOJEFE = Console.ReadLine().ToLower();

							while (CARGOJEFE != "capataz principal" && CARGOJEFE != "supervisor de obra" && CARGOJEFE != "seguridad e higiene" && CARGOJEFE != "lider de albañilería" && CARGOJEFE !="lider de albañileria" && CARGOJEFE != "jefe de demolición" && CARGOJEFE != "jefe de demolicion")
							{
								Console.WriteLine("Cargo no disponible. Por favor, ingrese un cargo disponible.");
								Console.Write("Ingrese el cargo del jefe de obra: ");
								CARGOJEFE = Console.ReadLine().ToLower();
							}

							Console.Write("Ingrese la bonificación del jefe de obra: ");
							double BONIFICACION = double.Parse(Console.ReadLine());
							while (BONIFICACION < 0)
							{
								Console.WriteLine("La bonificación no puede ser negativo. Por favor, ingresa un valor mayor o igual a 0");
								Console.Write("Ingrese la bonificación del jefe de obra: ");
								BONIFICACION = double.Parse(Console.ReadLine());
							}

							//FUNCION PARA CONTRATAR UN JEFE DE OBRA
							
							ContratarJefeDeObra(NYAJEFE, DNIJEFE, SUELDOJEFE, CARGOJEFE, BONIFICACION, empresa);
							Console.WriteLine("");
							Console.WriteLine("═════════════════════════════════════════════════════════════════════════════");
							Console.WriteLine ("¡Operación realizada con éxito!");
							Console.WriteLine ("El jefe " + NYAJEFE +" (DNI: "+ DNIJEFE +")"+ " ha sido contrado correctamente.");
							Console.WriteLine("═════════════════════════════════════════════════════════════════════════════");
							return;
							
						}
						Console.Write("Ingrese el DNI del jefe correctamente: ");
						DNIJEFE = int.Parse(Console.ReadLine());
						
					}
				}
			}
			catch (OcurrioUnErrorException e)
			{
				Console.WriteLine("OCURRIO UN ERROR: " + e.motivo);
				Console.WriteLine("");
			}
			catch (FormatException)
			{
				Console.WriteLine ("Error: Entrada no válida. Por favor, ingresa un número entero válido.");
				
			}
			catch (Exception)
			{
				Console.WriteLine ("Ha ocurrido un error inesperado.");
			}
		}
		public static void ContratarJefeDeObra(string nya, int dni, double sueldo, string cargo, double bonificacion, EmpresaConstructora empresa1){
			

			JefeDeObra nuevoJefeDeObra = new JefeDeObra(bonificacion, null, nya, dni, sueldo, cargo);
			empresa1.AgregarJefeDeObra(nuevoJefeDeObra);
			Console.Write ("¿Desea asignar al jefe de obra a un grupo de obreros? (Ingrese [s/n]): ");
			
			string opcionc = Console.ReadLine().ToLower();
			while (opcionc != "s" && opcionc != "n")
			{
				Console.Write("Por favor, ingrese [s] para confirmar o [n] para omitir la asignación: ");
				opcionc = Console.ReadLine().ToLower();

			}
			if (opcionc == "s")
			{
				Console.WriteLine("Códigos de grupos sin jefe de obra: ");
				
				MostrarListaGrupoObrerosLibres(empresa1.ListaGrupoObreros);
				
				Console.WriteLine();
				Console.Write("Ingrese el código del grupo sin jefe de obra al que desea asignarlo (presione [0] para cancelar): ");
				int cod = int.Parse(Console.ReadLine());
				
				bool codigoGrupo = BuscarGrupoSinJefeAsignado (cod,empresa1.ListaGrupoObreros);
				
				
				while (!codigoGrupo && cod != 0)
				{
					Console.Write("Código ingresado incorrecto. Ingrese un código de un grupo sin jefe de obra :(presione [0] para cancelar) ");
					cod = int.Parse(Console.ReadLine());
					
					codigoGrupo =BuscarGrupoSinJefeAsignado (cod,empresa1.ListaGrupoObreros);
					
				}
				
				if (cod ==0)
					Console.WriteLine ("El jefe de obra no se ha asignado a ningún grupo.");
				
				foreach (GrupoObreros elem in empresa1.ListaGrupoObreros)
				{
					if (cod == elem.NumeroGrupo)
					{
						elem.AsignarJefeDeObra(nuevoJefeDeObra);
						
					}
				}
				
			}
			else
			{
				Console.WriteLine("No se ha asignado a ningún grupo.");
			}

			
		}
		public static void MostrarListaGrupoObrerosLibres(ArrayList ListaGrupo)
		{
			foreach (GrupoObreros elem in ListaGrupo)
			{
				if (elem.JefeObra == null)
				{
					Console.WriteLine("-Grupo: " + elem.NumeroGrupo);
				}
			}
		}
		public static bool BuscarGrupoSinJefeAsignado (int codigo,ArrayList listaGrupoObre)
		{
			foreach (GrupoObreros grupo in listaGrupoObre)
			{
				if (grupo.JefeObra == null && grupo.NumeroGrupo == codigo)
				{
					return true;
				}
			}
			return false;
		}
		
		//OPCIÓN F: MENÚ.
		public static void CaseF(EmpresaConstructora empresa){
			Console.WriteLine("═════════════════════════════════════════════════════════════════════════════");
			Console.WriteLine("ELIMINAR UN JEFE DE OBRA");
			Console.WriteLine("═════════════════════════════════════════════════════════════════════════════");
			try
			{
				Console.Write("¿Desea Eliminar un Jefe de Obra?[s/n]: ");
				string sinof= Console.ReadLine().ToLower();
				while (sinof != "s" && sinof != "n"){
					Console.Write("Por favor, ingrese [s] para confirmar o [n] para cancelar: ");
					sinof= Console.ReadLine().ToLower();
				}
				if(sinof=="n"){
					Console.WriteLine("Operación cancelada.");
					return;
				}
				if (sinof == "s")
				{
					Console.WriteLine("");
					
					MostrarJefesDeObraNombreLegajo(empresa.ListaJefesDeObra);
					
					Console.WriteLine("");

					int legajoJefe;
					
					
					do
					{
						Console.Write("Ingrese el número de legajo del jefe de obra que desea eliminar(presione [0] para salir): ");
						
						legajoJefe = int.Parse(Console.ReadLine());
						if (legajoJefe != 0){
							
							JefeDeObra jefe = empresa.BuscarJefe(legajoJefe);


							if (jefe != null){
								
								string confirmar;
								Console.Write("Seguro que quiere eliminar a: " + jefe.Nya + " (Legajo: "+jefe.NumeroLegajo+ ") de forma permanente?[s/n]: " );
								
								confirmar = Console.ReadLine().ToLower();
								while (confirmar != "s" && confirmar != "n")
								{
									Console.Write("Ingrese [s] para confirmar o [n] para cancalar: ");
									
									confirmar = Console.ReadLine().ToLower();
								}

								if (confirmar == "s")
								{
									EliminarObreroEmpresa(legajoJefe,empresa);
									
									Console.WriteLine("El Jefe de obra "+jefe.Nya +" (Legajo: "+ jefe.NumeroLegajo+ ") fue eliminado con exito.");
									
									break;


								}
							}
							else
							{
								Console.WriteLine("Legajo ingresado no asignado a ningún jefe de obra.");
							}
						}

					} while (legajoJefe != 0);
				}
			}
			catch (OverflowException)
			{
				Console.WriteLine ("Error: El número ingresado está fuera de los límites permitidos. Por favor, introduzca un número válido.");
			}
			catch (FormatException)
			{
				Console.WriteLine ("Error: Entrada no válida. Por favor, ingresa un número entero válido.");
				
			}
			catch (Exception)
			{
				Console.WriteLine ("Se produjo un error inesperado. Por favor, intente nuevamente.");
			}
			
		}
		public static void MostrarJefesDeObraNombreLegajo(ArrayList listaJefes)
		{
			Console.WriteLine("_");
			Console.WriteLine("JEFES DE OBRA: ");
			Console.WriteLine("JEFE: [NOMBRE, APELLIDO Y N° LEGAJO]\n");
			foreach (JefeDeObra elem in listaJefes)
			{
				Console.WriteLine("-" + elem.Nya + ", " + elem.NumeroLegajo);
			}

			Console.WriteLine("_");
		}
		
		//OPCIÓN G: MENÚ.
		public static void CaseG(EmpresaConstructora empresa){
			Console.WriteLine("═════════════════════════════════════════════════════════════════════════════");
			Console.WriteLine("ASIGNAR JEFE A UN GRUPO");
			Console.WriteLine("═════════════════════════════════════════════════════════════════════════════");
			
			try
			{
				Console.Write("¿Desea Asignar un Jefe a un Grupo?[s/n]: ");
				string sinog= Console.ReadLine().ToLower();
				while (sinog != "s" && sinog != "n"){
					Console.Write("Por favor, ingrese [s] para confirmar o [n] para cancelar: ");
					sinog= Console.ReadLine().ToLower();
				}
				if(sinog=="n"){
					Console.WriteLine("Operación cancelada.");
					return;
				}
				if (sinog == "s")
				{
					Console.WriteLine ("Jefes sin un grupo asignado.");
					
					Console.WriteLine("═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═");
					
					MostrarJefeSinAsignarAGgrupo(empresa.ListaJefesDeObra,empresa.ListaGrupoObreros);
					
					
					Console.WriteLine("═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═");
					Console.Write("Ingrese el legajo del jefe de obra que desea asignar a un grupo de obreros (presione[0] para salir): ");
					int legajoJefeSinAsignar = int.Parse (Console.ReadLine ());
					
					if (legajoJefeSinAsignar != 0 ){
						
						JefeDeObra jefeEncontrado = LegajoJefeDeObraSinAsignar(legajoJefeSinAsignar,empresa.ListaJefesDeObra,empresa.ListaGrupoObreros);
						
						while (jefeEncontrado == null && legajoJefeSinAsignar != 0)
						{
							Console.WriteLine ("El legajo (" + legajoJefeSinAsignar + ") no está asignado a ningún jefe de obra.");
							Console.Write("Ingrese numero de legajo del jefe de obra que desea asginar (presione [0] para salir): ");
							legajoJefeSinAsignar = int.Parse(Console.ReadLine ());
							
							jefeEncontrado = LegajoJefeDeObraSinAsignar(legajoJefeSinAsignar,empresa.ListaJefesDeObra,empresa.ListaGrupoObreros);
							
						}
						
						if (legajoJefeSinAsignar != 0)
						{
							Console.WriteLine ("Grupos de obreros sin jefe asignado.");
							Console.WriteLine("═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═");
							
							MostrarGrupoObrerosSinJefeAsignado(empresa.ListaGrupoObreros);
							
							Console.WriteLine("═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═");
							
							Console.Write ("Ingrese el número de grupo al que desea asignar al jefe de obra (presione[0] para salir):  ");
							int numeroGrupo = int.Parse(Console.ReadLine ());
							
							if (numeroGrupo != 0)
							{
								GrupoObreros grupoEncontrado = BuscarNumeroGrupoObreros (numeroGrupo,empresa.ListaGrupoObreros);
								
								while (grupoEncontrado == null && numeroGrupo != 0){
									
									Console.WriteLine ("Número de grupo no asignado a ningún grupo.");
									Console.Write ("Ingrese el número de grupo al que desea asignar al jefe de obra (presione[0] para salir): ");
									numeroGrupo = int.Parse(Console.ReadLine ());
									
									grupoEncontrado = BuscarNumeroGrupoObreros (numeroGrupo,empresa.ListaGrupoObreros);
									
								}
								
								if (numeroGrupo != 0)
								{
									
									AsignarJefeAgrupo(jefeEncontrado,numeroGrupo,empresa.ListaGrupoObreros);
									
									Console.WriteLine ("Jefe " + jefeEncontrado.Nya + " asignado al grupo (" + numeroGrupo + ") con exito.");
								}
								else
								{
									Console.WriteLine ("El jefe " + jefeEncontrado.Nya + "no ha sido asignado a ningún grupo de obreros.");
								}
							}
							else
							{
								Console.WriteLine ("El jefe " + jefeEncontrado.Nya + " no ha sido asignado a ningún grupo de obreros.");
							}
							
							
							
						}
						else
						{
							Console.WriteLine ("Ningún jefe se ha asignado a ningún grupo.");
						}
						
					}
					else
					{
						Console.WriteLine ("Ningún jefe se ha asignado a ningún grupo.");
					}
				}
			}
			
			catch (OcurrioUnErrorException m)
			{
				Console.WriteLine (m.motivo);
			}
			
			catch (OverflowException)
			{
				Console.WriteLine ("ERROR: El número ingresado está fuera de los límites permitidos. Por favor, introduzca un número válido.");
			}
			catch (FormatException)
			{
				Console.WriteLine ("ERROR: Entrada no válida. Por favor, ingresa un número entero válido.");
				
			}
			catch (Exception)
			{
				Console.WriteLine ("Se produjo un error inesperado. Por favor, intente nuevamente.");
			}
		}
		public static void MostrarJefeSinAsignarAGgrupo(ArrayList listaJefes, ArrayList listaGrupoObre )
		{
			bool encontrado = true;
			foreach (JefeDeObra elem in listaJefes)
			{
				encontrado = true;
				
				foreach (GrupoObreros elem2 in listaGrupoObre)
				{
					
					if (elem2.JefeObra == elem)
					{
						encontrado = false;
					}
					
				}
				if (encontrado)
				{
					elem.Mostrar ();
				}
				
			}
		}
		public static JefeDeObra LegajoJefeDeObraSinAsignar (int legajo, ArrayList listaJefes, ArrayList listaGrupo )
		{
			bool encontrado = true;
			foreach (JefeDeObra jefe in listaJefes)
			{
				encontrado = true;
				
				foreach (GrupoObreros grupo in listaGrupo)
				{
					
					if (grupo.JefeObra == jefe)
					{
						encontrado = false;
					}
					
				}
				if (encontrado)
				{
					if (jefe.NumeroLegajo == legajo)
					{
						return jefe;
					}
				}
				
			}
			
			return null;
		}
		public static void MostrarGrupoObrerosSinJefeAsignado (ArrayList listaGrupo)
		{
			foreach (GrupoObreros elem in listaGrupo)
			{
				if (elem.JefeObra == null)
				{
					elem.Mostrar();
				}
			}
		}
		public static GrupoObreros BuscarNumeroGrupoObreros (int numeroGrupo,ArrayList listaGrupo)
		{
			foreach (GrupoObreros elem in listaGrupo)
			{
				if (elem.NumeroGrupo == numeroGrupo)
				{
					return elem;
				}
			}
			
			return null;
		}
		public static void AsignarJefeAgrupo (JefeDeObra jefe, int numeroGrupo, ArrayList listaGrupo)
		{
			foreach (GrupoObreros elem in listaGrupo)
			{
				if (elem.NumeroGrupo == numeroGrupo)
				{
					elem.AsignarJefeDeObra (jefe);
				}
			}
		}
		
		//OPCIÓN H: MENÚ.
		public static void CaseH(EmpresaConstructora empresa){
			Console.WriteLine("═════════════════════════════════════════════════════════════════════════════");
			Console.WriteLine("ELIMINAR JEFE DE UN GRUPO");
			Console.WriteLine("═════════════════════════════════════════════════════════════════════════════");
			Console.WriteLine("");
			
			
			
			try{
				
				Console.Write("¿Desea Eliminar un Jefe de un Grupo?[s/n]: ");
				string sinoh =Console.ReadLine().ToLower();
				while (sinoh != "s" && sinoh != "n"){
					Console.Write("Por favor, ingrese [s] para confirmar o [n] para cancelar: ");
					sinoh= Console.ReadLine().ToLower();
				}
				if(sinoh=="n"){
					Console.WriteLine("Operación cancelada.");
					return;
				}
				if (sinoh == "s")
				{
					MostrarJefesConGrupoAsignado(empresa.ListaJefesDeObra);
					Console.Write("ingrese el Legajo del jefe para sacarlo del grupo: ");

					int legajoEliminarJefe = int.Parse(Console.ReadLine());

					JefeDeObra jefeEliminar = empresa.BuscarJefe(legajoEliminarJefe);
					
					Console.Write ("Seguro que quiere sacar al jefe de obra " + jefeEliminar.Nya + " del grupo número ("+ jefeEliminar.GrupoObrero.NumeroGrupo + ")? [s/n]: ");
					string sacarJefeGrupo = Console.ReadLine ().ToLower ();
					while (sacarJefeGrupo != "s" && sacarJefeGrupo  != "n"){
						Console.Write("Por favor, ingrese [s] para confirmar o [n] para negación: ");
						sacarJefeGrupo = Console.ReadLine().ToLower();}
					if (sacarJefeGrupo == "s")
					{

						if (jefeEliminar != null)
						{
							jefeEliminar.GrupoObrero.EliminarJefeGrupo(legajoEliminarJefe);
							
							jefeEliminar.SacarGrupoObrero();

							Console.WriteLine("Jefe sacado del grupo con exito.");
						}
						else
						{
							Console.WriteLine("Jefe no encontrado.");
						}
					}
					else
						Console.WriteLine ("Ningún jefe se ha sacado de su grupo asignado.");
					
				}
			}
			catch (FormatException){
				Console.WriteLine ("Error: Entrada no válida.");
			}
			catch (Exception){
				
				Console.WriteLine ("Se produjo un error inesperado. Por favor, intente nuevamente.");
			}
			
		}
		public static void MostrarJefesConGrupoAsignado( ArrayList ListaJefes)
		{
			foreach (JefeDeObra elem in ListaJefes)
			{
				if (elem.GrupoObrero != null)
				{
					elem.Mostrar();
				}
			}
		}
		
		//OPCIÓN I: MENÚ.
		public static void CaseI(EmpresaConstructora empresa){
			Console.WriteLine("═════════════════════════════════════════════════════════════════════════════");
			Console.WriteLine("ASIGNAR JEFE A UNA OBRA");
			Console.WriteLine("═════════════════════════════════════════════════════════════════════════════");
			Console.WriteLine("");
			try{
				
				Console.Write("¿Desea Asignar un Jefe a una Obra?[s/n]: ");
				string sinoi= Console.ReadLine().ToLower();
				while (sinoi != "s" && sinoi != "n"){
					Console.Write("Por favor, ingrese [s] para confirmar o [n] para cancelar: ");
					sinoi= Console.ReadLine().ToLower();
				}
				if(sinoi=="n"){
					Console.WriteLine("Operación cancelada.");
					return;
				}
				if (sinoi == "s")
				{
					
					MostrarObrasSinJefe(empresa.ListaObrasEnEjecucion);
					Console.Write("Ingrese el codigo de la obra a la que quiera asignarle un Jefe: ");
					int codigoObra = int.Parse(Console.ReadLine());
					
					Obra obra = empresa.BuscarObra (codigoObra);
					
					if (obra.JefeObra == null)
					{
						empresa.MostrarJefesDeObra();
						Console.Write("Ingrese el legajo del jefe para colocarlo a la obra: ");
						int legajoJefee = int.Parse(Console.ReadLine());
						
						AgregarJefeAObraExistente(codigoObra,legajoJefee,empresa.ListaObrasEnEjecucion,empresa.ListaJefesDeObra);
						
						Console.WriteLine();
					}
					else
						Console.WriteLine ("La obra ya dispone de un jefe asignado.");
				}
			}
			catch (FormatException){
				Console.WriteLine ("Error: Entrada no válida.");
			}
			catch (Exception){
				Console.WriteLine ("Se produjo un error inesperado. Por favor, intente nuevamente.");
			}
			
		}
		public static void MostrarObrasSinJefe(ArrayList ListaObrasEjecucion){
			foreach (Obra elem in ListaObrasEjecucion){
				if(elem.JefeObra== null){
					elem.Mostrar();
					
					// crear una cadena para mostrar los grupos asignados
					string grupoAsignadosInfo = ""; // inicializa la cadena vacía

					if (elem.GruposAsignados.Count > 0){
						
						foreach (GrupoObreros grupo in elem.GruposAsignados){
							// concatenar el numero del grupo a la cadena
							if (grupoAsignadosInfo != ""){// si ya hay informacion, agrega una coma
								
								grupoAsignadosInfo += ", ";
							}
							grupoAsignadosInfo += "Grupo " + grupo.NumeroGrupo; // agrega el numero del grupo
						}
						Console.WriteLine("Grupos: " + grupoAsignadosInfo); // muestra los grupos
					}
					else{
						Console.WriteLine("Grupos: Sin grupos asignados."); // mensaje si no hay grupos
					}
					
					Console.WriteLine("~");
					Console.WriteLine();
					
				}
			}
		}
		public static  void AgregarJefeAObraExistente(int codigoObra, int legajoJefe,ArrayList ListaObrasEnEjecucion, ArrayList ListaJefesDeObra)
		{

			Obra obraEncontrada = null;//se guardara la obra si fue encontrada

			foreach (Obra elem in ListaObrasEnEjecucion)
			{
				if (elem.CodigoInterno == codigoObra)
				{
					obraEncontrada = elem;//se guarda la obra en obraEncontrada
					break;//salimos del bucle si encontramos la obra
				}
			}
			if (obraEncontrada == null)
			{
				Console.WriteLine("_");
				Console.WriteLine("La obra con el codigo " + codigoObra + " no fue encontrada.");
				Console.WriteLine("_");
				return;
			}
			JefeDeObra jefeEncontrado = null;

			foreach (JefeDeObra elem2 in ListaJefesDeObra)
			{
				if (elem2.NumeroLegajo == legajoJefe)
				{
					jefeEncontrado = elem2;
					break;//salimos del bucle si encontramos el jefe
				}
			}
			//            bool asignado = false;                                      | Esta verificacion es por si el jefe solo puede estar en una obra
			//            foreach (Obra obra in ListaObrasEnEjecucion)                | pero en nuestro caso quisimos hacerlo mas realista y hacer que un
			//            {                                                           | jefe pueda estar en varias obras
			//                if (obra.JefeObra == jefeEncontrado)
			//                {
			//                    asignado = true;
			//                }
			//            }
//
			//            if (asignado)
			//            {
			//                Console.WriteLine("Jefe ya asignado a una obra.");
			//                Console.WriteLine("No se ha añadido el jefe a la obra.");
			//                return;
			//            }

			if (jefeEncontrado == null)
			{
				Console.WriteLine("_");
				Console.WriteLine("No se encontro el jefe con el legajo : " + legajoJefe + ".");
				Console.WriteLine("_");
				return;
			}

			obraEncontrada.AsignarJefeDeObraObra(jefeEncontrado);
			Console.WriteLine("Jefe añadido a la obra con exito.");
		}
		
		//OPCIÓN J: MENÚ.
		public static void CaseJ(EmpresaConstructora empresa){
			Console.WriteLine("═════════════════════════════════════════════════════════════════════════════");
			Console.WriteLine("ELIMINAR JEFE DE UNA OBRA.");
			Console.WriteLine("═════════════════════════════════════════════════════════════════════════════");
			Console.WriteLine();
			
			try{
				
				Console.Write("¿Desea Eliminar un Jefe de una Obra?[s/n]: ");
				string sinoj= Console.ReadLine().ToLower();
				while (sinoj != "s" && sinoj != "n"){
					Console.Write("Por favor, ingrese [s] para confirmar o [n] para cancelar: ");
					sinoj= Console.ReadLine().ToLower();
				}
				if(sinoj=="n"){
					Console.WriteLine("Operación cancelada.");
					return;
				}
				if (sinoj == "s")
				{
					
					Console.WriteLine("Obras que poseen un Jefe:");
					MostrarObrasConJefe(empresa.ListaObrasEnEjecucion);
					Console.WriteLine();
					int codinter;
					do{
						Console.Write("Ingrese el Codigo Interno de la Obra a la que quiera eliminar el Jefe(para salir presione [0]): ");
						codinter= int.Parse(Console.ReadLine());
						if(codinter !=0){
							Obra obraencontrada=empresa.BuscarObra(codinter);//busca la obra con el codigo interno ingresado
							if( obraencontrada != null && obraencontrada.JefeObra != null){
								JefeDeObra jefito=obraencontrada.JefeObra;// obtener el jefe de la obra
								
								Console.Write("¿Seguro que quiere eliminar a "+ jefito.Nya+ " (Legajo: "+ jefito.NumeroLegajo+ ") de la obra?[s/n]: ");
								string confirmar= Console.ReadLine().ToLower();
								
								while(confirmar != "s" && confirmar != "n"){
									Console.WriteLine("Por favor ingrese [s] para confirmar o [n] para cancelar: ");
									confirmar=Console.ReadLine().ToLower();
								}
								if(confirmar == "s"){
									obraencontrada.JefeObra=null;// elimina el jefe de la obra
									Console.WriteLine("El jefe: "+ jefito.Nya+ " ("+jefito.NumeroLegajo+") fue eliminado de la obra exitosamente.");
									bool hayObrasConJefes = false;
									foreach (Obra elem in empresa.ListaObrasEnEjecucion){
										if (elem.JefeObra != null){
											hayObrasConJefes = true;
											break; // Salir del bucle si encontramos al menos una obra con un jefe
										}
									}

									// mostrar las obras con jefes solo si hay alguna
									if (hayObrasConJefes){
										Console.WriteLine();
										Console.WriteLine("Obras que poseen un Jefe:");
										MostrarObrasConJefe(empresa.ListaObrasEnEjecucion);
									}
									else{
										Console.WriteLine();
										Console.WriteLine("Ya no hay mas obras con jefes, volviendo al menú...");
										break;
									}
								}
								else{
									Console.WriteLine("Eliminacion cancelada.");
								}
							}
							else if(obraencontrada == null){
								Console.WriteLine("No se encontró la obra con el codigo: "+ codinter);
							}
							
							
							else if (obraencontrada.JefeObra == null)
							{
								Console.WriteLine("El código ingresado no esta asignado a ninguna obra con jefe asignado.");
							}
							else
								Console.WriteLine ("Volviendo al menú principal...");
							
						}
					}
					while(codinter !=0);
					Console.WriteLine();
					
				}
			}
			catch (FormatException){
				Console.WriteLine ("Error: Entrada no válida.");
			}
			catch (Exception){
				Console.WriteLine ("Se produjo un error inesperado. Por favor, intente nuevamente.");
			}
			
		}
		public static void MostrarObrasConJefe(ArrayList ListaObrasEjecucion){
			foreach (Obra elem in ListaObrasEjecucion){
				if(elem.JefeObra != null){
					elem.Mostrar();
				}
			}
		}
		
		//OPCIÓN K: MENÚ.
		public static void CaseK(EmpresaConstructora empresa){
			Console.WriteLine("═════════════════════════════════════════════════════════════════════════════");
			Console.WriteLine("CREAR OBRA NUEVA");
			Console.WriteLine("═════════════════════════════════════════════════════════════════════════════");
			try
			{
				Console.Write("¿Desea crear una Obra?[s/n]: ");
				string sinok= Console.ReadLine().ToLower();
				while (sinok != "s" && sinok != "n"){
					Console.Write("Por favor, ingrese [s] para confirmar o [n] para cancelar: ");
					sinok= Console.ReadLine().ToLower();
				}
				if(sinok=="n"){
					Console.WriteLine("Operación cancelada.");
					return;
				}
				if (sinok == "s")
				{
					Console.WriteLine("");
					Console.Write("Ingrese el nombre del propietario: ");
					string NombreProp = Console.ReadLine();

					Console.Write("Ingrese DNI del propietario (8 dígitos): ");
					int DNIProp = int.Parse(Console.ReadLine());

					while (DNIProp < 10000000)
					{

						Console.WriteLine("═════════════════════════════════════════════════════════════════════════════");
						Console.WriteLine("El DNI ingresado no es válido. Debe contener 8 dígitos. Intente nuevamente.");
						Console.WriteLine("═════════════════════════════════════════════════════════════════════════════");
						Console.Write("Ingrese DNI del propietario: ");
						DNIProp = int.Parse(Console.ReadLine());

					}
					while (DNIProp > 10000000){
						Console.WriteLine("═════════════════════════════════════════════════════════════════════════════");
						Console.Write("El Dni ("+ DNIProp+ ") que ha ingresado es correcto?[s/n]: ");
						string opcsi= Console.ReadLine().ToLower();
						Console.WriteLine("═════════════════════════════════════════════════════════════════════════════");
						while (opcsi != "s" && opcsi != "n"){
							Console.Write("Por favor, ingrese [s] para confirmar o [n] para omitir la asignación a un grupo: ");
							opcsi= Console.ReadLine().ToLower();
						}
						if(opcsi == "s"){
							
							

							Console.WriteLine("Tipos de obras:");
							Console.WriteLine("═════════════════════════════════════════════════════════════════════════════");
							Console.WriteLine("-construcción");
							Console.WriteLine("-remodelación");
							Console.WriteLine("-ampliación");
							Console.WriteLine("-demolición");
							Console.WriteLine("-reparación\n");
							Console.WriteLine("═════════════════════════════════════════════════════════════════════════════");

							Console.Write("Ingrese el tipo de obra: ");
							string TipoDeObra = Console.ReadLine().ToLower();

							while (TipoDeObra != "construcción"&& TipoDeObra != "construccion" && TipoDeObra != "remodelación" && TipoDeObra != "remodelacion"&& TipoDeObra != "ampliación" &&TipoDeObra != "ampliacion"&& TipoDeObra != "demolición" && TipoDeObra != "demolicion" && TipoDeObra != "reparación"&& TipoDeObra !="reparacion")
							{
								Console.WriteLine("Tipo de obra no disponible. Por favor, ingrese un tipo de obra disponible.");
								Console.Write("Ingrese el tipo de obra: ");
								TipoDeObra = Console.ReadLine().ToLower();
							}

							Console.Write("Ingrese el costo de la obra: ");
							double Costo = double.Parse(Console.ReadLine());

							while (Costo < 0)
							{

								Console.WriteLine("El costo no puede ser negativo. Por favor, ingresa un valor mayor o igual a 0");
								Console.Write("Ingrese el costo de la obra: ");
								Costo = double.Parse(Console.ReadLine());

							}
							

							CrearObra(NombreProp, DNIProp, TipoDeObra, Costo, empresa);
							return;
							
						}
						
						Console.Write("Ingrese el DNI del Propietario correctamente: ");
						DNIProp= int.Parse(Console.ReadLine());
					}
				}
				
			}
			catch (OverflowException)
			{
				Console.WriteLine ("Error: El número ingresado está fuera de los límites permitidos. Por favor, introduzca un número válido.");
			}
			catch (FormatException)
			{
				Console.WriteLine ("Error: Entrada no válida. Por favor, ingresa un número entero válido.");
				
			}
			catch (Exception)
			{
				Console.WriteLine ("Se produjo un error inesperado. Por favor, intente nuevamente.");
			}
		}
		
		public static void CrearObra (string nombre, int dni, string tipodeobra, double costo, EmpresaConstructora empresa1){
			try{
				
				Obra nuevaobra=new Obra(nombre,dni,tipodeobra,0,costo,null);
				
				//empresa1.ListaObrasEnEjecucion.Add(nuevaobra);
				
				Console.Write("¿Quiere asignarle un jefe de obra?[s/n]: ");
				string opcionk = Console.ReadLine().ToLower();
				
				while (opcionk != "s" && opcionk != "n")
				{
					Console.Write("Por favor, ingrese [s] para confirmar o [n] para omitir la asignación: ");
					opcionk = Console.ReadLine();
				}

				if (opcionk == "s")
				{
					MostrarJefesDeObraNombreLegajo(empresa1.ListaJefesDeObra);
					try{
						Console.Write("Ingrese el legajo del jefe de obra: ");
						int legajojefe = int.Parse(Console.ReadLine());
						
						JefeDeObra jefeObra = empresa1.BuscarJefe (legajojefe);
						
						if (jefeObra != null){
							AgregarObraEnEjecucion(nuevaobra, jefeObra,empresa1.ListaObrasEnEjecucion);
							Console.WriteLine ("Obra creada con jefe de obra asignado.");
							return;
						}
						else{
							Console.WriteLine();
							Console.WriteLine("No se encontró el Jefe de Obra colocado");
							Console.WriteLine("Se creó la obra sin Jefe de Obra");
							AgregarObraEnEjecucion(nuevaobra,null,empresa1.ListaObrasEnEjecucion);
							
						}
					}
					catch (FormatException)
					{
						AgregarObraEnEjecucion(nuevaobra,null,empresa1.ListaObrasEnEjecucion);
						Console.WriteLine ("Error: Entrada no válida.La Obra se creó sin Jefe de Obra");
						
					}
				}
				if( opcionk == "n")
				{
					AgregarObraEnEjecucion(nuevaobra,null,empresa1.ListaObrasEnEjecucion);
					Console.WriteLine("Se creó la Obra sin Jefe de Obra.");
				}
				
				
			}
			
//				while (jefeObra == null)
//				{
//					Console.WriteLine ("Jefe no encontrado.");
//					Console.Write("¿Quiere asignarle un jefe de obra?[s/n]: ");
//					opcionk = Console.ReadLine().ToLower();
			
//					while (opcionk != "s" && opcionk != "n")
//					{
//						Console.Write("Por favor, ingrese [s] para confirmar o [n] para omitir la asignación: ");
//						opcionk = Console.ReadLine();
//					}
//					if (opcionk == "n")
//					{
//						Console.WriteLine();
//						Console.WriteLine("La obra fue creada con exito sin jefe asignado.");
//						return;
//					}
//					if ( opcionk == "s")
//					{
//						Console.Write("Ingrese el legajo del jefe de obra: ");
//						legajojefe = int.Parse(Console.ReadLine());
//
//						jefeObra = empresa1.BuscarJefe (legajojefe);
//					}
//				}
			
//				if (jefeObra != null)
//				{
//
//
//					AgregarObraEnEjecucion(nuevaobra, jefeObra,empresa1.ListaObrasEnEjecucion);
//					Console.WriteLine ("Obra creada con exito con jefe de obra asignado.");
//					return;
//				}
			
//			}
//			else {
//
//				Console.WriteLine("La obra fue creada con exito sin jefe asignado.");
//			}
			
			catch (OverflowException)
			{
				Console.WriteLine ("Error: El número ingresado está fuera de los límites permitidos. Por favor, introduzca un número válido.");
			}
			catch (FormatException)
			{
				
				Console.WriteLine ("Error: Entrada no válida.");
				
			}
			catch (Exception)
			{
				Console.WriteLine ("Se produjo un error inesperado. Por favor, intente nuevamente.");
			}
			
			
			
			
			
			
		}
		public static void AgregarObraEnEjecucion(Obra obrita, JefeDeObra legajo, ArrayList ListaObrasEnEjecucion)
		{
			ListaObrasEnEjecucion.Add(obrita);
			if (legajo != null)
			{
				obrita.AsignarJefeDeObraObra(legajo);

			}
		}


		//OPCIÓN L: MENÚ
		public static void CaseL(EmpresaConstructora empresa){
			Console.WriteLine("═════════════════════════════════════════════════════════════════════════════");
			Console.WriteLine("MODIFICAR EL ESTADO DE AVANCE DE UNA OBRA.");
			Console.WriteLine("═════════════════════════════════════════════════════════════════════════════");

			try
			{
				Console.Write("¿Desea modificar el estado de avance de una Obra?[s/n]: ");
				string sino= Console.ReadLine().ToLower();
				while (sino != "s" && sino != "n"){
					Console.Write("Por favor, ingrese [s] para confirmar o [n] para cancelar: ");
					sino= Console.ReadLine().ToLower();
				}
				if(sino=="n"){
					Console.WriteLine("Operación cancelada.");
					return;
				}
				if (sino == "s")
				{
					Console.WriteLine("");
					Console.WriteLine("Estados de las obras:");
					Console.WriteLine("═════════════════════════════════════════════════════════════════════════════");
					
					MostrarObrasDisponibleAvance(empresa.ListaObrasEnEjecucion);
					
					Console.WriteLine("═════════════════════════════════════════════════════════════════════════════");
					Console.Write("Ingrese el código de la obra que desea modificar (presione [0] para regresar al menú principal): ");
					int codigoInterno = int.Parse(Console.ReadLine());

					if (codigoInterno != 0)
					{
						Obra obraEncontrada = BuscarObraDisponible(empresa.ListaObrasEnEjecucion,codigoInterno);

						while (obraEncontrada == null && codigoInterno != 0 )
						{
							Console.WriteLine("El código (" + codigoInterno +   ") no corresponde a ninguna obra.");
							Console.Write("Por favor, ingrese un código válido o [0] para volver al menú principal: ");
							codigoInterno = int.Parse(Console.ReadLine());
							obraEncontrada = BuscarObraDisponible(empresa.ListaObrasEnEjecucion,codigoInterno);
						}
						if (codigoInterno != 0)
						{
							Console.Write("Ingrese el nuevo estado de avance (un valor entre 0 y 100): ");
							
							int estadoDeAvance = int.Parse(Console.ReadLine());
							
							while (estadoDeAvance < 0 || estadoDeAvance > 100)
							{
								Console.WriteLine ("El valor ingresado (" + estadoDeAvance + ") no es válido.");
								Console.Write ("Por favor, ingrese un número estre 0 y 100: ");
								estadoDeAvance = int.Parse(Console.ReadLine());
								
							}
							
							ModificarPorcentajeObra(codigoInterno, estadoDeAvance,empresa.ListaObrasEnEjecucion,empresa);
							Console.WriteLine ("El estado de avance de la obra (" + obraEncontrada.CodigoInterno + ") ha sido actualizado a " + obraEncontrada.EstadoDeAvance +"% correctamente.");
							Console.WriteLine("");
						}
						else
							Console.WriteLine ("No se ha modificado el estado de ninguna obra. Regresando al menú principal.");
					}
					else
						Console.WriteLine ("No se ha modificado el estado de ninguna obra. Regresando al menú principal.");

				}
			}
			catch (OverflowException)
			{
				Console.WriteLine ("ERROR: El número ingresado está fuera de los límites permitidos. Por favor, introduzca un número válido.");
			}
			catch (FormatException)
			{
				Console.WriteLine ("ERROR: Entrada no válida. Por favor, ingresa un número entero válido.");
			}
			catch (Exception)
			{
				Console.WriteLine ("Se produjo un error inesperado. Por favor, intente nuevamente.");
			}
		}
		public static void MostrarListaEstadoAvanceObrasEnEjecucion(ArrayList ListaObrasEnEjecucion){
			
			foreach (Obra elem in ListaObrasEnEjecucion){
				Console.WriteLine("- Código: " + elem.CodigoInterno + " | Estado de avance: " + elem.EstadoDeAvance + "%");
			}
		}
		public static void MostrarObrasDisponibleAvance (ArrayList listaObra)
		{
			foreach (Obra obra in listaObra)
			{
				if (obra.JefeObra != null && obra.GruposAsignados.Count > 0){
					
					Console.WriteLine ("- Código: " + obra.CodigoInterno + " | Estado de avance: " + obra.EstadoDeAvance + "%.");
				}
			}
		}
		public static Obra BuscarObraDisponible (ArrayList listaObras, int codigoInternoObra)
		{
			foreach (Obra obra in listaObras)
			{
				if (obra.JefeObra != null && obra.GruposAsignados.Count > 0 && obra.CodigoInterno == codigoInternoObra)
				{
					return obra;
				}
			}
			return null;
		}
		public static void ModificarPorcentajeObra(int codigo, int avance, ArrayList ListaObrasEnEjec,EmpresaConstructora empre)
		{
			foreach (Obra elem in ListaObrasEnEjec)
			{
				if (codigo == elem.CodigoInterno)
				{
					if (avance == 100)
					{
						elem.EstadoDeAvance = avance;
						empre.ListaObrasFinalizadas.Add(elem);
						empre.ListaObrasEnEjecucion.Remove(elem);
						Console.WriteLine("La obra ha finalizado");
						break;
					}
					else
					{
						elem.EstadoDeAvance = avance;
					}
				}
			}
		}
		
		//OPCIÓN M: MENÚ
		public static void CaseM(EmpresaConstructora empresa){
			Console.WriteLine("═════════════════════════════════════════════════════════════════════════════");
			Console.WriteLine("ASIGNAR GRUPO A OBRA");
			Console.WriteLine("═════════════════════════════════════════════════════════════════════════════");
			
			Console.WriteLine("");
			
			try{
				
				Console.Write("¿Desea asignar un grupo a una Obra?[s/n]: ");
				string sino= Console.ReadLine().ToLower();
				while (sino != "s" && sino != "n"){
					Console.Write("Por favor, ingrese [s] para confirmar o [n] para cancelar: ");
					sino= Console.ReadLine().ToLower();
				}
				if(sino=="n"){
					Console.WriteLine("Operación cancelada.");
					return;
				}
				if (sino == "s")
				{
					Console.WriteLine ("Obras: ");
					MostrarListaObrasEnEjecucionConGrupo(empresa.ListaObrasEnEjecucion);
					
					Console.WriteLine("");
					
					Console.Write("Ingrese el código interno de la obra que desea asignarle un grupo (0 para salir):  ");
					int codigoInternoObra = int.Parse (Console.ReadLine ());
					
					if (codigoInternoObra != 0)
					{
						Obra obra = empresa.BuscarObra (codigoInternoObra);
						
						while (obra == null && codigoInternoObra != 0){
							
							Console.WriteLine ("Código interno no asignado a ninguna obra. Por favor, ingresa un código de obra válido (presione[0] para salir)");
							Console.Write ("Ingrese el código interno de la obra que desea asignarle un grupo (0 para salir):  ");
							codigoInternoObra = int.Parse (Console.ReadLine ());
							obra = empresa.BuscarObra (codigoInternoObra);
							
						}
						
						if ( codigoInternoObra != 0){
							
							Console.WriteLine();
							Console.WriteLine ("Grupos de obreros disponibles: ");
							
							MostrarGrupoObrerosConMenosDeTresObras(empresa.ListaGrupoObreros);
							
							
							Console.Write("Ingrese el número del grupo al que desea asignarle la obra (0 para salir):  ");
							int numeroGrupo = int.Parse (Console.ReadLine ());
							
							if ( numeroGrupo != 0)
							{
								GrupoObreros grupo = BuscarGrupoDisponibles (numeroGrupo,empresa.ListaGrupoObreros);
								
								while (grupo == null){
									
									Console.WriteLine ("Código de grupo no asignado a ningún grupo disponible. Por favor, ingrese un número válido. (presione[0] para salir)");
									Console.Write ("Ingrese el número del grupo al que desea asignarle la obra (0 para salir):  ");
									numeroGrupo = int.Parse (Console.ReadLine ());
									grupo = BuscarGrupoDisponibles (numeroGrupo,empresa.ListaGrupoObreros);
									if (numeroGrupo == 0)
										break;
									
								}
								
								if (numeroGrupo != 0)
								{
									AgregarGrupoAObra(obra,numeroGrupo,empresa.ListaGrupoObreros);
									
									Console.WriteLine("");
									Console.WriteLine("═════════════════════════════════════════════════════════════════════════════");
									Console.WriteLine ("La obra (" + obra.CodigoInterno +") del propietario " + obra.NombrePropietario + " ha sido asignada al grupo número (" + numeroGrupo + ")");
									Console.WriteLine("═════════════════════════════════════════════════════════════════════════════");
								}
								else
									Console.WriteLine ("No se ha asignado ningun grupo a un obra.");
								
							}
							else
								Console.WriteLine ("No se ha asignado ningun grupo a obra.");
							
							
						}
						else
							Console.WriteLine ("No se ha asignado ningun grupo a un obra.");
						
					}
					else
						Console.WriteLine ("No se ha asignado ningun grupo a un obra.");
				}
				
			}
			catch(OcurrioUnErrorException e){
				Console.WriteLine("ERROR : "+e.motivo);
			}
			catch (FormatException){
				Console.WriteLine ("Error: Entrada no válida.");
			}
			catch(Exception){
				Console.WriteLine("ERROR: Ocurrió un error inesperado");
			}
			
		}
		public static void MostrarGrupoObrerosConMenosDeTresObras (ArrayList ListaGrupoObreros)
		{
			foreach (GrupoObreros elem in ListaGrupoObreros)
			{
				if (elem.CantidadObras < 3 && elem.JefeObra != null)
				{
					elem.Mostrar();
				}
			}
		}
		public static GrupoObreros BuscarGrupoDisponibles (int codigoGrupo,ArrayList ListaGrupoObreros)
		{
			foreach (GrupoObreros grupo in ListaGrupoObreros)
			{
				if (grupo.CantidadObras <= 3 && grupo.JefeObra != null)    //un grupo puede trabajar hasta en 3 obras diferentes solamente
				{
					if (grupo.NumeroGrupo == codigoGrupo)
					{
						return grupo;
					}
				}
			}
			
			return null;
			
		}
		public static void AgregarGrupoAObra(Obra obra, int numeroGrupo, ArrayList ListaGrupoObre)
		{
			foreach (GrupoObreros grupo in ListaGrupoObre)
			{
				if (grupo.NumeroGrupo == numeroGrupo)
				{
					grupo.AsignarObraAGrupo(obra);// llama a un metodo de la clase GrupoObreros
					
					obra.AgregarGrupo(grupo);//llama un metodo para agregar al grupo a la obra
					break;//salir del bucle una vez que se haya encontrado y agregado al grupo correspondiente
				}
			}
		}
		public static void MostrarListaObrasEnEjecucionConGrupo(ArrayList ListaObrasEnEjec){//muestra obras en ejecucion y el grupo asignado a la obra
			
			foreach (Obra elem in ListaObrasEnEjec){
				elem.Mostrar();
				
				string grupoAsignadosInfo="";

				if(elem.GruposAsignados.Count > 0){
					grupoAsignadosInfo += "Grupos: ";
					foreach( GrupoObreros elem2 in elem.GruposAsignados)
					{
						if(grupoAsignadosInfo != "Grupos: ")
						{
							grupoAsignadosInfo += ", ";
						}
						grupoAsignadosInfo += "Grupo "+ elem2.NumeroGrupo.ToString();						
					}
				}
				else{
					grupoAsignadosInfo= "Grupos: Sin grupos asignados.";
				}
				Console.WriteLine(grupoAsignadosInfo);
				
				Console.WriteLine();
			}
			
		}
		
		//OPCIÓN N: MENÚ
		public static void MostrarSubMenuImpresion(){
			Console.WriteLine("╔═════════════════════════════════════════════════════════════════════════════╗");
			Console.WriteLine("║                            SUBMENÚ DE IMPRESIÓN:                            ║");
			Console.WriteLine("║═════════════════════════════════════════════════════════════════════════════║");
			Console.WriteLine("");
			Console.WriteLine("a) Listado de obreros.");
			Console.WriteLine("b) Listado de grupos.");
			Console.WriteLine("c) Listado de jefes de obra.");
			Console.WriteLine("d) Listado de obras en ejecución.");
			Console.WriteLine("e) Listado de obras finalizadas.");
			Console.WriteLine("f) Listado de estado de obras sin finalizar.");
			Console.WriteLine("g) Mostrar los integrantes de un grupo.");
			Console.WriteLine("h) Mostrar Obras Finalizadas de tipo...");
			Console.WriteLine("i) Mostrar Obras en Ejecución de tipo...");
			Console.WriteLine("j) Mostrar Obras por Precio de forma Ordenada.");
			Console.WriteLine("k) Salir del submenú.");
			Console.WriteLine("═════════════════════════════════════════════════════════════════════════════");
		}
		
		//OPCIÓN A: SUBMENÚ
		public static void CaseASubMenu(EmpresaConstructora empresa){
			Console.WriteLine("═════════════════════════════════════════════════════════════════════════════");
			Console.WriteLine("LISTA DE OBREROS");
			Console.WriteLine("═════════════════════════════════════════════════════════════════════════════");
			Console.WriteLine("");
			empresa.MostrarListaObreros();
			Console.WriteLine("");
		}
		
		//OPCIÓN B: SUBMENÚ
		public static void CaseBSubMenu(EmpresaConstructora empresa){
			Console.WriteLine("═════════════════════════════════════════════════════════════════════════════");
			Console.WriteLine("LISTA DE GRUPOS");
			Console.WriteLine("═════════════════════════════════════════════════════════════════════════════");
			Console.WriteLine("");
			MostrarListaGruposConObra(empresa);
			Console.WriteLine();
			//        public static void MostrarListaGruposConObra(EmpresaConstructora empresa1)   //ES PARA MOSTRAR LA FUNCION UTILIZADA
			//        {
			//            foreach (GrupoObreros elem in empresa1.ListaGrupoObreros)
			//            {
			//                elem.mostrar();
			//                ImprimirObrasAsignadas(elem);
//
			//            }
//
			//        }
		}

		//OPCIÓN C: SUBMENÚ
		public static void CaseCSubMenu(EmpresaConstructora empresa){
			Console.WriteLine("═════════════════════════════════════════════════════════════════════════════");
			Console.WriteLine("LISTA JEFES DE OBRA");
			Console.WriteLine("═════════════════════════════════════════════════════════════════════════════");
			Console.WriteLine("");
			empresa.MostrarJefesDeObra();
			Console.WriteLine("");
			
		}
		
		//OPCIÓN D: SUBMENÚ
		public static void CaseDSubMenu(EmpresaConstructora empresa){
			Console.WriteLine("═════════════════════════════════════════════════════════════════════════════");
			Console.WriteLine("LISTA DE OBRAS EN EJECUCIÓN");
			Console.WriteLine("═════════════════════════════════════════════════════════════════════════════");
			Console.WriteLine("");
			MostrarListaObrasEnEjecucionConGrupo(empresa.ListaObrasEnEjecucion);
			Console.WriteLine("");
		}
		
		//OPCIÓN E: SUBMENÚ
		public static void CaseESubMenu(EmpresaConstructora empresa){
			Console.WriteLine("═════════════════════════════════════════════════════════════════════════════");
			Console.WriteLine("LISTA DE OBRAS FINALIZADAS");
			Console.WriteLine("");
			Console.WriteLine("═════════════════════════════════════════════════════════════════════════════");
			empresa.MostrarListaObrasFinalizadas();
			Console.WriteLine("");
		}
		
		//OPCIÓN F: SUBMENÚ
		public static void CaseFSubMenu(EmpresaConstructora empresa){
			Console.WriteLine("═════════════════════════════════════════════════════════════════════════════");
			Console.WriteLine("LISTA DE ESTADO DE AVANCE DE OBRAS SIN FINALIZAR");
			Console.WriteLine("═════════════════════════════════════════════════════════════════════════════");
			Console.WriteLine("");
			MostrarListaEstadoAvanceObrasEnEjecucion(empresa.ListaObrasEnEjecucion);
			Console.WriteLine("");
			
		}
		
		//OPCIÓN G: SUBMENÚ
		public static void CaseGSubMenu(EmpresaConstructora empresa){
			try{
				Console.WriteLine("═════════════════════════════════════════════════════════════════════════════");
				Console.WriteLine("MOSTRAR LOS INTEGRANTES DE UN GRUPO");
				Console.WriteLine("═════════════════════════════════════════════════════════════════════════════");
				Console.WriteLine("");
				Console.WriteLine("¿Quiere buscarlo por jefe o por código de grupo?");
				Console.WriteLine("1)Buscar por jefe.");
				Console.WriteLine("2)Buscar por código de grupo.");
				Console.WriteLine("3)Salir.");
				
				Console.WriteLine("═════════════════════════════════════════════════════════════════════════════");
				Console.Write("Ingrese una opción: ");
				int respuesta = int.Parse(Console.ReadLine());
				Console.WriteLine("═════════════════════════════════════════════════════════════════════════════");
				Console.WriteLine("");
				
				
				
				while (respuesta != 3)
				{
					if (respuesta == 1)
					{
						Console.WriteLine("═════════════════════════════════════════════════════════════════════════════");
						Console.WriteLine("BUSCAR POR JEFE");
						Console.WriteLine("═════════════════════════════════════════════════════════════════════════════");
						Console.WriteLine("");
						
						MostrarJefesDeObraNombreLegajo(empresa.ListaJefesDeObra);
						
						Console.WriteLine("");
						Console.WriteLine("═════════════════════════════════════════════════════════════════════════════");
						Console.Write("Inserte el legajo del jefe del grupo que desea buscar: ");
						int jefelegajo = int.Parse(Console.ReadLine());
						Console.WriteLine("═════════════════════════════════════════════════════════════════════════════");
						Console.WriteLine("");
						Console.WriteLine("═════════════════════════════════════════════════════════════════════════════");
						Console.WriteLine("INTEGRANTES DEL GRUPO: ");
						Console.WriteLine("═════════════════════════════════════════════════════════════════════════════");
						Console.WriteLine("");
						
						JefeDeObra jefe = empresa.BuscarJefe (jefelegajo);
						
						if (jefe.GrupoObrero != null)
						{
							MostrarListaIntegrantesPorJefe(jefelegajo,empresa.ListaJefesDeObra,empresa.ListaGrupoObreros);
						}
						else
							Console.WriteLine ("Este jefe no esta asignado a ningún grupo.");
						
						
						
						Console.WriteLine("");
					}
					else if (respuesta == 2)
					{
						Console.WriteLine("═════════════════════════════════════════════════════════════════════════════");
						Console.WriteLine("BUSCAR POR GRUPO");
						Console.WriteLine("═════════════════════════════════════════════════════════════════════════════");
						Console.WriteLine();
						
						MostrarListaGruposObrerosCodigo(empresa.ListaGrupoObreros);
						
						
						Console.WriteLine();
						Console.WriteLine("═════════════════════════════════════════════════════════════════════════════");
						Console.Write("Inserte el código del grupo que desea buscar (1-8): ");
						int codigoobra = int.Parse(Console.ReadLine());
						Console.WriteLine("═════════════════════════════════════════════════════════════════════════════");
						while (codigoobra < 1 || codigoobra > 8){
							Console.WriteLine("");
							Console.WriteLine("═════════════════════════════════════════════════════════════════════════════");
							Console.WriteLine("Código" + codigoobra + "incorrecto. Ingrese el código de un grupo.");
							Console.WriteLine("═════════════════════════════════════════════════════════════════════════════");
							Console.Write("Ingrese el código de un grupo: ");
							codigoobra = int.Parse(Console.ReadLine());
						}
						Console.WriteLine("");
						Console.WriteLine("═════════════════════════════════════════════════════════════════════════════");
						Console.WriteLine("");
						Console.WriteLine("Integrantes del grupo:\n ");
						Console.WriteLine("═════════════════════════════════════════════════════════════════════════════");
						Console.WriteLine("");
						
						
						MostrarListaIntegrantesPorGrupo(codigoobra,empresa.ListaGrupoObreros);
						
						Console.WriteLine("");
					}
					else
					{
						Console.WriteLine("");
						Console.WriteLine("═════════════════════════════════════════════════════════════════════════════");
						Console.WriteLine("Respuesta inválida.");
						Console.WriteLine("═════════════════════════════════════════════════════════════════════════════");
						Console.WriteLine("");
					}
					Console.WriteLine("═════════════════════════════════════════════════════════════════════════════");
					Console.WriteLine("MOSTRAR LOS INTEGRANTES DE UN GRUPO");
					Console.WriteLine("═════════════════════════════════════════════════════════════════════════════");
					Console.WriteLine("");
					Console.WriteLine("1)Buscar por jefe.");
					Console.WriteLine("2)Buscar por código de grupo.");
					Console.WriteLine("3)Salir.");
					Console.WriteLine("");
					Console.WriteLine("═════════════════════════════════════════════════════════════════════════════");
					Console.Write("Ingrese una opción: ");
					respuesta = int.Parse(Console.ReadLine());
					Console.WriteLine("═════════════════════════════════════════════════════════════════════════════");
					Console.WriteLine("");
				}
				
			}
			catch (OverflowException)
			{
				Console.WriteLine ("ERROR: El número ingresado está fuera de los límites permitidos. Por favor, introduzca un número válido.");
			}
			catch (FormatException)
			{
				Console.WriteLine ("ERROR: Entrada no válida. Por favor, ingresa un número entero válido.");
				
			}
			catch (Exception)
			{
				Console.WriteLine ("ERROR: Se produjo un error inesperado. Por favor, intente nuevamente.");
			}

			
		}
		public static void MostrarListaIntegrantesPorJefe(int legajoJefe, ArrayList listaJefes,ArrayList listaGrupos){
			
			foreach (JefeDeObra elem in listaJefes)
			{
				if (legajoJefe == elem.NumeroLegajo)
				{
					elem.Mostrar();

					foreach (GrupoObreros elem2 in listaGrupos)
					{
						if (elem2.JefeObra == elem)
							
							elem2.ImprimirIntegrantes();
					}
				}

			}
		}
		public static void MostrarListaIntegrantesPorGrupo(int codigo,ArrayList ListaGrupos){
			
			foreach (GrupoObreros elem in ListaGrupos)
			{

				if (codigo == elem.NumeroGrupo)
				{
					if (elem.JefeObra != null)
					{
						
						elem.JefeObra.Mostrar();
					}
					else
					{
						Console.WriteLine("Sin jefe de obra asignado.");
					}

					Console.WriteLine("");

					if (elem.ListaIntregrantes.Count > 0)
					{
						Console.WriteLine ("Obrero/s: ");
						elem.ImprimirIntegrantes();
					}
					else
					{
						Console.WriteLine("Sin obreros asignados.");
					}
				}

			}
		}
		
		//OPCIÓN H: SUBMENÚ
		public static void CaseHSubMenu(EmpresaConstructora empresa){
			Console.WriteLine("═════════════════════════════════════════════════════════════════════════════");
			Console.WriteLine("MOSTRAR OBRAS FINALIZADAS DE TIPO...");
			Console.WriteLine("═════════════════════════════════════════════════════════════════════════════");
			Console.WriteLine("");
			Console.WriteLine("Tipos de obras:");
			Console.WriteLine("═════════════════════════════════════════════════════════════════════════════");
			Console.WriteLine("-construcción");
			Console.WriteLine("-remodelación");
			Console.WriteLine("-ampliación");
			Console.WriteLine("-demolición");
			Console.WriteLine("-reparación\n");
			Console.WriteLine("═════════════════════════════════════════════════════════════════════════════");
			try{
				Console.Write("Ingrese el tipo de obra que quiera visualizar: ");
				string TipoObra = Console.ReadLine().ToLower();

				while (TipoObra != "construcción" && TipoObra != "construccion" && TipoObra != "remodelación" && TipoObra != "remodelacion" && TipoObra != "ampliación" && TipoObra != "ampliacion" && TipoObra != "demolición" && TipoObra != "demolicion" && TipoObra != "reparación" && TipoObra != "reparacion")
				{
					Console.WriteLine("Tipo de obra no disponible. Por favor, ingrese un tipo de obra disponible.");
					Console.Write("Ingrese el tipo de obra: ");
					TipoObra = Console.ReadLine().ToLower();
				}
				MostrarObrasDeTipo_(empresa.ListaObrasFinalizadas,0,TipoObra);
			}
			catch (FormatException){
				Console.WriteLine ("Error: Entrada no válida.");
			}
			catch (Exception){
				Console.WriteLine ("Se produjo un error inesperado. Por favor, intente nuevamente.");
			}
			
		}
		public static void MostrarObrasDeTipo_(ArrayList lista, int pos, string tipoDeObra)
		{
			if (pos < lista.Count)
			{
				Obra obra = (Obra)lista[pos];
				if (obra.TipoDeObra == tipoDeObra)
				{
					obra.Mostrar();
				}

				MostrarObrasDeTipo_(lista, pos + 1, tipoDeObra);





			}
		}
		
		//OPCIÓN I: SUBMENÚ
		public static void CaseISubMenu(EmpresaConstructora empresa){
			Console.WriteLine("═════════════════════════════════════════════════════════════════════════════");
			Console.WriteLine("MOSTRAR OBRAS EN EJECUCIÓN DE TIPO...");
			Console.WriteLine("═════════════════════════════════════════════════════════════════════════════");
			Console.WriteLine("");
			Console.WriteLine("Tipos de obras:");
			Console.WriteLine("═════════════════════════════════════════════════════════════════════════════");
			Console.WriteLine("-construcción");
			Console.WriteLine("-remodelación");
			Console.WriteLine("-ampliación");
			Console.WriteLine("-demolición");
			Console.WriteLine("-reparación\n");
			Console.WriteLine("═════════════════════════════════════════════════════════════════════════════");
			try{
				Console.Write("Ingrese el tipo de obra que quiera visualizar: ");
				string TipoObraEjec = Console.ReadLine().ToLower();

				while (TipoObraEjec != "construcción" && TipoObraEjec != "construccion" && TipoObraEjec != "remodelación" && TipoObraEjec != "remodelacion" && TipoObraEjec != "ampliación" &&TipoObraEjec != "ampliacion" && TipoObraEjec != "demolición" && TipoObraEjec != "demolicion" && TipoObraEjec != "reparación"&& TipoObraEjec != "reparacion")
				{
					Console.WriteLine("Tipo de obra no disponible. Por favor, ingrese un tipo de obra disponible.");
					Console.Write("Ingrese el tipo de obra: ");
					TipoObraEjec = Console.ReadLine().ToLower();
				}
				
				
				MostrarObrasDeTipo_(empresa.ListaObrasEnEjecucion,0,TipoObraEjec);
			}
			catch (FormatException){
				Console.WriteLine ("Error: Entrada no válida.");
			}
			catch (Exception){
				Console.WriteLine ("Se produjo un error inesperado. Por favor, intente nuevamente.");
			}
			//            public static void MostrarObrasDeTipo_(ArrayList lista, int pos, string tipoDeObra){
//
			//            if (pos < lista.Count)
			//            {
			//                Obra obra = (Obra)lista[pos];
			//                if (obra.TipoDeObra == tipoDeObra)                                             Se utiliza esta funcion
			//                {
			//                    obra.mostrar();
			//                }
//
			//                MostrarObrasDeTipo_(lista, pos + 1, tipoDeObra);
//
//
//
//
//
			//            }
		}
		
		//OPCIÓN J: SUBMENÚ
		public static void CaseJSubMenu(EmpresaConstructora empresa){
			Console.WriteLine("═════════════════════════════════════════════════════════════════════════════");
			Console.WriteLine("MOSTRAR OBRAS POR PRECIO DE FORMA ORDENADA");
			Console.WriteLine("═════════════════════════════════════════════════════════════════════════════");
			Console.WriteLine("");
			Console.WriteLine("[1] Obras en Ejecución.");
			Console.WriteLine("[2] Obras Finalizadas.");
			Console.WriteLine("");
			try{
				Console.Write("¿Desea visualizar las Obras en Ejecución o las Obras Finalizadas?: ");
				int opcionj=int.Parse( Console.ReadLine());
				
				while(opcionj != 1 && opcionj != 2){
					Console.WriteLine("[1] Obras en Ejecución.");
					Console.WriteLine("[2] Obras Finalizadas.");
					Console.Write("Por favor ingrese una opción valida: ");
					opcionj=int.Parse(Console.ReadLine());
					
				}
				if( opcionj == 1){
					OrdenarObraPrecio(empresa.ListaObrasEnEjecucion);
					MostrarListaObrasEnEjecucionConGrupo(empresa.ListaObrasEnEjecucion);
				}
				if( opcionj ==2){
					OrdenarObraPrecio(empresa.ListaObrasFinalizadas);
					empresa.MostrarListaObrasFinalizadas();
				}
			}
			catch (FormatException){
				Console.WriteLine ("ERROR: Entrada no válida.");
			}
			catch (Exception){
				
				Console.WriteLine ("Se produjo un error inesperado. Por favor, intente nuevamente.");
			}
		}
		public static void OrdenarObraPrecio(ArrayList lista){
			
			for (int i = 0; i < lista.Count; i++)
			{
				for (int j = i + 1; j < lista.Count; j++)
				{
					Obra obra = (Obra)lista[i];
					Obra obra2 = (Obra)lista[j];

					if (obra.Costo > obra2.Costo)
					{
						lista[i] = obra2;
						lista[j] = obra;
					}
				}
			}

		}
	}
}

