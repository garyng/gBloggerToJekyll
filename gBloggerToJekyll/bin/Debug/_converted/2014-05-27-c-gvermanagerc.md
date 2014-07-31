---
layout: post
title: '[开源][C#] gVerManager——自动增递你的C#程序版本'
author: 'Gary Ng'
tags: ['C#','原创','教程']
---

gVerManager 一个非常简单，用来AssemblyInfo.cs 之中的[assembly:
AssemblyVersion(“XX”)]项  
 开源版本，源代码：<https://github.com/garyng/gVerManager>  
 \*需要.net 3.5  

# 【使用教程】

1、到我的github上下载整个repo  

[![image](http://lh6.ggpht.com/-vPZCVwv22UQ/U4SEDxEqUYI/AAAAAAAAG9s/hjMDJhqAu0k/image_thumb%25255B4%25255D.png?imgmax=800 "image")](http://lh6.ggpht.com/-4yWRe6iZzzQ/U4SEC7Yya2I/AAAAAAAAG9k/02Qj_i0JSko/s1600-h/image%25255B6%25255D.png)  
 2、打开zip文件  
 进入gVerManager-master.zip\\gVerManager-master\\gVerManager\\bin\\Debug
你会看到gVerManager.exe 的文件  
 把它copy 出来  

[![image](http://lh3.ggpht.com/-1XMVPmNqkBQ/U4SEGCYWurI/AAAAAAAAG98/kLWklfV0W9Q/image_thumb%25255B5%25255D.png?imgmax=800 "image")](http://lh4.ggpht.com/-4lURtnIf3RI/U4SEExI4wYI/AAAAAAAAG90/J_k604IWhgA/s1600-h/image%25255B9%25255D.png)  
  
 3、然后打开你的C\# Project  
 放到你的Debug 目录下  

[![image](http://lh5.ggpht.com/-yswMDj3kMGw/U4SEHwJxVuI/AAAAAAAAG-M/tdIs15zR510/image_thumb%25255B6%25255D.png?imgmax=800 "image")](http://lh5.ggpht.com/-w4V4A4pu2n0/U4SEHGwg9rI/AAAAAAAAG-E/4U0Y0v-_--A/s1600-h/image%25255B12%25255D.png)  
 4、Visual Studio 打开你的Solution  
 打开Properties 下的 AssemblyInfo.cs  

[![image](http://lh4.ggpht.com/-KzpA-gRrb74/U4SEJp6RG-I/AAAAAAAAG-c/qNsxzrUZoaI/image_thumb%25255B12%25255D.png?imgmax=800 "image")](http://lh5.ggpht.com/-JeJw6iQ0K-A/U4SEIzp9OJI/AAAAAAAAG-U/-umdnk_FiEg/s1600-h/image%25255B16%25255D.png)  
  
 5、把[assembly: AssemblyFileVersion("1.0.0.0")]给注释掉  
 然后保存  

[![image](http://lh5.ggpht.com/-_vRWy-TyoLg/U4SELEx8hdI/AAAAAAAAG-s/yajZTsLKJ0E/image_thumb%25255B13%25255D.png?imgmax=800 "image")](http://lh3.ggpht.com/-EIM7WjLg70k/U4SEKRhlB5I/AAAAAAAAG-k/oE_Rlgl5ptA/s1600-h/image%25255B19%25255D.png)  
  
 6、在Solution Explorer 内右键你的Project  
 点击Properties  

[![image](http://lh5.ggpht.com/-uM2K3F-sMr0/U4SEM7uBlYI/AAAAAAAAG-8/bJM4fQvTAQs/image_thumb%25255B14%25255D.png?imgmax=800 "image")](http://lh6.ggpht.com/-df-pBojoCpE/U4SEMKf9OsI/AAAAAAAAG-0/C4VD1DMRxd8/s1600-h/image%25255B22%25255D.png)  
  
 7、然后点击Build Events  
 在Pre-build event command line 之中输入：  
 gVerManager.exe -f "\$(ProjectDir)Properties\\AssemblyInfo.cs"  

[![image](http://lh6.ggpht.com/-Tu2-yvZG7Yo/U4SEOldPukI/AAAAAAAAG_M/4MU_OSfYVSg/image_thumb%25255B15%25255D.png?imgmax=800 "image")](http://lh3.ggpht.com/-pK4ukXJutPI/U4SENgdEAFI/AAAAAAAAG_E/RlRO7hR7rB4/s1600-h/image%25255B25%25255D.png)  
  
 8、F6试试编译  
 然后就可以查看效果了！  

[![image](http://lh3.ggpht.com/-jsV_ipY4_tw/U4SEQE62z8I/AAAAAAAAG_c/A4jG-mgTGPE/image_thumb%25255B16%25255D.png?imgmax=800 "image")](http://lh6.ggpht.com/-4Aj8z_vdKEU/U4SEPS6AZeI/AAAAAAAAG_U/jPndWoIJP1Q/s1600-h/image%25255B28%25255D.png)  
  
  
 注：久违的更新！xD

