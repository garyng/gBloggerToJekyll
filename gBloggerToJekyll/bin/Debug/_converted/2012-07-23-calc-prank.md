---
layout: post
title: '[原创][C] 恶搞Windows 计算器——Windows Calculator Prank'
author: 'Gary Ng'
tags: ['C','Prank','原创']
---

好久不见！最近考试啦，不得空写文章。近几天，在一位编程大大的教导下（Gnix），完成了我人生第一个DLL。  

过程中遇到好多困难，比如怎样枚举子窗口、设置文本等等，最后还是一一解决了  
 学到了个新的API —— EnumChildWindows  

函数原型（摘自[MSDN](http://msdn.microsoft.com/en-us/library/windows/desktop/ms633494(v=vs.85).aspx)）：  

    BOOL WINAPI EnumChildWindows(
      __in_opt  HWND hWndParent,
      __in      WNDENUMPROC lpEnumFunc,
      __in      LPARAM lParam
    );

  
 EnumChildWindows 是个回调函数，什么来的？  
  

就是个API，每当有事件发生时（这里是找到了一个子窗口），就会调用该函数，lpEnumFunc就是要指向函数地址。  
  
 而回调函数是长这么一个样的：  

    BOOL CALLBACK EnumChildProc(
      __in  HWND hwnd,
      __in  LPARAM lParam
    );

  
 hwnd就是控件的句柄啦！  
  
 在Code::Blocks
内写DLL时发现一个问题，但是还是被解决了——那就是DLL\_PROCESS\_ATTACH等事件竟然没被激活  
  
 Google了下，找到了解决办法，就是在前头加上 extern "C"  
  
 真是的，废话说太多了啊，跑题了。。  
  

**注意：此DLL在32bit的环境下编译，与64bit的机器不兼容！还有此DLL对Windows
XP 下的计算器无效**（怀疑Windows XP的Calculator
的按钮文本是画上去的。。）  
  
 还需要准备一个DLL injector，推荐的有Winject，但是我用了Gnix写的Dll
Injector\~  
  
 先发个在Windows 7 下测试的截图  
  

[![untitled](http://lh4.ggpht.com/-acnkkKruaDw/UA1g5GfO1ZI/AAAAAAAAB04/JpMvEZfT6ys/untitled_thumb%25255B1%25255D.png?imgmax=800 "untitled")](http://lh4.ggpht.com/-C0q0yrRpq3k/UA1g3tagHhI/AAAAAAAAB0w/Mf-kJAs6xOY/s1600-h/untitled%25255B1%25255D.png)  
  
 按钮都成了自己设置的文字啦哈哈！  
  
 好啦！  
  
 **【下载地址】**  
  
 Calculator Prank DLL Download Link: [Calculator
Prank.dll](http://dl.dropbox.com/u/43619472/%E6%89%B9%E5%A4%84%E7%90%86/C%20and%20C%2B%2B/CalcPrank/Calculator%20Prank.dll)  
  
 Winject Download Link:
[Winject.exe](http://dl.dropbox.com/u/43619472/OtherSoft/Winject.exe)  
  
 Gnix 写的DLL injector: [Dll Injector By
Gnix.exe](http://dl.dropbox.com/u/43619472/OtherSoft/Dll%20Injector%20By%20Gnix.exe)  
  
  
  
 来个视频呗！  
  

[![](http://lh6.ggpht.com/-G3uZxNX5dYo/UA1g5mFCzwI/AAAAAAAAB08/E9CegM6qyuE/video7d0cd2b3182f%25255B2%25255D.jpg?imgmax=800)](http://www.youtube.com/watch?v=IuORJryequw&feature=youtube_gdata_player)

