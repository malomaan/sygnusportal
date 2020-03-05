using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace SygnusportalBD
{
    [MetadataType(typeof(Pagaduria.Metadata))]
    public partial class Pagaduria
    {
        sealed class Metadata
        {
            [DisplayName("ID")]
            [DataType(DataType.Text)]
            [Required(ErrorMessage = "Debe ingresar el {0}")]
            public int pag_id { get; set; }

            [DisplayName("Codigo")]
            [DataType(DataType.Text)]
            [Required(ErrorMessage = "Debe ingresar el {0}")]
            [StringLength(50)]
            public string pag_codigo { get; set; }

            [DisplayName("NIT")]
            [DataType(DataType.Text)]
            [Required(ErrorMessage = "Debe ingresar el {0}")]
            public string pag_nit { get; set; }

            [DisplayName("DV")]
            [DataType(DataType.Text)]
            [Required(ErrorMessage = "Debe ingresar el {0}")]
            [StringLength(1)]
            public Nullable<int> pag_dv { get; set; }

            [DisplayName("Nombre")]
            [DataType(DataType.Text)]
            [Required(ErrorMessage = "Debe ingresar el {0}")]
            [StringLength(250)]
            public string pag_nombre { get; set; }

            [DisplayName("Direccion")]
            [DataType(DataType.Text)]
            [Required(ErrorMessage = "Debe ingresar el {0}")]
            [StringLength(250)]
            public string pag_direccion { get; set; }

            [DisplayName("Ciudad")]
            [DataType(DataType.Text)]
            [Required(ErrorMessage = "Debe ingresar el {0}")]
            public string ciu_codigo { get; set; }

            [DisplayName("Telefonos")]
            [DataType(DataType.Text)]
            [Required(ErrorMessage = "Debe ingresar el {0}")]
            [StringLength(150)]
            public string pag_telefonos { get; set; }

            [DisplayName("URL")]
            [DataType(DataType.Url)]
            [Required(ErrorMessage = "Debe ingresar el {0}")]
            public string pag_url { get; set; }

            [DisplayName("Email")]
            [DataType(DataType.EmailAddress)]
            [Required(ErrorMessage = "Debe ingresar el {0}")]
            public string pag_mail { get; set; }

            [DisplayName("Logo")]
            [DataType(DataType.Text)]
            [Required(ErrorMessage = "Debe ingresar el {0}")]
            public string pag_logo { get; set; }

            [DisplayName("SygnusURL")]
            [DataType(DataType.Url)]
            [Required(ErrorMessage = "Debe ingresar el {0}")]
            public string pag_urlsygnus { get; set; }

            [DisplayName("Color")]
            [DataType(DataType.Text)]
            [Required(ErrorMessage = "Debe ingresar el {0}")]
            [StringLength(250)]
            public string pag_color { get; set; }

            [DisplayName("Tipo")]
            [DataType(DataType.Text)]
            [Required(ErrorMessage = "Debe ingresar el {0}")]
            public Nullable<int> tpa_id { get; set; }

            [DisplayName("Empresa")]
            [DataType(DataType.Text)]
            [Required(ErrorMessage = "Debe ingresar el {0}")]
            public string emp_nit { get; set; }

            [DisplayName("IDEntidad")]
            [DataType(DataType.Text)]
            [Required(ErrorMessage = "Debe ingresar el {0}")]
            public Nullable<int> ent_id { get; set; }

            [DisplayName("Activa")]
            [Required(ErrorMessage = "Debe ingresar el {0}")]
            public Nullable<bool> pag_activa { get; set; }

            [DisplayName("Fax")]
            [DataType(DataType.Text)]
            [Required(ErrorMessage = "Debe ingresar el {0}")]
            [StringLength(250)]
            public string pag_fax { get; set; }


        }
    }
}
