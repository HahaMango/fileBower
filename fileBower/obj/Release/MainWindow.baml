   M S B A M L   `   `   `  ���� D  @fileBower, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:fileBower.DatafileBower.Data      fileBower.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     .localclr-namespace:fileBower.Data     -     � Title$  
MainWindow��$��475.257��$��290.1�� � WindowStyle$
 None=� � AllowsTransparency . $��10q���Z�  J� Effect 3  -System.Windows.Media.Effects.DropShadowEffect     
BlurRadius$ 10Q�   Color$ 	#FF858484��   	Direction$ 90Q�   ShadowDepth$ 3Q� � 	Resources 	 �� MergedDictionaries
 �� Source   FileBox �� 
TargetType ��Name �� Padding J� SnapsToDevicePixels   ScrollViewerControlTemplate1    fileBower.Data.Visibilable  visi  switchin �� TargetProperty �� 
TargetName<  6System.Windows.Media.Animation.EasingThicknessKeyFrame p� KeyTime p� Value  	switchout�� 	 �� $
 FileBoxStyle.xaml?�%l  &	        7  &	 i     &	 n     &	 W    �� " ��.R��� $ Bd��#��z��#��z��#��z��$ 1q� . ._��� |�.  #��z��8��  .���� # z   �� .��r� $ (FrameworkElement.Margin)�$ 
listboxWeb��.	�  $ 0��$ 
-270,0,0,0q�  $ 0:0:0.2��$ 0q�r� $ (FrameworkElement.Margin)�$ listbox1��.	�  $ 0��$ 0q�  $ 0:0:0.2��$ 	270,0,0,0q��� .��r� $ (FrameworkElement.Margin)�$ listbox1��.	�  $ 0��$ 	270,0,0,0q�  $ 0:0:0.2��$ 0q�r� $ (FrameworkElement.Margin)�$ 
listboxWeb��.	�  $ 0��$ 0q�  $ 0:0:0.2��$ 
-270,0,0,0q� � Triggers :�  :� RoutedEvent$ ToggleButton.Checked�� :� 
SourceName$ switchbutton��.[��� -    ��Name$ switchin_BeginStoryboard��#��[ :� $ ToggleButton.Unchecked��$ switchbutton��.[��� -   $ switchout_BeginStoryboard��#��[ .��� .+�� -    �Name$ grid2�����	#FF1B1B1B$��0,0,10,0q�.+�� -   $��grid1��$��	10,48,0,0q�$	��371��$	��Top=�$
��Left=�$	��240��.+��� -    ��Name$ listbox1�����	#FF292929
�������$��Disabled=�#��[  $
��Left=�$	��240����Z� ���� .R�� .+��� -   $	��220��$��45��{���  �� Source# [  �� Path$ 
StackState�.+��� $��30��$
��auto��$��18(����� *FileNameLastName+���� # [ $ 	ItemColor��� $
��auto��$��9(����� *
Filename+���� # [ $ 	ItemColor��� -   $��删除��$��40��$��20��$
��Left=�$	��Top=�  MyButton#��[ $��	180,0,0,0q���Z� ��Z� y��� # [ $ Vi�����  j� Stretch$ Uniform=� �� ImageSource$ img\close.png���� -	   $ 
listboxWeb�����	#FF292929
�������$��Disabled=�#��[  $��
-270,0,0,0q�$
��Left=�$	��240����Z� ���� .R�� .+��� -
   $	��220��$��45��{��� # [ $ 
StackState�.+��� $��30��$
��auto��$��18(����� *	WebName+���� # [ $ 	ItemColor��� $
��auto��$��9(����� *	Webaddr+���� # [ $ 	ItemColor��� -   $��删除��$��40��$��20��$
��Left=�$	��Top=�#��[ $��	180,0,0,0q���Z� ��Z� y��� # [ $ Vi����� $ Uniform=�$ img\close.png���� -   $��selectButton��$��选择文件夹��$
��Left=�$��173,424,0,0q�$	��Top=�$��77��$��23��
�������#��[ ��Z� ��Z� �� -   $��关闭��$
��Left=�$��
202,10,0,0q�$	��Top=�$��48��$��23��
�������#��[ ��Z� ��Z� �� -   $��打开资源管理器��$
��Left=�$��
10,424,0,0q�$	��Top=�$	��102��$��23��
�������#��[ ��Z� ��Z� �� -   $��编辑��$
��Left=�$��	10,10,0,0q�$	��Top=�$��46��#��[ $��23��
������� � -   $��webframe��$	��204��$
��auto��$y�Hidden=��� -   $��switchbutton��$�� ��$
��Left=�$��35��$��236.1,207.333,0,0q�  switchButton#��[ $	��Top=�$��35��