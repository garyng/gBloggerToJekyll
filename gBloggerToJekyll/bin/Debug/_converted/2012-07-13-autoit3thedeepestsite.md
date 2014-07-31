---
layout: post
title: '[网站][AutoIt3] 最深的网页——TheDeepestSite'
author: 'Gary Ng'
tags: ['AutoIt3','原创','教程']
---

前几天看到了这个网站——<http://thedeepestsite.com/>  
 号称是最深的网站，有多深呢？——8公里，是的8000米  
  
  
 这网站是为一个饮水品牌而建的，而地底面往下8公里既是其水的来源  
 能拿来干嘛呢？  
 对！往下滚动到8000米以下！  

这不是一分钟就能做得到的哦！必须要8小时才能做到！（笔者用了9个小时呢。。）  
 每个成功滚到8000米以下的用户，网站就会将其名字刻到石层上，作为鼓励  
  
  
 整个8000米中有7个不同的土层，不同的土层会显示不同的纹理  
 第一层：Turf / Soil / Bedrock  
 第二层：Sandstone  
 第三层：Volcanic Rock  
 第四层：Flysch  
 第五层：Water  
 第六层：Mixed Group  
 第七层：Granite  
  
  
 如果你有Facebook帐号，可以点击网页左下角的“Connect With Facebook”  
 一来能发布当前已经Scroll到多少米了，二来能保存进度  
  
  
 其实真的需要8、9个小时不停的手工滑动么？  
 不必的！  

最近笔者接触了[AutoIt3](http://www.autoitscript.com/site/)，一个很不错的脚本语言，自动化操作交给他保证没问题！  
 所以笔者就动手写了个脚本，用以自动往下滚动网页  

（注：该网页必须是可现实的，而且必须在说有的程序的最上方，也就是必须有焦点的，鼠标也必须在网页内，就像怎样人工Scroll网页一样）  
  
 很简单罢了，就那么几行：  

> WinActivate("Borjomi") ;Activate TheDeepestSite.com Webpage For \$x =
> 0 to 1000000 Step 1 MouseWheel("down", 1000) ;Scrolling Down!
> Sleep(100) ;Sleep for 100 miliseconds Next

这脚本很简单，读者们必须向开启网页，然后再运行这个脚本!  
 啊？不懂怎样运行？  

下载这个已经编译成exe的脚本文件：[ScrollingScript.exe](http://dl.dropbox.com/u/43619472/%E6%89%B9%E5%A4%84%E7%90%86/AutoIt3/ScollingScript.exe)  
 怎样停止呢？  
 只要点击系统栏上的AutoIt图标就好了!（菜单出现需要一段时间）  
 然后好好看着电脑帮你Scroll该网页吧！  
  
  
 这个是笔者自己用脚本，加了点提示信息：  

> \#include  
> \#include  
> \#include Global \$tRECT, \$hFont, \$hOldFont, \$hDC
> HotKeySet("{ESC}", "\_Exit") \$tRECT =
> DllStructCreate(\$tagRect)DllStructSetData(\$tRECT, "Left",
> 50)DllStructSetData(\$tRECT, "Top", 10)DllStructSetData(\$tRECT,
> "Right", 1000)DllStructSetData(\$tRECT, "Bottom", 1000) \$hDC =
> \_WinAPI\_GetDC(0)\$hFont = \_WinAPI\_CreateFont(40, 0, 0, 0, 400,
> False, False, False, \$DEFAULT\_CHARSET, \_ \$OUT\_DEFAULT\_PRECIS,
> \$CLIP\_DEFAULT\_PRECIS, \$DEFAULT\_QUALITY, 0, 'Verdana')\$hOldFont =
> \_WinAPI\_SelectObject(\$hDC, \$hFont) \_WinAPI\_SetTextColor(\$hDC,
> 0x0000FF)\_WinAPI\_SetBkColor(\$hDC, 0x000000); comment next line to
> get black background instead of transparent
> one;\_WinAPI\_SetBkMode(\$hDC, \$TRANSPARENT) WinActivate("Borjomi")
> ;Activate TheDeepestSite.com WebpageDim \$Num = 1299\#include  
> While 1 \$Num = \$Num + 1 \_WinAPI\_DrawText(\$hDC, "Scrolling Down To
> 8000 Meters Below..." & \$Num, \$tRECT, \$DT\_CENTER) if Mod(\$Num,50)
> = 0 then \_ScreenCapture\_Capture(@DesktopDir & "\\Deep\\" & \$Num & "
> - Deep.bmp") \_WinAPI\_DrawText(\$hDC, \$Num \* 1000 & "Scrolls,
> ScreenShot Saved.", \$tRECT, \$DT\_CENTER) ;msgbox (0,"",@DesktopDir &
> "\\Deep\\" & \$Num & " - Deep") EndIf MouseWheel("down", 1000)
> ;Scrolling Down! Sleep(100)WEnd Func \_Exit()
> \_WinAPI\_SelectObject(\$hDC, \$hOldFont)
> \_WinAPI\_DeleteObject(\$hFont) \_WinAPI\_ReleaseDC(0, \$hDC)
> \_WinAPI\_InvalidateRect(0, 0) \$tRECT = 0 ExitEndFunc ;==\>\_Exit

已经编译成exe下载地址：[ScrolingScript -
GaryNg](http://dl.dropbox.com/u/43619472/%E6%89%B9%E5%A4%84%E7%90%86/AutoIt3/ScrollingScript%20-%20GaryNg.exe)  
  
  
 PS:笔者已经到底了～有图为证！  

[![](http://4.bp.blogspot.com/-b1LOxikaiWc/T_-qwJwswyI/AAAAAAAAB0k/EC_VLivrr6A/s1600/2012-07-13+11-55-30_Borjomi+-+360Chrome.png)](http://4.bp.blogspot.com/-b1LOxikaiWc/T_-qwJwswyI/AAAAAAAAB0k/EC_VLivrr6A/s1600/2012-07-13+11-55-30_Borjomi+-+360Chrome.png)

  
  
  
  
  
  
  

