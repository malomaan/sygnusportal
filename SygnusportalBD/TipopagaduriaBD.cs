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
    /// Create date: Feb 10 2020 10:36AM
    /// Procedimiento almacenado que genera Script de Clases BD de Tablas
    /// CLASE CONSTRUCTOR, INSERT, UPDATE, DELETE Y SELECT de tablas de Bases de Datos
    /// </summary>

    public class TipopagaduriaBD
    {

        sygnusportalEntities BD = new sygnusportalEntities();


        // ******************* = Costructor = ******************************
        // Declaración de variables
        int tpa_id;
        string tpa_descripcion;

        // Deficinción de propiedades
        public int Tpa_id { get; set; }
        public string Tpa_descripcion { get; set; }

        public TipopagaduriaBD()
        {
            tpa_descripcion = "";
        }
        // ===========================================================================
        /// <summary>
        /// Author     : MARCO ANTONIO MARTINEZ LOPEZ
        /// Create date: Feb 10 2020 10:36AM
        /// Método que permite insertar en la tabla Tipopagaduria capa BD
        /// </summary>
        // ******************* = Método Insert = ******************************
        public void Tipopagaduria_Insert(string tpa_descripcion)
        {
            try
            {
                BD.Tipopagaduria_Insert(tpa_descripcion);
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
        /// Create date: Feb 10 2020 10:36AM
        /// Método que permite actualizar en la tabla Tipopagaduria capa BD
        /// </summary>
        // ******************* = Método Update = ******************************
        public void Tipopagaduria_Update(int tpa_id, string tpa_descripcion)
        {
            try
            {
                BD.Tipopagaduria_Update(tpa_id, tpa_descripcion);
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
        /// Create date: Feb 10 2020 10:36AM
        /// Método que permite eliminar en la tabla Tipopagaduria capa BD
        /// </summary>
        // ******************* = Método Delete = ******************************
        public void Tipopagaduria_Delete(int tpa_id)
        {
            try
            {
                BD.Tipopagaduria_Delete(tpa_id);
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
        /// Create date: Feb 10 2020 10:36AM
        /// Método que permite listar de la tabla Tipopagaduria capa BD
        /// </summary>
        // ******************* = Método List = ******************************
        public List<Tipopagaduria_List_Result> Tipopagaduria_List(int tpa_id)
        {
            try
            {
                var Tipopagaduria = (from TTipopagaduria in BD.Tipopagaduria_List(tpa_id) select TTipopagaduria).ToList();
                return Tipopagaduria;
            }
            catch (Exception Ex)
            {
                throw (Ex);
            }
        }
    }
    //FIN DE LA CLASE

}
