   M S B A M L   `   `   `  ????H  DDecoratorTask, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:DecoratorTaskDecoratorTask  5   	       DecoratorTask.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:DecoratorTask     5   	   c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  63     ? Title$  
MainWindow??5   	   $	??450??6   $	??800??6)   .??5	      ? .+?5
   
   ?? $
??Left=?6   .+?5      ?? .??5      ?? -   5         ??Name$ checkBox_stackPanel??5      .+?5      ?? $??10q?6   $??12(?6,   $??DemiBold"?6:   .??6P   Instagram Service ? LayoutTransform 5      ?? 5       ?? ScaleX$ 2Q?6-    ?? ScaleY$ 2Q?68   6E   5      ?? 5      $??10q?6   $??12(?6+   $??DemiBold"?69   .??6O   Facebook Service 5      ?? 5      $ 2Q?6-   $ 2Q?68   6E   5      ?? 5      $??10q?6   $??12(?6+   $??DemiBold"?69   .??6O   Telegram Service 5      ?? 5       $ 2Q?6-   $ 2Q?68   6E   5#      ?? 5%      $??10q?6   $??12(?6+   $??DemiBold"?69   .??6O   Twitter Service 5'      ?? 5(      $ 2Q?6-   $ 2Q?68   6E   5+      5,      5-      5.      ?? 50   
   $??Right=?6   $??Bottom=?61   .+?52      ?? $??45(?65   
???????$
??Bold"?53      
??? ? ?$??Center=?54      $	??200??55      $??50,50,50,50q?56      ??52      ?? *SendCommand+.??56   *   Send ? 	Resources 58       ?? 
TargetType ?? Property ?? Value??%d   '??       ?? 59      " ??6   .?5:      ??  ?@??CornerRadius$ 10??69   6F   5;      5<      5=      5>      ?? 5@   
   -   5        $??
stackPanel??5@      $??Right=?6'   $	??Top=?6C   $	??450??5A      $	??250??6!   .+?5B      ?? 	 ?? Orientation$	 
Horizontal=?6   $??Center=?62   .+?5C      ?? $??25(?6   ??6&   ?? *Items[0].Message+6M   ?? 5D      $
??Fill=?6>   $??40??6M   ??6   ?? *Items[0].ImagePath+6Z   5E      ?? 5F      $	 
Horizontal=?6   $??Center=?62   .+?5G      ?? $??25(?6   ??6&   ?? *Items[1].Message+6M   ?? 5H      $
??Fill=?6>   $??40??6M   ??6   ?? *Items[1].ImagePath+6Z   5I      ?? 5J      $	 
Horizontal=?6   $??Center=?62   .+?5K      ?? $??25(?6   ??6&   ?? *Items[2].Message+6M   ?? 5L      $
??Fill=?6>   $??40??6M   ??6   ?? *Items[2].ImagePath+6Z   5M      ?? 5N      $	 
Horizontal=?6   $??Center=?62   .+?5O      ?? $??25(?6   ??6&   ?? *Items[3].Message+6M   ?? 5P      $
??Fill=?6>   $??40??6M   ??6   ?? *Items[3].ImagePath+6Z   5Q      5S      5T      5U      