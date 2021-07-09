using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class ColeccionesMusic
    {
        private List<Proveedor> Listado(List<CapaDatos.Provedor> productoDeCapaDeDatos)
        {
            List<Proveedor> listado = new List<Proveedor>();
            foreach (CapaDatos.Provedor p in productoDeCapaDeDatos)
            {
                Proveedor productoNegocio = new Proveedor();
                productoNegocio.Id = p.id;
                productoNegocio.Nombre = p.nombre;
                productoNegocio.Contacto = p.contacto;
                productoNegocio.Direccion = p.direccion;
                productoNegocio.NombreEmpresa = p.nombreEmpresa;
                

                listado.Add(productoNegocio);
            }
            return listado;

        }

        public List<Proveedor> ReadAll()
        {
            CommonBC.ModeloVentas = null;
            var listado = CommonBC.ModeloVentas.Provedor;
            return Listado(listado.ToList());
        }


       



        //private List<Producto> List(List<CapaDatos.Producto> productoDeCapaDeDatos)
        //{
        //List<Producto> listado = new List<Producto>();
        //foreach (CapaDatos.Producto p in productoDeCapaDeDatos)
        //{
        // Producto productoNegocio = new Producto();


        // listado.Add(productoNegocio);
        //
        // return listado;

    }


}
//}   
