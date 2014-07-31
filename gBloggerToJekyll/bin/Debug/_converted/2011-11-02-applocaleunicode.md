---
layout: post
title: '[转载][软件介绍] Applocale：非Unicode的程式介面乱码解决方法笔记'
author: 'Gary Ng'
tags: ['不能正常显示文字','乱码','电脑不能显示非Unicode字符','转载','软件']
---

[![apa04](http://farm1.static.flickr.com/238/517322504_5f083f3901_o.png)](http://translate.googleusercontent.com/translate_c?act=url&hl=zh-CN&ie=UTF8&prev=_t&rurl=translate.google.com&sl=en&tl=zh-CN&twu=1&u=http://www.flickr.com/photos/esorhjy/517322504/&usg=ALkJrhjbNCkEU1ERrNH8IZDFufP2iDwUaQ)  

以下的叙述，适用于**XP和2003**两种Windows的作业系统，我们在繁体中文XP中Unicode的
AppLocale公用程式
“。今天这篇处理，是我收集整理网路上一些Applocale的介绍与延伸应用，并加入基本操作方式教学的一篇统合笔记。  

-   **微软AppLocale**

微软自己是这么介绍这个工具的：“以的Unicode为基础的平台（例如Windows
XP中）会模拟执行non - Unicode的
（或是非Unicode的登入程式的语言），将登入程式的非Unicode的文字免转换成Unicode的。非Unicode的
（UI）就会显示成乱码...... AppLocale（或**应用区域设置**
）只能暂时解决这些在以UNICODE（UTF - 16）为基础的Windows
XP的系统中执行non - Unicode的登入程式的限制。AppLocale
的Unicode之间进行转换。“  

-   执行Applocale，按下﹝浏览﹞，选择你想要执行的程式。

[![apa01](http://farm1.static.flickr.com/189/517280986_bc90f9ac6f_o.png)](http://translate.googleusercontent.com/translate_c?act=url&hl=zh-CN&ie=UTF8&prev=_t&rurl=translate.google.com&sl=en&tl=zh-CN&twu=1&u=http://www.flickr.com/photos/esorhjy/517280986/&usg=ALkJrhjHN1vFw5lFiXCMzpyX7qiDWvQyrw)  

-   选择该程式的语言。

[![apa02](http://farm1.static.flickr.com/253/517306837_89c900d6c6_o.png)](http://translate.googleusercontent.com/translate_c?act=url&hl=zh-CN&ie=UTF8&prev=_t&rurl=translate.google.com&sl=en&tl=zh-CN&twu=1&u=http://www.flickr.com/photos/esorhjy/517306837/&usg=ALkJrhjC5Iov8wVj_qL2pNbLJr5HF8mNyQ)  

-   

[![apa03](http://farm1.static.flickr.com/227/517280714_5ac5338d3b_o.png)](http://translate.googleusercontent.com/translate_c?act=url&hl=zh-CN&ie=UTF8&prev=_t&rurl=translate.google.com&sl=en&tl=zh-CN&twu=1&u=http://www.flickr.com/photos/esorhjy/517280714/&usg=ALkJrhiF9lfaI0nxoAlxrM3Kp4RrC6hO2A)  

-   **Applocale的问题**

在使用过Applocale后，可能会影响到以后的某些程式安装，具体情形是“使用过AppLocale后，”C：\\
WINDOWS \\
AppPatch文件“这个免夹可能会出现”AppLoc.tmp“这个档案此档案可能会造成的“Windows
Installer”运作错误，不但安装程式的画面变成乱码，还会随着安装程序，把乱码带入注册表，造成许多问题，这应该算是AppLocale的  

-   **pApplocale：Applocale非官方修正版**

Applocale的BUG
**作者为Piaip，**以下引自其原文介绍**：“微软AppLocale，出名的切换语系工具，不过栭有很多问题，包括你装了后MSI安装程序都会用上次设定的语系跑等等我修正了AppLocale，改为[pAppLocale](http://ntu.csie.org/~piaip/papploc.msi)
，除了修正错误外还让你建捷径后执行的程式不会再跑对话窗韩你。“**  

-   pApplocale作者网页： [​​http://ntu.csie.org/〜piaip /
    index.html的](http://translate.googleusercontent.com/translate_c?act=url&hl=zh-CN&ie=UTF8&prev=_t&rurl=translate.google.com&sl=en&tl=zh-CN&twu=1&u=http://ntu.csie.org/~piaip/index.html&usg=ALkJrhjoJ5cw1d_8gkj0sl2-qU9sxp6tIQ)
-   pApplocale下载点： [http://ntu.csie.org/〜piaip /
    papploc.msi](http://ntu.csie.org/~piaip/papploc.msi)
-   其它[下载点一](http://translate.googleusercontent.com/translate_c?act=url&hl=zh-CN&ie=UTF8&prev=_t&rurl=translate.google.com&sl=en&tl=zh-CN&twu=1&u=http://www.badongo.com/file/3208040&usg=ALkJrhibSdDHpvLSsaLriV3itYsJI587ug)
    ，
    [下载点二](http://translate.googleusercontent.com/translate_c?act=url&hl=zh-CN&ie=UTF8&prev=_t&rurl=translate.google.com&sl=en&tl=zh-CN&twu=1&u=http://z32.zupload.com/download.php%3Ffile%3Dgetfile%26filepath%3D32899&usg=ALkJrhi7CawMRp2gHJRw0zoDJUCUo9A_Sw)

安装过程与执行方式都和原本无异。  

-   **在滑鼠【快速选单】中加入Applocale快捷选项对话**

**————————以下转贴自ZEGii P2PZONE。**  
 使用AppLocale时每次都要按开始\>程式集\>的Microsoft AppLocale\>
AppLocale.exe  
须时费久〜因此小弟将之简单整合于右键内，  
只须执行以下章档叧可以各来源如下：  
 **日本语执行的。reg**  
 **代码：**  

> Windows注册表编辑器5.00版  
> [HKEY\_CLASSES\_ROOT \\ exefile \\ SHELL \\日本语执行]  
> [HKEY\_CLASSES\_ROOT \\ exefile \\ SHELL \\日本语执行\\命令]  
> @ =“C：\\ \\ WINDOWS \\ \\ AppPatch文件\\ \\ AppLoc.exe \\”％1 \\“\\”/
> L0411 \\“”

**简体中文执行的。reg**  
 **代码：**  

> Windows注册表编辑器5.00版  
> [HKEY\_CLASSES\_ROOT \\ exefile \\ SHELL \\简体中文执行]  
> [HKEY\_CLASSES\_ROOT \\ exefile \\ SHELL \\简体中文执行\\命令]  
> @ =“C：\\ \\ WINDOWS \\ \\ AppPatch文件\\ \\ AppLoc.exe \\”％1 \\“\\”/
> L0804 \\“”

**繁体中文执行的。reg**  
 **代码：**  

> Windows注册表编辑器5.00版  
> [HKEY\_CLASSES\_ROOT \\ exefile \\ SHELL \\繁体中文执行]  
> [HKEY\_CLASSES\_ROOT \\ exefile \\ SHELL \\繁体中文执行\\命令]  
> @ =“C：\\ \\ WINDOWS \\ \\ AppPatch文件\\ \\ AppLoc.exe \\”％1 \\“\\”/
> L0404 \\“”

**韩国语执行的。reg**  
 **代码：**  

> Windows注册表编辑器5.00版  
> [HKEY\_CLASSES\_ROOT \\ exefile \\ SHELL \\韩国语执行]  
> [HKEY\_CLASSES\_ROOT \\ exefile \\ SHELL \\韩国语执行\\命令]  
> @ =“C：\\ \\ WINDOWS \\ \\ AppPatch文件\\ \\ AppLoc.exe \\”％1 \\“\\”/
> L0412 \\“”

**——————以上欢迎转贴，请注明原创来自ZEGii @
P2PZONE，并为处理保持原的整性**

