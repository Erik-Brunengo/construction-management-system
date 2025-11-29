using System;
using System.Collections;

namespace Proyecto_uno
{
    public class EmpresaConstructora
    {
        
        //Variables de instancia.
        private string nombreEmpresaConstuctora;
        private string ubicacion;

        private ArrayList listaObrasEnEjecucion;
        private ArrayList listaObrasFinalizadas;
        private ArrayList listaGrupoObreros;
        private ArrayList listaObrero;
        private ArrayList listaJefesDeObra;

        //Constructor.
        public EmpresaConstructora(string nombreEmpresaConstuctora, string ubicacion)
        {
            this.nombreEmpresaConstuctora = nombreEmpresaConstuctora;
            this.ubicacion = ubicacion;
            listaObrasEnEjecucion = new ArrayList();
            listaObrasFinalizadas = new ArrayList();
            listaGrupoObreros = new ArrayList();
            listaObrero = new ArrayList();
            listaJefesDeObra = new ArrayList();
        }

        //Propiedades.
        public string NombreEmpresaConstructora { get { return nombreEmpresaConstuctora; } set { nombreEmpresaConstuctora = value; } }
        public string Ubicacion { get { return ubicacion; } set { ubicacion = value; } }
        public ArrayList ListaObrasEnEjecucion { get { return listaObrasEnEjecucion; } }
        public ArrayList ListaObrasFinalizadas { get { return listaObrasFinalizadas; } }
        public ArrayList ListaGrupoObreros { get { return listaGrupoObreros; } }
        public ArrayList ListaObrero { get { return listaObrero; } }
        public ArrayList ListaJefesDeObra { get { return listaJefesDeObra; } }

        //Métodos.
        public void MostrarEmpresa(){
            Console.WriteLine("Nombre de la empresa: "+ nombreEmpresaConstuctora);
            Console.WriteLine("Ubicacion de la empresa: "+ ubicacion);
        }
        
        //Lista Obras En Ejecucion
        
        public void AgregarObraEnEjecucion(Obra obrita){
            
            listaObrasEnEjecucion.Add(obrita);
            
        }
        
        public Obra BuscarObra(int codigo)
        {

            foreach (Obra elem in listaObrasEnEjecucion)
            {
                if (elem.CodigoInterno == codigo)
                    return elem;
            }
            return null;
        }
        
        public void EliminarObraEnEjecucion(Obra obrita){
            listaObrasEnEjecucion.Remove(obrita);
        }
        
        public void MostrarListaObrasEnEje(){
            foreach (Obra elem in listaObrasEnEjecucion){
                elem.Mostrar();
            }
        }
        
        //Lista Obras Finalizadas        
        
        public void AgregarObraFinalizada(Obra obrita){
            listaObrasFinalizadas.Add(obrita);
        }
        
        public void EliminarObraFinalizada(Obra obrita){
            listaObrasFinalizadas.Remove(obrita);
        }
        
        public void MostrarListaObrasFinalizadas()
        {
            foreach(Obra elem in listaObrasFinalizadas)
            {
                elem.Mostrar();
            }
        }
        
        //Lista Grupo Obreros
        
        public void AgregarGrupos(GrupoObreros grupo)
        {
            listaGrupoObreros.Add(grupo);
        }
        
        public GrupoObreros BuscarGrupo(int codigogrupo){
            foreach( GrupoObreros elem in listaGrupoObreros){
                if(elem.NumeroGrupo ==codigogrupo){
                return elem;
                }
            }
            return null;
        }
        
        public void EliminarGrupos(GrupoObreros grupo){
            listaGrupoObreros.Remove(grupo);
        }
        
        public void MostrarListaGRupos(){
            foreach (GrupoObreros elem in listaGrupoObreros){
                elem.Mostrar();
            }
        }
        
        //Lista Obreros
        
        public void AgregarObrero(Obrero obre)
        {
            listaObrero.Add(obre);
        }
        
        public Obrero BuscarObrero(int legajo)
        {
            foreach (Obrero obrero in listaObrero)
            {
                if (obrero.NumeroLegajo == legajo)
                {
                    return obrero;
                }
            }
            return null;
        }     
        public void EliminarObrero(Obrero obrero){
        
            listaObrero.Remove (obrero);
        }
        
        public void MostrarListaObreros(){
            foreach (Obrero elem in listaObrero){
                elem.Mostrar();                                            
                foreach (GrupoObreros grupo in listaGrupoObreros)
                {
                	foreach (Obrero obrero in grupo.ListaIntregrantes)
                	{
                		if (elem == obrero)
                		{
                			Console.WriteLine (" Grupo asignado: " + grupo.NumeroGrupo);
                		}
                	}
                }
                                
                Console.WriteLine("~");
                Console.WriteLine();              
            }
        }     
        //Lista Jefe de Obra
        
        public void AgregarJefeDeObra(JefeDeObra jefe)
        {
            
            listaObrero.Add(jefe);
            listaJefesDeObra.Add(jefe);

        }
        
        public JefeDeObra BuscarJefe(int legajo)
        {
            foreach (JefeDeObra jefe in listaJefesDeObra)
            {
                if (jefe.NumeroLegajo == legajo)
                {
                    return jefe;
                }
            }
            return null;
        }
        
        public void EliminarJefeEmpresa(JefeDeObra jefe)
        {
            listaJefesDeObra.Remove(jefe);
        }
        
        public void MostrarJefesDeObra()
        {
            foreach (JefeDeObra elem in listaJefesDeObra)
            {
                elem.Mostrar();

            }
            Console.WriteLine("_");
        }
                
}
}
