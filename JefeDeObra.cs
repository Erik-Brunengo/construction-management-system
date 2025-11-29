using System;
using System.Collections;

namespace Proyecto_uno
{
	public class JefeDeObra: Obrero
	{
		//Variables de Instancias.
		private double bonificacion;
		private GrupoObreros grupoObrero;

		//Constructor.

		public JefeDeObra(){}
		public JefeDeObra(double bonificacion, GrupoObreros grupoObrero, string nya, int dni, double sueldo, string cargo) : base(nya, dni, sueldo, cargo){
			
			this.bonificacion = bonificacion;
			this.grupoObrero = grupoObrero;

		}

		//Propiedades.
		public double Bonificacion { get { return bonificacion; } set { bonificacion = value; } }
		public GrupoObreros GrupoObrero { get { return grupoObrero; } set { grupoObrero = value; } }


		//Métodos.
		public override void Mostrar(){
			
			Console.WriteLine ("Jefe de obra: ");
			base.Mostrar();
			Console.WriteLine(" Bonificacion: "+ bonificacion);
			if (grupoObrero != null)
				Console.WriteLine (" Grupo asingado: " + grupoObrero.NumeroGrupo);
			if (grupoObrero == null)
				Console.WriteLine (" Sin grupo asignado.");
			Console.WriteLine("~");
			Console.WriteLine();
		}
		//Grupo Obrero
		
		public void AsignarGrupo(GrupoObreros grupito){
			if(grupito != null){
				grupoObrero= grupito;
			}
		}
		public void SacarGrupoObrero()
		{
			grupoObrero = null;
		}


	}
}
