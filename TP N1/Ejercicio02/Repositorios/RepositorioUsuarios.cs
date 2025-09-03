using Ejercicio02.Clases;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02.Repositorios
{
    public class RepositorioUsuarios
    {
        private readonly List<Usuario> listaUsuarios = [];

        public void AgregarUsuario(Usuario usuario)
        {
            int codigo = listaUsuarios.Count + 1;
            usuario.Codigo = codigo;

            listaUsuarios.Add(usuario);
        }

        public IReadOnlyCollection<Usuario> ListarUsuarios()
        {
            return listaUsuarios;
        }

        public bool AgregarContratoPaquete(string usuarioSeleccionado, Paquete paquete)
        {
            Usuario usuario = listaUsuarios.First(x => x.Nombre == usuarioSeleccionado);

            if (!usuario.PaquetesContratados.Contains(paquete))
            {
                usuario.PaquetesContratados.Add(paquete);
                return true;
            }

            return false;
        }
    }
}
