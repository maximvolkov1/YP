   M S B A M L   `   `   `  ����I  EPraktikaVolkov, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:PraktikaVolkov.PagesPraktikaVolkov.Pages  5      /    )PraktikaVolkov.Pages.AddStaffingTablePage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:PraktikaVolkov.Pages     5        N� 
Background
  ����� N� Title$ AddStaffingTablePage��5	      .��5      � .+�5   
   �� ���	#FFFFFEDC6   �� 5   
   $
��Left=�6   $	��Top=�60   $	��210��6I   $��52��6U   $��
402,51,0,0q�6a   .+�5      �� $'��!Код подразделения��6   $��5q�61   $��Center=�6<   $��Center=�6Y   $��14(�6t   $��
Constantia)�6�   �� 5      -   5        $��textb1��5   N   $��5q�67   $��15��6B   ��6   �� *IdStaffingTable+6N   5      �� 5   
   $
��Left=�6   $	��Top=�60   $	��210��6I   $��402,108,0,0q�6U   $��52��6j   .+�5      �� $'��!Код подразделения��6   $��5q�61   $��Center=�6<   $��Center=�6Y   $��14(�6t   $��
Constantia)�6�   �� 5      -   5        $��Depacbx��5   R   $��5q�6;   $��19��6F    �� DisplayMemberPath$ IdDepartment��6a    �� SelectedItem 6   �� *
Department+6a   5      �� 5   
   $
��Left=�6   $	��Top=�60   $	��210��6I   $��52��6V   $��402,165,0,0q�6b   .+�5      �� $��Код должности��6   $��5q�6-   $��Center=�68   $��Center=�6U   $��14(�6p   $��
Constantia)�6~   �� 5      -   5        $��Postcbx��5   L   $��5q�65   $��19��6@   $ IdPost��6[    6   �� *Post+6[   5      �� 5   
   $
��Left=�6   $	��Top=�60   $	��210��6I   $��52��6U   $��402,226,0,0q�6a   .+�5      �� $1��+Количество сотрудников��6   $��5q�66   $��Center=�6A   $��Center=�6^   $��14(�6y   $��
Constantia)�6�   �� 5      -   5        $��text2��5   P   $��5q�69   $��15��6D   ��6   �� *NumberOfEmployees+6P   5      �� 5   
   $
��Left=�6   $	��Top=�60   $	��210��6I   $��402,279,0,0q�6U   $��52��6j   .+�5      �� -   5         ��Name$ Savebtn��5      $��Сохранить��6&   $	��200��6;   $��
Constantia)�6]   $��14(�6u   $��Center=�6�   $��Center=�6�   $��5q�6�   
�������6�   �� 5      -   5        $ Backbtn��5      $��Отменить��6&   $	��200��6;   $��
Constantia)�6_   $��14(�6w   
�������6�   5       5!      5"      