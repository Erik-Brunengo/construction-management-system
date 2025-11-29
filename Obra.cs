using System;
using System.Collections;

namespace Proyecto_uno
{

    public class Obra
    {
        
        //Variables de Instancia
        private int codigoInterno;
        private string nombrePropietario;
        private int dniPropietario;
        private string tipoDeObra;
        private int estadoDeAvance;
        private double costo;
        private JefeDeObra jefeObra;
        private ArrayList gruposAsignados;
        private static int codig=0;
        
        //Constructor.
        public Obra(string nombrePropietario, int dniPropietario, string tipodeobra, int estadoavance, double costo, JefeDeObra jefeObra)
        {
            this.codigoInterno = ++codig;
            this.nombrePropietario = nombrePropietario;
            this.dniPropietario = dniPropietario;
            this.tipoDeObra = tipodeobra;
            this.estadoDeAvance = estadoavance;
            this.costo = costo;
            this.jefeObra = null;
            gruposAsignados= new ArrayList();
        }

        
        //Propiedades.
        public int CodigoInterno { get { return codigoInterno; } set { codigoInterno = value; } }
        public string NombrePropietario { get { return nombrePropietario; } set { nombrePropietario = value; } }
        public int DniPropietario { get { return dniPropietario; } set { dniPropietario = value; } }
        public string TipoDeObra { get { return tipoDeObra; } set { tipoDeObra = value; } }
        public int EstadoDeAvance { get { return estadoDeAvance; } set { estadoDeAvance = value; } }
        public double Costo { get { return costo; } set { costo = value; } }
        public JefeDeObra JefeObra { get { return jefeObra; } set { jefeObra = value; } }
        public ArrayList GruposAsignados{get{return gruposAsignados;}}
        public int Codig{get{return codig;}set{codig=value;}}
        
        //Métodos.
        public void Mostrar(){
            Console.WriteLine("~");
            Console.WriteLine("Obra: "+ codigoInterno);
            Console.WriteLine("Codigo de Obra: " + codigoInterno);
            Console.WriteLine("Nombre del Propietario: " + nombrePropietario);
            Console.WriteLine("Tipo de Obra: " + tipoDeObra);
            Console.WriteLine("Estado de Avance de la Obra: " + estadoDeAvance);
            Console.WriteLine("Costo de la Obra: "+ costo);
            Console.WriteLine("Cantidad de Grupos: "+ GruposAsignados.Count);
            if(jefeObra != null){
            Console.WriteLine("Jefe: "+ jefeObra.Nya);
            }
            if(jefeObra == null){
                Console.WriteLine("Jefe: Esta obra no tiene Jefe");
            }
            Console.WriteLine("~");
        }
        
        //Jefe Obra
        
        public void AsignarJefeDeObraObra(JefeDeObra jefe)
        {
            if (JefeObra == null)
            {
                JefeObra = jefe;
            }
        }
        
        public void EliminarJefe()
        {
            if (jefeObra != null)
            {
                jefeObra = null;
            }
        }
        
        //Grupos Asignados
        
        public void AgregarGrupo( GrupoObreros grupito)
        {
            gruposAsignados.Add(grupito);
        }
        
        public void EliminarGrupo(GrupoObreros grupito){
            gruposAsignados.Remove(grupito);
        }
        
        public void MostrarGruposAsignados(){
            foreach(GrupoObreros elem in gruposAsignados){
                elem.Mostrar();
            }
        }
        

    }
}
