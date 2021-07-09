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
    public interface ICatalagoPro

       
    {
        [OperationContract]
        int Create(string nombreCategoria, string tipoCategoria, string especificacion, string detalles);

        [OperationContract]
        int Update(int id, string nombreCategoria, string tipoCategoria, string especificacion, string detalles);

        [OperationContract]
        int Delete(int id);

        [OperationContract]
        CapaNegocio.CatalogoProducto Read(int id);
    }
}
