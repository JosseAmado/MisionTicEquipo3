using System.Collections.Generic;
using ProyectoCiclo3.App.Dominio;
using System.Linq;
using System;
 
namespace ProyectoCiclo3.App.Persistencia.AppRepositorios
{
    public class RepositorioServicios
    {
        List<Servicio> servicios;
 
    public RepositorioServicios()
        {
            servicios= new List<Servicio>()
            {
                new Servicio{id=1,origen="",destino= ,fecha= "",fecha= "Caja",encomienda= ""},
                new Servicio{id=2,origen="",destino= ,fecha= "",fecha= "Caja",encomienda= ""},
                new Servicio{id=3,origen="",destino= ,fecha= "",fecha= "Caja",encomienda= ""}
            };
        }
 
        public IEnumerable<Servicio> GetAll()
        {
            return servicios;
        }
 
        public Servicio GetWithId(int id){
            return servicios.SingleOrDefault(e => e.id == id);
        }
    }
}
