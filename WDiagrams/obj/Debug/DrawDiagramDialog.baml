   M S B A M L   `   `   `  ����D  @WDiagrams, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:WDiagrams	WDiagrams  5      !    WDiagrams.DrawDiagramDialog   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      )localclr-namespace:WDiagrams     5        � Title$
  Draw��5      .��5
      �  � ColumnDefinitions 5   
   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��5* �6   �� 5      $��2* �6    � RowDefinitions 5   
   �� 5      $��1* �6   �� 5      $��3* �6   .+�5   
   �� -   5         ��Name$ TitleListBox��5       �� 
IsReadOnly . $��0��5      $��0��6"   $��4��6/   $��20(�5      $��5q�5      $��20q�5      $��Center=�5      �� 5   
   $��0��6   $��1��6%   .+�5      �� -   5        $ TextBoxWithData��5      $��5q�5      $��10q�5      �� 5       -   5         ��Name$ ListBoxWithData��5       $��5q�5!      $��70q�5"      ��5$      �� 5%      .R�5&      �� .+�5'      �� ��5(   !   ��  �� Path$ DataInfo.Data�5)      5*      5,      5-      �� 5.   
   $��1��6   $��1��6%   .+�5/      �� -   5         ��Name$ 	AddButton��5/      $	��Add��6(   $��5q�50      $��10q�51      52      �� 53      -   5        $ SeriesButton��53      $��Series��6+   $��5q�54      $��10q�55      56      �� 57      -   5        $ DeleteButton��57      $��Delete��6+   $��5q�58      $��10q�59      5:      �� 5;      -   5        $ 
DrawButton��5;      $
��Draw��6)   $��5q�5<      $��10q�5=      5>      5?      �� 5@   
   -   5         ��Name$ 
MainCanvas��5@      $��2��5A      $��1��6!   $��5q�5B      $	��260��5C      
�������5D      5E      5F      