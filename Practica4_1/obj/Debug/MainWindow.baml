   M S B A M L   `   `   `  ����F  BPractica4_1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Practica4_1Practica4_1  5   	       Practica4_1.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:Practica4_1     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      �� 5      $
��Auto �6    � ColumnDefinitions 5   
   �� 5      �� 5      �� 5      .+�5   
   �� -   5        $��caja1��5      $��10q�6   �� 5   
   -   5        $��caja2��5      $��10q�6   $��1��6+   �� 5   
   -   5        $��AÑADIR��5      $��10q�6"   $��2��6.   6>   �� 5   
   -   5        $��lista��5      $��10q�6    $��1��6,   $��3��69    �� View 5      �� 5      .P�5      �� $��NOMBRE��6%    �� DisplayMemberBinding 65   �� *nombre+�� 5      $��APELLIDO��6%    67   �� *apell+�� 5      $
��EDAD��6%    63   �� *edad+5      5      �� 5    
   -   5        $��
cajasalida��5       $��10q�6"   $��2��6.   $��3��6;   
������6O   5!      5"      