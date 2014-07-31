---
layout: post
title: '[转载][电脑小窍门] 如何自由修改 Windows 2000/XP 中的 Service Pack 版本号'
author: 'Gary Ng'
tags: ['SP1','Sp2','SP3','修改Service Pack 版本号','教程','转载']
---

有时我们需要自己修改当前 Windows 2000/XP 系统中已安装的 Service Pack
版本号。例如我们需要重新安装 Windows XP 的 Service Pack
2，却发现控制面板的【系统】属性中显示的 Service Pack
版本因系统出错显示成了“Service Pack
3”或更高。这时系统就將因为当前系统的版本号比要安装的版本号高而拒绝安装。  
  
  
  

这时，我们可以打开注册表编辑器（Regedit--查看[【转载】【电脑小窍门】如何修改注册表](http://garyngzhongbo.blogspot.com/2011/10/blog-post_15.html)）  
 HKEY\_LOCAL\_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\Windows，找到
DWORD 值 CSDVerision。这个值如果是十六进制的 100、十进制的
256，系统显示的 Service Pack 版本就是 SP1，如果是十六进制的
200、十进制的 512，系统显示的 Service Pack 版本就是
SP2，如果是十六进制的 300、十进制的 768，系统显示的 Service Pack
版本就是 SP3...... 依次类推。我们将其修改为正确的版本号即可。  
  
 修改后，控制面板的【系统】属性以及“关于
Windows”对话框中的版本号就修改过了。但此方法只适用于修复正确的 Service
Pack 版本，假设 Windows XP 只安装了 SP1，通过这样修改把系统版本号改为
SP2 达到“升级”的目的是没有任何意义的，因为系统实际并没有升级
