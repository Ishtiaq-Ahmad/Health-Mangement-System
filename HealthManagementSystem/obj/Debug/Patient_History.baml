   M S B A M L   `   `   `  ����Q  MHealthManagementSystem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:HealthManagementSystemHealthManagementSystem  5   	   ,    &HealthManagementSystem.Patient_History   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:HealthManagementSystem     5   	     � Title$  Patient List��5      $	��450��6   $	��800��6*   .��5	      � $	��422��6   $	��Top=�6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dataGridPatientList��5      $
��Left=�60   $	��237��6K   $��223,130,0,0q�6X   $	��Top=�6m   $	��558��6�   $��2q�6�   ���	#FFBFB7B76�   �� 5   
   -   5         ��Name$ textBoxEmployeeSearch��5      $
��Left=�62   $��18(�6M   $��24��6[   $��
604,94,0,0q�6g    �� TextWrapping$
 Wrap=�6{   $�� ��6�   $	��Top=�6�   $	��169��6�   6�   �� 5   
   -   5         ��Name$ image��5      $
��Left=�6   $����E:\University\8th Semester\Visiual Programing Language\Project\HealthManagementSystem\HealthManagementSystem\images\icons8-google-web-search-512.png��6:   $��37��6�   $��
566,88,0,0q�6�   $	��Top=�6�   $��50��6  �� 5   
   -   5         ��Name$ buttonShowAllEmployee��5      $��20(�60   $��Patient List��6c   $
��Left=�6z   $��
10,130,0,0q�6�   $	��Top=�6�   $	��190��6�   $��42��6�   ���	#FF50B589$��2,2,2,1q�6�    J� RenderTransformOrigin$ 1.006,1.097&�6
  �� 5   
   -   5        $ 
buttonback��5      $
��Back��6&   $��20(�6N   $
��Left=�6\   $��673,378,0,8q�6w   $	��104��6�   $��2q�6�   ���	#FF121010$
��Bold"�6�   $ 1.221,0.071&�6�   ��5      �� 5       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5      � 	 � Color$	 Black��6#   
 � Offset$
 0Q�61   � 5      $	 	#FFFEFFFD��6#   $
 1Q�65   � 5      $	 	#FFD0D1CF��6#   $
 0.255Q�65   5      5      �� 5   
   -   5        $ 	imageback��5      $���|E:\University\8th Semester\Visiual Programing Language\Project\HealthManagementSystem\HealthManagementSystem\images\back.png��6#   $
��Left=�6�   $��34��6�   $��749,384,0,0q�6�   $	��Top=�6�   $��24��6�   �� 5   
   -   5         ��Name$ label��5      $ ��Hospital Management System��6   $
��Left=�6D   $��
223,10,0,0q�6_   $	��Top=�6s   $��Script MT Bold)�6�   $��36(�6�   $
��Bold"�6�   ���	#FF0F9B7E6�   �� 5   
   -   5        $ image1��5      $����E:\University\8th Semester\Visiual Programing Language\Project\HealthManagementSystem\HealthManagementSystem\images\iconfinder_Nurse-1_379345.png��6    $
��Left=�6�   $��81��6�   $��	133,1,0,0q�6�   $	��Top=�6�   $	��135��6  �� 5   
   -	   5        $ buttonAddPatient��5      $��20(�6+   $��Add Patient��6X   $
��Left=�6n   $��
10,177,0,0q�6�   $	��Top=�6�   $	��190��6�   $��42��6�   ���	#FF50B589$��2,2,2,1q�6�   $ 1.006,1.097&�6�   �� 5   
   -
   5        $ buttonManagepatient��5      $��20(�6.   $��Manage Patient��6_   $
��Left=�6x   $��
10,224,0,0q�6�   $	��Top=�6�   $	��190��6�   $��42��6�   ���	#FF50B589$��2,2,2,1q�6�   $ 1.006,1.097&�6  �� 5   
   -   5        $ buttonSurgicalPatient��5      $��20(�60   $��Surgical Patient��6b   $
��Left=�6}   $��
10,271,0,0q�6�   $	��Top=�6�   $	��190��6�   $��42��6�   ���	#FF50B589$��2,2,2,1q�6�   $ 1.006,1.097&�6  �� 5   
   -   5        $ buttonSurgicalPatientList��5      $��20(�64   $��Surgical Patient List��6j   $
��Left=�6�   $��
10,325,0,0q�6�   $	��Top=�6�   $	��190��6�   $��42��6�   ���	#FF50B589$��2,2,2,1q�6   $ 1.006,1.097&�6  5      5       