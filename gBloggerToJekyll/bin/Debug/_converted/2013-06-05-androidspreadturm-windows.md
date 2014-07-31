---
layout: post
title: '[教程][Android] 中国机SpreadTurm Windows 驱动 + 恢复原厂设置'
author: 'Gary Ng'
tags: ['Android','教程']
---

家里某架中国机（俗称“山寨机”）的screen lock pattern
忘了，折腾了一整个上午，才搞到factory reset。  
 刚开始发现Power button + Vol up 的菜单内竟然没有factory
reset，然后不小心发现到了可以进fastboot mode。（Power button + home
button）。  
 fastboot 然我想到了adb 和 fastboot 的 tools，
下载了（这边：<http://www.mediafire.com/download/x6zgi5zga0fug0w/adb_fastboot.zip>），却不知道要怎么做（悲剧的中国机，啥教程都没有..）  
 结果因此折腾了N个小时..  
 只找到了适合的driver，下载地址：  

<http://www.mediafire.com/download/wdx8bhlpef3oj9w/SCI-android-usb-driver-jungo-v4.zip>  
 最后，搜寻无果.. adb 因为没有开usb debugging mode 也不能用..  
 剩下fastboot了… 心血来潮打进了fastboot help，慢慢看自带的帮助文件..  
 突然发现到了这个：  

[![image](http://lh3.ggpht.com/-8nrTlBRSZXM/Ua7HJacn24I/AAAAAAAADbc/4jAjQr8CMkY/image_thumb.png?imgmax=800 "image")](http://lh3.ggpht.com/-PwfYNyX47BA/Ua7HHiWeWLI/AAAAAAAADbU/sreq2Nx2eBE/s1600-h/image%25255B2%25255D.png)  
  
 这…这…不是factory reset 么？  
 兴奋的打入了fastboot –w  
 然后fastboot reboot  
 娃哈哈哈哈，成功了！  
 （对不起，没截到图，太兴奋了）  
  
 特此留下这篇文章…造福人群 ![Open-mouthed
smile](http://lh4.ggpht.com/-cgW6JGzr8y8/Ua7HJkJTW0I/AAAAAAAADbg/9qLvW6MxmSI/wlEmoticon-openmouthedsmile%25255B2%25255D.png?imgmax=800)
