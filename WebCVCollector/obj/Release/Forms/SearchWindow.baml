   M S B A M L   `   `   `  ���� I  EWebCVCollector, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:WebCVCollector.FormsWebCVCollector.Forms  A%clr-namespace:WebCVCollector.ControlsWebCVCollector.Controls  > :DAL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null4%clr-namespace:DAL.Models;assembly=DAL
DAL.Models O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem '    !WebCVCollector.Forms.SearchWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     4local"clr-namespace:WebCVCollector.Forms     5loc%clr-namespace:WebCVCollector.Controls     4lo%clr-namespace:DAL.Models;assembly=DAL     6sys&clr-namespace:System;assembly=mscorlib     -     � Title$  Search��$	��700��$	��800�� � 
ResizeMode$ NoResize=� � WindowStartupLocation$ CenterScreen=� � Topmost .  � ShowInTaskbar .   � 	Resources    dataFromEnum S� 
MethodName S� 
ObjectType  System.Enum S� MethodParameters	 M� TypeName��%@   &	        S� $ 	GetValues��"   M� $	 lo:ExpAmount��.��� 
 � ColumnDefinitions
 �� .+��� -    ��Name$ label��$��Search string:��$
��Left=�$��	10,10,0,0q�$	��Top=��� -   $ label2��$��Expirience:��$
��Left=�$��
469,50,0,0q�$	��Top=�$��67���� -    ��Name$ SearchStringTextBox��$
��Left=�$��23��$��	96,13,0,0q� �� TextWrapping$
 Wrap=�$	��Top=�$	��568�� � ForceCursor . �� -    ��Name$ 	SearchBtn�� �� 	IsDefault . $��Search��$
��Left=�$��23��$��
676,14,0,0q�$	��Top=�$��86���� -   $ SalaryTextBox��$
��Left=�$��23��$��	10,48,0,0q�$
 Wrap=�$	��Top=�$	��120��{���  �� ElementName$ salaryCheckBox�� �� Path$ 	IsChecked��� -    ��Name$ expComboBox��$
��Left=�$��
541,50,0,0q�$	��Top=�$	��123��.@���  �� 
IsSelected . 
 � Tag$ -1��$��Doesn't matter���� $ 0��$��Without expirience���� $ 1��$��Less than 1 year���� $ 2��$��	1-3 years���� $ 3��$��	3-5 years���� $ 4��$��More than 5 years���� -    ��Name$ 
cvsListBox��$
��Left=�$	��576��$��	10,77,0,0q�$	��Top=�$	��761��$��Disabled=�$��Visible=����� .R�.   (WebCVCollector.Controls.CVPreviewControl  �� -	   $ ageMinTextBox��$
��Left=�$��23��$��
226,49,0,0q�$
 Wrap=�$	��Top=�$��40��{��� $ ageMinCheckBox��$ 	IsChecked��� -
   $ ageMaxTextBox��$
��Left=�$��23��$��
347,48,0,0q�$
 Wrap=�$	��Top=�$��40��{��� $ ageMaxCheckBox��$ 	IsChecked��� -    ��Name$ salaryCheckBox��$��
Max salary��$
��Left=�$��
135,55,0,0q�$	��Top=� J� RenderTransformOrigin$ 2.692,0.846&�$��16���� -   $ ageMinCheckBox��$��Min age��$
��Left=�$��
271,55,0,0q�$	��Top=�$ 2.692,0.846&�$��16���� -   $ ageMaxCheckBox��$��Max age��$
��Left=�$��
392,55,0,0q�$	��Top=�$ 2.692,0.846&�$��16���� -   $ 
totalLabel��$�� ��$
��Left=�$��
669,35,0,0q�$	��Top=�$	��102���� -   $ resultLabel��$�� ��$
��Left=�$��
669,53,0,0q�$	��Top=�$	��102��