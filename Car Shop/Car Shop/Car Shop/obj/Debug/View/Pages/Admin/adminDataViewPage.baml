   M S B A M L   `   `   `  ����C  ?Car Shop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:Car_Shop.View.Pages.AdminCar_Shop.View.Pages.Admin  5      1    +Car_Shop.View.Pages.Admin.adminDataViewPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      9local'clr-namespace:Car_Shop.View.Pages.Admin     5      -   5          N� Title$  adminDataViewPage��5	      .��5      �  � RowDefinitions 5   
   �� 5      $
��0.2* �6   �� 5      $��* �6   �� 5      $
��0.2* �6   .+�5   
   � $��0��6   .+�5      �� $��Center=�6   $
��Left=�5      $��10q�5      .+�5      �� -   5         ��Name$ backBtn��5      $��
Назад��5      $��15(�5      $	��120��5      $��30��5      5      5      �� 5      $��Center=�6   $��Center=�5       �� Orientation$ 
Horizontal=�5       .+�5!      �� $��Поиск:��6   $��18(�5"      $��SemiBold"�5#      $��80��5$      �� 5%      -   5         ��Name$ 	searchTxb��5%      $��18(�5&      $	��200��5'      5(      5)      � 5+   
   $��1��6    � ColumnDefinitions 5,      �� 5-      $��* �6#   �� 5.      $
��0.2* �6#   .+�51      � $��0��6   .+�52      &   System.Windows.Controls.DataGrid  -   5          Name$ 	dataaView��52         AutoGenerateColumns .     
IsReadOnly . 	   Columns	 53      0  *System.Windows.Controls.DataGridTextColumn  54      ,  &System.Windows.Controls.DataGridColumn
   Header$
 ID��6-      Width5  /System.Windows.Controls.DataGridLengthConverter$
 0.5* 6P   1  +System.Windows.Controls.DataGridBoundColumn   Binding 69   �� *ID+6P     55      $
 Машина��6-   $ * 6Y    6=   �� *	CarName+6Y     56      $
 Модель��6-   $ * 6W    6=   �� *Model+6W     57      $
 
Класс��6-   $ * 6V    6<   �� *Class+6V     58      $
 
Кузов��6-   $ * 6X    6<   �� *	CarBody+6X     59      $
 Год выпуска��6-   $ * 6�    6B   �� *
YearOfProd+ �� StringFormat$ {00:dd MMMM yyy}��6�     5:      $
 Цена��6-   $
 0.5* 6U    6;   �� *Price+6U   5<      5=      � 5?      $��1��6   .+�5@      �� $��Center=�6   $��Center=�5A      $ Vertical=�5B      .+�5C      �� -   5        $ addBtn��5C      $��Добавить��5D      $��15(�5E      $	��130��5F      $��35��5G      $��0,0,0,20q�5H      6/   �� 5I      -   5        $ 	deletVBtn��5I      $��Удалить��5J      $��15(�5K      $	��130��5L      $��35��5M      $��0,0,0,20q�5N      6/   �� 5O      -   5        $ editBtn��5O      $��Изменить��5P      $��15(�5Q      $	��130��5R      $��35��5S      $��0,0,0,20q�5T      6/   �� 5U      -   5        $ infoBtn��5U      $��Подробнее��5V      $��15(�5W      $	��130��5X      $��35��5Y      $��0,0,0,20q�5Z      6/   5[      5\      5]      � 5_   
   $��2��6   .+�5`      �� 5b      5c      5d      5e      