   M S B A M L   `   `   `  ????I  EQuanLyKhachSan, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:QuanLyKhachSanQuanLyKhachSan  5          QuanLyKhachSan.PageUser   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      _ [MaterialDesignThemes.Wpf, Version=4.2.1.2, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      (localclr-namespace:QuanLyKhachSan  5       
  MainVM  ? DataContext#  [  5       N? Title$ PageUser??5
      .??5      #  MaterialDesignThemes.Wpf.Card  .??5   
   ?  ? ColumnDefinitions 5      ?? 5      $??90 ?6#   60   ?? 5      6%   .+?5      ? $??1??6    5      ?? 5      $
??0.5* ?6'   66   ?? 5      $??1* ?6'   64   .+?5      ?? $??Center=?6   .+?5      ?? $$??./Source/Image/pngwing.com.png??6   $	??150??5      $??0 50 0 0q?5      6,   ?? 5      $	??100??6    ? ToolTip$ Change??5      $??Change??5      $??0 20 0 0q?5      
????? ?
?????? $??0q?5!      5"      5#      ?? 5$      $??1??6   $??30 0 0 0q?5%      .+?5&      ?? $??0 50 0 0q?6!    ? 	Resources 5'       ?? 
TargetType ?? Property ?? Value??%?  '??       '?? H     '?? )    ?? 5(      " ??6$   .?5)   "   ??  ? ??$ 10q?6;   5*      ?? 5+      " ??6$   .?5,   "   ??  ? ??$	 300??6:   ?? 5-   "    ? ??$ 0q?6D   ?? 5.   "    ? ??$ Stretch=?6H   ?? 5/   "    ? ??$ 16(?6=   ?? 50   "    ? ??$ Center=?6F   51      ?? 52      " ??6$   .?53   "   ??  ? ??$ 16(?6=   ?? 54   "    ? ??$	 150??6:   55      56      .+?57      ??  ?? Orientation$ 
Horizontal=?6%   .+?58      ?? $??	Họ tên??6$   67   ?? 59      $??Phan Chí Bảo??6&   6<   5:      ?? 5;      $ 
Horizontal=?6%   .+?5<      ?? $??
Ngày sinh??6$   6:   ?? 5=      $??
02/07/2002??6&   6:   5>      ?? 5?      $ 
Horizontal=?6%   .+?5@      ?? $??Giới tính??6$   6:   ?? 5A      $	??Nam??6&   63   5B      ?? 5C      $ 
Horizontal=?6%   .+?5D      ?? $??Số điện thoại??6$   6>   ?? 5E      $??
0378990175??6&   6:   5F      ?? 5G      $ 
Horizontal=?6%   .+?5H      ?? $??Địa chỉ??6$   68   ?? 5I      $T??N032/TL, ấp Thạnh Lễ, xã Bảo Thuận, huyện Ba Tri, tỉnh Bến Tre??6&   	 ?? TextWrapping$
	 Wrap=?5J      64   5K      ?? 5L      $ 
Horizontal=?6%   .+?5M      ?? $??Chức vụ??6$   68   ?? 5N      $??Giám đốc??6&   68   5O      5P      ?? 5Q      $ 
Horizontal=?6!   $??Right=?6:   .+?5R      ?? $??Logout??6!   $
??auto??5S   !   $??20 20 50 20q?5T   !   $??Center=?5U   !   ??5V   !   ?? *LogoutUserCommand+6I   ?? 5W      $??Save change??6!   $
??auto??5X   !   $??20 20 50 20q?5Y   !   $??Center=?5Z   !   6E   5[      5\      5]      5^      5_      5`      