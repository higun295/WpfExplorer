   M S B A M L   `   `   `  ����N  JWpfExplorer.Support, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullxOclr-namespace:WpfExplorer.Support.Local.Converters;assembly=WpfExplorer.Support$WpfExplorer.Support.Local.Converters  5      H DJamesnet.Wpf, Version=1.0.0.33, Culture=neutral, PublicKeyToken=nullS9clr-namespace:Jamesnet.Wpf.Controls;assembly=Jamesnet.WpfJamesnet.Wpf.Controls 5      K GWpfExplorer.Main, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:WpfExplorer.Main.UI.UnitsWpfExplorer.Main.UI.Units 5      W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089.   (WpfExplorer.Main.UI.Units.FolderTreeItem  �� 
TargetType �� Property �� Value �� Mode �� 
TargetType �� Padding%  Jamesnet.Wpf.Controls.JamesGridK GWpfAutoGrid.Core, Version=1.5.1.0, Culture=neutral, PublicKeyToken=null  WpfAutoGrid.AutoGrid   Columns   Rows ��Name	 �� 	Converter9   3WpfExplorer.Support.Local.Converters.DepthConverter,  &WpfExplorer.Main.UI.Units.ExpandButton
  Name d� 	IsChecked%  Jamesnet.Wpf.Controls.JamesIcon  Name   Fill   Icon ��Name ��Name �� Triggers �� Value �� Binding �� 
TargetName P� Property P� Value �� ElementName �� Path ^� 
Conditions �� Binding �� Value�� 5      F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     :x,http://schemas.microsoft.com/winfx/2006/xaml     5      YcnvtsOclr-namespace:WpfExplorer.Support.Local.Converters;assembly=WpfExplorer.Support  5      Cjames9clr-namespace:Jamesnet.Wpf.Controls;assembly=Jamesnet.Wpf  5      1units'clr-namespace:WpfExplorer.Main.UI.Units  5      %�	  '         �� 5      "    6   .�5   
   ��  �@��AlternationCount$ 2��6-   �� 5	   
    � ��
 ���� 6'   �� 5
   
    � �� �#FFFFFF6'   �� 5   
    �@Q�
IsExpanded 6'   �� *IsFolderExpanded+$ TwoWay=��� 5   
    �@Q�
IsSelected 6'   �� *IsFolderSelected+�� 5   
    � �� 6(   �� *
Children+�� 5   
    �@J�SnapsToDevicePixels$
 True��60   �� 5   
    �@�UseLayoutRounding$
 True��6.   �� 5   
    � �� 5      �� 5      "   6"   .R�5      �� $ 0 0 0 0q�6   ._�5        $ *��6*   $ 
Auto, Auto��5   *   .+�5      �� $
 item��6%   #��z��5   %   ���#313131$��0 0 0 0q�5   %    5   %   �� *Depth+	   ._�5   "     $��0 4 0 4q�62   $ Auto, Auto, *��5   2   $ *��5   2   .+�5   &     $
 expand��69   #��z��5   9    5    9   �� *IsFolderExpanded+$ OneWay=�  5!   &   $
 icon��66   $��16��5"   6   $��16��5#   6   $��4 2 4 2q�5$   6   # z��5%   6    5&   6   �� *
IconType+�� 5'   &   $
 text��60   $��0 0 30 0q�5(   0   $��Center=�5)   0   #��z��5*   0   $��CharacterEllipsis=�5,   0   ��5+   0   �� *Name+5,   0   5-   #   5.      �� 5/      $ items��6-   $��1��50   -   $y�	Collapsed=�51   -   52      53       54      �� 55      $ Folder��56   &    55   &   �� *
IconType+.a�57      �� $
 icon��6%    �@ Fill$ 	#FFEFB13A��6G   �� 58       � �� �#3131316;   59      �� 5:      $
 True��5;   &    5:   &   �� *
IsDenied+.a�5<      �� $
 icon��6%    �@J�Opacity$	 0.3Q�6J   �� 5=      $
 text��6%    �@J�Opacity$	 0.3Q�6J   5>      P� 5?       �@Q�
IsExpanded$
 True��68   . �5@      �� $ items��6%    � y�$ Visible=�6N   5A      �� 5B      $
 True��5C   &    5B   &   �� $ expand��$ 	IsChecked�.a�5D      �� $ items��6%    � y�$ Visible=�6N   5E      �� 5F      $ False��5G   &    5F   &   �� $ expand��$ 	IsChecked�.a�5H      �� $ items��6%    � y�$ 	Collapsed=�6N   5I      P� 5J       �@Q�
IsSelected$
 True��68   . �5K      ��  � �� �	#FFE262856;   5L      ^� 5M       5N      �� 5O   "    6,   �� *
IconType+
 Folder6I   �� 5P   "    6,   �� *IsFolderExpanded+ True6Q   .0�5R      �� $
 icon��6%    �@ Icon$ 
FolderOpen=�6G   5S      5U      5W      5X      5Y      