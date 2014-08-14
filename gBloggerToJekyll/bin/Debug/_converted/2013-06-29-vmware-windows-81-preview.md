---
layout: post
title: '[原创][教程] VMware 内下载+安装Windows 8.1 Preview'
author: 'Gary Ng'
tags: ['vmware','Windows 8.1','原创','教程']
---

Windows 8 正式版发出有好一段时间了（这里有[USB内安装试玩Windows 8
正式版](http://garyngzhongbo.blogspot.com/2012/11/usbwindows-8.html)、还有[激活Windows
8
正式版的方法](http://garyngzhongbo.blogspot.com/2012/11/windows-8.html)）。  
 但是Windows 8
正式版本的发布却遭到了很多负面的评论：比如去除了传统的Start
Menu啦、增加了Metro Start Screen 啦等等等等。。。  
 不到一年后的6月26日，Microsoft 正式推出了Windows 8.1 的 Preview
版本（可以说是Windows Blue，但是肯定不叫Windows
9！所以别混淆了！），开放给大众下载测试：  
 1、ISO下载，安装时需要序列号  
 2、Windows Store 直接下载，自动化升级。  
 但是为了保险起见，我们还是一如往常的使用虚拟机试玩Windows 8.1
Preview（一下简称Windows 8.1 Pre）！  
  
 【工具】  
 1、俗语说，“工欲善其事，必先利其器”，欲玩Win 8.1
Pre，需装虚拟机。（怎么搞起语文来了？），这里笔者选者了VMWare
Workstation 作为虚拟机的工具。  
<table>
<tbody>
<tr class="odd">
<td align="left"><strong>VMware Workstation</strong><br /> 下载地址：<a href="https://my.vmware.com/web/vmware/info/slug/desktop_end_user_computing/vmware_workstation/9_0?rct=j&amp;q=vmware%20workstation%209&amp;source=web&amp;cd=1&amp;ved=0CCkQFjAA&amp;url=http://www.vmware.com/go/downloadworkstation&amp;ei=DqLNUYe7N4uIrgeom4DAAg&amp;usg=AFQjCNEVKbKEcEsfY7NjAaBQZbrtZtXttg&amp;bvm=bv.48572450,d.bmk&amp;cad=rja" title="https://my.vmware.com/web/vmware/info/slug/desktop_end_user_computing/vmware_workstation/9_0?rct=j&amp;q=vmware%20workstation%209&amp;source=web&amp;cd=1&amp;ved=0CCkQFjAA&amp;url=http://www.vmware.com/go/downloadworkstation&amp;ei=DqLNUYe7N4uIrgeom4DAAg&amp;usg=AFQjCNEVKbKEcEsfY7NjAaBQZbrtZtXttg&amp;bvm=bv.48572450,d.bmk&amp;cad=rja">https://my.vmware.com/web/vmware/info/slug/desktop_end_user_computing/vmware_workstation/9_0?rct=j&amp;q=vmware%20workstation%209&amp;source=web&amp;cd=1&amp;ved=0CCkQFjAA&amp;url=http://www.vmware.com/go/downloadworkstation&amp;ei=DqLNUYe7N4uIrgeom4DAAg&amp;usg=AFQjCNEVKbKEcEsfY7NjAaBQZbrtZtXttg&amp;bvm=bv.48572450,d.bmk&amp;cad=rja</a><br /> (需注册帐号方能下载)<br /><br /> 序列号（任选一）：<br /> <a href="http://lh3.ggpht.com/-5UxcMd7n-Ok/Uc5c5VernEI/AAAAAAAADeI/4_qogD7Bytk/s1600-h/image131.png"><img src="http://lh6.ggpht.com/-D1Ceu42lxOg/Uc5c6Ccr71I/AAAAAAAADeQ/O6Idb7MmOR0/image_thumb43.png?imgmax=800" title="image" alt="image" /></a></td>
</tr>
</tbody>
</table>

  
 2、试玩当然不能少了主角——Windows 8.1 Pre 的ISO 文件！  
 Microsoft 开放了Windows 8.1 Pre 的
ISO安装文件给大众，所以可以根据自己的喜好来下载试玩特定的Win 8.1
版本！  
<table>
<tbody>
<tr class="odd">
<td align="left"><strong>Windows 8.1 Preview ISO</strong><br /> 下载官方页面：<a href="http://windows.microsoft.com/en-us/windows-8/preview-iso" title="http://windows.microsoft.com/en-us/windows-8/preview-iso">http://windows.microsoft.com/en-us/windows-8/preview-iso</a><br /><br /> 序列号：NTTX3-RV7VB-T7X7F-WQYYY-9Y92F</td>
</tr>
</tbody>
</table>

  
 不同语言下载大全：  
<table>
<tbody>
<tr class="odd">
<td align="left"><strong>English 64-bit (x64)</strong><br /> <a href="http://iso.esd.microsoft.com/W81RPI/8FBC5B738CFD9D29D6956B5DA9DF2DFD4F6C1D8AF/WindowsBlue-ClientwithApps-64bit-English-X1899605.iso" title="http://iso.esd.microsoft.com/W81RPI/8FBC5B738CFD9D29D6956B5DA9DF2DFD4F6C1D8AF/WindowsBlue-ClientwithApps-64bit-English-X1899605.iso">http://iso.esd.microsoft.com/W81RPI/8FBC5B738CFD9D29D6956B5DA9DF2DFD4F6C1D8AF/WindowsBlue-ClientwithApps-64bit-English-X1899605.iso</a><br /> 3.8GB<br /> SHA-1: 0xD8076E029292FBC933792D215793045031255FF6<br />  <br /> <strong>English 32-bit (x86)</strong><br /> <a href="http://iso.esd.microsoft.com/W81RPI/8FBC5B738CFD9D29D6956B5DA9DF2DFD4F6C1D8AF/WindowsBlue-ClientwithApps-32bit-English-X1899604.iso" title="http://iso.esd.microsoft.com/W81RPI/8FBC5B738CFD9D29D6956B5DA9DF2DFD4F6C1D8AF/WindowsBlue-ClientwithApps-32bit-English-X1899604.iso">http://iso.esd.microsoft.com/W81RPI/8FBC5B738CFD9D29D6956B5DA9DF2DFD4F6C1D8AF/WindowsBlue-ClientwithApps-32bit-English-X1899604.iso</a><br /> 2.8GB<br /> SHA-1: 0x447CCD24EB3DC6CFD9A42E62A5F6418B578E3CBF<br />  <br /> <strong>Chinese (Simplified) 64-bit (x64)</strong><br /> <a href="http://iso.esd.microsoft.com/W81RPI/8FBC5B738CFD9D29D6956B5DA9DF2DFD4F6C1D8AF/WindowsBlue-ClientwithApps-64bit-ChineseSimplified-X1899611.iso" title="http://iso.esd.microsoft.com/W81RPI/8FBC5B738CFD9D29D6956B5DA9DF2DFD4F6C1D8AF/WindowsBlue-ClientwithApps-64bit-ChineseSimplified-X1899611.iso">http://iso.esd.microsoft.com/W81RPI/8FBC5B738CFD9D29D6956B5DA9DF2DFD4F6C1D8AF/WindowsBlue-ClientwithApps-64bit-ChineseSimplified-X1899611.iso</a><br /> 3.9 GB<br /> SHA-1: 0xA34B8F71DCE39303F81402E2B44DA17117BB8970  <br /> <strong>Chinese (Simplified) 32-bit (x86)</strong><br /> <a href="http://iso.esd.microsoft.com/W81RPI/8FBC5B738CFD9D29D6956B5DA9DF2DFD4F6C1D8AF/WindowsBlue-ClientwithApps-32bit-ChineseSimplified-X1899610.iso" title="http://iso.esd.microsoft.com/W81RPI/8FBC5B738CFD9D29D6956B5DA9DF2DFD4F6C1D8AF/WindowsBlue-ClientwithApps-32bit-ChineseSimplified-X1899610.iso">http://iso.esd.microsoft.com/W81RPI/8FBC5B738CFD9D29D6956B5DA9DF2DFD4F6C1D8AF/WindowsBlue-ClientwithApps-32bit-ChineseSimplified-X1899610.iso</a><br /> 2.9 GB<br /> SHA-1: 0xF394D21EB655867E455B2DCAAEC37A4160F6F812<br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /></td>
</tr>
</tbody>
</table>

  
 笔者选择了Windows 8.1 Preview English x86 2.8GB  
<table>
<tbody>
<tr class="odd">
<td align="left"><strong>Windows 8.1 Preview 安装需求<br /></strong>处理器：1GHz 或更高<br /> RAM： 1GB (x86) 或 2GB(x64)<br /> 硬盘空间： 16GB(x86) 或 20GB(x64)<br /> 显示卡：DirectX9</td>
</tr>
</tbody>
</table>

  
 【安装步骤】  
 1、打开VMware Workstation  
 2、点击Create a New Virtual Machine  

[![image](http://lh4.ggpht.com/-4SAiq1pnJ2Q/Uc2pn4NXbwI/AAAAAAAADd4/dFwObEgoUOI/image_thumb%25255B1%25255D.png?imgmax=800 "image")](http://lh5.ggpht.com/-sZQGPoGn1jE/Uc2pnQheh0I/AAAAAAAADdw/sBSfKC9zWP4/s1600-h/image%25255B5%25255D.png)  
 3、点击Custom(advanced)  

[![image](http://lh6.ggpht.com/-zbh0MM_s6kI/Uc5c7HaT57I/AAAAAAAADeg/oDGOvOD9j38/image_thumb2.png?imgmax=800 "image")](http://lh3.ggpht.com/-7bBGbBDAe24/Uc5c6hZK8TI/AAAAAAAADeY/4ASn98ku33Q/s1600-h/image8.png)  
  
 4、点击Next  

[![image](http://lh5.ggpht.com/-fqv51k5pKy0/Uc5c8Lly-uI/AAAAAAAADew/KTvhAS2EMCI/image_thumb44.png?imgmax=800 "image")](http://lh5.ggpht.com/-AmaAMC98yEc/Uc5c7-zDU5I/AAAAAAAADeo/Ywaq1uAD8bs/s1600-h/image134.png)  
  
 4、点击I will install the operating system later  

[![image](http://lh5.ggpht.com/-l7KBsJv5vNw/Uc5c9GyK2LI/AAAAAAAADe8/8VHA3VQ7YjI/image_thumb24.png?imgmax=800 "image")](http://lh3.ggpht.com/-D0ryKkq1Vig/Uc5c8kFW9kI/AAAAAAAADe4/u7L2DR2BlYA/s1600-h/image74.png)  
  
 5、Guest Operating System 选择Microsoft Windows，Version 选择Windows
8，点击Next  

[![image](http://lh4.ggpht.com/-AM1m_M-TGzs/Uc5c-S1MSsI/AAAAAAAADfQ/nP6qgBpt-eY/image_thumb45.png?imgmax=800 "image")](http://lh5.ggpht.com/-Amu9yKI7e4Y/Uc5c9yfvc_I/AAAAAAAADfI/YDGRT5Ml-GQ/s1600-h/image137.png)  
 6、为虚拟机取名，点击Next  

[![image](http://lh5.ggpht.com/-CM6Z7qWLTx0/Uc5c_j-MmKI/AAAAAAAADfg/SP2stTSskV4/image_thumb10.png?imgmax=800 "image")](http://lh3.ggpht.com/-mHwXT98KsPg/Uc5c-_ixaMI/AAAAAAAADfY/sFPDqPQyqm4/s1600-h/image32.png)  
  
 7、笔者电脑双核心，所以选者2个core，也可以选择1个  

[![image](http://lh5.ggpht.com/-0bU_rVntVT4/Uc5dAlUYtiI/AAAAAAAADfw/W3tUwCQmlAs/image_thumb11.png?imgmax=800 "image")](http://lh6.ggpht.com/-vISCo3SAVFw/Uc5dAEUnJAI/AAAAAAAADfo/hQOAc_C5gQU/s1600-h/image35.png)  
  
 8、Memory调到大概1024MB或以上 (32bit)，点击Next  

[![image](http://lh3.ggpht.com/-UUxMUlvmZ5g/Uc5dB4kFLwI/AAAAAAAADgA/7SNIA4XaCrk/image_thumb12.png?imgmax=800 "image")](http://lh5.ggpht.com/--wnqjCi83Uw/Uc5dBY0ZmTI/AAAAAAAADf4/Ld6tUjUCyTQ/s1600-h/image38.png)  
  
 9、点击Next  

[![image](http://lh3.ggpht.com/-dsIiNaMW54w/Uc5dC42JzjI/AAAAAAAADgQ/YajFLXKuC6Y/image_thumb13.png?imgmax=800 "image")](http://lh3.ggpht.com/-mIHnLNuteq8/Uc5dCSdP8GI/AAAAAAAADgI/dG-fhSd7YBU/s1600-h/image41.png)  
  
 10、点击Next  

[![image](http://lh3.ggpht.com/-AD0e9LbAJ84/Uc5dEOXYRxI/AAAAAAAADgg/h8AJtdlDac8/image_thumb14.png?imgmax=800 "image")](http://lh3.ggpht.com/-pIJZicx9G9U/Uc5dDaJ7F5I/AAAAAAAADgY/tJqu5GYYhw8/s1600-h/image44.png)  
  
 11、点击Next  

[![image](http://lh5.ggpht.com/-VT3hNhoM5tY/Uc5dFExi9SI/AAAAAAAADgw/4FFjgGHs3jo/image_thumb15.png?imgmax=800 "image")](http://lh4.ggpht.com/-dyS6rPBz9hU/Uc5dElLviSI/AAAAAAAADgo/48S1l5LccM8/s1600-h/image47.png)  
  
 12、点击Next  

[![image](http://lh3.ggpht.com/-TUtQ7oiR3lc/Uc5dGVGrVMI/AAAAAAAADhA/4qOrKTybkYg/image_thumb16.png?imgmax=800 "image")](http://lh5.ggpht.com/-eO9QqDFbZ3s/Uc5dFnVwUQI/AAAAAAAADg4/h8rTHyce_5g/s1600-h/image50.png)  
  
 13、点击Next  

[![image](http://lh3.ggpht.com/-P8Z4acJXKMc/Uc5dHSH_D8I/AAAAAAAADhQ/jJHGkHM3e40/image_thumb46.png?imgmax=800 "image")](http://lh4.ggpht.com/-GDrfn04XKM8/Uc5dGzsiWfI/AAAAAAAADhI/aoJ5dcJpmUQ/s1600-h/image140.png)  
  
 14、点击Next  

[![image](http://lh4.ggpht.com/-xNKBr8wavpc/Uc5dIRpc_0I/AAAAAAAADhg/RSAT-RE9L_w/image_thumb19.png?imgmax=800 "image")](http://lh4.ggpht.com/-cnxXqp5Zm-I/Uc5dHiZPXxI/AAAAAAAADhY/Q4ewar-m01E/s1600-h/image59.png)  
  
 15、点击Finish  

[![image](http://lh3.ggpht.com/-79EUoLCcPiM/Uc5dOmcaKpI/AAAAAAAADhw/ISAmzHunaBg/image_thumb25.png?imgmax=800 "image")](http://lh5.ggpht.com/-ZKwX9m9A6w8/Uc5dIwmvETI/AAAAAAAADho/xz89NZrjEKA/s1600-h/image77.png)  
  
 16、回到主页，点击Edit virtual machine settings  

[![image](http://lh4.ggpht.com/-41KYgaUMTgg/Uc5dPzeijuI/AAAAAAAADiA/gfri31WmRJI/image_thumb47.png?imgmax=800 "image")](http://lh4.ggpht.com/-EIHDbAVsQm8/Uc5dPfUUAtI/AAAAAAAADh4/r-iYk-a0mAo/s1600-h/image143.png)  
  
 17、点击CD/DVD(IDE)，勾选Use ISO image file，然后点击Browse…
来选择下载回来的Windows 8.1 Preview ISO 文件  

[![image](http://lh6.ggpht.com/-8tTUZP7e3pw/Uc5dQwSEvDI/AAAAAAAADiQ/3cG-oVam4j0/image_thumb28.png?imgmax=800 "image")](http://lh4.ggpht.com/-lZAA74AHHXs/Uc5dQVIAk1I/AAAAAAAADiI/gC6fQRKUuPY/s1600-h/image86.png)  

[![image](http://lh4.ggpht.com/-5ki2QT31jqk/Uc5dSPTdg9I/AAAAAAAADig/QPPMlGDuqSs/image_thumb29.png?imgmax=800 "image")](http://lh4.ggpht.com/-cKQiHWGrIXk/Uc5dRoe36II/AAAAAAAADiY/R6BF_6kXF4E/s1600-h/image89.png)  
  
 18、点击OK  

[![image](http://lh4.ggpht.com/-1NthVlZad94/Uc5dTJVdj-I/AAAAAAAADiw/gAxqXTfB2Ng/image_thumb30.png?imgmax=800 "image")](http://lh5.ggpht.com/-AJtPUpro5SM/Uc5dSqzAaYI/AAAAAAAADio/KM65zGTc34I/s1600-h/image92.png)  
  
 19、返回主页，点击Power on this virtual machine  

[![image](http://lh5.ggpht.com/-8Q5udkJz67g/Uc5dUbEVfxI/AAAAAAAADjA/bxxB_CW1EUw/image_thumb48.png?imgmax=800 "image")](http://lh3.ggpht.com/-xbCFDdzHlkk/Uc5dT11pBvI/AAAAAAAADi4/pjdcfIU8k8U/s1600-h/image146.png)  
 20、你可以点击这个按钮进入全屏模式  

[![image](http://lh3.ggpht.com/-MQpP9tHR9dA/Uc5dVkG2vlI/AAAAAAAADjQ/i3hBPk0dS3w/image_thumb32.png?imgmax=800 "image")](http://lh4.ggpht.com/-Dj25z-09Ucc/Uc5dU82ekrI/AAAAAAAADjI/pkVepj5FEqY/s1600-h/image98.png)  
  
 21、点击Next  

[![image](http://lh6.ggpht.com/-PmDSxnnf1ko/Uc5dWlKVhjI/AAAAAAAADjg/TJPwZCLBEhM/image_thumb33.png?imgmax=800 "image")](http://lh3.ggpht.com/-qVMPIOgDPY0/Uc5dWK3Ap1I/AAAAAAAADjY/nJ3apWpQ9qQ/s1600-h/image101.png)  
  
 22、点击Install Now  

[![image](http://lh5.ggpht.com/-6pAWKGZaPJE/Uc5ddYutDgI/AAAAAAAADjw/8kpXmB4oBbU/image_thumb34.png?imgmax=800 "image")](http://lh5.ggpht.com/-yArRAjODSZc/Uc5dchpQyuI/AAAAAAAADjo/8xxmzsPJjJw/s1600-h/image104.png)  
  
 23、Setup Is Starting  

[![image](http://lh3.ggpht.com/-jLwz5LkE-Ig/Uc5deQQvP7I/AAAAAAAADj8/sMJPz3eUa8c/image_thumb35.png?imgmax=800 "image")](http://lh6.ggpht.com/-au0NYau4sJ4/Uc5dd3KUuHI/AAAAAAAADj4/KdXThKjJRyg/s1600-h/image107.png)  
  
 24、输入Product Key： NTTX3-RV7VB-T7X7F-WQYYY-9Y92F，点击Next  

[![image](http://lh6.ggpht.com/-QRnrOho7dDI/Uc5dftJhHUI/AAAAAAAADkQ/Wc4F9M1QfUs/image_thumb36.png?imgmax=800 "image")](http://lh6.ggpht.com/-xxH3Vj7pAls/Uc5de_LUplI/AAAAAAAADkI/WGK30cebb5s/s1600-h/image110.png)  
  
 25、点击I accept the license terms，点击Next  

[![image](http://lh4.ggpht.com/--9vkvSRn_3M/Uc5dg5GS5EI/AAAAAAAADkg/_F7zSq1Q9kU/image_thumb37.png?imgmax=800 "image")](http://lh4.ggpht.com/-UacFM3fwI5w/Uc5dgEitd_I/AAAAAAAADkY/QLAH_kok40U/s1600-h/image113.png)  
  
 26、选择Custom: Install Windows Only (advanced)  

[![image](http://lh5.ggpht.com/-m7EJgXhLcCs/Uc5diOiy4dI/AAAAAAAADkw/hVDS6fDmvEs/image_thumb38.png?imgmax=800 "image")](http://lh5.ggpht.com/-LQNHVI1V2sQ/Uc5dhQrVexI/AAAAAAAADko/9ItIq8pduuQ/s1600-h/image116.png)  
  
 27、选择Drive 0，点击Next  

[![image](http://lh3.ggpht.com/-EHTRl2_pN9U/Uc5djKzIfQI/AAAAAAAADlA/V49TBeqOuAs/image_thumb39.png?imgmax=800 "image")](http://lh6.ggpht.com/-348yt4SrBiY/Uc5digaR3kI/AAAAAAAADk4/2WKSXUEsQHM/s1600-h/image119.png)  
  
 28、开始安装  

[![image](http://lh4.ggpht.com/-4xIGyzG0FJ0/Uc5dkpxrecI/AAAAAAAADlQ/Knk3jQ538aE/image_thumb40.png?imgmax=800 "image")](http://lh4.ggpht.com/-bvAVHWvSPsU/Uc5djzuyyCI/AAAAAAAADlI/-Ef8aQFfUAI/s1600-h/image122.png)  
  
 29、安装完毕之后就是重启  
 30、跳过重启、重启、再重启，就是设置画面了  
  
 【设置】  
 1、变得更加仔细的Personalize 画面  

[![image](http://lh3.ggpht.com/-HasRLVT58Mo/Uc5dlnx6vcI/AAAAAAAADlg/yoJtdRrlZs4/image_thumb49.png?imgmax=800 "image")](http://lh3.ggpht.com/-tPoxftRTi0M/Uc5dlGnk83I/AAAAAAAADlY/x7Rj4tWtSyU/s1600-h/image149.png)  
  
 2、点击use express settings，然后就是setup account  

[![image](http://lh5.ggpht.com/-rwtJZqzCJPc/Uc5dmt-oFlI/AAAAAAAADlw/7nCtEiWStvQ/image_thumb52.png?imgmax=800 "image")](http://lh6.ggpht.com/-sm7GXNfPQ8o/Uc5dmMBP7rI/AAAAAAAADlo/i3VTORy9mfA/s1600-h/image158.png)  

[![image](http://lh3.ggpht.com/-D7H-p_EfnsA/Uc5doGXIUuI/AAAAAAAADmA/XRKX0W0grqg/image_thumb50.png?imgmax=800 "image")](http://lh4.ggpht.com/-pXNsImFiwCg/Uc5dnWjEc5I/AAAAAAAADl4/JCR6DG8jqJc/s1600-h/image152.png)  
  
 3、填入帐号和密码  

[![image](http://lh6.ggpht.com/-teHmT90Eqhk/Uc5duUL-QOI/AAAAAAAADmQ/jAvZNBHF2Ac/image_thumb51.png?imgmax=800 "image")](http://lh3.ggpht.com/-AZHPayUOtkY/Uc5dosTqd4I/AAAAAAAADmI/cJA8x2u1iZ0/s1600-h/image155.png)  
  
 4、Connecting  

[![image](http://lh5.ggpht.com/-2wrmCSom69U/Uc5dvW0hfuI/AAAAAAAADmg/fd-ghy6ufsI/image_thumb53.png?imgmax=800 "image")](http://lh3.ggpht.com/-NJaw8wBoZes/Uc5du2w55PI/AAAAAAAADmY/blrA2RcS3P4/s1600-h/image161.png)  
  
 5、帐号验证  

[![image](http://lh4.ggpht.com/-yxerNjk8_mc/Uc5dwj9TH-I/AAAAAAAADmw/3e4pP9WF6OQ/image_thumb54.png?imgmax=800 "image")](http://lh4.ggpht.com/-Hl5NFpt32SA/Uc5dv88uaoI/AAAAAAAADmo/Q3iOOzDvHJw/s1600-h/image164.png)  
  
 6、深度整合SkyDrive  

[![image](http://lh4.ggpht.com/-JIu-AFXfrQw/Uc5dxiQX3QI/AAAAAAAADnA/YfXJMHKNXa0/image_thumb55.png?imgmax=800 "image")](http://lh5.ggpht.com/-SgQ1BJxcDfU/Uc5dxGm-7hI/AAAAAAAADm4/z0JXOtqQxGE/s1600-h/image167.png)  
  
 7、然后是重启  

[![image](http://lh3.ggpht.com/-MY0ywAcnzVM/Uc5dyp5SATI/AAAAAAAADnQ/w4Js_OLetII/image_thumb56.png?imgmax=800 "image")](http://lh4.ggpht.com/-SeOrmyNVPIY/Uc5dyfFsQbI/AAAAAAAADnI/Yni1liLcFiM/s1600-h/image170.png)  
  
 8、  

[![image](http://lh4.ggpht.com/-dqRrLSCZGIg/Uc5d0JQ52rI/AAAAAAAADng/GpUINE_-_ic/image_thumb57.png?imgmax=800 "image")](http://lh6.ggpht.com/-mD4mxdyoP4Y/Uc5dzb9qBDI/AAAAAAAADnY/LjUUVgm5T5M/s1600-h/image173.png)  
  
 9、Installing Apps  

[![image](http://lh6.ggpht.com/-KIeLjJnjX6I/Uc5d1JdXLjI/AAAAAAAADnw/8pP7Jdz24N4/image_thumb58.png?imgmax=800 "image")](http://lh5.ggpht.com/-ZaxV-U7i_As/Uc5d0ncU1RI/AAAAAAAADno/gnZLcqbgers/s1600-h/image176.png)  
  
 10、Getting Your Apps Ready  

[![image](http://lh6.ggpht.com/-mZnfpPR2Nd8/Uc5eAqw12SI/AAAAAAAADoA/73RZwUJN6LA/image_thumb59.png?imgmax=800 "image")](http://lh4.ggpht.com/-im3Oca6aYTM/Uc5d1kK3c8I/AAAAAAAADn4/ElRzrleNO3o/image179.png?imgmax=800)  
  
 11、Getting Your PC Ready  

[![image](http://lh6.ggpht.com/-cLq790kwimI/Uc5eB1DU18I/AAAAAAAADoQ/Po-mEAWzMgY/image_thumb60.png?imgmax=800 "image")](http://lh5.ggpht.com/-4Kvuz3U8vVA/Uc5eBJga77I/AAAAAAAADoI/cCCr6ABeczk/s1600-h/image182.png)  
  
 12、Almost Ready  

[![image](http://lh4.ggpht.com/-pPYS9u0LQXo/Uc5eC_C2j2I/AAAAAAAADog/OnnletIwfKI/image_thumb61.png?imgmax=800 "image")](http://lh4.ggpht.com/-h8TS6Vp2mjY/Uc5eCO7JkbI/AAAAAAAADoY/-MMTsuZcaiE/s1600-h/image185.png)  
  
 13、好了！  

[![image](http://lh6.ggpht.com/-t50Ia2zBkW0/Uc5eEdEGNsI/AAAAAAAADow/VYGU9OmonBc/image_thumb62.png?imgmax=800 "image")](http://lh6.ggpht.com/-bA4yJETQANM/Uc5eDqw5rjI/AAAAAAAADoo/kqPYUZ_nEEs/s1600-h/image188.png)
