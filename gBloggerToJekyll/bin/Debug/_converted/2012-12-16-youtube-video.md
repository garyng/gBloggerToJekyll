---
layout: post
title: '[原创][教程] 获取YouTube 的Video下载链接的方法'
author: 'Gary Ng'
tags: ['Youtube','Youtube Downloader','原创','教程']
---

这是一个比较简短的文章，略略的介绍了YouTube Video Grabber
如何获取YouTube 视频的下载地址等等。  
  
 **【写在前面的话】**  
 这篇文章，只是提出笔者用来实现YouTube Video Grabber
的思路，不提供代码，组要的原因是让读者动动脑，动动手，这样才能彻底的了解。  
 还有就是，这个方法不是永远可行的，如果有天YouTube
突然改版了，那这个方法就很可能失效，但是都几乎相同。  
  
 **【原理解密】**  
 0、获取视频的链接  
 这个不用说，这是一定要的，没有视频链接，要怎么下载？  
  
 1、获取HTML代码  
 获取视频的下载地址呢，首先就必须下载该网页的HTML源代码，这里就以Google
Chrome 中直接显示网页的源代码。  
  
 2、获取swf变量  
  
 有了视频的HTML代码，万事好办了！  

YouTube呢，它把所有的视频的链接都储存在这个变量之中，只要找到该变量，就能逐一分析出各个不同分辨率的视频下载链接  
 只要在HTML代码中搜索var swf = 就可以看到了：  

[![image](http://lh4.ggpht.com/-_Sxnb6b8M4c/UM3YgT9hkfI/AAAAAAAAC_8/KOmlyJBQJrM/image_thumb.png?imgmax=800 "image")](http://lh5.ggpht.com/-3ah6OC5q6u8/UM3Yfaw28nI/AAAAAAAAC_0/zXGTtIlmEoU/s1600-h/image%25255B2%25255D.png)  
 从var swf =  一直复制到
document.getElementById('watch7-player').innerHTML = swf;  

[![image](http://lh5.ggpht.com/-DOSSrrq6J78/UM3YiBvf_mI/AAAAAAAADAI/BRH4hdP2Hz8/image_thumb%25255B1%25255D.png?imgmax=800 "image")](http://lh5.ggpht.com/-QXQ_2ROdM1U/UM3YhFJ7kxI/AAAAAAAADAA/GgL1NpXMRi0/s1600-h/image%25255B5%25255D.png)  
  

复制到任何一个编辑器（笔者用Notepad++），当然里面还有很多我们不需要的东西。  
  
 4、URL解码(URLDecode)  

复制后，读者们后看到很多类似%2310的字眼，YouTube可能是为了隐藏视频的下载链接，把他们给“编码（Encode）”了，但是，不用怕，这种加密的方法是“可逆”的，就是所有“编码”，就有“解码（Decode）”，就如有“加密（Encrypt）”，就有“解密（Decrypt）”般。  
 如何解码呢？用特定的解码器！  
 而解码器，笔者已经为大家准备了！  

笔者为了大家的方便，做了个比较容易记的域名：[**http://urlendecoder.tk/**](http://urlendecoder.tk/)  
 打开上述网页，然后将复制过来的贴到该框框上，然后点击“Decode” **3次**  

[![image](http://lh6.ggpht.com/-QAgksqCn70Y/UM3YkDN8PrI/AAAAAAAADAc/M8GUJaUXRUs/image_thumb%25255B4%25255D.png?imgmax=800 "image")](http://lh3.ggpht.com/-9RniByKvFP4/UM3YjJShVtI/AAAAAAAADAU/kWQbNh9FgkE/s1600-h/image%25255B10%25255D.png)  
 过后，再次将已经解码了的内容复制到编辑器。  
  
 5、分析下载地址  
 解码后，就可以开始分析下载链接啦！  

其实，我们之前复制的代码之中，还掺杂着很多与该视频不相关的资料，我们主要的目的是分析出下载链接。  
 首先，所有的下载链接都是在url\_encoded\_fmt\_stream\_map
后面的，所以我们要做的是：在文本编辑器中搜索url\_encoded\_fmt\_stream\_map，然后去掉之前的部分。  

[![image](http://lh5.ggpht.com/-xxkUtwUecss/UM3Ymaiut_I/AAAAAAAADAo/bRO_vGYRpCE/image_thumb%25255B5%25255D.png?imgmax=800 "image")](http://lh5.ggpht.com/-LJaCeqxMXoE/UM3YlcIGuLI/AAAAAAAADAg/JXe5YVjdUC4/s1600-h/image%25255B13%25255D.png)  
  
 各位读者，应该看出什么了吧？之中，所有的视频链接都是以&url=
分开的，所以我们只要分辨每个&url=，然后把它们分开，视频的下载链接就出来了！  

[![image](http://lh3.ggpht.com/-PG2DZFQXPAo/UM3YopQ3qVI/AAAAAAAADA4/2SYNhaGtiz8/image_thumb%25255B6%25255D.png?imgmax=800 "image")](http://lh5.ggpht.com/-hBgsvc5lSDQ/UM3YnfYyZoI/AAAAAAAADA0/oxxJe2qbi7o/s1600-h/image%25255B16%25255D.png)  
  
 把他们一个个复制出来：  

[![image](http://lh3.ggpht.com/-SgqgwNlBNoQ/UM3YrD953WI/AAAAAAAADBM/vw2k0EUZWoQ/image_thumb%25255B10%25255D.png?imgmax=800 "image")](http://lh5.ggpht.com/-Ql2AhaPd2q8/UM3YpZd6YAI/AAAAAAAADBA/pUMup-hSEas/s1600-h/image%25255B24%25255D.png)  
  

注意：最后一个下载链接一直到\\u0026为止（就是说，下载链接不包括\\u0026和\\u0026以后的字串）  
  

[![image](http://lh6.ggpht.com/-unk_pjseAwY/UM3YtG-gimI/AAAAAAAADBY/QBeDA-c7m1I/image_thumb%25255B7%25255D.png?imgmax=800 "image")](http://lh5.ggpht.com/-eXU_NWorM2s/UM3YsHeL0RI/AAAAAAAADBU/vzKMVZOS7bY/s1600-h/image%25255B19%25255D.png)  
  
 6、替换sig  
 最后一个步骤了，YouTube
很“顽皮”地把最重要的signature换成了sig，所以如果不直接替换回去的话，就不能下载视频了。  

[![image](http://lh3.ggpht.com/-mBVZieLXSBg/UM3YvZpoXrI/AAAAAAAADBo/z9X20T6gYnc/image_thumb%25255B11%25255D.png?imgmax=800 "image")](http://lh6.ggpht.com/-U2gRXwQOtuI/UM3YuT4DdeI/AAAAAAAADBk/uQrNtDbjlfA/s1600-h/image%25255B27%25255D.png)  
 所以要把sig 替换成 signature  

[![image](http://lh4.ggpht.com/-cZqQboYklMk/UM3YxHy6ifI/AAAAAAAADB4/BjcQ4ouxOH0/image_thumb%25255B12%25255D.png?imgmax=800 "image")](http://lh6.ggpht.com/-tIjmnVjosG0/UM3YwIgkcpI/AAAAAAAADBw/2fi04F7AEAc/s1600-h/image%25255B30%25255D.png)  
  
 过后，就完成了！  
  
 **【附加信息】**  
 这里来略略解释下视频下载链接的几个比较重要的参数的功能：  
 以这个链接为例子：  

http://r2---sn-uh-30ar.c.youtube.com/videoplayback?upn=NPuqK12Qg1c&sparams=cp,id,ip,ipbits,itag,ratebypass,source,upn,expire&fexp=900148  

,928006,922401,920704,912806,925703,928001,922403,922405,929901,913605,913546,913556,908493,9  

08496,920201,913302,919009,914903,911116,910221,901451,902556&key=yt1&expire=13556871  
 40&itag=45&ipbits=8&sver=3&ratebypass=yes&mt=1355664552&ip=115.132.  

86.57&mv=m&source=youtube&ms=au&cp=U0hUSlZTVV9JSkNONF9OTVlCOlhfSGt5RWJrWTc2&a  
 mp;id=fae9bd59b0dcc824&newshard=yes&type=video/webm; codecs="vp8.0,   

vorbis"&fallback\_host=tc.v19.cache1.c.youtube.com&signature=D33AA12FD27D75BF1D269B235  

B2449FF0212E9C5.14C2A0886FF05BFB84B92F08EDBB09146448F191&quality=hd720,itag=22  
  
 参数：  
 **itag** ： 辨认该下载链接说对应的视频分辨率（YouTube @ Wikipedia
那里有个很详细的itag表<http://en.wikipedia.org/wiki/YouTube#Quality_and_codecs>）  
  
 **type**： 这就是视频的格式（有flv、webm、3gp、mp4等等）  
  

**quality**：这就是视频的质量啦，分为hd1080、hd720、large、medium、small
，分别对应1080p、720p、480p、360p、240p  
  

