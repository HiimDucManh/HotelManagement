   M S B A M L   `   `   `  ????I  EQuanLyKhachSan, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:QuanLyKhachSanQuanLyKhachSan  5          QuanLyKhachSan.PageRoom   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:QuanLyKhachSan     5      _ [MaterialDesignThemes.Wpf, Version=4.2.1.2, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5        N? Title$  PageRoom??5	      .??5      #  MaterialDesignThemes.Wpf.Card  .??5   
   ?  ? ColumnDefinitions 5      ?? 5      $??90 ?6#   60   ?? 5      6%   .+?5      ? $??1??6    ? RowDefinitions 5      ?? 5      $??90 ?6$   62   ?? 5      6&   .+?5      ? .+?5      ??  ? 	Resources 5       ?? 
TargetType ?? Property ?? Value%  MaterialDesignThemes.Wpf.Badged??%?  '??       '?? z     '  ^    ?? 5      " ??6$   .?5   "   ??  ? ??$
 auto??6;   6J   ?? 5   "    ? ??$
 auto??6:   6I   5      ?? 5      " ??6$   .?5    "   ??  ?@??Orientation$ 
Horizontal=?6@   6U   ?? 5!   "    ? ??$ Center=?6F   6W   ?? 5"   "    ? ??$ Center=?6H   6Y   ?? 5#   "    ? ??$ 10q?6;   6H   5$      ?? 5%      "  6$   .?5&   "   ??  ? ??$ 10q?6;   6H   5'      5(      .+?5)           Badge$ 3??60   $??36??6:   .??5*      ?? $??
Tất cả??6%    ? ToolTip$ 
Tất cả??5+   )   
??????? #  MaterialDesignRaisedLightButton#??[  5-   )   6d   5.        5/      $ 3??60   .??50      ?? $??Trống??6%   $ Trống??51   )   ???	#FF30BD30#??[  53   )   6d   54        55      $ 3??60   .??56      ?? $??Nhận Phòng??6%   $ Nhận Phòng??57   )   ???	#FFEE5757#??[  59   )   6d   5:        5;      $ 3??60   .??5<      ?? $??
Quá hạn??6%   $ 
Quá hạn??5=   )   ???	#FFEA5721#??[  5?   )   6d   5@        5A      $ 3??60   .??5B      ?? $??Đã đặt??6%   $ Đã đặt??5C   )   ???	#FF1C8BB0#??[  5E   )   6d   5F        5G      $ 3??60   .??5H      ?? $??Đang sửa??6%   $ Đang sửa??5I   )   ???	#FFAE9D9D#??[  5K   )   6d   5L      5M      5N      ? 5Q      $??1??6   .+?5R      ?? $
??Auto=?6#   $
??Auto=?5S   #   .??5T      ?? .+?5U      ?? 	 ?? Orientation$	 
Horizontal=?6)   $	??265??6B   $??10q?6O   .+?5V   "   &   MaterialDesignThemes.Wpf.Flipper    MaterialDesignCardFlipper#??[ 69   $??10q?5W   9   
   FrontContent
 5X   &   ?? 5Y   *     MaterialDesignFlatButton#??[ 61      FlipCommand#??Z 5Z   %   $??8q?5[   %   $	??192??5\   %   $	??101??5]   %   5^   +      BackContent 5`   &   ? 5a   *   $	??240??6/   $	??200??6<    5b   .   ?? 5c   2   $
??Auto ?6@   ?? 5d   2   $??* ?6@   .+?5f   .   (  "MaterialDesignThemes.Wpf.ColorZone  $??6q?6G      Mode$ 
PrimaryMid=?6S   .??5g   2   ?? $	 
Horizontal=?6=   .+?5h   6   ??  & "MaterialDesignToolForegroundButton#??[ 6=   #??Z 5i   1   $
??Left=?5j   1   .??5k   :   '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ 	ArrowLeft=?6R   $??Right=?6c   5l   7   ?? 5m   6   $??8 0 0 0q?6@   $??Center=?6Q   $??	EDIT USER??6l   6   5n   3   5o   /   ? 5p   .   $??1??63    5q   2   ?? 5r   6   6F   ?? 5s   6   $
??auto ?6D   6T   .+?5u   2   ??  5v   6   ??%w   '??       ?? 5w   :   " ??6@   .?5x   >   ??  ? ??$ 3q?6W   ?? 5y   >    ? ??$
 auto??6V   5z   ;   5{   7   .+?5|   6   #  MaterialDesignThemes.Wpf.Chip  $??Tên khách hàng??6J      Icon$ T??6c   $??5q?6l   6y   ?? 5}   6   $??Thời gian nhận phòng??6@   $
??Left=?6\   6y   ?? 5~   6   $??A??6@   $??Right=?6I   6g   ?? 5   6   $??Thời gian trả phòng??6@   $
??Left=?6[   6x   ?? 5?   6   $??A??6@   $??Right=?6I   6g   ?? 5?   6   $	 
Horizontal=?6A   .+?5?   :   ?? $??Loại phòng??6D   $
??Left=?6V   6s   ?? 5?   :   $??A??6D   $??Right=?6M   6k   5?   7   5?   3   ? 5?   2   $??1??67    5?   6   ?? 5?   :   $
??auto ?6K   6Z   ?? 5?   :   6N   .+?5?   6   ??   MaterialDesignRaisedButton#??[ 6=   $
??auto??6q   $/ )Resource name: MaterialDesignRaisedButton??5?   )   $
??Book??5?   )   $??Center=?5?   )   5?   7   ?? 5?   6   #??[ 6=   $
??auto??6q   $/ )Resource name: MaterialDesignRaisedButton??5?   )   $??Thanh toán??5?   )   $??1??5?   )   $??Center=?5?   )   5?   7   5?   3   5?   /   5?   +   5?   #     5?   "   #??[ 69   $??10q?6l   
 5?   &   ?? 5?   *   #??[ 61   #??Z 5?   %   $??8q?5?   %   $	??192??5?   %   $	??101??5?   %   5?   +    5?   &   ? 5?   *   $	??240??6/   $	??200??6<    5?   .   ?? 5?   2   $
??Auto ?6@   ?? 5?   2   $??* ?6@   .+?5?   .     $??6q?6G   $ 
PrimaryMid=?6S   .??5?   2   ?? $	 
Horizontal=?6=   .+?5?   6   ?? #??[ 6=   #??Z 5?   1   $
??Left=?5?   1   .??5?   :     $ 	ArrowLeft=?6R   $??Right=?6c   5?   7   ?? 5?   6   $??8 0 0 0q?6@   $??Center=?6Q   $??	EDIT USER??6l   6   5?   3   5?   /   ? 5?   .   $??1??63    5?   2   ?? 5?   6   6F   ?? 5?   6   $
??auto ?6D   6T   .+?5?   2   ??  5?   6   ??%w   '??       ?? 5?   :   " ??6@   .?5?   >   ??  ? ??$ 3q?6W   ?? 5?   >    ? ??$
 auto??6V   5?   ;   5?   7   .+?5?   6     $??Tên khách hàng??6J   $ T??6c   $??5q?6l   6y   ?? 5?   6   $??Thời gian nhận phòng??6@   $
??Left=?6\   6y   ?? 5?   6   $??A??6@   $??Right=?6I   6g   ?? 5?   6   $??Thời gian trả phòng??6@   $
??Left=?6[   6x   ?? 5?   6   $??A??6@   $??Right=?6I   6g   ?? 5?   6   $	 
Horizontal=?6A   .+?5?   :   ?? $??Loại phòng??6D   $
??Left=?6V   6s   ?? 5?   :   $??A??6D   $??Right=?6M   6k   5?   7   5?   3   ? 5?   2   $??1??67    5?   6   ?? 5?   :   $
??auto ?6K   6Z   ?? 5?   :   6N   .+?5?   6   ?? #??[ 6=   $
??auto??6q   $/ )Resource name: MaterialDesignRaisedButton??5?   )   $
??Book??5?   )   $??Center=?5?   )   5?   7   ?? 5?   6   #??[ 6=   $
??auto??6q   $/ )Resource name: MaterialDesignRaisedButton??5?   )   $??Thanh toán??5?   )   $??1??5?   )   $??Center=?5?   )   5?   7   5?   3   5?   /   5?   +   5?   #     5?   "   #??[ 69   $??10q?5?   9   
 5?   &   ?? 5?   *   #??[ 61   #??Z 5?   %   $??8q?5?   %   $	??192??5?   %   $	??101??5?   %   5?   +    5?   &   ? 5?   *   $	??240??6/   $	??200??6<    5?   .   ?? 5?   2   $
??Auto ?6@   ?? 5?   2   $??* ?6@   .+?5?   .     $??6q?6G   $ 
PrimaryMid=?6S   .??5?   2   ?? $	 
Horizontal=?6=   .+?5?   6   ?? #??[ 6=   #??Z 5?   1   $
??Left=?5?   1   .??5?   :     $ 	ArrowLeft=?6R   $??Right=?6c   5?   7   ?? 5?   6   $??8 0 0 0q?6@   $??Center=?6Q   $??	EDIT USER??6l   6   5?   3   5?   /   ? 5?   .   $??1??63    5?   2   ?? 5?   6   6F   ?? 5?   6   $
??auto ?6D   6T   .+?5   2   ??  5  6   ??%w   '??       ?? 5  :   " ??6@   .?5  >   ??  ? ??$ 3q?6W   ?? 5  >    ? ??$
 auto??6V   5  ;   5  7   .+?5  6     $??Tên khách hàng??6J   $ T??6c   $??5q?6l   6y   ?? 5  6   $??Thời gian nhận phòng??6@   $
??Left=?6\   6y   ?? 5	  6   $??A??6@   $??Right=?6I   6g   ?? 5
  6   $??Thời gian trả phòng??6@   $
??Left=?6[   6x   ?? 5  6   $??A??6@   $??Right=?6I   6g   ?? 5  6   $	 
Horizontal=?6A   .+?5  :   ?? $??Loại phòng??6D   $
??Left=?6V   6s   ?? 5  :   $??A??6D   $??Right=?6M   6k   5  7   5  3   ? 5  2   $??1??67    5  6   ?? 5  :   $
??auto ?6K   6Z   ?? 5  :   6N   .+?5  6   ?? #??[ 6=   $
??auto??6q   $/ )Resource name: MaterialDesignRaisedButton??5  )   $
??Book??5  )   $??Center=?5  )   5  7   ?? 5  6   #??[ 6=   $
??auto??6q   $/ )Resource name: MaterialDesignRaisedButton??5  )   $??Thanh toán??5  )   $??1??5  )   $??Center=?5  )   5   7   5!  3   5"  /   5#  +   5%  #     5'  "   #??[ 69   $??10q?6l   
 5(  &   ?? 5)  *   #??[ 61   #??Z 5*  %   $??8q?5+  %   $	??192??5,  %   $	??101??5-  %   5.  +    50  &   ? 51  *   $	??240??6/   $	??200??6<    52  .   ?? 53  2   $
??Auto ?6@   ?? 54  2   $??* ?6@   .+?56  .     $??6q?6G   $ 
PrimaryMid=?6S   .??57  2   ?? $	 
Horizontal=?6=   .+?58  6   ?? #??[ 6=   #??Z 59  1   $
??Left=?5:  1   .??5;  :     $ 	ArrowLeft=?6R   $??Right=?6c   5<  7   ?? 5=  6   $??8 0 0 0q?6@   $??Center=?6Q   $??	EDIT USER??6l   6   5>  3   5?  /   ? 5@  .   $??1??63    5A  2   ?? 5B  6   6F   ?? 5C  6   $
??auto ?6D   6T   .+?5E  2   ??  5F  6   ??%w   '??       ?? 5G  :   " ??6@   .?5H  >   ??  ? ??$ 3q?6W   ?? 5I  >    ? ??$
 auto??6V   5J  ;   5K  7   .+?5L  6     $??Tên khách hàng??6J   $ T??6c   $??5q?6l   6y   ?? 5M  6   $??Thời gian nhận phòng??6@   $
??Left=?6\   6y   ?? 5N  6   $??A??6@   $??Right=?6I   6g   ?? 5O  6   $??Thời gian trả phòng??6@   $
??Left=?6[   6x   ?? 5P  6   $??A??6@   $??Right=?6I   6g   ?? 5Q  6   $	 
Horizontal=?6A   .+?5R  :   ?? $??Loại phòng??6D   $
??Left=?6V   6s   ?? 5S  :   $??A??6D   $??Right=?6M   6k   5T  7   5U  3   ? 5V  2   $??1??67    5W  6   ?? 5X  :   $
??auto ?6K   6Z   ?? 5Y  :   6N   .+?5[  6   ?? #??[ 6=   $
??auto??6q   $/ )Resource name: MaterialDesignRaisedButton??5\  )   $
??Book??5]  )   $??Center=?5^  )   5_  7   ?? 5`  6   #??[ 6=   $
??auto??6q   $/ )Resource name: MaterialDesignRaisedButton??5a  )   $??Thanh toán??5b  )   $??1??5c  )   $??Center=?5d  )   5e  7   5f  3   5g  /   5h  +   5j  #     5l  "   #??[ 69   $??10q?6l   
 5m  &   ?? 5n  *   #??[ 61   #??Z 5o  %   $??8q?5p  %   $	??192??5q  %   $	??101??5r  %   5s  +    5u  &   ? 5v  *   $	??240??6/   $	??200??6<    5w  .   ?? 5x  2   $
??Auto ?6@   ?? 5y  2   $??* ?6@   .+?5{  .     $??6q?6G   $ 
PrimaryMid=?6S   .??5|  2   ?? $	 
Horizontal=?6=   .+?5}  6   ?? #??[ 6=   #??Z 5~  1   $
??Left=?5  1   .??5?  :     $ 	ArrowLeft=?6R   $??Right=?6c   5?  7   ?? 5?  6   $??8 0 0 0q?6@   $??Center=?6Q   $??	EDIT USER??6l   6   5?  3   5?  /   ? 5?  .   $??1??63    5?  2   ?? 5?  6   6F   ?? 5?  6   $
??auto ?6D   6T   .+?5?  2   ??  5?  6   ??%w   '??       ?? 5?  :   " ??6@   .?5?  >   ??  ? ??$ 3q?6W   ?? 5?  >    ? ??$
 auto??6V   5?  ;   5?  7   .+?5?  6     $??Tên khách hàng??6J   $ T??6c   $??5q?6l   6y   ?? 5?  6   $??Thời gian nhận phòng??6@   $
??Left=?6\   6y   ?? 5?  6   $??A??6@   $??Right=?6I   6g   ?? 5?  6   $??Thời gian trả phòng??6@   $
??Left=?6[   6x   ?? 5?  6   $??A??6@   $??Right=?6I   6g   ?? 5?  6   $	 
Horizontal=?6A   .+?5?  :   ?? $??Loại phòng??6D   $
??Left=?6V   6s   ?? 5?  :   $??A??6D   $??Right=?6M   6k   5?  7   5?  3   ? 5?  2   $??1??67    5?  6   ?? 5?  :   $
??auto ?6K   6Z   ?? 5?  :   6N   .+?5?  6   ?? #??[ 6=   $
??auto??6q   $/ )Resource name: MaterialDesignRaisedButton??5?  )   $
??Book??5?  )   $??Center=?5?  )   5?  7   ?? 5?  6   #??[ 6=   $
??auto??6q   $/ )Resource name: MaterialDesignRaisedButton??5?  )   $??Thanh toán??5?  )   $??1??5?  )   $??Center=?5?  )   5?  7   5?  3   5?  /   5?  +   5?  #   5?     ?? 5?     $	 
Horizontal=?6)   $	??260??6B   .+?5?  "     #??[ 69   $??10q?5?  9   
 5?  &   ?? 5?  *   #??[ 61   #??Z 5?  %   $??8q?5?  %   $	??192??5?  %   $	??101??5?  %   5?  +    5?  &   ? 5?  *   $	??240??6/   $	??200??6<    5?  .   ?? 5?  2   $
??Auto ?6@   ?? 5?  2   $??* ?6@   .+?5?  .     $??6q?6G   $ 
PrimaryMid=?6S   .??5?  2   ?? $	 
Horizontal=?6=   .+?5?  6   ?? #??[ 6=   #??Z 5?  1   $
??Left=?5?  1   .??5?  :     $ 	ArrowLeft=?6R   $??Right=?6c   5?  7   ?? 5?  6   $??8 0 0 0q?6@   $??Center=?6Q   $??	EDIT USER??6l   6   5?  3   5?  /   ? 5?  .   $??1??63    5?  2   ?? 5?  6   6F   ?? 5?  6   $
??auto ?6D   6T   .+?5?  2   ??  5?  6   ??%w   '??       ?? 5?  :   " ??6@   .?5?  >   ??  ? ??$ 3q?6W   ?? 5?  >    ? ??$
 auto??6V   5?  ;   5?  7   .+?5?  6     $??Tên khách hàng??6J   $ T??6c   $??5q?6l   6y   ?? 5?  6   $??Thời gian nhận phòng??6@   $
??Left=?6\   6y   ?? 5?  6   $??A??6@   $??Right=?6I   6g   ?? 5?  6   $??Thời gian trả phòng??6@   $
??Left=?6[   6x   ?? 5?  6   $??A??6@   $??Right=?6I   6g   ?? 5?  6   $	 
Horizontal=?6A   .+?5?  :   ?? $??Loại phòng??6D   $
??Left=?6V   6s   ?? 5?  :   $??A??6D   $??Right=?6M   6k   5?  7   5?  3   ? 5?  2   $??1??67    5?  6   ?? 5?  :   $
??auto ?6K   6Z   ?? 5?  :   6N   .+?5?  6   ?? #??[ 6=   $
??auto??6q   $/ )Resource name: MaterialDesignRaisedButton??5?  )   $
??Book??5?  )   $??Center=?5?  )   5?  7   ?? 5?  6   #??[ 6=   $
??auto??6q   $/ )Resource name: MaterialDesignRaisedButton??5?  )   $??Thanh toán??5?  )   $??1??5?  )   $??Center=?5?  )   5?  7   5?  3   5?  /   5?  +   5?  #     5?  "   #??[ 69   $??10q?6l   
 5?  &   ?? 5?  *   #??[ 61   #??Z 5?  %   $??8q?5?  %   $	??192??5?  %   $	??101??5?  %   5   +    5  &   ? 5  *   $	??240??6/   $	??200??6<    5  .   ?? 5  2   $
??Auto ?6@   ?? 5  2   $??* ?6@   .+?5  .     $??6q?6G   $ 
PrimaryMid=?6S   .??5	  2   ?? $	 
Horizontal=?6=   .+?5
  6   ?? #??[ 6=   #??Z 5  1   $
??Left=?5  1   .??5  :     $ 	ArrowLeft=?6R   $??Right=?6c   5  7   ?? 5  6   $??8 0 0 0q?6@   $??Center=?6Q   $??	EDIT USER??6l   6   5  3   5  /   ? 5  .   $??1??63    5  2   ?? 5  6   6F   ?? 5  6   $
??auto ?6D   6T   .+?5  2   ??  5  6   ??%w   '??       ?? 5  :   " ??6@   .?5  >   ??  ? ??$ 3q?6W   ?? 5  >    ? ??$
 auto??6V   5  ;   5  7   .+?5  6     $??Tên khách hàng??6J   $ T??6c   $??5q?6l   6y   ?? 5  6   $??Thời gian nhận phòng??6@   $
??Left=?6\   6y   ?? 5   6   $??A??6@   $??Right=?6I   6g   ?? 5!  6   $??Thời gian trả phòng??6@   $
??Left=?6[   6x   ?? 5"  6   $??A??6@   $??Right=?6I   6g   ?? 5#  6   $	 
Horizontal=?6A   .+?5$  :   ?? $??Loại phòng??6D   $
??Left=?6V   6s   ?? 5%  :   $??A??6D   $??Right=?6M   6k   5&  7   5'  3   ? 5(  2   $??1??67    5)  6   ?? 5*  :   $
??auto ?6K   6Z   ?? 5+  :   6N   .+?5-  6   ?? #??[ 6=   $
??auto??6q   $/ )Resource name: MaterialDesignRaisedButton??5.  )   $
??Book??5/  )   $??Center=?50  )   51  7   ?? 52  6   #??[ 6=   $
??auto??6q   $/ )Resource name: MaterialDesignRaisedButton??53  )   $??Thanh toán??54  )   $??1??55  )   $??Center=?56  )   57  7   58  3   59  /   5:  +   5<  #     5>  "   #??[ 69   $??10q?5?  9   
 5@  &   ?? 5A  *   #??[ 61   #??Z 5B  %   $??8q?5C  %   $	??192??5D  %   $	??101??5E  %   5F  +    5H  &   ? 5I  *   $	??240??6/   $	??200??6<    5J  .   ?? 5K  2   $
??Auto ?6@   ?? 5L  2   $??* ?6@   .+?5N  .     $??6q?6G   $ 
PrimaryMid=?6S   .??5O  2   ?? $	 
Horizontal=?6=   .+?5P  6   ?? #??[ 6=   #??Z 5Q  1   $
??Left=?5R  1   .??5S  :     $ 	ArrowLeft=?6R   $??Right=?6c   5T  7   ?? 5U  6   $??8 0 0 0q?6@   $??Center=?6Q   $??	EDIT USER??6l   6   5V  3   5W  /   ? 5X  .   $??1??63    5Y  2   ?? 5Z  6   6F   ?? 5[  6   $
??auto ?6D   6T   .+?5]  2   ??  5^  6   ??%w   '??       ?? 5_  :   " ??6@   .?5`  >   ??  ? ??$ 3q?6W   ?? 5a  >    ? ??$
 auto??6V   5b  ;   5c  7   .+?5d  6     $??Tên khách hàng??6J   $ T??6c   $??5q?6l   6y   ?? 5e  6   $??Thời gian nhận phòng??6@   $
??Left=?6\   6y   ?? 5f  6   $??A??6@   $??Right=?6I   6g   ?? 5g  6   $??Thời gian trả phòng??6@   $
??Left=?6[   6x   ?? 5h  6   $??A??6@   $??Right=?6I   6g   ?? 5i  6   $	 
Horizontal=?6A   .+?5j  :   ?? $??Loại phòng??6D   $
??Left=?6V   6s   ?? 5k  :   $??A??6D   $??Right=?6M   6k   5l  7   5m  3   ? 5n  2   $??1??67    5o  6   ?? 5p  :   $
??auto ?6K   6Z   ?? 5q  :   6N   .+?5s  6   ?? #??[ 6=   $
??auto??6q   $/ )Resource name: MaterialDesignRaisedButton??5t  )   $
??Book??5u  )   $??Center=?5v  )   5w  7   ?? 5x  6   #??[ 6=   $
??auto??6q   $/ )Resource name: MaterialDesignRaisedButton??5y  )   $??Thanh toán??5z  )   $??1??5{  )   $??Center=?5|  )   5}  7   5~  3   5  /   5?  +   5?  #     5?  "   #??[ 69   $??10q?6l   
 5?  &   ?? 5?  *   #??[ 61   #??Z 5?  %   $??8q?5?  %   $	??192??5?  %   $	??101??5?  %   5?  +    5?  &   ? 5?  *   $	??240??6/   $	??200??6<    5?  .   ?? 5?  2   $
??Auto ?6@   ?? 5?  2   $??* ?6@   .+?5?  .     $??6q?6G   $ 
PrimaryMid=?6S   .??5?  2   ?? $	 
Horizontal=?6=   .+?5?  6   ?? #??[ 6=   #??Z 5?  1   $
??Left=?5?  1   .??5?  :     $ 	ArrowLeft=?6R   $??Right=?6c   5?  7   ?? 5?  6   $??8 0 0 0q?6@   $??Center=?6Q   $??	EDIT USER??6l   6   5?  3   5?  /   ? 5?  .   $??1??63    5?  2   ?? 5?  6   6F   ?? 5?  6   $
??auto ?6D   6T   .+?5?  2   ??  5?  6   ??%w   '??       ?? 5?  :   " ??6@   .?5?  >   ??  ? ??$ 3q?6W   ?? 5?  >    ? ??$
 auto??6V   5?  ;   5?  7   .+?5?  6     $??Tên khách hàng??6J   $ T??6c   $??5q?6l   6y   ?? 5?  6   $??Thời gian nhận phòng??6@   $
??Left=?6\   6y   ?? 5?  6   $??A??6@   $??Right=?6I   6g   ?? 5?  6   $??Thời gian trả phòng??6@   $
??Left=?6[   6x   ?? 5?  6   $??A??6@   $??Right=?6I   6g   ?? 5?  6   $	 
Horizontal=?6A   .+?5?  :   ?? $??Loại phòng??6D   $
??Left=?6V   6s   ?? 5?  :   $??A??6D   $??Right=?6M   6k   5?  7   5?  3   ? 5?  2   $??1??67    5?  6   ?? 5?  :   $
??auto ?6K   6Z   ?? 5?  :   6N   .+?5?  6   ?? #??[ 6=   $
??auto??6q   $/ )Resource name: MaterialDesignRaisedButton??5?  )   $
??Book??5?  )   $??Center=?5?  )   5?  7   ?? 5?  6   #??[ 6=   $
??auto??6q   $/ )Resource name: MaterialDesignRaisedButton??5?  )   $??Thanh toán??5?  )   $??1??5?  )   $??Center=?5?  )   5?  7   5?  3   5?  /   5?  +   5?  #     5?  "   #??[ 69   $??10q?6l   
 5?  &   ?? 5?  *   #??[ 61   #??Z 5?  %   $??8q?5?  %   $	??192??5?  %   $	??101??5?  %   5?  +    5?  &   ? 5?  *   $	??240??6/   $	??200??6<    5?  .   ?? 5?  2   $
??Auto ?6@   ?? 5?  2   $??* ?6@   .+?5?  .     $??6q?6G   $ 
PrimaryMid=?6S   .??5?  2   ?? $	 
Horizontal=?6=   .+?5?  6   ?? #??[ 6=   #??Z 5?  1   $
??Left=?5?  1   .??5?  :     $ 	ArrowLeft=?6R   $??Right=?6c   5?  7   ?? 5?  6   $??8 0 0 0q?6@   $??Center=?6Q   $??	EDIT USER??6l   6   5?  3   5?  /   ? 5?  .   $??1??63    5?  2   ?? 5?  6   6F   ?? 5?  6   $
??auto ?6D   6T   .+?5?  2   ??  5?  6   ??%w   '??       ?? 5?  :   " ??6@   .?5?  >   ??  ? ??$ 3q?6W   ?? 5?  >    ? ??$
 auto??6V   5?  ;   5?  7   .+?5?  6     $??Tên khách hàng??6J   $ T??6c   $??5q?6l   6y   ?? 5?  6   $??Thời gian nhận phòng??6@   $
??Left=?6\   6y   ?? 5?  6   $??A??6@   $??Right=?6I   6g   ?? 5?  6   $??Thời gian trả phòng??6@   $
??Left=?6[   6x   ?? 5?  6   $??A??6@   $??Right=?6I   6g   ?? 5?  6   $	 
Horizontal=?6A   .+?5?  :   ?? $??Loại phòng??6D   $
??Left=?6V   6s   ?? 5?  :   $??A??6D   $??Right=?6M   6k   5?  7   5?  3   ? 5?  2   $??1??67    5?  6   ?? 5?  :   $
??auto ?6K   6Z   ?? 5?  :   6N   .+?5?  6   ?? #??[ 6=   $
??auto??6q   $/ )Resource name: MaterialDesignRaisedButton??5?  )   $
??Book??5?  )   $??Center=?5   )   5  7   ?? 5  6   #??[ 6=   $
??auto??6q   $/ )Resource name: MaterialDesignRaisedButton??5  )   $??Thanh toán??5  )   $??1??5  )   $??Center=?5  )   5  7   5  3   5	  /   5
  +   5  #   5     ?? 5     $	 
Horizontal=?6)   $	??260??6B   .+?5  "     #??[ 69   $??10q?5  9   
 5  &   ?? 5  *   #??[ 61   #??Z 5  %   $??8q?5  %   $	??192??5  %   $	??101??5  %   5  +    5  &   ? 5  *   $	??240??6/   $	??200??6<    5  .   ?? 5  2   $
??Auto ?6@   ?? 5  2   $??* ?6@   .+?5   .     $??6q?6G   $ 
PrimaryMid=?6S   .??5!  2   ?? $	 
Horizontal=?6=   .+?5"  6   ?? #??[ 6=   #??Z 5#  1   $
??Left=?5$  1   .??5%  :     $ 	ArrowLeft=?6R   $??Right=?6c   5&  7   ?? 5'  6   $??8 0 0 0q?6@   $??Center=?6Q   $??	EDIT USER??6l   6   5(  3   5)  /   ? 5*  .   $??1??63    5+  2   ?? 5,  6   6F   ?? 5-  6   $
??auto ?6D   6T   .+?5/  2   ??  50  6   ??%w   '??       ?? 51  :   " ??6@   .?52  >   ??  ? ??$ 3q?6W   ?? 53  >    ? ??$
 auto??6V   54  ;   55  7   .+?56  6     $??Tên khách hàng??6J   $ T??6c   $??5q?6l   6y   ?? 57  6   $??Thời gian nhận phòng??6@   $
??Left=?6\   6y   ?? 58  6   $??A??6@   $??Right=?6I   6g   ?? 59  6   $??Thời gian trả phòng??6@   $
??Left=?6[   6x   ?? 5:  6   $??A??6@   $??Right=?6I   6g   ?? 5;  6   $	 
Horizontal=?6A   .+?5<  :   ?? $??Loại phòng??6D   $
??Left=?6V   6s   ?? 5=  :   $??A??6D   $??Right=?6M   6k   5>  7   5?  3   ? 5@  2   $??1??67    5A  6   ?? 5B  :   $
??auto ?6K   6Z   ?? 5C  :   6N   .+?5E  6   ?? #??[ 6=   $
??auto??6q   $/ )Resource name: MaterialDesignRaisedButton??5F  )   $
??Book??5G  )   $??Center=?5H  )   5I  7   ?? 5J  6   #??[ 6=   $
??auto??6q   $/ )Resource name: MaterialDesignRaisedButton??5K  )   $??Thanh toán??5L  )   $??1??5M  )   $??Center=?5N  )   5O  7   5P  3   5Q  /   5R  +   5T  #     5V  "   #??[ 69   $??10q?6l   
 5W  &   ?? 5X  *   #??[ 61   #??Z 5Y  %   $??8q?5Z  %   $	??192??5[  %   $	??101??5\  %   5]  +    5_  &   ? 5`  *   $	??240??6/   $	??200??6<    5a  .   ?? 5b  2   $
??Auto ?6@   ?? 5c  2   $??* ?6@   .+?5e  .     $??6q?6G   $ 
PrimaryMid=?6S   .??5f  2   ?? $	 
Horizontal=?6=   .+?5g  6   ?? #??[ 6=   #??Z 5h  1   $
??Left=?5i  1   .??5j  :     $ 	ArrowLeft=?6R   $??Right=?6c   5k  7   ?? 5l  6   $??8 0 0 0q?6@   $??Center=?6Q   $??	EDIT USER??6l   6   5m  3   5n  /   ? 5o  .   $??1??63    5p  2   ?? 5q  6   6F   ?? 5r  6   $
??auto ?6D   6T   .+?5t  2   ??  5u  6   ??%w   '??       ?? 5v  :   " ??6@   .?5w  >   ??  ? ??$ 3q?6W   ?? 5x  >    ? ??$
 auto??6V   5y  ;   5z  7   .+?5{  6     $??Tên khách hàng??6J   $ T??6c   $??5q?6l   6y   ?? 5|  6   $??Thời gian nhận phòng??6@   $
??Left=?6\   6y   ?? 5}  6   $??A??6@   $??Right=?6I   6g   ?? 5~  6   $??Thời gian trả phòng??6@   $
??Left=?6[   6x   ?? 5  6   $??A??6@   $??Right=?6I   6g   ?? 5?  6   $	 
Horizontal=?6A   .+?5?  :   ?? $??Loại phòng??6D   $
??Left=?6V   6s   ?? 5?  :   $??A??6D   $??Right=?6M   6k   5?  7   5?  3   ? 5?  2   $??1??67    5?  6   ?? 5?  :   $
??auto ?6K   6Z   ?? 5?  :   6N   .+?5?  6   ?? #??[ 6=   $
??auto??6q   $/ )Resource name: MaterialDesignRaisedButton??5?  )   $
??Book??5?  )   $??Center=?5?  )   5?  7   ?? 5?  6   #??[ 6=   $
??auto??6q   $/ )Resource name: MaterialDesignRaisedButton??5?  )   $??Thanh toán??5?  )   $??1??5?  )   $??Center=?5?  )   5?  7   5?  3   5?  /   5?  +   5?  #     5?  "   #??[ 69   $??10q?5?  9   
 5?  &   ?? 5?  *   #??[ 61   #??Z 5?  %   $??8q?5?  %   $	??192??5?  %   $	??101??5?  %   5?  +    5?  &   ? 5?  *   $	??240??6/   $	??200??6<    5?  .   ?? 5?  2   $
??Auto ?6@   ?? 5?  2   $??* ?6@   .+?5?  .     $??6q?6G   $ 
PrimaryMid=?6S   .??5?  2   ?? $	 
Horizontal=?6=   .+?5?  6   ?? #??[ 6=   #??Z 5?  1   $
??Left=?5?  1   .??5?  :     $ 	ArrowLeft=?6R   $??Right=?6c   5?  7   ?? 5?  6   $??8 0 0 0q?6@   $??Center=?6Q   $??	EDIT USER??6l   6   5?  3   5?  /   ? 5?  .   $??1??63    5?  2   ?? 5?  6   6F   ?? 5?  6   $
??auto ?6D   6T   .+?5?  2   ??  5?  6   ??%w   '??       ?? 5?  :   " ??6@   .?5?  >   ??  ? ??$ 3q?6W   ?? 5?  >    ? ??$
 auto??6V   5?  ;   5?  7   .+?5?  6     $??Tên khách hàng??6J   $ T??6c   $??5q?6l   6y   ?? 5?  6   $??Thời gian nhận phòng??6@   $
??Left=?6\   6y   ?? 5?  6   $??A??6@   $??Right=?6I   6g   ?? 5?  6   $??Thời gian trả phòng??6@   $
??Left=?6[   6x   ?? 5?  6   $??A??6@   $??Right=?6I   6g   ?? 5?  6   $	 
Horizontal=?6A   .+?5?  :   ?? $??Loại phòng??6D   $
??Left=?6V   6s   ?? 5?  :   $??A??6D   $??Right=?6M   6k   5?  7   5?  3   ? 5?  2   $??1??67    5?  6   ?? 5?  :   $
??auto ?6K   6Z   ?? 5?  :   6N   .+?5?  6   ?? #??[ 6=   $
??auto??6q   $/ )Resource name: MaterialDesignRaisedButton??5?  )   $
??Book??5?  )   $??Center=?5?  )   5?  7   ?? 5?  6   #??[ 6=   $
??auto??6q   $/ )Resource name: MaterialDesignRaisedButton??5?  )   $??Thanh toán??5?  )   $??1??5?  )   $??Center=?5?  )   5?  7   5?  3   5?  /   5?  +   5?  #     5?  "   #??[ 69   $??10q?6l   
 5?  &   ?? 5?  *   #??[ 61   #??Z 5?  %   $??8q?5?  %   $	??192??5?  %   $	??101??5?  %   5?  +    5?  &   ? 5?  *   $	??240??6/   $	??200??6<    5?  .   ?? 5?  2   $
??Auto ?6@   ?? 5?  2   $??* ?6@   .+?5?  .     $??6q?6G   $ 
PrimaryMid=?6S   .??5?  2   ?? $	 
Horizontal=?6=   .+?5?  6   ?? #??[ 6=   #??Z 5?  1   $
??Left=?5?  1   .??5?  :     $ 	ArrowLeft=?6R   $??Right=?6c   5?  7   ?? 5?  6   $??8 0 0 0q?6@   $??Center=?6Q   $??	EDIT USER??6l   6   5?  3   5?  /   ? 5?  .   $??1??63    5?  2   ?? 5?  6   6F   ?? 5?  6   $
??auto ?6D   6T   .+?5?  2   ??  5   6   ??%w   '??       ?? 5  :   " ??6@   .?5  >   ??  ? ??$ 3q?6W   ?? 5  >    ? ??$
 auto??6V   5  ;   5  7   .+?5  6     $??Tên khách hàng??6J   $ T??6c   $??5q?6l   6y   ?? 5  6   $??Thời gian nhận phòng??6@   $
??Left=?6\   6y   ?? 5  6   $??A??6@   $??Right=?6I   6g   ?? 5	  6   $??Thời gian trả phòng??6@   $
??Left=?6[   6x   ?? 5
  6   $??A??6@   $??Right=?6I   6g   ?? 5  6   $	 
Horizontal=?6A   .+?5  :   ?? $??Loại phòng??6D   $
??Left=?6V   6s   ?? 5  :   $??A??6D   $??Right=?6M   6k   5  7   5  3   ? 5  2   $??1??67    5  6   ?? 5  :   $
??auto ?6K   6Z   ?? 5  :   6N   .+?5  6   ?? #??[ 6=   $
??auto??6q   $/ )Resource name: MaterialDesignRaisedButton??5  )   $
??Book??5  )   $??Center=?5  )   5  7   ?? 5  6   #??[ 6=   $
??auto??6q   $/ )Resource name: MaterialDesignRaisedButton??5  )   $??Thanh toán??5  )   $??1??5  )   $??Center=?5  )   5  7   5   3   5!  /   5"  +   5$  #     5&  "   #??[ 69   $??10q?6l   
 5'  &   ?? 5(  *   #??[ 61   #??Z 5)  %   $??8q?5*  %   $	??192??5+  %   $	??101??5,  %   5-  +    5/  &   ? 50  *   $	??240??6/   $	??200??6<    51  .   ?? 52  2   $
??Auto ?6@   ?? 53  2   $??* ?6@   .+?55  .     $??6q?6G   $ 
PrimaryMid=?6S   .??56  2   ?? $	 
Horizontal=?6=   .+?57  6   ?? #??[ 6=   #??Z 58  1   $
??Left=?59  1   .??5:  :     $ 	ArrowLeft=?6R   $??Right=?6c   5;  7   ?? 5<  6   $??8 0 0 0q?6@   $??Center=?6Q   $??	EDIT USER??6l   6   5=  3   5>  /   ? 5?  .   $??1??63    5@  2   ?? 5A  6   6F   ?? 5B  6   $
??auto ?6D   6T   .+?5D  2   ??  5E  6   ??%w   '??       ?? 5F  :   " ??6@   .?5G  >   ??  ? ??$ 3q?6W   ?? 5H  >    ? ??$
 auto??6V   5I  ;   5J  7   .+?5K  6     $??Tên khách hàng??6J   $ T??6c   $??5q?6l   6y   ?? 5L  6   $??Thời gian nhận phòng??6@   $
??Left=?6\   6y   ?? 5M  6   $??A??6@   $??Right=?6I   6g   ?? 5N  6   $??Thời gian trả phòng??6@   $
??Left=?6[   6x   ?? 5O  6   $??A??6@   $??Right=?6I   6g   ?? 5P  6   $	 
Horizontal=?6A   .+?5Q  :   ?? $??Loại phòng??6D   $
??Left=?6V   6s   ?? 5R  :   $??A??6D   $??Right=?6M   6k   5S  7   5T  3   ? 5U  2   $??1??67    5V  6   ?? 5W  :   $
??auto ?6K   6Z   ?? 5X  :   6N   .+?5Z  6   ?? #??[ 6=   $
??auto??6q   $/ )Resource name: MaterialDesignRaisedButton??5[  )   $
??Book??5\  )   $??Center=?5]  )   5^  7   ?? 5_  6   #??[ 6=   $
??auto??6q   $/ )Resource name: MaterialDesignRaisedButton??5`  )   $??Thanh toán??5a  )   $??1??5b  )   $??Center=?5c  )   5d  7   5e  3   5f  /   5g  +   5i  #   5j     ?? 5l     $	 
Horizontal=?6)   $	??260??6B   .+?5m  "     #??[ 69   $??10q?5n  9   
 5o  &   ?? 5p  *   #??[ 61   #??Z 5q  %   $??8q?5r  %   $	??192??5s  %   $	??101??5t  %   5u  +    5w  &   ? 5x  *   $	??240??6/   $	??200??6<    5y  .   ?? 5z  2   $
??Auto ?6@   ?? 5{  2   $??* ?6@   .+?5}  .     $??6q?6G   $ 
PrimaryMid=?6S   .??5~  2   ?? $	 
Horizontal=?6=   .+?5  6   ?? #??[ 6=   #??Z 5?  1   $
??Left=?5?  1   .??5?  :     $ 	ArrowLeft=?6R   $??Right=?6c   5?  7   ?? 5?  6   $??8 0 0 0q?6@   $??Center=?6Q   $??	EDIT USER??6l   6   5?  3   5?  /   ? 5?  .   $??1??63    5?  2   ?? 5?  6   6F   ?? 5?  6   $
??auto ?6D   6T   .+?5?  2   ??  5?  6   ??%w   '??       ?? 5?  :   " ??6@   .?5?  >   ??  ? ??$ 3q?6W   ?? 5?  >    ? ??$
 auto??6V   5?  ;   5?  7   .+?5?  6     $??Tên khách hàng??6J   $ T??6c   $??5q?6l   6y   ?? 5?  6   $??Thời gian nhận phòng??6@   $
??Left=?6\   6y   ?? 5?  6   $??A??6@   $??Right=?6I   6g   ?? 5?  6   $??Thời gian trả phòng??6@   $
??Left=?6[   6x   ?? 5?  6   $??A??6@   $??Right=?6I   6g   ?? 5?  6   $	 
Horizontal=?6A   .+?5?  :   ?? $??Loại phòng??6D   $
??Left=?6V   6s   ?? 5?  :   $??A??6D   $??Right=?6M   6k   5?  7   5?  3   ? 5?  2   $??1??67    5?  6   ?? 5?  :   $
??auto ?6K   6Z   ?? 5?  :   6N   .+?5?  6   ?? #??[ 6=   $
??auto??6q   $/ )Resource name: MaterialDesignRaisedButton??5?  )   $
??Book??5?  )   $??Center=?5?  )   5?  7   ?? 5?  6   #??[ 6=   $
??auto??6q   $/ )Resource name: MaterialDesignRaisedButton??5?  )   $??Thanh toán??5?  )   $??1??5?  )   $??Center=?5?  )   5?  7   5?  3   5?  /   5?  +   5?  #     5?  "   #??[ 69   $??10q?6l   
 5?  &   ?? 5?  *   #??[ 61   #??Z 5?  %   $??8q?5?  %   $	??192??5?  %   $	??101??5?  %   5?  +    5?  &   ? 5?  *   $	??240??6/   $	??200??6<    5?  .   ?? 5?  2   $
??Auto ?6@   ?? 5?  2   $??* ?6@   .+?5?  .     $??6q?6G   $ 
PrimaryMid=?6S   .??5?  2   ?? $	 
Horizontal=?6=   .+?5?  6   ?? #??[ 6=   #??Z 5?  1   $
??Left=?5?  1   .??5?  :     $ 	ArrowLeft=?6R   $??Right=?6c   5?  7   ?? 5?  6   $??8 0 0 0q?6@   $??Center=?6Q   $??	EDIT USER??6l   6   5?  3   5?  /   ? 5?  .   $??1??63    5?  2   ?? 5?  6   6F   ?? 5?  6   $
??auto ?6D   6T   .+?5?  2   ??  5?  6   ??%w   '??       ?? 5?  :   " ??6@   .?5?  >   ??  ? ??$ 3q?6W   ?? 5?  >    ? ??$
 auto??6V   5?  ;   5?  7   .+?5?  6     $??Tên khách hàng??6J   $ T??6c   $??5q?6l   6y   ?? 5?  6   $??Thời gian nhận phòng??6@   $
??Left=?6\   6y   ?? 5?  6   $??A??6@   $??Right=?6I   6g   ?? 5?  6   $??Thời gian trả phòng??6@   $
??Left=?6[   6x   ?? 5?  6   $??A??6@   $??Right=?6I   6g   ?? 5?  6   $	 
Horizontal=?6A   .+?5?  :   ?? $??Loại phòng??6D   $
??Left=?6V   6s   ?? 5?  :   $??A??6D   $??Right=?6M   6k   5?  7   5?  3   ? 5?  2   $??1??67    5?  6   ?? 5?  :   $
??auto ?6K   6Z   ?? 5?  :   6N   .+?5?  6   ?? #??[ 6=   $
??auto??6q   $/ )Resource name: MaterialDesignRaisedButton??5?  )   $
??Book??5?  )   $??Center=?5?  )   5?  7   ?? 5?  6   #??[ 6=   $
??auto??6q   $/ )Resource name: MaterialDesignRaisedButton??5?  )   $??Thanh toán??5?  )   $??1??5?  )   $??Center=?5?  )   5?  7   5?  3   5?  /   5?  +   5?  #     5?  "   #??[ 69   $??10q?5?  9   
 5?  &   ?? 5?  *   #??[ 61   #??Z 5?  %   $??8q?5?  %   $	??192??5?  %   $	??101??5?  %   5   +    5  &   ? 5  *   $	??240??6/   $	??200??6<    5  .   ?? 5  2   $
??Auto ?6@   ?? 5  2   $??* ?6@   .+?5  .     $??6q?6G   $ 
PrimaryMid=?6S   .??5	  2   ?? $	 
Horizontal=?6=   .+?5
  6   ?? #??[ 6=   #??Z 5  1   $
??Left=?5  1   .??5  :     $ 	ArrowLeft=?6R   $??Right=?6c   5  7   ?? 5  6   $??8 0 0 0q?6@   $??Center=?6Q   $??	EDIT USER??6l   6   5  3   5  /   ? 5  .   $??1??63    5  2   ?? 5  6   6F   ?? 5  6   $
??auto ?6D   6T   .+?5  2   ??  5  6   ??%w   '??       ?? 5  :   " ??6@   .?5  >   ??  ? ??$ 3q?6W   ?? 5  >    ? ??$
 auto??6V   5  ;   5  7   .+?5  6     $??Tên khách hàng??6J   $ T??6c   $??5q?6l   6y   ?? 5  6   $??Thời gian nhận phòng??6@   $
??Left=?6\   6y   ?? 5   6   $??A??6@   $??Right=?6I   6g   ?? 5!  6   $??Thời gian trả phòng??6@   $
??Left=?6[   6x   ?? 5"  6   $??A??6@   $??Right=?6I   6g   ?? 5#  6   $	 
Horizontal=?6A   .+?5$  :   ?? $??Loại phòng??6D   $
??Left=?6V   6s   ?? 5%  :   $??A??6D   $??Right=?6M   6k   5&  7   5'  3   ? 5(  2   $??1??67    5)  6   ?? 5*  :   $
??auto ?6K   6Z   ?? 5+  :   6N   .+?5-  6   ?? #??[ 6=   $
??auto??6q   $/ )Resource name: MaterialDesignRaisedButton??5.  )   $
??Book??5/  )   $??Center=?50  )   51  7   ?? 52  6   #??[ 6=   $
??auto??6q   $/ )Resource name: MaterialDesignRaisedButton??53  )   $??Thanh toán??54  )   $??1??55  )   $??Center=?56  )   57  7   58  3   59  /   5:  +   5<  #     5>  "   #??[ 69   $??10q?6l   
 5?  &   ?? 5@  *   #??[ 61   #??Z 5A  %   $??8q?5B  %   $	??192??5C  %   $	??101??5D  %   5E  +    5G  &   ? 5H  *   $	??240??6/   $	??200??6<    5I  .   ?? 5J  2   $
??Auto ?6@   ?? 5K  2   $??* ?6@   .+?5M  .     $??6q?6G   $ 
PrimaryMid=?6S   .??5N  2   ?? $	 
Horizontal=?6=   .+?5O  6   ?? #??[ 6=   #??Z 5P  1   $
??Left=?5Q  1   .??5R  :     $ 	ArrowLeft=?6R   $??Right=?6c   5S  7   ?? 5T  6   $??8 0 0 0q?6@   $??Center=?6Q   $??	EDIT USER??6l   6   5U  3   5V  /   ? 5W  .   $??1??63    5X  2   ?? 5Y  6   6F   ?? 5Z  6   $
??auto ?6D   6T   .+?5\  2   ??  5]  6   ??%w   '??       ?? 5^  :   " ??6@   .?5_  >   ??  ? ??$ 3q?6W   ?? 5`  >    ? ??$
 auto??6V   5a  ;   5b  7   .+?5c  6     $??Tên khách hàng??6J   $ T??6c   $??5q?6l   6y   ?? 5d  6   $??Thời gian nhận phòng??6@   $
??Left=?6\   6y   ?? 5e  6   $??A??6@   $??Right=?6I   6g   ?? 5f  6   $??Thời gian trả phòng??6@   $
??Left=?6[   6x   ?? 5g  6   $??A??6@   $??Right=?6I   6g   ?? 5h  6   $	 
Horizontal=?6A   .+?5i  :   ?? $??Loại phòng??6D   $
??Left=?6V   6s   ?? 5j  :   $??A??6D   $??Right=?6M   6k   5k  7   5l  3   ? 5m  2   $??1??67    5n  6   ?? 5o  :   $
??auto ?6K   6Z   ?? 5p  :   6N   .+?5r  6   ?? #??[ 6=   $
??auto??6q   $/ )Resource name: MaterialDesignRaisedButton??5s  )   $
??Book??5t  )   $??Center=?5u  )   5v  7   ?? 5w  6   #??[ 6=   $
??auto??6q   $/ )Resource name: MaterialDesignRaisedButton??5x  )   $??Thanh toán??5y  )   $??1??5z  )   $??Center=?5{  )   5|  7   5}  3   5~  /   5  +   5?  #     5?  "   #??[ 69   $??10q?6l   
 5?  &   ?? 5?  *   #??[ 61   #??Z 5?  %   $??8q?5?  %   $	??192??5?  %   $	??101??5?  %   5?  +    5?  &   ? 5?  *   $	??240??6/   $	??200??6<    5?  .   ?? 5?  2   $
??Auto ?6@   ?? 5?  2   $??* ?6@   .+?5?  .     $??6q?6G   $ 
PrimaryMid=?6S   .??5?  2   ?? $	 
Horizontal=?6=   .+?5?  6   ?? #??[ 6=   #??Z 5?  1   $
??Left=?5?  1   .??5?  :     $ 	ArrowLeft=?6R   $??Right=?6c   5?  7   ?? 5?  6   $??8 0 0 0q?6@   $??Center=?6Q   $??	EDIT USER??6l   6   5?  3   5?  /   ? 5?  .   $??1??63    5?  2   ?? 5?  6   6F   ?? 5?  6   $
??auto ?6D   6T   .+?5?  2   ??  5?  6   ??%w   '??       ?? 5?  :   " ??6@   .?5?  >   ??  ? ??$ 3q?6W   ?? 5?  >    ? ??$
 auto??6V   5?  ;   5?  7   .+?5?  6     $??Tên khách hàng??6J   $ T??6c   $??5q?6l   6y   ?? 5?  6   $??Thời gian nhận phòng??6@   $
??Left=?6\   6y   ?? 5?  6   $??A??6@   $??Right=?6I   6g   ?? 5?  6   $??Thời gian trả phòng??6@   $
??Left=?6[   6x   ?? 5?  6   $??A??6@   $??Right=?6I   6g   ?? 5?  6   $	 
Horizontal=?6A   .+?5?  :   ?? $??Loại phòng??6D   $
??Left=?6V   6s   ?? 5?  :   $??A??6D   $??Right=?6M   6k   5?  7   5?  3   ? 5?  2   $??1??67    5?  6   ?? 5?  :   $
??auto ?6K   6Z   ?? 5?  :   6N   .+?5?  6   ?? #??[ 6=   $
??auto??6q   $/ )Resource name: MaterialDesignRaisedButton??5?  )   $
??Book??5?  )   $??Center=?5?  )   5?  7   ?? 5?  6   #??[ 6=   $
??auto??6q   $/ )Resource name: MaterialDesignRaisedButton??5?  )   $??Thanh toán??5?  )   $??1??5?  )   $??Center=?5?  )   5?  7   5?  3   5?  /   5?  +   5?  #   5?     5?     5?     5?     5?     5?     5?     5?     