   M S B A M L   `   `   `  ����Q  MHealthManagementSystem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:HealthManagementSystemHealthManagementSystem  5   	   *    $HealthManagementSystem.Employee_List   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:HealthManagementSystem     5   	     � Title$  Employee_List��5   	   $	��450��6   $	��800��6,   .��5	      � $	��422��6   $	��Top=�6   .+�5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dataGridEmployeeList��5
      $
��Left=�61   $	��317��6L   $��	10,42,0,0q�6Y   $	��Top=�6l   $	��775��6�   $��2q�6�   �� 5   
   -   5         ��Name$ textBoxEmployeeSearch��5      $
��Left=�62   $��18(�6M   $��24��6[   $��	635,6,0,0q�6g    �� TextWrapping$
 Wrap=�6z   $�� ��6�   $	��Top=�6�   $	��136��6�   6�   �� 5   
   -   5         ��Name$ image��5      $
��Left=�6   $����E:\University\8th Semester\Visiual Programing Language\Project\HealthManagementSystem\HealthManagementSystem\images\icons8-google-web-search-512.png��6:   $��37��6�   $��	597,0,0,0q�6�   $	��Top=�6�   $��50��6  �� 5   
   -   5         ��Name$ buttonShowAllEmployee��5      $��20(�60   $��Employee List��6b   $
��Left=�6z   $��
13,371,0,0q�6�   $	��Top=�6�   $	��179��6�   $��42��6�   ���	#FF50B589$��2,2,2,1q�6�   �� 5   
   -   5        $ buttonUpdate��5      $��Update��6B   $��20(�6S   $
��Left=�6a   $��280,371,0,0q�6|   $	��Top=�6�   $	��147��6�   $��42��6�   
�������$��2q�6�   $
��Bold"�6�   ���	#FF8E902F J� RenderTransformOrigin$ 0.003,0.381&�6  �� 5   
   -   5        $ buttonDelete��5      $��Delete��6B   $��20(�6S   $
��Left=�6a   $��458,370,0,10q�6|   $	��147��6�   
�������$��2q�6�   ���	#FFF31313$
��Bold"�6�   �� 5   
   -   5        $ 
buttonback��5      $
��Back��6>   $��20(�6M   $
��Left=�6[   $��634,370,0,10q�6v   $	��147��6�   
�������$��2q�6�   ���	#FF121010$
��Bold"�6�   $ 1.221,0.071&�6�   �� 5   
   -   5        $ imageUpdate��5      $���~E:\University\8th Semester\Visiual Programing Language\Project\HealthManagementSystem\HealthManagementSystem\images\arrows.png��6%   $
��Left=�6�   $��50��6�   $��388,373,0,-1q�6�   $	��Top=�6�   $��37��6  �� 5   
   -	   5        $ imagedelete��5      $����E:\University\8th Semester\Visiual Programing Language\Project\HealthManagementSystem\HealthManagementSystem\images\interface.png��6%   $
��Left=�6�   $��36��6�   $��563,372,0,0q�6�   $	��Top=�6�   $��42��6  �� 5   
   -
   5        $ 	imageback��5      $���|E:\University\8th Semester\Visiual Programing Language\Project\HealthManagementSystem\HealthManagementSystem\images\back.png��6#   $
��Left=�6�   $��29��6�   $��735,375,0,0q�6�   $	��Top=�6�   $��42��6�   5      5      