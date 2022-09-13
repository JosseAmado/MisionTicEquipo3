using System.Collections.Generic;
using ProyectoCiclo3.App.Dominio;
using System.Linq;
using System;
 
namespace ProyectoCiclo3.App.Persistencia.AppRepositorios
{
    public class RepositorioUsuarios
    {
        List<Usuario> usuarios;
 
        public RepositorioUsuarios()
        {
            usuarios= new List<Usuario>()


            {
                new Usuario{id=1,nombre="camila",apellidos= "vasquez",direccion= "calle20",telefono= "312890",ciudad= "cali"},
                new Usuario{id=2,nombre="pedro",apellidos= "perez",direccion= "calle30",telefono= "312890",ciudad= "cali"},
                new Usuario{id=3,nombre="maia",apellidos= "montes",direccion= "calle70",telefono= "312890",ciudad= "cali"}
            };

           
        }
 
        public IEnumerable<Usuario> GetAll()
        {
            return usuarios;
        }
 
        public Usuario GetWithId(int id){
            return usuarios.SingleOrDefault(u => u.id == id);
        }
    }
}
   
