using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CatalogoProducto
    {
        public int Id { get; set; }
        public string NombreCategoria { get; set; }
        public string TipoCategoria { get; set; }
        public string Especificacion { get; set; }
        public string Detalles { get; set; }

        public CatalogoProducto()
        {
            Id = 0;
            NombreCategoria     = "";
            TipoCategoria       = "";
            Especificacion      = "";
            Detalles            = "";
        }


        public int Create()
        {
            try
            {
                // Producto capa de datos          //Capa de negocio.
                //Clase con contructores.
                //CapaDeNegocio..
                //p cada de datos                Clase //Producto()
                CapaDatos.CatalogoProducto y = new CapaDatos.CatalogoProducto();


                y.nombreCategoria   = this.NombreCategoria;
                y.tipoCategoria     = this.TipoCategoria;
                y.especificacion    = this.Especificacion;
                y.detalles          = this.Detalles;


                CommonBC.ModeloVentas.CatalogoProducto.Add(y);
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
                CapaDatos.CatalogoProducto y = CommonBC.ModeloVentas.
                    CatalogoProducto.First(x => x.id == this.Id);


               
                this.NombreCategoria = y.nombreCategoria ;
                this.TipoCategoria =   y.tipoCategoria ;
                this.Especificacion = y.especificacion ;
                this.Detalles= y.detalles ;


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
                CapaDatos.CatalogoProducto y = CommonBC.ModeloVentas.CatalogoProducto.
                                                First(x => x.id == Id);
                y.id                 = this.Id;
                y.nombreCategoria    = this.NombreCategoria;
                y.tipoCategoria      = this.TipoCategoria;
                y.especificacion     = this.Especificacion;
                y.detalles           = this.Detalles;

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
                CapaDatos.CatalogoProducto y = CommonBC.ModeloVentas.CatalogoProducto.
                                                First(x => x.id == Id);
                CommonBC.ModeloVentas.CatalogoProducto.Remove(y);
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
