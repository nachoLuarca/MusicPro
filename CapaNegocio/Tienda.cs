using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Tienda
    {

        public int Id { get; set; }
        public int IdContador { get; set; }
        public int IdAministrador { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Contacto { get; set; }
        public string Tiendcol { get; set; }

        public Tienda()
        {
            Id = 0;
            IdContador = 0;
            IdAministrador = 0;
            Nombre = "";
            Direccion = "";
            Contacto = "";
            Tiendcol = "";
        }

        public int Create()
        {
            try
            {
                // Producto capa de datos          //Capa de negocio.
                //Clase con contructores.
                //CapaDeNegocio..
                //p cada de datos                Clase //Producto()
                CapaDatos.Tienda x = new CapaDatos.Tienda();



                x.idContador = this.IdContador;
                x.idAministrador = this.IdAministrador;
                x.nombre = this.Nombre;
                x.direccion = this.Direccion;
                x.contacto = this.Contacto;
                x.tiendcol = this.Tiendcol;




                CommonBC.ModeloVentas.Tienda.Add(x);
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
                CapaDatos.Tienda y = CommonBC.ModeloVentas.
                    Tienda.First(x => x.id == this.Id);


                this.IdContador = y.idContador;
                this.IdAministrador = y.idAministrador ;
                this.Nombre = y.nombre ;
                this.Direccion =   y.direccion ;
                this.Contacto  = y.contacto ;
                this.Tiendcol = y.tiendcol ;



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
                CapaDatos.Tienda y = CommonBC.ModeloVentas.Tienda.
                                                First(x => x.id == Id);

                y.idContador = this.IdContador;
                y.idAministrador = this.IdAministrador;
                y.nombre = this.Nombre;
                y.direccion = this.Direccion;
                y.contacto = this.Contacto;
                y.tiendcol = this.Tiendcol;



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
                CapaDatos.Tienda y = CommonBC.ModeloVentas.Tienda.
                                                First(x => x.id == Id);
                CommonBC.ModeloVentas.Tienda.Remove(y);
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
