using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    class Factura
    {
        public int Id { get; set; }
        public int Monto { get; set; }
        public string Fecha { get; set; }
        public string MedioPago { get; set; }
        public string Direccion { get; set; }


        public Factura()
        {
            Id = 0;
            Monto = 0;
            Fecha = "";
            MedioPago = "";
            Direccion = "";
          
         
        }


        public int Create()
        {
            try
            {
                // Producto capa de datos          //Capa de negocio.
                //Clase con contructores.
                //CapaDeNegocio..
                //p cada de datos                Clase //Producto()
                CapaDatos.Factura x = new CapaDatos.Factura();


                x.Monto         = this.Monto;
                x.Fecha         = this.Fecha;
                x.MedioPago     = this.MedioPago;
                x.Fecha         = this.Fecha;
                x.direccion     = this.Direccion;




                CommonBC.ModeloVentas.Factura.Add(x);
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
                CapaDatos.Factura pr = CommonBC.ModeloVentas.
                    Factura.First(x => x.id == this.Id);


                this.Monto          = pr.Monto;
                this.Fecha          = pr.Fecha;
                this.MedioPago      = pr.MedioPago;
                this.Direccion      = pr.direccion;



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
                CapaDatos.Factura y = CommonBC.ModeloVentas.Factura.
                                                First(x => x.id == Id);
                y.id        = this.Id;
                y.Monto     = this.Monto;
                y.Fecha     = this.Fecha;
                y.MedioPago = this.MedioPago;
                y.Fecha     = this.Fecha;
                y.direccion = this.Direccion;



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
                CapaDatos.Factura y = CommonBC.ModeloVentas.Factura.
                                                First(x => x.id == Id);
                CommonBC.ModeloVentas.Factura.Remove(y);
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
