USE [master]
GO
/****** Object:  Database [Calorimeter1]    Script Date: 2023/4/17 16:22:41 ******/
CREATE DATABASE [Calorimeter1]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Calorimeter1', FILENAME = N'E:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\Calorimeter1.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Calorimeter1_log', FILENAME = N'E:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\Calorimeter1.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [Calorimeter1] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Calorimeter1].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Calorimeter1] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Calorimeter1] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Calorimeter1] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Calorimeter1] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Calorimeter1] SET ARITHABORT OFF 
GO
ALTER DATABASE [Calorimeter1] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [Calorimeter1] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [Calorimeter1] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Calorimeter1] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Calorimeter1] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Calorimeter1] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Calorimeter1] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Calorimeter1] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Calorimeter1] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Calorimeter1] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Calorimeter1] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Calorimeter1] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Calorimeter1] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Calorimeter1] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Calorimeter1] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Calorimeter1] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Calorimeter1] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Calorimeter1] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Calorimeter1] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Calorimeter1] SET  MULTI_USER 
GO
ALTER DATABASE [Calorimeter1] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Calorimeter1] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Calorimeter1] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Calorimeter1] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
EXEC sys.sp_db_vardecimal_storage_format N'Calorimeter1', N'ON'
GO
USE [Calorimeter1]
GO
/****** Object:  Table [dbo].[CalorimeterTable1]    Script Date: 2023/4/17 16:22:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CalorimeterTable1](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Table_number] [nvarchar](30) NOT NULL,
	[Cooling_capacity] [numeric](20, 2) NULL,
	[Calories] [numeric](20, 2) NULL,
	[Thermal_power] [numeric](8, 2) NULL,
	[Instantaneous_flow] [numeric](8, 4) NULL,
	[Cumulative_flow] [numeric](20, 4) NULL,
	[Water_supply_temperature] [numeric](8, 2) NULL,
	[Return_watertemperature] [numeric](6, 2) NULL,
	[Cumulative_working_time] [numeric](20, 0) NULL,
	[Instrument_current_time] [nvarchar](50) NULL,
	[Instrument_status] [numeric](4, 0) NULL,
	[CreateTime] [datetime] NULL,
 CONSTRAINT [PK_CalorimeterTable1_1] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Cost_Schedule]    Script Date: 2023/4/17 16:22:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cost_Schedule](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Table_number] [nvarchar](30) NOT NULL,
	[Cooling_capacity] [numeric](20, 2) NULL,
	[Calories] [numeric](20, 2) NULL,
	[Dosage_Cooling_capacity] [numeric](10, 2) NULL,
	[Dosage_Calories] [numeric](10, 2) NULL,
	[Cost_Cooling_capacity] [money] NULL,
	[Cost_Calories] [money] NULL,
	[Total_cost] [money] NULL,
	[CreateTime] [datetime] NULL,
	[Cooling_price] [money] NULL,
	[Calories_price] [money] NULL,
 CONSTRAINT [PK_Cost_Schedule] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NumberofLayers]    Script Date: 2023/4/17 16:22:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NumberofLayers](
	[NumberofLayersId] [int] NOT NULL,
	[NumberofLayer] [varchar](20) NULL,
 CONSTRAINT [PK_NumberofLayers] PRIMARY KEY CLUSTERED 
(
	[NumberofLayersId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Table_Numbers1]    Script Date: 2023/4/17 16:22:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Table_Numbers1](
	[Table_Number1] [nvarchar](30) NOT NULL,
	[NumberofLayersId] [int] NOT NULL,
	[ControlAddress] [nvarchar](10) NOT NULL,
	[Port_diection] [nvarchar](5) NOT NULL,
 CONSTRAINT [PK_Table_Numbers1] PRIMARY KEY CLUSTERED 
(
	[Table_Number1] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Table_NumberTest]    Script Date: 2023/4/17 16:22:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Table_NumberTest](
	[Table_Number1] [nvarchar](30) NOT NULL,
	[NumberofLayersId] [int] NOT NULL,
	[ControlAddress] [nvarchar](10) NOT NULL,
	[Port_diection] [nvarchar](5) NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Unit_pricess]    Script Date: 2023/4/17 16:22:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Unit_pricess](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Calories] [money] NOT NULL,
	[Cooling_capacity] [money] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[User_balance]    Script Date: 2023/4/17 16:22:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User_balance](
	[Table_number] [nvarchar](30) NOT NULL,
	[Names] [nvarchar](20) NULL,
	[Balance] [money] NULL,
	[Quota] [money] NULL,
	[NumberofLayersId] [int] NULL,
	[Room_No] [nvarchar](50) NULL,
 CONSTRAINT [PK_User_balance] PRIMARY KEY CLUSTERED 
(
	[Table_number] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[User_data1]    Script Date: 2023/4/17 16:22:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[User_data1](
	[Table_number] [nvarchar](30) NOT NULL,
	[Names] [nvarchar](20) NULL,
	[Gender] [char](2) NULL,
	[Room_No] [nvarchar](50) NULL,
	[Building] [nvarchar](50) NULL,
	[Phone] [nvarchar](100) NULL,
	[NumberofLayersId] [int] NULL,
	[Billabletime] [smalldatetime] NULL,
	[CreateTime] [datetime] NULL,
 CONSTRAINT [PK_User_data1] PRIMARY KEY CLUSTERED 
(
	[Table_number] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[User_payment1]    Script Date: 2023/4/17 16:22:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User_payment1](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Table_number] [nvarchar](30) NOT NULL,
	[Names] [nvarchar](20) NULL,
	[Cost] [money] NOT NULL,
	[Billabletime] [smalldatetime] NULL,
	[CreateTime] [datetime] NOT NULL,
 CONSTRAINT [PK_User_payment1_1] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  View [dbo].[AdvancedView]    Script Date: 2023/4/17 16:22:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--添加视图
CREATE VIEW [dbo].[AdvancedView]
AS
SELECT  dbo.Cost_Schedule.Table_number, dbo.User_data1.Names, dbo.User_data1.Room_No, dbo.User_data1.Building, 
                   dbo.Cost_Schedule.Cooling_capacity, dbo.Cost_Schedule.Calories, dbo.Cost_Schedule.Dosage_Cooling_capacity, 
                   dbo.Cost_Schedule.Dosage_Calories, dbo.Cost_Schedule.Cost_Cooling_capacity, dbo.Cost_Schedule.Cost_Calories, 
                   dbo.Cost_Schedule.Total_cost, dbo.Cost_Schedule.CreateTime, dbo.Cost_Schedule.Calories_price, 
                   dbo.Cost_Schedule.Cooling_price
FROM      dbo.User_data1 INNER JOIN
                   dbo.Cost_Schedule ON dbo.User_data1.Table_number = dbo.Cost_Schedule.Table_number

GO
/****** Object:  View [dbo].[View_user_balance]    Script Date: 2023/4/17 16:22:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[View_user_balance]
AS
SELECT  dbo.User_data1.Table_number, dbo.User_data1.Names, dbo.User_balance.Balance, dbo.User_balance.Quota, 
                   dbo.NumberofLayers.NumberofLayer, dbo.User_data1.Room_No
FROM      dbo.User_balance INNER JOIN
                   dbo.User_data1 ON dbo.User_balance.Table_number = dbo.User_data1.Table_number INNER JOIN
                   dbo.NumberofLayers ON dbo.User_data1.NumberofLayersId = dbo.NumberofLayers.NumberofLayersId

GO
ALTER TABLE [dbo].[CalorimeterTable1] ADD  CONSTRAINT [DF_CalorimeterTable1_Cooling_capacity]  DEFAULT ((0.00)) FOR [Cooling_capacity]
GO
ALTER TABLE [dbo].[CalorimeterTable1] ADD  CONSTRAINT [DF_CalorimeterTable1_Calories]  DEFAULT ((0.00)) FOR [Calories]
GO
ALTER TABLE [dbo].[CalorimeterTable1] ADD  CONSTRAINT [DF_CalorimeterTable1_Thermal_power]  DEFAULT ((0.00)) FOR [Thermal_power]
GO
ALTER TABLE [dbo].[CalorimeterTable1] ADD  CONSTRAINT [DF_CalorimeterTable1_Instantaneous_flow]  DEFAULT ((0.0000)) FOR [Instantaneous_flow]
GO
ALTER TABLE [dbo].[CalorimeterTable1] ADD  CONSTRAINT [DF_CalorimeterTable1_Water_supply_temperature]  DEFAULT ((0.00)) FOR [Water_supply_temperature]
GO
ALTER TABLE [dbo].[CalorimeterTable1] ADD  CONSTRAINT [DF_CalorimeterTable1_Return_watertemperature]  DEFAULT ((0.00)) FOR [Return_watertemperature]
GO
ALTER TABLE [dbo].[CalorimeterTable1] ADD  CONSTRAINT [DF_CalorimeterTable1_Cumulative_working_time]  DEFAULT ((0)) FOR [Cumulative_working_time]
GO
ALTER TABLE [dbo].[CalorimeterTable1] ADD  CONSTRAINT [DF_CalorimeterTable1_Instrument_current_time]  DEFAULT ((0)) FOR [Instrument_current_time]
GO
ALTER TABLE [dbo].[CalorimeterTable1] ADD  CONSTRAINT [DF_CalorimeterTable1_Instrument_status]  DEFAULT ((0)) FOR [Instrument_status]
GO
ALTER TABLE [dbo].[CalorimeterTable1] ADD  CONSTRAINT [DF_CalorimeterTable1_CreateTime]  DEFAULT (getdate()) FOR [CreateTime]
GO
ALTER TABLE [dbo].[Cost_Schedule] ADD  CONSTRAINT [DF_Cost_Schedule_Table_number]  DEFAULT ((0)) FOR [Table_number]
GO
ALTER TABLE [dbo].[Cost_Schedule] ADD  CONSTRAINT [DF_Cost_Schedule_Cooling_capacity]  DEFAULT ((0.00)) FOR [Cooling_capacity]
GO
ALTER TABLE [dbo].[Cost_Schedule] ADD  CONSTRAINT [DF_Cost_Schedule_Calories]  DEFAULT ((0.00)) FOR [Calories]
GO
ALTER TABLE [dbo].[Cost_Schedule] ADD  CONSTRAINT [DF_Cost_Schedule_Dosage_Cooling_capacity]  DEFAULT ((0.00)) FOR [Dosage_Cooling_capacity]
GO
ALTER TABLE [dbo].[Cost_Schedule] ADD  CONSTRAINT [DF_Cost_Schedule_Dosage_Calories]  DEFAULT ((0.00)) FOR [Dosage_Calories]
GO
ALTER TABLE [dbo].[Cost_Schedule] ADD  CONSTRAINT [DF_Cost_Schedule_Cost_Cooling_capacity]  DEFAULT ((0)) FOR [Cost_Cooling_capacity]
GO
ALTER TABLE [dbo].[Cost_Schedule] ADD  CONSTRAINT [DF_Cost_Schedule_Cost_Calories]  DEFAULT ((0)) FOR [Cost_Calories]
GO
ALTER TABLE [dbo].[Cost_Schedule] ADD  CONSTRAINT [DF_Cost_Schedule_Total_cost]  DEFAULT ((0)) FOR [Total_cost]
GO
ALTER TABLE [dbo].[Cost_Schedule] ADD  CONSTRAINT [DF_Cost_Schedule_CreateTime]  DEFAULT (getdate()) FOR [CreateTime]
GO
ALTER TABLE [dbo].[Table_Numbers1] ADD  CONSTRAINT [DF_Table_Numbers1_ControlAddress]  DEFAULT ((0)) FOR [ControlAddress]
GO
ALTER TABLE [dbo].[Unit_pricess] ADD  CONSTRAINT [DF_Unit_pricess_Calories]  DEFAULT ((0.0)) FOR [Calories]
GO
ALTER TABLE [dbo].[Unit_pricess] ADD  CONSTRAINT [DF_Unit_pricess_Cooling_capacity]  DEFAULT ((0.0)) FOR [Cooling_capacity]
GO
ALTER TABLE [dbo].[User_balance] ADD  CONSTRAINT [DF_User_balance_Balance]  DEFAULT ((0.0)) FOR [Balance]
GO
ALTER TABLE [dbo].[User_balance] ADD  CONSTRAINT [DF_User_balance_Quota]  DEFAULT ((0.0)) FOR [Quota]
GO
ALTER TABLE [dbo].[User_data1] ADD  CONSTRAINT [DF_User_data_CreateTime]  DEFAULT (getdate()) FOR [CreateTime]
GO
ALTER TABLE [dbo].[User_payment1] ADD  CONSTRAINT [DF_User_payment1_CreateTime]  DEFAULT (getdate()) FOR [CreateTime]
GO
ALTER TABLE [dbo].[CalorimeterTable1]  WITH NOCHECK ADD  CONSTRAINT [FK_CalorimeterTable1_Table_Numbers1] FOREIGN KEY([Table_number])
REFERENCES [dbo].[Table_Numbers1] ([Table_Number1])
GO
ALTER TABLE [dbo].[CalorimeterTable1] CHECK CONSTRAINT [FK_CalorimeterTable1_Table_Numbers1]
GO
ALTER TABLE [dbo].[Table_Numbers1]  WITH NOCHECK ADD  CONSTRAINT [FK_Table_Numbers1_NumberofLayers] FOREIGN KEY([NumberofLayersId])
REFERENCES [dbo].[NumberofLayers] ([NumberofLayersId])
GO
ALTER TABLE [dbo].[Table_Numbers1] CHECK CONSTRAINT [FK_Table_Numbers1_NumberofLayers]
GO
ALTER TABLE [dbo].[Table_Numbers1]  WITH NOCHECK ADD  CONSTRAINT [FK_Table_Numbers1_Table_Numbers1] FOREIGN KEY([Table_Number1])
REFERENCES [dbo].[Table_Numbers1] ([Table_Number1])
GO
ALTER TABLE [dbo].[Table_Numbers1] CHECK CONSTRAINT [FK_Table_Numbers1_Table_Numbers1]
GO
ALTER TABLE [dbo].[User_data1]  WITH NOCHECK ADD  CONSTRAINT [FK_User_data1_NumberofLayers] FOREIGN KEY([NumberofLayersId])
REFERENCES [dbo].[NumberofLayers] ([NumberofLayersId])
GO
ALTER TABLE [dbo].[User_data1] CHECK CONSTRAINT [FK_User_data1_NumberofLayers]
GO
ALTER TABLE [dbo].[User_data1]  WITH NOCHECK ADD  CONSTRAINT [FK_User_data1_Table_Numbers1] FOREIGN KEY([Table_number])
REFERENCES [dbo].[Table_Numbers1] ([Table_Number1])
GO
ALTER TABLE [dbo].[User_data1] CHECK CONSTRAINT [FK_User_data1_Table_Numbers1]
GO
/****** Object:  DdlTrigger [OnTriggerDboSchema]    Script Date: 2023/4/17 16:22:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE trigger [OnTriggerDboSchema] ON database FOR create_table, create_view AS BEGIN   DECLARE @xmlEventData xml   SELECT    @xmlEventData = eventdata()   DECLARE @schemaName nvarchar(max)   DECLARE @objectName nvarchar(max)   DECLARE @DynSql nvarchar(max)      SET @schemaName    = convert(nvarchar(max), @xmlEventData.query('/EVENT_INSTANCE/SchemaName/text()'))   SET @objectName    = convert(nvarchar(max), @xmlEventData.query('/EVENT_INSTANCE/ObjectName/text()'))   IF(@schemaName='')   BEGIN     SET @DynSql = N'alter schema [dbo] transfer [' + @schemaName + N'].[' + @objectName + N']'     EXEC sp_executesql @statement=@DynSql   END END SET QUOTED_IDENTIFIER ON SET ANSI_NULLS ON 

GO
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
ENABLE TRIGGER [OnTriggerDboSchema] ON DATABASE
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'用户余额' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'User_balance', @level2type=N'COLUMN',@level2name=N'Balance'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[41] 4[34] 2[14] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1[50] 2[25] 3) )"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "User_data1"
            Begin Extent = 
               Top = 19
               Left = 200
               Bottom = 252
               Right = 481
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Cost_Schedule"
            Begin Extent = 
               Top = 7
               Left = 658
               Bottom = 292
               Right = 1057
            End
            DisplayFlags = 280
            TopColumn = 5
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 2364
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1356
         SortOrder = 1416
         GroupBy = 1356
         Filter = 1776
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'AdvancedView'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'AdvancedView'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "User_data1"
            Begin Extent = 
               Top = 41
               Left = 414
               Bottom = 319
               Right = 644
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "NumberofLayers"
            Begin Extent = 
               Top = 11
               Left = 775
               Bottom = 130
               Right = 1005
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "User_balance"
            Begin Extent = 
               Top = 7
               Left = 48
               Bottom = 180
               Right = 247
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1176
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1356
         SortOrder = 1416
         GroupBy = 1350
         Filter = 1356
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_user_balance'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_user_balance'
GO
USE [master]
GO
ALTER DATABASE [Calorimeter1] SET  READ_WRITE 
GO
