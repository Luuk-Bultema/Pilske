   M S B A M L   `   `   `  ����A  =Pilske, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:PilskePilske  5   	       Pilske.Bieren   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:Pilske     5   	     � Title$  Bieren��5   	   $	��450��6   $	��800��6%   .��5	      � .+�5
   
   �� -   5         ��Name$ txtBier��5
      $
��Left=�6#   $��23��6>   $��
545,26,0,0q�6J    �� TextWrapping$
 Wrap=�6^   $	��Top=�6r   $	��120��6�    J� RenderTransformOrigin$ 0.082,-0.009&�6�   �� 5   
   $
��Left=�6   $��
480,33,0,0q�6/   $
��Wrap=�6C   $
��Bier��6W   $	��Top=�6c   �� 5   
   -   5         ��Name$ btnOpslaanB��5      $#��Opslaan Bier                 ��6&   $
��Left=�5      $��620,111,0,0q�6.   $	��Top=�6C   $��75��6[   6f   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dgBier��5      $
��Left=�6#   $	��240��6>   $��480,155,0,0q�6K   $	��Top=�6`   $	��245��6x      AutoGenerateColumns .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$	 Bid��6>   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6%   �� *bid+6>     5      $
 Bier��6>   	 6%   �� *bier+6>   4  .System.Windows.Controls.DataGridTemplateColumn  5      
   CellTemplate
 5      �� 5      .R�5      �� .+�5   "   �� $ 
btnDeleteB��6)   -   5        $��Delete��5   =   6N   5      5      5        5      
 5      �� 5      .R�5      �� $ 
btnWijzigB��6%   -   5        $��Wijzig��5   9   6J   5       5"        5#      
 5$      �� 5%      .R�5&      �� $ btnDoorvoerenB��6%   -   5        $��Bestel��5&   =   6N   5'      5)      5+        5,   
   -   5        $ dgBestelling��5,      $
��Left=�6)   $	��240��6D   $��
55,155,0,0q�6Q   $	��Top=�6e   $	��310��6}    .   5-        5.      $	 Bid��6E   	 6%   �� *
bieren.bid+6E     5/      $
 Bier��6E   	 6%   �� *bieren.bier+6E     50      $ bestelId��6B   	 6%   �� *
bestelid+6B     51      $ BestellingsDatum��6J   	 6%   �� *bestellingsDatum+6J   55      �� 56   
   -   5        $ btnPopulair��56      $��Populariteit bieren��6&   $
��Left=�6D   $��
225,92,0,0q�6_   $	��Top=�6s   $	��110��6�   $��29��6�   58      59      