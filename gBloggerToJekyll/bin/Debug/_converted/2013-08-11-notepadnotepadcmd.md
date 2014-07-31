---
layout: post
title: '[原创][教程][Notepad++] 如何在Notepad++内执行命令（CMD、编译程序等等）'
author: 'Gary Ng'
tags: ['Notepad++','原创','教程']
---

今天研究下Notepad++内如何执行某个外部命令（比如说编译某个程序、或者是打开某个文件等等）  
 隆重欢迎Notepad++ 内超级有用的插件——NppExec！（拍手！）  
  

如果你没有Notepad++，请到这边下载<http://notepad-plus-plus.org/download/v6.4.5.html>  

如果你不知道Notepad++，或者是没有听过呢..那我告诉你：Notepad++是一个非常非常非常非常棒的Text
Editor，比一些语言的IDE还好很多，而且支持各种各样的语言，还有语法高亮、多个Theme等等，总之，如果你是写代码的，你不能不试试看！  
  
 首先呢，先下载NppExec这个插件——  
 1、打开Notepad++，然后点击Plugin \> Plugin Manager \> Show Plugin
Manager  

[![image](http://lh3.ggpht.com/-CRu5kXGnq7Y/Ugeo-akCf7I/AAAAAAAADt8/VCgFs81pdyU/image_thumb.png?imgmax=800 "image")](http://lh5.ggpht.com/-kPlsRRQOWD4/Ugeo9o-nIqI/AAAAAAAADt0/eVKH5JDarGc/s1600-h/image%25255B2%25255D.png)  
  
 2、然后勾选NppExec，点击Install  

[![image](http://lh3.ggpht.com/-SIynDSrzhIQ/Ugeo_9nAtVI/AAAAAAAADuM/9eWfJpcDXuY/image_thumb%25255B1%25255D.png?imgmax=800 "image")](http://lh4.ggpht.com/-Gd2PybRPOZ8/Ugeo_Hl8E1I/AAAAAAAADuE/FhTS6ExEKp4/s1600-h/image%25255B5%25255D.png)  
  
 3、然后等待安装完毕，重启Notepad++  
 4、重启Notepad++过后来带Plugins \> 就会看到NppExec了  
 5、点击Plugins \> NppExec \> Execute  

[![image](http://lh4.ggpht.com/--WWiqb08tpE/UgepBMRkqVI/AAAAAAAADuc/eFZNEcQJZKs/image_thumb%25255B2%25255D.png?imgmax=800 "image")](http://lh4.ggpht.com/-JTXp-7XU2U0/UgepAXM3GvI/AAAAAAAADuU/MKFrf9RDkwk/s1600-h/image%25255B8%25255D.png)  
  
 6、这边就可以输入一些命令等等  

[![image](http://lh5.ggpht.com/-iqTMy4EnnXY/UgepCZ-oZcI/AAAAAAAADus/wKLhg1Kpybg/image_thumb%25255B3%25255D.png?imgmax=800 "image")](http://lh3.ggpht.com/-hj-z57m2_Nc/UgepBgHt-7I/AAAAAAAADuk/wKi1zjvEdNs/s1600-h/image%25255B11%25255D.png)  
  
 ————  
 这边奉上我出来的CMD命令：  
  

```
cmd /c if exist "$(FULL_CURRENT_PATH)" ( cmd /c "mshta vbscript:CreateObject("WScript.Shell").Run("$(FULL_CURRENT_PATH)")(window.close)") else ( cmd /c "mshta vbscript:msgbox("File not found. Please save first.")(window.close)")
```

  

  
  

>   
>  功能：  
>  1、以默认的程序开启文件  
>  2、如果还未保存文件则提示用户保存文件

至于各个代码的意思是什么呢，就略略解释下（当然不一定准确）：  

```
if exist "$(FULL_CURRENT_PATH)"
```

就是如果(if)当前文件(\$(FULL\_CURRENT\_PATH))存在就执行此命令：  

```
( cmd /c "mshta vbscript:CreateObject("WScript.Shell").Run("$(FULL_CURRENT_PATH)")(window.close)")
```

mshta 是Microsoft 的 HTML Application （就是类似以IE运行）  
 vbscript 是叫mshta以vbscript的语法解析代码（当然能用JavaScript）  

```
CreateObject("WScript.Shell")
```

是创建一个WScript.Shell 的object  

```
.Run("$(FULL_CURRENT_PATH)")
```

就是直接执行文件，Windows 会自动以默认的程序开启该文件  

```
(window.close)
```

就是关闭mshta的窗口（似乎可以隐藏的，NppExec似乎也能以hide的模式运行，但是为了保险起见，还是放吧！）  
 \*话说mshta.exe 进程似乎会驻留，如果会就加个exit 或者是 taskkill 吧\*  
 如果不存在就执行此命令：  

```
( cmd /c "mshta vbscript:msgbox("File not found. Please save first.")(window.close)")
```

```
vbscript:msgbox("File not found. Please save first.")
```

是弹出MsgBox 提示用户保存文件  
 ————  
 7、写好命令之后，点击Save，储存到一个Script内  

[![image](http://lh3.ggpht.com/-VkguLl4GGXI/UgepDqU5TrI/AAAAAAAADu8/l8wU4LPwjT0/image_thumb%25255B4%25255D.png?imgmax=800 "image")](http://lh5.ggpht.com/-HNFWNgIzRe4/UgepCyT6oQI/AAAAAAAADu0/UoLBBptcZDo/s1600-h/image%25255B14%25255D.png)  
  
 8、Save 好后，到Plugins \> NppExec \> Advanced Options…  

[![image](http://lh5.ggpht.com/-ZYvn8oxDSe0/UgepE0U2wSI/AAAAAAAADvM/_OkseJQAZ1Y/image_thumb%25255B5%25255D.png?imgmax=800 "image")](http://lh6.ggpht.com/--Vmw93E2erk/UgepEGnmk8I/AAAAAAAADvE/ePfVpysSd_8/s1600-h/image%25255B17%25255D.png)  
  
 9、然后选择Place to the Macros submenu  

[![image](http://lh3.ggpht.com/-Gy84JoybipY/UgepGfcK8_I/AAAAAAAADvc/vGxO5NHuoPQ/image_thumb%25255B7%25255D.png?imgmax=800 "image")](http://lh6.ggpht.com/-WFeh_GxIUJ0/UgepFuGgM3I/AAAAAAAADvU/iqumwo0uRdQ/s1600-h/image%25255B23%25255D.png)  
  
 10、在Associated script 那儿选择之前的script，然后在Item name
给个名字，编辑完毕，就可以点击Add/Modify  

[![image](http://lh3.ggpht.com/-QzNAKbb2pmI/UgepJ4fAZ3I/AAAAAAAADvs/BAWWNst5f70/image_thumb%25255B8%25255D.png?imgmax=800 "image")](http://lh5.ggpht.com/-fVndv7MEqgk/UgepJDKJpTI/AAAAAAAADvk/XYJsfnQapQI/s1600-h/image%25255B26%25255D.png)  
  
 11、最后就可以到Macros 那儿直接执行script  

[![image](http://lh3.ggpht.com/-5PEtcRTrp-I/UgepLWs-Q-I/AAAAAAAADv8/OVQiXQKYLPo/image_thumb%25255B9%25255D.png?imgmax=800 "image")](http://lh5.ggpht.com/-rPBgIRxP6Fw/UgepKbjUHMI/AAAAAAAADv0/FAwRLX7U_RQ/s1600-h/image%25255B29%25255D.png)  
  
 完成！  
  
 \*附加：NPP\_SAVE = 保存当前文件\*

