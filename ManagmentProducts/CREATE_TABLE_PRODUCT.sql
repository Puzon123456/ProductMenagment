Create Table Products(
Id UNIQUEIDENTIFIER DEFAULT NEWID() Primary Key,
Name NVarchar(100) Not Null,
Price Decimal
)