   M S B A M L   `   `   `  ????I  EQuanLyKhachSan, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:QuanLyKhachSanQuanLyKhachSan  5      "    QuanLyKhachSan.PageEmployees   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:QuanLyKhachSan     5      _ [MaterialDesignThemes.Wpf, Version=4.2.1.2, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5        N? Title$  PageCustomer??5	      .??5      #  MaterialDesignThemes.Wpf.Card  .??5   
   ?  ? ColumnDefinitions 5      ?? 5      $??90 ?6#   60   ?? 5      6%   .+?5      ? $??1??6   .+?5      ?? $
??Auto=?6   $
??Auto=?5      .??5      &   System.Windows.Controls.DataGrid  $??8q?6      CanUserSortColumns .    CanUserAddRows .     AutoGenerateColumns .  -  'MaterialDesignThemes.Wpf.DataGridAssist   CellPadding$ 8q?5         ColumnHeaderPadding$ 20q?5      ??5      ?? *Items3+   Columns 5      4  .System.Windows.Controls.DataGridCheckBoxColumn  5       -  )MaterialDesignDataGridCheckBoxColumnStyle1  +System.Windows.Controls.DataGridBoundColumn   ElementStyle# [  5   -    4 0MaterialDesignDataGridCheckBoxColumnEditingStyle	   EditingElementStyle#	 [ 5   -   ,  &System.Windows.Controls.DataGridColumn
   Header$
 
Quản lý??5   -      MinWidth$ 50Q?5    -      Binding 5   5   ?? *
IsSelected+5    -   0  *System.Windows.Controls.DataGridTextColumn  5!      $	
 STT??5"   )    ) %MaterialDesignDataGridTextColumnStyle# [ 5#   )    0 ,MaterialDesignDataGridTextColumnEditingStyle#	 [ 5$   )   $ 50Q?5%   )    5!   1   ?? *Name+5%   )     5&      $
 Mã nhân viên??5'   )   # [ 5(   )   #	 [ 5)   )   $	 130Q?5*   )    5&   1   ?? *Name+5*   )     5+      $
 	Họ tên??5,   )   #	 [ 5-   )   $	 130Q?5.   )     5/      $
 
Ngày sinh??50   )   #	 [ 51   )   $	 130Q?52   *     53      $
 Giới tính??54   )   #	 [ 55   )   $	 130Q?56   )     57      $
 Số CMND/CCCD??58   )   #	 [ 59   )   $	 130Q?5:   )     5;      $
 Số điện thoại??5<   )   #	 [ 5=   )   $	 130Q?5>   )     5?      $
 Địa chỉ??5@   )   #	 [ 5A   )   $	 130Q?5B   )   5D      5E      5F      5G      5H      5I      