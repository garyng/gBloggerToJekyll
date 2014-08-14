---
layout: post
title: '[原创教程] Windows 8 Consumer Preview 虚拟机内安装教程'
author: 'Gary Ng'
tags: ['vmware','windows 8','windows 8 Consumer preview','windows 8 install','原创','教程']
---

通宵地把 2.53GB 的 Windows 8 Consumer Preview （以下都简称 “Windows 8
CP”）下载完了，就是为了这篇教程 和 笔者自己想试玩的欲望。  
 （什么？还没下载？快到这里下载吧！—— [【操作系统】万众期待的Windows 8
Consumer
Preview终于释出啦！](http://garyngzhongbo.blogspot.com/2012/03/windows-8-consumer-preview.html)）  
 为了电脑内的文件的安全，笔者选把Windows 8 CP
安装在虚拟机内，以防出了什么差错，后悔都来不及了。  

> 在整个安装过程中，笔者遇到了N多问题。。。  
>  VirtualBox 内安装不了 Windows 8 CP
> （也许是笔者的电脑配置很差吧？）、VMware Workstation
> （以下都简称“VMware
> WS”了啊～）安装不了（又花了几个小时来找问题的源头，竟然还误删注册表信息）、安装VMware
> WS 时遇到蓝屏（安装网络驱动时就这样了，上论坛查询，初步断定是VMware
> WS的驱动与键盘冲突导致的，花了几个小时来还原系统啊）、系统还原时竟然删掉了VMware
> WS的安装文件（又花了2个小时下载）、还有网络竟然无端端的断线  
>  只能说：好事多磨啊！

好啦好啦，转入正题！  
  
 这次笔者选用 VMware Workstation 来安装Windows 8
CP，原因是笔者花了几个小时在VirtualBox上安装Windows 8 CP
没一次能成功，读者们可以自己试用VirtualBox来安装Windows 8
CP，设置方法与安装Windows 8 Developer
Preview一样（更多详情请浏览[【原创教程】【Windows 8预览版介绍】Virtual
Box玩Windows
8!](http://garyngzhongbo.blogspot.com/2011/10/windows-8virtual-boxwindows-8.html)）！  
 注：笔者测试Windows 8 CP 的操作环境是 Windows Vista Home Premium x86
SP2  
  
 工欲善其事，必先利其器嘛！首先，当然是到VMware官方网站下载 [VMware
Workstation](http://downloads.vmware.com/d/info/desktop_end_user_computing/vmware_workstation/8_0)
!  

[![r2js4exg.2qz](http://lh5.ggpht.com/-wzDFvpd0DrQ/T1Qu__dRRMI/AAAAAAAABNo/BrbulPJ-cUk/r2js4exg.2qz_thumb.png?imgmax=800 "r2js4exg.2qz")](http://lh4.ggpht.com/-zcrOqfz2_aw/T1Qu-xOkxvI/AAAAAAAABNg/fRquKc--igA/s1600-h/r2js4exg.2qz3.png)  
  
 读者必须先注册为VMware用户，才能下载VMware Workstation（下面简称“VMware
WS”）！下载过下来的VMware WS 还得输入注册码才能激活，特此附上Vmware WS
8.x 的N个注册码（随便输入一个就够了）：  

[![image](http://lh5.ggpht.com/-tQOsziiX_-E/T1QvDBHQZ1I/AAAAAAAABN4/1fEteIjHgUo/image_thumb34.png?imgmax=800 "image")](http://lh6.ggpht.com/-aUYupPlya8A/T1QvBo2brcI/AAAAAAAABNw/HhfufkMg-f8/s1600-h/image36.png)  
  
 在下载VMware WS （大概500MB啊）的当儿，读者们可以看看以下关于Windows 8
CP 的影片～  

[![videocapture-jGbaAQyz8Q0](http://lh5.ggpht.com/-2ZWWjaxC_cw/T1QvEujuk-I/AAAAAAAABOA/4NgOEJFeKk8/videocapture-jGbaAQyz8Q02.png?imgmax=800 "videocapture-jGbaAQyz8Q0")](http://www.youtube.com/watch?v=jGbaAQyz8Q0)

VMware WS下载完了后，就马上开始吧！  
 1、当然是先开启 VMware WS程序咯～  
  
 2、程序开启后，点击”Create A New Virtual Machine”  
 [![2012-03-03
18-59-30](http://lh6.ggpht.com/-0zhgZB0d4sw/T1QvHYm8UMI/AAAAAAAABOQ/O9tVL70FvV0/2012-03-03-18-59-30_thumb5.png?imgmax=800 "2012-03-03 18-59-30")](http://lh5.ggpht.com/-eC0h0X0ZznU/T1QvF-8NueI/AAAAAAAABOI/AtgZ8244nQc/s1600-h/2012-03-03-18-59-306.png)  
  
 3、然后选择 “Custom (advanced)”，点击Next  
 [![2012-03-03
19-00-06](http://lh4.ggpht.com/-j5mrFgSEIYg/T1QvKbeKCuI/AAAAAAAABOg/gGhwmppH9TM/2012-03-03-19-00-06_thumb1.png?imgmax=800 "2012-03-03 19-00-06")](http://lh5.ggpht.com/-sx0n7ZAhPWU/T1QvI-e1ABI/AAAAAAAABOY/_aT0X9D98lg/s1600-h/2012-03-03-19-00-065.png)  
  
 4、点击Next  
 [![2012-03-03 22-28-06\_new virtual machine
wizard](http://lh4.ggpht.com/-y1HYG9uT-48/T1QvNqWNA2I/AAAAAAAABOw/AY-CKyNtIsk/2012-03-03-22-28-06_new-virtual-mach%25255B1%25255D.png?imgmax=800 "2012-03-03 22-28-06_new virtual machine wizard")](http://lh5.ggpht.com/-4Je-KunM4u4/T1QvMMdMkgI/AAAAAAAABOo/RO0QyumSXtQ/s1600-h/2012-03-03-22-28-06_new-virtual-mach.png)  
  
 5、选择 “I will install the operating system later”，点击 Next  
 [![2012-03-03 22-28-29\_new virtual machine
wizard](http://lh6.ggpht.com/-YCsX2oLzXxI/T1QvPtf789I/AAAAAAAABPA/ePZ6eMaVmSc/2012-03-03-22-28-29_new-virtual-mach.png?imgmax=800 "2012-03-03 22-28-29_new virtual machine wizard")](http://lh5.ggpht.com/-wGV3ZEepCUQ/T1QvOZdjXmI/AAAAAAAABO4/kKX4tgiLHCk/s1600-h/2012-03-03-22-28-29_new-virtual-mach%25255B2%25255D.png)  
  
 6、选择“Microsoft Windows”，然后在下拉菜单中选择“Windows 7”，点击
Next  
 [![2012-03-03 22-28-53\_new virtual machine
wizard](http://lh6.ggpht.com/-a-2t3PTtGzs/T1QvSHK9fOI/AAAAAAAABPQ/CdXVJpRx5C0/2012-03-03-22-28-53_new-virtual-mach.png?imgmax=800 "2012-03-03 22-28-53_new virtual machine wizard")](http://lh6.ggpht.com/-oi_FiruVUV4/T1QvQ0a-HbI/AAAAAAAABPI/_fakFN654-c/s1600-h/2012-03-03-22-28-53_new-virtual-mach%25255B1%25255D.png)  
  
 7、为虚拟机取个名字吧！再点Next  
 [![2012-03-03 22-29-18\_new virtual machine
wizard](http://lh5.ggpht.com/-KCM6ZG499YA/T1QvUgPiufI/AAAAAAAABPg/Q1b4yjgSUQg/2012-03-03-22-29-18_new-virtual-mach%25255B1%25255D.png?imgmax=800 "2012-03-03 22-29-18_new virtual machine wizard")](http://lh3.ggpht.com/-6fFJQIG_PY4/T1QvTEnq1fI/AAAAAAAABPY/MEibbrQ8BZw/s1600-h/2012-03-03-22-29-18_new-virtual-mach%25255B2%25255D.png)  
  

8、这儿可以根据读者的电脑而设定，笔者的电脑配置比较差，所以选1个，设置好后，点击Next  
 [![2012-03-03 22-29-42\_new virtual machine
wizard](http://lh3.ggpht.com/-lvgtx24cTSw/T1QvW9lTzbI/AAAAAAAABPw/lkFn1aVKRrI/2012-03-03-22-29-42_new-virtual-mach.png?imgmax=800 "2012-03-03 22-29-42_new virtual machine wizard")](http://lh5.ggpht.com/-jQDsjF36hSM/T1QvVgGiGwI/AAAAAAAABPk/UYi6fyRlrrQ/s1600-h/2012-03-03-22-29-42_new-virtual-mach%25255B2%25255D.png)  
  
 9、这里是设置虚拟机的内存大小，Windows 8 CP 32-bit 的最低要
1024MB，所以我们选1024MB吧～点击Next  
 注：内存大小必须是4的倍数！  
 [![2012-03-03 22-30-10\_new virtual machine
wizard](http://lh5.ggpht.com/-PTD6_F5XBrM/T1QvZ4-RSvI/AAAAAAAABQA/be9zid6zI78/2012-03-03-22-30-10_new-virtual-mach%25255B1%25255D.png?imgmax=800 "2012-03-03 22-30-10_new virtual machine wizard")](http://lh3.ggpht.com/-K1s881jLVVE/T1QvYhoQ7xI/AAAAAAAABP4/gR0MyZMUVGA/s1600-h/2012-03-03-22-30-10_new-virtual-mach.png)  
  
 10、这里建议选 “Use bridged
networking”（别怕，过后还能在设置的～），点击 Next  
 [![2012-03-03 22-30-40\_new virtual machine
wizard](http://lh3.ggpht.com/-ZRzFCOmhdI8/T1Qvcg7s3LI/AAAAAAAABQQ/s2RXBKNDbyo/2012-03-03-22-30-40_new-virtual-mach%25255B1%25255D.png?imgmax=800 "2012-03-03 22-30-40_new virtual machine wizard")](http://lh6.ggpht.com/-uyZyi0ZjVM0/T1QvbFYlfxI/AAAAAAAABQI/KJWUElFKYTk/s1600-h/2012-03-03-22-30-40_new-virtual-mach%25255B2%25255D.png)  
  
 11、选”LSI Logic SAS (Recommended)“，点击 Next  
 [![2012-03-03 22-31-03\_new virtual machine
wizard](http://lh3.ggpht.com/-i9MESq5j3mU/T1QvfJkq0kI/AAAAAAAABQg/AokE6fuNzOw/2012-03-03-22-31-03_new-virtual-mach.png?imgmax=800 "2012-03-03 22-31-03_new virtual machine wizard")](http://lh6.ggpht.com/-0hc9KJfLYdk/T1QveK3J5xI/AAAAAAAABQY/WOxKC-V_3Lo/s1600-h/2012-03-03-22-31-03_new-virtual-mach%25255B1%25255D.png)  
  
 12、到了设置虚拟硬碟的时候啦！选择“Create a new virtual hardisk”，点击
Next  
 [![2012-03-03 22-31-18\_new virtual machine
wizard](http://lh3.ggpht.com/-GYWFISN6d2c/T1Qvid9pZgI/AAAAAAAABQw/rxxt5_sCCOY/2012-03-03-22-31-18_new-virtual-mach.png?imgmax=800 "2012-03-03 22-31-18_new virtual machine wizard")](http://lh6.ggpht.com/-kuQ3eyzCpMg/T1QvhJlZMiI/AAAAAAAABQo/idDUasT-9Nc/s1600-h/2012-03-03-22-31-18_new-virtual-mach%25255B1%25255D.png)  
  
 13、选择“SCSI (Recommended)”，点击Next  
 [![2012-03-03 22-31-33\_new virtual machine
wizard](http://lh6.ggpht.com/-TqTjdwehOt8/T1Qvk_YOuoI/AAAAAAAABRA/ljBG91l3wkQ/2012-03-03-22-31-33_new-virtual-mach.png?imgmax=800 "2012-03-03 22-31-33_new virtual machine wizard")](http://lh6.ggpht.com/-l8DS1PQvqGY/T1QvjkKbU0I/AAAAAAAABQ4/aVa2K8mUDdg/s1600-h/2012-03-03-22-31-33_new-virtual-mach%25255B2%25255D.png)  
  
  
 14、在“Maximum disk size (GB)
”那儿设置虚拟硬盘最大大小，推荐大于40GB，然后选择“Split virtual disk
into multiple files”，在点击Next  
 [![2012-03-03 22-32-13\_new virtual machine
wizard](http://lh6.ggpht.com/-qf_UBqtyHMg/T1QvmzcGd-I/AAAAAAAABRQ/dwHMUKawjlc/2012-03-03-22-32-13_new-virtual-mach%25255B1%25255D.png?imgmax=800 "2012-03-03 22-32-13_new virtual machine wizard")](http://lh4.ggpht.com/-xpqjSpeLGy0/T1QvlxcoJDI/AAAAAAAABRI/qFuNNAe98fg/s1600-h/2012-03-03-22-32-13_new-virtual-mach%25255B2%25255D.png)  
  
 15、这里是设置每个虚拟硬盘的名称，每个虚拟硬盘的大小是固定的，那就是
2GB，过后点击Next 就是了  
 [![2012-03-03 22-32-35\_new virtual machine
wizard](http://lh6.ggpht.com/-nmAmUbDE9xc/T1QvpZzYkoI/AAAAAAAABRg/fgLXw4tu_Ug/2012-03-03-22-32-35_new-virtual-mach.png?imgmax=800 "2012-03-03 22-32-35_new virtual machine wizard")](http://lh5.ggpht.com/-W4iI4pulJBY/T1QvoJQM8OI/AAAAAAAABRY/nhHX11v98Gw/s1600-h/2012-03-03-22-32-35_new-virtual-mach%25255B2%25255D.png)  
  
 16、这里显示的是虚拟机的信息，点击Finish  
 [![2012-03-03 22-33-11\_new virtual machine
wizard](http://lh5.ggpht.com/-zOIIfGxzc3c/T1Qvr9I9p3I/AAAAAAAABRw/QC-2yHXIIhM/2012-03-03-22-33-11_new-virtual-mach.png?imgmax=800 "2012-03-03 22-33-11_new virtual machine wizard")](http://lh3.ggpht.com/-mAo4QJCzZP0/T1Qvqs-0i4I/AAAAAAAABRo/nrXY-g4X96I/s1600-h/2012-03-03-22-33-11_new-virtual-mach%25255B2%25255D.png)  
  
  
 17、回到主界面，选择Windows 8 Consumer Preview 的虚拟机后，在点击“Edit
virtual machine settings”  
 [![2012-03-03 22-34-02\_windows 8 consumer preview - vmware
workstation](http://lh3.ggpht.com/-rxWxOCRrgkg/T1QvuJEW7cI/AAAAAAAABSA/WAbwtNG56IQ/2012-03-03-22-34-02_windows-8-consum%25255B1%25255D.png?imgmax=800 "2012-03-03 22-34-02_windows 8 consumer preview - vmware workstation")](http://lh4.ggpht.com/-DWgVKjY0W8s/T1QvtOunn9I/AAAAAAAABR4/DSFX6Opsa_8/s1600-h/2012-03-03-22-34-02_windows-8-consum.png)  
  
 18、然后点击”Floppy”，点击下方的Remove以去掉Floppy  
 [![2012-03-03 22-34-25\_virtual machine
settings](http://lh5.ggpht.com/-yS3JtUS0u30/T1QvxI_MFBI/AAAAAAAABSQ/HITBy3UYZrM/2012-03-03-22-34-25_virtual-machine-%25255B1%25255D.png?imgmax=800 "2012-03-03 22-34-25_virtual machine settings")](http://lh3.ggpht.com/-FGKAxcOVPbA/T1QvvvdIZsI/AAAAAAAABSI/4EcCH_monZE/s1600-h/2012-03-03-22-34-25_virtual-machine-.png)  
  
 19、在选择”CD/DVD(IDE)“，选择“Use ISO image file”，点击Browse  
 [![2012-03-03 22-34-50\_virtual machine
settings](http://lh4.ggpht.com/-pTCdbpO0xRQ/T1QvzgcFw8I/AAAAAAAABSg/Y6moC2IzlyE/2012-03-03-22-34-50_virtual-machine-%25255B2%25255D.png?imgmax=800 "2012-03-03 22-34-50_virtual machine settings")](http://lh6.ggpht.com/-ItRQevsz-Ww/T1Qvyh3DERI/AAAAAAAABSY/EDDvlCVtWKc/s1600-h/2012-03-03-22-34-50_virtual-machine-.png)  
  
 20、选择下载好的Windows 8 CP 影像文件，点击Open  
 [![2012-03-03 22-35-25\_browse for iso
image](http://lh6.ggpht.com/-BEVXDcVWW6Y/T1Qv2oxj1gI/AAAAAAAABSw/sg-g1pPtwlg/2012-03-03-22-35-25_browse-for-iso-i.png?imgmax=800 "2012-03-03 22-35-25_browse for iso image")](http://lh4.ggpht.com/-49qNYvnVN7s/T1Qv1CaPd4I/AAAAAAAABSo/uOLdJGU86GY/s1600-h/2012-03-03-22-35-25_browse-for-iso-i%25255B2%25255D.png)  
  
 21、过后再点击OK  
 [![2012-03-03 22-36-07\_virtual machine
settings](http://lh5.ggpht.com/-BdYXBYDnoNk/T1Qv5OYonRI/AAAAAAAABTA/-CH0Mq4k_Oc/2012-03-03-22-36-07_virtual-machine-.png?imgmax=800 "2012-03-03 22-36-07_virtual machine settings")](http://lh6.ggpht.com/-JzVwZiWbIpw/T1Qv3lhLQqI/AAAAAAAABS0/yXqtAwCZFZ4/s1600-h/2012-03-03-22-36-07_virtual-machine-%25255B2%25255D.png)  
  

22、到这里，虚拟机基本上已经设置好了，现在来启动吧！（很紧张对吧？）点击上方的[![2012-03-03
22-38-06\_windows 8 consumer preview - vmware
workstation](http://lh6.ggpht.com/-F3yELb0HZbY/T1Qv7EhJQwI/AAAAAAAABTM/nu2z35WPXiM/2012-03-03-22-38-06_windows-8-consum.png?imgmax=800 "2012-03-03 22-38-06_windows 8 consumer preview - vmware workstation")](http://lh3.ggpht.com/-GIeodNJem34/T1Qv6KkyCdI/AAAAAAAABTE/YNB7HT_O9pQ/s1600-h/2012-03-03-22-38-06_windows-8-consum%25255B5%25255D.png)按钮  
 [![2012-03-03 22-38-06\_windows 8 consumer preview - vmware
workstation](http://lh6.ggpht.com/-6MQojDKly10/T1Qv9CZJNPI/AAAAAAAABTg/yR0qybM33ic/2012-03-03-22-38-06_windows-8-consum%25255B2%25255D.png?imgmax=800 "2012-03-03 22-38-06_windows 8 consumer preview - vmware workstation")](http://lh4.ggpht.com/-hy0sBscn48g/T1Qv8CGz03I/AAAAAAAABTY/wQyA1fzZK3Q/s1600-h/2012-03-03-22-38-06_windows-8-consum%25255B3%25255D.png)  
  
 23、全新的开机动画现身！  
 [![2012-03-03 22-39-07\_windows 8 consumer preview - vmware
workstation](http://lh4.ggpht.com/-oFw5ULIRmiE/T1Qv_zvIh4I/AAAAAAAABTw/VXu6pf42TGM/2012-03-03-22-39-07_windows-8-consum.png?imgmax=800 "2012-03-03 22-39-07_windows 8 consumer preview - vmware workstation")](http://lh3.ggpht.com/-5-coZ0Lu8PA/T1Qv-lbkKiI/AAAAAAAABTo/trpkNEtMM4M/s1600-h/2012-03-03-22-39-07_windows-8-consum%25255B1%25255D.png)  
 额。。还不错吧。。  
  
 24、开始安装Windows 8 CP 了！点击Next  
 [![2012-03-03 22-40-20\_windows 8 consumer preview - vmware
workstation](http://lh6.ggpht.com/-GPA2PS3_z4c/T1QwCy9eKEI/AAAAAAAABUA/1ytyhcWj8ck/2012-03-03-22-40-20_windows-8-consum.png?imgmax=800 "2012-03-03 22-40-20_windows 8 consumer preview - vmware workstation")](http://lh6.ggpht.com/-pY4sh6Ftfp0/T1QwBVv4UpI/AAAAAAAABT4/fVM90ss0t64/s1600-h/2012-03-03-22-40-20_windows-8-consum%25255B2%25255D.png)  
  
 25、点击 Install Now  
 [![2012-03-03 22-40-39\_windows 8 consumer preview - vmware
workstation](http://lh5.ggpht.com/-Skqw4-kt6kI/T1QwFB7ILMI/AAAAAAAABUQ/Alg9Cq2jdKo/2012-03-03-22-40-39_windows-8-consum%25255B2%25255D.png?imgmax=800 "2012-03-03 22-40-39_windows 8 consumer preview - vmware workstation")](http://lh3.ggpht.com/-KYHPyYWZWJI/T1QwD5EPA5I/AAAAAAAABUI/2knvwMfQQPw/s1600-h/2012-03-03-22-40-39_windows-8-consum.png)  
  
 26、等待。。。  
 [![2012-03-03 22-40-54\_windows 8 consumer preview - vmware
workstation](http://lh4.ggpht.com/-ZhW24zHvMF0/T1QwHEdvyfI/AAAAAAAABUg/FB80UBOguU8/2012-03-03-22-40-54_windows-8-consum%25255B2%25255D.png?imgmax=800 "2012-03-03 22-40-54_windows 8 consumer preview - vmware workstation")](http://lh5.ggpht.com/-c16BVrxym8A/T1QwGCygYuI/AAAAAAAABUU/DETkvYTe_6A/s1600-h/2012-03-03-22-40-54_windows-8-consum%25255B1%25255D.png)  
  
 27、输入序列号  
 [![2012-03-03 22-42-04\_windows 8 consumer preview - vmware
workstation](http://lh6.ggpht.com/-1QgGM8pnoik/T1QwKlwrhzI/AAAAAAAABUw/7H5mAky_UNk/2012-03-03-22-42-04_windows-8-consum%25255B1%25255D.png?imgmax=800 "2012-03-03 22-42-04_windows 8 consumer preview - vmware workstation")](http://lh5.ggpht.com/-1bS3CiaoTaA/T1QwJWGnmTI/AAAAAAAABUo/VwmrJ_kq1uc/s1600-h/2012-03-03-22-42-04_windows-8-consum.png)  
  
 28、点击 “I accept the license terms”  
 [![2012-03-03 22-42-33\_windows 8 consumer preview - vmware
workstation](http://lh4.ggpht.com/-BCrXatFFOeQ/T1QwNqg1xQI/AAAAAAAABVA/o3RGQQH3cko/2012-03-03-22-42-33_windows-8-consum.png?imgmax=800 "2012-03-03 22-42-33_windows 8 consumer preview - vmware workstation")](http://lh5.ggpht.com/-aAMw-nPXoBs/T1QwMFcsafI/AAAAAAAABU4/kdW_jkGyagM/s1600-h/2012-03-03-22-42-33_windows-8-consum%25255B2%25255D.png)  
  
 29、选择“Custom: Install Windows only (advanced)”  
 [![2012-03-03 22-42-58\_windows 8 consumer preview - vmware
workstation](http://lh3.ggpht.com/-Q27TByE7ho8/T1QwQsnYOwI/AAAAAAAABVQ/QKZr9rQIrwI/2012-03-03-22-42-58_windows-8-consum%25255B2%25255D.png?imgmax=800 "2012-03-03 22-42-58_windows 8 consumer preview - vmware workstation")](http://lh4.ggpht.com/-nh6eKuHGz_0/T1QwPNgLQyI/AAAAAAAABVI/L3zXQgPuauQ/s1600-h/2012-03-03-22-42-58_windows-8-consum%25255B1%25255D.png)  
  
 30、选择硬盘，然后点击Next  
 [![2012-03-03 22-43-15\_windows 8 consumer preview - vmware
workstation](http://lh6.ggpht.com/-rs-WMw53bww/T1QwTlHrGbI/AAAAAAAABVg/bPs2Z4RuPDg/2012-03-03-22-43-15_windows-8-consum%25255B1%25255D.png?imgmax=800 "2012-03-03 22-43-15_windows 8 consumer preview - vmware workstation")](http://lh6.ggpht.com/-hCUqfzJpm2c/T1QwSIVVKWI/AAAAAAAABVY/7CIxjcxI8ak/s1600-h/2012-03-03-22-43-15_windows-8-consum.png)  
  
 31、Windows 8 CP 开始安装了  
 [![2012-03-03 22-44-56\_windows 8 consumer preview - vmware
workstation](http://lh5.ggpht.com/-tJCXgPvioSI/T1QwWGmYyMI/AAAAAAAABVw/FuV69dzuEek/2012-03-03-22-44-56_windows-8-consum.png?imgmax=800 "2012-03-03 22-44-56_windows 8 consumer preview - vmware workstation")](http://lh6.ggpht.com/-BzxplZJhfd4/T1QwU_x2J6I/AAAAAAAABVo/oPZ-IiGszFg/s1600-h/2012-03-03-22-44-56_windows-8-consum%25255B2%25255D.png)  
  
 32、点击Restart Now 以便重启系统，让Windows完成安装  
 [![2012-03-03 23-01-19\_windows 8 consumer preview - vmware
workstation](http://lh5.ggpht.com/-UmGVG4tNLPg/T1QwZDAsXGI/AAAAAAAABWA/dWslVB7gjaU/2012-03-03-23-01-19_windows-8-consum%25255B1%25255D.png?imgmax=800 "2012-03-03 23-01-19_windows 8 consumer preview - vmware workstation")](http://lh6.ggpht.com/-vCCAMA82S4s/T1QwXppXmkI/AAAAAAAABV4/gs28oxuPqQ4/s1600-h/2012-03-03-23-01-19_windows-8-consum%25255B2%25255D.png)  
  
 33、重启后再次看到熟悉的界面  
 [![2012-03-03 23-01-51\_windows 8 consumer preview - vmware
workstation](http://lh6.ggpht.com/-0bUo6gA2KuI/T1Qwbrp7rGI/AAAAAAAABWQ/iTrdDq1bSNM/2012-03-03-23-01-51_windows-8-consum.png?imgmax=800 "2012-03-03 23-01-51_windows 8 consumer preview - vmware workstation")](http://lh3.ggpht.com/-9ZTpDFBs41w/T1QwZ1A790I/AAAAAAAABWI/cmzlEjw3Na4/s1600-h/2012-03-03-23-01-51_windows-8-consum%25255B1%25255D.png)  
  
 34、Setup is updating registry settings  
 [![2012-03-03 23-02-27\_windows 8 consumer preview - vmware
workstation](http://lh4.ggpht.com/-66ZbwTNDPSA/T1Qwd1UocKI/AAAAAAAABWg/Q_yARRxKHzc/2012-03-03-23-02-27_windows-8-consum%25255B1%25255D.png?imgmax=800 "2012-03-03 23-02-27_windows 8 consumer preview - vmware workstation")](http://lh5.ggpht.com/-h8Wgi0XJE2w/T1QwcvQOHbI/AAAAAAAABWY/smJziDUmF-Y/s1600-h/2012-03-03-23-02-27_windows-8-consum%25255B2%25255D.png)  
  
 35、Preparing  
 [![2012-03-03 23-03-26\_windows 8 consumer preview - vmware
workstation](http://lh3.ggpht.com/-YMyC7p3eDgU/T1QwgVvF5KI/AAAAAAAABWw/CT-ik4v78O0/2012-03-03-23-03-26_windows-8-consum%25255B2%25255D.png?imgmax=800 "2012-03-03 23-03-26_windows 8 consumer preview - vmware workstation")](http://lh5.ggpht.com/-ZlJ_BF6eGGk/T1QwfZZ_COI/AAAAAAAABWo/BSyRBcrGQ0I/s1600-h/2012-03-03-23-03-26_windows-8-consum.png)  
  
 36、Getting devices ready  
 [![2012-03-03 23-04-24\_windows 8 consumer preview - vmware
workstation](http://lh6.ggpht.com/-cr9SNIE40Jg/T1QwikPTVzI/AAAAAAAABXA/-kqcezQ0YGE/2012-03-03-23-04-24_windows-8-consum%25255B2%25255D.png?imgmax=800 "2012-03-03 23-04-24_windows 8 consumer preview - vmware workstation")](http://lh3.ggpht.com/-cGS4jqohVW4/T1QwhgxoZbI/AAAAAAAABW4/6wBtfdK593s/s1600-h/2012-03-03-23-04-24_windows-8-consum%25255B1%25255D.png)  
  
 37、Getting system ready  
 [![2012-03-03 23-07-52\_windows 8 consumer preview - vmware
workstation](http://lh6.ggpht.com/-VA23zEgbKZw/T1Qwk_6K3YI/AAAAAAAABXQ/Cll8jJRT6gw/2012-03-03-23-07-52_windows-8-consum.png?imgmax=800 "2012-03-03 23-07-52_windows 8 consumer preview - vmware workstation")](http://lh5.ggpht.com/-C77Zwf0Kpk0/T1QwjkN6E3I/AAAAAAAABXI/e467ifn388U/s1600-h/2012-03-03-23-07-52_windows-8-consum%25255B1%25255D.png)  
  
 38、然后又是一个重启，又看到Betta鱼了  
 [![2012-03-03 23-08-38\_windows 8 consumer preview - vmware
workstation](http://lh6.ggpht.com/-PZRYJEIZ3ME/T1QwmyleL7I/AAAAAAAABXg/YAtQp_IzmeM/2012-03-03-23-08-38_windows-8-consum%25255B2%25255D.png?imgmax=800 "2012-03-03 23-08-38_windows 8 consumer preview - vmware workstation")](http://lh5.ggpht.com/-LJTL1mQ17tU/T1Qwl-35VEI/AAAAAAAABXY/VTS5sGvflXQ/s1600-h/2012-03-03-23-08-38_windows-8-consum%25255B1%25255D.png)  
  
 39、Preparing  
 [![2012-03-03 23-10-15\_windows 8 consumer preview - vmware
workstation](http://lh5.ggpht.com/-2Rj7tGo0vpU/T1QwpPDw3QI/AAAAAAAABXw/8CfNmGBFoms/2012-03-03-23-10-15_windows-8-consum%25255B2%25255D.png?imgmax=800 "2012-03-03 23-10-15_windows 8 consumer preview - vmware workstation")](http://lh5.ggpht.com/-lFm5tVhcp5I/T1Qwn9bx1jI/AAAAAAAABXo/KsJZHXvlbNI/s1600-h/2012-03-03-23-10-15_windows-8-consum%25255B1%25255D.png)  
  
 40、好啦！来到了Personalize，Background 是用来调整Windows
的背景颜色，然后在PC name为电脑取个名字吧！  
 [![2012-03-03 23-10-56\_windows 8 consumer preview - vmware
workstation](http://lh6.ggpht.com/-b1SKOzi0NJQ/T1QwroLvKLI/AAAAAAAABYA/n4dVhI2WfAM/2012-03-03-23-10-56_windows-8-consum.png?imgmax=800 "2012-03-03 23-10-56_windows 8 consumer preview - vmware workstation")](http://lh4.ggpht.com/-AT5ys5KRp4o/T1QwqeVmjHI/AAAAAAAABX0/Z-0Qi8YXlQs/s1600-h/2012-03-03-23-10-56_windows-8-consum%25255B2%25255D.png)  
  
 41、按下”Use express setting”  
 [![2012-03-04 18-47-41\_windows 8 consumer preview - vmware
workstation](http://lh3.ggpht.com/-qlx8tIvgfDE/T1QwuSKZtrI/AAAAAAAABYQ/YtSjelQjiPE/2012-03-04-18-47-41_windows-8-consum.png?imgmax=800 "2012-03-04 18-47-41_windows 8 consumer preview - vmware workstation")](http://lh3.ggpht.com/-PR7ioWgeg1s/T1QwtO3miFI/AAAAAAAABYI/YxO03ZHn__8/s1600-h/2012-03-04-18-47-41_windows-8-consum%25255B2%25255D.png)  
  

42、为电脑创建账户、设置密码（注：这是笔者没连上网络时的安装截图，如果连上网络，Windows
会要求输入电子邮件和密码！）  
 [![2012-03-04 18-48-51\_windows 8 consumer preview - vmware
workstation](http://lh5.ggpht.com/-mbpee5ZEd-k/T1QwxKZEwJI/AAAAAAAABYg/lvI5uYSbeIU/2012-03-04-18-48-51_windows-8-consum.png?imgmax=800 "2012-03-04 18-48-51_windows 8 consumer preview - vmware workstation")](http://lh5.ggpht.com/-HED3yUNxB8Y/T1QwvtVqRtI/AAAAAAAABYY/IfcmLtMBX8E/s1600-h/2012-03-04-18-48-51_windows-8-consum%25255B2%25255D.png)  
  
 43、Finalizing you settings  
 [![2012-03-04 18-49-43\_windows 8 consumer preview - vmware
workstation](http://lh4.ggpht.com/-mNy7aR5avTM/T1QwzUfG3HI/AAAAAAAABYw/VVrqtoH8iDk/2012-03-04-18-49-43_windows-8-consum%25255B2%25255D.png?imgmax=800 "2012-03-04 18-49-43_windows 8 consumer preview - vmware workstation")](http://lh3.ggpht.com/-JDyxMraS6fQ/T1QwyFtW26I/AAAAAAAABYo/eLR41UwwhCM/s1600-h/2012-03-04-18-49-43_windows-8-consum%25255B1%25255D.png)  
  
 44、登陆界面：  
 [![2012-03-04 18-50-29\_windows 8 consumer preview - vmware
workstation](http://lh4.ggpht.com/-Nn7hPdXj-xU/T1Qw1vCVCQI/AAAAAAAABZA/kcbQ_ZwuwLA/2012-03-04-18-50-29_windows-8-consum%25255B2%25255D.png?imgmax=800 "2012-03-04 18-50-29_windows 8 consumer preview - vmware workstation")](http://lh5.ggpht.com/-lAXrOPV80JI/T1Qw0dMDaBI/AAAAAAAABY4/uSTw76_EGAo/s1600-h/2012-03-04-18-50-29_windows-8-consum.png)  
 [![2012-03-04 18-50-55\_windows 8 consumer preview - vmware
workstation](http://lh5.ggpht.com/-K6XFWYCPNkE/T1Qw4FK8MsI/AAAAAAAABZQ/Co7jHwyQTT0/2012-03-04-18-50-55_windows-8-consum%25255B1%25255D.png?imgmax=800 "2012-03-04 18-50-55_windows 8 consumer preview - vmware workstation")](http://lh6.ggpht.com/-wovMCAG9Cmc/T1Qw2g43EaI/AAAAAAAABZI/oEwhkvV7zKc/s1600-h/2012-03-04-18-50-55_windows-8-consum%25255B2%25255D.png)  
  
 45、往上拉即可看到大家期待的界面：Metro 界面！  
 [![2012-03-04 18-52-36\_windows 8 consumer preview - vmware
workstation](http://lh5.ggpht.com/-X0a2jeicSf4/T1QxKxJNXrI/AAAAAAAABZg/tHa9rIKMcQ0/2012-03-04-18-52-36_windows-8-consum%25255B2%25255D.png?imgmax=800 "2012-03-04 18-52-36_windows 8 consumer preview - vmware workstation")](http://lh5.ggpht.com/-gmDZEvONrxY/T1QxBZ5fN5I/AAAAAAAABZY/IRWyM4xNSWE/s1600-h/2012-03-04-18-52-36_windows-8-consum%25255B1%25255D.png)  
 [![2012-03-04 18-53-04\_windows 8 consumer preview - vmware
workstation](http://lh4.ggpht.com/-xzKspNnplLc/T1QxOQRGudI/AAAAAAAABZw/slEdbGkh6hE/2012-03-04-18-53-04_windows-8-consum.png?imgmax=800 "2012-03-04 18-53-04_windows 8 consumer preview - vmware workstation")](http://lh6.ggpht.com/-dCJhLEt8XBc/T1QxMxWefYI/AAAAAAAABZo/cXIwlTp2qCQ/s1600-h/2012-03-04-18-53-04_windows-8-consum%25255B1%25255D.png)  
  
 46、传说中的Betta Fish 壁纸！  
 注意到么？-Windows 8 CP 没有 Windows Start 菜单！  
 [![2012-03-04 18-54-01\_windows 8 consumer preview - vmware
workstation](http://lh4.ggpht.com/-JgKo5c-nnIc/T1QxRhXJQfI/AAAAAAAABaA/UkZ3MoMECig/2012-03-04-18-54-01_windows-8-consum%25255B1%25255D.png?imgmax=800 "2012-03-04 18-54-01_windows 8 consumer preview - vmware workstation")](http://lh6.ggpht.com/-2iRfql4ThwU/T1QxP0JSoZI/AAAAAAAABZ4/dYGvkyj7bFs/s1600-h/2012-03-04-18-54-01_windows-8-consum%25255B2%25255D.png)  
  
 好啦，到这里Windows 8 Consumer Preview 就安装成功啦！  
 好好享受Windows 8 CP 的新特性吧！  
 请期待下一篇的试玩及各种功能详解Windows 8 CP的教程！  
  

