   M S B A M L   `   `   `  ���� I  EWebCVCollector, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:WebCVCollector.FormsWebCVCollector.Forms  %    WebCVCollector.Forms.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     4local"clr-namespace:WebCVCollector.Forms     -     � Title$  CV Collector��$	��222��$	��540�� � 
ResizeMode$ NoResize=�.��� .+��� -    ��Name$ 
CollectBtn��$��Collect CVs��$
��Left=�$��55��$��	10,10,0,0q�$	��Top=�$	��200���� -   $ 	SearchBtn��$��Search��$
��Left=�$��
317,10,0,0q�$	��Top=�$	��200��$��55���� -    ��Name$ 	textBlock��$
��Left=�$	��114��$��	10,70,0,0q�$
��Wrap=�$	��Top=�$	��200���� $8�2Collect CVs from E1 site and store it in local DB.���� �� $D�>Uses Selenium and Chrome browser to opening and parsing pages.���� -   $ 
textBlock1��$
��Left=�$	��114��$��
317,70,0,0q�$
��Wrap=�$	��Top=�$	��200���� $!�Search for CVs in local DB.���� �� $�Uses SQL server.���� -    ��Name$ 	initLabel��$'��!Db initialization. Please wait...��$
��Left=�$	��194��$	��Top=�$	��534��
�������