﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:2.0.50727.4927
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hotels.DataModels
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
	
	
	[System.Data.Linq.Mapping.DatabaseAttribute(Name="Hotel")]
	public partial class DataClassesDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Insertroom(room instance);
    partial void Updateroom(room instance);
    partial void Deleteroom(room instance);
    partial void InsertroomFloors(roomFloors instance);
    partial void UpdateroomFloors(roomFloors instance);
    partial void DeleteroomFloors(roomFloors instance);
    partial void InsertroomStatus(roomStatus instance);
    partial void UpdateroomStatus(roomStatus instance);
    partial void DeleteroomStatus(roomStatus instance);
    partial void Insertroomtype(roomtype instance);
    partial void Updateroomtype(roomtype instance);
    partial void Deleteroomtype(roomtype instance);
    partial void Insertuser(user instance);
    partial void Updateuser(user instance);
    partial void Deleteuser(user instance);
    #endregion
		
		public DataClassesDataContext() : 
				base(global::Hotels.Properties.Settings.Default.HotelConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<room> room
		{
			get
			{
				return this.GetTable<room>();
			}
		}
		
		public System.Data.Linq.Table<roomFloors> roomFloors
		{
			get
			{
				return this.GetTable<roomFloors>();
			}
		}
		
		public System.Data.Linq.Table<roomStatus> roomStatus
		{
			get
			{
				return this.GetTable<roomStatus>();
			}
		}
		
		public System.Data.Linq.Table<roomtype> roomtype
		{
			get
			{
				return this.GetTable<roomtype>();
			}
		}
		
		public System.Data.Linq.Table<roomManage> roomManage
		{
			get
			{
				return this.GetTable<roomManage>();
			}
		}
		
		public System.Data.Linq.Table<user> user
		{
			get
			{
				return this.GetTable<user>();
			}
		}
		
		private void InsertroomManage(roomManage obj)
		{
			this.InsertRoom(((System.Nullable<int>)(obj.roomId)), ((System.Nullable<int>)(obj.rType)), ((System.Nullable<int>)(obj.rStatue)), ((System.Nullable<int>)(obj.rFloor)), ((System.Nullable<int>)(obj.phone)), ((System.Nullable<bool>)(obj.isHourRoom)), obj.description, ((System.Nullable<System.DateTime>)(obj.time)));
		}
		
		private void UpdateroomManage(roomManage obj)
		{
			roomManage original = ((roomManage)(roomManage.GetOriginalEntityState(obj)));
			this.UpdateRoom(((System.Nullable<int>)(obj.roomId)), ((System.Nullable<int>)(obj.rType)), ((System.Nullable<int>)(obj.rStatue)), ((System.Nullable<int>)(obj.rFloor)), ((System.Nullable<int>)(obj.phone)), ((System.Nullable<bool>)(obj.isHourRoom)), obj.description, ((System.Nullable<System.DateTime>)(obj.time)), ((System.Nullable<int>)(original.roomId)));
		}
		
		private void DeleteroomManage(roomManage obj)
		{
			roomManage original = ((roomManage)(roomManage.GetOriginalEntityState(obj)));
			this.DeleteRoom(((System.Nullable<int>)(original.roomId)));
		}
		
		[Function(Name="dbo.selectRoomAddMany")]
		public int selectRoomAddMany([Parameter(DbType="Int")] System.Nullable<int> startNum, [Parameter(DbType="Int")] System.Nullable<int> endNum, [Parameter(DbType="Int")] ref System.Nullable<int> selectRoomCount)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), startNum, endNum, selectRoomCount);
			selectRoomCount = ((System.Nullable<int>)(result.GetParameterValue(2)));
			return ((int)(result.ReturnValue));
		}
		
		[Function(Name="dbo.DeleteRoom")]
		public int DeleteRoom([Parameter(Name="Original_roomId", DbType="Int")] System.Nullable<int> original_roomId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), original_roomId);
			return ((int)(result.ReturnValue));
		}
		
		[Function(Name="dbo.InsertRoom")]
		public ISingleResult<InsertRoom_个结果> InsertRoom([Parameter(DbType="Int")] System.Nullable<int> roomId, [Parameter(DbType="Int")] System.Nullable<int> rType, [Parameter(DbType="Int")] System.Nullable<int> rStatue, [Parameter(DbType="Int")] System.Nullable<int> rFloor, [Parameter(DbType="Int")] System.Nullable<int> phone, [Parameter(DbType="Bit")] System.Nullable<bool> isHourRoom, [Parameter(DbType="NVarChar(50)")] string description, [Parameter(DbType="SmallDateTime")] System.Nullable<System.DateTime> time)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), roomId, rType, rStatue, rFloor, phone, isHourRoom, description, time);
			return ((ISingleResult<InsertRoom_个结果>)(result.ReturnValue));
		}
		
		[Function(Name="dbo.UpdateRoom")]
		public ISingleResult<UpdateRoom_个结果> UpdateRoom([Parameter(DbType="Int")] System.Nullable<int> roomId, [Parameter(DbType="Int")] System.Nullable<int> rType, [Parameter(DbType="Int")] System.Nullable<int> rStatue, [Parameter(DbType="Int")] System.Nullable<int> rFloor, [Parameter(DbType="Int")] System.Nullable<int> phone, [Parameter(DbType="Bit")] System.Nullable<bool> isHourRoom, [Parameter(DbType="NVarChar(50)")] string description, [Parameter(DbType="SmallDateTime")] System.Nullable<System.DateTime> time, [Parameter(Name="Original_roomId", DbType="Int")] System.Nullable<int> original_roomId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), roomId, rType, rStatue, rFloor, phone, isHourRoom, description, time, original_roomId);
			return ((ISingleResult<UpdateRoom_个结果>)(result.ReturnValue));
		}
	}
	
	[Table(Name="dbo.room")]
	public partial class room : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _roomId;
		
		private int _rType;
		
		private int _rStatue;
		
		private int _rFloor;
		
		private System.Nullable<int> _phone;
		
		private System.Nullable<bool> _isHourRoom;
		
		private string _description;
		
		private System.Nullable<System.DateTime> _time;
		
		private EntityRef<roomFloors> _roomFloors;
		
		private EntityRef<roomStatus> _roomStatus;
		
		private EntityRef<roomtype> _roomtype;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnroomIdChanging(int value);
    partial void OnroomIdChanged();
    partial void OnrTypeChanging(int value);
    partial void OnrTypeChanged();
    partial void OnrStatueChanging(int value);
    partial void OnrStatueChanged();
    partial void OnrFloorChanging(int value);
    partial void OnrFloorChanged();
    partial void OnphoneChanging(System.Nullable<int> value);
    partial void OnphoneChanged();
    partial void OnisHourRoomChanging(System.Nullable<bool> value);
    partial void OnisHourRoomChanged();
    partial void OndescriptionChanging(string value);
    partial void OndescriptionChanged();
    partial void OntimeChanging(System.Nullable<System.DateTime> value);
    partial void OntimeChanged();
    #endregion
		
		public room()
		{
			this._roomFloors = default(EntityRef<roomFloors>);
			this._roomStatus = default(EntityRef<roomStatus>);
			this._roomtype = default(EntityRef<roomtype>);
			OnCreated();
		}
		
		[Column(Storage="_roomId", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int roomId
		{
			get
			{
				return this._roomId;
			}
			set
			{
				if ((this._roomId != value))
				{
					this.OnroomIdChanging(value);
					this.SendPropertyChanging();
					this._roomId = value;
					this.SendPropertyChanged("roomId");
					this.OnroomIdChanged();
				}
			}
		}
		
		[Column(Storage="_rType", DbType="Int NOT NULL")]
		public int rType
		{
			get
			{
				return this._rType;
			}
			set
			{
				if ((this._rType != value))
				{
					if (this._roomtype.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnrTypeChanging(value);
					this.SendPropertyChanging();
					this._rType = value;
					this.SendPropertyChanged("rType");
					this.OnrTypeChanged();
				}
			}
		}
		
		[Column(Storage="_rStatue", DbType="Int NOT NULL")]
		public int rStatue
		{
			get
			{
				return this._rStatue;
			}
			set
			{
				if ((this._rStatue != value))
				{
					if (this._roomStatus.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnrStatueChanging(value);
					this.SendPropertyChanging();
					this._rStatue = value;
					this.SendPropertyChanged("rStatue");
					this.OnrStatueChanged();
				}
			}
		}
		
		[Column(Storage="_rFloor", DbType="Int NOT NULL")]
		public int rFloor
		{
			get
			{
				return this._rFloor;
			}
			set
			{
				if ((this._rFloor != value))
				{
					if (this._roomFloors.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnrFloorChanging(value);
					this.SendPropertyChanging();
					this._rFloor = value;
					this.SendPropertyChanged("rFloor");
					this.OnrFloorChanged();
				}
			}
		}
		
		[Column(Storage="_phone", DbType="Int")]
		public System.Nullable<int> phone
		{
			get
			{
				return this._phone;
			}
			set
			{
				if ((this._phone != value))
				{
					this.OnphoneChanging(value);
					this.SendPropertyChanging();
					this._phone = value;
					this.SendPropertyChanged("phone");
					this.OnphoneChanged();
				}
			}
		}
		
		[Column(Storage="_isHourRoom", DbType="Bit")]
		public System.Nullable<bool> isHourRoom
		{
			get
			{
				return this._isHourRoom;
			}
			set
			{
				if ((this._isHourRoom != value))
				{
					this.OnisHourRoomChanging(value);
					this.SendPropertyChanging();
					this._isHourRoom = value;
					this.SendPropertyChanged("isHourRoom");
					this.OnisHourRoomChanged();
				}
			}
		}
		
		[Column(Storage="_description", DbType="NVarChar(50)")]
		public string description
		{
			get
			{
				return this._description;
			}
			set
			{
				if ((this._description != value))
				{
					this.OndescriptionChanging(value);
					this.SendPropertyChanging();
					this._description = value;
					this.SendPropertyChanged("description");
					this.OndescriptionChanged();
				}
			}
		}
		
		[Column(Storage="_time", DbType="SmallDateTime")]
		public System.Nullable<System.DateTime> time
		{
			get
			{
				return this._time;
			}
			set
			{
				if ((this._time != value))
				{
					this.OntimeChanging(value);
					this.SendPropertyChanging();
					this._time = value;
					this.SendPropertyChanged("time");
					this.OntimeChanged();
				}
			}
		}
		
		[Association(Name="roomFloors_room", Storage="_roomFloors", ThisKey="rFloor", OtherKey="floorId", IsForeignKey=true)]
		public roomFloors roomFloors
		{
			get
			{
				return this._roomFloors.Entity;
			}
			set
			{
				roomFloors previousValue = this._roomFloors.Entity;
				if (((previousValue != value) 
							|| (this._roomFloors.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._roomFloors.Entity = null;
						previousValue.room.Remove(this);
					}
					this._roomFloors.Entity = value;
					if ((value != null))
					{
						value.room.Add(this);
						this._rFloor = value.floorId;
					}
					else
					{
						this._rFloor = default(int);
					}
					this.SendPropertyChanged("roomFloors");
				}
			}
		}
		
		[Association(Name="roomStatus_room", Storage="_roomStatus", ThisKey="rStatue", OtherKey="status", IsForeignKey=true)]
		public roomStatus roomStatus
		{
			get
			{
				return this._roomStatus.Entity;
			}
			set
			{
				roomStatus previousValue = this._roomStatus.Entity;
				if (((previousValue != value) 
							|| (this._roomStatus.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._roomStatus.Entity = null;
						previousValue.room.Remove(this);
					}
					this._roomStatus.Entity = value;
					if ((value != null))
					{
						value.room.Add(this);
						this._rStatue = value.status;
					}
					else
					{
						this._rStatue = default(int);
					}
					this.SendPropertyChanged("roomStatus");
				}
			}
		}
		
		[Association(Name="roomtype_room", Storage="_roomtype", ThisKey="rType", OtherKey="type", IsForeignKey=true)]
		public roomtype roomtype
		{
			get
			{
				return this._roomtype.Entity;
			}
			set
			{
				roomtype previousValue = this._roomtype.Entity;
				if (((previousValue != value) 
							|| (this._roomtype.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._roomtype.Entity = null;
						previousValue.room.Remove(this);
					}
					this._roomtype.Entity = value;
					if ((value != null))
					{
						value.room.Add(this);
						this._rType = value.type;
					}
					else
					{
						this._rType = default(int);
					}
					this.SendPropertyChanged("roomtype");
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
	
	[Table(Name="dbo.roomFloors")]
	public partial class roomFloors : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _floorId;
		
		private string _floorName;
		
		private EntitySet<room> _room;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnfloorIdChanging(int value);
    partial void OnfloorIdChanged();
    partial void OnfloorNameChanging(string value);
    partial void OnfloorNameChanged();
    #endregion
		
		public roomFloors()
		{
			this._room = new EntitySet<room>(new Action<room>(this.attach_room), new Action<room>(this.detach_room));
			OnCreated();
		}
		
		[Column(Storage="_floorId", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int floorId
		{
			get
			{
				return this._floorId;
			}
			set
			{
				if ((this._floorId != value))
				{
					this.OnfloorIdChanging(value);
					this.SendPropertyChanging();
					this._floorId = value;
					this.SendPropertyChanged("floorId");
					this.OnfloorIdChanged();
				}
			}
		}
		
		[Column(Storage="_floorName", DbType="NVarChar(10) NOT NULL", CanBeNull=false)]
		public string floorName
		{
			get
			{
				return this._floorName;
			}
			set
			{
				if ((this._floorName != value))
				{
					this.OnfloorNameChanging(value);
					this.SendPropertyChanging();
					this._floorName = value;
					this.SendPropertyChanged("floorName");
					this.OnfloorNameChanged();
				}
			}
		}
		
		[Association(Name="roomFloors_room", Storage="_room", ThisKey="floorId", OtherKey="rFloor")]
		public EntitySet<room> room
		{
			get
			{
				return this._room;
			}
			set
			{
				this._room.Assign(value);
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
		
		private void attach_room(room entity)
		{
			this.SendPropertyChanging();
			entity.roomFloors = this;
		}
		
		private void detach_room(room entity)
		{
			this.SendPropertyChanging();
			entity.roomFloors = null;
		}
	}
	
	[Table(Name="dbo.roomStatus")]
	public partial class roomStatus : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _status;
		
		private string _statusName;
		
		private EntitySet<room> _room;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnstatusChanging(int value);
    partial void OnstatusChanged();
    partial void OnstatusNameChanging(string value);
    partial void OnstatusNameChanged();
    #endregion
		
		public roomStatus()
		{
			this._room = new EntitySet<room>(new Action<room>(this.attach_room), new Action<room>(this.detach_room));
			OnCreated();
		}
		
		[Column(Storage="_status", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int status
		{
			get
			{
				return this._status;
			}
			set
			{
				if ((this._status != value))
				{
					this.OnstatusChanging(value);
					this.SendPropertyChanging();
					this._status = value;
					this.SendPropertyChanged("status");
					this.OnstatusChanged();
				}
			}
		}
		
		[Column(Storage="_statusName", DbType="NChar(4) NOT NULL", CanBeNull=false)]
		public string statusName
		{
			get
			{
				return this._statusName;
			}
			set
			{
				if ((this._statusName != value))
				{
					this.OnstatusNameChanging(value);
					this.SendPropertyChanging();
					this._statusName = value;
					this.SendPropertyChanged("statusName");
					this.OnstatusNameChanged();
				}
			}
		}
		
		[Association(Name="roomStatus_room", Storage="_room", ThisKey="status", OtherKey="rStatue")]
		public EntitySet<room> room
		{
			get
			{
				return this._room;
			}
			set
			{
				this._room.Assign(value);
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
		
		private void attach_room(room entity)
		{
			this.SendPropertyChanging();
			entity.roomStatus = this;
		}
		
		private void detach_room(room entity)
		{
			this.SendPropertyChanging();
			entity.roomStatus = null;
		}
	}
	
	[Table(Name="dbo.roomtype")]
	public partial class roomtype : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _type;
		
		private string _typeName;
		
		private decimal _onePrice;
		
		private System.Nullable<decimal> _hourStartPrice;
		
		private System.Nullable<decimal> _hourAddPrice;
		
		private System.Nullable<decimal> _discountPrice;
		
		private EntitySet<room> _room;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OntypeChanging(int value);
    partial void OntypeChanged();
    partial void OntypeNameChanging(string value);
    partial void OntypeNameChanged();
    partial void OnonePriceChanging(decimal value);
    partial void OnonePriceChanged();
    partial void OnhourStartPriceChanging(System.Nullable<decimal> value);
    partial void OnhourStartPriceChanged();
    partial void OnhourAddPriceChanging(System.Nullable<decimal> value);
    partial void OnhourAddPriceChanged();
    partial void OndiscountPriceChanging(System.Nullable<decimal> value);
    partial void OndiscountPriceChanged();
    #endregion
		
		public roomtype()
		{
			this._room = new EntitySet<room>(new Action<room>(this.attach_room), new Action<room>(this.detach_room));
			OnCreated();
		}
		
		[Column(Storage="_type", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int type
		{
			get
			{
				return this._type;
			}
			set
			{
				if ((this._type != value))
				{
					this.OntypeChanging(value);
					this.SendPropertyChanging();
					this._type = value;
					this.SendPropertyChanged("type");
					this.OntypeChanged();
				}
			}
		}
		
		[Column(Storage="_typeName", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string typeName
		{
			get
			{
				return this._typeName;
			}
			set
			{
				if ((this._typeName != value))
				{
					this.OntypeNameChanging(value);
					this.SendPropertyChanging();
					this._typeName = value;
					this.SendPropertyChanged("typeName");
					this.OntypeNameChanged();
				}
			}
		}
		
		[Column(Storage="_onePrice", DbType="Decimal(18,2) NOT NULL")]
		public decimal onePrice
		{
			get
			{
				return this._onePrice;
			}
			set
			{
				if ((this._onePrice != value))
				{
					this.OnonePriceChanging(value);
					this.SendPropertyChanging();
					this._onePrice = value;
					this.SendPropertyChanged("onePrice");
					this.OnonePriceChanged();
				}
			}
		}
		
		[Column(Storage="_hourStartPrice", DbType="Decimal(18,2)")]
		public System.Nullable<decimal> hourStartPrice
		{
			get
			{
				return this._hourStartPrice;
			}
			set
			{
				if ((this._hourStartPrice != value))
				{
					this.OnhourStartPriceChanging(value);
					this.SendPropertyChanging();
					this._hourStartPrice = value;
					this.SendPropertyChanged("hourStartPrice");
					this.OnhourStartPriceChanged();
				}
			}
		}
		
		[Column(Storage="_hourAddPrice", DbType="Decimal(18,2)")]
		public System.Nullable<decimal> hourAddPrice
		{
			get
			{
				return this._hourAddPrice;
			}
			set
			{
				if ((this._hourAddPrice != value))
				{
					this.OnhourAddPriceChanging(value);
					this.SendPropertyChanging();
					this._hourAddPrice = value;
					this.SendPropertyChanged("hourAddPrice");
					this.OnhourAddPriceChanged();
				}
			}
		}
		
		[Column(Storage="_discountPrice", DbType="Decimal(18,2)")]
		public System.Nullable<decimal> discountPrice
		{
			get
			{
				return this._discountPrice;
			}
			set
			{
				if ((this._discountPrice != value))
				{
					this.OndiscountPriceChanging(value);
					this.SendPropertyChanging();
					this._discountPrice = value;
					this.SendPropertyChanged("discountPrice");
					this.OndiscountPriceChanged();
				}
			}
		}
		
		[Association(Name="roomtype_room", Storage="_room", ThisKey="type", OtherKey="rType")]
		public EntitySet<room> room
		{
			get
			{
				return this._room;
			}
			set
			{
				this._room.Assign(value);
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
		
		private void attach_room(room entity)
		{
			this.SendPropertyChanging();
			entity.roomtype = this;
		}
		
		private void detach_room(room entity)
		{
			this.SendPropertyChanging();
			entity.roomtype = null;
		}
	}
	
	[Table(Name="dbo.roomManage")]
	public partial class roomManage : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _roomId;
		
		private int _rType;
		
		private int _rStatue;
		
		private int _rFloor;
		
		private System.Nullable<int> _phone;
		
		private System.Nullable<bool> _isHourRoom;
		
		private string _description;
		
		private System.Nullable<System.DateTime> _time;
		
		private string _floorName;
		
		private string _statusName;
		
		private string _typeName;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnroomIdChanging(int value);
    partial void OnroomIdChanged();
    partial void OnrTypeChanging(int value);
    partial void OnrTypeChanged();
    partial void OnrStatueChanging(int value);
    partial void OnrStatueChanged();
    partial void OnrFloorChanging(int value);
    partial void OnrFloorChanged();
    partial void OnphoneChanging(System.Nullable<int> value);
    partial void OnphoneChanged();
    partial void OnisHourRoomChanging(System.Nullable<bool> value);
    partial void OnisHourRoomChanged();
    partial void OndescriptionChanging(string value);
    partial void OndescriptionChanged();
    partial void OntimeChanging(System.Nullable<System.DateTime> value);
    partial void OntimeChanged();
    partial void OnfloorNameChanging(string value);
    partial void OnfloorNameChanged();
    partial void OnstatusNameChanging(string value);
    partial void OnstatusNameChanged();
    partial void OntypeNameChanging(string value);
    partial void OntypeNameChanged();
    #endregion
		
		public roomManage()
		{
			OnCreated();
		}
		
		[Column(Storage="_roomId", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int roomId
		{
			get
			{
				return this._roomId;
			}
			set
			{
				if ((this._roomId != value))
				{
					this.OnroomIdChanging(value);
					this.SendPropertyChanging();
					this._roomId = value;
					this.SendPropertyChanged("roomId");
					this.OnroomIdChanged();
				}
			}
		}
		
		[Column(Storage="_rType", DbType="Int NOT NULL")]
		public int rType
		{
			get
			{
				return this._rType;
			}
			set
			{
				if ((this._rType != value))
				{
					this.OnrTypeChanging(value);
					this.SendPropertyChanging();
					this._rType = value;
					this.SendPropertyChanged("rType");
					this.OnrTypeChanged();
				}
			}
		}
		
		[Column(Storage="_rStatue", DbType="Int NOT NULL")]
		public int rStatue
		{
			get
			{
				return this._rStatue;
			}
			set
			{
				if ((this._rStatue != value))
				{
					this.OnrStatueChanging(value);
					this.SendPropertyChanging();
					this._rStatue = value;
					this.SendPropertyChanged("rStatue");
					this.OnrStatueChanged();
				}
			}
		}
		
		[Column(Storage="_rFloor", DbType="Int NOT NULL")]
		public int rFloor
		{
			get
			{
				return this._rFloor;
			}
			set
			{
				if ((this._rFloor != value))
				{
					this.OnrFloorChanging(value);
					this.SendPropertyChanging();
					this._rFloor = value;
					this.SendPropertyChanged("rFloor");
					this.OnrFloorChanged();
				}
			}
		}
		
		[Column(Storage="_phone", DbType="Int")]
		public System.Nullable<int> phone
		{
			get
			{
				return this._phone;
			}
			set
			{
				if ((this._phone != value))
				{
					this.OnphoneChanging(value);
					this.SendPropertyChanging();
					this._phone = value;
					this.SendPropertyChanged("phone");
					this.OnphoneChanged();
				}
			}
		}
		
		[Column(Storage="_isHourRoom", DbType="Bit")]
		public System.Nullable<bool> isHourRoom
		{
			get
			{
				return this._isHourRoom;
			}
			set
			{
				if ((this._isHourRoom != value))
				{
					this.OnisHourRoomChanging(value);
					this.SendPropertyChanging();
					this._isHourRoom = value;
					this.SendPropertyChanged("isHourRoom");
					this.OnisHourRoomChanged();
				}
			}
		}
		
		[Column(Storage="_description", DbType="NVarChar(50)")]
		public string description
		{
			get
			{
				return this._description;
			}
			set
			{
				if ((this._description != value))
				{
					this.OndescriptionChanging(value);
					this.SendPropertyChanging();
					this._description = value;
					this.SendPropertyChanged("description");
					this.OndescriptionChanged();
				}
			}
		}
		
		[Column(Storage="_time", DbType="SmallDateTime")]
		public System.Nullable<System.DateTime> time
		{
			get
			{
				return this._time;
			}
			set
			{
				if ((this._time != value))
				{
					this.OntimeChanging(value);
					this.SendPropertyChanging();
					this._time = value;
					this.SendPropertyChanged("time");
					this.OntimeChanged();
				}
			}
		}
		
		[Column(Storage="_floorName", DbType="NVarChar(10) NOT NULL", CanBeNull=false)]
		public string floorName
		{
			get
			{
				return this._floorName;
			}
			set
			{
				if ((this._floorName != value))
				{
					this.OnfloorNameChanging(value);
					this.SendPropertyChanging();
					this._floorName = value;
					this.SendPropertyChanged("floorName");
					this.OnfloorNameChanged();
				}
			}
		}
		
		[Column(Storage="_statusName", DbType="NChar(4) NOT NULL", CanBeNull=false)]
		public string statusName
		{
			get
			{
				return this._statusName;
			}
			set
			{
				if ((this._statusName != value))
				{
					this.OnstatusNameChanging(value);
					this.SendPropertyChanging();
					this._statusName = value;
					this.SendPropertyChanged("statusName");
					this.OnstatusNameChanged();
				}
			}
		}
		
		[Column(Storage="_typeName", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string typeName
		{
			get
			{
				return this._typeName;
			}
			set
			{
				if ((this._typeName != value))
				{
					this.OntypeNameChanging(value);
					this.SendPropertyChanging();
					this._typeName = value;
					this.SendPropertyChanged("typeName");
					this.OntypeNameChanged();
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
	
	[Table(Name="dbo.[user]")]
	public partial class user : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _Name;
		
		private string _PassWord;
		
		private int _Rights;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnPassWordChanging(string value);
    partial void OnPassWordChanged();
    partial void OnRightsChanging(int value);
    partial void OnRightsChanged();
    #endregion
		
		public user()
		{
			OnCreated();
		}
		
		[Column(Storage="_Name", DbType="NVarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
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
		
		[Column(Storage="_PassWord", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string PassWord
		{
			get
			{
				return this._PassWord;
			}
			set
			{
				if ((this._PassWord != value))
				{
					this.OnPassWordChanging(value);
					this.SendPropertyChanging();
					this._PassWord = value;
					this.SendPropertyChanged("PassWord");
					this.OnPassWordChanged();
				}
			}
		}
		
		[Column(Storage="_Rights", DbType="Int NOT NULL")]
		public int Rights
		{
			get
			{
				return this._Rights;
			}
			set
			{
				if ((this._Rights != value))
				{
					this.OnRightsChanging(value);
					this.SendPropertyChanging();
					this._Rights = value;
					this.SendPropertyChanged("Rights");
					this.OnRightsChanged();
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
	
	public partial class InsertRoom_个结果
	{
		
		private int _roomId;
		
		private int _rType;
		
		private int _rStatue;
		
		private int _rFloor;
		
		private System.Nullable<int> _phone;
		
		private System.Nullable<bool> _isHourRoom;
		
		private string _description;
		
		private System.Nullable<System.DateTime> _time;
		
		public InsertRoom_个结果()
		{
		}
		
		[Column(Storage="_roomId", DbType="Int NOT NULL")]
		public int roomId
		{
			get
			{
				return this._roomId;
			}
			set
			{
				if ((this._roomId != value))
				{
					this._roomId = value;
				}
			}
		}
		
		[Column(Storage="_rType", DbType="Int NOT NULL")]
		public int rType
		{
			get
			{
				return this._rType;
			}
			set
			{
				if ((this._rType != value))
				{
					this._rType = value;
				}
			}
		}
		
		[Column(Storage="_rStatue", DbType="Int NOT NULL")]
		public int rStatue
		{
			get
			{
				return this._rStatue;
			}
			set
			{
				if ((this._rStatue != value))
				{
					this._rStatue = value;
				}
			}
		}
		
		[Column(Storage="_rFloor", DbType="Int NOT NULL")]
		public int rFloor
		{
			get
			{
				return this._rFloor;
			}
			set
			{
				if ((this._rFloor != value))
				{
					this._rFloor = value;
				}
			}
		}
		
		[Column(Storage="_phone", DbType="Int")]
		public System.Nullable<int> phone
		{
			get
			{
				return this._phone;
			}
			set
			{
				if ((this._phone != value))
				{
					this._phone = value;
				}
			}
		}
		
		[Column(Storage="_isHourRoom", DbType="Bit")]
		public System.Nullable<bool> isHourRoom
		{
			get
			{
				return this._isHourRoom;
			}
			set
			{
				if ((this._isHourRoom != value))
				{
					this._isHourRoom = value;
				}
			}
		}
		
		[Column(Storage="_description", DbType="NVarChar(50)")]
		public string description
		{
			get
			{
				return this._description;
			}
			set
			{
				if ((this._description != value))
				{
					this._description = value;
				}
			}
		}
		
		[Column(Storage="_time", DbType="SmallDateTime")]
		public System.Nullable<System.DateTime> time
		{
			get
			{
				return this._time;
			}
			set
			{
				if ((this._time != value))
				{
					this._time = value;
				}
			}
		}
	}
	
	public partial class UpdateRoom_个结果
	{
		
		private int _roomId;
		
		private int _rType;
		
		private int _rStatue;
		
		private int _rFloor;
		
		private System.Nullable<int> _phone;
		
		private System.Nullable<bool> _isHourRoom;
		
		private string _description;
		
		private System.Nullable<System.DateTime> _time;
		
		public UpdateRoom_个结果()
		{
		}
		
		[Column(Storage="_roomId", DbType="Int NOT NULL")]
		public int roomId
		{
			get
			{
				return this._roomId;
			}
			set
			{
				if ((this._roomId != value))
				{
					this._roomId = value;
				}
			}
		}
		
		[Column(Storage="_rType", DbType="Int NOT NULL")]
		public int rType
		{
			get
			{
				return this._rType;
			}
			set
			{
				if ((this._rType != value))
				{
					this._rType = value;
				}
			}
		}
		
		[Column(Storage="_rStatue", DbType="Int NOT NULL")]
		public int rStatue
		{
			get
			{
				return this._rStatue;
			}
			set
			{
				if ((this._rStatue != value))
				{
					this._rStatue = value;
				}
			}
		}
		
		[Column(Storage="_rFloor", DbType="Int NOT NULL")]
		public int rFloor
		{
			get
			{
				return this._rFloor;
			}
			set
			{
				if ((this._rFloor != value))
				{
					this._rFloor = value;
				}
			}
		}
		
		[Column(Storage="_phone", DbType="Int")]
		public System.Nullable<int> phone
		{
			get
			{
				return this._phone;
			}
			set
			{
				if ((this._phone != value))
				{
					this._phone = value;
				}
			}
		}
		
		[Column(Storage="_isHourRoom", DbType="Bit")]
		public System.Nullable<bool> isHourRoom
		{
			get
			{
				return this._isHourRoom;
			}
			set
			{
				if ((this._isHourRoom != value))
				{
					this._isHourRoom = value;
				}
			}
		}
		
		[Column(Storage="_description", DbType="NVarChar(50)")]
		public string description
		{
			get
			{
				return this._description;
			}
			set
			{
				if ((this._description != value))
				{
					this._description = value;
				}
			}
		}
		
		[Column(Storage="_time", DbType="SmallDateTime")]
		public System.Nullable<System.DateTime> time
		{
			get
			{
				return this._time;
			}
			set
			{
				if ((this._time != value))
				{
					this._time = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
