   M S B A M L   `   `   `  ����I  EWebCVCollector, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:WebCVCollector.FormsWebCVCollector.Forms  5   	   %    WebCVCollector.Forms.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:WebCVCollector.Forms     5   	   -   5          � Title$  CV Collector��5   	   $	��222��6   $	��540��6+    � 
ResizeMode$ NoResize=�67   .��5	      � .+�5
   
   �� -   5         ��Name$ 
CollectBtn��5
      $��Collect CVs��6%   $
��Left=�6;   $��55��6V   $��	10,10,0,0q�6b   $	��Top=�6u   $	��200��6�   6�   �� 5   
   -   5        $ 	SearchBtn��5      $��Search��6$   $
��Left=�65   $��
317,10,0,0q�6P   $	��Top=�6d   $	��200��6|   $��55��6�   6�   �� 5   
   -   5         ��Name$ 	textBlock��5      $
��Left=�6'   $	��114��6B   $��	10,70,0,0q�6O   $
��Wrap=�6b   $	��Top=�6v   $	��200��6�   �� 6�   $8�2Collect CVs from E1 site and store it in local DB.��6�   �� 6�   �� 6�   $D�>Uses Selenium and Chrome browser to opening and parsing pages.��6�   64  �� 5   
   -   5        $ 
textBlock1��5      $
��Left=�6(   $	��114��6C   $��
317,70,0,0q�6P   $
��Wrap=�6d   $	��Top=�6x   $	��200��6�   �� 6�   $!�Search for CVs in local DB.��6�   �� 6�   �� 6�   $�Uses SQL server.��6�   6�   �� 5   
   -   5         ��Name$ 	initLabel��5      $'��!Db initialization. Please wait...��6#   $
��Left=�6O   $	��194��6j   $	��Top=�6w   $	��534��6�   
�������6�   5      5      