   M S B A M L   `   `   `  ����I  ECardCollection, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:CardCollection.ControlsCardCollection.Controls  5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0896   0CardCollection.Controls.NavigationMultiConverter   navigationMultiConverter  �� 
TargetType �� Property �� Value$   CardCollection.Controls.Wizard �� 
TargetType � ColumnDefinitions � RowDefinitions ��Name �� 
ResourceId �� TypeInTargetAssembly	 ��Name
 �� TemplatedParent �� RelativeSource �� Path   
ActivePage ��Name �� Orientation `� 	Converter �� Triggers P� 
SourceName P� Property P� Value �� 
TargetName�� 5      D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    :x,http://schemas.microsoft.com/winfx/2006/xaml     5      2Controls%clr-namespace:CardCollection.Controls  5      %�  &	        (��      5       *.,Controls:Wizard.HeaderPanelBorderResourceKey+)(�� �     5       *20Controls:Wizard.SideHeaderPanelBorderResourceKey+)(�� �    5       */-Controls:Wizard.ContentPanelBorderResourceKey+)(�� �    5       *20Controls:Wizard.NavigationPanelBorderResourceKey+)(�� �    5        *-+Controls:Wizard.NavigationButtonResourceKey+)'      7   7      5      6(   �� 5      "  ��6   .�5	   
   ��  � �� �#FFFFFF6'   �� 5
   
    � �� �#A0A0A06(   �� 5   
    � ��$ 0,0,0,1q�6,   �� 5   
    �@��Padding$ 5q�6$   5      �� 5      "  ��6   .�5   
   ��  � �� �#FFFFFF6'   �� 5   
    � �� �#A0A0A06(   �� 5   
    � ��$ 0,0,1,0q�6,   5      �� 5      "  ��6   .�5   
   ��  � �� �#FFFFFF6'   5      �� 5      "  ��6   .�5   
   ��  � �� �#F0F0F06'   �� 5   
    � �� �#A0A0A06(   �� 5   
    � ��$ 0,1,0,0q�6,   �� 5   
    �@��Padding$ 7q�6$   5      �� 5       "  ��6   .�5!   
   ��  � ��$ 76��6"   �� 5"   
    � ��$ 24��6#   5#      �� 5%      "   6   .�5&   
   ��  � �� �#F0F0F06'   �� 5'   
    � �� �#A0A0A06(   �� 5(   
    � ��$ 1q�6,   �� 5)   
    � �� 5*      �� 5+      "  6"   .R�5,      �� #��z��6   #��z��5-      #��z��5.      ._�5/      �  51      �� 52   "   $
��Auto �63   �� 53   "   $��* �63    56      �� 57   "   $
��Auto �60   �� 58   "   $��* �60   �� 59   "   $
��Auto �60   .+�5=      �� $ HeaderBorder��6%   $��0��6;   $��1��6H   $��1��6X   ��5>   %   C� *�� $" HeaderPanelBorderResourceKey��"  +._�5?   "   �� $	 HeaderPresenter��61   ��6J   �� # Z
 $ ActivePage.Header�5@      �� 5C      $ SideHeaderBorder��6%   $��0��6?   $��2��6L   $��0��6]   ��5D   %   C� *�� $&  SideHeaderPanelBorderResourceKey��"  +._�5E   "   �� $	 SideHeaderPresenter��61   ��6N   �� # Z
 $ ActivePage.SideHeader�5F      �� 5I      $��1��6%   $��1��62   ��5J   %   C� *�� $# ContentPanelBorderResourceKey��"  +._�5K   "   �� #��z 61   #��z��5L   1   5M      �� 5P      $��2��6%   $��2��62   ��6F   C� *�� $&  NavigationPanelBorderResourceKey��"  +._�5Q   "   � .+�5R   &   �� $ 	PART_Help��6-   $
��Left=�6@   $
��Help��6[   ��5S   )   C� *�� $! NavigationButtonResourceKey��"  +{�5T   )   �� # Z
 $ ActivePage.CanHelp�6�   �� 5V   &   $��26��61   $ 
Horizontal=�6=   $��Right=�6V   .+�5W   *   �� $ PART_Cancel��61   $��Cancel��6F   $��0,0,7,0q�6W   ��5X   -   C� *�� $! NavigationButtonResourceKey��"  +{�5Y   -   �� # Z
 $ ActivePage.CanCancel�6�   �� 5Z   *   $ PART_Previous��61   $��Previous��6H   ��6[   C� *�� $! NavigationButtonResourceKey��"  +{�5[   .   `� 5\   2   8   .1�5]   6   �� # Z
 6>   $$ ActivePage.CanNavigatePrevious�6y   �� 5^   6   # Z
 6>   $ ActivePage.CanPrevious�6y   5_   3   5a   +   �� 5b   *   $ 	PART_Next��61   $
��Next��6D   ��6S   C� *�� $! NavigationButtonResourceKey��"  +{�5c   .   `� 5d   2   8  .1�5e   6   �� # Z
 6>   $  ActivePage.CanNavigateNext�6y   �� 5f   6   # Z
 6>   $ ActivePage.CanNext�6y   5g   3   5i   +   �� 5j   *   $ PART_Finish��61   $��Finish��6F   $��7,0,0,0q�6W   ��5k   -   C� *�� $! NavigationButtonResourceKey��"  +{�5l   -   �� # Z
 $ ActivePage.CanFinish�6�   5m   '   5n   #   5o      5p      5q       5s      P� 5t      $ SideHeaderPresenter��6"    � �� .  . �5u      �� $ SideHeaderBorder��6%    � y�$ 	Collapsed=�6Y   5v      P� 5w      $ HeaderPresenter��6"    � �� .  . �5x      �� $ HeaderBorder��6%    � y�$ 	Collapsed=�6U   5y      5{      5}      5~      5�      