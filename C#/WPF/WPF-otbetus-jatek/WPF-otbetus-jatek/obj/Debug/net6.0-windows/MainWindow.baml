   M S B A M L   `   `   `  ����L  HWPF-otbetus-jatek, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:WPF_otbetus_jatekWPF_otbetus_jatek  5   	   "    WPF_otbetus_jatek.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:WPF_otbetus_jatek     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � ��5
   
   !� 5       j� Viewbox$ 10,10,2400,1200�6    j� ViewboxUnits$ Absolute=�64    !� Visual 5      �� 5      $��/bg.jpg��6    J� BitmapEffect 5      �� 5       �� Radius$ 25Q�6/   5      5       � RowDefinitions 5   
   �� 5      $��20 �6   �� 5      .+�5   
   o� .@�5      m� $
��File��6   .@�5      m� -   5        $
��Open��5      6)   5      5      �� 5!   
   -   5         ��Name$	 cim��5!      $��20q�6!   $��1��6-   $��0��6:   $��5 betűs játék��6J   
�������$��40(�6v   $	��Top=�6�   $��Center=�6�   $
��Wrap=�6�   $��Impact)�6�    J� Effect 5"      3  -System.Windows.Media.Effects.DropShadowEffect  5#      	   ShadowDepth$	 4Q�6#   
   
BlurRadius$
 5Q�63      Opacity$
 0.75Q�6B      	Direction$	 315Q�6Q   5%      �� 5&   
   -   5        $
 elet��5&      $��0��6"   $��1��62   $��	0,25,65,0q�6?   $��Right=�6R   $	��Top=�6n   $
��Wrap=�6�   $��Élet��6�   
�������$��30(�6�   $��Impact)�6�    5'        5(      $	 4Q�6#   $
 5Q�63   $
 0.75Q�6B   $	 315Q�6Q   5*      �� 5+   
   -   5        $
��Tipp��5+   &   $��0��65   $��1��6E   $��Bottom=�6R   $��Center=�6m   $	��100q�6�   $
��40,5q�6�   $��Impact)�6�   
�������
���/kU�$��25(�6�    � 	Resources 5,       �� 
TargetType �� Property �� Value��%^   '��       �� 5-      " ��6   .�5.      ��  �@��CornerRadius$ 7��65   5/      50       51        52      $	 4Q�6#   $
 5Q�63   $
 0.75Q�6B   $	 315Q�6Q   54      �� 55   
   $��0��6   $��1��6    $��Right=�6-   $	��Top=�6I   $��87��6a   $��	20,10,0,0q�6m   $��69��6�   ��56      �� 57       �� 	UriSource$ 	/elet.png?�6   59      �� 5:   
   -   5         ��Name$ tbinput��5:      $��1��6#   $��0��60   $��Center=�6@   $��Center=�6[    �� TextWrapping$
 Wrap=�6x   $	��250��6�   $��25��6�   $��18(�6�   $��Comic Sans MS)�6�   .��6�    5;        5<      $	 4Q�6#   $
 5Q�63   $
 0.75Q�6B   $	 315Q�6Q   .��5=      5>      �� 5?   
   -   5        $ megoldas��5?      $��1��6&   $��0��63   $��Center=�6C   $��Center=�6^   $
��Wrap=�6{   $��	0,0,0,150q�6�   
�������$��20(�6�   $��Impact)�6�    5@        5A      $	 4Q�6#   $
 5Q�63   $
 0.75Q�6B   $	 315Q�6Q   5C      � 5E   
   -   5         �Name$ gameover��5E      $��Center=�6"   .��5F      �� $��1q�6   ._�5G      �� -   5        $ gameovertext��5G      
���**��
������� �� Padding$ 30q�6\   $��20(�6i   $��Impact)�6w   $
��Wrap=�6�   5H      5I      �� 5K   
   -	   5        $ teszt��5K      $��1��6#   $��0��60   $��Bottom=�6@   $��Center=�6[   $��50q�6x   5M      5N      