---
layout: post
title: '[原创][教程] 在USB内直接使用正式版Windows 8'
author: 'Gary Ng'
tags: ['windows 8','windows 8 install','原创','教程']
---

Windows 8 在2012年10月26日正式上市啦！这表示我们可以买到已经安装Windows
8 的电脑咯！  
 这里是Windows 8 的最低硬件配置需求：  

> 如果要在电脑上运行 Windows 8，必须满足以下条件：  
>
> -   处理器：1 GHz 或更快（支持 PAE、NX 和 SSE2）  
> -   RAM：1 GB（32 位）或 2 GB（64 位）  
> -   硬盘空间：16 GB（32 位）或 20 GB（64 位）  
> -   图形卡：带有 WDDM 驱动程序的 Microsoft DirectX 9 图形设备
>
> 若要使用某些特定功能，还需要满足以下附加要求：  
>
> -   若要使用触控功能，你需要支持多点触控的平板电脑或显示器[（详情）](http://windows.microsoft.com/zh-CN/windows-8/multitouch-harware-reqs)  
> -   若要访问 Windows 应用商店并下载和运行应用，你需要有效的 Internet
>     连接及至少 1024 x 768 的屏幕分辨率  
> -   若要拖拽程序，你需要至少 1366 x 768 的屏幕分辨率  
> -   Internet 接入（可能产生 ISP 费用）  
> -   安全启动要求固件支持 UEFI v2.3.1 Errata B，并且在 UEFI
>     签名数据库中具有 Microsoft Windows 证书颁发机构  
> -   一些游戏和程序可能需要图形卡兼容 DirectX 10
>     或更高版本，以获得最佳性能  
> -   某些功能需要使用 Microsoft 帐户  
> -   观看 DVD
>     需要单独的播放软件[（详情）](http://windows.microsoft.com/zh-CN/windows/dvd-playback-help)  
> -   Windows Media Center
>     许可证单独销售[（详情）](http://windows.microsoft.com/zh-CN/windows-8/feature-packs)  
> -   BitLocker To Go 需要 USB 闪存驱动器（仅限于 Windows 8 Pro）  
> -   BitLocker 需要受信任的平台模块 (TPM) 1.2 或 USB 闪存驱动器（仅限于
>     Windows 8 Pro）  
> -   客户端 Hyper-V 需要有二级地址翻译 (SLAT) 功能的 64
>     位系统以及额外的 2 GB RAM（仅限于 Windows 8 Pro）  
> -   在 Windows Media Center
>     中播放和录制直播电视节目需要电视调谐器（仅限于 Windows 8 Pro Pack
>     和 Windows 8 Media Center Pack）  
> -   不同地区的免费 Internet
>     电视节目内容不同，某些内容可能需要额外付费（仅限于 (Windows 8 Pro
>     Pack 和 Windows 8 Media Center Pack）
>
> 你可以运行[升级助手](http://windows.microsoft.com/zh-CN/windows-8/upgrade-to-windows-8)以检查你的电脑是否满足这些要求。

   
 笔者拖到现在才下载Windows 8（正式版，下同），其实是因为Windows 8
没有下载速度比较快的链接，只有ed2k资源的，下载速度相对的比较不稳定。  
 这里是大家期待的——Windows 8
各个版本的下载地址（ed2k资源，推荐用[迅雷](http://dl.xunlei.com/xl7.html)下载，也可以用[迅雷简精版](http://mini.xunlei.com/)下载）。  

<table>
<colgroup>
<col width="50%" />
<col width="50%" />
</colgroup>
<tbody>
<tr class="odd">
<td align="left"><strong>版本（英文正式版）</strong>
<strong>下载链接（ed2k资源）</strong></td>
<td align="left">Windows 8 Professional x86 + Core
<a href="ed2k://|file|en_windows_8_x86_dvd_915417.iso|2632460288|C357F5451EB803897CAA93437E0A7535|/">en_windows_8_x86_dvd_915417.iso (2.45 GB)</a></td>
</tr>
</tbody>
</table>

  
 笔者下载的是Windows 8 Professional x86 + Core，也就是32位Windows
8专业版本。  
 还有这里是Windows 8 各个版本的安装密钥：  
 **注意：这些安装密不能激活Windows 8，只是用于安装罢了！**  
 **WMC = Windows Media Center**  

<table>
<colgroup>
<col width="50%" />
<col width="50%" />
</colgroup>
<tbody>
<tr class="odd">
<td align="left"><strong>版本（英文正式版）</strong>
<strong>安装密钥</strong></td>
<td align="left">Windows 8 Professional x86 + Core
Core = FB4WR-32NVD-4RW79-XQFWH-CYQG3<br /> <strong><br /></strong> <strong>Professional = XKY4K-2NRWR-8F6P2-448RF-CRYQH</strong><br /> Professional WMC = RR3BN-3YY9P-9D7FC-7J4YF-QGJXW<br /><br /></td>
</tr>
</tbody>
</table>

  

## **开始在USB内安装Windows 8!**

**工具：**  
 1、一只随身碟（建议20GB以上的）  
 2、[Windows 7
AIK](http://download.microsoft.com/download/8/E/9/8E9BBC64-E6F8-457C-9B8D-F6C9A16E6D6A/KB3AIK_EN.iso)
（用来挂载WIM映像档案）  
  

### **用DiskPart 分区（资料会丢失）**

1、打开CMD，输入**Diskpart**  

[![image](http://lh5.ggpht.com/-sysPaxazumY/UJIpsB_O5xI/AAAAAAAACdk/AXrK3tqDPuY/image_thumb%25255B1%25255D.png?imgmax=800 "image")](http://lh4.ggpht.com/-ZCILUJ-AYSw/UJIprDrxQII/AAAAAAAACdc/5V99Cpp-Eq4/s1600-h/image%25255B3%25255D.png)  
  
 2、输入**list disk**  

[![image](http://lh3.ggpht.com/-nr1IqoVder8/UJIpuLV4eBI/AAAAAAAACd0/ksEtml6nwIg/image_thumb%25255B2%25255D.png?imgmax=800 "image")](http://lh4.ggpht.com/-CQzouyomP2U/UJIptOf1VCI/AAAAAAAACdo/tPZecgivxmY/s1600-h/image%25255B6%25255D.png)  
  
 3、由此可见，我的随身碟上是Disk 3，输入 **select disk 3**  

[![image](http://lh3.ggpht.com/-2ZuWfYPbTvY/UJIpwa6nF8I/AAAAAAAACeE/HStRAilFLR4/image_thumb%25255B5%25255D.png?imgmax=800 "image")](http://lh4.ggpht.com/-xGyGyGAytPA/UJIpvRuEM7I/AAAAAAAACd4/YyZTfuikWo0/s1600-h/image%25255B15%25255D.png)  
  
 4、输入**clean（此步骤将完全清除随身碟上的数据！）**  

[![image](http://lh4.ggpht.com/-0RWYnjeWsmc/UJIpz-nG_ZI/AAAAAAAACeU/vsUhuFUaBYc/image_thumb%25255B6%25255D.png?imgmax=800 "image")](http://lh6.ggpht.com/-uzc5VS_8EYc/UJIpxiodYRI/AAAAAAAACeM/IJyfkn1vO38/s1600-h/image%25255B18%25255D.png)  
  
 5、输入**create partition primary size=30720** 来创建主分区（size=30720
是分区大小，以MB为单位，30720MB=30GB）  
 如果要把整个随身碟当作分区，就输入**create partition primary**  

### [![image](http://lh5.ggpht.com/-Iq_vlctgv68/UJIp6Gy-JqI/AAAAAAAACek/9uX2FWYlpHU/image_thumb%25255B7%25255D.png?imgmax=800 "image")](http://lh3.ggpht.com/-a2JCq5eTcjY/UJIp0xFxjJI/AAAAAAAACeY/DCb50WL9JS8/image%25255B21%25255D.png?imgmax=800)

  
 6、输入**select partition 1**  

[![image](http://lh3.ggpht.com/-CT68Zh6wIe8/UJIp8Tl_OOI/AAAAAAAACew/yz0OAbhcI2g/image_thumb%25255B8%25255D.png?imgmax=800 "image")](http://lh6.ggpht.com/-_j2PLRo1KIg/UJIp7OgrRqI/AAAAAAAACes/5FHdFEpaSDU/s1600-h/image%25255B24%25255D.png)  
  
 <s>7、输入**format fs=ntfs quick label="Windows 8"**
来格式化以及给分区一个名字（label="Windows 8"就是分区名，</s>Windows XP
下的diskpart似乎没有这个参数）  
 7、输入**active**  

[![image](http://lh6.ggpht.com/-ITl22PDO5S8/UJIp-CY7N8I/AAAAAAAACfE/OG1HuHWE-Mg/image_thumb%25255B9%25255D.png?imgmax=800 "image")](http://lh4.ggpht.com/-cv6NUROjAmc/UJIp9Ig5FiI/AAAAAAAACe8/joLwHRg-yaw/s1600-h/image%25255B27%25255D.png)  
  
 8、然后在输入**assign**  

[![image](http://lh3.ggpht.com/-lFNNO3plUPw/UJIqAklyXbI/AAAAAAAACfU/yfbqQ1l3CXA/image_thumb%25255B10%25255D.png?imgmax=800 "image")](http://lh4.ggpht.com/-tcoMUDZIFWA/UJIp_uLbBGI/AAAAAAAACfI/4smDsYy9RSc/s1600-h/image%25255B30%25255D.png)  
  
 10、在My computer 下右击随身盘，选择format （由于在Windows XP
下的Diskpart 没有format 这个参数，只好用my computer 下的format
向导了）  

[![image](http://lh4.ggpht.com/-7L9FOxh7dP0/UJIqGnpb2wI/AAAAAAAACfk/6QGYtwd8xfs/image_thumb%25255B11%25255D.png?imgmax=800 "image")](http://lh5.ggpht.com/-vptK6hRpMtE/UJIqBul0MVI/AAAAAAAACfY/2mw1fBrSG2I/image%25255B33%25255D.png?imgmax=800)  
  
 11、File System 选择**NTFS**，在Volume Label内填入“Windows
8”（也可以是其他的），勾上“Quick Format”  

[![image](http://lh6.ggpht.com/-BPgEZYZ2wfA/UJIqJ3EYobI/AAAAAAAACf0/8NbUSN-u2BY/image_thumb%25255B13%25255D.png?imgmax=800 "image")](http://lh5.ggpht.com/-0LK3OcJnc4Q/UJIqHmQkBjI/AAAAAAAACfs/RxYUtauzlYk/s1600-h/image%25255B39%25255D.png)  
  
 12、点击OK，完成！  

[![image](http://lh6.ggpht.com/--TjnZilUcBg/UJIqL5aEWdI/AAAAAAAACgA/HpGUc0rml54/image_thumb%25255B14%25255D.png?imgmax=800 "image")](http://lh5.ggpht.com/-_7SadVpBpgk/UJIqLN8GB-I/AAAAAAAACf8/OKCC9ocot6o/s1600-h/image%25255B42%25255D.png)  

[![image](http://lh4.ggpht.com/-NIRnFf2ed4U/UJIqNrzLWWI/AAAAAAAACgQ/uiRaTjQVNWM/image_thumb%25255B15%25255D.png?imgmax=800 "image")](http://lh3.ggpht.com/-bDanMoG7m0g/UJIqMxTVAzI/AAAAAAAACgM/wyy_L9vneWw/s1600-h/image%25255B45%25255D.png)  
  
  

### **安装Windows 7 AIK**

Windows 7 AIK 是ISO 档案的，必须用ISO挂载工具过载ISO  

建议使用**魔方的虚拟光驱（[点击这里下载](http://www.mediafire.com/?9q2cb7qpiscp5ks)）**  
 1、打开魔方虚拟光驱，选择“加载镜像”，选择Windows 7 AIK的ISO镜像档  

[![image](http://lh6.ggpht.com/-QUdCwiIQpgM/UJH6BDQIqsI/AAAAAAAACaA/mljbkyuLTX0/image_thumb%25255B15%25255D.png?imgmax=800 "image")](http://lh5.ggpht.com/-7XJ7I_1Knf0/UJH5_0lUNrI/AAAAAAAACZ0/v6GHrgLA1MM/s1600-h/image%25255B47%25255D.png)  
  
 2、到My Computer，点击KB3AIK\_EN，就可以开始安装Windows AIK  

[![image](http://lh3.ggpht.com/-88FQO-jxBx8/UJH6DUNIDxI/AAAAAAAACaQ/Cq001CaTL84/image_thumb%25255B16%25255D.png?imgmax=800 "image")](http://lh6.ggpht.com/-gi37f-0x8yQ/UJH6CaRP8lI/AAAAAAAACaI/iwLe7unkD2M/s1600-h/image%25255B50%25255D.png)  
  
 3、等待安装完成吧！  
  

### **把WIM映像档安装到随身碟内**

1、再次用魔方虚拟光驱挂载Windows 8 的ISO档案  

[![image](http://lh4.ggpht.com/-E3Yo25Fd55Q/UJH6FvgIvLI/AAAAAAAACac/KqrNN_PWr5s/image_thumb%25255B18%25255D.png?imgmax=800 "image")](http://lh4.ggpht.com/-CiGpQHr00sI/UJH6Eu2crjI/AAAAAAAACaU/PzSlHSFFINk/s1600-h/image%25255B56%25255D.png)  
  
 3、Windows 8 ISO挂载在K:\\ 盘符  

[![image](http://lh5.ggpht.com/-wqmubYcP5PQ/UJH6IYOCBuI/AAAAAAAACaw/ql_6sD2G-q8/image_thumb%25255B19%25255D.png?imgmax=800 "image")](http://lh6.ggpht.com/-5nwatCFH-oA/UJH6HZj7_LI/AAAAAAAACao/mM6JgS7Ncfs/s1600-h/image%25255B59%25255D.png)  
  
 3、安装Windows AIK 后，打开Deployment Tools Command Prompt  

[![image](http://lh4.ggpht.com/-OtS6tvGjP0s/UJH6LDzezSI/AAAAAAAACbA/rCvdTxbXjJE/image_thumb%25255B17%25255D.png?imgmax=800 "image")](http://lh4.ggpht.com/-6Rj5znt4fBk/UJH6JnC8kvI/AAAAAAAACa4/JxENzKXDqT8/s1600-h/image%25255B53%25255D.png)  
  
 4、在Deployment Tools Command Prompt中输入：  
 **imagex /apply K:\\sources\\install.wim 1 I:\\**  
 **其中K:\\是Windows 8 挂载到的盘符，I:\\是随身盘的盘符**  

[![image](http://lh3.ggpht.com/-6MA5z9lVAYo/UJH6Nq-LB7I/AAAAAAAACbM/7H0X2ao0CPs/image_thumb%25255B20%25255D.png?imgmax=800 "image")](http://lh4.ggpht.com/-tN9OlmNXWQw/UJH6MQZ95_I/AAAAAAAACbE/qw26bBjXmWU/s1600-h/image%25255B62%25255D.png)  
  
 5、开始安装：  

[![image](http://lh3.ggpht.com/-kgMuBlnGwyw/UJH6PrSLQ8I/AAAAAAAACbg/f4UQaLRNo0o/image_thumb%25255B21%25255D.png?imgmax=800 "image")](http://lh3.ggpht.com/-OdcLa_RNnSI/UJH6Og_LAUI/AAAAAAAACbU/jR6ICzCMHBE/s1600-h/image%25255B65%25255D.png)  
  
 6、安装完成！  

[![image](http://lh3.ggpht.com/-_yAdqg9D7UY/UJH6R1l-2GI/AAAAAAAACbs/GXlceAonfY4/image_thumb%25255B22%25255D.png?imgmax=800 "image")](http://lh4.ggpht.com/-I7QPcnuFDQQ/UJH6QoGgsII/AAAAAAAACbo/HS3FOSgzUlU/s1600-h/image%25255B68%25255D.png)  
  
 7、最后一个重要的部分，不要急着关闭Deployment Tools Command
Prompt，现在输入这个命令：  
 **bcdboot.exe I:\\windows /s I:\\**  
 **I:\\ 就是随身碟的盘符**  
 **注：在Windows XP下执行此语句会出现错误！**  

[![image](http://lh3.ggpht.com/-CvmhqFMNIGQ/UJH6T5cyLAI/AAAAAAAACb8/oEspzORic6o/image_thumb%25255B23%25255D.png?imgmax=800 "image")](http://lh5.ggpht.com/-fmPy26zDlRQ/UJH6S2B4HaI/AAAAAAAACb0/zTEUTTK_2d8/s1600-h/image%25255B71%25255D.png)  
  
 然后重新开机，在电脑的Boot Menu内把USB设为First Boot，然后就好啦！  

[![image](http://lh3.ggpht.com/-milJzRtCbIc/UJIqQMYob5I/AAAAAAAACgk/cS8RFd4cjKU/image_thumb%25255B17%25255D.png?imgmax=800 "image")](http://lh6.ggpht.com/-1irRR6JE9yc/UJIqOv19xkI/AAAAAAAACgc/fmMVhjglWQk/s1600-h/image%25255B49%25255D.png)  
  
  
  
 激活Windows 8
看这里》》http://garyngzhongbo.blogspot.com/2012/11/windows-8.html

