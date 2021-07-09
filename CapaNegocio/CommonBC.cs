using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    class CommonBC
    {
        private static MusicProbdEntities _modeloVentas;
        public static MusicProbdEntities ModeloVentas
        {
            get
            {
                if (_modeloVentas == null)
                    _modeloVentas = new MusicProbdEntities();
                return _modeloVentas;
            }
            set { _modeloVentas = value; }
        }

    }
}
