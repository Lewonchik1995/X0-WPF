   M S B A M L   `   `   `  ????D  @CrossZero, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:CrossZero	CrossZero  5   	       CrossZero.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:CrossZero     5   	     ? Title$  
MainWindow??5   	   $	??500??6   $	??300??6)   .??5
      ?  ? ColumnDefinitions 5   
   ?? 5      ?? 5      ?? 5       ? RowDefinitions 5   
   ?? 5      $
??0.5* ?6   ?? 5      ?? 5      ?? 5      ?? 5      $
??0.5* ?6   ?? 5      $
??0.5* ?6   ?? 5      $
??0.5* ?6   .+?5   
   ?? $#??КРЕСТИКИ-НОЛИКИ??6   $??0??6+   $??3??68   $??Center=?6L   $??Center=?6g   $??25(?6?   $
??Bold"?6?   $??Ubuntu)?6?   ?? 5   
   -   5        $??TopLeft??5      $??1??6    $??0??6-   $?? ??6=   $??55(?6H   $??Ubuntu)?6V   $??5q?6j   6u   ?? 5   
   -   5        $??	TopMiddle??5      $??1??6"   $??1??6/   $?? ??6?   $??55(?6J   $??Ubuntu)?6X   $??5q?6l   6w   ?? 5   
   -   5        $??TopRight??5      $??1??6!   $??2??6.   $?? ??6>   $??55(?6I   $??Ubuntu)?6W   $??5q?6k   6v   ?? 5   
   -   5        $??
MiddleLeft??5      $??2??6#   $??0??60   $?? ??6@   $??55(?6K   $??Ubuntu)?6Y   $??5q?6m   6x   ?? 5   
   -   5        $??Middle??5      $??2??6   $??1??6,   $?? ??6<   $??55(?6G   $??Ubuntu)?6U   $??5q?6i   6t   ?? 5   
   -   5        $??MiddleRight??5      $??3??6$   $??2??61   $?? ??6A   $??55(?6L   $??Ubuntu)?6Z   $??5q?6n   6y   ?? 5    
   -   5        $??
BottomLeft??5       $??3??6#   $??0??60   $?? ??6@   $??55(?6K   $??Ubuntu)?6Y   $??5q?6m   6x   ?? 5!   
   -   5        $??BottomMiddle??5!      $??3??6%   $??1??62   $?? ??6B   $??55(?6N   $??Ubuntu)?6\   $??5q?6p   6{   ?? 5"   
   -	   5        $??BottomRight??5"      $??2??6$   $??2??61   $?? ??6A   $??55(?6L   $??Ubuntu)?6Z   $??5q?6n   6y   ?? 5#   
   -
   5         ??Name$ TurnDisplayer??5#      $??4??6(   $??3??65   $"??Ходят: Крестики??6I   $??Center=?6c   $??Center=?6?   ?? 5$   
   -   5        $??5??5$      $??1??6   $??Новая игра??6.   $??10q?6C   6O   5%      5&      