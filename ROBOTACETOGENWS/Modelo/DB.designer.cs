﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ROBOTACETOGENWS.Modelo
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="SGBINTEGRACION")]
	public partial class DBDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Definiciones de métodos de extensibilidad
    partial void OnCreated();
    partial void InsertACETOGEN_Recepcion(ACETOGEN_Recepcion instance);
    partial void UpdateACETOGEN_Recepcion(ACETOGEN_Recepcion instance);
    partial void DeleteACETOGEN_Recepcion(ACETOGEN_Recepcion instance);
    partial void InsertACETOGEN_Picking(ACETOGEN_Picking instance);
    partial void UpdateACETOGEN_Picking(ACETOGEN_Picking instance);
    partial void DeleteACETOGEN_Picking(ACETOGEN_Picking instance);
    #endregion
		
		public DBDataContext() : 
				base(global::ROBOTACETOGENWS.Properties.Settings.Default.SGBINTEGRACIONConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DBDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DBDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DBDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DBDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<ACETOGEN_TXTIN> ACETOGEN_TXTIN
		{
			get
			{
				return this.GetTable<ACETOGEN_TXTIN>();
			}
		}
		
		public System.Data.Linq.Table<ACETOGEN_Recepcion> ACETOGEN_Recepcion
		{
			get
			{
				return this.GetTable<ACETOGEN_Recepcion>();
			}
		}
		
		public System.Data.Linq.Table<ACETOGEN_Picking> ACETOGEN_Picking
		{
			get
			{
				return this.GetTable<ACETOGEN_Picking>();
			}
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.ACETOGEN_Picking_UpdKey")]
		public int ACETOGEN_Picking_UpdKey([global::System.Data.Linq.Mapping.ParameterAttribute(Name="IdOrden", DbType="BigInt")] System.Nullable<long> idOrden)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), idOrden);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.ACETOGEN_TXTINLOG_InsKey")]
		public int ACETOGEN_TXTINLOG_InsKey([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Descripcion", DbType="VarChar(200)")] string descripcion, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Tipo", DbType="VarChar(200)")] string tipo)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), descripcion, tipo);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.ACETOGEN_OrdenesWS_InsKey")]
		public int ACETOGEN_OrdenesWS_InsKey(
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="Numero_Orden", DbType="VarChar(100)")] string numero_Orden, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="NumeroDoc", DbType="VarChar(100)")] string numeroDoc, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="Cod_cliente", DbType="VarChar(100)")] string cod_cliente, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="Cod_Sucursal", DbType="VarChar(100)")] string cod_Sucursal, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="Cod_Direc", DbType="VarChar(100)")] string cod_Direc, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="Direccion", DbType="VarChar(100)")] string direccion, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="Comuna", DbType="VarChar(100)")] string comuna, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="Region", DbType="VarChar(100)")] string region, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="Fecha", DbType="DateTime")] System.Nullable<System.DateTime> fecha, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(100)")] string occ, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="N_Referencia", DbType="VarChar(50)")] string n_Referencia, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="FechaSolicitada", DbType="VarChar(50)")] string fechaSolicitada, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="FechaDocumento", DbType="VarChar(50)")] string fechaDocumento, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="FechaVencimiento", DbType="VarChar(50)")] string fechaVencimiento, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="Observaciones", DbType="VarChar(100)")] string observaciones, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="Transporte", DbType="VarChar(100)")] string transporte, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="CodigoProducto", DbType="VarChar(100)")] string codigoProducto, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="NombreProducto", DbType="VarChar(100)")] string nombreProducto, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="Cant_Solicitada", DbType="BigInt")] System.Nullable<long> cant_Solicitada, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="Empresa", DbType="BigInt")] System.Nullable<long> empresa, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="TIPO_DOC", DbType="BigInt")] System.Nullable<long> tIPO_DOC, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="NOM_CLIENTE", DbType="VarChar(50)")] string nOM_CLIENTE, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="Bodega", DbType="VarChar(50)")] string bodega)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), numero_Orden, numeroDoc, cod_cliente, cod_Sucursal, cod_Direc, direccion, comuna, region, fecha, occ, n_Referencia, fechaSolicitada, fechaDocumento, fechaVencimiento, observaciones, transporte, codigoProducto, nombreProducto, cant_Solicitada, empresa, tIPO_DOC, nOM_CLIENTE, bodega);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.ACETOGEN_JSON_InsKey")]
		public int ACETOGEN_JSON_InsKey([global::System.Data.Linq.Mapping.ParameterAttribute(Name="JSON", DbType="VarChar(MAX)")] string jSON)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), jSON);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.ACETOGEN_Delete_Temporal")]
		public int ACETOGEN_Delete_Temporal([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Id_Estado", DbType="BigInt")] System.Nullable<long> id_Estado)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), id_Estado);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.ACETOGEN_ACETOGEN_TXTIN_Carga")]
		public int ACETOGEN_ACETOGEN_TXTIN_Carga([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Id_Estado", DbType="BigInt")] System.Nullable<long> id_Estado)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), id_Estado);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.ACETOGEN_Recepcion_UpdKey")]
		public int ACETOGEN_Recepcion_UpdKey([global::System.Data.Linq.Mapping.ParameterAttribute(Name="IdOrden", DbType="BigInt")] System.Nullable<long> idOrden)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), idOrden);
			return ((int)(result.ReturnValue));
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ACETOGEN_TXTIN")]
	public partial class ACETOGEN_TXTIN
	{
		
		private long _ID_TXTIN;
		
		private string _NumeroOrden;
		
		private string _NumeroDocumento;
		
		private string _CodigoCliente;
		
		private string _CodigoSucursal;
		
		private string _Cod_Direc;
		
		private string _Direccion;
		
		private string _Comuna;
		
		private string _Region;
		
		private System.Nullable<System.DateTime> _Fecha;
		
		private string _OCC;
		
		private string _NumeroReferencia;
		
		private string _FechaSolicitada;
		
		private string _FechaDocumento;
		
		private string _FechaVencimiento;
		
		private string _Observaciones;
		
		private string _Transporte;
		
		private string _CodigoProducto;
		
		private string _NombreProducto;
		
		private System.Nullable<decimal> _Cant_Solicitada;
		
		private System.Nullable<System.DateTime> _FechaCreacion;
		
		private System.Nullable<int> _Id_Estado;
		
		private System.Nullable<long> _Empresa;
		
		private System.Nullable<long> _Tipo_Doc;
		
		private System.Nullable<long> _Id_Zcabecera;
		
		private System.Nullable<long> _Id_Orden;
		
		private System.Nullable<long> _Id_OrdenDetalle;
		
		private System.Nullable<long> _Id_EmpresaDestino;
		
		private System.Nullable<long> _Id_ProductoTipoEmbalaje;
		
		public ACETOGEN_TXTIN()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID_TXTIN", AutoSync=AutoSync.Always, DbType="BigInt NOT NULL IDENTITY", IsDbGenerated=true)]
		public long ID_TXTIN
		{
			get
			{
				return this._ID_TXTIN;
			}
			set
			{
				if ((this._ID_TXTIN != value))
				{
					this._ID_TXTIN = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NumeroOrden", DbType="VarChar(100)")]
		public string NumeroOrden
		{
			get
			{
				return this._NumeroOrden;
			}
			set
			{
				if ((this._NumeroOrden != value))
				{
					this._NumeroOrden = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NumeroDocumento", DbType="VarChar(100)")]
		public string NumeroDocumento
		{
			get
			{
				return this._NumeroDocumento;
			}
			set
			{
				if ((this._NumeroDocumento != value))
				{
					this._NumeroDocumento = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CodigoCliente", DbType="VarChar(100)")]
		public string CodigoCliente
		{
			get
			{
				return this._CodigoCliente;
			}
			set
			{
				if ((this._CodigoCliente != value))
				{
					this._CodigoCliente = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CodigoSucursal", DbType="VarChar(100)")]
		public string CodigoSucursal
		{
			get
			{
				return this._CodigoSucursal;
			}
			set
			{
				if ((this._CodigoSucursal != value))
				{
					this._CodigoSucursal = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cod_Direc", DbType="VarChar(100)")]
		public string Cod_Direc
		{
			get
			{
				return this._Cod_Direc;
			}
			set
			{
				if ((this._Cod_Direc != value))
				{
					this._Cod_Direc = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Direccion", DbType="VarChar(100)")]
		public string Direccion
		{
			get
			{
				return this._Direccion;
			}
			set
			{
				if ((this._Direccion != value))
				{
					this._Direccion = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Comuna", DbType="VarChar(100)")]
		public string Comuna
		{
			get
			{
				return this._Comuna;
			}
			set
			{
				if ((this._Comuna != value))
				{
					this._Comuna = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Region", DbType="VarChar(100)")]
		public string Region
		{
			get
			{
				return this._Region;
			}
			set
			{
				if ((this._Region != value))
				{
					this._Region = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Fecha", DbType="DateTime")]
		public System.Nullable<System.DateTime> Fecha
		{
			get
			{
				return this._Fecha;
			}
			set
			{
				if ((this._Fecha != value))
				{
					this._Fecha = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OCC", DbType="VarChar(100)")]
		public string OCC
		{
			get
			{
				return this._OCC;
			}
			set
			{
				if ((this._OCC != value))
				{
					this._OCC = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NumeroReferencia", DbType="VarChar(100)")]
		public string NumeroReferencia
		{
			get
			{
				return this._NumeroReferencia;
			}
			set
			{
				if ((this._NumeroReferencia != value))
				{
					this._NumeroReferencia = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FechaSolicitada", DbType="VarChar(50)")]
		public string FechaSolicitada
		{
			get
			{
				return this._FechaSolicitada;
			}
			set
			{
				if ((this._FechaSolicitada != value))
				{
					this._FechaSolicitada = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FechaDocumento", DbType="VarChar(50)")]
		public string FechaDocumento
		{
			get
			{
				return this._FechaDocumento;
			}
			set
			{
				if ((this._FechaDocumento != value))
				{
					this._FechaDocumento = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FechaVencimiento", DbType="VarChar(50)")]
		public string FechaVencimiento
		{
			get
			{
				return this._FechaVencimiento;
			}
			set
			{
				if ((this._FechaVencimiento != value))
				{
					this._FechaVencimiento = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Observaciones", DbType="VarChar(100)")]
		public string Observaciones
		{
			get
			{
				return this._Observaciones;
			}
			set
			{
				if ((this._Observaciones != value))
				{
					this._Observaciones = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Transporte", DbType="VarChar(100)")]
		public string Transporte
		{
			get
			{
				return this._Transporte;
			}
			set
			{
				if ((this._Transporte != value))
				{
					this._Transporte = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CodigoProducto", DbType="VarChar(100)")]
		public string CodigoProducto
		{
			get
			{
				return this._CodigoProducto;
			}
			set
			{
				if ((this._CodigoProducto != value))
				{
					this._CodigoProducto = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NombreProducto", DbType="VarChar(100)")]
		public string NombreProducto
		{
			get
			{
				return this._NombreProducto;
			}
			set
			{
				if ((this._NombreProducto != value))
				{
					this._NombreProducto = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cant_Solicitada", DbType="Decimal(18,4)")]
		public System.Nullable<decimal> Cant_Solicitada
		{
			get
			{
				return this._Cant_Solicitada;
			}
			set
			{
				if ((this._Cant_Solicitada != value))
				{
					this._Cant_Solicitada = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FechaCreacion", DbType="DateTime")]
		public System.Nullable<System.DateTime> FechaCreacion
		{
			get
			{
				return this._FechaCreacion;
			}
			set
			{
				if ((this._FechaCreacion != value))
				{
					this._FechaCreacion = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id_Estado", DbType="Int")]
		public System.Nullable<int> Id_Estado
		{
			get
			{
				return this._Id_Estado;
			}
			set
			{
				if ((this._Id_Estado != value))
				{
					this._Id_Estado = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Empresa", DbType="BigInt")]
		public System.Nullable<long> Empresa
		{
			get
			{
				return this._Empresa;
			}
			set
			{
				if ((this._Empresa != value))
				{
					this._Empresa = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Tipo_Doc", DbType="BigInt")]
		public System.Nullable<long> Tipo_Doc
		{
			get
			{
				return this._Tipo_Doc;
			}
			set
			{
				if ((this._Tipo_Doc != value))
				{
					this._Tipo_Doc = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id_Zcabecera", DbType="BigInt")]
		public System.Nullable<long> Id_Zcabecera
		{
			get
			{
				return this._Id_Zcabecera;
			}
			set
			{
				if ((this._Id_Zcabecera != value))
				{
					this._Id_Zcabecera = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id_Orden", DbType="BigInt")]
		public System.Nullable<long> Id_Orden
		{
			get
			{
				return this._Id_Orden;
			}
			set
			{
				if ((this._Id_Orden != value))
				{
					this._Id_Orden = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id_OrdenDetalle", DbType="BigInt")]
		public System.Nullable<long> Id_OrdenDetalle
		{
			get
			{
				return this._Id_OrdenDetalle;
			}
			set
			{
				if ((this._Id_OrdenDetalle != value))
				{
					this._Id_OrdenDetalle = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id_EmpresaDestino", DbType="BigInt")]
		public System.Nullable<long> Id_EmpresaDestino
		{
			get
			{
				return this._Id_EmpresaDestino;
			}
			set
			{
				if ((this._Id_EmpresaDestino != value))
				{
					this._Id_EmpresaDestino = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id_ProductoTipoEmbalaje", DbType="BigInt")]
		public System.Nullable<long> Id_ProductoTipoEmbalaje
		{
			get
			{
				return this._Id_ProductoTipoEmbalaje;
			}
			set
			{
				if ((this._Id_ProductoTipoEmbalaje != value))
				{
					this._Id_ProductoTipoEmbalaje = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ACETOGEN_Recepcion")]
	public partial class ACETOGEN_Recepcion : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private long _ID;
		
		private System.Nullable<long> _Id_Orden;
		
		private System.Nullable<long> _Id_OrdenDetalle;
		
		private string _Codigo_Empresa;
		
		private string _Codigo_Documento;
		
		private string _Numero_Orden;
		
		private string _Codigo_Producto;
		
		private System.Nullable<int> _Cantidad_Recepcion;
		
		private System.Nullable<System.DateTime> _FechaTransaccion;
		
		private System.Nullable<long> _Id_Estado;
		
		private System.Nullable<System.DateTime> _FechaCreacion;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(long value);
    partial void OnIDChanged();
    partial void OnId_OrdenChanging(System.Nullable<long> value);
    partial void OnId_OrdenChanged();
    partial void OnId_OrdenDetalleChanging(System.Nullable<long> value);
    partial void OnId_OrdenDetalleChanged();
    partial void OnCodigo_EmpresaChanging(string value);
    partial void OnCodigo_EmpresaChanged();
    partial void OnCodigo_DocumentoChanging(string value);
    partial void OnCodigo_DocumentoChanged();
    partial void OnNumero_OrdenChanging(string value);
    partial void OnNumero_OrdenChanged();
    partial void OnCodigo_ProductoChanging(string value);
    partial void OnCodigo_ProductoChanged();
    partial void OnCantidad_RecepcionChanging(System.Nullable<int> value);
    partial void OnCantidad_RecepcionChanged();
    partial void OnFechaTransaccionChanging(System.Nullable<System.DateTime> value);
    partial void OnFechaTransaccionChanged();
    partial void OnId_EstadoChanging(System.Nullable<long> value);
    partial void OnId_EstadoChanged();
    partial void OnFechaCreacionChanging(System.Nullable<System.DateTime> value);
    partial void OnFechaCreacionChanged();
    #endregion
		
		public ACETOGEN_Recepcion()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="BigInt NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public long ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id_Orden", DbType="BigInt")]
		public System.Nullable<long> Id_Orden
		{
			get
			{
				return this._Id_Orden;
			}
			set
			{
				if ((this._Id_Orden != value))
				{
					this.OnId_OrdenChanging(value);
					this.SendPropertyChanging();
					this._Id_Orden = value;
					this.SendPropertyChanged("Id_Orden");
					this.OnId_OrdenChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id_OrdenDetalle", DbType="BigInt")]
		public System.Nullable<long> Id_OrdenDetalle
		{
			get
			{
				return this._Id_OrdenDetalle;
			}
			set
			{
				if ((this._Id_OrdenDetalle != value))
				{
					this.OnId_OrdenDetalleChanging(value);
					this.SendPropertyChanging();
					this._Id_OrdenDetalle = value;
					this.SendPropertyChanged("Id_OrdenDetalle");
					this.OnId_OrdenDetalleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Codigo_Empresa", DbType="VarChar(50)")]
		public string Codigo_Empresa
		{
			get
			{
				return this._Codigo_Empresa;
			}
			set
			{
				if ((this._Codigo_Empresa != value))
				{
					this.OnCodigo_EmpresaChanging(value);
					this.SendPropertyChanging();
					this._Codigo_Empresa = value;
					this.SendPropertyChanged("Codigo_Empresa");
					this.OnCodigo_EmpresaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Codigo_Documento", DbType="VarChar(50)")]
		public string Codigo_Documento
		{
			get
			{
				return this._Codigo_Documento;
			}
			set
			{
				if ((this._Codigo_Documento != value))
				{
					this.OnCodigo_DocumentoChanging(value);
					this.SendPropertyChanging();
					this._Codigo_Documento = value;
					this.SendPropertyChanged("Codigo_Documento");
					this.OnCodigo_DocumentoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Numero_Orden", DbType="VarChar(50)")]
		public string Numero_Orden
		{
			get
			{
				return this._Numero_Orden;
			}
			set
			{
				if ((this._Numero_Orden != value))
				{
					this.OnNumero_OrdenChanging(value);
					this.SendPropertyChanging();
					this._Numero_Orden = value;
					this.SendPropertyChanged("Numero_Orden");
					this.OnNumero_OrdenChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Codigo_Producto", DbType="VarChar(50)")]
		public string Codigo_Producto
		{
			get
			{
				return this._Codigo_Producto;
			}
			set
			{
				if ((this._Codigo_Producto != value))
				{
					this.OnCodigo_ProductoChanging(value);
					this.SendPropertyChanging();
					this._Codigo_Producto = value;
					this.SendPropertyChanged("Codigo_Producto");
					this.OnCodigo_ProductoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cantidad_Recepcion", DbType="Int")]
		public System.Nullable<int> Cantidad_Recepcion
		{
			get
			{
				return this._Cantidad_Recepcion;
			}
			set
			{
				if ((this._Cantidad_Recepcion != value))
				{
					this.OnCantidad_RecepcionChanging(value);
					this.SendPropertyChanging();
					this._Cantidad_Recepcion = value;
					this.SendPropertyChanged("Cantidad_Recepcion");
					this.OnCantidad_RecepcionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FechaTransaccion", DbType="DateTime")]
		public System.Nullable<System.DateTime> FechaTransaccion
		{
			get
			{
				return this._FechaTransaccion;
			}
			set
			{
				if ((this._FechaTransaccion != value))
				{
					this.OnFechaTransaccionChanging(value);
					this.SendPropertyChanging();
					this._FechaTransaccion = value;
					this.SendPropertyChanged("FechaTransaccion");
					this.OnFechaTransaccionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id_Estado", DbType="BigInt")]
		public System.Nullable<long> Id_Estado
		{
			get
			{
				return this._Id_Estado;
			}
			set
			{
				if ((this._Id_Estado != value))
				{
					this.OnId_EstadoChanging(value);
					this.SendPropertyChanging();
					this._Id_Estado = value;
					this.SendPropertyChanged("Id_Estado");
					this.OnId_EstadoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FechaCreacion", DbType="DateTime")]
		public System.Nullable<System.DateTime> FechaCreacion
		{
			get
			{
				return this._FechaCreacion;
			}
			set
			{
				if ((this._FechaCreacion != value))
				{
					this.OnFechaCreacionChanging(value);
					this.SendPropertyChanging();
					this._FechaCreacion = value;
					this.SendPropertyChanged("FechaCreacion");
					this.OnFechaCreacionChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ACETOGEN_Picking")]
	public partial class ACETOGEN_Picking : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private long _ID;
		
		private System.Nullable<long> _Id_Orden;
		
		private System.Nullable<long> _Id_OrdenDetalle;
		
		private string _Codigo_Empresa;
		
		private string _Codigo_Documento;
		
		private string _Numero_Orden;
		
		private string _Codigo_Producto;
		
		private System.Nullable<int> _Cantidad_Picking;
		
		private System.Nullable<System.DateTime> _FechaTransaccion;
		
		private System.Nullable<long> _Id_Estado;
		
		private System.Nullable<System.DateTime> _FechaCreacion;
		
		private System.Nullable<long> _TipoDoc;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(long value);
    partial void OnIDChanged();
    partial void OnId_OrdenChanging(System.Nullable<long> value);
    partial void OnId_OrdenChanged();
    partial void OnId_OrdenDetalleChanging(System.Nullable<long> value);
    partial void OnId_OrdenDetalleChanged();
    partial void OnCodigo_EmpresaChanging(string value);
    partial void OnCodigo_EmpresaChanged();
    partial void OnCodigo_DocumentoChanging(string value);
    partial void OnCodigo_DocumentoChanged();
    partial void OnNumero_OrdenChanging(string value);
    partial void OnNumero_OrdenChanged();
    partial void OnCodigo_ProductoChanging(string value);
    partial void OnCodigo_ProductoChanged();
    partial void OnCantidad_PickingChanging(System.Nullable<int> value);
    partial void OnCantidad_PickingChanged();
    partial void OnFechaTransaccionChanging(System.Nullable<System.DateTime> value);
    partial void OnFechaTransaccionChanged();
    partial void OnId_EstadoChanging(System.Nullable<long> value);
    partial void OnId_EstadoChanged();
    partial void OnFechaCreacionChanging(System.Nullable<System.DateTime> value);
    partial void OnFechaCreacionChanged();
    partial void OnTipoDocChanging(System.Nullable<long> value);
    partial void OnTipoDocChanged();
    #endregion
		
		public ACETOGEN_Picking()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="BigInt NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public long ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id_Orden", DbType="BigInt")]
		public System.Nullable<long> Id_Orden
		{
			get
			{
				return this._Id_Orden;
			}
			set
			{
				if ((this._Id_Orden != value))
				{
					this.OnId_OrdenChanging(value);
					this.SendPropertyChanging();
					this._Id_Orden = value;
					this.SendPropertyChanged("Id_Orden");
					this.OnId_OrdenChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id_OrdenDetalle", DbType="BigInt")]
		public System.Nullable<long> Id_OrdenDetalle
		{
			get
			{
				return this._Id_OrdenDetalle;
			}
			set
			{
				if ((this._Id_OrdenDetalle != value))
				{
					this.OnId_OrdenDetalleChanging(value);
					this.SendPropertyChanging();
					this._Id_OrdenDetalle = value;
					this.SendPropertyChanged("Id_OrdenDetalle");
					this.OnId_OrdenDetalleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Codigo_Empresa", DbType="VarChar(50)")]
		public string Codigo_Empresa
		{
			get
			{
				return this._Codigo_Empresa;
			}
			set
			{
				if ((this._Codigo_Empresa != value))
				{
					this.OnCodigo_EmpresaChanging(value);
					this.SendPropertyChanging();
					this._Codigo_Empresa = value;
					this.SendPropertyChanged("Codigo_Empresa");
					this.OnCodigo_EmpresaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Codigo_Documento", DbType="VarChar(50)")]
		public string Codigo_Documento
		{
			get
			{
				return this._Codigo_Documento;
			}
			set
			{
				if ((this._Codigo_Documento != value))
				{
					this.OnCodigo_DocumentoChanging(value);
					this.SendPropertyChanging();
					this._Codigo_Documento = value;
					this.SendPropertyChanged("Codigo_Documento");
					this.OnCodigo_DocumentoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Numero_Orden", DbType="VarChar(50)")]
		public string Numero_Orden
		{
			get
			{
				return this._Numero_Orden;
			}
			set
			{
				if ((this._Numero_Orden != value))
				{
					this.OnNumero_OrdenChanging(value);
					this.SendPropertyChanging();
					this._Numero_Orden = value;
					this.SendPropertyChanged("Numero_Orden");
					this.OnNumero_OrdenChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Codigo_Producto", DbType="VarChar(50)")]
		public string Codigo_Producto
		{
			get
			{
				return this._Codigo_Producto;
			}
			set
			{
				if ((this._Codigo_Producto != value))
				{
					this.OnCodigo_ProductoChanging(value);
					this.SendPropertyChanging();
					this._Codigo_Producto = value;
					this.SendPropertyChanged("Codigo_Producto");
					this.OnCodigo_ProductoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cantidad_Picking", DbType="Int")]
		public System.Nullable<int> Cantidad_Picking
		{
			get
			{
				return this._Cantidad_Picking;
			}
			set
			{
				if ((this._Cantidad_Picking != value))
				{
					this.OnCantidad_PickingChanging(value);
					this.SendPropertyChanging();
					this._Cantidad_Picking = value;
					this.SendPropertyChanged("Cantidad_Picking");
					this.OnCantidad_PickingChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FechaTransaccion", DbType="DateTime")]
		public System.Nullable<System.DateTime> FechaTransaccion
		{
			get
			{
				return this._FechaTransaccion;
			}
			set
			{
				if ((this._FechaTransaccion != value))
				{
					this.OnFechaTransaccionChanging(value);
					this.SendPropertyChanging();
					this._FechaTransaccion = value;
					this.SendPropertyChanged("FechaTransaccion");
					this.OnFechaTransaccionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id_Estado", DbType="BigInt")]
		public System.Nullable<long> Id_Estado
		{
			get
			{
				return this._Id_Estado;
			}
			set
			{
				if ((this._Id_Estado != value))
				{
					this.OnId_EstadoChanging(value);
					this.SendPropertyChanging();
					this._Id_Estado = value;
					this.SendPropertyChanged("Id_Estado");
					this.OnId_EstadoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FechaCreacion", DbType="DateTime")]
		public System.Nullable<System.DateTime> FechaCreacion
		{
			get
			{
				return this._FechaCreacion;
			}
			set
			{
				if ((this._FechaCreacion != value))
				{
					this.OnFechaCreacionChanging(value);
					this.SendPropertyChanging();
					this._FechaCreacion = value;
					this.SendPropertyChanged("FechaCreacion");
					this.OnFechaCreacionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TipoDoc", DbType="BigInt")]
		public System.Nullable<long> TipoDoc
		{
			get
			{
				return this._TipoDoc;
			}
			set
			{
				if ((this._TipoDoc != value))
				{
					this.OnTipoDocChanging(value);
					this.SendPropertyChanging();
					this._TipoDoc = value;
					this.SendPropertyChanged("TipoDoc");
					this.OnTipoDocChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591