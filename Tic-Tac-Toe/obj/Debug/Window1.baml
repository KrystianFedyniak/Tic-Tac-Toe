   M S B A M L   `   `   `  ����F  BTic-Tac-Toe, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Tic_Tac_ToeTic_Tac_Toe  5   	       Tic_Tac_Toe.Window1   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:Tic_Tac_Toe     5   	     � Title$  About��5   	    � 
ResizeMode$ CanMinimize=�6    � ShowInTaskbar .   � WindowStartupLocation$ CenterScreen=�6F   $��359.333��6k   $	��558��6|   .��5	      � -   5        ��5
   
   �� 5       �� EndPoint$ 0.5,1&�6"    � MappingMode$ RelativeToBoundingBox=�63    �� 
StartPoint$ 0.5,0&�6W   .��5      �  � Color$ 	#FF086997��6    � Offset$ 0.423Q�61   � 5      $ 	#FF0A0036��6   $ 1Q�61   5      	 � RowDefinitions	 5   
   �� 5      $	��82* �6   �� 5      $	��77* �6   �� 5      $	��84* �6   �� 5      $	��83* �6   
 � ColumnDefinitions
 5   
   �� 5      $	��73* �6   �� 5      $
��107* �6   .+�5   
   �� -   5         ��Name$ 	LabelName��5      $
��Name��6#   $��1��62   $
��Left=�6B   $��	25,16,0,0q�6]   $	��Top=�6p   $��56��6�   $	��256��6�   $��24(�6�   $
��Bold"�6�   �� 5   
   -   5        $ LabelVersion��5      $��Version��6&   $��1��68   $
��Left=�6H   $��	25,10,0,0q�6c   $	��Top=�6v   $��57��6�   $	��256��6�   $��24(�6�   $
��Bold"�6�   $��1��6�   �� 5   
   -   5        $ LabelCreator��5      $��Creator��6&   $��1��68   $
��Left=�6H   $��	25,10,0,0q�6c   $	��Top=�6v   $��64��6�   $	��293��6�   $��20(�6�   $��2��6�   $
��Bold"�6�   �� 5   
   -   5         ��Name$ 
AboutImage��5      $
��Left=�6$   $	��243��6?   $��3��6L   $	��Top=�6]   $	��224��6u   $��Resources/tic1.png��6�   $
��Fill=�6�   6�   �� 5   
   -   5         ��Name$ CloseButton��5      $��Close��6&   $
��Left=�66   $��3��6Q   $	��Top=�6^   $	��552��6v   $��83��6�   $��2��6�   $��30(�6�   $
��Bold"�6�   
���  ��$��0,1,0,-1q�6�   ��5      �� 5       5"      5$      5%      