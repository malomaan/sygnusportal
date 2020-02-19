using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace SygnusportalBD
{
    [MetadataType(typeof(Ciudad.Metadata))]

    public partial class Ciudad
    {
        sealed class Metadata
        {
            [DisplayName("Codigo")]
            [DataType(DataType.Text)]
            [Required(ErrorMessage = "Debe ingresar el {0}")]
            [StringLength(5)]
            public string ciu_codigo { get; set; }

            [DisplayName("Nombre")]
            [DataType(DataType.Text)]
            [Required(ErrorMessage = "Debe ingresar el {0}")]
            public string ciu_nombre { get; set; }

            [DisplayName("Codigo")]
            [Required(ErrorMessage = "Debe ingresar el {0}")]
            public Nullable<bool> ciu_capital { get; set; }

            [DisplayName("Departamento")]
            [DataType(DataType.Text)]
            [Required(ErrorMessage = "Debe seleccionar el {0}")]
            public string dep_codigo { get; set; }
        }


    }
}
