   M S B A M L   `   `   `  ����I  EPraktikaVolkov, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:PraktikaVolkov.PagesPraktikaVolkov.Pages  5      +    %PraktikaVolkov.Pages.CalculationsPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:PraktikaVolkov.Pages     5        N� Title$  CalculationsPage��5	      .��5      �  � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��50 �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ 
EmployeeBD��5      $��Stretch=�6'      AutoGenerateColumns .     
IsReadOnly . ���	#FFFFFEDC$��
Constantia)�6�   $��14(�6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$! Код сотрудника��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6>   �� *
IdEmployee+  5      $ ФИО��6%    62   �� *FIO+  5      $ Дата рождения��6%    6<   �� *	BirthDate+ �� StringFormat$ {0:dd.MM.yyyy}��  5      $ Пол��6%    62   �� *Gender+  5      $ 
Адрес��6%    64   �� *Addres+  5      $ Телефон��6%    66   �� *Phone+  5      $ Образование��6%    6:   �� *	Education+  5      $ Код должности��6%    6<   �� *IdPost+  5      $' !Код подразделения��6%    6@   �� *IdDepartment+  5      $2 ,Код штатного расписания��6%    6F   �� *IdStaffingTable+  5      $ Дата принятия��6%    6<   �� *DateAcceptence+$ {0:dd.MM.yyyy}��  5      $# Дата увольнения��6%    6>   �� *DateDismissal+$ {0:dd.MM.yyyy}��  5      $% Дата перемещения��6%    6?   �� *
DateMoving+$ {0:dd.MM.yyyy}��  5      $ 
Оклад��6%    64   �� *Salary+  5       $L FКоличество отработанных дней за месяц��6%    6T   �� *
DaysWorked+  5!      $" Итого к выплате��6%    6>   �� *
Tobepaid+5#      �� 5$   
   	 �� Orientation$	 
Horizontal=�6   $��1��6.   
�������.+�5%      �� -   5        
 ��Name$
 backbtn��5%      $��
Назад��6&   $��30��66   $	��130��6B   ���	#FFFFFEDC$��
Constantia)�6{   $��14(�6�   $��5q�6�   5&      5'      5(      