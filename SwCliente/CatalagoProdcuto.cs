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
    public class CatalagoProdcuto : ICatalagoPro
    {
        public int Create(string nombreCategoria, string tipoCategoria, string especificacion, string detalles)
        {
            CapaNegocio.CatalogoProducto y = new CapaNegocio.CatalogoProducto();

            y.NombreCategoria = nombreCategoria;

            y.TipoCategoria = tipoCategoria;

            y.Especificacion = especificacion;

            y.Detalles = detalles;

            return y.Create();
        }

        public int Delete(int id)
        {
            CapaNegocio.CatalogoProducto x = new CapaNegocio.CatalogoProducto();

            x.Id = id;

            return x.Delete();
        }

        public CatalogoProducto Read(int id)
        {
            CapaNegocio.CatalogoProducto x = new CapaNegocio.CatalogoProducto();

            x.Id = id;

            //Convierte a entero la salida y Devouelve 1 si ocurrio la lectura y nulo si no o (0):
            if (x.Read() == 1)
                return x;


            return null;
        }

        public int Update(int id, string nombreCategoria, string tipoCategoria, string especificacion, string detalles)
        {

            CapaNegocio.CatalogoProducto y = new CapaNegocio.CatalogoProducto();

            y.Id = id;

            y.NombreCategoria = nombreCategoria;

            y.TipoCategoria = tipoCategoria;

            y.Especificacion = especificacion;

            y.Detalles = detalles;

            return y.Update();
        }
    }
}
