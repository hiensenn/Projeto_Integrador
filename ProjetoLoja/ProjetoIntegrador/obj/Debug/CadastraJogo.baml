   M S B A M L   `   `   `  ����L  HProjetoIntegrador, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:ProjetoIntegradorProjetoIntegrador  5      $    ProjetoIntegrador.CadastraJogo   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:ProjetoIntegrador     5      .��5	      � $��20q�6   $��Center=�6     � RowDefinitions  5
   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� $��0��6   $��24(�6!   $��Regular"�6/   $��Center=�6D   $��0,0,0,20q�6a   ���#fffCadastro de Jogos6�   �� 5   
   $��1��6    �� Orientation$ 
Horizontal=�6"   $��Center=�6;   $��0,0,0,10q�6X   .+�5      �� $	��120��6   $��16(�6$   $��Center=�62   $��
ExtraLight"�6M   ���#fffNome do Jogo:6�   �� 5      -   5         ��Name$ nomeJogo_Textbox��5      $	��300��60   $��Right=�6<   $��16(�6X   $��Bottom=�6g   $��0,0,0,2q�6�   5      �� 5   
   $��2��6   $ 
Horizontal=�6"   $��Center=�6;   $��0,0,0,10q�6X   .+�5      �� $	��120��6   $��16(�6$   $��Center=�62   $��
ExtraLight"�6M   ���#fff
Código:6�   �� 5      -   5        $ codigoJogo_TextBox��5      $	��300��62   $��16(�6>   $��Center=�6L   5      �� 5    
   $��3��6   $ 
Horizontal=�6"   $��Center=�6;   $��0,0,0,10q�6X   .+�5!      �� $	��120��6   $��16(�6$   $��Center=�62   $��
ExtraLight"�6M   ���#fffTipo de Jogo:6�   �� 5"      -   5         ��Name$ TipoJogo_ComboBox��5"      $	��300��62   $��16(�6>   $��Center=�6L   .@�5#      �� $��Ação��6   �� 5$      $��Aventura��6   �� 5%      $��Estratégia��6   �� 5&      $��Esporte��6   �� 5'      $��Simulação��6   �� 5(      $	��RPG��6   5)      5*      �� 5-   
   $��4��6   $ Vertical=�6"   .+�5/      �� $��5��6   $��0,20,0,0q�6'   $��Center=�69   .+�50      �� $��18(�6   $��Regular"�6*   $��0,0,0,10q�6?   $��Center=�6Q   ���#fffQtd6�   �� 51      -   5        $ quantidadeJogo_TextBox��51      $	��100��6:   $��16(�6F   $��Center=�6T   $��Center=�6q   $��0,0,0,10q�6�   �� 53      $��5��6   $��18(�6)   $��Regular"�67   $��0,0,0,10q�6L   $��Center=�6^   ���#fff
Valor R$6�   �� 54      -   5        $ valorJogo_TextBox��54      $	��100��65   $��16(�6A   $��Center=�6O   55      57      �� 5:   
   -   5         ��Name$ registrarJogo��5:      $��6��6(   $	��200��5;      $��50��6   $��0,30,0,0q�6)   $��Center=�6;   $	��Top=�6X   ���#008B8B���#fff$��16(�5<      $��Regular"�6   $��	REGISTRAR��64   $��10q�6H   ���#fff$��1q�6h   6|   5=      5>      