using System;
using System.Collections;

namespace Proyecto_uno
{


    public class GrupoObreros
    {
        //Variables de Instancias.
        private int numeroGrupo;
        private Obra codigoObra;// clase obra
        private ArrayList listaIntegrantes;//clase  obrero
        private JefeDeObra jefeObra;//clase jefedeobra
        private Obra [] listaDeObras;//clase obra
        private int cantidadObras;
        
        //Constructor.
        public GrupoObreros(int numeroGrupo,Obra codigoObra, JefeDeObra jefeObra){
        
            this.numeroGrupo=numeroGrupo;
            listaIntegrantes = new ArrayList();
            this.jefeObra = null;
            this.codigoObra=null;
            listaDeObras = new Obra [3];
        }
        
        //Propiedades.
        public int NumeroGrupo{get{return numeroGrupo;}set{numeroGrupo=value;}}
        public Obra CodigoObra { get { return codigoObra; } set { codigoObra = value; } }
        public ArrayList ListaIntregrantes { get { return listaIntegrantes; } }
        public JefeDeObra JefeObra { get { return jefeObra; } set { jefeObra = value; } }
        public Obra [] ListaDeObras{get {return listaDeObras;}}
        public int CantidadObras{set {cantidadObras = value;}get {return cantidadObras;}}

        //Metodos.
        public void Mostrar(){
        
            Console.WriteLine("═════════════════════════════════════════════════════════════════════════════");
            Console.WriteLine("Grupo: " + numeroGrupo);
            Console.WriteLine("Código del grupo: " + numeroGrupo);
            int cantidadIntegrantes = listaIntegrantes.Count;
            Console.WriteLine("Cantidad de integrantes: " + cantidadIntegrantes);
            if (jefeObra != null)
                Console.WriteLine("Jefe de obra asignado: -" + jefeObra.Nya + " (Legajo: " + jefeObra.NumeroLegajo +")\n");
            else
                Console.WriteLine("Sin jefe de obra asignado.\n");
               
         }
        
        //Lista Integrantes.
        
        public void AsignarObrero(Obrero obre)//se le agrega un obrero a la lista de integrantes
        {
            ListaIntregrantes.Add(obre);
        }
        
        public Obrero BuscarObrero (int legajo)
        {
            foreach (Obrero obrero in listaIntegrantes)
            {
                if (obrero.NumeroLegajo == legajo)
                {
                    return obrero;
                }
            }
            return null;
        }
        
        public void EliminarObrero(Obrero obrero){
            

            for (int i = listaIntegrantes.Count - 1; i >= 0; i--){
                
    
                Obrero elem = (Obrero)listaIntegrantes[i];
                if (elem.NumeroLegajo == obrero.NumeroLegajo){
        
                    listaIntegrantes.RemoveAt(i); // Elimina el obrero del grupo
                    Console.WriteLine("Se ha eliminado el obrero con legajo " + obrero.NumeroLegajo + " del grupo.");
                    return; // Salir después de eliminar
                }
            }
            Console.WriteLine("No se encontró el obrero con legajo " + obrero.NumeroLegajo + " en el grupo.");
}
        
        public void eliminarObrero (Obrero obrero){
        
            foreach (Obrero obre in listaIntegrantes)
            {
                if (obre == obrero)
                {
                    listaIntegrantes.Remove (obrero);
                    break;
                }
            }
        }
        
        public void ImprimirIntegrantes()
        {
            foreach (Obrero elem in ListaIntregrantes)
            {
                elem.Mostrar();
                Console.WriteLine("~");
                Console.WriteLine();
            }
        }
        
        //Jefe de Obra
        
        public void AsignarJefeDeObra(JefeDeObra jefe){//se agrega el jefe a la obra
                                                     //se agrega jefe al grupo
            if (JefeObra == null)
            {
                JefeObra = jefe;
                jefe.GrupoObrero=this;
            }
            else
            {
                Console.WriteLine("_");
                throw new OcurrioUnErrorException("Este grupo de obreros ya dispone de un jefe de obra.");

            }
        }
        
        public void EliminarJefe(JefeDeObra jefe)
        {
            if (jefeObra != null)
            {
                
                if (jefeObra.NumeroLegajo == jefe.NumeroLegajo)
                {
                    jefeObra = null;
                }
            }
                
        }
        
        public void EliminarJefeGrupo(int codigo)
        {
            if (jefeObra != null)
            {
                if (JefeObra.NumeroLegajo == codigo)
                {
                    jefeObra = null;

                }
            }

        }
        
        //Lista de Obras
        
        public void AsignarObraAGrupo(Obra obra)
        {
            foreach(Obra elem in listaDeObras){
                if(elem != null && elem.CodigoInterno ==obra.CodigoInterno){
                    throw new OcurrioUnErrorException("La obra ya está asignada a este grupo.");
                }
            }
            if(cantidadObras <3){
                listaDeObras [cantidadObras] = obra;
                cantidadObras +=1;
                
            }
            else{
                throw new OcurrioUnErrorException("El grupo solo puede tener como maximo 3 obras");
            }
            
            
        }
        
        public void EliminarObraDelGrupo(Obra obrita){
            // verificar si la obra existe en la lista
                for (int i = 0; i < cantidadObras; i++){    
                if (listaDeObras[i] != null && listaDeObras[i].CodigoInterno == obrita.CodigoInterno){
                    // si encontra la obra, eliminarla
                    listaDeObras[i] = null; // eliminar referencia a la obra

                    // desplazar las obras hacia adelante
                    for (int j = i; j < cantidadObras - 1; j++){
                        listaDeObras[j] = listaDeObras[j + 1];
                    }
                    listaDeObras[cantidadObras - 1] = null; //limpiar el último elemento
                    cantidadObras--; // decrementar el contador de obras
                    Console.WriteLine("La obra: "+obrita.CodigoInterno +" ha sido eliminada del grupo "+numeroGrupo);
                    return;
                }
            }

            //si no se encuentra la obra
            throw new Exception("La obra no se encontró en el grupo.");
}
        
        public void MostrarObrasDelGrupo(){
            foreach(Obra elem in listaDeObras){
                elem.Mostrar();
            }
        }
        
   
}
}
