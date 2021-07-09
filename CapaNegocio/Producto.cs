using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Producto
    {
        public int Id { get; set; }
        public int IdProveedor { get; set; }
        public int IdCatalogoProducto { get; set; }
        public int CodigoBarra { get; set; }
        public int Precio { get; set; }
        public int Stock { get; set; }
        public int StockCritico { get; set; }
        public string Marca { get; set; }

        public Producto()
        {
            Id = 0;
            IdProveedor = 0;
            IdCatalogoProducto = 0;
            CodigoBarra = 0;
            Precio = 0;
            Stock = 0;
            StockCritico = 0;
            Marca= "";
        }

        // crud
        public int Create()
        {
            try
            {
                CapaDatos.Producto p = new CapaDatos.Producto();

               
                p.idProveedor = this.IdProveedor;
                p.idCatalogoProducto = this.IdCatalogoProducto;
                p.codigoBarra = this.CodigoBarra;
                p.precio = this.Stock;
                p.stock = this.Stock;
                p.stock = this.StockCritico;
                p.marca = this.Marca;
                CommonBC.ModeloVentas.Producto.Add(p);
                return CommonBC.ModeloVentas.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return -1;
            }
        }
        public int Read()
        {
            try
            {
                CommonBC.ModeloVentas = null;
                CapaDatos.Producto p = CommonBC.ModeloVentas.
                                            Producto.First(x => x.id == this.Id);
                this.IdProveedor = p.idProveedor;
                this.IdCatalogoProducto = p.idCatalogoProducto ;
                this.CodigoBarra = p.codigoBarra ;
                this.Precio =  p.precio;
                this.Stock = p.stock ;
                this.StockCritico = p.stock;
                p.marca = this.Marca;


                return 1;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return -1;
            }
        }

        public int Update()
        {
            try
            {
                CapaDatos.Producto p = CommonBC.ModeloVentas.
                                            Producto.First(x => x.id == this.Id);
                p.idProveedor = this.IdProveedor;
                p.idCatalogoProducto = this.IdCatalogoProducto;
                p.codigoBarra = this.CodigoBarra;
                p.precio = this.Stock;
                p.stock = this.Stock;
                p.stock = this.StockCritico;
                p.marca = this.Marca;

                CommonBC.ModeloVentas.SaveChanges();

                return CommonBC.ModeloVentas.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return -1;
            }
        }
        public int Delete()
        {
            try
            {
                CapaDatos.Producto p = CommonBC.ModeloVentas.Producto.
                                First(x => x.id == Id);

                CommonBC.ModeloVentas.Producto.Remove(p);
                return CommonBC.ModeloVentas.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return -1; // negativo error
            }
        }
    }
}
