---
layout: post
title: '[教程] 闪盘(Pendrive)内装 BackTrack 5 R3 + Virtual Box 内直接boot USB 教程'
author: 'Gary Ng'
tags: ['Backtrack','plop','USB','virtual box','Virtual Box教程','原创','教程']
---

“肺”话不多说，直接进入正题。  

# 【设置】

## 【工具】

A、BackTrack 5 r 3 的ISO映象档  
 下载地址：<http://www.backtrack-linux.org/downloads/>  
 因为有很多下载选项，这里略略指导一下：  
 1、直接点击Download， 你也可以Register  

[![image](http://lh4.ggpht.com/-J0UgYcjhhSY/UiCjj7Q8N3I/AAAAAAAAEPw/WFem9cUH1ko/image_thumb.png?imgmax=800 "image")](http://lh5.ggpht.com/-lzd7nX-lH90/UiCjjFl0usI/AAAAAAAAEPo/w8_umTWNItM/s1600-h/image%25255B2%25255D.png)  
  
 2、然后这里就会有很多选项，我们选择Backtrack 5 R3  
 Window Manager 就默认选GNOME  
 Architecture 依照你的选择，我这里选择32 （32bit）  
 Image Type 选ISO  
 Download Type 依照你的选择，可以torrent
也可以direct，这里我选择direct  
 然后就可以点击"Click To Download"的按钮  

[![image](http://lh3.ggpht.com/-SmQyW1AhASo/UiCjlQIN27I/AAAAAAAAEQA/P2CZKhcbqJg/image_thumb%25255B2%25255D.png?imgmax=800 "image")](http://lh4.ggpht.com/-4MP5Bod5cYY/UiCjkoUxLJI/AAAAAAAAEP4/GE8SvDIk1DE/s1600-h/image%25255B8%25255D.png)  
  
 3、映象档大小大概是3GB  

[![image](http://lh6.ggpht.com/-IuQULPH6Nds/UiCjmcy0qpI/AAAAAAAAEQQ/L4zV3buqv44/image_thumb%25255B3%25255D.png?imgmax=800 "image")](http://lh4.ggpht.com/-7dJ2niMyQYM/UiCjl9yonRI/AAAAAAAAEQI/2V0eadH8Y-k/s1600-h/image%25255B11%25255D.png)  
  
 B、UNetBootin  
 下载地址：<http://unetbootin.sourceforge.net/>  
  

## 【开始将BT5装进闪盘】

**注：闪盘大小最好8GB或以上**  
  
 1、先打开UNetBootin，选择"DiskImage"，点击"…"选择下载回来的bt5 ISO
映象档  

[![image](http://lh4.ggpht.com/-HXCK0DGli-4/UiCjnkB9LHI/AAAAAAAAEQg/rIqVcqaXU-U/image_thumb%25255B4%25255D.png?imgmax=800 "image")](http://lh5.ggpht.com/-Qxjr5yxhX1Q/UiCjm8uN1lI/AAAAAAAAEQY/qXkjfDsAB_s/s1600-h/image%25255B14%25255D.png)  
  

[![image](http://lh5.ggpht.com/-FDln5_I0Q9k/UiCjo35ttQI/AAAAAAAAEQw/ks5prAzuL5c/image_thumb%25255B5%25255D.png?imgmax=800 "image")](http://lh6.ggpht.com/-N65848dcNEw/UiCjoGUpoZI/AAAAAAAAEQo/-QEUheSamIY/s1600-h/image%25255B17%25255D.png)  
  
 2、然后在Type 选择USB Drive  
 Drive 选择闪盘的盘符  
 然后点击OK  

[![image](http://lh4.ggpht.com/-XJlhadnmJ2I/UiCjp7rknFI/AAAAAAAAERA/dv57PXbxAaU/image_thumb%25255B6%25255D.png?imgmax=800 "image")](http://lh3.ggpht.com/-RhmjTBBzaa0/UiCjpVilNnI/AAAAAAAAEQ4/vPcUtNqgO-s/s1600-h/image%25255B20%25255D.png)  
  
 3、开始操作，等待..  

[![image](http://lh3.ggpht.com/-QQNZoAJ3lHE/UiCjrNZinpI/AAAAAAAAERQ/Ej378ifhfKk/image_thumb%25255B7%25255D.png?imgmax=800 "image")](http://lh5.ggpht.com/-c56Qme33A_4/UiCjqhm2GQI/AAAAAAAAERE/FCoWDqC-7kU/s1600-h/image%25255B23%25255D.png)  
  
 注：在这儿可能会卡着很久，等等..  

[![image](http://lh3.ggpht.com/-au-A4sADANA/UiCjsdNZqyI/AAAAAAAAERg/pRmaPBJXaUQ/image_thumb%25255B8%25255D.png?imgmax=800 "image")](http://lh4.ggpht.com/-dtaUB2OdNgI/UiCjr3WMfQI/AAAAAAAAERY/jlcDObSybi0/s1600-h/image%25255B26%25255D.png)  
  
 4、完成！  
 直接点击Exit如果你要退出..  
  

[![image](http://lh5.ggpht.com/-001hgnFYc0I/UiCjtbZPc1I/AAAAAAAAERw/I1s1ExK2ewI/image_thumb%25255B9%25255D.png?imgmax=800 "image")](http://lh3.ggpht.com/-8RPYub1Dcbo/UiCjs-MbphI/AAAAAAAAERo/sIXX1cmKUcU/s1600-h/image%25255B29%25255D.png)  
  

# 【试用】

注：如果你要用bt5来…（你明白的）的话，建议你进BIOS，把USB设为First Boot
然后boot 进USB内！  
 注2：如果要输入密码的话：  

> username： root  
>  password： toor

因为实在是太懒惰了，而且直接电脑boot BT5的话，screenshot
不到一些画面，于是做了一些些研究，找到了用Virtual Box 来直接boot USB  

## 【工具】

1、Virtual Box  
 下载地址：<https://www.virtualbox.org/wiki/Downloads>  
 下载后安装。  
  
 2、Plop Boot Manager  
 下载地址：<http://www.plop.at/en/bootmanager/download.html>  

建议下载版本5.0.14的：<http://download.plop.at/files/bootmngr/plpbt-5.0.14.zip>  
 下载后解压即可  
  

## 【开始Boot闪盘】

注：因为只是测试是否可以boot，所以设置基本可以全都放默认的  
 1、打开Virtual Box，点击上方的New  

[![image](http://lh6.ggpht.com/-TPwTWg8MHdQ/UiCjuqDju4I/AAAAAAAAESA/rZd3cXlw_t4/image_thumb%25255B10%25255D.png?imgmax=800 "image")](http://lh5.ggpht.com/-SzbH78az22o/UiCjt0AFAoI/AAAAAAAAER4/HahTsHsGVVU/s1600-h/image%25255B32%25255D.png)  
  
 2、输入名称  
 Type 选择 Linux  
 Version 就选择Other Linux  
 点击Next  

[![image](http://lh4.ggpht.com/-aDRrkieOO8g/UiCjvrER7jI/AAAAAAAAESQ/L8sPj1xcpSM/image_thumb%25255B11%25255D.png?imgmax=800 "image")](http://lh5.ggpht.com/-jBUF43694So/UiCjvDTUbHI/AAAAAAAAESI/I-AJvNujnxY/s1600-h/image%25255B35%25255D.png)  
  
 3、保留默认，点击Next  

[![image](http://lh6.ggpht.com/-bdrPXZv0dGo/UiCjw2VmzhI/AAAAAAAAESg/TbMNECS_pug/image_thumb%25255B12%25255D.png?imgmax=800 "image")](http://lh3.ggpht.com/-fYQw64lmtLM/UiCjwaExW6I/AAAAAAAAESY/T9DzktU5BZI/s1600-h/image%25255B38%25255D.png)  
  
 4、因为只是测试，所以直接选择Do not add a virtual hard drive  
 点击Create  

[![image](http://lh4.ggpht.com/-7IRmVqQdDlw/UiCjyHI_4mI/AAAAAAAAESw/fhBHpI0N8EY/image_thumb%25255B13%25255D.png?imgmax=800 "image")](http://lh3.ggpht.com/-iJq_O-Dv_kg/UiCjxaXJH3I/AAAAAAAAESo/OfZpAm4AyX8/s1600-h/image%25255B41%25255D.png)  
  
 5、点击Continue  

[![image](http://lh3.ggpht.com/-urn21grOH0M/UiCjzHd-S4I/AAAAAAAAETA/ui6p5h3sLPg/image_thumb%25255B14%25255D.png?imgmax=800 "image")](http://lh3.ggpht.com/-ihPfIgGibF0/UiCjyt2w5xI/AAAAAAAAES4/3-0aLoAawss/s1600-h/image%25255B44%25255D.png)  
  
 6、选择创建号的Virtual Machine，然后点击上方的settings  

[![image](http://lh3.ggpht.com/-L3ThXysX65U/UiCj0UPlnEI/AAAAAAAAETQ/FjM0BkCPD_4/image_thumb%25255B15%25255D.png?imgmax=800 "image")](http://lh4.ggpht.com/-jZ67qBe9NxE/UiCjzsKV5sI/AAAAAAAAETI/Z8YXmoaRm_A/s1600-h/image%25255B47%25255D.png)  
  

7、点击Storage，然后点击右方的[![image](http://lh4.ggpht.com/-LnYls4vqo1Y/UiCj1at232I/AAAAAAAAETg/F70X7YoojrI/image_thumb%25255B17%25255D.png?imgmax=800 "image")](http://lh6.ggpht.com/-KIo6Uz-43Nk/UiCj0we-4kI/AAAAAAAAETY/1jIPHoqq5yE/s1600-h/image%25255B53%25255D.png)
按钮  

[![image](http://lh5.ggpht.com/-gMC4da2DGFQ/UiCj2gV6DBI/AAAAAAAAETw/AyQY0s-8qnM/image_thumb%25255B16%25255D.png?imgmax=800 "image")](http://lh6.ggpht.com/-sbLO4DH-RBk/UiCj1x_uGyI/AAAAAAAAETo/fehFAZsNiy8/s1600-h/image%25255B50%25255D.png)  
  
 8、选择Choose Disk  

[![image](http://lh3.ggpht.com/-lnbR6oN07DQ/UiCj3kIsbBI/AAAAAAAAEUA/yWhr9FEBVCA/image_thumb%25255B18%25255D.png?imgmax=800 "image")](http://lh5.ggpht.com/-WKRk_PD4ffA/UiCj3Ma89MI/AAAAAAAAET4/czLkMY2S9PQ/s1600-h/image%25255B56%25255D.png)  
  
 9、现在选择下载回来的plop boot manager 的 ISO文件  
 点击Open  

[![image](http://lh5.ggpht.com/-tSgDocCeeis/UiCj475F7TI/AAAAAAAAEUQ/ME0hLyfvblc/image_thumb%25255B19%25255D.png?imgmax=800 "image")](http://lh4.ggpht.com/-6Xyb8qmfDbU/UiCj4Tp60PI/AAAAAAAAEUI/xZuHcaqDKQw/s1600-h/image%25255B59%25255D.png)  
  
 10、现在转到USB 选项  

点击[![image](http://lh4.ggpht.com/-erWKQzUOrOg/UiCj54_gptI/AAAAAAAAEUg/v6YSvBJ2Z5Y/image_thumb%25255B22%25255D.png?imgmax=800 "image")](http://lh4.ggpht.com/-SebKAVNopTI/UiCj5YOaqDI/AAAAAAAAEUY/qaQ2pB_egHs/s1600-h/image%25255B68%25255D.png)  

[![image](http://lh4.ggpht.com/-9WQK5LPxLLQ/UiCj7DwHWfI/AAAAAAAAEUw/t-8SFzuE8qc/image_thumb%25255B20%25255D.png?imgmax=800 "image")](http://lh6.ggpht.com/-P7_5OO0AnGk/UiCj6S8EAfI/AAAAAAAAEUo/n21Sygn9HaE/s1600-h/image%25255B62%25255D.png)  
  
 11、选择Boot的USB  

[![image](http://lh5.ggpht.com/-JaEhrYInTVg/UiCj8MW4OcI/AAAAAAAAEVA/3rBpwc7P4OI/image_thumb%25255B23%25255D.png?imgmax=800 "image")](http://lh6.ggpht.com/-gpvZhs9qtQc/UiCj7ZvQ_9I/AAAAAAAAEU4/kvTGy0Ljs7s/s1600-h/image%25255B71%25255D.png)  
  
 12、然后点击OK  

[![image](http://lh3.ggpht.com/-JcPWFZEVpwg/UiCj9d9JqnI/AAAAAAAAEVQ/2bUbeDMvnyo/image_thumb%25255B24%25255D.png?imgmax=800 "image")](http://lh6.ggpht.com/-nLJmGhLGIwg/UiCj8jG756I/AAAAAAAAEVI/bhBXGgv7mR0/s1600-h/image%25255B74%25255D.png)  
  
 13、然后点击start  

[![image](http://lh4.ggpht.com/-1I0nwxnZf9o/UiCj_Elry5I/AAAAAAAAEVg/ued4eX_yQzo/image_thumb%25255B25%25255D.png?imgmax=800 "image")](http://lh5.ggpht.com/-N6vGGQMLIwk/UiCj-Y9Hn1I/AAAAAAAAEVY/aFx1ezRmF8w/s1600-h/image%25255B77%25255D.png)  
  
 14、看到这个Boot manager，选择USB  

[![image](http://lh3.ggpht.com/-7QRF7DYwVAU/UiCkAAym39I/AAAAAAAAEVw/0pOkgseB_Pc/image_thumb%25255B26%25255D.png?imgmax=800 "image")](http://lh4.ggpht.com/-mBinwAN_2TI/UiCj_uolNrI/AAAAAAAAEVo/tOHrS885NIM/s1600-h/image%25255B80%25255D.png)  
  
 **这里开始的操作与电脑实际boot没有差别**  
 1、选择Default Mode  

[![image](http://lh6.ggpht.com/--iqX32YovHM/UiCkBubvJiI/AAAAAAAAEWA/TPGdnieNvYo/image_thumb%25255B27%25255D.png?imgmax=800 "image")](http://lh4.ggpht.com/-xI-S-hJaBZk/UiCkA1W0MnI/AAAAAAAAEV4/yTgG6kpWUUA/s1600-h/image%25255B83%25255D.png)  
  
 2、等其loading完成  

[![image](http://lh3.ggpht.com/-hfjOTcbXXyA/UiCkC28LgxI/AAAAAAAAEWQ/3cjti-Fw3YE/image_thumb%25255B28%25255D.png?imgmax=800 "image")](http://lh3.ggpht.com/-96UxShz7Lsw/UiCkCPRGy1I/AAAAAAAAEWI/BhqPrMWxd2k/s1600-h/image%25255B86%25255D.png)  
  
 3、loading 完成后，默认是command line的，如果输入密码账户——username:
root pass: toor  

[![image](http://lh4.ggpht.com/--oY26AQj46c/UiCkEjWp3VI/AAAAAAAAEWg/mTUighiQuPs/image_thumb%25255B30%25255D.png?imgmax=800 "image")](http://lh3.ggpht.com/-jZLcR83XLQA/UiCkD5uDU2I/AAAAAAAAEWY/i7v0R1nBKbg/s1600-h/image%25255B92%25255D.png)  
  
 4、如果要进入GUI界面  
 输入**startx**  
 按下enter  
 然后就会看到这个：  

[![image](http://lh6.ggpht.com/-5EGQvsHj7ik/UiCkH1MW_4I/AAAAAAAAEWw/TUb59cFZ_yY/image_thumb%25255B31%25255D.png?imgmax=800 "image")](http://lh3.ggpht.com/-UiJk_UWtvyc/UiCkGHgaW3I/AAAAAAAAEWo/9WGzm4UjDvM/s1600-h/image%25255B95%25255D.png)  
  
 5、进入桌面  

[![image](http://lh6.ggpht.com/-vedJzgXlVMQ/UiCkK7v-QcI/AAAAAAAAEXA/I-Tr_HeDkII/image_thumb%25255B32%25255D.png?imgmax=800 "image")](http://lh6.ggpht.com/-xqaogB8ksCs/UiCkJXaYEQI/AAAAAAAAEW4/eTIEOkl--b8/s1600-h/image%25255B98%25255D.png)  
  
 6、如果你要连接WiFi的话，可以到Internet \> Wicd Network Manager
里面链接  

[![image](http://lh4.ggpht.com/-o0rMHs0Vu8s/UiCkNNQDfCI/AAAAAAAAEXQ/MqUzd5tp5VQ/image_thumb%25255B38%25255D.png?imgmax=800 "image")](http://lh4.ggpht.com/-0ne-U9Zx5Uk/UiCkL6U4BtI/AAAAAAAAEXI/NGsYvSChNzU/s1600-h/image%25255B116%25255D.png)  

[![image](http://lh3.ggpht.com/-ntDl__sePnY/UiCkOg44exI/AAAAAAAAEXg/mSgUSVjuniM/image_thumb%25255B39%25255D.png?imgmax=800 "image")](http://lh5.ggpht.com/-jFKPG-JE2QU/UiCkN-WJFlI/AAAAAAAAEXY/1_DOXlk6O1M/s1600-h/image%25255B119%25255D.png)  
  
 附加： BackTrack \> Exploitation Tools \> Wireless Exploitation Tools
\> WLAN Exploitation \> fern-wifi-cracker  
 你懂的..不解释  

[![image](http://lh5.ggpht.com/-dysJqRtgGN0/UiCkQ5t1InI/AAAAAAAAEXw/DgL1X0snlts/image_thumb%25255B33%25255D.png?imgmax=800 "image")](http://lh5.ggpht.com/-EnkWRKmyHO0/UiCkPsma4eI/AAAAAAAAEXo/ueUvkfdgcL4/s1600-h/image%25255B101%25255D.png)  
  
 bt5不支持我那悲剧的网卡：  

[![image](http://lh4.ggpht.com/-vW-4WptawI0/UiCkSoKBgwI/AAAAAAAAEYA/HZNzqwZ1U44/image_thumb%25255B34%25255D.png?imgmax=800 "image")](http://lh4.ggpht.com/-u6rrKKsKKTo/UiCkR58IAUI/AAAAAAAAEX4/0rSyH-qL3V8/s1600-h/image%25255B104%25255D.png)  
  
 当然你可以用aircrack-ng  
  
 好了，就到这儿..

