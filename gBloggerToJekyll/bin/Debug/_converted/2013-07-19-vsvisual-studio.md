---
layout: post
title: '[VS] 如何修改Visual Studio 启动画面的版权信息'
author: 'Gary Ng'
tags: ['VS','教程']
---

找了很久才找到的  
 特此在这儿分享。  
  
 32位 修改一下注册表：  

HKEY\_LOCAL\_MACHINE\\SOFTWARE\\Microsoft\\VisualStudio\\10.0\\Registration\\UserName  
 HKEY\_LOCAL\_MACHINE\\SOFTWARE\\Microsoft\\Windows
NT\\CurrentVersion\\RegisteredOrganization  
  
 如果还是没有更改的话  
 切换到VS的目录  
 打开CMD  
 输入devenv.exe /setup
