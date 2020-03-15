using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SygnusportalBD;

namespace SygnusportalPRC
{
    // ===========================================================================
    /// <summary>
    /// Author     : MARCO ANTONIO MARTINEZ LOPEZ
    /// Create date: Feb 10 2020 10:42AM
    /// Procedimiento almacenado que genera Script de Clases PRC de la capa BD
    /// CLASE CONSTRUCTOR, INSERT, UPDATE, DELETE Y SELECT de tablas de Bases de Datos
    /// </summary>

    public class PagaduriaPRC
    {

        PagaduriaBD BDPagaduria = new PagaduriaBD();


        // ******************* = Costructor = ******************************
        // Declaración de variables
        int pag_id;
        string pag_codigo;
        string pag_nit;
        int pag_dv;
        string pag_nombre;
        string pag_direccion;
        string ciu_codigo;
        string pag_telefonos;
        string pag_url;
        string pag_mail;
        string pag_logo;
        string pag_urlsygnus;
        string pag_color;
        int tpa_id;
        string emp_nit;
        int ent_id;
        bool pag_activa;
        string pag_fax;

        // Deficinción de propiedades
        public int Pag_id { get; set; }
        public string Pag_codigo { get; set; }
        public string Pag_nit { get; set; }
        public int Pag_dv { get; set; }
        public string Pag_nombre { get; set; }
        public string Pag_direccion { get; set; }
        public string Ciu_codigo { get; set; }
        public string Pag_telefonos { get; set; }
        public string Pag_url { get; set; }
        public string Pag_mail { get; set; }
        public string Pag_logo { get; set; }
        public string Pag_urlsygnus { get; set; }
        public string Pag_color { get; set; }
        public int Tpa_id { get; set; }
        public string Emp_nit { get; set; }
        public int Ent_id { get; set; }
        public bool Pag_activa { get; set; }
        public string Pag_fax { get; set; }

        public PagaduriaPRC()
        {
            pag_codigo = "";
            pag_nit = "";
            pag_dv = 0;
            pag_nombre = "";
            pag_direccion = "";
            ciu_codigo = "";
            pag_telefonos = "";
            pag_url = "";
            pag_mail = "";
            pag_logo = "";
            pag_urlsygnus = "";
            pag_color = "";
            tpa_id = 0;
            emp_nit = "";
            ent_id = 0;
            pag_activa = true;
            pag_fax = "";
        }
        // ===========================================================================
        /// <summary>
        /// Author     : MARCO ANTONIO MARTINEZ LOPEZ
        /// Create date: Feb 10 2020 10:42AM
        /// Método que permite insertar en la tabla Pagaduria capa PRC
        /// </summary>
        // ******************* = Método Insert = ******************************
        public void Pagaduria_Insert(string pag_codigo, string pag_nit, int pag_dv, string pag_nombre, string pag_direccion, string ciu_codigo, string pag_telefonos, string pag_url, string pag_mail, string pag_logo, string pag_urlsygnus, string pag_color, int tpa_id, string emp_nit, int ent_id, bool pag_activa, string pag_fax)
        {
            try
            {
                BDPagaduria.Pagaduria_Insert(pag_codigo, pag_nit, pag_dv, pag_nombre, pag_direccion, ciu_codigo, pag_telefonos, pag_url, pag_mail, pag_logo, pag_urlsygnus, pag_color, tpa_id, emp_nit, ent_id, pag_activa, pag_fax);
            }
            catch (Exception Ex)
            {
                throw (Ex);
            }
        }
        // ===========================================================================
        /// <summary>
        /// Author     : MARCO ANTONIO MARTINEZ LOPEZ
        /// Create date: Feb 10 2020 10:42AM
        /// Método que permite actualizar en la tabla Pagaduria capa PRC
        /// </summary>
        // ******************* = Método Update = ******************************
        public void Pagaduria_Update(int pag_id, string pag_codigo, string pag_nit, int pag_dv, string pag_nombre, string pag_direccion, string ciu_codigo, string pag_telefonos, string pag_url, string pag_mail, string pag_logo, string pag_urlsygnus, string pag_color, int tpa_id, string emp_nit, int ent_id, bool pag_activa, string pag_fax)
        {
            try
            {
                BDPagaduria.Pagaduria_Update(pag_id, pag_codigo, pag_nit, pag_dv, pag_nombre, pag_direccion, ciu_codigo, pag_telefonos, pag_url, pag_mail, pag_logo, pag_urlsygnus, pag_color, tpa_id, emp_nit, ent_id, pag_activa, pag_fax);
            }
            catch (Exception Ex)
            {
                throw (Ex);
            }
        }
        // ===========================================================================
        /// <summary>
        /// Author     : MARCO ANTONIO MARTINEZ LOPEZ
        /// Create date: Feb 10 2020 10:42AM
        /// Método que permite eliminar en la tabla Pagaduria capa PRC
        /// </summary>
        // ******************* = Método Delete = ******************************
        public void Pagaduria_Delete(int pag_id)
        {
            try
            {
                BDPagaduria.Pagaduria_Delete(pag_id);
            }
            catch (Exception Ex)
            {
                throw (Ex);
            }
        }
        // ===========================================================================
        /// <summary>
        /// Author     : MARCO ANTONIO MARTINEZ LOPEZ
        /// Create date: Feb 10 2020 10:42AM
        /// Método que permite listar de la tabla Pagaduria capa PRC
        /// </summary>
        // ******************* = Método List = ******************************
        public List<Pagaduria_List_Result> Pagaduria_List(int pag_id)
        {
            try
            {
                var Pagaduria = (from TPagaduria in BDPagaduria.Pagaduria_List(pag_id) select TPagaduria).ToList();
                return Pagaduria;
            }
            catch (Exception Ex)
            {
                throw (Ex);
            }
        }

        /// <summary>
        /// Procedimiento que muestra el listado se pagadurías activas y sus estados capa PRC
        /// </summary>
        /// <returns></returns>
        public List<Pagaduria_ListActivasPeriodos_Result> Pagaduria_ListActivasPeriodos()
        {
            try
            {
                var Pagaduria = (from TPagaduria in BDPagaduria.Pagaduria_ListActivasPeriodos() select TPagaduria).ToList();
                return Pagaduria;
            }
            catch (Exception Ex)
            {
                throw (Ex);
            }
        }



        /// <summary>
        /// Procedimiento que muestra el listado se pagadurías activas Habilitadas y sus estados capa PRC
        /// </summary>
        /// <returns></returns>
        public List<Pagaduria_ListActivasPeriodos_Habilitada_Result> Pagaduria_ListActivasPeriodos_Habilitada()
        {
            try
            {
                var Pagaduria = (from TPagaduria in BDPagaduria.Pagaduria_ListActivasPeriodos_Habilitada() select TPagaduria).ToList();
                return Pagaduria;
            }
            catch (Exception Ex)
            {
                throw (Ex);
            }
        }


        /// <summary>
        /// Procedimiento que muestra el listado se pagadurías activas por tipo y sus estados capa PRC
        /// </summary>
        /// <returns></returns>
        public List<Pagaduria_ListActivasPeriodos_Tipo_Result> Pagaduria_ListActivasPeriodos_Tipo(int tpa_id)
        {
            try
            {
                var Pagaduria = (from TPagaduria in BDPagaduria.Pagaduria_ListActivasPeriodos_Tipo(tpa_id) select TPagaduria).ToList();
                return Pagaduria;
            }
            catch (Exception Ex)
            {
                throw (Ex);
            }
        }


    }
    //FIN DE LA CLASE
}
