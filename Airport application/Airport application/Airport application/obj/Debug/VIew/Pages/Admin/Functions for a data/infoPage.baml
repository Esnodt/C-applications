   M S B A M L   `   `   `  ����N  JAirport application, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null�Gclr-namespace:Airport_application.VIew.Pages.Admin.Functions_for_a_data9Airport_application.VIew.Pages.Admin.Functions_for_a_data  5      H    BAirport_application.VIew.Pages.Admin.Functions_for_a_data.infoPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      YlocalGclr-namespace:Airport_application.VIew.Pages.Admin.Functions_for_a_data     5      b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5
      -   5          N� Title$  infoPage��5	         MaterialDesignBody#���   5      $��Regular"�5      $��13(�5      &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignPaper N� 
Background# �  5        MaterialDesignFont N� 
FontFamily# �  5      .��5      � .+�5   
   �� $��/View/img/allBg.jpg��6   $
��Fill=�6-   � 5   
    � RowDefinitions 5      �� 5      $��* �6    �� 5      $
��0.2* �6    .+�5      � $��0��6   .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ dataView��5         AutoGenerateColumns .     
IsReadOnly . 
���   �	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn
   Header$
 ID��6-      Width5  /System.Windows.Controls.DataGridLengthConverter$
 0.3* 6P   1  +System.Windows.Controls.DataGridBoundColumn   Binding 69   �� *ID+6P     5       $!
 Номер самолета��6-   $ * 6k    6E   �� *Plane.PlaneNumber+6k     5!      $
 Тип��6-   $ * 6Y    6:   �� *
Plane.Type+6Y     5"      $#
 Количество мест��6-   $ * 6n    6F   �� *Plane.NumberOfPlace+6n     5#      $6
 0Количество свободных мест��6-   $ * 6�    6P   �� *Plane.Passengers.PassNumber+6�   5%      5&      � 5(      $��1��6   .+�5)      �� $��Center=�6   $��Center=�5*      .+�5+      �� -   5         ��Name$ backBtn��5+      $��
Назад��5,      $��16(�5-      $	��120��5.      $��35��5/      
���   �
���   �
�������53      54      55      56      57      58      