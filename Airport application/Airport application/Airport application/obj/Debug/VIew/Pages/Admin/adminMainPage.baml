   M S B A M L   `   `   `  ����N  JAirport application, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null[2clr-namespace:Airport_application.VIew.Pages.Admin$Airport_application.VIew.Pages.Admin  5      8    2Airport_application.VIew.Pages.Admin.adminMainPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Dlocal2clr-namespace:Airport_application.VIew.Pages.Admin     5      b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5
      -   5          N� Title$  adminMainPage��5	         MaterialDesignBody#���   5      $��Regular"�5      $��13(�5      &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignBackground N� 
Background# �  5        MaterialDesignFont N� 
FontFamily# �  5      .��5      � .+�5   
   �� $��/View/img/allBg.jpg��6   $
��Fill=�6-   � 5   	    � RowDefinitions 5      �� 5      $��0.25* �6    �� 5      $��* �6    �� 5      $��0.25* �6    .+�5      � $��0��6   .+�5      �� $��Center=�6!   $��Center=�5   !    �� Orientation$ 
Horizontal=�5    !   $��20q�5!   !   .+�5"      �� $��Поиск:��6$   $��18(�5#   $   $��SemiBold"�5$   $   $��70��5%   $   
�������5&   $   �� 5'      -   5         ��Name$ 	searchTxb��5'   "   $��16(�5(   "   $	��300��5)   "   
�������
�������5+   6   5,      5-      � 5/      $��1��6   .+�50      &   System.Windows.Controls.DataGrid  -   5          Name$ datavIew��50      	   AutoGenerateColumns	 .  
   
IsReadOnly
 . 
�������
���   �   Columns 51      0  *System.Windows.Controls.DataGridTextColumn  52      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��61      Width5  /System.Windows.Controls.DataGridLengthConverter$
 0.3* 6T      
Foreground
 �����1  +System.Windows.Controls.DataGridBoundColumn   Binding 6=   �� *ID+6a     53      $! Номер маршрута��61   $ * 6i    6I   �� *RouteNumber+6i     54      $ Пункт вылета��61   $ * 6d    6G   �� *
DepPoint+6d     55      $! Пункт прибытия��61   $ * 6f    6I   �� *
ArrPoint+6f     56      $ Дистанция��61   $ * 6a    6D   �� *
Distance+6a     57      $) #Дата и время вылета��61   $ * 6�    6N   �� *PlaneParameters.DepDateTime+ �� StringFormat$ {00:dd MMMM yyy}��6�     58      $- 'Дата и время прибытия��61   $ * 6�    6P   �� *PlaneParameters.ArrDateTime+$ {00:dd MMMM yyy}��6�     59      $< 6Количество проданных билетов��61   $ * 6�    6W   �� *PlaneParameters.Tickets+6�   5;      5<      � 5>      $��2��6   .+�5?      �� $��Center=�6!   $��Center=�5@   !   $ 
Horizontal=�5A   !   .+�5B      �� -   5         ��Name$ addBtn��5B   !   $��Добавить��5C   !   
���   �
���   �
�������$	��120��5G   !   $��35��5H   !   $��0,0,20,0q�5I   !   63   �� 5J      -   5        $ editBtn��5J   !   $��Изменить��5K   !   
���   �
���   �
�������$	��120��5O   !   $��35��5P   !   $��0,0,20,0q�5Q   !   63   �� 5R      -   5        $ 	deleteBtn��5R   !   $��Удалить��5S   !   
���   �
���   �
�������$	��120��5W   !   $��35��5X   !   $��0,0,20,0q�5Y   !   63   �� 5Z      -   5        $ infoBtn��5Z   !   $��Подробнее��5[   !   
���   �
���   �
�������$	��120��5_   !   $��35��5`   !   $��0,0,20,0q�5a   !   63   �� 5b      -   5        $ pdfBtn��5b      $	��PDF��5c   !   
���   �
���   �
�������$	��120��5g   !   $��35��5h   !   6-   5i      5j      5k      5l      5m      