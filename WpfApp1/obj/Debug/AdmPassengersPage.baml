   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5          WpfApp1.AdmPassengersPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      'localclr-namespace:WpfApp1     5        N� Title$  AdmPassengersPage��5	      .��5      � 
������� � RowDefinitions 5   
   �� 5      $	��10* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6    � ColumnDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5      .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ 	datagrid1��5      $��0��6&   $��5��63   �� 5   
   -   5         ��Name$
 txt1��5      $��2��6    $��1��6-   $��3��6=   �� 5    
   -   5        $
 txt2��5       $��3��6    $��1��6-   $��3��6=   �� 5!   
   -   5        $
 txt3��5!      $��4��6    $��1��6-   $��3��6=   �� 5"   
   -   5        $
 txt4��5"      $��5��6    $��1��6-   $��3��6=   �� 5#   
   -   5         ��Name$ back_button��5#      $��
Назад��6&   $��7��66   6C   �� 5$   
   -   5        $ 
add_button��5$      $��Добавить��6%   $��7��68   $��1��6E   6U   �� 5%   
   -   5        $ edit_button��5%      $��Изменить��6&   $��7��69   $��2��6F   6V   �� 5&   
   -	   5        $ delete_button��5&      $��Удалить��6(   $��7��6:   $��3��6G   6W   5'      5(      