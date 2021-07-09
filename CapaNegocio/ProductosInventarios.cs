using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    class ProductosInventarios
    {
        public int Id { get; set; }
        public int IdFactura { get; set; }
        public int IdVentas { get; set; }

        public ProductosInventarios()
        {
            Id = 0;
            IdFactura = 0;
            IdVentas = 0;

                  
        }
        //listar
        public int Create()
        {
            try
            {
                // Producto capa de datos          //Capa de negocio.
                //Clase con contructores.
                //CapaDeNegocio..
                //p cada de datos                Clase //Producto()
                CapaDatos.ProductosInventarios pi = new CapaDatos.ProductosInventarios();

              
                pi.idFactura = this.IdFactura;
                pi.idVentas = this.IdVentas;
               

                CommonBC.ModeloVentas.ProductosInventarios.Add(pi);
                return CommonBC.ModeloVentas.SaveChanges();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine();
                return -1;
            }
        }
        public int Read()
        {
            try

            {
                //where                  //Busca variable en la base de datos
                CapaDatos.ProductosInventarios p = CommonBC.ModeloVentas.
                    ProductosInventarios.First(x => x.id == this.Id);

                this.IdFactura = p.idFactura;
                this.IdVentas = p.idVentas;
               





                //Si se crea un producto devulevo 1.
                return 1;

            }

            catch (Exception ex)

            {

                Console.WriteLine(ex.Message);

                return -1;
                //si no devuleve -1.

            }
        }

        public int Update()
        {
            try
            {   //Rescata fila de base de datos, devuelve un pobjeto producto  que se almcena en la variable p
                CapaDatos.ProductosInventarios pi = CommonBC.ModeloVentas.ProductosInventarios.
                                                First(x => x.id == Id);
               
                pi.idFactura = this.IdFactura;
                pi.idVentas = this.IdVentas;

                return CommonBC.ModeloVentas.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return -1; // negativo error
            }
        }
        //Busca La clave primaria y la elimina segun lo ingresado por el cliente.
        public int Delete()
        {
            try
            {
                CapaDatos.ProductosInventarios pi = CommonBC.ModeloVentas.ProductosInventarios.
                                                First(x => x.id == Id);
                CommonBC.ModeloVentas.ProductosInventarios.Remove(pi);
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
