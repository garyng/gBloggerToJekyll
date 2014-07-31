---
layout: post
title: '[教程][VS插件] Visual Studio Copy Code As Html 插件-测试'
author: 'Gary Ng'
tags: ['VS','插件','教程']
---

之前测试的<http://syntaxhighlight.in/>还是不能用在我的blogger
动态模板上，纠结啊。。  
  
 今天找到了这个VS2010 的插件（不知道之前的版本能不能用，没试过）：  

<http://blogs.msdn.com/b/kirillosenkov/archive/2010/06/07/copy-code-in-html-format-with-visual-studio-2010.aspx>  
  
 这个插件叫“Copy Code As HTML”，是专门为这个插件——VS2010 Productivity
Power Tools 写的，所以只要安装到这里下载安装VS2010 Productivity Power
Tools  
 就可以用Copy Code As Html 了：  

<http://visualstudiogallery.msdn.microsoft.com/d0d33361-18e2-46c0-8ff2-4adea1e34fef/>  
  
  
 安装后，可以直接开启VS2010的project 文件，然后选者一段代码，左键\>Copy
就好了！  

[![image](http://lh3.ggpht.com/-vJOOfvfMYEI/UZ4pcviOdPI/AAAAAAAADYk/upmH8qWb6TM/image_thumb%25255B7%25255D.png?imgmax=800 "image")](http://lh4.ggpht.com/-mGI8DE3XmKA/UZ4pb_zCVxI/AAAAAAAADYg/2txwhGm1m68/s1600-h/image%25255B10%25255D.png)  
  
 如果你是用Windows Live Writer
写部落格的，要贴上已经高亮了的代码的话，必须按下Ctrl + Shift + V
(Special Paste) 或者右键\>Special Paste  

[![image](http://lh3.ggpht.com/-FM-bN0ON0-w/UZ4pdtFS8jI/AAAAAAAADY0/pjGnt77N8EQ/image_thumb%25255B2%25255D.png?imgmax=800 "image")](http://lh6.ggpht.com/-XK_FnV_cJlA/UZ4pc8dcRAI/AAAAAAAADYs/KPVU97ktIjc/s1600-h/image%25255B6%25255D.png)  
  
 然后就会出现这个窗口，选择Keep Formating 就好了！  

[![image](http://lh6.ggpht.com/-dSaDXe-Asew/UZ4pek2ReEI/AAAAAAAADZI/MBVWIAqfnnc/image_thumb%25255B8%25255D.png?imgmax=800 "image")](http://lh3.ggpht.com/-L1MPbourgVU/UZ4peCCI9GI/AAAAAAAADY8/YkyRxDH20oE/s1600-h/image%25255B13%25255D.png)  
  
 可是有时候在Windows Live Write 内会出现问题  
 当你重Edit 切换到Preview 在切换回Edit 时，整个代码就乱掉了…  
 Windows Live Writer 下测试：  
public Size BoxSize
{
    get
    {
        return m\_szBox;
    }
    set
    {
        m\_szBox = value;
    }
}
  
public Size PicBoxSize
{
    get
    {
        return m\_szPic;
    }
    set
    {
        m\_szPic = value;
    }
}
  
当然你可以到Tools\>Option… 的Productivity Power Tools 设置。
[![image](http://lh6.ggpht.com/--nzBfuGpCNA/UZ4pfzjABRI/AAAAAAAADZY/s6Y8lkXarPA/image_thumb%25255B1%25255D.png?imgmax=800 "image")](http://lh4.ggpht.com/-hXZEUYu-VjQ/UZ4pfHpBXpI/AAAAAAAADZQ/3oEJF3n1iBc/s1600-h/image%25255B3%25255D.png)
