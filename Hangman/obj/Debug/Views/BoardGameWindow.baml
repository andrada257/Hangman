   M S B A M L   `   `   `  ����B  >Hangman, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:Hangman.ViewsHangman.Views  5   	   7 clr-namespace:Hangman.ViewModelsHangman.ViewModels  5   	   #    Hangman.Views.BoardGameWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:Hangman.Views     5   	   7
viewmodels clr-namespace:Hangman.ViewModels     5   	     � Title$  Hangman Game��5	   	    � WindowStyle$
 None=�6    � WindowState$ 	Maximized=�61   .��5
      � .+�5   
   o� $
��1700��6   $��35��6   $
��Left=�6(   $	��Top=�6C   $��18(�6\   .@�5      m� $
��File��6   .@�5      m� $��New Game��6    m� Command 6.   �� *	newGame+m� 5      $��	Open Game��6   m� 5      $��	Save Game��6   m� 5      $��
Statistics��6   m� 5      -   5        $
��Exit��5      6*   5      m� 5      $��
Categories��6   .@�5      m� $��All Categories��6    63   �� *allCategories+m� 5      $
��Cars��6    6)   �� *cars+m� 5      $��Movies��6    6+   �� *movies+m� 5      $��Singers��6    6,   �� *	singers+m� 5      $��Capitals��6    6-   �� *
capitals+5      m� 5      $
��Help��6   .@�5      m� $��About��6   5       5"      � 5$   
   $��0,35,0,0q�6   ��5%      �� 5&       �� ImageSource$S MD:\Facultate\Anul2\Semestrul2\MVP\Tema2\Hangman\Hangman\Images\Backround2.jpg��6   .+�5)      �� .+�5*      � .+�5+      �� -   5        $��
imageLabel��5+      $	��131��6/   $��89��6;   $��	40,20,0,0q�6G   .��5,      �� ��6    �� *userVM.Image+5-      �� 5/      $��25(�6@   $��
10,40,10,0q�6N   $	��120��6b   $��60��6n   ��6   �� *userVM.UserName+6n   50      � 53      .+�55      �� $��30(�6   $��	30,0,16,0q�6*   .��56      �� .�6   Level:58      59      �� 5:      $��25(�66   $
��Bold"�6D   $��0,5,0,0q�6V   ��6   �� *level+6V   5<      �� 5@      .��5A      �� $��UniformToFill=�6;   $	��481��6S   $	��470��6`   $��0,30,0,0q�6l   ��6   �� *imageSource+6l   5C      � 5D      $��0, 20, 0, 0q�6   .+�5E      �� $��30(�6!   $��88��6/   $��30,0,0,0q�6:   �� 5F      .�6   Word:5H      5I      �� 5K      -   5        $��lbName��5K      $��30(�6Q   $	��400��6_   $��10,5,0,0q�6k   ��6+   �� *words.ShownedWord+6k   5M      5O      �� 5R      $��0,0,0,0q�6   .+�5S      �� $��20(�65   $��Center=�6C   
���   �$��41��6z   $��77��6�   
�������$��Center=�6�   $��	0,0,400,0q�6�   
�������$��2,2,2,2q�6�   $��Center=�6  ��6   �� *
timeLeft+6  � 5T      $��165, 150, 0, 0q�6   .+�5U      �� $��60(�6=   $��85��6K    �� TextAlignment$ Center=�6V   $��	10,0,10,0q�6m   #��� ��6�   ��6    �� *mistakes[0]+6�   �� 5V      $��60(�6=   $��85��6K   $ Center=�6V   #��� ��6m   $��	10,0,10,0q�6�   ��6    �� *mistakes[1]+6�   �� 5W      $��60(�6=   $��85��6K   $ Center=�6V   #��� ��6m   $��	10,0,10,0q�6�   ��6    �� *mistakes[2]+6�   �� 5X      $��60(�6=   $��85��6K   $ Center=�6V   #��� ��6m   $��	10,0,10,0q�6�   ��6    �� *mistakes[3]+6�   �� 5Y      $��60(�6=   $��85��6K   $ Center=�6V   #��� ��6m   $��	10,0,10,0q�6�   ��6    �� *mistakes[4]+6�   �� 5Z      $��60(�6=   $��85��6K   $ Center=�6V   #��� ��6m   $��	10,0,10,0q�6�   ��6    �� *mistakes[5]+6�   5[      � 5]      $��180, 180, 100, 40q�6   .+�5_      �� $��A��6   $��67��6?   $��60��6J   
���   �
�������$��40(�6|   ��6)   �� *a+{�6�   �� *	CanCloseA+�� 5`      $��B��6   $��67��6?   $��60��6J   
���   �
�������$��40(�6|   ��6)   �� *b+{�6�   �� *	CanCloseB+�� 5a      $��C��6   $��67��6?   $��60��6J   
���   �
�������$��40(�6|   ��6)   �� *c+{�6�   �� *	CanCloseC+�� 5b      $��D��6   $��67��6?   $��60��6J   
���   �
�������$��40(�6|   ��6)   �� *d+{�6�   �� *	CanCloseD+�� 5c      $��E��6   $��67��6?   $��60��6J   
���   �
�������$��40(�6|   ��6)   �� *e+{�6�   �� *	CanCloseE+�� 5d      $��F��6   $��67��6?   $��60��6J   
���   �
�������$��40(�6|   ��6)   �� *f+{�6�   �� *	CanCloseF+�� 5e      $��G��6   $��67��6?   $��60��6J   
���   �
�������$��40(�6|   ��6)   �� *g+{�6�   �� *	CanCloseG+�� 5f      $��H��6   $��67��6?   $��60��6J   
���   �
�������$��40(�6|   ��6)   �� *h+{�6�   �� *	CanCloseH+�� 5g      $��I��6   $��67��6?   $��60��6J   
���   �
�������$��40(�6|   ��6)   �� *i+{�6�   �� *	CanCloseI+5i      � 5k      $��115, 0, 0, 0q�6   .+�5m      �� $��J��6   $��67��6?   $��60��6J   
���   �
�������$��40(�6|   ��6)   �� *j+{�6�   �� *	CanCloseJ+�� 5n      $��K��6   $��67��6?   $��60��6J   
���   �
�������$��40(�6|   ��6)   �� *k+{�6�   �� *	CanCloseK+�� 5o      $��L��6   $��67��6?   $��60��6J   
���   �
�������$��40(�6|   ��6)   �� *l+{�6�   �� *	CanCloseL+�� 5p      $��M��6   $��67��6?   $��60��6J   
���   �
�������$��40(�6|   ��6)   �� *m+{�6�   �� *	CanCloseM+�� 5q      $��N��6   $��67��6?   $��60��6J   
���   �
�������$��40(�6|   ��6)   �� *n+{�6�   �� *	CanCloseN+�� 5r      $��O��6   $��67��6?   $��60��6J   
���   �
�������$��40(�6|   ��6)   �� *o+{�6�   �� *	CanCloseO+�� 5s      $��P��6   $��67��6?   $��60��6J   
���   �
�������$��40(�6|   ��6)   �� *p+{�6�   �� *	CanCloseP+�� 5t      $��Q��6   $��67��6?   $��60��6J   
���   �
�������$��40(�6|   ��6)   �� *q+{�6�   �� *	CanCloseQ+�� 5u      $��R��6   $��67��6?   $��60��6J   
���   �
�������$��40(�6|   ��6)   �� *r+{�6�   �� *	CanCloseR+�� 5v      $��S��6   $��67��6?   $��60��6J   
���   �
�������$��40(�6|   ��6)   �� *s+{�6�   �� *	CanCloseS+�� 5w      $��T��6   $��67��6?   $��60��6J   
���   �
�������$��40(�6|   ��6)   �� *t+{�6�   �� *	CanCloseT+5y      � 5{      $��275, 40, 0, 0q�6   .+�5}      �� $��U��6   $��67��6?   $��60��6J   
���   �
�������$��40(�6|   ��6)   �� *u+{�6�   �� *	CanCloseU+�� 5~      $��V��6   $��67��6?   $��60��6J   
���   �
�������$��40(�6|   ��6)   �� *v+{�6�   �� *	CanCloseV+�� 5      $��W��6   $��67��6?   $��60��6J   
���   �
�������$��40(�6|   ��6)   �� *w+{�6�   �� *	CanCloseW+�� 5�      $��X��6   $��67��6?   $��60��6J   
���   �
�������$��40(�6|   ��6)   �� *x+{�6�   �� *	CanCloseX+�� 5�      $��Y��6   $��67��6?   $��60��6J   
���   �
�������$��40(�6|   ��6)   �� *y+{�6�   �� *	CanCloseY+�� 5�      $��Z��6   $��67��6?   $��60��6J   
���   �
�������$��40(�6|   ��6)   �� *z+{�6�   �� *	CanCloseZ+5�      5�      5�      5�      5�      