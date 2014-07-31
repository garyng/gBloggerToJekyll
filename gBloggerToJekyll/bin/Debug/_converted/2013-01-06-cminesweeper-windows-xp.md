---
layout: post
title: '[原创][开源][C#] Minesweeper 外挂（Windows XP）'
author: 'Gary Ng'
tags: ['C#','原创','开源']
---

Minesweeper 外挂，99%秒杀！  
 原理我不解释了，都是ReadProcessMemory 为主，然后在用mouse\_event
来移动、点击。  
 只适合Windows XP，因为不同的操作系统下，储存信息的内存地址也不同。  
 这些是Windows XP 下，minesweeper 储存信息的内存地址（16进制）：  
 宽度：0x1005334  
高度：0x1005338  
地雷数量：0x1005330  
地雷基地址：0x1005340  
 每个格子的地址算法是：iCellBaseAddress + (32 \* (y + 1) + (x +
1))；当中x为x坐标，y为y坐标，从0开始。  
  
 【截图】  

[![image](http://lh3.ggpht.com/-bURyqWTMO2Q/UOlapIh1fBI/AAAAAAAADD0/StitogiyahA/image_thumb%25255B2%25255D.png?imgmax=800 "image")](http://lh5.ggpht.com/-qpzE2KQRH6E/UOlaoIhzC_I/AAAAAAAADDs/6ADfBXkXfGQ/s1600-h/image%25255B8%25255D.png)  

[![image](http://lh3.ggpht.com/-hg94QbYgYRg/UOlark6bVgI/AAAAAAAADEA/IowKNcqmrOQ/image_thumb.png?imgmax=800 "image")](http://lh5.ggpht.com/-zV3IZX47zrk/UOlaqGXXNOI/AAAAAAAADD8/nFIwoEGn6zc/s1600-h/image%25255B2%25255D.png)  
  

[![image](http://lh6.ggpht.com/-XWBv6WSAC7U/UOlauA7ApGI/AAAAAAAADEQ/VlOtfCWlQ04/image_thumb%25255B1%25255D.png?imgmax=800 "image")](http://lh3.ggpht.com/-2lUQWvVd-VQ/UOlasmjD69I/AAAAAAAADEM/rEZ3-q6OqUY/s1600-h/image%25255B5%25255D.png)  
  
 【下载地址】（附源码）  

### <https://dl.dropbox.com/u/43619472/%E6%89%B9%E5%A4%84%E7%90%86/C%23/Minesweeper%20Auto%20Solver/Minesweeper%20Auto%20Solver.zip>
