   M S B A M L   `   `   `  ����Q  MHealthManagementSystem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:HealthManagementSystemHealthManagementSystem  5   	   *    $HealthManagementSystem.PatientDetail   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:HealthManagementSystem     5   	     � Title$  PatientDetail��5   	   $	��450��6   $	��800��6,   .��5	      �  J� RenderTransformOrigin$ 0.487,0.235&�6   .+�5
   
   �� -   5         ��Name$ label��5
      $��Patient Form��6   $��22(�66   $
��Left=�6D   $��	318,0,0,0q�6_   $	��Top=�6r   $ 2.656,-1.793&�6�   ���	#FF30B4EC$	��200��6�   �� 5   
   -   5        $ labelPatientID��5      $��
Patient ID��6(   $��17(�6=   $
��Left=�6K   $��
518,21,0,0q�6f   $	��Top=�6z   $ 2.656,-1.793&�6�   ���	#FF30B4EC$��82��6�   $��31��6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dataGrid��5      $��16(�6&   $
��Left=�64   $��83��6O   $��	36,64,0,0q�6[   $	��Top=�6n   $	��725��6�   $ 0.253,0.131&�6�   �� 5   
   -   5        $ labelSymptoms��5      $��Symptoms��6'   $
��Left=�6:   $��
27,152,0,0q�6U   $	��Top=�6i   ���	#FF30B4EC$��14(�6�   $	��114��6�   $��31��6�   $
��Bold"�6�   �� 5   
   -   5        $ labelDiagnose��5      $��Diagnose��6'   $
��Left=�6:   $��
27,211,0,0q�6U   $	��Top=�6i   ���	#FF30B4EC$
��Bold"�6�   $��14(�6�   $��92��6�   $��31��6�   �� 5   
   -   5         ��Name$ textBoxSymptoms��5      $
��Left=�6+   $��25��6F   $��17(�6R   $��152,158,0,0q�6`    �� TextWrapping$
 Wrap=�6u   $�� ��6�   $	��Top=�6�   $	��379��6�   �� 5   
   -   5         ��Name$ 
buttonSave��5      $
��Save��6%   $��18(�6M   ���	#FF30B4EC$
��Left=�6r   $��216,384,0,0q�6�   $	��Top=�6�   $��96��6�   $��28��6�   �� 5   
   -   5        $ 
buttonback��5      $
��Back��6%   $��18(�6M   ���	#FF30B4EC$
��Left=�6r   $��392,384,0,0q�6�   $	��Top=�6�   $��97��6�   $��28��6�   $ 0.941,0.491&�6�   �� 5   
   -	   5        $ 
textBoxPid��5      $
��Left=�6&   $��25��6A   $��17(�6M   $��
619,27,0,0q�6[   $
 Wrap=�6o   $�� ��6�   $	��Top=�6�   $	��142��6�   6�   �� 5   
   -
   5        $ textBoxDiagnose��5      $
��Left=�6+   $��25��6F   $��17(�6R   $��152,211,0,0q�6`   $
 Wrap=�6u   $�� ��6�   $	��Top=�6�   $	��379��6�   �� 5   
   -   5        $ labelMedication��5      $��
Medication��6)   $
��Left=�6>   $��
27,264,0,0q�6Y   $	��Top=�6m   ���	#FF30B4EC$
��Bold"�6�   $��14(�6�   $��92��6�   $��31��6�   $ 
0.53,2.101&�6�   �� 5   
   -   5        $ textBoxMedication��5      $
��Left=�6-   $��65��6H   $��17(�6T   $��152,264,0,0q�6b   $
 Wrap=�6w   $�� ��6�   $	��Top=�6�   $	��379��6�   �� 5   
   -   5        $ buttonUpdate��5      $��Update��6'   $��18(�6S   ���	#FFDFE95A$
��Left=�6x   $��
67,384,0,0q�6�   $	��Top=�6�   $��96��6�   $��28��6�   �� 5   
   -   5        $ buttonPrescription��5      $��Crate Prescription��6-   $��18(�6l   ���	#FF58A314$
��Left=�6�   $��570,282,0,0q�6�   $	��Top=�6�   $	��173��6�   $��43��6�   5      5      