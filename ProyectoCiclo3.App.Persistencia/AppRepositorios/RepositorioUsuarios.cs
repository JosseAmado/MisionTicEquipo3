using System.Collections.Generic;
using ProyectoCiclo3.App.Dominio;
using System.Linq;
using System;
 
namespace ProyectoCiclo3.App.Persistencia.AppRepositorios
{
    public class RepositorioUsuarios
    { 
        
        private readonly AppContext _appContext = new AppContext();   

        public IEnumerable<Usuario> GetAll()
        {
           return _appContext.Usuarios;
        }
 
        public Usuario GetWithId(int id){
            return _appContext.Usuarios.Find(id);
        }

        // public Usuario Update(Usuario newUsuario){
        //     var encomienda = _appContext.Usuarios.Find(newUsuario.id);
        //     if(encomienda != null){
        //         encomienda.descripcion = newUsuario.descripcion;
        //         encomienda.peso = newUsuario.peso;
        //         encomienda.tipo = newUsuario.tipo;
        //         encomienda.presentacion = newUsuario.presentacion;
        //         //Guardar en base de datos
        //          _appContext.SaveChanges();
        //     }
        // return encomienda;
        // }

        // public Usuario Create(Usuario newUsuario)
        // {
        //    var addUsuario = _appContext.Usuarios.Add(newUsuario);
        //     //Guardar en base de datos
        //     _appContext.SaveChanges();
        //     return addUsuario.Entity;
        // }

        // public Usuario Delete(int id)
        // {
        //     var encomienda = _appContext.Usuarios.Find(id);
        // if (encomienda != null){
        //     _appContext.Usuarios.Remove(encomienda);
        //     //Guardar en base de datos
        //     _appContext.SaveChanges();
        // }
        //  return null;  
        // }

    }
}
