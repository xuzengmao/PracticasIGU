   M S B A M L   `   `   `  ����F  BPractica5_1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Practica5_1Practica5_1  5   	       Practica5_1.CambiaColor   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:Practica5_1     5   	   -   5          � Title$  CambiaColor��5	   	   $	��450��6   $	��450��6*   .��5
      �  � RowDefinitions 5   
   �� 5      �� 5      $��4* �6   �� 5      �� 5       � ColumnDefinitions 5   
   �� 5      �� 5      �� 5      .+�5   
   �� $��icon/iconRedCircle.png��6   $��30��60   �� 5   
   $��icon/iconGreenCircle.png��6   $��1��62   $��30��6B   �� 5   
   $��icon/iconBlueCircle.png��6   $��2��61   $��30��6A   �� 5   
   -   5        $��	RedSlider��5       � Maximum$	 255Q�6"    �� TickFrequency$ 5Q�60    �� TickPlacement$
 Both=�6B   $��1��6W    �� Orientation$ Vertical=�6d   $��Center=�6{   $��30��6�   �� 5   
   -   5        $��GreenSlider��5      $	 255Q�6$   $ 5Q�62   $
 Both=�6D   $��1��6Z   $��1��6g   $ Vertical=�6w   $��Center=�6�   $��30��6�   �� 5   
   -   5        $��
BlueSlider��5      $	 255Q�6#   $ 5Q�61   $
 Both=�6C   $��1��6X   $��2��6e   $ Vertical=�6u   $��Center=�6�   $��30��6�   �� 5   
   -   5        $��RedValue��5      $��2��6$   $��Center=�61   $��Center=�6N   ��6i   ��  �� ElementName$ 	RedSlider�� �� Path$ Value��� 5   
   -   5        $��
GreenValue��5      $��2��6&   $��1��63   $��Center=�6C   $��Center=�6`   ��6{   �� $ GreenSlider��$ Value��� 5   
   -   5        $��	BlueValue��5      $��2��6%   $��2��62   $��Center=�6B   $��Center=�6_   ��6z   �� $ 
BlueSlider��$ Value��� 5   
   -   5        $��	OK_Button��5      $��OK��6"   $��3��6/   $��1��6<   $��20q�6L   6X   �� 5    
   -	   5        $��Cancel_Button��5       $��Cancel��6&   $��3��67   $��2��6D   $��20q�6T   6`   5!      5"      