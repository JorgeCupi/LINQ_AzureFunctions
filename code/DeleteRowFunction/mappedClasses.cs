#r "System.XML.Linq"

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;



[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="functionsdb")]
public partial class Functionsdb : System.Data.Linq.DataContext
{
	
	private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
	
  #region Extensibility Method Definitions
  partial void OnCreated();
  #endregion
	
	public Functionsdb(string connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public System.Data.Linq.Table<SalesLT_Address> SalesLT_Address
	{
		get
		{
			return this.GetTable<SalesLT_Address>();
		}
	}
	
	public System.Data.Linq.Table<BuildVersion> BuildVersion
	{
		get
		{
			return this.GetTable<BuildVersion>();
		}
	}
	
	public System.Data.Linq.Table<SalesLT_Customer> SalesLT_Customer
	{
		get
		{
			return this.GetTable<SalesLT_Customer>();
		}
	}
	
	public System.Data.Linq.Table<SalesLT_CustomerAddress> SalesLT_CustomerAddress
	{
		get
		{
			return this.GetTable<SalesLT_CustomerAddress>();
		}
	}
	
	public System.Data.Linq.Table<ErrorLog> ErrorLog
	{
		get
		{
			return this.GetTable<ErrorLog>();
		}
	}
	
	public System.Data.Linq.Table<SalesLT_Product> SalesLT_Product
	{
		get
		{
			return this.GetTable<SalesLT_Product>();
		}
	}
	
	public System.Data.Linq.Table<SalesLT_ProductCategory> SalesLT_ProductCategory
	{
		get
		{
			return this.GetTable<SalesLT_ProductCategory>();
		}
	}
	
	public System.Data.Linq.Table<SalesLT_ProductDescription> SalesLT_ProductDescription
	{
		get
		{
			return this.GetTable<SalesLT_ProductDescription>();
		}
	}
	
	public System.Data.Linq.Table<SalesLT_ProductModel> SalesLT_ProductModel
	{
		get
		{
			return this.GetTable<SalesLT_ProductModel>();
		}
	}
	
	public System.Data.Linq.Table<SalesLT_ProductModelProductDescription> SalesLT_ProductModelProductDescription
	{
		get
		{
			return this.GetTable<SalesLT_ProductModelProductDescription>();
		}
	}
	
	public System.Data.Linq.Table<SalesLT_SalesOrderDetail> SalesLT_SalesOrderDetail
	{
		get
		{
			return this.GetTable<SalesLT_SalesOrderDetail>();
		}
	}
	
	public System.Data.Linq.Table<SalesLT_SalesOrderHeader> SalesLT_SalesOrderHeader
	{
		get
		{
			return this.GetTable<SalesLT_SalesOrderHeader>();
		}
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="SalesLT.Address")]
public partial class SalesLT_Address : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _AddressID;
	
	private string _AddressLine1;
	
	private string _AddressLine2;
	
	private string _City;
	
	private string _StateProvince;
	
	private string _CountryRegion;
	
	private string _PostalCode;
	
	private System.Guid _Rowguid;
	
	private System.DateTime _ModifiedDate;
	
	private EntitySet<SalesLT_CustomerAddress> _SalesLT_CustomerAddress;
	
	private EntitySet<SalesLT_SalesOrderHeader> _SalesLT_SalesOrderHeader;
	
	private EntitySet<SalesLT_SalesOrderHeader> _Address;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnAddressIDChanging(int value);
    partial void OnAddressIDChanged();
    partial void OnAddressLine1Changing(string value);
    partial void OnAddressLine1Changed();
    partial void OnAddressLine2Changing(string value);
    partial void OnAddressLine2Changed();
    partial void OnCityChanging(string value);
    partial void OnCityChanged();
    partial void OnStateProvinceChanging(string value);
    partial void OnStateProvinceChanged();
    partial void OnCountryRegionChanging(string value);
    partial void OnCountryRegionChanged();
    partial void OnPostalCodeChanging(string value);
    partial void OnPostalCodeChanged();
    partial void OnRowguidChanging(System.Guid value);
    partial void OnRowguidChanged();
    partial void OnModifiedDateChanging(System.DateTime value);
    partial void OnModifiedDateChanged();
    #endregion
	
	public SalesLT_Address()
	{
		this._SalesLT_CustomerAddress = new EntitySet<SalesLT_CustomerAddress>(new Action<SalesLT_CustomerAddress>(this.attach_SalesLT_CustomerAddress), new Action<SalesLT_CustomerAddress>(this.detach_SalesLT_CustomerAddress));
		this._SalesLT_SalesOrderHeader = new EntitySet<SalesLT_SalesOrderHeader>(new Action<SalesLT_SalesOrderHeader>(this.attach_SalesLT_SalesOrderHeader), new Action<SalesLT_SalesOrderHeader>(this.detach_SalesLT_SalesOrderHeader));
		this._Address = new EntitySet<SalesLT_SalesOrderHeader>(new Action<SalesLT_SalesOrderHeader>(this.attach_Address), new Action<SalesLT_SalesOrderHeader>(this.detach_Address));
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AddressID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int AddressID
	{
		get
		{
			return this._AddressID;
		}
		set
		{
			if ((this._AddressID != value))
			{
				this.OnAddressIDChanging(value);
				this.SendPropertyChanging();
				this._AddressID = value;
				this.SendPropertyChanged("AddressID");
				this.OnAddressIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AddressLine1", DbType="NVarChar(60) NOT NULL", CanBeNull=false)]
	public string AddressLine1
	{
		get
		{
			return this._AddressLine1;
		}
		set
		{
			if ((this._AddressLine1 != value))
			{
				this.OnAddressLine1Changing(value);
				this.SendPropertyChanging();
				this._AddressLine1 = value;
				this.SendPropertyChanged("AddressLine1");
				this.OnAddressLine1Changed();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AddressLine2", DbType="NVarChar(60)")]
	public string AddressLine2
	{
		get
		{
			return this._AddressLine2;
		}
		set
		{
			if ((this._AddressLine2 != value))
			{
				this.OnAddressLine2Changing(value);
				this.SendPropertyChanging();
				this._AddressLine2 = value;
				this.SendPropertyChanged("AddressLine2");
				this.OnAddressLine2Changed();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_City", DbType="NVarChar(30) NOT NULL", CanBeNull=false)]
	public string City
	{
		get
		{
			return this._City;
		}
		set
		{
			if ((this._City != value))
			{
				this.OnCityChanging(value);
				this.SendPropertyChanging();
				this._City = value;
				this.SendPropertyChanged("City");
				this.OnCityChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StateProvince", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
	public string StateProvince
	{
		get
		{
			return this._StateProvince;
		}
		set
		{
			if ((this._StateProvince != value))
			{
				this.OnStateProvinceChanging(value);
				this.SendPropertyChanging();
				this._StateProvince = value;
				this.SendPropertyChanged("StateProvince");
				this.OnStateProvinceChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CountryRegion", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
	public string CountryRegion
	{
		get
		{
			return this._CountryRegion;
		}
		set
		{
			if ((this._CountryRegion != value))
			{
				this.OnCountryRegionChanging(value);
				this.SendPropertyChanging();
				this._CountryRegion = value;
				this.SendPropertyChanged("CountryRegion");
				this.OnCountryRegionChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PostalCode", DbType="NVarChar(15) NOT NULL", CanBeNull=false)]
	public string PostalCode
	{
		get
		{
			return this._PostalCode;
		}
		set
		{
			if ((this._PostalCode != value))
			{
				this.OnPostalCodeChanging(value);
				this.SendPropertyChanging();
				this._PostalCode = value;
				this.SendPropertyChanged("PostalCode");
				this.OnPostalCodeChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Name="rowguid", Storage="_Rowguid", DbType="UniqueIdentifier NOT NULL")]
	public System.Guid Rowguid
	{
		get
		{
			return this._Rowguid;
		}
		set
		{
			if ((this._Rowguid != value))
			{
				this.OnRowguidChanging(value);
				this.SendPropertyChanging();
				this._Rowguid = value;
				this.SendPropertyChanged("Rowguid");
				this.OnRowguidChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ModifiedDate", DbType="DateTime NOT NULL")]
	public System.DateTime ModifiedDate
	{
		get
		{
			return this._ModifiedDate;
		}
		set
		{
			if ((this._ModifiedDate != value))
			{
				this.OnModifiedDateChanging(value);
				this.SendPropertyChanging();
				this._ModifiedDate = value;
				this.SendPropertyChanged("ModifiedDate");
				this.OnModifiedDateChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="FK_CustomerAddress_Address_AddressID", Storage="_SalesLT_CustomerAddress", ThisKey="AddressID", OtherKey="AddressID", DeleteRule="NO ACTION")]
	public EntitySet<SalesLT_CustomerAddress> SalesLT_CustomerAddress
	{
		get
		{
			return this._SalesLT_CustomerAddress;
		}
		set
		{
			this._SalesLT_CustomerAddress.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="FK_SalesOrderHeader_Address_BillTo_AddressID", Storage="_SalesLT_SalesOrderHeader", ThisKey="AddressID", OtherKey="BillToAddressID", DeleteRule="NO ACTION")]
	public EntitySet<SalesLT_SalesOrderHeader> SalesLT_SalesOrderHeader
	{
		get
		{
			return this._SalesLT_SalesOrderHeader;
		}
		set
		{
			this._SalesLT_SalesOrderHeader.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="FK_SalesOrderHeader_Address_ShipTo_AddressID", Storage="_Address", ThisKey="AddressID", OtherKey="ShipToAddressID", DeleteRule="NO ACTION")]
	public EntitySet<SalesLT_SalesOrderHeader> Address
	{
		get
		{
			return this._Address;
		}
		set
		{
			this._Address.Assign(value);
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
	
	private void attach_SalesLT_CustomerAddress(SalesLT_CustomerAddress entity)
	{
		this.SendPropertyChanging();
		entity.SalesLT_Address = this;
	}
	
	private void detach_SalesLT_CustomerAddress(SalesLT_CustomerAddress entity)
	{
		this.SendPropertyChanging();
		entity.SalesLT_Address = null;
	}
	
	private void attach_SalesLT_SalesOrderHeader(SalesLT_SalesOrderHeader entity)
	{
		this.SendPropertyChanging();
		entity.SalesLT_Address = this;
	}
	
	private void detach_SalesLT_SalesOrderHeader(SalesLT_SalesOrderHeader entity)
	{
		this.SendPropertyChanging();
		entity.SalesLT_Address = null;
	}
	
	private void attach_Address(SalesLT_SalesOrderHeader entity)
	{
		this.SendPropertyChanging();
		entity.ShipToAddress = this;
	}
	
	private void detach_Address(SalesLT_SalesOrderHeader entity)
	{
		this.SendPropertyChanging();
		entity.ShipToAddress = null;
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.BuildVersion")]
public partial class BuildVersion : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private byte _SystemInformationID;
	
	private string _DatabaseVersion;
	
	private System.DateTime _VersionDate;
	
	private System.DateTime _ModifiedDate;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnSystemInformationIDChanging(byte value);
    partial void OnSystemInformationIDChanged();
    partial void OnDatabaseVersionChanging(string value);
    partial void OnDatabaseVersionChanged();
    partial void OnVersionDateChanging(System.DateTime value);
    partial void OnVersionDateChanged();
    partial void OnModifiedDateChanging(System.DateTime value);
    partial void OnModifiedDateChanged();
    #endregion
	
	public BuildVersion()
	{
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SystemInformationID", AutoSync=AutoSync.OnInsert, DbType="TinyInt NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public byte SystemInformationID
	{
		get
		{
			return this._SystemInformationID;
		}
		set
		{
			if ((this._SystemInformationID != value))
			{
				this.OnSystemInformationIDChanging(value);
				this.SendPropertyChanging();
				this._SystemInformationID = value;
				this.SendPropertyChanged("SystemInformationID");
				this.OnSystemInformationIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Name="Database Version", Storage="_DatabaseVersion", DbType="NVarChar(25) NOT NULL", CanBeNull=false)]
	public string DatabaseVersion
	{
		get
		{
			return this._DatabaseVersion;
		}
		set
		{
			if ((this._DatabaseVersion != value))
			{
				this.OnDatabaseVersionChanging(value);
				this.SendPropertyChanging();
				this._DatabaseVersion = value;
				this.SendPropertyChanged("DatabaseVersion");
				this.OnDatabaseVersionChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_VersionDate", DbType="DateTime NOT NULL")]
	public System.DateTime VersionDate
	{
		get
		{
			return this._VersionDate;
		}
		set
		{
			if ((this._VersionDate != value))
			{
				this.OnVersionDateChanging(value);
				this.SendPropertyChanging();
				this._VersionDate = value;
				this.SendPropertyChanged("VersionDate");
				this.OnVersionDateChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ModifiedDate", DbType="DateTime NOT NULL")]
	public System.DateTime ModifiedDate
	{
		get
		{
			return this._ModifiedDate;
		}
		set
		{
			if ((this._ModifiedDate != value))
			{
				this.OnModifiedDateChanging(value);
				this.SendPropertyChanging();
				this._ModifiedDate = value;
				this.SendPropertyChanged("ModifiedDate");
				this.OnModifiedDateChanged();
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

[global::System.Data.Linq.Mapping.TableAttribute(Name="SalesLT.Customer")]
public partial class SalesLT_Customer : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _CustomerID;
	
	private bool _NameStyle;
	
	private string _Title;
	
	private string _FirstName;
	
	private string _MiddleName;
	
	private string _LastName;
	
	private string _Suffix;
	
	private string _CompanyName;
	
	private string _SalesPerson;
	
	private string _EmailAddress;
	
	private string _Phone;
	
	private string _PasswordHash;
	
	private string _PasswordSalt;
	
	private System.Guid _Rowguid;
	
	private System.DateTime _ModifiedDate;
	
	private EntitySet<SalesLT_CustomerAddress> _SalesLT_CustomerAddress;
	
	private EntitySet<SalesLT_SalesOrderHeader> _SalesLT_SalesOrderHeader;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCustomerIDChanging(int value);
    partial void OnCustomerIDChanged();
    partial void OnNameStyleChanging(bool value);
    partial void OnNameStyleChanged();
    partial void OnTitleChanging(string value);
    partial void OnTitleChanged();
    partial void OnFirstNameChanging(string value);
    partial void OnFirstNameChanged();
    partial void OnMiddleNameChanging(string value);
    partial void OnMiddleNameChanged();
    partial void OnLastNameChanging(string value);
    partial void OnLastNameChanged();
    partial void OnSuffixChanging(string value);
    partial void OnSuffixChanged();
    partial void OnCompanyNameChanging(string value);
    partial void OnCompanyNameChanged();
    partial void OnSalesPersonChanging(string value);
    partial void OnSalesPersonChanged();
    partial void OnEmailAddressChanging(string value);
    partial void OnEmailAddressChanged();
    partial void OnPhoneChanging(string value);
    partial void OnPhoneChanged();
    partial void OnPasswordHashChanging(string value);
    partial void OnPasswordHashChanged();
    partial void OnPasswordSaltChanging(string value);
    partial void OnPasswordSaltChanged();
    partial void OnRowguidChanging(System.Guid value);
    partial void OnRowguidChanged();
    partial void OnModifiedDateChanging(System.DateTime value);
    partial void OnModifiedDateChanged();
    #endregion
	
	public SalesLT_Customer()
	{
		this._SalesLT_CustomerAddress = new EntitySet<SalesLT_CustomerAddress>(new Action<SalesLT_CustomerAddress>(this.attach_SalesLT_CustomerAddress), new Action<SalesLT_CustomerAddress>(this.detach_SalesLT_CustomerAddress));
		this._SalesLT_SalesOrderHeader = new EntitySet<SalesLT_SalesOrderHeader>(new Action<SalesLT_SalesOrderHeader>(this.attach_SalesLT_SalesOrderHeader), new Action<SalesLT_SalesOrderHeader>(this.detach_SalesLT_SalesOrderHeader));
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CustomerID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int CustomerID
	{
		get
		{
			return this._CustomerID;
		}
		set
		{
			if ((this._CustomerID != value))
			{
				this.OnCustomerIDChanging(value);
				this.SendPropertyChanging();
				this._CustomerID = value;
				this.SendPropertyChanged("CustomerID");
				this.OnCustomerIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NameStyle", DbType="Bit NOT NULL")]
	public bool NameStyle
	{
		get
		{
			return this._NameStyle;
		}
		set
		{
			if ((this._NameStyle != value))
			{
				this.OnNameStyleChanging(value);
				this.SendPropertyChanging();
				this._NameStyle = value;
				this.SendPropertyChanged("NameStyle");
				this.OnNameStyleChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Title", DbType="NVarChar(8)")]
	public string Title
	{
		get
		{
			return this._Title;
		}
		set
		{
			if ((this._Title != value))
			{
				this.OnTitleChanging(value);
				this.SendPropertyChanging();
				this._Title = value;
				this.SendPropertyChanged("Title");
				this.OnTitleChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FirstName", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
	public string FirstName
	{
		get
		{
			return this._FirstName;
		}
		set
		{
			if ((this._FirstName != value))
			{
				this.OnFirstNameChanging(value);
				this.SendPropertyChanging();
				this._FirstName = value;
				this.SendPropertyChanged("FirstName");
				this.OnFirstNameChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MiddleName", DbType="NVarChar(50)")]
	public string MiddleName
	{
		get
		{
			return this._MiddleName;
		}
		set
		{
			if ((this._MiddleName != value))
			{
				this.OnMiddleNameChanging(value);
				this.SendPropertyChanging();
				this._MiddleName = value;
				this.SendPropertyChanged("MiddleName");
				this.OnMiddleNameChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LastName", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
	public string LastName
	{
		get
		{
			return this._LastName;
		}
		set
		{
			if ((this._LastName != value))
			{
				this.OnLastNameChanging(value);
				this.SendPropertyChanging();
				this._LastName = value;
				this.SendPropertyChanged("LastName");
				this.OnLastNameChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Suffix", DbType="NVarChar(10)")]
	public string Suffix
	{
		get
		{
			return this._Suffix;
		}
		set
		{
			if ((this._Suffix != value))
			{
				this.OnSuffixChanging(value);
				this.SendPropertyChanging();
				this._Suffix = value;
				this.SendPropertyChanged("Suffix");
				this.OnSuffixChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CompanyName", DbType="NVarChar(128)")]
	public string CompanyName
	{
		get
		{
			return this._CompanyName;
		}
		set
		{
			if ((this._CompanyName != value))
			{
				this.OnCompanyNameChanging(value);
				this.SendPropertyChanging();
				this._CompanyName = value;
				this.SendPropertyChanged("CompanyName");
				this.OnCompanyNameChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SalesPerson", DbType="NVarChar(256)")]
	public string SalesPerson
	{
		get
		{
			return this._SalesPerson;
		}
		set
		{
			if ((this._SalesPerson != value))
			{
				this.OnSalesPersonChanging(value);
				this.SendPropertyChanging();
				this._SalesPerson = value;
				this.SendPropertyChanged("SalesPerson");
				this.OnSalesPersonChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EmailAddress", DbType="NVarChar(50)")]
	public string EmailAddress
	{
		get
		{
			return this._EmailAddress;
		}
		set
		{
			if ((this._EmailAddress != value))
			{
				this.OnEmailAddressChanging(value);
				this.SendPropertyChanging();
				this._EmailAddress = value;
				this.SendPropertyChanged("EmailAddress");
				this.OnEmailAddressChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Phone", DbType="NVarChar(25)")]
	public string Phone
	{
		get
		{
			return this._Phone;
		}
		set
		{
			if ((this._Phone != value))
			{
				this.OnPhoneChanging(value);
				this.SendPropertyChanging();
				this._Phone = value;
				this.SendPropertyChanged("Phone");
				this.OnPhoneChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PasswordHash", DbType="VarChar(128) NOT NULL", CanBeNull=false)]
	public string PasswordHash
	{
		get
		{
			return this._PasswordHash;
		}
		set
		{
			if ((this._PasswordHash != value))
			{
				this.OnPasswordHashChanging(value);
				this.SendPropertyChanging();
				this._PasswordHash = value;
				this.SendPropertyChanged("PasswordHash");
				this.OnPasswordHashChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PasswordSalt", DbType="VarChar(10) NOT NULL", CanBeNull=false)]
	public string PasswordSalt
	{
		get
		{
			return this._PasswordSalt;
		}
		set
		{
			if ((this._PasswordSalt != value))
			{
				this.OnPasswordSaltChanging(value);
				this.SendPropertyChanging();
				this._PasswordSalt = value;
				this.SendPropertyChanged("PasswordSalt");
				this.OnPasswordSaltChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Name="rowguid", Storage="_Rowguid", DbType="UniqueIdentifier NOT NULL")]
	public System.Guid Rowguid
	{
		get
		{
			return this._Rowguid;
		}
		set
		{
			if ((this._Rowguid != value))
			{
				this.OnRowguidChanging(value);
				this.SendPropertyChanging();
				this._Rowguid = value;
				this.SendPropertyChanged("Rowguid");
				this.OnRowguidChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ModifiedDate", DbType="DateTime NOT NULL")]
	public System.DateTime ModifiedDate
	{
		get
		{
			return this._ModifiedDate;
		}
		set
		{
			if ((this._ModifiedDate != value))
			{
				this.OnModifiedDateChanging(value);
				this.SendPropertyChanging();
				this._ModifiedDate = value;
				this.SendPropertyChanged("ModifiedDate");
				this.OnModifiedDateChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="FK_CustomerAddress_Customer_CustomerID", Storage="_SalesLT_CustomerAddress", ThisKey="CustomerID", OtherKey="CustomerID", DeleteRule="NO ACTION")]
	public EntitySet<SalesLT_CustomerAddress> SalesLT_CustomerAddress
	{
		get
		{
			return this._SalesLT_CustomerAddress;
		}
		set
		{
			this._SalesLT_CustomerAddress.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="FK_SalesOrderHeader_Customer_CustomerID", Storage="_SalesLT_SalesOrderHeader", ThisKey="CustomerID", OtherKey="CustomerID", DeleteRule="NO ACTION")]
	public EntitySet<SalesLT_SalesOrderHeader> SalesLT_SalesOrderHeader
	{
		get
		{
			return this._SalesLT_SalesOrderHeader;
		}
		set
		{
			this._SalesLT_SalesOrderHeader.Assign(value);
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
	
	private void attach_SalesLT_CustomerAddress(SalesLT_CustomerAddress entity)
	{
		this.SendPropertyChanging();
		entity.SalesLT_Customer = this;
	}
	
	private void detach_SalesLT_CustomerAddress(SalesLT_CustomerAddress entity)
	{
		this.SendPropertyChanging();
		entity.SalesLT_Customer = null;
	}
	
	private void attach_SalesLT_SalesOrderHeader(SalesLT_SalesOrderHeader entity)
	{
		this.SendPropertyChanging();
		entity.SalesLT_Customer = this;
	}
	
	private void detach_SalesLT_SalesOrderHeader(SalesLT_SalesOrderHeader entity)
	{
		this.SendPropertyChanging();
		entity.SalesLT_Customer = null;
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="SalesLT.CustomerAddress")]
public partial class SalesLT_CustomerAddress : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _CustomerID;
	
	private int _AddressID;
	
	private string _AddressType;
	
	private System.Guid _Rowguid;
	
	private System.DateTime _ModifiedDate;
	
	private EntityRef<SalesLT_Address> _SalesLT_Address;
	
	private EntityRef<SalesLT_Customer> _SalesLT_Customer;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCustomerIDChanging(int value);
    partial void OnCustomerIDChanged();
    partial void OnAddressIDChanging(int value);
    partial void OnAddressIDChanged();
    partial void OnAddressTypeChanging(string value);
    partial void OnAddressTypeChanged();
    partial void OnRowguidChanging(System.Guid value);
    partial void OnRowguidChanged();
    partial void OnModifiedDateChanging(System.DateTime value);
    partial void OnModifiedDateChanged();
    #endregion
	
	public SalesLT_CustomerAddress()
	{
		this._SalesLT_Address = default(EntityRef<SalesLT_Address>);
		this._SalesLT_Customer = default(EntityRef<SalesLT_Customer>);
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CustomerID", DbType="Int NOT NULL", IsPrimaryKey=true)]
	public int CustomerID
	{
		get
		{
			return this._CustomerID;
		}
		set
		{
			if ((this._CustomerID != value))
			{
				if (this._SalesLT_Customer.HasLoadedOrAssignedValue)
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnCustomerIDChanging(value);
				this.SendPropertyChanging();
				this._CustomerID = value;
				this.SendPropertyChanged("CustomerID");
				this.OnCustomerIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AddressID", DbType="Int NOT NULL", IsPrimaryKey=true)]
	public int AddressID
	{
		get
		{
			return this._AddressID;
		}
		set
		{
			if ((this._AddressID != value))
			{
				if (this._SalesLT_Address.HasLoadedOrAssignedValue)
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnAddressIDChanging(value);
				this.SendPropertyChanging();
				this._AddressID = value;
				this.SendPropertyChanged("AddressID");
				this.OnAddressIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AddressType", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
	public string AddressType
	{
		get
		{
			return this._AddressType;
		}
		set
		{
			if ((this._AddressType != value))
			{
				this.OnAddressTypeChanging(value);
				this.SendPropertyChanging();
				this._AddressType = value;
				this.SendPropertyChanged("AddressType");
				this.OnAddressTypeChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Name="rowguid", Storage="_Rowguid", DbType="UniqueIdentifier NOT NULL")]
	public System.Guid Rowguid
	{
		get
		{
			return this._Rowguid;
		}
		set
		{
			if ((this._Rowguid != value))
			{
				this.OnRowguidChanging(value);
				this.SendPropertyChanging();
				this._Rowguid = value;
				this.SendPropertyChanged("Rowguid");
				this.OnRowguidChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ModifiedDate", DbType="DateTime NOT NULL")]
	public System.DateTime ModifiedDate
	{
		get
		{
			return this._ModifiedDate;
		}
		set
		{
			if ((this._ModifiedDate != value))
			{
				this.OnModifiedDateChanging(value);
				this.SendPropertyChanging();
				this._ModifiedDate = value;
				this.SendPropertyChanged("ModifiedDate");
				this.OnModifiedDateChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="FK_CustomerAddress_Address_AddressID", Storage="_SalesLT_Address", ThisKey="AddressID", OtherKey="AddressID", IsForeignKey=true)]
	public SalesLT_Address SalesLT_Address
	{
		get
		{
			return this._SalesLT_Address.Entity;
		}
		set
		{
			SalesLT_Address previousValue = this._SalesLT_Address.Entity;
			if (((previousValue != value) 
						|| (this._SalesLT_Address.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._SalesLT_Address.Entity = null;
					previousValue.SalesLT_CustomerAddress.Remove(this);
				}
				this._SalesLT_Address.Entity = value;
				if ((value != null))
				{
					value.SalesLT_CustomerAddress.Add(this);
					this._AddressID = value.AddressID;
				}
				else
				{
					this._AddressID = default(int);
				}
				this.SendPropertyChanged("SalesLT_Address");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="FK_CustomerAddress_Customer_CustomerID", Storage="_SalesLT_Customer", ThisKey="CustomerID", OtherKey="CustomerID", IsForeignKey=true)]
	public SalesLT_Customer SalesLT_Customer
	{
		get
		{
			return this._SalesLT_Customer.Entity;
		}
		set
		{
			SalesLT_Customer previousValue = this._SalesLT_Customer.Entity;
			if (((previousValue != value) 
						|| (this._SalesLT_Customer.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._SalesLT_Customer.Entity = null;
					previousValue.SalesLT_CustomerAddress.Remove(this);
				}
				this._SalesLT_Customer.Entity = value;
				if ((value != null))
				{
					value.SalesLT_CustomerAddress.Add(this);
					this._CustomerID = value.CustomerID;
				}
				else
				{
					this._CustomerID = default(int);
				}
				this.SendPropertyChanged("SalesLT_Customer");
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

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ErrorLog")]
public partial class ErrorLog : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _ErrorLogID;
	
	private System.DateTime _ErrorTime;
	
	private string _UserName;
	
	private int _ErrorNumber;
	
	private System.Nullable<int> _ErrorSeverity;
	
	private System.Nullable<int> _ErrorState;
	
	private string _ErrorProcedure;
	
	private System.Nullable<int> _ErrorLine;
	
	private string _ErrorMessage;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnErrorLogIDChanging(int value);
    partial void OnErrorLogIDChanged();
    partial void OnErrorTimeChanging(System.DateTime value);
    partial void OnErrorTimeChanged();
    partial void OnUserNameChanging(string value);
    partial void OnUserNameChanged();
    partial void OnErrorNumberChanging(int value);
    partial void OnErrorNumberChanged();
    partial void OnErrorSeverityChanging(System.Nullable<int> value);
    partial void OnErrorSeverityChanged();
    partial void OnErrorStateChanging(System.Nullable<int> value);
    partial void OnErrorStateChanged();
    partial void OnErrorProcedureChanging(string value);
    partial void OnErrorProcedureChanged();
    partial void OnErrorLineChanging(System.Nullable<int> value);
    partial void OnErrorLineChanged();
    partial void OnErrorMessageChanging(string value);
    partial void OnErrorMessageChanged();
    #endregion
	
	public ErrorLog()
	{
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ErrorLogID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int ErrorLogID
	{
		get
		{
			return this._ErrorLogID;
		}
		set
		{
			if ((this._ErrorLogID != value))
			{
				this.OnErrorLogIDChanging(value);
				this.SendPropertyChanging();
				this._ErrorLogID = value;
				this.SendPropertyChanged("ErrorLogID");
				this.OnErrorLogIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ErrorTime", DbType="DateTime NOT NULL")]
	public System.DateTime ErrorTime
	{
		get
		{
			return this._ErrorTime;
		}
		set
		{
			if ((this._ErrorTime != value))
			{
				this.OnErrorTimeChanging(value);
				this.SendPropertyChanging();
				this._ErrorTime = value;
				this.SendPropertyChanged("ErrorTime");
				this.OnErrorTimeChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserName", DbType="NVarChar(128) NOT NULL", CanBeNull=false)]
	public string UserName
	{
		get
		{
			return this._UserName;
		}
		set
		{
			if ((this._UserName != value))
			{
				this.OnUserNameChanging(value);
				this.SendPropertyChanging();
				this._UserName = value;
				this.SendPropertyChanged("UserName");
				this.OnUserNameChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ErrorNumber", DbType="Int NOT NULL")]
	public int ErrorNumber
	{
		get
		{
			return this._ErrorNumber;
		}
		set
		{
			if ((this._ErrorNumber != value))
			{
				this.OnErrorNumberChanging(value);
				this.SendPropertyChanging();
				this._ErrorNumber = value;
				this.SendPropertyChanged("ErrorNumber");
				this.OnErrorNumberChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ErrorSeverity", DbType="Int")]
	public System.Nullable<int> ErrorSeverity
	{
		get
		{
			return this._ErrorSeverity;
		}
		set
		{
			if ((this._ErrorSeverity != value))
			{
				this.OnErrorSeverityChanging(value);
				this.SendPropertyChanging();
				this._ErrorSeverity = value;
				this.SendPropertyChanged("ErrorSeverity");
				this.OnErrorSeverityChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ErrorState", DbType="Int")]
	public System.Nullable<int> ErrorState
	{
		get
		{
			return this._ErrorState;
		}
		set
		{
			if ((this._ErrorState != value))
			{
				this.OnErrorStateChanging(value);
				this.SendPropertyChanging();
				this._ErrorState = value;
				this.SendPropertyChanged("ErrorState");
				this.OnErrorStateChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ErrorProcedure", DbType="NVarChar(126)")]
	public string ErrorProcedure
	{
		get
		{
			return this._ErrorProcedure;
		}
		set
		{
			if ((this._ErrorProcedure != value))
			{
				this.OnErrorProcedureChanging(value);
				this.SendPropertyChanging();
				this._ErrorProcedure = value;
				this.SendPropertyChanged("ErrorProcedure");
				this.OnErrorProcedureChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ErrorLine", DbType="Int")]
	public System.Nullable<int> ErrorLine
	{
		get
		{
			return this._ErrorLine;
		}
		set
		{
			if ((this._ErrorLine != value))
			{
				this.OnErrorLineChanging(value);
				this.SendPropertyChanging();
				this._ErrorLine = value;
				this.SendPropertyChanged("ErrorLine");
				this.OnErrorLineChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ErrorMessage", DbType="NVarChar(4000) NOT NULL", CanBeNull=false)]
	public string ErrorMessage
	{
		get
		{
			return this._ErrorMessage;
		}
		set
		{
			if ((this._ErrorMessage != value))
			{
				this.OnErrorMessageChanging(value);
				this.SendPropertyChanging();
				this._ErrorMessage = value;
				this.SendPropertyChanged("ErrorMessage");
				this.OnErrorMessageChanged();
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

[global::System.Data.Linq.Mapping.TableAttribute(Name="SalesLT.Product")]
public partial class SalesLT_Product : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _ProductID;
	
	private string _Name;
	
	private string _ProductNumber;
	
	private string _Color;
	
	private decimal _StandardCost;
	
	private decimal _ListPrice;
	
	private string _Size;
	
	private System.Nullable<decimal> _Weight;
	
	private System.Nullable<int> _ProductCategoryID;
	
	private System.Nullable<int> _ProductModelID;
	
	private System.DateTime _SellStartDate;
	
	private System.Nullable<System.DateTime> _SellEndDate;
	
	private System.Nullable<System.DateTime> _DiscontinuedDate;
	
	private System.Data.Linq.Binary _ThumbNailPhoto;
	
	private string _ThumbnailPhotoFileName;
	
	private System.Guid _Rowguid;
	
	private System.DateTime _ModifiedDate;
	
	private EntityRef<SalesLT_ProductCategory> _SalesLT_ProductCategory;
	
	private EntityRef<SalesLT_ProductModel> _SalesLT_ProductModel;
	
	private EntitySet<SalesLT_SalesOrderDetail> _SalesLT_SalesOrderDetail;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnProductIDChanging(int value);
    partial void OnProductIDChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnProductNumberChanging(string value);
    partial void OnProductNumberChanged();
    partial void OnColorChanging(string value);
    partial void OnColorChanged();
    partial void OnStandardCostChanging(decimal value);
    partial void OnStandardCostChanged();
    partial void OnListPriceChanging(decimal value);
    partial void OnListPriceChanged();
    partial void OnSizeChanging(string value);
    partial void OnSizeChanged();
    partial void OnWeightChanging(System.Nullable<decimal> value);
    partial void OnWeightChanged();
    partial void OnProductCategoryIDChanging(System.Nullable<int> value);
    partial void OnProductCategoryIDChanged();
    partial void OnProductModelIDChanging(System.Nullable<int> value);
    partial void OnProductModelIDChanged();
    partial void OnSellStartDateChanging(System.DateTime value);
    partial void OnSellStartDateChanged();
    partial void OnSellEndDateChanging(System.Nullable<System.DateTime> value);
    partial void OnSellEndDateChanged();
    partial void OnDiscontinuedDateChanging(System.Nullable<System.DateTime> value);
    partial void OnDiscontinuedDateChanged();
    partial void OnThumbNailPhotoChanging(System.Data.Linq.Binary value);
    partial void OnThumbNailPhotoChanged();
    partial void OnThumbnailPhotoFileNameChanging(string value);
    partial void OnThumbnailPhotoFileNameChanged();
    partial void OnRowguidChanging(System.Guid value);
    partial void OnRowguidChanged();
    partial void OnModifiedDateChanging(System.DateTime value);
    partial void OnModifiedDateChanged();
    #endregion
	
	public SalesLT_Product()
	{
		this._SalesLT_ProductCategory = default(EntityRef<SalesLT_ProductCategory>);
		this._SalesLT_ProductModel = default(EntityRef<SalesLT_ProductModel>);
		this._SalesLT_SalesOrderDetail = new EntitySet<SalesLT_SalesOrderDetail>(new Action<SalesLT_SalesOrderDetail>(this.attach_SalesLT_SalesOrderDetail), new Action<SalesLT_SalesOrderDetail>(this.detach_SalesLT_SalesOrderDetail));
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProductID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int ProductID
	{
		get
		{
			return this._ProductID;
		}
		set
		{
			if ((this._ProductID != value))
			{
				this.OnProductIDChanging(value);
				this.SendPropertyChanging();
				this._ProductID = value;
				this.SendPropertyChanged("ProductID");
				this.OnProductIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
	public string Name
	{
		get
		{
			return this._Name;
		}
		set
		{
			if ((this._Name != value))
			{
				this.OnNameChanging(value);
				this.SendPropertyChanging();
				this._Name = value;
				this.SendPropertyChanged("Name");
				this.OnNameChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProductNumber", DbType="NVarChar(25) NOT NULL", CanBeNull=false)]
	public string ProductNumber
	{
		get
		{
			return this._ProductNumber;
		}
		set
		{
			if ((this._ProductNumber != value))
			{
				this.OnProductNumberChanging(value);
				this.SendPropertyChanging();
				this._ProductNumber = value;
				this.SendPropertyChanged("ProductNumber");
				this.OnProductNumberChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Color", DbType="NVarChar(15)")]
	public string Color
	{
		get
		{
			return this._Color;
		}
		set
		{
			if ((this._Color != value))
			{
				this.OnColorChanging(value);
				this.SendPropertyChanging();
				this._Color = value;
				this.SendPropertyChanged("Color");
				this.OnColorChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StandardCost", DbType="Money NOT NULL")]
	public decimal StandardCost
	{
		get
		{
			return this._StandardCost;
		}
		set
		{
			if ((this._StandardCost != value))
			{
				this.OnStandardCostChanging(value);
				this.SendPropertyChanging();
				this._StandardCost = value;
				this.SendPropertyChanged("StandardCost");
				this.OnStandardCostChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ListPrice", DbType="Money NOT NULL")]
	public decimal ListPrice
	{
		get
		{
			return this._ListPrice;
		}
		set
		{
			if ((this._ListPrice != value))
			{
				this.OnListPriceChanging(value);
				this.SendPropertyChanging();
				this._ListPrice = value;
				this.SendPropertyChanged("ListPrice");
				this.OnListPriceChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Size", DbType="NVarChar(5)")]
	public string Size
	{
		get
		{
			return this._Size;
		}
		set
		{
			if ((this._Size != value))
			{
				this.OnSizeChanging(value);
				this.SendPropertyChanging();
				this._Size = value;
				this.SendPropertyChanged("Size");
				this.OnSizeChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Weight", DbType="Decimal(8,2)")]
	public System.Nullable<decimal> Weight
	{
		get
		{
			return this._Weight;
		}
		set
		{
			if ((this._Weight != value))
			{
				this.OnWeightChanging(value);
				this.SendPropertyChanging();
				this._Weight = value;
				this.SendPropertyChanged("Weight");
				this.OnWeightChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProductCategoryID", DbType="Int")]
	public System.Nullable<int> ProductCategoryID
	{
		get
		{
			return this._ProductCategoryID;
		}
		set
		{
			if ((this._ProductCategoryID != value))
			{
				if (this._SalesLT_ProductCategory.HasLoadedOrAssignedValue)
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnProductCategoryIDChanging(value);
				this.SendPropertyChanging();
				this._ProductCategoryID = value;
				this.SendPropertyChanged("ProductCategoryID");
				this.OnProductCategoryIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProductModelID", DbType="Int")]
	public System.Nullable<int> ProductModelID
	{
		get
		{
			return this._ProductModelID;
		}
		set
		{
			if ((this._ProductModelID != value))
			{
				if (this._SalesLT_ProductModel.HasLoadedOrAssignedValue)
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnProductModelIDChanging(value);
				this.SendPropertyChanging();
				this._ProductModelID = value;
				this.SendPropertyChanged("ProductModelID");
				this.OnProductModelIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SellStartDate", DbType="DateTime NOT NULL")]
	public System.DateTime SellStartDate
	{
		get
		{
			return this._SellStartDate;
		}
		set
		{
			if ((this._SellStartDate != value))
			{
				this.OnSellStartDateChanging(value);
				this.SendPropertyChanging();
				this._SellStartDate = value;
				this.SendPropertyChanged("SellStartDate");
				this.OnSellStartDateChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SellEndDate", DbType="DateTime")]
	public System.Nullable<System.DateTime> SellEndDate
	{
		get
		{
			return this._SellEndDate;
		}
		set
		{
			if ((this._SellEndDate != value))
			{
				this.OnSellEndDateChanging(value);
				this.SendPropertyChanging();
				this._SellEndDate = value;
				this.SendPropertyChanged("SellEndDate");
				this.OnSellEndDateChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DiscontinuedDate", DbType="DateTime")]
	public System.Nullable<System.DateTime> DiscontinuedDate
	{
		get
		{
			return this._DiscontinuedDate;
		}
		set
		{
			if ((this._DiscontinuedDate != value))
			{
				this.OnDiscontinuedDateChanging(value);
				this.SendPropertyChanging();
				this._DiscontinuedDate = value;
				this.SendPropertyChanged("DiscontinuedDate");
				this.OnDiscontinuedDateChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ThumbNailPhoto", DbType="VarBinary(MAX)", CanBeNull=true, UpdateCheck=UpdateCheck.Never)]
	public System.Data.Linq.Binary ThumbNailPhoto
	{
		get
		{
			return this._ThumbNailPhoto;
		}
		set
		{
			if ((this._ThumbNailPhoto != value))
			{
				this.OnThumbNailPhotoChanging(value);
				this.SendPropertyChanging();
				this._ThumbNailPhoto = value;
				this.SendPropertyChanged("ThumbNailPhoto");
				this.OnThumbNailPhotoChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ThumbnailPhotoFileName", DbType="NVarChar(50)")]
	public string ThumbnailPhotoFileName
	{
		get
		{
			return this._ThumbnailPhotoFileName;
		}
		set
		{
			if ((this._ThumbnailPhotoFileName != value))
			{
				this.OnThumbnailPhotoFileNameChanging(value);
				this.SendPropertyChanging();
				this._ThumbnailPhotoFileName = value;
				this.SendPropertyChanged("ThumbnailPhotoFileName");
				this.OnThumbnailPhotoFileNameChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Name="rowguid", Storage="_Rowguid", DbType="UniqueIdentifier NOT NULL")]
	public System.Guid Rowguid
	{
		get
		{
			return this._Rowguid;
		}
		set
		{
			if ((this._Rowguid != value))
			{
				this.OnRowguidChanging(value);
				this.SendPropertyChanging();
				this._Rowguid = value;
				this.SendPropertyChanged("Rowguid");
				this.OnRowguidChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ModifiedDate", DbType="DateTime NOT NULL")]
	public System.DateTime ModifiedDate
	{
		get
		{
			return this._ModifiedDate;
		}
		set
		{
			if ((this._ModifiedDate != value))
			{
				this.OnModifiedDateChanging(value);
				this.SendPropertyChanging();
				this._ModifiedDate = value;
				this.SendPropertyChanged("ModifiedDate");
				this.OnModifiedDateChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="FK_Product_ProductCategory_ProductCategoryID", Storage="_SalesLT_ProductCategory", ThisKey="ProductCategoryID", OtherKey="ProductCategoryID", IsForeignKey=true)]
	public SalesLT_ProductCategory SalesLT_ProductCategory
	{
		get
		{
			return this._SalesLT_ProductCategory.Entity;
		}
		set
		{
			SalesLT_ProductCategory previousValue = this._SalesLT_ProductCategory.Entity;
			if (((previousValue != value) 
						|| (this._SalesLT_ProductCategory.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._SalesLT_ProductCategory.Entity = null;
					previousValue.SalesLT_Product.Remove(this);
				}
				this._SalesLT_ProductCategory.Entity = value;
				if ((value != null))
				{
					value.SalesLT_Product.Add(this);
					this._ProductCategoryID = value.ProductCategoryID;
				}
				else
				{
					this._ProductCategoryID = default(Nullable<int>);
				}
				this.SendPropertyChanged("SalesLT_ProductCategory");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="FK_Product_ProductModel_ProductModelID", Storage="_SalesLT_ProductModel", ThisKey="ProductModelID", OtherKey="ProductModelID", IsForeignKey=true)]
	public SalesLT_ProductModel SalesLT_ProductModel
	{
		get
		{
			return this._SalesLT_ProductModel.Entity;
		}
		set
		{
			SalesLT_ProductModel previousValue = this._SalesLT_ProductModel.Entity;
			if (((previousValue != value) 
						|| (this._SalesLT_ProductModel.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._SalesLT_ProductModel.Entity = null;
					previousValue.SalesLT_Product.Remove(this);
				}
				this._SalesLT_ProductModel.Entity = value;
				if ((value != null))
				{
					value.SalesLT_Product.Add(this);
					this._ProductModelID = value.ProductModelID;
				}
				else
				{
					this._ProductModelID = default(Nullable<int>);
				}
				this.SendPropertyChanged("SalesLT_ProductModel");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="FK_SalesOrderDetail_Product_ProductID", Storage="_SalesLT_SalesOrderDetail", ThisKey="ProductID", OtherKey="ProductID", DeleteRule="NO ACTION")]
	public EntitySet<SalesLT_SalesOrderDetail> SalesLT_SalesOrderDetail
	{
		get
		{
			return this._SalesLT_SalesOrderDetail;
		}
		set
		{
			this._SalesLT_SalesOrderDetail.Assign(value);
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
	
	private void attach_SalesLT_SalesOrderDetail(SalesLT_SalesOrderDetail entity)
	{
		this.SendPropertyChanging();
		entity.SalesLT_Product = this;
	}
	
	private void detach_SalesLT_SalesOrderDetail(SalesLT_SalesOrderDetail entity)
	{
		this.SendPropertyChanging();
		entity.SalesLT_Product = null;
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="SalesLT.ProductCategory")]
public partial class SalesLT_ProductCategory : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _ProductCategoryID;
	
	private System.Nullable<int> _ParentProductCategoryID;
	
	private string _Name;
	
	private System.Guid _Rowguid;
	
	private System.DateTime _ModifiedDate;
	
	private EntitySet<SalesLT_Product> _SalesLT_Product;
	
	private EntityRef<SalesLT_ProductCategory> _ParentProductCategory;
	
	private EntitySet<SalesLT_ProductCategory> _ProductCategory;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnProductCategoryIDChanging(int value);
    partial void OnProductCategoryIDChanged();
    partial void OnParentProductCategoryIDChanging(System.Nullable<int> value);
    partial void OnParentProductCategoryIDChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnRowguidChanging(System.Guid value);
    partial void OnRowguidChanged();
    partial void OnModifiedDateChanging(System.DateTime value);
    partial void OnModifiedDateChanged();
    #endregion
	
	public SalesLT_ProductCategory()
	{
		this._SalesLT_Product = new EntitySet<SalesLT_Product>(new Action<SalesLT_Product>(this.attach_SalesLT_Product), new Action<SalesLT_Product>(this.detach_SalesLT_Product));
		this._ParentProductCategory = default(EntityRef<SalesLT_ProductCategory>);
		this._ProductCategory = new EntitySet<SalesLT_ProductCategory>(new Action<SalesLT_ProductCategory>(this.attach_ProductCategory), new Action<SalesLT_ProductCategory>(this.detach_ProductCategory));
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProductCategoryID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int ProductCategoryID
	{
		get
		{
			return this._ProductCategoryID;
		}
		set
		{
			if ((this._ProductCategoryID != value))
			{
				this.OnProductCategoryIDChanging(value);
				this.SendPropertyChanging();
				this._ProductCategoryID = value;
				this.SendPropertyChanged("ProductCategoryID");
				this.OnProductCategoryIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ParentProductCategoryID", DbType="Int")]
	public System.Nullable<int> ParentProductCategoryID
	{
		get
		{
			return this._ParentProductCategoryID;
		}
		set
		{
			if ((this._ParentProductCategoryID != value))
			{
				if (this._ParentProductCategory.HasLoadedOrAssignedValue)
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnParentProductCategoryIDChanging(value);
				this.SendPropertyChanging();
				this._ParentProductCategoryID = value;
				this.SendPropertyChanged("ParentProductCategoryID");
				this.OnParentProductCategoryIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
	public string Name
	{
		get
		{
			return this._Name;
		}
		set
		{
			if ((this._Name != value))
			{
				this.OnNameChanging(value);
				this.SendPropertyChanging();
				this._Name = value;
				this.SendPropertyChanged("Name");
				this.OnNameChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Name="rowguid", Storage="_Rowguid", DbType="UniqueIdentifier NOT NULL")]
	public System.Guid Rowguid
	{
		get
		{
			return this._Rowguid;
		}
		set
		{
			if ((this._Rowguid != value))
			{
				this.OnRowguidChanging(value);
				this.SendPropertyChanging();
				this._Rowguid = value;
				this.SendPropertyChanged("Rowguid");
				this.OnRowguidChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ModifiedDate", DbType="DateTime NOT NULL")]
	public System.DateTime ModifiedDate
	{
		get
		{
			return this._ModifiedDate;
		}
		set
		{
			if ((this._ModifiedDate != value))
			{
				this.OnModifiedDateChanging(value);
				this.SendPropertyChanging();
				this._ModifiedDate = value;
				this.SendPropertyChanged("ModifiedDate");
				this.OnModifiedDateChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="FK_Product_ProductCategory_ProductCategoryID", Storage="_SalesLT_Product", ThisKey="ProductCategoryID", OtherKey="ProductCategoryID", DeleteRule="NO ACTION")]
	public EntitySet<SalesLT_Product> SalesLT_Product
	{
		get
		{
			return this._SalesLT_Product;
		}
		set
		{
			this._SalesLT_Product.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="FK_ProductCategory_ProductCategory_ParentProductCategoryID_ProductCategoryID", Storage="_ParentProductCategory", ThisKey="ParentProductCategoryID", OtherKey="ProductCategoryID", IsForeignKey=true)]
	public SalesLT_ProductCategory ParentProductCategory
	{
		get
		{
			return this._ParentProductCategory.Entity;
		}
		set
		{
			SalesLT_ProductCategory previousValue = this._ParentProductCategory.Entity;
			if (((previousValue != value) 
						|| (this._ParentProductCategory.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._ParentProductCategory.Entity = null;
					previousValue.ProductCategory.Remove(this);
				}
				this._ParentProductCategory.Entity = value;
				if ((value != null))
				{
					value.ProductCategory.Add(this);
					this._ParentProductCategoryID = value.ProductCategoryID;
				}
				else
				{
					this._ParentProductCategoryID = default(Nullable<int>);
				}
				this.SendPropertyChanged("ParentProductCategory");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="FK_ProductCategory_ProductCategory_ParentProductCategoryID_ProductCategoryID", Storage="_ProductCategory", ThisKey="ProductCategoryID", OtherKey="ParentProductCategoryID", DeleteRule="NO ACTION")]
	public EntitySet<SalesLT_ProductCategory> ProductCategory
	{
		get
		{
			return this._ProductCategory;
		}
		set
		{
			this._ProductCategory.Assign(value);
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
	
	private void attach_SalesLT_Product(SalesLT_Product entity)
	{
		this.SendPropertyChanging();
		entity.SalesLT_ProductCategory = this;
	}
	
	private void detach_SalesLT_Product(SalesLT_Product entity)
	{
		this.SendPropertyChanging();
		entity.SalesLT_ProductCategory = null;
	}
	
	private void attach_ProductCategory(SalesLT_ProductCategory entity)
	{
		this.SendPropertyChanging();
		entity.ParentProductCategory = this;
	}
	
	private void detach_ProductCategory(SalesLT_ProductCategory entity)
	{
		this.SendPropertyChanging();
		entity.ParentProductCategory = null;
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="SalesLT.ProductDescription")]
public partial class SalesLT_ProductDescription : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _ProductDescriptionID;
	
	private string _Description;
	
	private System.Guid _Rowguid;
	
	private System.DateTime _ModifiedDate;
	
	private EntitySet<SalesLT_ProductModelProductDescription> _SalesLT_ProductModelProductDescription;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnProductDescriptionIDChanging(int value);
    partial void OnProductDescriptionIDChanged();
    partial void OnDescriptionChanging(string value);
    partial void OnDescriptionChanged();
    partial void OnRowguidChanging(System.Guid value);
    partial void OnRowguidChanged();
    partial void OnModifiedDateChanging(System.DateTime value);
    partial void OnModifiedDateChanged();
    #endregion
	
	public SalesLT_ProductDescription()
	{
		this._SalesLT_ProductModelProductDescription = new EntitySet<SalesLT_ProductModelProductDescription>(new Action<SalesLT_ProductModelProductDescription>(this.attach_SalesLT_ProductModelProductDescription), new Action<SalesLT_ProductModelProductDescription>(this.detach_SalesLT_ProductModelProductDescription));
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProductDescriptionID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int ProductDescriptionID
	{
		get
		{
			return this._ProductDescriptionID;
		}
		set
		{
			if ((this._ProductDescriptionID != value))
			{
				this.OnProductDescriptionIDChanging(value);
				this.SendPropertyChanging();
				this._ProductDescriptionID = value;
				this.SendPropertyChanged("ProductDescriptionID");
				this.OnProductDescriptionIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Description", DbType="NVarChar(400) NOT NULL", CanBeNull=false)]
	public string Description
	{
		get
		{
			return this._Description;
		}
		set
		{
			if ((this._Description != value))
			{
				this.OnDescriptionChanging(value);
				this.SendPropertyChanging();
				this._Description = value;
				this.SendPropertyChanged("Description");
				this.OnDescriptionChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Name="rowguid", Storage="_Rowguid", DbType="UniqueIdentifier NOT NULL")]
	public System.Guid Rowguid
	{
		get
		{
			return this._Rowguid;
		}
		set
		{
			if ((this._Rowguid != value))
			{
				this.OnRowguidChanging(value);
				this.SendPropertyChanging();
				this._Rowguid = value;
				this.SendPropertyChanged("Rowguid");
				this.OnRowguidChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ModifiedDate", DbType="DateTime NOT NULL")]
	public System.DateTime ModifiedDate
	{
		get
		{
			return this._ModifiedDate;
		}
		set
		{
			if ((this._ModifiedDate != value))
			{
				this.OnModifiedDateChanging(value);
				this.SendPropertyChanging();
				this._ModifiedDate = value;
				this.SendPropertyChanged("ModifiedDate");
				this.OnModifiedDateChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="FK_ProductModelProductDescription_ProductDescription_ProductDescriptionID", Storage="_SalesLT_ProductModelProductDescription", ThisKey="ProductDescriptionID", OtherKey="ProductDescriptionID", DeleteRule="NO ACTION")]
	public EntitySet<SalesLT_ProductModelProductDescription> SalesLT_ProductModelProductDescription
	{
		get
		{
			return this._SalesLT_ProductModelProductDescription;
		}
		set
		{
			this._SalesLT_ProductModelProductDescription.Assign(value);
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
	
	private void attach_SalesLT_ProductModelProductDescription(SalesLT_ProductModelProductDescription entity)
	{
		this.SendPropertyChanging();
		entity.SalesLT_ProductDescription = this;
	}
	
	private void detach_SalesLT_ProductModelProductDescription(SalesLT_ProductModelProductDescription entity)
	{
		this.SendPropertyChanging();
		entity.SalesLT_ProductDescription = null;
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="SalesLT.ProductModel")]
public partial class SalesLT_ProductModel : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _ProductModelID;
	
	private string _Name;
	
	private System.Xml.Linq.XElement _CatalogDescription;
	
	private System.Guid _Rowguid;
	
	private System.DateTime _ModifiedDate;
	
	private EntitySet<SalesLT_Product> _SalesLT_Product;
	
	private EntitySet<SalesLT_ProductModelProductDescription> _SalesLT_ProductModelProductDescription;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnProductModelIDChanging(int value);
    partial void OnProductModelIDChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnCatalogDescriptionChanging(System.Xml.Linq.XElement value);
    partial void OnCatalogDescriptionChanged();
    partial void OnRowguidChanging(System.Guid value);
    partial void OnRowguidChanged();
    partial void OnModifiedDateChanging(System.DateTime value);
    partial void OnModifiedDateChanged();
    #endregion
	
	public SalesLT_ProductModel()
	{
		this._SalesLT_Product = new EntitySet<SalesLT_Product>(new Action<SalesLT_Product>(this.attach_SalesLT_Product), new Action<SalesLT_Product>(this.detach_SalesLT_Product));
		this._SalesLT_ProductModelProductDescription = new EntitySet<SalesLT_ProductModelProductDescription>(new Action<SalesLT_ProductModelProductDescription>(this.attach_SalesLT_ProductModelProductDescription), new Action<SalesLT_ProductModelProductDescription>(this.detach_SalesLT_ProductModelProductDescription));
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProductModelID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int ProductModelID
	{
		get
		{
			return this._ProductModelID;
		}
		set
		{
			if ((this._ProductModelID != value))
			{
				this.OnProductModelIDChanging(value);
				this.SendPropertyChanging();
				this._ProductModelID = value;
				this.SendPropertyChanged("ProductModelID");
				this.OnProductModelIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
	public string Name
	{
		get
		{
			return this._Name;
		}
		set
		{
			if ((this._Name != value))
			{
				this.OnNameChanging(value);
				this.SendPropertyChanging();
				this._Name = value;
				this.SendPropertyChanged("Name");
				this.OnNameChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CatalogDescription", DbType="Xml", CanBeNull=true, UpdateCheck=UpdateCheck.Never)]
	public System.Xml.Linq.XElement CatalogDescription
	{
		get
		{
			return this._CatalogDescription;
		}
		set
		{
			if ((this._CatalogDescription != value))
			{
				this.OnCatalogDescriptionChanging(value);
				this.SendPropertyChanging();
				this._CatalogDescription = value;
				this.SendPropertyChanged("CatalogDescription");
				this.OnCatalogDescriptionChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Name="rowguid", Storage="_Rowguid", DbType="UniqueIdentifier NOT NULL")]
	public System.Guid Rowguid
	{
		get
		{
			return this._Rowguid;
		}
		set
		{
			if ((this._Rowguid != value))
			{
				this.OnRowguidChanging(value);
				this.SendPropertyChanging();
				this._Rowguid = value;
				this.SendPropertyChanged("Rowguid");
				this.OnRowguidChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ModifiedDate", DbType="DateTime NOT NULL")]
	public System.DateTime ModifiedDate
	{
		get
		{
			return this._ModifiedDate;
		}
		set
		{
			if ((this._ModifiedDate != value))
			{
				this.OnModifiedDateChanging(value);
				this.SendPropertyChanging();
				this._ModifiedDate = value;
				this.SendPropertyChanged("ModifiedDate");
				this.OnModifiedDateChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="FK_Product_ProductModel_ProductModelID", Storage="_SalesLT_Product", ThisKey="ProductModelID", OtherKey="ProductModelID", DeleteRule="NO ACTION")]
	public EntitySet<SalesLT_Product> SalesLT_Product
	{
		get
		{
			return this._SalesLT_Product;
		}
		set
		{
			this._SalesLT_Product.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="FK_ProductModelProductDescription_ProductModel_ProductModelID", Storage="_SalesLT_ProductModelProductDescription", ThisKey="ProductModelID", OtherKey="ProductModelID", DeleteRule="NO ACTION")]
	public EntitySet<SalesLT_ProductModelProductDescription> SalesLT_ProductModelProductDescription
	{
		get
		{
			return this._SalesLT_ProductModelProductDescription;
		}
		set
		{
			this._SalesLT_ProductModelProductDescription.Assign(value);
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
	
	private void attach_SalesLT_Product(SalesLT_Product entity)
	{
		this.SendPropertyChanging();
		entity.SalesLT_ProductModel = this;
	}
	
	private void detach_SalesLT_Product(SalesLT_Product entity)
	{
		this.SendPropertyChanging();
		entity.SalesLT_ProductModel = null;
	}
	
	private void attach_SalesLT_ProductModelProductDescription(SalesLT_ProductModelProductDescription entity)
	{
		this.SendPropertyChanging();
		entity.SalesLT_ProductModel = this;
	}
	
	private void detach_SalesLT_ProductModelProductDescription(SalesLT_ProductModelProductDescription entity)
	{
		this.SendPropertyChanging();
		entity.SalesLT_ProductModel = null;
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="SalesLT.ProductModelProductDescription")]
public partial class SalesLT_ProductModelProductDescription : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _ProductModelID;
	
	private int _ProductDescriptionID;
	
	private string _Culture;
	
	private System.Guid _Rowguid;
	
	private System.DateTime _ModifiedDate;
	
	private EntityRef<SalesLT_ProductDescription> _SalesLT_ProductDescription;
	
	private EntityRef<SalesLT_ProductModel> _SalesLT_ProductModel;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnProductModelIDChanging(int value);
    partial void OnProductModelIDChanged();
    partial void OnProductDescriptionIDChanging(int value);
    partial void OnProductDescriptionIDChanged();
    partial void OnCultureChanging(string value);
    partial void OnCultureChanged();
    partial void OnRowguidChanging(System.Guid value);
    partial void OnRowguidChanged();
    partial void OnModifiedDateChanging(System.DateTime value);
    partial void OnModifiedDateChanged();
    #endregion
	
	public SalesLT_ProductModelProductDescription()
	{
		this._SalesLT_ProductDescription = default(EntityRef<SalesLT_ProductDescription>);
		this._SalesLT_ProductModel = default(EntityRef<SalesLT_ProductModel>);
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProductModelID", DbType="Int NOT NULL", IsPrimaryKey=true)]
	public int ProductModelID
	{
		get
		{
			return this._ProductModelID;
		}
		set
		{
			if ((this._ProductModelID != value))
			{
				if (this._SalesLT_ProductModel.HasLoadedOrAssignedValue)
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnProductModelIDChanging(value);
				this.SendPropertyChanging();
				this._ProductModelID = value;
				this.SendPropertyChanged("ProductModelID");
				this.OnProductModelIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProductDescriptionID", DbType="Int NOT NULL", IsPrimaryKey=true)]
	public int ProductDescriptionID
	{
		get
		{
			return this._ProductDescriptionID;
		}
		set
		{
			if ((this._ProductDescriptionID != value))
			{
				if (this._SalesLT_ProductDescription.HasLoadedOrAssignedValue)
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnProductDescriptionIDChanging(value);
				this.SendPropertyChanging();
				this._ProductDescriptionID = value;
				this.SendPropertyChanged("ProductDescriptionID");
				this.OnProductDescriptionIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Culture", DbType="NChar(6) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
	public string Culture
	{
		get
		{
			return this._Culture;
		}
		set
		{
			if ((this._Culture != value))
			{
				this.OnCultureChanging(value);
				this.SendPropertyChanging();
				this._Culture = value;
				this.SendPropertyChanged("Culture");
				this.OnCultureChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Name="rowguid", Storage="_Rowguid", DbType="UniqueIdentifier NOT NULL")]
	public System.Guid Rowguid
	{
		get
		{
			return this._Rowguid;
		}
		set
		{
			if ((this._Rowguid != value))
			{
				this.OnRowguidChanging(value);
				this.SendPropertyChanging();
				this._Rowguid = value;
				this.SendPropertyChanged("Rowguid");
				this.OnRowguidChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ModifiedDate", DbType="DateTime NOT NULL")]
	public System.DateTime ModifiedDate
	{
		get
		{
			return this._ModifiedDate;
		}
		set
		{
			if ((this._ModifiedDate != value))
			{
				this.OnModifiedDateChanging(value);
				this.SendPropertyChanging();
				this._ModifiedDate = value;
				this.SendPropertyChanged("ModifiedDate");
				this.OnModifiedDateChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="FK_ProductModelProductDescription_ProductDescription_ProductDescriptionID", Storage="_SalesLT_ProductDescription", ThisKey="ProductDescriptionID", OtherKey="ProductDescriptionID", IsForeignKey=true)]
	public SalesLT_ProductDescription SalesLT_ProductDescription
	{
		get
		{
			return this._SalesLT_ProductDescription.Entity;
		}
		set
		{
			SalesLT_ProductDescription previousValue = this._SalesLT_ProductDescription.Entity;
			if (((previousValue != value) 
						|| (this._SalesLT_ProductDescription.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._SalesLT_ProductDescription.Entity = null;
					previousValue.SalesLT_ProductModelProductDescription.Remove(this);
				}
				this._SalesLT_ProductDescription.Entity = value;
				if ((value != null))
				{
					value.SalesLT_ProductModelProductDescription.Add(this);
					this._ProductDescriptionID = value.ProductDescriptionID;
				}
				else
				{
					this._ProductDescriptionID = default(int);
				}
				this.SendPropertyChanged("SalesLT_ProductDescription");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="FK_ProductModelProductDescription_ProductModel_ProductModelID", Storage="_SalesLT_ProductModel", ThisKey="ProductModelID", OtherKey="ProductModelID", IsForeignKey=true)]
	public SalesLT_ProductModel SalesLT_ProductModel
	{
		get
		{
			return this._SalesLT_ProductModel.Entity;
		}
		set
		{
			SalesLT_ProductModel previousValue = this._SalesLT_ProductModel.Entity;
			if (((previousValue != value) 
						|| (this._SalesLT_ProductModel.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._SalesLT_ProductModel.Entity = null;
					previousValue.SalesLT_ProductModelProductDescription.Remove(this);
				}
				this._SalesLT_ProductModel.Entity = value;
				if ((value != null))
				{
					value.SalesLT_ProductModelProductDescription.Add(this);
					this._ProductModelID = value.ProductModelID;
				}
				else
				{
					this._ProductModelID = default(int);
				}
				this.SendPropertyChanged("SalesLT_ProductModel");
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

[global::System.Data.Linq.Mapping.TableAttribute(Name="SalesLT.SalesOrderDetail")]
public partial class SalesLT_SalesOrderDetail : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _SalesOrderID;
	
	private int _SalesOrderDetailID;
	
	private short _OrderQty;
	
	private int _ProductID;
	
	private decimal _UnitPrice;
	
	private decimal _UnitPriceDiscount;
	
	private decimal _LineTotal;
	
	private System.Guid _Rowguid;
	
	private System.DateTime _ModifiedDate;
	
	private EntityRef<SalesLT_Product> _SalesLT_Product;
	
	private EntityRef<SalesLT_SalesOrderHeader> _SalesLT_SalesOrderHeader;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnSalesOrderIDChanging(int value);
    partial void OnSalesOrderIDChanged();
    partial void OnSalesOrderDetailIDChanging(int value);
    partial void OnSalesOrderDetailIDChanged();
    partial void OnOrderQtyChanging(short value);
    partial void OnOrderQtyChanged();
    partial void OnProductIDChanging(int value);
    partial void OnProductIDChanged();
    partial void OnUnitPriceChanging(decimal value);
    partial void OnUnitPriceChanged();
    partial void OnUnitPriceDiscountChanging(decimal value);
    partial void OnUnitPriceDiscountChanged();
    partial void OnLineTotalChanging(decimal value);
    partial void OnLineTotalChanged();
    partial void OnRowguidChanging(System.Guid value);
    partial void OnRowguidChanged();
    partial void OnModifiedDateChanging(System.DateTime value);
    partial void OnModifiedDateChanged();
    #endregion
	
	public SalesLT_SalesOrderDetail()
	{
		this._SalesLT_Product = default(EntityRef<SalesLT_Product>);
		this._SalesLT_SalesOrderHeader = default(EntityRef<SalesLT_SalesOrderHeader>);
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SalesOrderID", DbType="Int NOT NULL", IsPrimaryKey=true)]
	public int SalesOrderID
	{
		get
		{
			return this._SalesOrderID;
		}
		set
		{
			if ((this._SalesOrderID != value))
			{
				if (this._SalesLT_SalesOrderHeader.HasLoadedOrAssignedValue)
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnSalesOrderIDChanging(value);
				this.SendPropertyChanging();
				this._SalesOrderID = value;
				this.SendPropertyChanged("SalesOrderID");
				this.OnSalesOrderIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SalesOrderDetailID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int SalesOrderDetailID
	{
		get
		{
			return this._SalesOrderDetailID;
		}
		set
		{
			if ((this._SalesOrderDetailID != value))
			{
				this.OnSalesOrderDetailIDChanging(value);
				this.SendPropertyChanging();
				this._SalesOrderDetailID = value;
				this.SendPropertyChanged("SalesOrderDetailID");
				this.OnSalesOrderDetailIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OrderQty", DbType="SmallInt NOT NULL")]
	public short OrderQty
	{
		get
		{
			return this._OrderQty;
		}
		set
		{
			if ((this._OrderQty != value))
			{
				this.OnOrderQtyChanging(value);
				this.SendPropertyChanging();
				this._OrderQty = value;
				this.SendPropertyChanged("OrderQty");
				this.OnOrderQtyChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProductID", DbType="Int NOT NULL")]
	public int ProductID
	{
		get
		{
			return this._ProductID;
		}
		set
		{
			if ((this._ProductID != value))
			{
				if (this._SalesLT_Product.HasLoadedOrAssignedValue)
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnProductIDChanging(value);
				this.SendPropertyChanging();
				this._ProductID = value;
				this.SendPropertyChanged("ProductID");
				this.OnProductIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UnitPrice", DbType="Money NOT NULL")]
	public decimal UnitPrice
	{
		get
		{
			return this._UnitPrice;
		}
		set
		{
			if ((this._UnitPrice != value))
			{
				this.OnUnitPriceChanging(value);
				this.SendPropertyChanging();
				this._UnitPrice = value;
				this.SendPropertyChanged("UnitPrice");
				this.OnUnitPriceChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UnitPriceDiscount", DbType="Money NOT NULL")]
	public decimal UnitPriceDiscount
	{
		get
		{
			return this._UnitPriceDiscount;
		}
		set
		{
			if ((this._UnitPriceDiscount != value))
			{
				this.OnUnitPriceDiscountChanging(value);
				this.SendPropertyChanging();
				this._UnitPriceDiscount = value;
				this.SendPropertyChanged("UnitPriceDiscount");
				this.OnUnitPriceDiscountChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LineTotal", AutoSync=AutoSync.Always, DbType="Decimal(38,6) NOT NULL", IsDbGenerated=true, UpdateCheck=UpdateCheck.Never, Expression="(isnull(([UnitPrice]*((1.0)-[UnitPriceDiscount]))*[OrderQty],(0.0)))")]
	public decimal LineTotal
	{
		get
		{
			return this._LineTotal;
		}
		set
		{
			if ((this._LineTotal != value))
			{
				this.OnLineTotalChanging(value);
				this.SendPropertyChanging();
				this._LineTotal = value;
				this.SendPropertyChanged("LineTotal");
				this.OnLineTotalChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Name="rowguid", Storage="_Rowguid", DbType="UniqueIdentifier NOT NULL")]
	public System.Guid Rowguid
	{
		get
		{
			return this._Rowguid;
		}
		set
		{
			if ((this._Rowguid != value))
			{
				this.OnRowguidChanging(value);
				this.SendPropertyChanging();
				this._Rowguid = value;
				this.SendPropertyChanged("Rowguid");
				this.OnRowguidChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ModifiedDate", DbType="DateTime NOT NULL")]
	public System.DateTime ModifiedDate
	{
		get
		{
			return this._ModifiedDate;
		}
		set
		{
			if ((this._ModifiedDate != value))
			{
				this.OnModifiedDateChanging(value);
				this.SendPropertyChanging();
				this._ModifiedDate = value;
				this.SendPropertyChanged("ModifiedDate");
				this.OnModifiedDateChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="FK_SalesOrderDetail_Product_ProductID", Storage="_SalesLT_Product", ThisKey="ProductID", OtherKey="ProductID", IsForeignKey=true)]
	public SalesLT_Product SalesLT_Product
	{
		get
		{
			return this._SalesLT_Product.Entity;
		}
		set
		{
			SalesLT_Product previousValue = this._SalesLT_Product.Entity;
			if (((previousValue != value) 
						|| (this._SalesLT_Product.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._SalesLT_Product.Entity = null;
					previousValue.SalesLT_SalesOrderDetail.Remove(this);
				}
				this._SalesLT_Product.Entity = value;
				if ((value != null))
				{
					value.SalesLT_SalesOrderDetail.Add(this);
					this._ProductID = value.ProductID;
				}
				else
				{
					this._ProductID = default(int);
				}
				this.SendPropertyChanged("SalesLT_Product");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="FK_SalesOrderDetail_SalesOrderHeader_SalesOrderID", Storage="_SalesLT_SalesOrderHeader", ThisKey="SalesOrderID", OtherKey="SalesOrderID", IsForeignKey=true, DeleteOnNull=true)]
	public SalesLT_SalesOrderHeader SalesLT_SalesOrderHeader
	{
		get
		{
			return this._SalesLT_SalesOrderHeader.Entity;
		}
		set
		{
			SalesLT_SalesOrderHeader previousValue = this._SalesLT_SalesOrderHeader.Entity;
			if (((previousValue != value) 
						|| (this._SalesLT_SalesOrderHeader.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._SalesLT_SalesOrderHeader.Entity = null;
					previousValue.SalesLT_SalesOrderDetail.Remove(this);
				}
				this._SalesLT_SalesOrderHeader.Entity = value;
				if ((value != null))
				{
					value.SalesLT_SalesOrderDetail.Add(this);
					this._SalesOrderID = value.SalesOrderID;
				}
				else
				{
					this._SalesOrderID = default(int);
				}
				this.SendPropertyChanged("SalesLT_SalesOrderHeader");
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

[global::System.Data.Linq.Mapping.TableAttribute(Name="SalesLT.SalesOrderHeader")]
public partial class SalesLT_SalesOrderHeader : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _SalesOrderID;
	
	private byte _RevisionNumber;
	
	private System.DateTime _OrderDate;
	
	private System.DateTime _DueDate;
	
	private System.Nullable<System.DateTime> _ShipDate;
	
	private byte _Status;
	
	private bool _OnlineOrderFlag;
	
	private string _SalesOrderNumber;
	
	private string _PurchaseOrderNumber;
	
	private string _AccountNumber;
	
	private int _CustomerID;
	
	private System.Nullable<int> _ShipToAddressID;
	
	private System.Nullable<int> _BillToAddressID;
	
	private string _ShipMethod;
	
	private string _CreditCardApprovalCode;
	
	private decimal _SubTotal;
	
	private decimal _TaxAmt;
	
	private decimal _Freight;
	
	private decimal _TotalDue;
	
	private string _Comment;
	
	private System.Guid _Rowguid;
	
	private System.DateTime _ModifiedDate;
	
	private EntitySet<SalesLT_SalesOrderDetail> _SalesLT_SalesOrderDetail;
	
	private EntityRef<SalesLT_Address> _SalesLT_Address;
	
	private EntityRef<SalesLT_Address> _ShipToAddress;
	
	private EntityRef<SalesLT_Customer> _SalesLT_Customer;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnSalesOrderIDChanging(int value);
    partial void OnSalesOrderIDChanged();
    partial void OnRevisionNumberChanging(byte value);
    partial void OnRevisionNumberChanged();
    partial void OnOrderDateChanging(System.DateTime value);
    partial void OnOrderDateChanged();
    partial void OnDueDateChanging(System.DateTime value);
    partial void OnDueDateChanged();
    partial void OnShipDateChanging(System.Nullable<System.DateTime> value);
    partial void OnShipDateChanged();
    partial void OnStatusChanging(byte value);
    partial void OnStatusChanged();
    partial void OnOnlineOrderFlagChanging(bool value);
    partial void OnOnlineOrderFlagChanged();
    partial void OnSalesOrderNumberChanging(string value);
    partial void OnSalesOrderNumberChanged();
    partial void OnPurchaseOrderNumberChanging(string value);
    partial void OnPurchaseOrderNumberChanged();
    partial void OnAccountNumberChanging(string value);
    partial void OnAccountNumberChanged();
    partial void OnCustomerIDChanging(int value);
    partial void OnCustomerIDChanged();
    partial void OnShipToAddressIDChanging(System.Nullable<int> value);
    partial void OnShipToAddressIDChanged();
    partial void OnBillToAddressIDChanging(System.Nullable<int> value);
    partial void OnBillToAddressIDChanged();
    partial void OnShipMethodChanging(string value);
    partial void OnShipMethodChanged();
    partial void OnCreditCardApprovalCodeChanging(string value);
    partial void OnCreditCardApprovalCodeChanged();
    partial void OnSubTotalChanging(decimal value);
    partial void OnSubTotalChanged();
    partial void OnTaxAmtChanging(decimal value);
    partial void OnTaxAmtChanged();
    partial void OnFreightChanging(decimal value);
    partial void OnFreightChanged();
    partial void OnTotalDueChanging(decimal value);
    partial void OnTotalDueChanged();
    partial void OnCommentChanging(string value);
    partial void OnCommentChanged();
    partial void OnRowguidChanging(System.Guid value);
    partial void OnRowguidChanged();
    partial void OnModifiedDateChanging(System.DateTime value);
    partial void OnModifiedDateChanged();
    #endregion
	
	public SalesLT_SalesOrderHeader()
	{
		this._SalesLT_SalesOrderDetail = new EntitySet<SalesLT_SalesOrderDetail>(new Action<SalesLT_SalesOrderDetail>(this.attach_SalesLT_SalesOrderDetail), new Action<SalesLT_SalesOrderDetail>(this.detach_SalesLT_SalesOrderDetail));
		this._SalesLT_Address = default(EntityRef<SalesLT_Address>);
		this._ShipToAddress = default(EntityRef<SalesLT_Address>);
		this._SalesLT_Customer = default(EntityRef<SalesLT_Customer>);
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SalesOrderID", DbType="Int NOT NULL", IsPrimaryKey=true)]
	public int SalesOrderID
	{
		get
		{
			return this._SalesOrderID;
		}
		set
		{
			if ((this._SalesOrderID != value))
			{
				this.OnSalesOrderIDChanging(value);
				this.SendPropertyChanging();
				this._SalesOrderID = value;
				this.SendPropertyChanged("SalesOrderID");
				this.OnSalesOrderIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RevisionNumber", DbType="TinyInt NOT NULL")]
	public byte RevisionNumber
	{
		get
		{
			return this._RevisionNumber;
		}
		set
		{
			if ((this._RevisionNumber != value))
			{
				this.OnRevisionNumberChanging(value);
				this.SendPropertyChanging();
				this._RevisionNumber = value;
				this.SendPropertyChanged("RevisionNumber");
				this.OnRevisionNumberChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OrderDate", DbType="DateTime NOT NULL")]
	public System.DateTime OrderDate
	{
		get
		{
			return this._OrderDate;
		}
		set
		{
			if ((this._OrderDate != value))
			{
				this.OnOrderDateChanging(value);
				this.SendPropertyChanging();
				this._OrderDate = value;
				this.SendPropertyChanged("OrderDate");
				this.OnOrderDateChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DueDate", DbType="DateTime NOT NULL")]
	public System.DateTime DueDate
	{
		get
		{
			return this._DueDate;
		}
		set
		{
			if ((this._DueDate != value))
			{
				this.OnDueDateChanging(value);
				this.SendPropertyChanging();
				this._DueDate = value;
				this.SendPropertyChanged("DueDate");
				this.OnDueDateChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ShipDate", DbType="DateTime")]
	public System.Nullable<System.DateTime> ShipDate
	{
		get
		{
			return this._ShipDate;
		}
		set
		{
			if ((this._ShipDate != value))
			{
				this.OnShipDateChanging(value);
				this.SendPropertyChanging();
				this._ShipDate = value;
				this.SendPropertyChanged("ShipDate");
				this.OnShipDateChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Status", DbType="TinyInt NOT NULL")]
	public byte Status
	{
		get
		{
			return this._Status;
		}
		set
		{
			if ((this._Status != value))
			{
				this.OnStatusChanging(value);
				this.SendPropertyChanging();
				this._Status = value;
				this.SendPropertyChanged("Status");
				this.OnStatusChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OnlineOrderFlag", DbType="Bit NOT NULL")]
	public bool OnlineOrderFlag
	{
		get
		{
			return this._OnlineOrderFlag;
		}
		set
		{
			if ((this._OnlineOrderFlag != value))
			{
				this.OnOnlineOrderFlagChanging(value);
				this.SendPropertyChanging();
				this._OnlineOrderFlag = value;
				this.SendPropertyChanged("OnlineOrderFlag");
				this.OnOnlineOrderFlagChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SalesOrderNumber", AutoSync=AutoSync.Always, DbType="NVarChar(25) NOT NULL", CanBeNull=false, IsDbGenerated=true, UpdateCheck=UpdateCheck.Never, Expression="(isnull(N\'SO\'+CONVERT([nvarchar](23),[SalesOrderID],(0)),N\'*** ERROR ***\'))")]
	public string SalesOrderNumber
	{
		get
		{
			return this._SalesOrderNumber;
		}
		set
		{
			if ((this._SalesOrderNumber != value))
			{
				this.OnSalesOrderNumberChanging(value);
				this.SendPropertyChanging();
				this._SalesOrderNumber = value;
				this.SendPropertyChanged("SalesOrderNumber");
				this.OnSalesOrderNumberChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PurchaseOrderNumber", DbType="NVarChar(25)")]
	public string PurchaseOrderNumber
	{
		get
		{
			return this._PurchaseOrderNumber;
		}
		set
		{
			if ((this._PurchaseOrderNumber != value))
			{
				this.OnPurchaseOrderNumberChanging(value);
				this.SendPropertyChanging();
				this._PurchaseOrderNumber = value;
				this.SendPropertyChanged("PurchaseOrderNumber");
				this.OnPurchaseOrderNumberChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AccountNumber", DbType="NVarChar(15)")]
	public string AccountNumber
	{
		get
		{
			return this._AccountNumber;
		}
		set
		{
			if ((this._AccountNumber != value))
			{
				this.OnAccountNumberChanging(value);
				this.SendPropertyChanging();
				this._AccountNumber = value;
				this.SendPropertyChanged("AccountNumber");
				this.OnAccountNumberChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CustomerID", DbType="Int NOT NULL")]
	public int CustomerID
	{
		get
		{
			return this._CustomerID;
		}
		set
		{
			if ((this._CustomerID != value))
			{
				if (this._SalesLT_Customer.HasLoadedOrAssignedValue)
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnCustomerIDChanging(value);
				this.SendPropertyChanging();
				this._CustomerID = value;
				this.SendPropertyChanged("CustomerID");
				this.OnCustomerIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ShipToAddressID", DbType="Int")]
	public System.Nullable<int> ShipToAddressID
	{
		get
		{
			return this._ShipToAddressID;
		}
		set
		{
			if ((this._ShipToAddressID != value))
			{
				if (this._ShipToAddress.HasLoadedOrAssignedValue)
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnShipToAddressIDChanging(value);
				this.SendPropertyChanging();
				this._ShipToAddressID = value;
				this.SendPropertyChanged("ShipToAddressID");
				this.OnShipToAddressIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BillToAddressID", DbType="Int")]
	public System.Nullable<int> BillToAddressID
	{
		get
		{
			return this._BillToAddressID;
		}
		set
		{
			if ((this._BillToAddressID != value))
			{
				if (this._SalesLT_Address.HasLoadedOrAssignedValue)
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnBillToAddressIDChanging(value);
				this.SendPropertyChanging();
				this._BillToAddressID = value;
				this.SendPropertyChanged("BillToAddressID");
				this.OnBillToAddressIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ShipMethod", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
	public string ShipMethod
	{
		get
		{
			return this._ShipMethod;
		}
		set
		{
			if ((this._ShipMethod != value))
			{
				this.OnShipMethodChanging(value);
				this.SendPropertyChanging();
				this._ShipMethod = value;
				this.SendPropertyChanged("ShipMethod");
				this.OnShipMethodChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CreditCardApprovalCode", DbType="VarChar(15)")]
	public string CreditCardApprovalCode
	{
		get
		{
			return this._CreditCardApprovalCode;
		}
		set
		{
			if ((this._CreditCardApprovalCode != value))
			{
				this.OnCreditCardApprovalCodeChanging(value);
				this.SendPropertyChanging();
				this._CreditCardApprovalCode = value;
				this.SendPropertyChanged("CreditCardApprovalCode");
				this.OnCreditCardApprovalCodeChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SubTotal", DbType="Money NOT NULL")]
	public decimal SubTotal
	{
		get
		{
			return this._SubTotal;
		}
		set
		{
			if ((this._SubTotal != value))
			{
				this.OnSubTotalChanging(value);
				this.SendPropertyChanging();
				this._SubTotal = value;
				this.SendPropertyChanged("SubTotal");
				this.OnSubTotalChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TaxAmt", DbType="Money NOT NULL")]
	public decimal TaxAmt
	{
		get
		{
			return this._TaxAmt;
		}
		set
		{
			if ((this._TaxAmt != value))
			{
				this.OnTaxAmtChanging(value);
				this.SendPropertyChanging();
				this._TaxAmt = value;
				this.SendPropertyChanged("TaxAmt");
				this.OnTaxAmtChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Freight", DbType="Money NOT NULL")]
	public decimal Freight
	{
		get
		{
			return this._Freight;
		}
		set
		{
			if ((this._Freight != value))
			{
				this.OnFreightChanging(value);
				this.SendPropertyChanging();
				this._Freight = value;
				this.SendPropertyChanged("Freight");
				this.OnFreightChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TotalDue", AutoSync=AutoSync.Always, DbType="Money NOT NULL", IsDbGenerated=true, UpdateCheck=UpdateCheck.Never, Expression="(isnull(([SubTotal]+[TaxAmt])+[Freight],(0)))")]
	public decimal TotalDue
	{
		get
		{
			return this._TotalDue;
		}
		set
		{
			if ((this._TotalDue != value))
			{
				this.OnTotalDueChanging(value);
				this.SendPropertyChanging();
				this._TotalDue = value;
				this.SendPropertyChanged("TotalDue");
				this.OnTotalDueChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Comment", DbType="NVarChar(MAX)", UpdateCheck=UpdateCheck.Never)]
	public string Comment
	{
		get
		{
			return this._Comment;
		}
		set
		{
			if ((this._Comment != value))
			{
				this.OnCommentChanging(value);
				this.SendPropertyChanging();
				this._Comment = value;
				this.SendPropertyChanged("Comment");
				this.OnCommentChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Name="rowguid", Storage="_Rowguid", DbType="UniqueIdentifier NOT NULL")]
	public System.Guid Rowguid
	{
		get
		{
			return this._Rowguid;
		}
		set
		{
			if ((this._Rowguid != value))
			{
				this.OnRowguidChanging(value);
				this.SendPropertyChanging();
				this._Rowguid = value;
				this.SendPropertyChanged("Rowguid");
				this.OnRowguidChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ModifiedDate", DbType="DateTime NOT NULL")]
	public System.DateTime ModifiedDate
	{
		get
		{
			return this._ModifiedDate;
		}
		set
		{
			if ((this._ModifiedDate != value))
			{
				this.OnModifiedDateChanging(value);
				this.SendPropertyChanging();
				this._ModifiedDate = value;
				this.SendPropertyChanged("ModifiedDate");
				this.OnModifiedDateChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="FK_SalesOrderDetail_SalesOrderHeader_SalesOrderID", Storage="_SalesLT_SalesOrderDetail", ThisKey="SalesOrderID", OtherKey="SalesOrderID", DeleteRule="CASCADE")]
	public EntitySet<SalesLT_SalesOrderDetail> SalesLT_SalesOrderDetail
	{
		get
		{
			return this._SalesLT_SalesOrderDetail;
		}
		set
		{
			this._SalesLT_SalesOrderDetail.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="FK_SalesOrderHeader_Address_BillTo_AddressID", Storage="_SalesLT_Address", ThisKey="BillToAddressID", OtherKey="AddressID", IsForeignKey=true)]
	public SalesLT_Address SalesLT_Address
	{
		get
		{
			return this._SalesLT_Address.Entity;
		}
		set
		{
			SalesLT_Address previousValue = this._SalesLT_Address.Entity;
			if (((previousValue != value) 
						|| (this._SalesLT_Address.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._SalesLT_Address.Entity = null;
					previousValue.SalesLT_SalesOrderHeader.Remove(this);
				}
				this._SalesLT_Address.Entity = value;
				if ((value != null))
				{
					value.SalesLT_SalesOrderHeader.Add(this);
					this._BillToAddressID = value.AddressID;
				}
				else
				{
					this._BillToAddressID = default(Nullable<int>);
				}
				this.SendPropertyChanged("SalesLT_Address");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="FK_SalesOrderHeader_Address_ShipTo_AddressID", Storage="_ShipToAddress", ThisKey="ShipToAddressID", OtherKey="AddressID", IsForeignKey=true)]
	public SalesLT_Address ShipToAddress
	{
		get
		{
			return this._ShipToAddress.Entity;
		}
		set
		{
			SalesLT_Address previousValue = this._ShipToAddress.Entity;
			if (((previousValue != value) 
						|| (this._ShipToAddress.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._ShipToAddress.Entity = null;
					previousValue.Address.Remove(this);
				}
				this._ShipToAddress.Entity = value;
				if ((value != null))
				{
					value.Address.Add(this);
					this._ShipToAddressID = value.AddressID;
				}
				else
				{
					this._ShipToAddressID = default(Nullable<int>);
				}
				this.SendPropertyChanged("ShipToAddress");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="FK_SalesOrderHeader_Customer_CustomerID", Storage="_SalesLT_Customer", ThisKey="CustomerID", OtherKey="CustomerID", IsForeignKey=true)]
	public SalesLT_Customer SalesLT_Customer
	{
		get
		{
			return this._SalesLT_Customer.Entity;
		}
		set
		{
			SalesLT_Customer previousValue = this._SalesLT_Customer.Entity;
			if (((previousValue != value) 
						|| (this._SalesLT_Customer.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._SalesLT_Customer.Entity = null;
					previousValue.SalesLT_SalesOrderHeader.Remove(this);
				}
				this._SalesLT_Customer.Entity = value;
				if ((value != null))
				{
					value.SalesLT_SalesOrderHeader.Add(this);
					this._CustomerID = value.CustomerID;
				}
				else
				{
					this._CustomerID = default(int);
				}
				this.SendPropertyChanged("SalesLT_Customer");
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
	
	private void attach_SalesLT_SalesOrderDetail(SalesLT_SalesOrderDetail entity)
	{
		this.SendPropertyChanging();
		entity.SalesLT_SalesOrderHeader = this;
	}
	
	private void detach_SalesLT_SalesOrderDetail(SalesLT_SalesOrderDetail entity)
	{
		this.SendPropertyChanging();
		entity.SalesLT_SalesOrderHeader = null;
	}
}