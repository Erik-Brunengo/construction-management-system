using System;
namespace Proyecto_uno
{
    
    public class OcurrioUnErrorException:Exception
    {
        public string motivo;
        
        public OcurrioUnErrorException(string m)
        {
            this.motivo=m;
        }
    }
}