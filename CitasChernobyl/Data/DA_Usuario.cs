using CitasChernobyl.Models;

namespace CitasChernobyl.Data
{
    public class DA_Usuario
    {

        public List<Usuario> ListaUsuario() {

            return new List<Usuario>
            {
                new Usuario{ Nombre ="Leonardo", Correo = "administrador@gmail.com", Clave= "12345" , Roles = new string[]{"Administrador"} },
                new Usuario{ Nombre ="Fransisco", Correo = "empleado1@gmail.com", Clave= "12345" , Roles = new string[]{"Empleado"} },
                new Usuario{ Nombre ="Cristian", Correo = "empleado2@gmail.com", Clave= "12345" , Roles = new string[]{"Empleado"} },
                new Usuario{ Nombre ="Alexander", Correo = "cliente1@gmail.com", Clave= "12345" , Roles = new string[]{"Cliente"} },
                new Usuario{ Nombre ="Milton", Correo = "cliente2@gmail.com", Clave= "12345" , Roles = new string[]{"Cliente"} }

            };

        }

        public Usuario ValidarUsuario(string _correo, string _clave) {

            return ListaUsuario().Where(item => item.Correo == _correo && item.Clave == _clave).FirstOrDefault();

        }

    }
}
