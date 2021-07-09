using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    class Contador
    {

        public int Id { get; set; }
        public int Rut { get; set; }
        public string Nombre { get; set; }
        public string Contacto { get; set; }

        public Contador()
        {
            Id = 0;
            Rut = 0;
            Nombre = "";
            Contacto = "";
        }

        public int Create()
        {
            try
            {
                // Producto capa de datos          //Capa de negocio.
                //Clase con contructores.
                //CapaDeNegocio..
                //p cada de datos                Clase //Producto()
                CapaDatos.Contador x = new CapaDatos.Contador();



                x.rut = this.Rut;
                x.nombre = this.Nombre;
                x.contacto = this.Contacto;
               



                CommonBC.ModeloVentas.Contador.Add(x);
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
                CapaDatos.Contador pr = CommonBC.ModeloVentas.
                    Contador.First(x => x.id == this.Id);


                this.Rut = pr.rut;
                this.Nombre = pr.nombre;
                this.Contacto = pr.contacto;
               


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
                CapaDatos.Contador y = CommonBC.ModeloVentas.Contador.
                                                First(x => x.id == Id);

                y.rut = this.Rut;
                y.nombre = this.Nombre;
                y.contacto = this.Contacto;
               


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
                CapaDatos.Contador y = CommonBC.ModeloVentas.Contador.
                                                First(x => x.id == Id);
                CommonBC.ModeloVentas.Contador.Remove(y);
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