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
    /// Create date: Feb 10 2020 10:35AM
    /// Procedimiento almacenado que genera Script de Clases PRC de la capa BD
    /// CLASE CONSTRUCTOR, INSERT, UPDATE, DELETE Y SELECT de tablas de Bases de Datos
    /// </summary>

    public class CiudadPRC
    {

        CiudadBD BDCiudad = new CiudadBD();


        // ******************* = Costructor = ******************************
        // Declaración de variables
        string ciu_codigo;
        string ciu_nombre;
        bool ciu_capital;
        string dep_codigo;

        // Deficinción de propiedades
        public string Ciu_codigo { get; set; }
        public string Ciu_nombre { get; set; }
        public bool Ciu_capital { get; set; }
        public string Dep_codigo { get; set; }

        public CiudadPRC()
        {
            ciu_codigo = "";
            ciu_nombre = "";
            ciu_capital = true;
            dep_codigo = "";
        }
        // ===========================================================================
        /// <summary>
        /// Author     : MARCO ANTONIO MARTINEZ LOPEZ
        /// Create date: Feb 10 2020 10:35AM
        /// Método que permite insertar en la tabla Ciudad capa PRC
        /// </summary>
        // ******************* = Método Insert = ******************************
        public void Ciudad_Insert(string ciu_codigo, string ciu_nombre, bool ciu_capital, string dep_codigo)
        {
            try
            {
                BDCiudad.Ciudad_Insert(ciu_codigo, ciu_nombre, ciu_capital, dep_codigo);
            }
            catch (Exception Ex)
            {
                throw (Ex);
            }
        }
        // ===========================================================================
        /// <summary>
        /// Author     : MARCO ANTONIO MARTINEZ LOPEZ
        /// Create date: Feb 10 2020 10:35AM
        /// Método que permite actualizar en la tabla Ciudad capa PRC
        /// </summary>
        // ******************* = Método Update = ******************************
        public void Ciudad_Update(string ciu_codigo, string ciu_nombre, bool ciu_capital, string dep_codigo)
        {
            try
            {
                BDCiudad.Ciudad_Update(ciu_codigo, ciu_nombre, ciu_capital, dep_codigo);
            }
            catch (Exception Ex)
            {
                throw (Ex);
            }
        }
        // ===========================================================================
        /// <summary>
        /// Author     : MARCO ANTONIO MARTINEZ LOPEZ
        /// Create date: Feb 10 2020 10:35AM
        /// Método que permite eliminar en la tabla Ciudad capa PRC
        /// </summary>
        // ******************* = Método Delete = ******************************
        public void Ciudad_Delete(string ciu_codigo)
        {
            try
            {
                BDCiudad.Ciudad_Delete(ciu_codigo);
            }
            catch (Exception Ex)
            {
                throw (Ex);
            }
        }
        // ===========================================================================
        /// <summary>
        /// Author     : MARCO ANTONIO MARTINEZ LOPEZ
        /// Create date: Feb 10 2020 10:35AM
        /// Método que permite listar de la tabla Ciudad capa PRC
        /// </summary>
        // ******************* = Método List = ******************************
        public List<Ciudad_List_Result> Ciudad_List(string ciu_codigo)
        {
            try
            {
                var Ciudad = (from TCiudad in BDCiudad.Ciudad_List(ciu_codigo) select TCiudad).ToList();
                return Ciudad;
            }
            catch (Exception Ex)
            {
                throw (Ex);
            }
        }
    }
    //FIN DE LA CLASE
}
