   M S B A M L   `   `   `  ����I  EPraktikaVolkov, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:PraktikaVolkov.PagesPraktikaVolkov.Pages  5      )    #PraktikaVolkov.Pages.AcceptancePage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:PraktikaVolkov.Pages     5      -   5          N� 
Background
  ����� N� Title$ AcceptancePage��5	      .��5      �  � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��50 �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ AcceptanceBD��5      $��Stretch=�6)      AutoGenerateColumns .     
IsReadOnly . $��
Constantia)�6|   $��14(�6�   ���	#FFFFFEDC   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Код принятия��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6;   �� *IdAcceptance+  5      $ Дата принятия��6%    6<   �� *DateAcceptance+	 �� StringFormat$	 {0:dd.MM.yyyy}��  5      $! Код сотрудника��6%    6=   �� *
IdEmployee+  5      $ Код должности��6%    6<   �� *IdPost+  5      $' !Код подразделения��6%    6@   �� *IdDepartment+4  .System.Windows.Controls.DataGridTemplateColumn  5      
   CellTemplate
 5      �� 5      .R�5      ��  ��Name$ editbtn��6s   -   5        $��Изменить��5   %   $��5q�68   $	��150��6C   $��20��6O   $��
Constantia)�6[   $��14(�6�   5      5      5      �� 5    
    �� Orientation$ 
Horizontal=�6   $��1��6.   
�������.+�5!      �� -   5        $ addbtn��5!      $��Добавить��6%   $��5q�68   $��30��6C   $	��150��6O   $��
Constantia)�6p   $��14(�6�   ���	#FFFFFEDC6�   �� 5"      -   5        $ delbtn��5"      $��Удалить��6%   $��5q�67   $��30��6B   $	��150��6N   $��
Constantia)�6o   $��14(�6�   ���	#FFFFFEDC6�   �� 5#      -   5        $ 	updatebtn��5#      $��
Отчет��6(   $��5q�68   $��30��6C   $	��150��6O   $��
Constantia)�6s   $��14(�6�   ���	#FFFFFEDC6�   �� 5$      -   5        $ filter��5$      $��Фильтрация��6%   $��5q�6:   $��30��6E   $	��150��6Q   $��
Constantia)�6r   $��14(�6�   ���	#FFFFFEDC6�   �� 5%      -   5        $ backbtn��5%      $��
Назад��6&   $��5q�66   $��30��6A   $	��150��6M   $��
Constantia)�6o   $��14(�6�   ���	#FFFFFEDC6�   5&      5'      5(      