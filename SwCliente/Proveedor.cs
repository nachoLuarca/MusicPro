using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using CapaNegocio;

namespace SwCliente
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código y en el archivo de configuración a la vez.
    public class Proveedor : IProveedor
    {
        public int Create(string nombre, string contacto, string direccion, string nombreEmpresa)
        {
            CapaNegocio.Proveedor prov = new CapaNegocio.Proveedor();

            prov.Nombre = nombre;

            prov.Contacto = contacto;

            prov.Direccion = direccion;

            prov.NombreEmpresa = nombreEmpresa;

            return prov.Create();
        }

        public int Delete(int id)
        {
            CapaNegocio.Proveedor x = new CapaNegocio.Proveedor();

            x.Id = id;

            return x.Delete();
        }

        public List<CapaNegocio.Proveedor> Listar()
        {
            CapaNegocio.ColeccionesMusic vc = new ColeccionesMusic();
            return vc.ReadAll();
        }

        public CapaNegocio.Proveedor Read(int id)
        {
            CapaNegocio.Proveedor prov = new CapaNegocio.Proveedor();

            prov.Id = id;

            //Convierte a entero la salida y Devouelve 1 si ocurrio la lectura y nulo si no o (0):
            if (prov.Read() == 1)
                return prov;


            return null;
        }

        public int Update(int id, string nombre, string contacto, string direccion, string nombreEmpresa)
        {
            CapaNegocio.Proveedor prov = new CapaNegocio.Proveedor();

            prov.Id = id;

            prov.Nombre = nombre;

            prov.Contacto = contacto;

            prov.Direccion = direccion;

            prov.NombreEmpresa = nombreEmpresa;


            return prov.Update();
        }
    }
}
