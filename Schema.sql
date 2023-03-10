DROP TABLE  [dbo].SourceConnectionSetting
GO
IF NOT EXISTS(SELECT 1 FROM INFORMATION_SCHEMA.TABLES
              WHERE TABLE_NAME = 'SourceConnectionSetting')
BEGIN

   CREATE TABLE [dbo].SourceConnectionSetting(
      SettingID NVARCHAR(30) NOT NULL
	, Value VARCHAR(1026) NOT NULL

	CONSTRAINT [SourceConnectionSetting_PK] PRIMARY KEY ([SettingID] )
   )
END   
GO

-- Source ERP system
Insert Into SourceConnectionSetting (SettingID, Value) Values ('Datasource','(local)')
Insert Into SourceConnectionSetting (SettingID, Value) Values ('InitCatalog','Hackathon')
Insert Into SourceConnectionSetting (SettingID, Value) Values ('UserID','sa')
Insert Into SourceConnectionSetting (SettingID, Value) Values ('Password','')

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

INSERT INTO SyncInstance(InstanceID,Descr,PluginName,AcuEndpointName,AcuEndpointVersion,AcuResourceName,AcuObjectName)
VALUES ('Customer', 'Customer', 'Sage500', 'Customer','22.200.001', '', '')

IF NOT EXISTS(SELECT 1 FROM INFORMATION_SCHEMA.TABLES
              WHERE TABLE_NAME = 'SourceQueryString')
BEGIN

   CREATE TABLE [dbo].SourceQueryString(
      InstanceID VARCHAR(15) NOT NULL FOREIGN KEY REFERENCES SyncInstance(InstanceID)
	, SettingID VARCHAR(15) NOT NULL
	, Value VARCHaR(1026) NOT NULL
	
	CONSTRAINT [SourceQueryString_PK] PRIMARY KEY ( [InstanceID], [SettingID] )

   )
END   
GO

DROP TABLE SyncMapping
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

TRUNCATE TABLE SyncMapping
Insert into SyncMapping (InstanceID, SourceField, DestField) Values ('Customer','CustKey','')
Insert into SyncMapping (InstanceID, SourceField, DestField) Values ('Customer','CustID'?,'CustomerID')
Insert into SyncMapping (InstanceID, SourceField, DestField) Values ('Customer','CustName','CustomerName')
Insert into SyncMapping (InstanceID, SourceField, DestField) Values ('Customer','Status','')
Insert into SyncMapping (InstanceID, SourceField, DestField) Values ('Customer','CreateDate','')
Insert into SyncMapping (InstanceID, SourceField, DestField) Values ('Customer','UpdateDate','')
Insert into SyncMapping (InstanceID, SourceField, DestField) Values ('Customer','CustClassID','CustomerClass')
Insert into SyncMapping (InstanceID, SourceField, DestField) Values ('Customer','AddrLine1','')
Insert into SyncMapping (InstanceID, SourceField, DestField) Values ('Customer','AddrLine2','')
Insert into SyncMapping (InstanceID, SourceField, DestField) Values ('Customer','CountryID','')
Insert into SyncMapping (InstanceID, SourceField, DestField) Values ('Customer','City','')
Insert into SyncMapping (InstanceID, SourceField, DestField) Values ('Customer','StateID','')
Insert into SyncMapping (InstanceID, SourceField, DestField) Values ('Customer','Name','PrimaryContact/FirstName')
Insert into SyncMapping (InstanceID, SourceField, DestField) Values ('Customer','Phone','MainContact/Phone1')
Insert into SyncMapping (InstanceID, SourceField, DestField) Values ('Customer','EmailAddr','MainContact/EMail')

IF NOT EXISTS(SELECT 1 FROM INFORMATION_SCHEMA.TABLES
              WHERE TABLE_NAME = 'SyncRow')
BEGIN

   CREATE TABLE [dbo].SyncRow(
      InstanceID VARCHAR(15) NOT NULL FOREIGN KEY REFERENCES SyncInstance(InstanceID)
	, RowNbr INT NOT NULL
	, NoteID varchar(256) NULL
	, Failed TINYINT NOT NULL DEFAULT 0
	, ErrorMessage NVARCHAR(MAX) NULL

	CONSTRAINT [SyncRow_PK] PRIMARY KEY ( [InstanceID], [RowNbr] )
   )
END   
GO

INSERT INTO SyncRow (InstanceID, RowNbr, NoteID) VALUES('Customer', 0, NEWID())
INSERT INTO SyncRow (InstanceID, RowNbr, NoteID) VALUES('Customer', 1, NEWID())
INSERT INTO SyncRow (InstanceID, RowNbr, NoteID) VALUES('Customer', 2, NEWID())
INSERT INTO SyncRow (InstanceID, RowNbr, NoteID) VALUES('Customer', 3, NEWID())
INSERT INTO SyncRow (InstanceID, RowNbr, NoteID) VALUES('Customer', 4, NEWID())
INSERT INTO SyncRow (InstanceID, RowNbr, NoteID) VALUES('Customer', 5, NEWID())
INSERT INTO SyncRow (InstanceID, RowNbr, NoteID) VALUES('Customer', 6, NEWID())
INSERT INTO SyncRow (InstanceID, RowNbr, NoteID) VALUES('Customer', 7, NEWID())
INSERT INTO SyncRow (InstanceID, RowNbr, NoteID) VALUES('Customer', 8, NEWID())
INSERT INTO SyncRow (InstanceID, RowNbr, NoteID) VALUES('Customer', 9, NEWID())
INSERT INTO SyncRow (InstanceID, RowNbr, NoteID) VALUES('Customer', 10, NEWID())
INSERT INTO SyncRow (InstanceID, RowNbr, NoteID) VALUES('Customer', 11, NEWID())
INSERT INTO SyncRow (InstanceID, RowNbr, NoteID) VALUES('Customer',12, NEWID())
INSERT INTO SyncRow (InstanceID, RowNbr, NoteID) VALUES('Customer', 13, NEWID())
INSERT INTO SyncRow (InstanceID, RowNbr, NoteID) VALUES('Customer', 14, NEWID())
INSERT INTO SyncRow (InstanceID, RowNbr, NoteID) VALUES('Customer', 15, NEWID())

IF NOT EXISTS(SELECT 1 FROM INFORMATION_SCHEMA.TABLES
              WHERE TABLE_NAME = 'SyncField')
BEGIN

   CREATE TABLE [dbo].SyncField(
      InstanceID VARCHAR(15) NOT NULL
	, RowNbr INT NOT NULL
	, SourceFieldName NVARCHAR(256) NOT NULL
	, DataType NVARCHAR(125) NOT NULL
	, Value NVARCHAR(1026) NULL

	CONSTRAINT [SyncField_PK] PRIMARY KEY ( [InstanceID], [RowNbr], [SourceFieldName] )
   )
END   
GO