   M S B A M L   `   `   `  ����M  IMining Application, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullDclr-namespace:Mining_Application.View.Pages.Admin.Functions_for_data6Mining_Application.View.Pages.Admin.Functions_for_data  5      E    ?Mining_Application.View.Pages.Admin.Functions_for_data.infoPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      VlocalDclr-namespace:Mining_Application.View.Pages.Admin.Functions_for_data     5      -   5          N� Title$  infoPage��5	      .��5      �  � RowDefinitions 5   
   �� 5      $
��0.2* �6   �� 5      $��* �6   �� 5      $
��0.2* �6   .+�5   
   � $��0��6   .+�5      �� $��Center=�6   $��Center=�5       �� Orientation$ 
Horizontal=�5      .+�5      �� $��Поиск:��6   $��18(�5      $��SemiBold"�5      $��70��5      �� 5      -   5         ��Name$ 	searchTxb��5      $��15(�5      $	��200��5      5      5      � 5    
   $��1��6   .+�5!      &   System.Windows.Controls.DataGrid  -   5          Name$ infoDataView��5!         AutoGenerateColumns .     
IsReadOnly .    Columns 5"      0  *System.Windows.Controls.DataGridTextColumn  5#      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6)   	   Width5  /System.Windows.Controls.DataGridLengthConverter$	 * 6R   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 65   �� *
Field.ID+6R     5$      $ Запасы��6)   $	 * 6Z   
 69   �� *Field.Stocks+6Z     5%      $' !Способ разработки��6)   $	 * 6h   
 6D   �� *Field.DevMethod+6h     5&      $! Годовая добыча��6)   $	 * 6f   
 6A   �� *Field.AnnualProd+6f     5'      $4 .Себестоимость за единицу��6)   $	 * 6q   
 6K   �� *Field.CostForUnit+6q     5(      $ Пункт вывоза��6)   $	 * 6]   
 6?   �� *	PointName+6]     5)      $1 +Пропускная способность��6)   $	 * 6f   
 6I   �� *
Capacity+6f   5+      5,      � 5.   
   $��2��6   .+�5/      �� $��Center=�6   $��Center=�50      .+�51      �� -   5         ��Name$ backBtn��51      $��
Назад��52      $��15(�53      $��35��54      $	��120��55      6%   56      57      58      59      