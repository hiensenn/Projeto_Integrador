   M S B A M L   `   `   `  ����L  HProjetoIntegrador, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:ProjetoIntegradorProjetoIntegrador  5      '    !ProjetoIntegrador.CadastraCliente   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:ProjetoIntegrador     5      .��5	      � $��20q�6   $��Center=�6     � RowDefinitions  5
   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� $��0��6   $��0��6!   $��3��61   $��REGISTRO DE VENDA��6E   $��24(�6^   ���#fff$��
ExtraLight"�6~   $��0,0,0,20q�6�   $��Center=�6�   �� 5   
   $��1��6   $��0��6!   $��LISTA JOGOS��61   $��Regular"�6D   $��Right=�6Z   $��15(�6v   $��	0,0,15,10q�6�   ���#fff6�   �� 5    
   $��1��6   $��1��6"    �� Orientation$ 
Horizontal=�62   $��Center=�6K   $��0,0,0,0q�6h   .+�5#      �� -   5         ��Name$ listaJogos_RegistroVenda��5#      $��Center=�69   $	��100��6T   6`   5'      �� 5)   
   $��2��6   $��0��6!   $��NOME CLIENTE��61   $��Regular"�6E   $��Right=�6[   $��15(�6w   $��	0,0,15,10q�6�   ���#fff6�   �� 5*   
   -   5         ��Name$ nomeCliente_RegistroVenda��5*      $��2��65   $��1��6B   $	��250��6R   ���#fff$��16(�6q   $��Center=�6   $
��Left=�6�   �� 5,   
   $��3��6   $��0��6!   $��E-MAIL ��61   $��Regular"�6@   $��Right=�6U   $��15(�6q   $��	0,0,15,10q�6   ���#fff6�   �� 5-   
   -   5        $ email_RegistroVendas��5-      $��3��60   $��1��6=   $	��250��6M   $��16(�6Y   $��Center=�6g   ���#fff$
��Left=�6�   �� 5/   
   $��4��6   $��0��6!   $
��CPF ��61   $��Regular"�6=   $��Right=�6R   $��15(�6n   $��	0,0,15,10q�6}   ���#fff6�   �� 50   
   -   5        $ cpf_RegistroVendas��50      $��4��6.   $��1��6;   $	��250��6K   $��16(�6W   $��Center=�6e   ���#fff$
��Left=�6�   �� 52   
   $��5��6   $��0��6!   $��
QUANTIDADE��61   $��Regular"�6C   $��Right=�6X   $��15(�6t   $��	0,0,15,10q�6�   ���#fff6�   �� 53   
   -   5        $ qtd_RegistroVendas��53      $��5��6.   $��1��6;   $	��250��6K   $��16(�6W   $��Center=�6e   ���#fff$
��Left=�6�   �� 57   
   -   5        $��9��57      $��1��6   $	��200��6.   $��50��6:   $��0,30,0,0q�6F   $��Center=�6X   $	��Top=�6u   ���#008B8B���#fff$��16(�58      $��Regular"�6   $��	REGISTRAR��64   $��10q�6H   ���#fff$��1q�6h   6|   59      5;      