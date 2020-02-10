﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SygnusportalBD
{
    // ===========================================================================
    /// <summary>
    /// Author     : MARCO ANTONIO MARTINEZ LOPEZ
    /// Create date: Feb 10 2020 10:30AM
    /// Procedimiento almacenado que genera Script de Clases BD de Tablas
    /// CLASE CONSTRUCTOR, INSERT, UPDATE, DELETE Y SELECT de tablas de Bases de Datos
    /// </summary>

    public class PaisBD
    {

        sygnusportalEntities BD = new sygnusportalEntities();


        // ******************* = Costructor = ******************************
        // Declaración de variables
        string pai_codigo;
        string pai_nombre;
        string pai_codigointernacional;
        bool pai_predeterminado;

        // Deficinción de propiedades
        public string Pai_codigo { get; set; }
        public string Pai_nombre { get; set; }
        public string Pai_codigointernacional { get; set; }
        public bool Pai_predeterminado { get; set; }

        public PaisBD()
        {
            pai_codigo = "";
            pai_nombre = "";
            pai_codigointernacional = "";
            pai_predeterminado = true;
        }
        // ===========================================================================
        /// <summary>
        /// Author     : MARCO ANTONIO MARTINEZ LOPEZ
        /// Create date: Feb 10 2020 10:30AM
        /// Método que permite insertar en la tabla Pais capa BD
        /// </summary>
        // ******************* = Método Insert = ******************************
        public void Pais_Insert(string pai_codigo, string pai_nombre, string pai_codigointernacional, bool pai_predeterminado)
        {
            try
            {
                BD.Pais_Insert(pai_codigo, pai_nombre, pai_codigointernacional, pai_predeterminado);
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
        /// Create date: Feb 10 2020 10:30AM
        /// Método que permite actualizar en la tabla Pais capa BD
        /// </summary>
        // ******************* = Método Update = ******************************
        public void Pais_Update(string pai_codigo, string pai_nombre, string pai_codigointernacional, bool pai_predeterminado)
        {
            try
            {
                BD.Pais_Update(pai_codigo, pai_nombre, pai_codigointernacional, pai_predeterminado);
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
        /// Create date: Feb 10 2020 10:30AM
        /// Método que permite eliminar en la tabla Pais capa BD
        /// </summary>
        // ******************* = Método Delete = ******************************
        public void Pais_Delete(string pai_codigo)
        {
            try
            {
                BD.Pais_Delete(pai_codigo);
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
        /// Create date: Feb 10 2020 10:30AM
        /// Método que permite listar de la tabla Pais capa BD
        /// </summary>
        // ******************* = Método List = ******************************
        public List<Pais_List_Result> Pais_List(string pai_codigo)
        {
            try
            {
                var Pais = (from TPais in BD.Pais_List(pai_codigo) select TPais).ToList();
                return Pais;
            }
            catch (Exception Ex)
            {
                throw (Ex);
            }
        }
    }
    //FIN DE LA CLASE
}
