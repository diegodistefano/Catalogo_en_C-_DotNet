using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    class Marcas
    {
        public int Id { get; set; }

        [DisplayName("Descripción")]
        public string Descripcion { get; set; }

    }
}
