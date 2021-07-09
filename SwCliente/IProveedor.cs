﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SwCliente
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IProveedor
    {
        [OperationContract]
        int Create(string nombre, string contacto, string direccion, string nombreEmpresa);

        [OperationContract]
        int Update(int id, string nombre, string contacto, string direccion, string nombreEmpresa);

        [OperationContract]
        int Delete(int id);

        [OperationContract]
        List<CapaNegocio.Proveedor> Listar();

        [OperationContract]
        CapaNegocio.Proveedor Read(int id);

    }
}
