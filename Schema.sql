DROP TABLE  [dbo].ConnectionSetting
GO
IF NOT EXISTS(SELECT 1 FROM INFORMATION_SCHEMA.TABLES
              WHERE TABLE_NAME = 'ConnectionSetting')
BEGIN

   CREATE TABLE [dbo].ConnectionSetting(
      SettingID NVARCHAR(30) NOT NULL,
	  IsDest bit NOT NULL DEFAULT(0),
	  Value VARCHAR(1026) NOT NULL

	CONSTRAINT [ConnectionSetting_PK] PRIMARY KEY ([SettingID] )
   )
END   
GO


-- Source ERP system
Insert Into SourceConnectionSetting (SettingID, Value) Values ('RemoteDatasource','(local)')
Insert Into SourceConnectionSetting (SettingID, Value) Values ('RemoteInitCatalog','Hackathon')
Insert Into SourceConnectionSetting (SettingID, Value) Values ('RemoteUserID','sa')
Insert Into SourceConnectionSetting (SettingID, Value) Values ('RemotePassword','')

Insert Into SourceConnectionSetting (SettingID, Value) Values ('LocalDatasource','(local)')
Insert Into SourceConnectionSetting (SettingID, Value) Values ('LocalInitCatalog','AcuConvert')
Insert Into SourceConnectionSetting (SettingID, Value) Values ('LocalUserID','sa')
Insert Into SourceConnectionSetting (SettingID, Value) Values ('LocalPassword','')




IF NOT EXISTS(SELECT 1 FROM INFORMATION_SCHEMA.TABLES
              WHERE TABLE_NAME = 'SyncInstance')
BEGIN

   CREATE TABLE [dbo].SyncInstance(
      InstanceID VARCHAR(15) NOT NULL
	, Descr varchar(256) NULL
	, LastRowNbr INT DEFAULT(0)
	, LastRun DATETIME NULL
	, PluginName VARCHAR(1025) NULL
	, AcuEndpointName VARCHAR(1025) NULL
	, AcuEndpointVersion VARCHAR(1025) NULL
	, AcuResourceName VARCHAR(1025) NULL
	, AcuObjectName VARCHAR(1025) NULL
	
	CONSTRAINT [SyncInstance_PK] PRIMARY KEY ( [InstanceID] )

   )
END   
GO

IF NOT EXISTS(SELECT 1 FROM INFORMATION_SCHEMA.TABLES
              WHERE TABLE_NAME = 'SourceQuerySetting')
BEGIN

   CREATE TABLE [dbo].SourceQuerySetting(
      InstanceID VARCHAR(15) NOT NULL FOREIGN KEY REFERENCES SyncInstance(InstanceID)
	, SettingID VARCHAR(15) NOT NULL
	, Value VARCHaR(1026) NOT NULL
	
	CONSTRAINT [SourceQuerySetting_PK] PRIMARY KEY ( [InstanceID], [SettingID] )

   )
END   
GO

IF NOT EXISTS(SELECT 1 FROM INFORMATION_SCHEMA.TABLES
              WHERE TABLE_NAME = 'SyncMapping')
BEGIN

   CREATE TABLE [dbo].SyncMapping(
      MappingID INT IDENTITY NOT NULL
	, InstanceID VARCHAR(15) NOT NULL FOREIGN KEY REFERENCES SyncInstance(InstanceID)
	, SourceField VARCHAR(256) NULL
	, DestField VARCHAR(256) NULL
	, SourceValue VARCHAR(256) NULL
	CONSTRAINT [SyncMapping_PK] PRIMARY KEY ( [MappingID] )
   )
END   
GO

IF NOT EXISTS(SELECT 1 FROM INFORMATION_SCHEMA.TABLES
              WHERE TABLE_NAME = 'SyncRow')
BEGIN

   CREATE TABLE [dbo].SyncRow(
      InstanceID VARCHAR(15) NOT NULL FOREIGN KEY REFERENCES SyncInstance(InstanceID)
	, RowNbr INT NOT NULL
	, NoteID UniqueIdentifier NULL
	, Failed TINYINT NOT NULL DEFAULT 0
	, ErrorMessage NVARCHAR(MAX) NULL

	CONSTRAINT [SyncRow_PK] PRIMARY KEY ( [InstanceID], [RowNbr] )
   )
END   
GO

IF NOT EXISTS(SELECT 1 FROM INFORMATION_SCHEMA.TABLES
              WHERE TABLE_NAME = 'SyncField')
BEGIN

   CREATE TABLE [dbo].SyncField(
      InstanceID VARCHAR(15) NOT NULL
	, RowNbr INT NOT NULL
	, SourceFieldName NVARCHAR(256) NOT NULL
	, IsKey bit NOT NULL DEFAULT 0
	, DataType NVARCHAR(125) NOT NULL
	, Value NVARCHAR(1026) NULL

	CONSTRAINT [SyncField_PK] PRIMARY KEY ( [InstanceID], [RowNbr], [SourceFieldName] )
   )
END   
GO