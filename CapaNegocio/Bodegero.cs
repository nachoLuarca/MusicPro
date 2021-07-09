using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    class Bodegero 
    {

        public int Id { get; set; }
        public int Idtiendas { get; set; }
        public string Nombre { get; set; }
        public string Contacto { get; set; }
        public string Direccion { get; set; }


        public Bodegero()
        {
            Id = 0;
            Idtiendas = 0;
            Nombre = "";
            Contacto = "";
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
                CapaDatos.Bodegero x = new CapaDatos.Bodegero();



                x.idtiendas = this.Idtiendas;
                x.nombre = this.Nombre;
                x.contacto = this.Contacto;
                x.direccion = this.Direccion;



                CommonBC.ModeloVentas.Bodegero.Add(x);
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
                CapaDatos.Bodegero pr = CommonBC.ModeloVentas.
                    Bodegero.First(x => x.id == this.Id);


                this.Idtiendas = pr.idtiendas;
                this.Nombre = pr.nombre;
                this.Contacto = pr.contacto;
                this.Direccion = pr.direccion;


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
                CapaDatos.Bodegero y = CommonBC.ModeloVentas.Bodegero.
                                                First(x => x.id == Id);

                y.idtiendas = this.Idtiendas;
                y.nombre = this.Nombre;
                y.contacto = this.Contacto;
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
                CapaDatos.Bodegero y = CommonBC.ModeloVentas.Bodegero.
                                                First(x => x.id == Id);
                CommonBC.ModeloVentas.Bodegero.Remove(y);
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
