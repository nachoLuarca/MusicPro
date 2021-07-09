using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    class ProductosInventariostienda
    {

        public int Id { get; set; }
        public int IdproductoInventarios { get; set; }
        public int Idproducto { get; set; }
        public int Idtienda { get; set; }

        public ProductosInventariostienda()
        {
            Id = 0;
            IdproductoInventarios = 0;
            Idproducto = 0;
            Idtienda = 0;
            
        }
    }
}
