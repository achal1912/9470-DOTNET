   M S B A M L   `   `   `  ����  WpfApplication1     WpfApplication1.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$1  +Consume WCF REST To Perform CRUD Operations��5   	   $	��471��6=   $	��625��6J   .��5      � $��0,0,-67,-31q�6    � ColumnDefinitions 5   
   �� 5      �� 5      $	��37* �6   .+�5
   
   �� $��Employee Id��6   $
��Left=�6&   $��	36,36,0,0q�6A   $	��Top=�6T   $	��120��6l   $��1��6x   �� 5   
   -   5        $��txtEmpId��5   �   $
��Left=�6   $��23��6-   $��
187,36,0,0q�69    �� TextWrapping$
 Wrap=�6M   $	��Top=�6a   $	��120��6y   $��1��6�   6�   �� 5   
   -   5        $#��Click To View Employee Detail��5      $
��Left=�69   $��
329,36,0,0q�6T   $	��Top=�6h   $	��194��6�   $��1��6�   6�   �� 5   
   $��Employee ID��6   $
��Left=�6&   $��35.632,87,0,0q�6A   $	��Top=�6X   $��1��6p   �� 5   
   $
��Name��6   $
��Left=�6   $��35.632,135,0,0q�6:   $	��Top=�6R   $��1��6j   �� 5   
   $��Joining Date��6   $
��Left=�6'   $��35.632,191,0,0q�6B   $	��Top=�6Z   $��1��6r   �� 5   
   $��Company Name��6   $
��Left=�6'   $��35.632,239,0,0q�6B   $	��Top=�6Z   $��1��6r   �� 5   
   $��Address��6   $
��Left=�6"   $��35.632,290,0,0q�6=   $	��Top=�6U   $��1��6m   �� 5   
   -   5        $��txtShowEmpId��5   �   $
��Left=�6   $��23��6-   $��
187,87,0,0q�69   $
 Wrap=�6M   $	��Top=�6b   $	��120��6z   $��1��6�   6�   �� 5   
   -   5        $��txtShowEmpName��5   �   $
��Left=�6   $��23��6-   $��187,135,0,0q�69   $
 Wrap=�6N   $	��Top=�6b   $	��187��6z   $��1��6�   6�   �� 5   
   -   5        $��txtShowEmpJoiningDate��5   �   $
��Left=�6   $��23��6-   $��187,195,0,0q�69   $
 Wrap=�6N   $	��Top=�6b   $	��187��6z   $��1��6�   6�   �� 5   
   -   5        $��txtShowCompany��5   �   $
��Left=�6   $��23��6-   $��187,243,0,0q�69   $
 Wrap=�6N   $	��Top=�6b   $	��187��6z   $��1��6�   6�   �� 5   
   -   5        $��txtShowAddress��5   �   $
��Left=�6   $��44��6-   $��187,290,0,0q�69   $
 Wrap=�6N   $	��Top=�6b   $	��187��6z   $��1��6�   6�   �� 5   
   -   5        $��Add New Employee��5      $��1��6,   $
��Left=�6<   $��
50,379,0,0q�6W   $	��Top=�6k   $	��120��6�   $��48��6�   6�   �� 5   
   -	   5        $��Update Employee��5      $��1��6+   $
��Left=�6;   $��205,379,0,0q�6V   $	��Top=�6k   $	��120��6�   $��48��6�   6�   �� 5   
   -
   5        $��Delete Employee��5      $��1��6+   $
��Left=�6;   $��361,379,0,0q�6V   $	��Top=�6k   $	��120��6�   $��48��6�   6�   5      5      