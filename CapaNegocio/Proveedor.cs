using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class Proveedor
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Contacto { get; set; }
        public string Direccion { get; set; }
        public string NombreEmpresa { get; set; }

        public Proveedor()
        {
            Id = 0;
            Nombre = "";
            Contacto = "";
            Direccion = "";
            NombreEmpresa = "";
        }

        public int Create()
        {
            try
            {
                // Producto capa de datos          //Capa de negocio.
                //Clase con contructores.
                //CapaDeNegocio..
                //p cada de datos                Clase //Producto()
                CapaDatos.Provedor pr = new CapaDatos.Provedor();


                pr.nombre = this.Nombre;
                pr.contacto = this.Contacto;
                pr.direccion = this.Direccion;
                pr.nombreEmpresa = this.NombreEmpresa;


                CommonBC.ModeloVentas.Provedor.Add(pr);
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
                CapaDatos.Provedor pr = CommonBC.ModeloVentas.
                    Provedor.First(x => x.id == this.Id);


                this.Nombre = pr.nombre;
                this.Contacto = pr.contacto;
                this.Direccion = pr.direccion;
                this.NombreEmpresa = pr.nombreEmpresa;

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
                CapaDatos.Provedor pr = CommonBC.ModeloVentas.Provedor.
                                                First(x => x.id == Id);
                pr.nombre = this.Nombre;
                pr.contacto = this.Contacto;
                pr.direccion = this.Direccion;
                pr.nombreEmpresa = this.NombreEmpresa;

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
                CapaDatos.Provedor pr = CommonBC.ModeloVentas.Provedor.
                                                First(x => x.id == Id);
                CommonBC.ModeloVentas.Provedor.Remove(pr);
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

