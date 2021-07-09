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
    public class Producto : IProducto
    {
        public int Create(int idProveedor, int idCategoria, int codigoBarra, int precio, int stock, int Stock_critico, string Descripcion)
        {
            CapaNegocio.Producto y = new CapaNegocio.Producto();

            y.IdProveedor = idProveedor;

            y.IdCatalogoProducto = idCategoria;

            y.CodigoBarra = codigoBarra;

            y.Precio = precio;

            y.Stock = stock;

            y.StockCritico = Stock_critico;

            y.Marca = Descripcion;


            return y.Create();
        }

        public int Delete(int id)
        {

            CapaNegocio.Producto x = new CapaNegocio.Producto();

            x.Id = id;

            return x.Delete();
        }

        

        public CapaNegocio.Producto Read(int id)
        {
            CapaNegocio.Producto x = new CapaNegocio.Producto();

            x.Id = id;

            //Convierte a entero la salida y Devouelve 1 si ocurrio la lectura y nulo si no o (0):
            if (x.Read() == 1)
                return x;


            return null;
        }

        public int Update(int id, int idProveedor, int idCategoria, int codigoBarra, int precio, int stock, int Stock_critico, string Descripcion)
        {

            CapaNegocio.Producto y = new CapaNegocio.Producto();


            y.Id            = id;
            y.IdProveedor   = idProveedor;

            y.IdCatalogoProducto   = idCategoria;

            y.CodigoBarra   = codigoBarra;

            y.Precio        = precio;

            y.Stock         = stock;

            y.StockCritico = Stock_critico;

            y.Marca         = Descripcion;


            return y.Update();

        }
    }
}
