using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace SygnusportalBD
{
    [MetadataType(typeof(TipoPagaduria.Metadata))]
    public  partial class TipoPagaduria
    {
        sealed class Metadata
        {
            [DisplayName("Id")]
            [DataType(DataType.Text)]
            [Required(ErrorMessage = "Debe ingresar el {0}")]
            public int tpa_id { get; set; }

            [DisplayName("Descripcion")]
            [DataType(DataType.Text)]
            [Required(ErrorMessage = "Debe ingresar el {0}")]
            [StringLength(150)]
            public string tpa_descripcion { get; set; }

        }
    }
}
