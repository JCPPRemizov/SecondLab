   M S B A M L   `   `   `  ����C  ?FirstLab, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:SecondLab	SecondLab  5   	       SecondLab.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:SecondLab     5   	   -   5          � Title$  
MainWindow��5   	   $	��424��6   $	��524��6)   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $	��78* �6   �� 5      $
��107* �6   �� 5      $	��77* �6    � RowDefinitions 5   
   �� 5      $
��167* �6   �� 5      $	��37* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ MainDataGrid��5      $��10,10,10,10q�6)   $��3��6>   5      �� 5   
   -   5         ��Name$ 
NextButton��5      $)��#Следующая страница��6%   $��
4,14,10,14q�6B   $��1��6o   $��2��6|   �� 5   
   -   5        $ ReturnButton��5      $��
Назад��6'   $��
10,14,6,14q�67   $��1��6K   6X   �� 5   
   -   5        $ CreateButton��5      $!��Создать запись��6'   $��1��6@   $��1��6h   $��	0,14,0,14q�6x   5      5      