   M S B A M L   `   `   `  ����A  =Pilske, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:PilskePilske  5   	       Pilske.Hapjes   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:Pilske     5   	     � Title$  Hapjes��5   	   $	��450��6   $	��800��6%   .��5	      � .+�5
   
   �� -   5         ��Name$ txtHapje��5
      $
��Left=�6$   $��23��6?   $��
545,26,0,0q�6K    �� TextWrapping$
 Wrap=�6_   $	��Top=�6s   $	��120��6�    J� RenderTransformOrigin$ 0.082,-0.009&�6�   �� 5   
   $
��Left=�6   $��
480,33,0,0q�6/   $
��Wrap=�6C   $��Hapje��6W   $	��Top=�6d   $��35��6|   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dgHapjes��5      $
��Left=�6%   $	��240��6@   $��480,155,0,0q�6M   $	��Top=�6b   $	��245��6z      AutoGenerateColumns .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$	 Hid��6>   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *hid+6>     5      $ Hapje��6@    6%   �� *hapje1+6@   4  .System.Windows.Controls.DataGridTemplateColumn  5      	   CellTemplate	 5      �� 5      .R�5      �� .+�5   "   �� 
 ��Name$
 	btnDelete��6)   -   5        $��Delete��5   <   6M   5      5      5        5      	 5      �� 5      .R�5      �� $
 	btnWijzig��6%   -   5        $��Wijzig��5   8   6I   5      5         5!      	 5"      �� 5#      .R�5$      �� $
 btnDoorvoeren��6%   -   5        $��Bestel��5$   <   6M   5%      5'      5)        5*   
   -   5        $ dgBestelling��5*      $
��Left=�6)   $	��240��6D   $��
55,155,0,0q�6Q   $	��Top=�6e   $	��310��6}    .   5+        5,      $	 Hid��6D    6%   �� *	hapje.hid+6D     5-      $ Hapje��6F    6%   �� *hapje.hapje1+6F     5.      $ bestelId��6B    6%   �� *
bestelid+6B     5/      $ BestellingsDatum��6J    6%   �� *bestellingsDatum+6J   53      �� 54   
   -   5        $
 BtnOpslaanH��54      $$��Opslaan Hapje                 ��6&   $
��Left=�55      $��
590,90,0,0q�6.   $	��Top=�6B   $��95��6Z   $��25��6e   6q   �� 56   
   -   5        $
 btnPopulariteitH��56      $��Populariteit Hapjes��6+   $
��Left=�6I   $��220,105,0,0q�6d   $	��Top=�6y   $	��115��6�   $��30��6�   6�   58      59      