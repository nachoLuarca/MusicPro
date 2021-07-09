using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SwCliente
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IProducto
    {
        [OperationContract]
        int Create(int idProveedor, int idCategoria, int codigoBarra, int precio,
            int stock, int Stock_critico, string  Descripcion);

        [OperationContract]
        int Update(int id, int idProveedor, int idCategoria, int codigoBarra, int precio,
            int stock, int Stock_critico, string Descripcion);

        [OperationContract]
        int Delete(int id);

        [OperationContract]
        CapaNegocio.Producto Read(int id);


      
    }
}
