   M S B A M L   `   `   `  ����L  HGames application, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullW0clr-namespace:Games_application.View.Pages.Admin"Games_application.View.Pages.Admin  5      6    0Games_application.View.Pages.Admin.adminManePage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Blocal0clr-namespace:Games_application.View.Pages.Admin     5      -   5          N� Title$  adminManePage��5	       � 	Resources 5       �� 
TargetType �� Property �� Value��%�   '��       �� 5   
   " ��6   .�5      ��  � ��
 �   �6;   �� 5       � ��
 �   �6<   �� 5       � ��
 �����6;   �� 5       � ��$	 130��6&   64   �� 5       � ��$ 40��6'   64   5      5      .��5      � .+�5   
   � .+�5      �� $��/img/witcheBg.jpg��6   $
��Fill=�6/   5      � 5   
    � RowDefinitions 5      �� 5      $��* �6    �� 5      $
��0.2* �6    .+�5       � $��0��6   .+�5!      �� -   5         ��Name$ listDataView��5!      
������ 
���   ���5"      �� 5#      .R�5$      �  � ColumnDefinitions 5%   "   �� 5&   &   $��* �67   �� 5'   &   $��* �67   .+�5*   "   � $��0��6'   $��0,0,40,0q�5+   '   .+�5,   &   �� $	��200��6,   $	��200��5-   ,   ��5.   ,   �� *	GameImg+5/   #   � 51   "   $��1��6'   .+�52   &   �� $��Center=�61   $
��Left=�53   1    �� Orientation$ Vertical=�54   1   .+�55   *   �� 	 �� ContentStringFormat$	 Название: {0}��6M   $��17(�6q   
�������$��0,0,0,15q�6�   ��60   �� *
GameName+6�   �� 56   *   $/	 )Дата выпуска: {0:dd MMMM yyyy}��6]   $��17(�6�   
�������$��0,0,0,15q�6�   ��60   �� *AddParameters.YearOfProd+6�   �� 57   *   $	 Цена: {0:C}��6J   $��17(�6l   
�������$��0,0,0,15q�6�   ��60   �� *Price+6�   �� 58   *   $	 Категория: {0}��6a   $��17(�6�   
���������60   �� *AddParameters.Category.Title+6�   59   '   5:   #   5;      5<      5>      5?      � 5A      $��1��6   .+�5B      �� $��Center=�6   $��Center=�5C      $ 
Horizontal=�5D      .+�5E      �� -   5        
addBtn��$��Добавить��5F      $��0,0,20,0q�5G       5H      ��%^   '��       �� 5I      " ��6$   .�5J   "   ��  �@��CornerRadius$ 5��6A   5K      5L      5M      �� 5N      -   5        
 ��Name$
 editBtn��5N      $��Изменить��5O      $��0,0,20,0q�5P       5R      ��%^   '��       �� 5S      " ��6$   .�5T   "   ��  �@��CornerRadius$ 5��6A   5U      5V      5W      �� 5X      -   5        $
 	deleteBtn��5X      $��Удалить��5Y      $��0,0,20,0q�5Z       5\      ��%^   '��       �� 5]      " ��6$   .�5^   "   ��  �@��CornerRadius$ 5��6A   5_      5`      5a      �� 5b      -   5        $
 pdfBtn��5b      $	��PDF��5c       5e      ��%^   '��       �� 5f      " ��6$   .�5g   "   ��  �@��CornerRadius$ 5��6A   5h      5i      5j      5k      5l      5m      5n      5o      