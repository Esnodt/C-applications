   M S B A M L   `   `   `  ����M  IMining Application, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullY1clr-namespace:Mining_Application.View.Pages.Admin#Mining_Application.View.Pages.Admin  5      ;    5Mining_Application.View.Pages.Admin.adminDataViewPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Clocal1clr-namespace:Mining_Application.View.Pages.Admin     5      -   5          N� Title$  adminDataViewPage��5	      .��5      �  � RowDefinitions 5   
   �� 5      $
��0.3* �6   �� 5      $��* �6   �� 5      $
��0.2* �6   .+�5   
   � $��0��6   .+�5      �� $��Center=�6   $
��Left=�5       �� Orientation$ 
Horizontal=�5      $��20q�5      .+�5      �� -   5         ��Name$ backBtn��5      $��
Назад��5      $��15(�5      $��30��5      $	��120��5      $��0,0,20,0q�5      5      �� 5      $ 
Horizontal=�6   .+�5      �� $��Поиск:��6    $��18(�5        $��SemiBold"�5!       $��70��5"       �� 5#      -   5         ��Name$ 	searchTxb��5#      $��15)�5$      $	��200��5%      6*   5&      5'      �� 5(      $��Center=�6   $��Right=�5)      $ Vertical=�5*      $��20q�5+      .+�5,      �� $ 
Horizontal=�6   $��0,0,0,10q�5-      .+�5.      �� $#��Выборка по типу:��6    $��13(�5/       $	��190��50       �� 51      -   5         ��Name$ 	typeCheck��52      $#��Твердое топливо��51      54      55      �� 56      $ 
Horizontal=�6   $��0,0,0,10q�57      .+�58      �� $5��/Выборка по месторождению:��6    $��13(�59       $	��190��5:       �� 5;      -   5        $ 
fieldCheck��5<      $��Эльдорадо��5;      5>      5?      �� 5@      $ 
Horizontal=�6   .+�5A      �� $6��0Непотребяемые ископаемые:��6    $��13(�5B       $	��190��5C       �� 5D      -   5        $ 	dontCheck��5D      5F      5G      5H      5I      � 5K   
   $��1��6   .+�5L      &   System.Windows.Controls.DataGrid  -   5          Name$ dataView��5L         AutoGenerateColumns .     
IsReadOnly . 	   Columns	 5M      0  *System.Windows.Controls.DataGridTextColumn  5N      ,  &System.Windows.Controls.DataGridColumn
   Header$
 ID��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$
 0.3* 6R   1  +System.Windows.Controls.DataGridBoundColumn   Binding 65   �� *
Field.ID+6R     5O      $+
 %Полезное ископаемое��6)   $ * 6t    6F   �� *Field.Mineral.MineralName+6t     5P      $'
 !Единица измерения��6)   $ * 6w    6D   �� * Field.Mineral.MineralUnit.Unit+6w     5Q      $+
 %Годовая потребность��6)   $ * 6u    6F   �� *Field.Mineral.AnnualOfYear+6u     5R      $"
 Цена за единицу��6)   $ * 6q    6B   �� *Field.Mineral.PriceForUnit+6q     5S      $
 Тип��6)   $
 0.5* 6i    66   �� * Field.Mineral.MineralType.Type+6i     5T      $1
 +Название месторождения��6)   $ * 6m    6I   �� *Field.FieldName+6m   5V      5W      � 5Y   
   $��2��6   .+�5Z      �� $��Center=�6   $��Center=�5[      $ 
Horizontal=�5\      .+�5]      �� -   5        $ addBtn��5]      $��Добавить��5^      $��15(�5_      $��35��5`      $	��120��5a      $��0,0,20,0q�5b      5c      �� 5d      -	   5        $ editBtn��5d      $��Изменить��5e      $��15(�5f      $��35��5g      $	��120��5h      $��0,0,20,0q�5i      5j      �� 5k      -
   5        $ 	deleteBtn��5k      $��Удалить��5l      $��15(�5m      $��35��5n      $	��120��5o      $��0,0,20,0q�5p      5q      �� 5r      -   5        $ infoBtn��5r      $��Подробнее��5s      $��15(�5t      $��35��5u      $	��120��5v      5w      5x      5y      5z      5{      