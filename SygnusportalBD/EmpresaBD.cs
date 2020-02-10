using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SygnusportalBD
{
    // ===========================================================================
    /// <summary>
    /// Author     : MARCO ANTONIO MARTINEZ LOPEZ
    /// Create date: Feb 10 2020 10:40AM
    /// Procedimiento almacenado que genera Script de Clases BD de Tablas
    /// CLASE CONSTRUCTOR, INSERT, UPDATE, DELETE Y SELECT de tablas de Bases de Datos
    /// </summary>

    public class EmpresaBD
    {

        sygnusportalEntities BD = new sygnusportalEntities();


        // ******************* = Costructor = ******************************
        // Declaración de variables
        string emp_nit;
        int emp_dv;
        string emp_nombre;
        string emp_direccion;
        string ciu_codigo;
        string emp_telefono;
        string emp_logo;
        string emp_url;

        // Deficinción de propiedades
        public string Emp_nit { get; set; }
        public int Emp_dv { get; set; }
        public string Emp_nombre { get; set; }
        public string Emp_direccion { get; set; }
        public string Ciu_codigo { get; set; }
        public string Emp_telefono { get; set; }
        public string Emp_logo { get; set; }
        public string Emp_url { get; set; }

        public EmpresaBD()
        {
            emp_nit = "";
            emp_dv = 0;
            emp_nombre = "";
            emp_direccion = "";
            ciu_codigo = "";
            emp_telefono = "";
            emp_logo = "";
            emp_url = "";
        }
        // ===========================================================================
        /// <summary>
        /// Author     : MARCO ANTONIO MARTINEZ LOPEZ
        /// Create date: Feb 10 2020 10:40AM
        /// Método que permite insertar en la tabla Empresa capa BD
        /// </summary>
        // ******************* = Método Insert = ******************************
        public void Empresa_Insert(string emp_nit, int emp_dv, string emp_nombre, string emp_direccion, string ciu_codigo, string emp_telefono, string emp_logo, string emp_url)
        {
            try
            {
                BD.Empresa_Insert(emp_nit, emp_dv, emp_nombre, emp_direccion, ciu_codigo, emp_telefono, emp_logo, emp_url);
                BD.SaveChanges();
            }
            catch (Exception Ex)
            {
                throw (Ex);
            }
        }
        // ===========================================================================
        /// <summary>
        /// Author     : MARCO ANTONIO MARTINEZ LOPEZ
        /// Create date: Feb 10 2020 10:40AM
        /// Método que permite actualizar en la tabla Empresa capa BD
        /// </summary>
        // ******************* = Método Update = ******************************
        public void Empresa_Update(string emp_nit, int emp_dv, string emp_nombre, string emp_direccion, string ciu_codigo, string emp_telefono, string emp_logo, string emp_url)
        {
            try
            {
                BD.Empresa_Update(emp_nit, emp_dv, emp_nombre, emp_direccion, ciu_codigo, emp_telefono, emp_logo, emp_url);
                BD.SaveChanges();
            }
            catch (Exception Ex)
            {
                throw (Ex);
            }
        }
        // ===========================================================================
        /// <summary>
        /// Author     : MARCO ANTONIO MARTINEZ LOPEZ
        /// Create date: Feb 10 2020 10:40AM
        /// Método que permite eliminar en la tabla Empresa capa BD
        /// </summary>
        // ******************* = Método Delete = ******************************
        public void Empresa_Delete(string emp_nit)
        {
            try
            {
                BD.Empresa_Delete(emp_nit);
                BD.SaveChanges();
            }
            catch (Exception Ex)
            {
                throw (Ex);
            }
        }
        // ===========================================================================
        /// <summary>
        /// Author     : MARCO ANTONIO MARTINEZ LOPEZ
        /// Create date: Feb 10 2020 10:40AM
        /// Método que permite listar de la tabla Empresa capa BD
        /// </summary>
        // ******************* = Método List = ******************************
        public List<Empresa_List_Result> Empresa_List(string emp_nit)
        {
            try
            {
                var Empresa = (from TEmpresa in BD.Empresa_List(emp_nit) select TEmpresa).ToList();
                return Empresa;
            }
            catch (Exception Ex)
            {
                throw (Ex);
            }
        }
    }
    //FIN DE LA CLASE
}
