﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class sygnusportalEntities : DbContext
    {
        public sygnusportalEntities()
            : base("name=sygnusportalEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Ciudad> Ciudad { get; set; }
        public virtual DbSet<Departamento> Departamento { get; set; }
        public virtual DbSet<Empresa> Empresa { get; set; }
        public virtual DbSet<Pagaduria> Pagaduria { get; set; }
        public virtual DbSet<Pais> Pais { get; set; }
        public virtual DbSet<TipoDato> TipoDato { get; set; }
        public virtual DbSet<TipoPagaduria> TipoPagaduria { get; set; }
    
        public virtual int Ciudad_Delete(string ciu_codigo)
        {
            var ciu_codigoParameter = ciu_codigo != null ?
                new ObjectParameter("ciu_codigo", ciu_codigo) :
                new ObjectParameter("ciu_codigo", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Ciudad_Delete", ciu_codigoParameter);
        }
    
        public virtual int Ciudad_Insert(string ciu_codigo, string ciu_nombre, Nullable<bool> ciu_capital, string dep_codigo)
        {
            var ciu_codigoParameter = ciu_codigo != null ?
                new ObjectParameter("ciu_codigo", ciu_codigo) :
                new ObjectParameter("ciu_codigo", typeof(string));
    
            var ciu_nombreParameter = ciu_nombre != null ?
                new ObjectParameter("ciu_nombre", ciu_nombre) :
                new ObjectParameter("ciu_nombre", typeof(string));
    
            var ciu_capitalParameter = ciu_capital.HasValue ?
                new ObjectParameter("ciu_capital", ciu_capital) :
                new ObjectParameter("ciu_capital", typeof(bool));
    
            var dep_codigoParameter = dep_codigo != null ?
                new ObjectParameter("dep_codigo", dep_codigo) :
                new ObjectParameter("dep_codigo", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Ciudad_Insert", ciu_codigoParameter, ciu_nombreParameter, ciu_capitalParameter, dep_codigoParameter);
        }
    
        public virtual ObjectResult<Ciudad_List_Result> Ciudad_List(string ciu_codigo)
        {
            var ciu_codigoParameter = ciu_codigo != null ?
                new ObjectParameter("ciu_codigo", ciu_codigo) :
                new ObjectParameter("ciu_codigo", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Ciudad_List_Result>("Ciudad_List", ciu_codigoParameter);
        }
    
        public virtual int Ciudad_Update(string ciu_codigo, string ciu_nombre, Nullable<bool> ciu_capital, string dep_codigo)
        {
            var ciu_codigoParameter = ciu_codigo != null ?
                new ObjectParameter("ciu_codigo", ciu_codigo) :
                new ObjectParameter("ciu_codigo", typeof(string));
    
            var ciu_nombreParameter = ciu_nombre != null ?
                new ObjectParameter("ciu_nombre", ciu_nombre) :
                new ObjectParameter("ciu_nombre", typeof(string));
    
            var ciu_capitalParameter = ciu_capital.HasValue ?
                new ObjectParameter("ciu_capital", ciu_capital) :
                new ObjectParameter("ciu_capital", typeof(bool));
    
            var dep_codigoParameter = dep_codigo != null ?
                new ObjectParameter("dep_codigo", dep_codigo) :
                new ObjectParameter("dep_codigo", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Ciudad_Update", ciu_codigoParameter, ciu_nombreParameter, ciu_capitalParameter, dep_codigoParameter);
        }
    
        public virtual int Departamento_Delete(string dep_codigo)
        {
            var dep_codigoParameter = dep_codigo != null ?
                new ObjectParameter("dep_codigo", dep_codigo) :
                new ObjectParameter("dep_codigo", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Departamento_Delete", dep_codigoParameter);
        }
    
        public virtual int Departamento_Insert(string dep_codigo, string dep_nombre, string pai_codigo)
        {
            var dep_codigoParameter = dep_codigo != null ?
                new ObjectParameter("dep_codigo", dep_codigo) :
                new ObjectParameter("dep_codigo", typeof(string));
    
            var dep_nombreParameter = dep_nombre != null ?
                new ObjectParameter("dep_nombre", dep_nombre) :
                new ObjectParameter("dep_nombre", typeof(string));
    
            var pai_codigoParameter = pai_codigo != null ?
                new ObjectParameter("pai_codigo", pai_codigo) :
                new ObjectParameter("pai_codigo", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Departamento_Insert", dep_codigoParameter, dep_nombreParameter, pai_codigoParameter);
        }
    
        public virtual ObjectResult<Departamento_List_Result> Departamento_List(string dep_codigo)
        {
            var dep_codigoParameter = dep_codigo != null ?
                new ObjectParameter("dep_codigo", dep_codigo) :
                new ObjectParameter("dep_codigo", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Departamento_List_Result>("Departamento_List", dep_codigoParameter);
        }
    
        public virtual int Departamento_Update(string dep_codigo, string dep_nombre, string pai_codigo)
        {
            var dep_codigoParameter = dep_codigo != null ?
                new ObjectParameter("dep_codigo", dep_codigo) :
                new ObjectParameter("dep_codigo", typeof(string));
    
            var dep_nombreParameter = dep_nombre != null ?
                new ObjectParameter("dep_nombre", dep_nombre) :
                new ObjectParameter("dep_nombre", typeof(string));
    
            var pai_codigoParameter = pai_codigo != null ?
                new ObjectParameter("pai_codigo", pai_codigo) :
                new ObjectParameter("pai_codigo", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Departamento_Update", dep_codigoParameter, dep_nombreParameter, pai_codigoParameter);
        }
    
        public virtual int Empresa_Delete(string emp_nit)
        {
            var emp_nitParameter = emp_nit != null ?
                new ObjectParameter("emp_nit", emp_nit) :
                new ObjectParameter("emp_nit", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Empresa_Delete", emp_nitParameter);
        }
    
        public virtual int Empresa_Insert(string emp_nit, Nullable<int> emp_dv, string emp_nombre, string emp_direccion, string ciu_codigo, string emp_telefono, string emp_logo, string emp_url)
        {
            var emp_nitParameter = emp_nit != null ?
                new ObjectParameter("emp_nit", emp_nit) :
                new ObjectParameter("emp_nit", typeof(string));
    
            var emp_dvParameter = emp_dv.HasValue ?
                new ObjectParameter("emp_dv", emp_dv) :
                new ObjectParameter("emp_dv", typeof(int));
    
            var emp_nombreParameter = emp_nombre != null ?
                new ObjectParameter("emp_nombre", emp_nombre) :
                new ObjectParameter("emp_nombre", typeof(string));
    
            var emp_direccionParameter = emp_direccion != null ?
                new ObjectParameter("emp_direccion", emp_direccion) :
                new ObjectParameter("emp_direccion", typeof(string));
    
            var ciu_codigoParameter = ciu_codigo != null ?
                new ObjectParameter("ciu_codigo", ciu_codigo) :
                new ObjectParameter("ciu_codigo", typeof(string));
    
            var emp_telefonoParameter = emp_telefono != null ?
                new ObjectParameter("emp_telefono", emp_telefono) :
                new ObjectParameter("emp_telefono", typeof(string));
    
            var emp_logoParameter = emp_logo != null ?
                new ObjectParameter("emp_logo", emp_logo) :
                new ObjectParameter("emp_logo", typeof(string));
    
            var emp_urlParameter = emp_url != null ?
                new ObjectParameter("emp_url", emp_url) :
                new ObjectParameter("emp_url", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Empresa_Insert", emp_nitParameter, emp_dvParameter, emp_nombreParameter, emp_direccionParameter, ciu_codigoParameter, emp_telefonoParameter, emp_logoParameter, emp_urlParameter);
        }
    
        public virtual ObjectResult<Empresa_List_Result> Empresa_List(string emp_nit)
        {
            var emp_nitParameter = emp_nit != null ?
                new ObjectParameter("emp_nit", emp_nit) :
                new ObjectParameter("emp_nit", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Empresa_List_Result>("Empresa_List", emp_nitParameter);
        }
    
        public virtual int Empresa_Update(string emp_nit, Nullable<int> emp_dv, string emp_nombre, string emp_direccion, string ciu_codigo, string emp_telefono, string emp_logo, string emp_url)
        {
            var emp_nitParameter = emp_nit != null ?
                new ObjectParameter("emp_nit", emp_nit) :
                new ObjectParameter("emp_nit", typeof(string));
    
            var emp_dvParameter = emp_dv.HasValue ?
                new ObjectParameter("emp_dv", emp_dv) :
                new ObjectParameter("emp_dv", typeof(int));
    
            var emp_nombreParameter = emp_nombre != null ?
                new ObjectParameter("emp_nombre", emp_nombre) :
                new ObjectParameter("emp_nombre", typeof(string));
    
            var emp_direccionParameter = emp_direccion != null ?
                new ObjectParameter("emp_direccion", emp_direccion) :
                new ObjectParameter("emp_direccion", typeof(string));
    
            var ciu_codigoParameter = ciu_codigo != null ?
                new ObjectParameter("ciu_codigo", ciu_codigo) :
                new ObjectParameter("ciu_codigo", typeof(string));
    
            var emp_telefonoParameter = emp_telefono != null ?
                new ObjectParameter("emp_telefono", emp_telefono) :
                new ObjectParameter("emp_telefono", typeof(string));
    
            var emp_logoParameter = emp_logo != null ?
                new ObjectParameter("emp_logo", emp_logo) :
                new ObjectParameter("emp_logo", typeof(string));
    
            var emp_urlParameter = emp_url != null ?
                new ObjectParameter("emp_url", emp_url) :
                new ObjectParameter("emp_url", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Empresa_Update", emp_nitParameter, emp_dvParameter, emp_nombreParameter, emp_direccionParameter, ciu_codigoParameter, emp_telefonoParameter, emp_logoParameter, emp_urlParameter);
        }
    
        public virtual int Pagaduria_Delete(Nullable<int> pag_id)
        {
            var pag_idParameter = pag_id.HasValue ?
                new ObjectParameter("pag_id", pag_id) :
                new ObjectParameter("pag_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Pagaduria_Delete", pag_idParameter);
        }
    
        public virtual int Pagaduria_Insert(string pag_codigo, string pag_nit, Nullable<int> pag_dv, string pag_nombre, string pag_direccion, string ciu_codigo, string pag_telefonos, string pag_url, string pag_mail, string pag_logo, string pag_urlsygnus, string pag_color, Nullable<int> tpa_id, string emp_nit, Nullable<int> ent_id, Nullable<bool> pag_activa, string pag_fax)
        {
            var pag_codigoParameter = pag_codigo != null ?
                new ObjectParameter("pag_codigo", pag_codigo) :
                new ObjectParameter("pag_codigo", typeof(string));
    
            var pag_nitParameter = pag_nit != null ?
                new ObjectParameter("pag_nit", pag_nit) :
                new ObjectParameter("pag_nit", typeof(string));
    
            var pag_dvParameter = pag_dv.HasValue ?
                new ObjectParameter("pag_dv", pag_dv) :
                new ObjectParameter("pag_dv", typeof(int));
    
            var pag_nombreParameter = pag_nombre != null ?
                new ObjectParameter("pag_nombre", pag_nombre) :
                new ObjectParameter("pag_nombre", typeof(string));
    
            var pag_direccionParameter = pag_direccion != null ?
                new ObjectParameter("pag_direccion", pag_direccion) :
                new ObjectParameter("pag_direccion", typeof(string));
    
            var ciu_codigoParameter = ciu_codigo != null ?
                new ObjectParameter("ciu_codigo", ciu_codigo) :
                new ObjectParameter("ciu_codigo", typeof(string));
    
            var pag_telefonosParameter = pag_telefonos != null ?
                new ObjectParameter("pag_telefonos", pag_telefonos) :
                new ObjectParameter("pag_telefonos", typeof(string));
    
            var pag_urlParameter = pag_url != null ?
                new ObjectParameter("pag_url", pag_url) :
                new ObjectParameter("pag_url", typeof(string));
    
            var pag_mailParameter = pag_mail != null ?
                new ObjectParameter("pag_mail", pag_mail) :
                new ObjectParameter("pag_mail", typeof(string));
    
            var pag_logoParameter = pag_logo != null ?
                new ObjectParameter("pag_logo", pag_logo) :
                new ObjectParameter("pag_logo", typeof(string));
    
            var pag_urlsygnusParameter = pag_urlsygnus != null ?
                new ObjectParameter("pag_urlsygnus", pag_urlsygnus) :
                new ObjectParameter("pag_urlsygnus", typeof(string));
    
            var pag_colorParameter = pag_color != null ?
                new ObjectParameter("pag_color", pag_color) :
                new ObjectParameter("pag_color", typeof(string));
    
            var tpa_idParameter = tpa_id.HasValue ?
                new ObjectParameter("tpa_id", tpa_id) :
                new ObjectParameter("tpa_id", typeof(int));
    
            var emp_nitParameter = emp_nit != null ?
                new ObjectParameter("emp_nit", emp_nit) :
                new ObjectParameter("emp_nit", typeof(string));
    
            var ent_idParameter = ent_id.HasValue ?
                new ObjectParameter("ent_id", ent_id) :
                new ObjectParameter("ent_id", typeof(int));
    
            var pag_activaParameter = pag_activa.HasValue ?
                new ObjectParameter("pag_activa", pag_activa) :
                new ObjectParameter("pag_activa", typeof(bool));
    
            var pag_faxParameter = pag_fax != null ?
                new ObjectParameter("pag_fax", pag_fax) :
                new ObjectParameter("pag_fax", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Pagaduria_Insert", pag_codigoParameter, pag_nitParameter, pag_dvParameter, pag_nombreParameter, pag_direccionParameter, ciu_codigoParameter, pag_telefonosParameter, pag_urlParameter, pag_mailParameter, pag_logoParameter, pag_urlsygnusParameter, pag_colorParameter, tpa_idParameter, emp_nitParameter, ent_idParameter, pag_activaParameter, pag_faxParameter);
        }
    
        public virtual ObjectResult<Pagaduria_List_Result> Pagaduria_List(Nullable<int> pag_id)
        {
            var pag_idParameter = pag_id.HasValue ?
                new ObjectParameter("pag_id", pag_id) :
                new ObjectParameter("pag_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Pagaduria_List_Result>("Pagaduria_List", pag_idParameter);
        }
    
        public virtual ObjectResult<Pagaduria_ListActivasPeriodos_Result> Pagaduria_ListActivasPeriodos()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Pagaduria_ListActivasPeriodos_Result>("Pagaduria_ListActivasPeriodos");
        }
    
        public virtual int Pagaduria_Update(Nullable<int> pag_id, string pag_codigo, string pag_nit, Nullable<int> pag_dv, string pag_nombre, string pag_direccion, string ciu_codigo, string pag_telefonos, string pag_url, string pag_mail, string pag_logo, string pag_urlsygnus, string pag_color, Nullable<int> tpa_id, string emp_nit, Nullable<int> ent_id, Nullable<bool> pag_activa, string pag_fax)
        {
            var pag_idParameter = pag_id.HasValue ?
                new ObjectParameter("pag_id", pag_id) :
                new ObjectParameter("pag_id", typeof(int));
    
            var pag_codigoParameter = pag_codigo != null ?
                new ObjectParameter("pag_codigo", pag_codigo) :
                new ObjectParameter("pag_codigo", typeof(string));
    
            var pag_nitParameter = pag_nit != null ?
                new ObjectParameter("pag_nit", pag_nit) :
                new ObjectParameter("pag_nit", typeof(string));
    
            var pag_dvParameter = pag_dv.HasValue ?
                new ObjectParameter("pag_dv", pag_dv) :
                new ObjectParameter("pag_dv", typeof(int));
    
            var pag_nombreParameter = pag_nombre != null ?
                new ObjectParameter("pag_nombre", pag_nombre) :
                new ObjectParameter("pag_nombre", typeof(string));
    
            var pag_direccionParameter = pag_direccion != null ?
                new ObjectParameter("pag_direccion", pag_direccion) :
                new ObjectParameter("pag_direccion", typeof(string));
    
            var ciu_codigoParameter = ciu_codigo != null ?
                new ObjectParameter("ciu_codigo", ciu_codigo) :
                new ObjectParameter("ciu_codigo", typeof(string));
    
            var pag_telefonosParameter = pag_telefonos != null ?
                new ObjectParameter("pag_telefonos", pag_telefonos) :
                new ObjectParameter("pag_telefonos", typeof(string));
    
            var pag_urlParameter = pag_url != null ?
                new ObjectParameter("pag_url", pag_url) :
                new ObjectParameter("pag_url", typeof(string));
    
            var pag_mailParameter = pag_mail != null ?
                new ObjectParameter("pag_mail", pag_mail) :
                new ObjectParameter("pag_mail", typeof(string));
    
            var pag_logoParameter = pag_logo != null ?
                new ObjectParameter("pag_logo", pag_logo) :
                new ObjectParameter("pag_logo", typeof(string));
    
            var pag_urlsygnusParameter = pag_urlsygnus != null ?
                new ObjectParameter("pag_urlsygnus", pag_urlsygnus) :
                new ObjectParameter("pag_urlsygnus", typeof(string));
    
            var pag_colorParameter = pag_color != null ?
                new ObjectParameter("pag_color", pag_color) :
                new ObjectParameter("pag_color", typeof(string));
    
            var tpa_idParameter = tpa_id.HasValue ?
                new ObjectParameter("tpa_id", tpa_id) :
                new ObjectParameter("tpa_id", typeof(int));
    
            var emp_nitParameter = emp_nit != null ?
                new ObjectParameter("emp_nit", emp_nit) :
                new ObjectParameter("emp_nit", typeof(string));
    
            var ent_idParameter = ent_id.HasValue ?
                new ObjectParameter("ent_id", ent_id) :
                new ObjectParameter("ent_id", typeof(int));
    
            var pag_activaParameter = pag_activa.HasValue ?
                new ObjectParameter("pag_activa", pag_activa) :
                new ObjectParameter("pag_activa", typeof(bool));
    
            var pag_faxParameter = pag_fax != null ?
                new ObjectParameter("pag_fax", pag_fax) :
                new ObjectParameter("pag_fax", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Pagaduria_Update", pag_idParameter, pag_codigoParameter, pag_nitParameter, pag_dvParameter, pag_nombreParameter, pag_direccionParameter, ciu_codigoParameter, pag_telefonosParameter, pag_urlParameter, pag_mailParameter, pag_logoParameter, pag_urlsygnusParameter, pag_colorParameter, tpa_idParameter, emp_nitParameter, ent_idParameter, pag_activaParameter, pag_faxParameter);
        }
    
        public virtual int Pais_Delete(string pai_codigo)
        {
            var pai_codigoParameter = pai_codigo != null ?
                new ObjectParameter("pai_codigo", pai_codigo) :
                new ObjectParameter("pai_codigo", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Pais_Delete", pai_codigoParameter);
        }
    
        public virtual int Pais_Insert(string pai_codigo, string pai_nombre, string pai_codigointernacional, Nullable<bool> pai_predeterminado)
        {
            var pai_codigoParameter = pai_codigo != null ?
                new ObjectParameter("pai_codigo", pai_codigo) :
                new ObjectParameter("pai_codigo", typeof(string));
    
            var pai_nombreParameter = pai_nombre != null ?
                new ObjectParameter("pai_nombre", pai_nombre) :
                new ObjectParameter("pai_nombre", typeof(string));
    
            var pai_codigointernacionalParameter = pai_codigointernacional != null ?
                new ObjectParameter("pai_codigointernacional", pai_codigointernacional) :
                new ObjectParameter("pai_codigointernacional", typeof(string));
    
            var pai_predeterminadoParameter = pai_predeterminado.HasValue ?
                new ObjectParameter("pai_predeterminado", pai_predeterminado) :
                new ObjectParameter("pai_predeterminado", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Pais_Insert", pai_codigoParameter, pai_nombreParameter, pai_codigointernacionalParameter, pai_predeterminadoParameter);
        }
    
        public virtual ObjectResult<Pais_List_Result> Pais_List(string pai_codigo)
        {
            var pai_codigoParameter = pai_codigo != null ?
                new ObjectParameter("pai_codigo", pai_codigo) :
                new ObjectParameter("pai_codigo", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Pais_List_Result>("Pais_List", pai_codigoParameter);
        }
    
        public virtual int Pais_Update(string pai_codigo, string pai_nombre, string pai_codigointernacional, Nullable<bool> pai_predeterminado)
        {
            var pai_codigoParameter = pai_codigo != null ?
                new ObjectParameter("pai_codigo", pai_codigo) :
                new ObjectParameter("pai_codigo", typeof(string));
    
            var pai_nombreParameter = pai_nombre != null ?
                new ObjectParameter("pai_nombre", pai_nombre) :
                new ObjectParameter("pai_nombre", typeof(string));
    
            var pai_codigointernacionalParameter = pai_codigointernacional != null ?
                new ObjectParameter("pai_codigointernacional", pai_codigointernacional) :
                new ObjectParameter("pai_codigointernacional", typeof(string));
    
            var pai_predeterminadoParameter = pai_predeterminado.HasValue ?
                new ObjectParameter("pai_predeterminado", pai_predeterminado) :
                new ObjectParameter("pai_predeterminado", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Pais_Update", pai_codigoParameter, pai_nombreParameter, pai_codigointernacionalParameter, pai_predeterminadoParameter);
        }
    
        public virtual int Tipodato_Delete(Nullable<int> tda_id)
        {
            var tda_idParameter = tda_id.HasValue ?
                new ObjectParameter("tda_id", tda_id) :
                new ObjectParameter("tda_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Tipodato_Delete", tda_idParameter);
        }
    
        public virtual int Tipodato_Insert(string tda_nombre, string tda_convencion, string tda_valorpredeterminado)
        {
            var tda_nombreParameter = tda_nombre != null ?
                new ObjectParameter("tda_nombre", tda_nombre) :
                new ObjectParameter("tda_nombre", typeof(string));
    
            var tda_convencionParameter = tda_convencion != null ?
                new ObjectParameter("tda_convencion", tda_convencion) :
                new ObjectParameter("tda_convencion", typeof(string));
    
            var tda_valorpredeterminadoParameter = tda_valorpredeterminado != null ?
                new ObjectParameter("tda_valorpredeterminado", tda_valorpredeterminado) :
                new ObjectParameter("tda_valorpredeterminado", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Tipodato_Insert", tda_nombreParameter, tda_convencionParameter, tda_valorpredeterminadoParameter);
        }
    
        public virtual ObjectResult<Tipodato_List_Result> Tipodato_List(Nullable<int> tda_id)
        {
            var tda_idParameter = tda_id.HasValue ?
                new ObjectParameter("tda_id", tda_id) :
                new ObjectParameter("tda_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Tipodato_List_Result>("Tipodato_List", tda_idParameter);
        }
    
        public virtual int Tipodato_Update(Nullable<int> tda_id, string tda_nombre, string tda_convencion, string tda_valorpredeterminado)
        {
            var tda_idParameter = tda_id.HasValue ?
                new ObjectParameter("tda_id", tda_id) :
                new ObjectParameter("tda_id", typeof(int));
    
            var tda_nombreParameter = tda_nombre != null ?
                new ObjectParameter("tda_nombre", tda_nombre) :
                new ObjectParameter("tda_nombre", typeof(string));
    
            var tda_convencionParameter = tda_convencion != null ?
                new ObjectParameter("tda_convencion", tda_convencion) :
                new ObjectParameter("tda_convencion", typeof(string));
    
            var tda_valorpredeterminadoParameter = tda_valorpredeterminado != null ?
                new ObjectParameter("tda_valorpredeterminado", tda_valorpredeterminado) :
                new ObjectParameter("tda_valorpredeterminado", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Tipodato_Update", tda_idParameter, tda_nombreParameter, tda_convencionParameter, tda_valorpredeterminadoParameter);
        }
    
        public virtual int Tipopagaduria_Delete(Nullable<int> tpa_id)
        {
            var tpa_idParameter = tpa_id.HasValue ?
                new ObjectParameter("tpa_id", tpa_id) :
                new ObjectParameter("tpa_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Tipopagaduria_Delete", tpa_idParameter);
        }
    
        public virtual int Tipopagaduria_Insert(string tpa_descripcion)
        {
            var tpa_descripcionParameter = tpa_descripcion != null ?
                new ObjectParameter("tpa_descripcion", tpa_descripcion) :
                new ObjectParameter("tpa_descripcion", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Tipopagaduria_Insert", tpa_descripcionParameter);
        }
    
        public virtual ObjectResult<Tipopagaduria_List_Result> Tipopagaduria_List(Nullable<int> tpa_id)
        {
            var tpa_idParameter = tpa_id.HasValue ?
                new ObjectParameter("tpa_id", tpa_id) :
                new ObjectParameter("tpa_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Tipopagaduria_List_Result>("Tipopagaduria_List", tpa_idParameter);
        }
    
        public virtual int Tipopagaduria_Update(Nullable<int> tpa_id, string tpa_descripcion)
        {
            var tpa_idParameter = tpa_id.HasValue ?
                new ObjectParameter("tpa_id", tpa_id) :
                new ObjectParameter("tpa_id", typeof(int));
    
            var tpa_descripcionParameter = tpa_descripcion != null ?
                new ObjectParameter("tpa_descripcion", tpa_descripcion) :
                new ObjectParameter("tpa_descripcion", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Tipopagaduria_Update", tpa_idParameter, tpa_descripcionParameter);
        }
    }
}