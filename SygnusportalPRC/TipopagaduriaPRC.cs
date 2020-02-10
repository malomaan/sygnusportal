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
    /// Create date: Feb 10 2020 10:37AM
    /// Procedimiento almacenado que genera Script de Clases PRC de la capa BD
    /// CLASE CONSTRUCTOR, INSERT, UPDATE, DELETE Y SELECT de tablas de Bases de Datos
    /// </summary>

    public class TipopagaduriaPRC
    {

        TipopagaduriaBD BDTipopagaduria = new TipopagaduriaBD();


        // ******************* = Costructor = ******************************
        // Declaración de variables
        int tpa_id;
        string tpa_descripcion;

        // Deficinción de propiedades
        public int Tpa_id { get; set; }
        public string Tpa_descripcion { get; set; }

        public TipopagaduriaPRC()
        {
            tpa_descripcion = "";
        }
        // ===========================================================================
        /// <summary>
        /// Author     : MARCO ANTONIO MARTINEZ LOPEZ
        /// Create date: Feb 10 2020 10:37AM
        /// Método que permite insertar en la tabla Tipopagaduria capa PRC
        /// </summary>
        // ******************* = Método Insert = ******************************
        public void Tipopagaduria_Insert(string tpa_descripcion)
        {
            try
            {
                BDTipopagaduria.Tipopagaduria_Insert(tpa_descripcion);
            }
            catch (Exception Ex)
            {
                throw (Ex);
            }
        }
        // ===========================================================================
        /// <summary>
        /// Author     : MARCO ANTONIO MARTINEZ LOPEZ
        /// Create date: Feb 10 2020 10:37AM
        /// Método que permite actualizar en la tabla Tipopagaduria capa PRC
        /// </summary>
        // ******************* = Método Update = ******************************
        public void Tipopagaduria_Update(int tpa_id, string tpa_descripcion)
        {
            try
            {
                BDTipopagaduria.Tipopagaduria_Update(tpa_id, tpa_descripcion);
            }
            catch (Exception Ex)
            {
                throw (Ex);
            }
        }
        // ===========================================================================
        /// <summary>
        /// Author     : MARCO ANTONIO MARTINEZ LOPEZ
        /// Create date: Feb 10 2020 10:37AM
        /// Método que permite eliminar en la tabla Tipopagaduria capa PRC
        /// </summary>
        // ******************* = Método Delete = ******************************
        public void Tipopagaduria_Delete(int tpa_id)
        {
            try
            {
                BDTipopagaduria.Tipopagaduria_Delete(tpa_id);
            }
            catch (Exception Ex)
            {
                throw (Ex);
            }
        }
        // ===========================================================================
        /// <summary>
        /// Author     : MARCO ANTONIO MARTINEZ LOPEZ
        /// Create date: Feb 10 2020 10:37AM
        /// Método que permite listar de la tabla Tipopagaduria capa PRC
        /// </summary>
        // ******************* = Método List = ******************************
        public List<Tipopagaduria_List_Result> Tipopagaduria_List(int tpa_id)
        {
            try
            {
                var Tipopagaduria = (from TTipopagaduria in BDTipopagaduria.Tipopagaduria_List(tpa_id) select TTipopagaduria).ToList();
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
