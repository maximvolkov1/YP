   M S B A M L   `   `   `  ����O  Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem  5      I EPraktikaVolkov, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:PraktikaVolkov.PagesPraktikaVolkov.Pages 5      +   %PraktikaVolkov.Pages.AddDismissalPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      6sys&clr-namespace:System;assembly=mscorlib     5      4local"clr-namespace:PraktikaVolkov.Pages     5        N� 
Background
  ����� N� Title$ AddDismissalPage��5
      .��5      � .+�5   
   �� ���	#FFFFFEDC6   �� 5   
   $��Center=�6   $	��Top=�62   $	��210��6K   $��52��6X   .+�5      �� $!��Код увольнения��6   $��5q�6.   $��Center=�69   $��Center=�6V   $��14(�6q   $��
Constantia)�6   �� 5      -   5        $��textb1��5   J   $��5q�63   $��19��6>   ��6   �� *IdDismissal+6J   5      �� 5   
   $��Center=�6   $	��Top=�62   $	��210��6K   $��0,54,0,0q�6W   $��57��6i   .+�5      �� $#��Дата увольнения��6   $��5q�6/   $��Center=�6:   $��Center=�6W   $��14(�6r   $��
Constantia)�6�   (  "System.Windows.Controls.DatePicker  5      -   5        $��
datepicker��5   �   $��5q�6W   $��24��6b   
 �� Now   SelectedDate# Z 6n      Text 6   �� *DateDismissal+ �� StringFormat$ {0:dd.MM.yyyy}��6�   5      �� 5   
   $��Center=�6   $	��Top=�62   $	��210��6K   $��52��6X   $��	0,120,0,0q�6d   .+�5      �� $!��Код сотрудника��6   $��5q�6.   $��Center=�69   $��Center=�6V   $��14(�6q   $��
Constantia)�6   �� 5      -   5        $��Empcbx��5   P   $��5q�69   $��19��6D    �� DisplayMemberPath$ 
IdEmployee��6^    �� SelectedItem 6   �� *
Employee+6^   5      �� 5   
   $��Center=�6   $	��Top=�62   $	��210��6K   $��52��6W   $��	0,181,0,0q�6c   .+�5      �� $��Код должности��6   $��5q�6-   $��Center=�68   $��Center=�6U   $��14(�6p   $��
Constantia)�6~   �� 5      -   5        $��Postcbx��5   L   $��5q�65   $��19��6@   $ IdPost��6[    6   �� *Post+6[   5      �� 5   
   $��Center=�6   $	��Top=�62   $	��210��6K   $	��108��6W   $��	0,303,0,0q�6d   .+�5      �� $)��#Причина увольнения��6   $��5q�62   $��Center=�6=   $��Center=�6Z   $��14(�6u   $��
Constantia)�6�   �� 5       -   5        $��	Reasoncbx��5    /   $��5q�6   $��19��6#   6/   �� 5!      -   5         ��Name$ Savebtn��5!      $��Сохранить��6&   $	��200��6;   $��
Constantia)�6]   $��14(�6u   
�������$��20��6�   $��5q�6�   �� 5"      -   5        $ Backbtn��5"      $��Отменить��6&   $	��200��6;   $��
Constantia)�6_   $��14(�6w   
�������$��20��6�   5#      �� 5$   
   $��Center=�6   $	��Top=�62   $	��210��6K   $��53��6W   $��	0,242,0,0q�6c   .+�5%      �� $'��!Код подразделения��6   $��5q�61   $��Center=�6<   $��Center=�6Y   $��14(�6t   $��
Constantia)�6�   �� 5&      -   5        $��Depacbx��5&   R   $��5q�6;   $��19��6F   $ IdDepartment��6a    6   �� *
Department+6a   5'      5(      5)      