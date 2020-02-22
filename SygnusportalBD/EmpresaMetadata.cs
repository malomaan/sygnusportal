using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace SygnusportalBD
{
    [MetadataType(typeof(Empresa.Metadata))]
    public partial class Empresa
    {
        sealed class Metadata
        {
            [DisplayName("NIT")]
            [Required(ErrorMessage = "Debe ingresar el {0}")]
            public string emp_nit { get; set; }

            [DisplayName("DV")]
            [Required(ErrorMessage = "Debe ingresar el {0}")]
            public Nullable<int> emp_dv { get; set; }

            [DisplayName("Nombre")]
            [DataType(DataType.Text)]
            [Required(ErrorMessage = "Debe ingresar el {0}")]
            [StringLength(250)]
            public string emp_nombre { get; set; }

            [DisplayName("Direccion")]
            [DataType(DataType.Text)]
            [Required(ErrorMessage = "Debe ingresar el {0}")]
            [StringLength(250)]
            public string emp_direccion { get; set; }

            [DisplayName("Ciudad")]
            [DataType(DataType.Text)]
            [Required(ErrorMessage = "Debe ingresar el {0}")]
            [StringLength(20)]
            public string ciu_codigo { get; set; }

            [DisplayName("Telefonos")]
            [DataType(DataType.Text)]
            [Required(ErrorMessage = "Debe ingresar el {0}")]
            [StringLength(250)]
            public string emp_telefono { get; set; }

            [DisplayName("Logo")]
            [DataType(DataType.Text)]
            public string emp_logo { get; set; }

            [DisplayName("URL")]
            [Required(ErrorMessage = "Debe ingresar el {0}")]
            [StringLength(250)]
            //[RegularExpression(@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$", ErrorMessage = "Por favor debe ingresar una dirección de Correo Electónico")]           
            [RegularExpression(@"http(s)?://([\w-]+\.)+[\w-]+(/[\w- ./?%&=]*)?", ErrorMessage = "Por favor debe ingresar una dirección URL")]
            public string emp_url { get; set; }

        }
    }
}
