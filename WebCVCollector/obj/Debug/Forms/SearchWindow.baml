   M S B A M L   `   `   `  ����I  EWebCVCollector, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:WebCVCollector.FormsWebCVCollector.Forms  5   	   A%clr-namespace:WebCVCollector.ControlsWebCVCollector.Controls  5   	   > :DAL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null4%clr-namespace:DAL.Models;assembly=DAL
DAL.Models 5   	   O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5	   	   '    !WebCVCollector.Forms.SearchWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:WebCVCollector.Forms     5   	   5loc%clr-namespace:WebCVCollector.Controls     5   	   4lo%clr-namespace:DAL.Models;assembly=DAL     5   	   6sys&clr-namespace:System;assembly=mscorlib     5	   	   -   5          � Title$  Search��5   	   $	��700��6   $	��800��6%    � 
ResizeMode$ NoResize=�61    � WindowStartupLocation$ CenterScreen=�6G    � Topmost .  � ShowInTaskbar .   � 	Resources 5         dataFromEnum S� 
MethodName S� 
ObjectType  System.Enum S� MethodParameters	 M� TypeName��%w   &	        S� 5   
   $ 	GetValues��62   "  5       5      M� 5      $	 lo:ExpAmount��6   5      5      .��5      � 
 � ColumnDefinitions
 5   
   �� 5      .+�5   
   �� -   5         ��Name$ label��5      $��Search string:��6   $
��Left=�68   $��	10,10,0,0q�6S   $	��Top=�6f   �� 5   
   -   5        $ label2��5      $��Expirience:��6    $
��Left=�66   $��
469,50,0,0q�6Q   $	��Top=�6e   $��67��6}   �� 5   
   -   5         ��Name$ SearchStringTextBox��5      $
��Left=�6/   $��23��6J   $��	96,13,0,0q�6V    �� TextWrapping$
 Wrap=�6i   $	��Top=�6}   $	��568��6�    � ForceCursor . 6�   �� 5   
   -   5         ��Name$ 	SearchBtn��5       �� 	IsDefault . $��Search��65   $
��Left=�6F   $��23��6a   $��
676,14,0,0q�6m   $	��Top=�6�   $��86��6�   6�   �� 5   
   -   5        $ SalaryTextBox��5      $
��Left=�6)   $��23��6D   $��	10,48,0,0q�6P   $
 Wrap=�6c   $	��Top=�6w   $	��120��6�   {�6�   ��  �� ElementName$ salaryCheckBox�� �� Path$ 	IsChecked��� 5   
   -   5         ��Name$ expComboBox��5      $
��Left=�6(   $��
541,50,0,0q�6C   $	��Top=�6W   $	��123��6o   .@�5       ��  �� 
IsSelected . 
 � Tag$ -1��6-   $��Doesn't matter��66   6Q   �� 5!      $ 0��6   $��Without expirience��6#   6B   �� 5"      $ 1��6   $��Less than 1 year��6#   6@   �� 5#      $ 2��6   $��	1-3 years��6#   69   �� 5$      $ 3��6   $��	3-5 years��6#   69   �� 5%      $ 4��6   $��More than 5 years��6#   6A   5&      �� 5'   
   -   5         ��Name$ 
cvsListBox��5'      $
��Left=�6&   $	��576��6A   $��	10,77,0,0q�6N   $	��Top=�6a   $	��761��6y   $��Disabled=�6�   $��Visible=�6�   ��5(      �� 5)      .R�5*      .   (WebCVCollector.Controls.CVPreviewControl  5,      5-      5/      �� 50   
   -	   5        $ ageMinTextBox��50      $
��Left=�6)   $��23��6D   $��
226,49,0,0q�6P   $
 Wrap=�6d   $	��Top=�6x   $��40��6�   {�6�   �� $ ageMinCheckBox��$ 	IsChecked��� 51   
   -
   5        $ ageMaxTextBox��51      $
��Left=�6)   $��23��6D   $��
347,48,0,0q�6P   $
 Wrap=�6d   $	��Top=�6x   $��40��6�   {�6�   �� $ ageMaxCheckBox��$ 	IsChecked��� 52   
   -   5         ��Name$ salaryCheckBox��52      $��
Max salary��6+   $
��Left=�6@   $��
135,55,0,0q�6[   $	��Top=�6o    J� RenderTransformOrigin$ 2.692,0.846&�6�   $��16��6�   6�   �� 53   
   -   5        $ ageMinCheckBox��53      $��Min age��6+   $
��Left=�6=   $��
271,55,0,0q�6X   $	��Top=�6l   $ 2.692,0.846&�6�   $��16��6�   6�   �� 54   
   -   5        $ ageMaxCheckBox��54      $��Max age��6+   $
��Left=�6=   $��
392,55,0,0q�6X   $	��Top=�6l   $ 2.692,0.846&�6�   $��16��6�   6�   �� 55   
   -   5        $ 
totalLabel��55      $�� ��6$   $
��Left=�6/   $��
669,35,0,0q�6J   $	��Top=�6^   $	��102��6v   �� 56   
   -   5        $ resultLabel��56      $�� ��6%   $
��Left=�60   $��
669,53,0,0q�6K   $	��Top=�6_   $	��102��6w   58      5:      