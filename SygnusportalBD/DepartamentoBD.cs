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
    /// Create date: Feb 10 2020 10:32AM
    /// Procedimiento almacenado que genera Script de Clases BD de Tablas
    /// CLASE CONSTRUCTOR, INSERT, UPDATE, DELETE Y SELECT de tablas de Bases de Datos
    /// </summary>

    public class DepartamentoBD
    {

        sygnusportalEntities BD = new sygnusportalEntities();


        // ******************* = Costructor = ******************************
        // Declaración de variables
        string dep_codigo;
        string dep_nombre;
        string pai_codigo;

        // Deficinción de propiedades
        public string Dep_codigo { get; set; }
        public string Dep_nombre { get; set; }
        public string Pai_codigo { get; set; }

        public DepartamentoBD()
        {
            dep_codigo = "";
            dep_nombre = "";
            pai_codigo = "";
        }
        // ===========================================================================
        /// <summary>
        /// Author     : MARCO ANTONIO MARTINEZ LOPEZ
        /// Create date: Feb 10 2020 10:32AM
        /// Método que permite insertar en la tabla Departamento capa BD
        /// </summary>
        // ******************* = Método Insert = ******************************
        public void Departamento_Insert(string dep_codigo, string dep_nombre, string pai_codigo)
        {
            try
            {
                BD.Departamento_Insert(dep_codigo, dep_nombre, pai_codigo);
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
        /// Create date: Feb 10 2020 10:32AM
        /// Método que permite actualizar en la tabla Departamento capa BD
        /// </summary>
        // ******************* = Método Update = ******************************
        public void Departamento_Update(string dep_codigo, string dep_nombre, string pai_codigo)
        {
            try
            {
                BD.Departamento_Update(dep_codigo, dep_nombre, pai_codigo);
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
        /// Create date: Feb 10 2020 10:32AM
        /// Método que permite eliminar en la tabla Departamento capa BD
        /// </summary>
        // ******************* = Método Delete = ******************************
        public void Departamento_Delete(string dep_codigo)
        {
            try
            {
                BD.Departamento_Delete(dep_codigo);
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
        /// Create date: Feb 10 2020 10:32AM
        /// Método que permite listar de la tabla Departamento capa BD
        /// </summary>
        // ******************* = Método List = ******************************
        public List<Departamento_List_Result> Departamento_List(string dep_codigo)
        {
            try
            {
                var Departamento = (from TDepartamento in BD.Departamento_List(dep_codigo) select TDepartamento).ToList();
                return Departamento;
            }
            catch (Exception Ex)
            {
                throw (Ex);
            }
        }

        // ===========================================================================
        /// <summary>
        /// Author     : MARCO ANTONIO MARTINEZ LOPEZ
        /// Create date: Feb 10 2020 10:32AM
        /// Método que permite listar de la tabla Departamento Por Pais capa BD
        /// </summary>
        // ******************* = Método List = ******************************
        public List<Departamento_List_Pais_Result> Departamento_List_Pais(string pai_codigo)
        {
            try
            {
                var Departamento = (from TDepartamento in BD.Departamento_List_Pais(pai_codigo) select TDepartamento).ToList();
                return Departamento;
            }
            catch (Exception Ex)
            {
                throw (Ex);
            }
        }

    }
    //FIN DE LA CLASE
}
