//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SygnusportalBD
{
    using System;
    using System.Collections.Generic;
    
    public partial class Empresa
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Empresa()
        {
            this.Pagaduria = new HashSet<Pagaduria>();
        }
    
        public string emp_nit { get; set; }
        public Nullable<int> emp_dv { get; set; }
        public string emp_nombre { get; set; }
        public string emp_direccion { get; set; }
        public string ciu_codigo { get; set; }
        public string emp_telefono { get; set; }
        public string emp_logo { get; set; }
        public string emp_url { get; set; }
    
        public virtual Ciudad Ciudad { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pagaduria> Pagaduria { get; set; }
    }
}
