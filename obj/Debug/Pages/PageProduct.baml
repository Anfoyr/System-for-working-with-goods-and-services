   M S B A M L   `   `   `  ����B  >WpfApp4, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:WpfApp4.PagesWpfApp4.Pages  5          WpfApp4.Pages.PageProduct   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -localclr-namespace:WpfApp4.Pages     5        N� Title$  PageProduct��5	      .��5      � .+�5   
   �� $��
Найти��6   �� 5   
   .��5      ��  �� Orientation$ Vertical=�6   .+�5      �� -   5        $��	TxtSearch��5      $	��700��6+   $��25��67   $��5q�6C   �� 5      -   5        $��ListProduct��5      
������ $	��650��6F   
������ ��5      �� 5      .R�5      �� 
���   � 
  LblRed#��[  6>   
�������$	��600��6q    � 	Resources 5   "    �� 
TargetType �� Triggers �� Binding �� Value �� Property �� Value��%�   &	        �� 5   &   " ��6,    5   *   �� 5   .    6:   �� *Product.IsActive+ 06_   .a�5   2   ��  � ��
 �  ��6O   5   /   5   '   5   #   .��5   "   �� $ Vertical=�6-   .+�5   &   �� $��StringImage��60   $y�Hidden=�6C   ��5   0   �� *MainImagePath+	 �� StringFormat$	 ..//{0}���� 5    &     	ImgSource#��[ 5!   )   ��5    ,   �� *Text+
 �� ElementName$
 StringImage��5!   )   �� 5"   &   $��TxtNameProduct��5#   0     	prdctTxtb#��[ 5$   0   ��5"   0   �� *Title+5$   0   �� 5%   &   $ 
Horizontal=�61   .+�5&   *   �� #��[ 6J   ��64   �� *Cost+6J   �� 5'   *   $�� рублей��64   #��[ 5(   4   5)   '   �� 5+   &   $ 
Horizontal=�61   $
��Left=�6J   .+�5,   *   �� $��BtnEdit��61   -   5          mainBtn#��[ 5-   1   $ ��Редактировать��5/   1   �� 50   *   $��BtnSalehistory��61   -   5        #��[ 51   1   $!��История продаж��53   1   54   '   55   #   56      57      59      5:      5;      �� 5=   
   $��Bottom=�6   $	��150��60   .+�5>      �� $ 
Horizontal=�6   $��5q�62   .+�5?      	� -   5        $
��RbUp��5A      $!��По возрастанию��5B      	� 5C      -   5        $��RbDown��5E      $��По убыванию��5F      5G      &   System.Windows.Controls.DataGrid  5I      -   5        $��gridListProduct��5I         
IsReadOnly .    AutoGenerateColumns .     Columns 5J      0  *System.Windows.Controls.DataGridTextColumn  5K      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ * 5L         Header$) #Название продукции��5N      1  +System.Windows.Controls.DataGridBoundColumn   Binding 5M      �� *Title+5N        5O      $ * 5P      $) #Название продукции��5Q       5R      �� *Cost+  5S      $ * 5T      $ Описание��5V       5U      �� *Description+5V        5W      $ * 5X      $ В наличии��5Z       5Y      �� *
IsActive+5Z        5[      $ * 5\      $ Компания��5^       5]      �� *ManufacturerID+5^      5`      5a      5b      5c      