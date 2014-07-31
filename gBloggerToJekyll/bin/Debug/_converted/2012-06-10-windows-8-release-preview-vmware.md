---
layout: post
title: '[原创教程] Windows 8 Release Preview VMware内安装教程'
author: 'Gary Ng'
tags: ['vmware','windows','windows 8','windows 8 install','windows 8 preview','原创','教程','虚拟机']
---

光阴似箭啊～很快的，续[Windows 8 Developer
Preview](http://garyngzhongbo.blogspot.com/2011/10/windows-8virtual-boxwindows-8.html)
和 [Windows 8 Consumer
Preview](http://garyngzhongbo.blogspot.com/2012/03/windows-8-consumer-preview_05.html)
后，Windows 最近又释放出了新版本的 **Windows 8 Release Preview
（一下简称Windows 8 RP）**啦！  
 首先呢，当然是下载Windows 8 RP 的ISO文件啦！  
 1、进入微软的官方网站下载Windows 8 RP 的 ISO
文件：<http://windows.microsoft.com/en-US/windows-8/iso>  
 笔者选择了Windows 8 RP x32英文版本的：  

> 64-bit (x64)                   
> [Download](http://go.microsoft.com/fwlink/?LinkId=251532) (3.3
> GB)                    Sha 1 hash —
> 0xD76AD96773615E8C504F63564AF749469CFCCD57  
>  32-bit (x86)                   
> [Download](http://go.microsoft.com/fwlink/?LinkId=251533) (2.5
> GB)                    Sha 1 hash —
> 0x8BED436F0959E7120A44BF7C29FF0AA962BDEFC9  
>  Product Key:   TK8TP-9JN6P-7X7WW-RFFTV-B7QPF

2、当然还要看看Windows 8 RP的系统要求啦！  

> Windows 8 Release Preview 能够在支持 Windows 7
> 的相同硬件上平稳运行：  
>
> -   处理器：1 GHz 或更快  
> -   RAM：1 GB RAM（32 位）或 2 GB RAM（64 位）  
> -   硬盘空间：16 GB（32 位）或 20 GB（64 位）  
> -   图形卡：带有 WDDM 驱动程序的 Microsoft DirectX 9 图形设备
>
> 若要使用某些特定功能，还需要满足以下附加要求：  
>
> -   若要使用触控，你需要支持多点触控的平板电脑或显示器。  
> -   若要访问 Windows 应用商店并下载和运行程序，你需要有效的 Internet
>     连接及至少 1024 x 768 的屏幕分辨率。  
> -   若要贴靠应用程序，你需要至少 1366 x 768 的屏幕分辨率。  
> -   Internet 接入（可能需要 ISP 费用）

3、符合以上系统需求后，马上下载ISO文件啦！  
 注：笔者下载的是Windows 8 RP x32英文版本，在Windows Vista x32 Home
Premium SP2 下的 VMware 虚拟机测试。  
 4、当然，为了大家的电脑的安全，笔者选择了在虚拟机——VMware下测试Windows
8 RP  
 VMware官方网站下载站： [VMware
Workstation](http://downloads.vmware.com/d/info/desktop_end_user_computing/vmware_workstation/8_0)  
 读者必须先注册为VMware用户，才能下载VMware Workstation（下面简称“VMware
WS”）！下载过下来的VMware WS还得输入注册码才能激活，特此附上Vmware WS
8.x 的N个注册码（随便输入一个就够了）：  

![[image36.png]](http://lh6.ggpht.com/-aUYupPlya8A/T1QvBo2brcI/AAAAAAAABNw/HhfufkMg-f8/s1600/image36.png)  
 如果 读者们都试玩过 Windows 8 Consumer Preview 的话，应该都下载过
VMware WS 了吧，那就可以跳过下载VMware WS 的步骤，在等待下载着Windows 8
RP 的 ISO 文件 和 VMware WS 时，可以看看微软关于介绍Windows 8 PR
的官方影片：  

  
 VMware WS 和 Windows 8 RP 的ISO 都下载完后，工具都俱全啦，开始测试！  
 1、开启VMware WS\~\~  
 2、点击File \> New Virtual Machine… 创建新的虚拟机  
 [![2012-06-05
14-57-45](http://lh3.ggpht.com/-ihzzEO6dAQY/T9SFE3jT8EI/AAAAAAAABhY/fCLMCVaPPJA/2012-06-05%25252014-57-45_thumb.png?imgmax=800 "2012-06-05 14-57-45")](http://lh3.ggpht.com/-ngPJv9Lrhyk/T9SFDlEQgTI/AAAAAAAABhQ/OXKJqudoZ1A/s1600-h/2012-06-05%25252014-57-45%25255B2%25255D.png)  
 3、点击“Custom(advanced)”在点击Next  
 [![2012-06-05
14-58-07](http://lh4.ggpht.com/-L7V1tY2cKRE/T9SFIbPiNGI/AAAAAAAABho/f8GgDCQWKL8/2012-06-05%25252014-58-07_thumb%25255B1%25255D.png?imgmax=800 "2012-06-05 14-58-07")](http://lh6.ggpht.com/-q7CX26u9ieg/T9SFGzN2j8I/AAAAAAAABhg/NDE3oXNN13c/s1600-h/2012-06-05%25252014-58-07%25255B5%25255D.png)  
 4、选择 “Workstation 8.0”，然后点击Next  
 [![2012-06-05
14-58-27](http://lh3.ggpht.com/-NUADAhLAX_I/T9SFK-VLkYI/AAAAAAAABh4/gq4FbDBwK28/2012-06-05%25252014-58-27_thumb%25255B1%25255D.png?imgmax=800 "2012-06-05 14-58-27")](http://lh6.ggpht.com/-sm0u9DhCYgg/T9SFJgx3OpI/AAAAAAAABhw/RFc52CliA_Y/s1600-h/2012-06-05%25252014-58-27%25255B5%25255D.png)  
 5、选择“I will install the operating system later.”，点击Next  
 [![2012-06-05
14-58-43](http://lh6.ggpht.com/-ZpXoA9fXYDo/T9SFNvmf_rI/AAAAAAAABiI/PKeo-vokUCQ/2012-06-05%25252014-58-43_thumb.png?imgmax=800 "2012-06-05 14-58-43")](http://lh4.ggpht.com/-d3nCZsqqQxk/T9SFMCQDL1I/AAAAAAAABiA/6eLfKeO1uLQ/s1600-h/2012-06-05%25252014-58-43%25255B2%25255D.png)  
 6、选择”Microsoft Windows“，Version 选择 “Windows 7 “，点击Next  
 [![2012-06-05
14-59-05](http://lh4.ggpht.com/-uqVvhqJGgcg/T9SFQKa_vUI/AAAAAAAABiY/fws34aaWxhc/2012-06-05%25252014-59-05_thumb.png?imgmax=800 "2012-06-05 14-59-05")](http://lh3.ggpht.com/-LU6ANMkhRuQ/T9SFOgkw1HI/AAAAAAAABiQ/YW-yaZv3Bus/s1600-h/2012-06-05%25252014-59-05%25255B2%25255D.png)  
 7、为虚拟机给个名字吧（笔者的是：Windows 8 Release
Preview），在点击Next  
 [![2012-06-05
14-59-28](http://lh4.ggpht.com/-ZEgC2dOV9z0/T9SFST7uixI/AAAAAAAABio/hRxZboV3Rs0/2012-06-05%25252014-59-28_thumb%25255B1%25255D.png?imgmax=800 "2012-06-05 14-59-28")](http://lh3.ggpht.com/-JFknYqjFpOI/T9SFRCeOxKI/AAAAAAAABig/Zd7d2ejzqFg/s1600-h/2012-06-05%25252014-59-28%25255B5%25255D.png)  

8、电脑配置高的读者们可以改变Processors的数量，笔者的电脑配置不高，所以只选择一个processors。点击Next  
 [![2012-06-05
14-59-51](http://lh3.ggpht.com/-I_vm_7jCeLQ/T9SFUnoIGSI/AAAAAAAABi4/v_Ih3FjCkJM/2012-06-05%25252014-59-51_thumb.png?imgmax=800 "2012-06-05 14-59-51")](http://lh4.ggpht.com/-8O4F7Cj0a7Y/T9SFTWUe4MI/AAAAAAAABiw/7l6eKYwuG-c/s1600-h/2012-06-05%25252014-59-51%25255B2%25255D.png)  
 9、设置虚拟机的Memory
Size，微软建议1GB以上，笔者选择了1780MB，点击Next  
 [![2012-06-05
15-00-18](http://lh3.ggpht.com/-88NYwBn7-A0/T9SFW4X7jnI/AAAAAAAABjI/FhDmFrJDevw/2012-06-05%25252015-00-18_thumb.png?imgmax=800 "2012-06-05 15-00-18")](http://lh4.ggpht.com/-kujHWiJ5ELI/T9SFWO7b3MI/AAAAAAAABjA/L6kOk1YhO9w/s1600-h/2012-06-05%25252015-00-18%25255B2%25255D.png)  
 10、设置虚拟机网络设置，选择”Use network address
translation(NAT)“，点击Next（注：笔者的VMware WS
不能联网，一联网电脑就BSOD了。。）  
 [![2012-06-05
15-00-35](http://lh4.ggpht.com/-ikwjjWdpcRM/T9SFZNzr1nI/AAAAAAAABjY/yTT1yfvyzKs/2012-06-05%25252015-00-35_thumb.png?imgmax=800 "2012-06-05 15-00-35")](http://lh6.ggpht.com/-4yFEBE3xtaI/T9SFYKDtvwI/AAAAAAAABjQ/ysLUyaePg4w/s1600-h/2012-06-05%25252015-00-35%25255B2%25255D.png)  
  
 11、选择 ”LSI Logic SAS (Recommended)“，点击 Next  
 [![2012-06-05
15-00-50](http://lh6.ggpht.com/-Nm_X_qP1M5s/T9SFbY_0fCI/AAAAAAAABjo/ODk-1tw9alM/2012-06-05%25252015-00-50_thumb.png?imgmax=800 "2012-06-05 15-00-50")](http://lh6.ggpht.com/-IYq_MFNadIs/T9SFaYXk7uI/AAAAAAAABjg/dDnuNUgm7Vg/s1600-h/2012-06-05%25252015-00-50%25255B2%25255D.png)  
 12、选择”Create a new virtual disk“，点击 Next  
 [![2012-06-05
15-01-04](http://lh6.ggpht.com/-9OWr_ar-DEc/T9SFedjkxpI/AAAAAAAABj4/sJ5fqH7Ilbc/2012-06-05%25252015-01-04_thumb.png?imgmax=800 "2012-06-05 15-01-04")](http://lh6.ggpht.com/-HM6gxDgfc6s/T9SFdRUQP3I/AAAAAAAABjw/ai-Y7lNysRI/s1600-h/2012-06-05%25252015-01-04%25255B2%25255D.png)  
 13、选择”SCSI(Recommended)“，点击Next  
 [![2012-06-05
15-01-16](http://lh6.ggpht.com/-6PuKi_9gF9E/T9SFg9uSeHI/AAAAAAAABkI/cM4Payfle-w/2012-06-05%25252015-01-16_thumb.png?imgmax=800 "2012-06-05 15-01-16")](http://lh3.ggpht.com/-rLutETgAlaw/T9SFff0V75I/AAAAAAAABkA/rlXfw-3qCrY/s1600-h/2012-06-05%25252015-01-16%25255B2%25255D.png)  

14、现在到了设置虚拟机的硬盘大小，微软建议20GB以上，笔者选择了40GB，然后选择”Split
virtual disk into multiple files“，点击Next  
 [![2012-06-05
15-01-37](http://lh3.ggpht.com/-NKVoj7lMXK0/T9SFjIxynyI/AAAAAAAABkY/GY0CqUncxTo/2012-06-05%25252015-01-37_thumb.png?imgmax=800 "2012-06-05 15-01-37")](http://lh5.ggpht.com/-2cNzmlKaNGU/T9SFiJxAIeI/AAAAAAAABkQ/UqxxJxsLJJo/s1600-h/2012-06-05%25252015-01-37%25255B2%25255D.png)  
 15、如果不需要更改虚拟机的存放路径，直接点击Next  
 [![2012-06-05
15-01-52](http://lh3.ggpht.com/-Z_xlQtc40oA/T9SFmEky5DI/AAAAAAAABko/o7DEQJXYuns/2012-06-05%25252015-01-52_thumb.png?imgmax=800 "2012-06-05 15-01-52")](http://lh6.ggpht.com/-Nm5EV5r--tU/T9SFk44ijWI/AAAAAAAABkg/0c-9cKSgSCg/s1600-h/2012-06-05%25252015-01-52%25255B2%25255D.png)  
 16、设置虚拟机大功告成！点击Finish  
 [![2012-06-05
15-02-02](http://lh6.ggpht.com/-Da6lXtwYNqA/T9SFoTFIwlI/AAAAAAAABk4/vkgb0dRIO1E/2012-06-05%25252015-02-02_thumb.png?imgmax=800 "2012-06-05 15-02-02")](http://lh4.ggpht.com/-iMqHmdquhLQ/T9SFnaqWwgI/AAAAAAAABkw/qF6h4usO6Po/s1600-h/2012-06-05%25252015-02-02%25255B2%25255D.png)  
 17、返回VMware WS 的界面，点击刚刚创建的虚拟机（Windows 8 Release
Preview），过后点击”Edit virtual machine settings“（笔者的Windows 8
Consumer Preview 还在呢～）  
 [![2012-06-05
15-03-42](http://lh4.ggpht.com/-9LIINIz0F2I/T9SFqtLdOXI/AAAAAAAABlI/UbJ5xQerruA/2012-06-05%25252015-03-42_thumb.png?imgmax=800 "2012-06-05 15-03-42")](http://lh5.ggpht.com/-8w-fveCZH_g/T9SFpfHToyI/AAAAAAAABlA/icRP6w8H3_A/s1600-h/2012-06-05%25252015-03-42%25255B2%25255D.png)  
 18、选择”CD/DVD(IDE)“，然后在”Connection”那儿点击”Use ISO image
file”,点击Browse  
 [![2012-06-05
15-04-04](http://lh6.ggpht.com/-TJPNJYrDxdI/T9SFwOE5PdI/AAAAAAAABlY/WgkISLtmlAc/2012-06-05%25252015-04-04_thumb.png?imgmax=800 "2012-06-05 15-04-04")](http://lh5.ggpht.com/-XXtX1rqQJQQ/T9SFuDSUSoI/AAAAAAAABlQ/sp45LOcaviQ/s1600-h/2012-06-05%25252015-04-04%25255B2%25255D.png)  
 19、选择已经下载的Windows 8 RP ISO 的存放路径，点击Open  
 [![2012-06-05
15-04-56](http://lh4.ggpht.com/-WeDap8JyrlQ/T9SFzUxCweI/AAAAAAAABlo/HElfJZOlIB4/2012-06-05%25252015-04-56_thumb.png?imgmax=800 "2012-06-05 15-04-56")](http://lh6.ggpht.com/-OSRznW4of4w/T9SFxsdbDmI/AAAAAAAABlg/b39Qmy98UTM/s1600-h/2012-06-05%25252015-04-56%25255B2%25255D.png)  
 20、点击OK  
 [![2012-06-05
15-05-13](http://lh5.ggpht.com/--6uS17NPtAE/T9SF2eO3Q9I/AAAAAAAABl4/lg_tivlqwKM/2012-06-05%25252015-05-13_thumb.png?imgmax=800 "2012-06-05 15-05-13")](http://lh5.ggpht.com/-qarhPXYOKIc/T9SF1Ia8j0I/AAAAAAAABlw/MQIwTQ43TEg/s1600-h/2012-06-05%25252015-05-13%25255B2%25255D.png)  
 21、返回VMware WS 的主界面，点击”Power on this virtual machine“  
 [![2012-06-05
15-05-37](http://lh3.ggpht.com/-1M5OYK0vGD4/T9SF4jywn5I/AAAAAAAABmI/nSRisgS8nTw/2012-06-05%25252015-05-37_thumb.png?imgmax=800 "2012-06-05 15-05-37")](http://lh3.ggpht.com/-Gb7-p2vDO20/T9SF3qHEMLI/AAAAAAAABmA/UfTFtc1WLyI/s1600-h/2012-06-05%25252015-05-37%25255B2%25255D.png)  
 22、又换了个界面的Windows 的开机画面！  
 [![2012-06-05
15-14-50](http://lh4.ggpht.com/-cjLlDw70Bwk/T9SF7E1n6gI/AAAAAAAABmY/yV0qgAmAKRQ/2012-06-05%25252015-14-50_thumb%25255B11%25255D.png?imgmax=800 "2012-06-05 15-14-50")](http://lh3.ggpht.com/-I6JazYBaJGc/T9SF5w4zu6I/AAAAAAAABmQ/iV9n25Eb4sU/s1600-h/2012-06-05%25252015-14-50%25255B5%25255D.png)  
 23、来到熟悉的Windows 安装界面！点击Next  
 [![2012-06-05
15-15-30](http://lh4.ggpht.com/-iA1NlzQ8VR4/T9SF-3MsCgI/AAAAAAAABmo/aBaR89raeMc/2012-06-05%25252015-15-30_thumb%25255B4%25255D.png?imgmax=800 "2012-06-05 15-15-30")](http://lh6.ggpht.com/-SVBPh2KJw5M/T9SF9fKISgI/AAAAAAAABmg/gwGFOIvIdWA/s1600-h/2012-06-05%25252015-15-30%25255B3%25255D.png)  
 24、点击“Install now”  
 [![2012-06-06
20-52-05](http://lh4.ggpht.com/-JX3Voy0p7e4/T9SGA_jg0uI/AAAAAAAABm4/BbzXML2rJuY/2012-06-06%25252020-52-05_thumb%25255B4%25255D.png?imgmax=800 "2012-06-06 20-52-05")](http://lh6.ggpht.com/-pVJMtANtwJw/T9SF_zNCF3I/AAAAAAAABmw/1yhXlMsL518/s1600-h/2012-06-06%25252020-52-05%25255B3%25255D.png)  
 25、”Setup is starting”  
 [![2012-06-06
20-53-02](http://lh3.ggpht.com/--Y5JBQJp3C0/T9SGEAdWbeI/AAAAAAAABnI/DmES_PAXvbo/2012-06-06%25252020-53-02_thumb%25255B6%25255D.png?imgmax=800 "2012-06-06 20-53-02")](http://lh5.ggpht.com/-3_Vs2pqCeH0/T9SGCHiEwII/AAAAAAAABnA/hhxgcQm10n0/s1600-h/2012-06-06%25252020-53-02%25255B3%25255D.png)  
 26、输入Windows 8
RP序列号（话说在那么低的配置下还有aero效果呢！赞！）  
 [![2012-06-06
20-55-10](http://lh6.ggpht.com/-MZ06gwJKAQU/T9SGGkx3SgI/AAAAAAAABnY/ctUn06VEGf8/2012-06-06%25252020-55-10_thumb%25255B4%25255D.png?imgmax=800 "2012-06-06 20-55-10")](http://lh6.ggpht.com/-poSenKMdD5g/T9SGFbU4pnI/AAAAAAAABnQ/1F_JPFQuzHk/s1600-h/2012-06-06%25252020-55-10%25255B3%25255D.png)  
 27、点击“I accept the license terms”，点击Next  
 [![2012-06-06
20-55-41](http://lh4.ggpht.com/-f0GGUwwM2pQ/T9SGKgOJTvI/AAAAAAAABno/uAi6VRCCSwc/2012-06-06%25252020-55-41_thumb%25255B4%25255D.png?imgmax=800 "2012-06-06 20-55-41")](http://lh3.ggpht.com/-4nKZRBIBwlg/T9SGICh6WuI/AAAAAAAABng/RQuih98BIaE/s1600-h/2012-06-06%25252020-55-41%25255B3%25255D.png)  
 28、点击“Custom: Install Windows only(advanced)”  
 [![2012-06-06
20-56-00](http://lh3.ggpht.com/-Tl__IxcjOcw/T9SGNN86hAI/AAAAAAAABn4/8yl6bTrhfXo/2012-06-06%25252020-56-00_thumb%25255B4%25255D.png?imgmax=800 "2012-06-06 20-56-00")](http://lh5.ggpht.com/-NI8QDgDCghs/T9SGLyhZZPI/AAAAAAAABnw/9oPITjsawkM/s1600-h/2012-06-06%25252020-56-00%25255B3%25255D.png)  
 29、选择磁盘，点击Next  
 [![2012-06-06
20-56-15](http://lh6.ggpht.com/-8UjtPTx7GP8/T9SGP6DSJ8I/AAAAAAAABoI/O7R_tlFYgIk/2012-06-06%25252020-56-15_thumb%25255B5%25255D.png?imgmax=800 "2012-06-06 20-56-15")](http://lh3.ggpht.com/-p39KBDnotYk/T9SGOt9Aw0I/AAAAAAAABoA/4vx55Zp4JIk/s1600-h/2012-06-06%25252020-56-15%25255B6%25255D.png)  
 30、开始安装啦！耐心等待吧～  
 [![2012-06-06
20-57-02](http://lh5.ggpht.com/-5nwjq8dYRSI/T9SGSTCD-fI/AAAAAAAABoY/2DSkfRmaF0E/2012-06-06%25252020-57-02_thumb%25255B4%25255D.png?imgmax=800 "2012-06-06 20-57-02")](http://lh5.ggpht.com/-Fw7bg_z40Zc/T9SGRFAE_dI/AAAAAAAABoQ/DguEd6QVmoM/s1600-h/2012-06-06%25252020-57-02%25255B3%25255D.png)  
 31、安装完毕，系统会重启（又看到我们熟悉的界面）  
 [![2012-06-06
21-18-15](http://lh6.ggpht.com/-2AqpgCEKwP0/T9SGVvKnMgI/AAAAAAAABoo/WFbJr1AWUS4/2012-06-06%25252021-18-15_thumb%25255B3%25255D.png?imgmax=800 "2012-06-06 21-18-15")](http://lh5.ggpht.com/-acs1bI2Bm-I/T9SGUa5bswI/AAAAAAAABog/8d5Lx7dtDlg/s1600-h/2012-06-06%25252021-18-15%25255B3%25255D.png)  
 32、Please Wait  
 [![2012-06-06
21-19-47](http://lh6.ggpht.com/-smw_Le7N3_Y/T9SGXwh-pHI/AAAAAAAABo4/k22ZI5lcs2k/2012-06-06%25252021-19-47_thumb%25255B4%25255D.png?imgmax=800 "2012-06-06 21-19-47")](http://lh6.ggpht.com/-6MDOi5IVu4M/T9SGWrp7p1I/AAAAAAAABow/qhKBTqlBmZI/s1600-h/2012-06-06%25252021-19-47%25255B3%25255D.png)  
 33、Preparing  
 [![2012-06-06
21-22-33](http://lh4.ggpht.com/-rfXwoNxHr-M/T9SGZzE8-eI/AAAAAAAABpI/_smylucuqkg/2012-06-06%25252021-22-33_thumb%25255B3%25255D.png?imgmax=800 "2012-06-06 21-22-33")](http://lh6.ggpht.com/-rfWGrNM2hpc/T9SGY5yqp8I/AAAAAAAABpA/iwViTh1o-ZY/s1600-h/2012-06-06%25252021-22-33%25255B3%25255D.png)  
 34、Getting devices ready （很久啊）  
 [![2012-06-06
21-24-05](http://lh3.ggpht.com/-qV4jKH2tuxE/T9SGbxSzdAI/AAAAAAAABpU/NiePS0CKPcE/2012-06-06%25252021-24-05_thumb%25255B3%25255D.png?imgmax=800 "2012-06-06 21-24-05")](http://lh3.ggpht.com/-_sILvA2Lnn4/T9SGazOLeoI/AAAAAAAABpQ/BXExNmRVN98/s1600-h/2012-06-06%25252021-24-05%25255B3%25255D.png)  
 35、Getting system ready  
 [![2012-06-06
21-28-18](http://lh3.ggpht.com/-TOP1_YuLOek/T9SGebFNgwI/AAAAAAAABpo/Z6IbiZNCHaA/2012-06-06%25252021-28-18_thumb%25255B3%25255D.png?imgmax=800 "2012-06-06 21-28-18")](http://lh6.ggpht.com/-LAZZyVYbWIQ/T9SGdJSlSYI/AAAAAAAABpg/uyR7VCSopkY/s1600-h/2012-06-06%25252021-28-18%25255B3%25255D.png)  
 36、再度重启  
 [![2012-06-06
21-29-21](http://lh5.ggpht.com/-np4T1a-8ado/T9SGgdcX8HI/AAAAAAAABp4/bwL_Rk30skE/2012-06-06%25252021-29-21_thumb%25255B3%25255D.png?imgmax=800 "2012-06-06 21-29-21")](http://lh6.ggpht.com/-5RE-NwxgQXo/T9SGfYwMLAI/AAAAAAAABpw/OcGH8-1JeZw/s1600-h/2012-06-06%25252021-29-21%25255B3%25255D.png)  
 37、到了设置页面（欢呼）  
 为系统选择颜色吧（比Windows 8 Consumer Preview
多了好多选择～），再为电脑给个名字，点击Next  
 [![2012-06-06
21-35-01](http://lh3.ggpht.com/-bH_A6BHoKGU/T9SGkHYen_I/AAAAAAAABqI/22BhD3zFxS0/2012-06-06%25252021-35-01_thumb%25255B4%25255D.png?imgmax=800 "2012-06-06 21-35-01")](http://lh3.ggpht.com/-NEXtvSurD94/T9SGi9m3haI/AAAAAAAABqA/bDouyTrEpms/s1600-h/2012-06-06%25252021-35-01%25255B3%25255D.png)  
 38、点击“Use express settings”  
 [![2012-06-06
21-36-23](http://lh3.ggpht.com/-bbDOzO_KK5I/T9SGnM8GvEI/AAAAAAAABqY/LeCSq9dChr4/2012-06-06%25252021-36-23_thumb%25255B4%25255D.png?imgmax=800 "2012-06-06 21-36-23")](http://lh6.ggpht.com/-E-DNzHE3dqw/T9SGl1oSdaI/AAAAAAAABqQ/BlpX4lKQO5I/s1600-h/2012-06-06%25252021-36-23%25255B3%25255D.png)  
 39、为电脑设置密码、帐户名等等，点击Finish（注：笔者的Vmware WS
无法连上网络，如果有网络的话，可能不是这个界面啦～）  
 [![2012-06-07
17-17-50](http://lh6.ggpht.com/-XTtSKjW_rXs/T9SGqE_tlVI/AAAAAAAABqo/aKBVX30BPEQ/2012-06-07%25252017-17-50_thumb%25255B4%25255D.png?imgmax=800 "2012-06-07 17-17-50")](http://lh3.ggpht.com/-5DFYBNbNHJ4/T9SGo2TrVLI/AAAAAAAABqg/em0WVeaNtxg/s1600-h/2012-06-07%25252017-17-50%25255B3%25255D.png)  
 40、Finalizing your settings  
 [![2012-06-07
17-18-37](http://lh5.ggpht.com/-Xgvb0yc0Kqw/T9SGsFFEOxI/AAAAAAAABq4/0NVg1IQdAsE/2012-06-07%25252017-18-37_thumb%25255B3%25255D.png?imgmax=800 "2012-06-07 17-18-37")](http://lh5.ggpht.com/-k_9jtUbq7u0/T9SGrDAcFEI/AAAAAAAABqw/uBV4juOFu3o/s1600-h/2012-06-07%25252017-18-37%25255B3%25255D.png)  
 41、重启，Your PC will be ready in just a moment  
 [![2012-06-07
17-20-01](http://lh5.ggpht.com/-6DDKKI0vU9E/T9SGvGlQwjI/AAAAAAAABrI/lXoH3-DTZEQ/2012-06-07%25252017-20-01_thumb%25255B4%25255D.png?imgmax=800 "2012-06-07 17-20-01")](http://lh3.ggpht.com/-oExel3Me6Tk/T9SGtOiuD6I/AAAAAAAABrA/2fpwKYmlR-A/s1600-h/2012-06-07%25252017-20-01%25255B3%25255D.png)  
 42、到主界面啦！（大声欢呼！）  
 [![2012-06-07
17-24-04](http://lh3.ggpht.com/-CeNK3YA9C9A/T9SGzgBgnkI/AAAAAAAABrY/OEqCIhsXdSI/2012-06-07%25252017-24-04_thumb%25255B4%25255D.png?imgmax=800 "2012-06-07 17-24-04")](http://lh6.ggpht.com/--NkaYuNoVog/T9SGxrNnS_I/AAAAAAAABrQ/AwQto3cigaI/s1600-h/2012-06-07%25252017-24-04%25255B3%25255D.png)  
 43、预设界面  
 [![2012-06-07
17-24-40](http://lh4.ggpht.com/-LA6w-XkUH8U/T9SHJ7SA0zI/AAAAAAAABro/gvel5lqewgs/2012-06-07%25252017-24-40_thumb%25255B4%25255D.png?imgmax=800 "2012-06-07 17-24-40")](http://lh5.ggpht.com/-OL-djQ7gExY/T9SG-4yVPwI/AAAAAAAABrg/falj3QNxI_Y/s1600-h/2012-06-07%25252017-24-40%25255B3%25255D.png)  
 44、把鼠标移到左下角就会显示这个，用以回到Metro界面  
 [![2012-06-07
17-24-54](http://lh3.ggpht.com/-KFWpGXH2yOI/T9SHenGcZBI/AAAAAAAABr4/mmcnVatqaRA/2012-06-07%25252017-24-54_thumb%25255B4%25255D.png?imgmax=800 "2012-06-07 17-24-54")](http://lh6.ggpht.com/-_nQxJjBDsuI/T9SHULXdPmI/AAAAAAAABrw/V49_e3JOzHc/s1600-h/2012-06-07%25252017-24-54%25255B3%25255D.png)  
 45、新版本的Task Manager，详细多了！  
 [![2012-06-07
17-25-54](http://lh6.ggpht.com/-C6p1KtkLemY/T9SHlPDZ2dI/AAAAAAAABsI/MnmPsM_WSsY/2012-06-07%25252017-25-54_thumb%25255B4%25255D.png?imgmax=800 "2012-06-07 17-25-54")](http://lh6.ggpht.com/-4jWgLnY8RgE/T9SHiKex6kI/AAAAAAAABsA/anFgHB3YEvE/s1600-h/2012-06-07%25252017-25-54%25255B3%25255D.png)  
 46、超酷的！  
 [![2012-06-07
17-26-02](http://lh5.ggpht.com/-VuNyY7C7xpI/T9SHsJ-UMYI/AAAAAAAABsY/GO8e-5FqVOo/2012-06-07%25252017-26-02_thumb%25255B4%25255D.png?imgmax=800 "2012-06-07 17-26-02")](http://lh5.ggpht.com/-7qjORD1QJjA/T9SHo32hQZI/AAAAAAAABsQ/Cgc7K0x4H9A/s1600-h/2012-06-07%25252017-26-02%25255B3%25255D.png)  
 47、炫酷的Windows 8 图标  
 [![2012-06-07
17-29-53](http://lh5.ggpht.com/-T2YWmDC3xBQ/T9SH2nDGnNI/AAAAAAAABso/c9urpmKokpk/2012-06-07%25252017-29-53_thumb%25255B4%25255D.png?imgmax=800 "2012-06-07 17-29-53")](http://lh6.ggpht.com/-lk3UPCBtnW8/T9SHxIh5wLI/AAAAAAAABsg/ulfS3I8KatM/s1600-h/2012-06-07%25252017-29-53%25255B3%25255D.png)  
 48、文件复制的进度变得更加详细  
 [![2012-06-07
17-32-56](http://lh3.ggpht.com/-iPJeE0m4YBA/T9SIIpnQ-5I/AAAAAAAABs4/jUZKUkVkhrg/2012-06-07%25252017-32-56_thumb%25255B5%25255D.png?imgmax=800 "2012-06-07 17-32-56")](http://lh3.ggpht.com/-dQIoLbI223E/T9SIAH1GNvI/AAAAAAAABsw/9Vxi4AkfDao/s1600-h/2012-06-07%25252017-32-56%25255B3%25255D.png)  
 49、按下Win+C显示右边的显示条和时间显示  
 [![2012-06-07
17-33-48](http://lh4.ggpht.com/-GbKS18RzTqA/T9SIQozlfkI/AAAAAAAABtI/66J8FAuyx7I/2012-06-07%25252017-33-48_thumb%25255B4%25255D.png?imgmax=800 "2012-06-07 17-33-48")](http://lh3.ggpht.com/-wbkwwU2iDGE/T9SIMo6YrJI/AAAAAAAABtA/qEM0-lJ-A34/s1600-h/2012-06-07%25252017-33-48%25255B3%25255D.png)  
 50、按下Win + i ，显示Setting  
 [![2012-06-07
17-36-09](http://lh4.ggpht.com/-oLSnOxj9Nx0/T9SIW5WIrBI/AAAAAAAABtY/AVlYZckhH8E/2012-06-07%25252017-36-09_thumb%25255B5%25255D.png?imgmax=800 "2012-06-07 17-36-09")](http://lh6.ggpht.com/-HC4rKaKJyOI/T9SIUIkRoGI/AAAAAAAABtQ/BzfFtWuHnAE/s1600-h/2012-06-07%25252017-36-09%25255B6%25255D.png)  
 51、按下Win + Q显示寻找Apps功能  
 [![2012-06-07
17-36-49](http://lh4.ggpht.com/-FhOagkg3HjQ/T9SIZ084t9I/AAAAAAAABto/mXoabUx24sA/2012-06-07%25252017-36-49_thumb%25255B4%25255D.png?imgmax=800 "2012-06-07 17-36-49")](http://lh4.ggpht.com/-IzmRd6qmXwg/T9SIYSIy71I/AAAAAAAABtg/NpK_H-sJGxE/s1600-h/2012-06-07%25252017-36-49%25255B3%25255D.png)  
 52、Win + W显示Setting Search功能  
 [![2012-06-07
17-37-29](http://lh6.ggpht.com/-PngkCf4APSQ/T9SIc1za-4I/AAAAAAAABt4/QrkmSks_eoY/2012-06-07%25252017-37-29_thumb%25255B5%25255D.png?imgmax=800 "2012-06-07 17-37-29")](http://lh4.ggpht.com/-KPMmlLAtYoY/T9SIbWQicPI/AAAAAAAABtw/usrhF0grgFo/s1600-h/2012-06-07%25252017-37-29%25255B6%25255D.png)  
 53、Win + K 显示Devices  
 [![2012-06-07
17-38-06](http://lh3.ggpht.com/-S13ra6JyzF0/T9SIjPmaaDI/AAAAAAAABuI/OrIXIjpdyps/2012-06-07%25252017-38-06_thumb%25255B4%25255D.png?imgmax=800 "2012-06-07 17-38-06")](http://lh6.ggpht.com/-iQC7EWDUff4/T9SIgCrRDzI/AAAAAAAABuA/sptlfoHrdwc/s1600-h/2012-06-07%25252017-38-06%25255B3%25255D.png)  
 54、Win + H 显示 Share  
 [![2012-06-07
17-38-42](http://lh4.ggpht.com/-65qHOm68P3k/T9SIrEWHexI/AAAAAAAABuY/DT1cevbb76s/2012-06-07%25252017-38-42_thumb%25255B4%25255D.png?imgmax=800 "2012-06-07 17-38-42")](http://lh5.ggpht.com/-S7jQNhyGnzU/T9SInaDXHjI/AAAAAAAABuQ/LSeWwtuhzzQ/s1600-h/2012-06-07%25252017-38-42%25255B3%25255D.png)  
 55、新版本的IE10  
 [![2012-06-07
17-40-48](http://lh5.ggpht.com/-ArdpmavydAo/T9SIzrRGRHI/AAAAAAAABuo/W_I18Ds5Ra4/2012-06-07%25252017-40-48_thumb%25255B4%25255D.png?imgmax=800 "2012-06-07 17-40-48")](http://lh4.ggpht.com/-5eQuY1PCUBQ/T9SIvSrmEaI/AAAAAAAABug/pVGwdrFApbE/s1600-h/2012-06-07%25252017-40-48%25255B3%25255D.png)  
 56、Win + Tab 显示切换窗口  
 [![2012-06-07
17-42-41](http://lh6.ggpht.com/-lN6gQxC8MWs/T9SI4JZh7BI/AAAAAAAABu4/mbylA1EinPc/2012-06-07%25252017-42-41_thumb%25255B4%25255D.png?imgmax=800 "2012-06-07 17-42-41")](http://lh5.ggpht.com/-XSbPxqkmm-Q/T9SI13-ZNkI/AAAAAAAABuw/wKibTrWG8wY/s1600-h/2012-06-07%25252017-42-41%25255B3%25255D.png)  
 57、新版本的Autorun  
 [![2012-06-07
17-50-30](http://lh4.ggpht.com/-KCoZcW1kO0I/T9SJVFpn9VI/AAAAAAAABvI/ar97ZIQrpJQ/2012-06-07%25252017-50-30_thumb%25255B7%25255D.png?imgmax=800 "2012-06-07 17-50-30")](http://lh6.ggpht.com/-VISLuXztNTM/T9SJCZ_A1cI/AAAAAAAABvA/BtW0xmcDqK0/2012-06-07%25252017-50-30%25255B4%25255D.png?imgmax=800)  
  
 好啦，介绍的七七八八啦～其他的功能就由读者去摸索啦～

