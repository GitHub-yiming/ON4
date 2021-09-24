
--�������Cooling_price��Calories_price�ֶ�
--������ͼ���Cooling_price��Calories_price
--���ã���������
USE [Calorimeter1]
GO

/****** Object:  View [dbo].[AdvancedView]    Script Date: 2021/9/24 15:25:16 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

--����ֶ�
IF COL_LENGTH('Cost_Schedule','Cooling_price') IS NULL
begin
  alter table Cost_Schedule add
  Cooling_price  money null,
  Calories_price  money null;
end

--�ж���ͼ������
if exists(select * from sys.views where name='AdvancedView')
drop view AdvancedView;
go
--�����ͼ
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

