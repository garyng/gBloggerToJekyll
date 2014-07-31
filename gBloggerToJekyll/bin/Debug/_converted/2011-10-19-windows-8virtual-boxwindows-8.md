---
layout: post
title: '[原创教程][Windows 8预览版介绍] Virtual Box玩Windows 8!'
author: 'Gary Ng'
tags: ['Hardware Virtualization Technology','HAV','virtual box','VT','windows','windows 8','windows 8 dev','windows 8 install','windows 8 preview','原创','教程']
---

三更半夜咯～花了大概24个小时下载Windows 8 Developer
Preview～终于下载完了～  
 好啦～废话不多说～  
  
 Windows 8 Developer
Preview官方网站：[dev.windows.com](http://dev.windows.com/)  
 下载地址：[点我下载Windows 8 Developer Preview English, 32-bit
(x86)](http://wdp.dlws.microsoft.com/WDPDL/9B8DFDFF736C5B1DBF956B89D8A9D4FD925DACD2/WindowsDeveloperPreview-32bit-English.iso)  
  
  
  
  
 丫丫～等等～笔者就是因为以下的问题困扰了很久啊！所以请读者们注意：  
 在开始安装Windows 8之前，读者必须拥有一个具有Hardware Virtualization
Technology (VT)功能的电脑！！  
 官方网站：[Microsoft® Hardware-Assisted Virtualization Detection
Tool](http://www.microsoft.com/download/en/details.aspx?displaylang=en&id=592#filelist)  

[微软的免费检测工具下载](http://www.microsoft.com/downloads/info.aspx?na=41&srcfamilyid=0ee2a17f-8538-4619-8d1c-05d27e11adb2&srcdisplaylang=en&u=http%3a%2f%2fdownload.microsoft.com%2fdownload%2f1%2f9%2fF%2f19FD407F-A7E9-4393-A845-D0B1F539678E%2fhavdetectiontool.exe)  

注意：此工具不必安装，运行后，程序将自动解压文件，稍等一会儿后，检测报告就会显示咯！  
 检测完毕过后（不要先急着吧那窗口关掉哦！）  
 如果结果是：this computer is configured with hardware-assisted
virtualization  
  
 厚厚～你可以继续咯～  
 其他结果看这里：  

<http://www.microsoft.com/windows/virtual-pc/support/configure-bios.aspx>  
  
 1、安装最新版本的Virtual Box（至19-10-2011最新版本是4.1.4）  
 官方网站：<https://www.virtualbox.org/wiki/Downloads>  
[![](http://1.bp.blogspot.com/-KKih6ohIssw/Tp7bZpOvliI/AAAAAAAAAKo/O9gU0KEKKMM/s640/down.jpg)](http://1.bp.blogspot.com/-KKih6ohIssw/Tp7bZpOvliI/AAAAAAAAAKo/O9gU0KEKKMM/s1600/down.jpg)
2、当然是运行Virtual Box啦！  
 3、程序打开后，点击"New"  
[![](http://2.bp.blogspot.com/-3WI9QPv4hAw/Tp7brqifKhI/AAAAAAAAAKw/3k1sa8efA8o/s1600/1.jpg)](http://2.bp.blogspot.com/-3WI9QPv4hAw/Tp7brqifKhI/AAAAAAAAAKw/3k1sa8efA8o/s1600/1.jpg)
4、将会跳出此框框：
点"Next"
[![](http://2.bp.blogspot.com/-Q-oxjcPFoWE/Tp7ca6YaoEI/AAAAAAAAAK4/Hl8Qwr8c5Vw/s400/2.jpg)](http://2.bp.blogspot.com/-Q-oxjcPFoWE/Tp7ca6YaoEI/AAAAAAAAAK4/Hl8Qwr8c5Vw/s1600/2.jpg)
  
5、Name输入Windows 8
OS选Windows 8（新版本添加了此选项哦！）
[![](http://4.bp.blogspot.com/-xM0_r3Io1aI/Tp7ctv9tZZI/AAAAAAAAALA/3CPehA5prAc/s400/3.jpg)](http://4.bp.blogspot.com/-xM0_r3Io1aI/Tp7ctv9tZZI/AAAAAAAAALA/3CPehA5prAc/s1600/3.jpg)
  
6、接下来是设置RAM大小（建议调成1024MB）
[![](http://4.bp.blogspot.com/-0wOP66-K5E8/Tp_hpKjqVgI/AAAAAAAAALM/fMiCUls40eg/s400/4.jpg)](http://4.bp.blogspot.com/-0wOP66-K5E8/Tp_hpKjqVgI/AAAAAAAAALM/fMiCUls40eg/s1600/4.jpg)
  
  
7、点击"Next"  
 程序会要求用会创建“虚拟硬盘”  
[![](http://1.bp.blogspot.com/-lb8HZbcqPB4/Tp_iAaOcENI/AAAAAAAAALU/MV7Nn04REb4/s400/5.jpg)](http://1.bp.blogspot.com/-lb8HZbcqPB4/Tp_iAaOcENI/AAAAAAAAALU/MV7Nn04REb4/s1600/5.jpg)
  
8、选"VDI"
[![](http://2.bp.blogspot.com/-aHKKCc6zmvI/Tp_iQpkUHEI/AAAAAAAAALc/soB3hSd9v2I/s400/6.jpg)](http://2.bp.blogspot.com/-aHKKCc6zmvI/Tp_iQpkUHEI/AAAAAAAAALc/soB3hSd9v2I/s1600/6.jpg)
  
9、选"Dynamically allocated"  
[![](http://3.bp.blogspot.com/-21X54h6Fj5o/Tp_idNzED2I/AAAAAAAAALk/dDAgKxRAi4I/s400/7.jpg)](http://3.bp.blogspot.com/-21X54h6Fj5o/Tp_idNzED2I/AAAAAAAAALk/dDAgKxRAi4I/s1600/7.jpg)
  
 10、容量大小设置成40GB  
[![](http://3.bp.blogspot.com/-KCAnxnkoVJg/Tp_irOMB8YI/AAAAAAAAALs/QlYcOS5d32o/s400/8.jpg)](http://3.bp.blogspot.com/-KCAnxnkoVJg/Tp_irOMB8YI/AAAAAAAAALs/QlYcOS5d32o/s1600/8.jpg)
  
 11、按"Create"  
[![](http://1.bp.blogspot.com/-LVsL3eYzwsY/Tp_i4QSzm9I/AAAAAAAAAL0/azmSQE_49cw/s400/9.jpg)](http://1.bp.blogspot.com/-LVsL3eYzwsY/Tp_i4QSzm9I/AAAAAAAAAL0/azmSQE_49cw/s1600/9.jpg)
  
[![](http://3.bp.blogspot.com/-A7zzPDkDVwo/Tp_i5GMcRWI/AAAAAAAAAL8/l-8CAytCYP4/s400/10.jpg)](http://3.bp.blogspot.com/-A7zzPDkDVwo/Tp_i5GMcRWI/AAAAAAAAAL8/l-8CAytCYP4/s1600/10.jpg)
  
 12、回到主页面，点击选择Windows 8 Preview后，点击上方的Setting  
[![](http://1.bp.blogspot.com/-5dwzDVEbNjg/Tp_jZU4_eoI/AAAAAAAAAME/6BZwM5NIxkE/s1600/11.jpg)](http://1.bp.blogspot.com/-5dwzDVEbNjg/Tp_jZU4_eoI/AAAAAAAAAME/6BZwM5NIxkE/s1600/11.jpg)
  
 13、在"System"选项， "Motherboard"子选项将CD/DVD-ROM和Hard Disk打勾  
 另外也要勾选"Enable IO APIC"的选项  
[![](http://4.bp.blogspot.com/-oisF9qUZ2JM/Tp_jZ3MtcGI/AAAAAAAAAMM/OltWbOjNNEw/s320/12.jpg)](http://4.bp.blogspot.com/-oisF9qUZ2JM/Tp_jZ3MtcGI/AAAAAAAAAMM/OltWbOjNNEw/s1600/12.jpg)
  
14、在"Acceleration"子选项选择"Enable VT-x/AMD-V"和"Enable Nested
Paging"
[![](http://2.bp.blogspot.com/-vHEK0BEPghU/Tp_jaHcKcbI/AAAAAAAAAMU/kyG3I64ITkU/s320/13.jpg)](http://2.bp.blogspot.com/-vHEK0BEPghU/Tp_jaHcKcbI/AAAAAAAAAMU/kyG3I64ITkU/s1600/13.jpg)
  
15、在"Display"选项，"Video"子选项，选择"Enable 3D Acceleration"
[![](http://2.bp.blogspot.com/-JRcAv-GJq40/Tp_jcDLHjwI/AAAAAAAAAM0/9fMrF1IbKxY/s320/17.jpg)](http://2.bp.blogspot.com/-JRcAv-GJq40/Tp_jcDLHjwI/AAAAAAAAAM0/9fMrF1IbKxY/s1600/17.jpg)
  
16、在"Storage"选项，点击那小小的CD图标
[![](http://4.bp.blogspot.com/-rNpHJOV1XRk/Tp_jar4AXzI/AAAAAAAAAMc/wMRAO_vtHgE/s320/14.jpg)](http://4.bp.blogspot.com/-rNpHJOV1XRk/Tp_jar4AXzI/AAAAAAAAAMc/wMRAO_vtHgE/s1600/14.jpg)
17、点击"Choose disk"  
[![](http://4.bp.blogspot.com/-B-nPHAaQBec/Tp_jbOfj-qI/AAAAAAAAAMk/H2TuPOuD4_E/s1600/15.jpg)](http://4.bp.blogspot.com/-B-nPHAaQBec/Tp_jbOfj-qI/AAAAAAAAAMk/H2TuPOuD4_E/s1600/15.jpg)
  
 18、选择Windows 8的映象档（.iso）的储存路径  
[![](http://4.bp.blogspot.com/-RI22ha6j408/Tp_jblaMaOI/AAAAAAAAAMs/twnBQVbyHs8/s320/16.jpg)](http://4.bp.blogspot.com/-RI22ha6j408/Tp_jblaMaOI/AAAAAAAAAMs/twnBQVbyHs8/s1600/16.jpg)
  
 19、回到主页面，点击"Start"  
[![](http://2.bp.blogspot.com/-oSUWrxHDbks/Tp_lv0GtQOI/AAAAAAAAAM8/OLuGV3SDf0g/s320/18.jpg)](http://2.bp.blogspot.com/-oSUWrxHDbks/Tp_lv0GtQOI/AAAAAAAAAM8/OLuGV3SDf0g/s1600/18.jpg)
  
 20、第一次运行会跳出很多提示框，全部都勾选"Do not show this message
again"，并点击OK  
[![](http://4.bp.blogspot.com/-r5Jg78b5ytk/Tp_lwcol5DI/AAAAAAAAANE/A9dh3pYtn_g/s320/19.jpg)](http://4.bp.blogspot.com/-r5Jg78b5ytk/Tp_lwcol5DI/AAAAAAAAANE/A9dh3pYtn_g/s1600/19.jpg)
  
 21、等等下吧～  
[![](http://2.bp.blogspot.com/-gmcq4Gw7YnM/Tp_lwn51p1I/AAAAAAAAANM/ZE-b_Gxp5Ng/s1600/20.jpg)](http://2.bp.blogspot.com/-gmcq4Gw7YnM/Tp_lwn51p1I/AAAAAAAAANM/ZE-b_Gxp5Ng/s1600/20.jpg)
  
 22、"Windows Loading Files"过后，就会出现这个安装向导啦！  
[![](http://2.bp.blogspot.com/-XXJzFfwipmM/Tp_lxdQlqmI/AAAAAAAAANU/6TonEwoqIqQ/s320/21.jpg)](http://2.bp.blogspot.com/-XXJzFfwipmM/Tp_lxdQlqmI/AAAAAAAAANU/6TonEwoqIqQ/s1600/21.jpg)
  
 23、点击"Install Now"  
[![](http://2.bp.blogspot.com/-e2SQS6akz7Y/Tp_lx0pQv4I/AAAAAAAAANc/mq0BK5JqCEk/s320/22.jpg)](http://2.bp.blogspot.com/-e2SQS6akz7Y/Tp_lx0pQv4I/AAAAAAAAANc/mq0BK5JqCEk/s1600/22.jpg)
  
 24、等待～  
[![](http://1.bp.blogspot.com/-9HAOLwCHgiQ/Tp_lyTiSEPI/AAAAAAAAANk/NDA4JfkpEKo/s320/23.jpg)](http://1.bp.blogspot.com/-9HAOLwCHgiQ/Tp_lyTiSEPI/AAAAAAAAANk/NDA4JfkpEKo/s1600/23.jpg)
  
 25、这个是"License Term"，勾选"I accept the license term"，点击"Next"  
[![](http://4.bp.blogspot.com/-slfW8YknNZw/Tp_lzA_mNEI/AAAAAAAAANs/fCSK1ZtKsTk/s320/24.jpg)](http://4.bp.blogspot.com/-slfW8YknNZw/Tp_lzA_mNEI/AAAAAAAAANs/fCSK1ZtKsTk/s1600/24.jpg)
  
 26、选择"Custom(advanced)"  
[![](http://1.bp.blogspot.com/-zVFAM_gpKvQ/Tp_lz4K8V9I/AAAAAAAAAN0/6FrZIgm6llo/s320/25.jpg)](http://1.bp.blogspot.com/-zVFAM_gpKvQ/Tp_lz4K8V9I/AAAAAAAAAN0/6FrZIgm6llo/s1600/25.jpg)
  
 27、点击"Disk 0 Unallocated Space"，再点"Next"  
[![](http://3.bp.blogspot.com/-dEqfevbsvDQ/Tp_l0WTqSII/AAAAAAAAAN8/wozk2xjL8zg/s320/26.jpg)](http://3.bp.blogspot.com/-dEqfevbsvDQ/Tp_l0WTqSII/AAAAAAAAAN8/wozk2xjL8zg/s1600/26.jpg)
  
28、在等等吧～（可能花上好几十。。。。分钟～）
[![](http://4.bp.blogspot.com/--d-F6akS-zs/Tp_n6gtxgaI/AAAAAAAAAOE/pr-cB_eVkOI/s320/27.jpg)](http://4.bp.blogspot.com/--d-F6akS-zs/Tp_n6gtxgaI/AAAAAAAAAOE/pr-cB_eVkOI/s1600/27.jpg)
  
 29、Copy完Windows Files咯～  
[![](http://2.bp.blogspot.com/-kX3ZxfXiCao/Tp_n7KbQRcI/AAAAAAAAAOM/6u8xeIpbkjU/s320/28.jpg)](http://2.bp.blogspot.com/-kX3ZxfXiCao/Tp_n7KbQRcI/AAAAAAAAAOM/6u8xeIpbkjU/s1600/28.jpg)
  
 30、这个部分最久了（小睡下）～  
[![](http://3.bp.blogspot.com/-ElJJs8jpSR8/Tp_n7c8lm5I/AAAAAAAAAOU/RU6pdX5RZZ8/s320/29.jpg)](http://3.bp.blogspot.com/-ElJJs8jpSR8/Tp_n7c8lm5I/AAAAAAAAAOU/RU6pdX5RZZ8/s1600/29.jpg)
  
 31、接下来的就快多了～  
[![](http://2.bp.blogspot.com/-tCWr0_Nh2_A/Tp_n7zZdleI/AAAAAAAAAOc/kieAogp2Kmk/s320/30.jpg)](http://2.bp.blogspot.com/-tCWr0_Nh2_A/Tp_n7zZdleI/AAAAAAAAAOc/kieAogp2Kmk/s1600/30.jpg)
  
 32、超美的开机画面～  
 Setup is updating registry settings...  
[![](http://1.bp.blogspot.com/-szHdKOzmhuw/Tp_n8aE39UI/AAAAAAAAAOk/j9O1aheuJxc/s320/31.jpg)](http://1.bp.blogspot.com/-szHdKOzmhuw/Tp_n8aE39UI/AAAAAAAAAOk/j9O1aheuJxc/s1600/31.jpg)
  
 33、Preparing...  
[![](http://3.bp.blogspot.com/-otwZ1zrYI7c/Tp_n89uPZNI/AAAAAAAAAOs/0iqzyAZ3oEs/s320/32.jpg)](http://3.bp.blogspot.com/-otwZ1zrYI7c/Tp_n89uPZNI/AAAAAAAAAOs/0iqzyAZ3oEs/s1600/32.jpg)
  
 34、Getting devices ready...  
[![](http://2.bp.blogspot.com/-vn4RnXf_-vs/Tp_n9kJlrUI/AAAAAAAAAOw/6i0WIoolAd0/s320/33.jpg)](http://2.bp.blogspot.com/-vn4RnXf_-vs/Tp_n9kJlrUI/AAAAAAAAAOw/6i0WIoolAd0/s1600/33.jpg)
  
 35、  Getting devices ready 100%...  
[![](http://1.bp.blogspot.com/-y1xhKiTY8GY/Tp_n_XMl2EI/AAAAAAAAAPE/vmvz-ay224Q/s320/35.jpg)](http://1.bp.blogspot.com/-y1xhKiTY8GY/Tp_n_XMl2EI/AAAAAAAAAPE/vmvz-ay224Q/s1600/35.jpg)
  
 36、Getting system ready...  
[![](http://2.bp.blogspot.com/-6pCekkB2Pfw/Tp_oAf0PRBI/AAAAAAAAAPM/LmlZTMvHpYE/s320/36.jpg)](http://2.bp.blogspot.com/-6pCekkB2Pfw/Tp_oAf0PRBI/AAAAAAAAAPM/LmlZTMvHpYE/s1600/36.jpg)
  
 37、美吧！输入用户名字～  
[![](http://2.bp.blogspot.com/-eGOjhnY_WqM/Tp_oBhyRZvI/AAAAAAAAAPk/p87-dvo33X0/s320/39.jpg)](http://2.bp.blogspot.com/-eGOjhnY_WqM/Tp_oBhyRZvI/AAAAAAAAAPk/p87-dvo33X0/s1600/39.jpg)
  
 38、选择"Use express settings"  
[![](http://2.bp.blogspot.com/-VQDSuRzN3ig/Tp_oCCSX7jI/AAAAAAAAAPs/2Lodf-0OWyM/s320/40.jpg)](http://2.bp.blogspot.com/-VQDSuRzN3ig/Tp_oCCSX7jI/AAAAAAAAAPs/2Lodf-0OWyM/s1600/40.jpg)
  
 39、输入电子邮件  
[![](http://4.bp.blogspot.com/-FyIAgUkxM9o/Tp_oCtj-8XI/AAAAAAAAAP0/KyEcxy34SBk/s320/41.jpg)](http://4.bp.blogspot.com/-FyIAgUkxM9o/Tp_oCtj-8XI/AAAAAAAAAP0/KyEcxy34SBk/s1600/41.jpg)
  
 40、输入完后，点击"Next"  
[![](http://1.bp.blogspot.com/-dHJFDo2ez5I/Tp_oCwsno-I/AAAAAAAAAP8/Tpoo6XNkA9I/s320/42.jpg)](http://1.bp.blogspot.com/-dHJFDo2ez5I/Tp_oCwsno-I/AAAAAAAAAP8/Tpoo6XNkA9I/s1600/42.jpg)
  
 41、点击"Next"  
[![](http://3.bp.blogspot.com/-MrB9JsL1WTM/Tp_oDdcL5jI/AAAAAAAAAQE/4KaiUURpAYk/s320/43.jpg)](http://3.bp.blogspot.com/-MrB9JsL1WTM/Tp_oDdcL5jI/AAAAAAAAAQE/4KaiUURpAYk/s1600/43.jpg)
  
 42、输入帐号的密码～  
[![](http://3.bp.blogspot.com/-xL1fHUzLSWo/Tp_oD2IL7CI/AAAAAAAAAQM/sMqukKjpsgg/s320/44.jpg)](http://3.bp.blogspot.com/-xL1fHUzLSWo/Tp_oD2IL7CI/AAAAAAAAAQM/sMqukKjpsgg/s1600/44.jpg)
  
 43、再点"Next"  
[![](http://2.bp.blogspot.com/-kvXVrQ5QOjE/Tp_oENakblI/AAAAAAAAAQU/S8AvY0aI7es/s320/45.jpg)](http://2.bp.blogspot.com/-kvXVrQ5QOjE/Tp_oENakblI/AAAAAAAAAQU/S8AvY0aI7es/s1600/45.jpg)
  
 44、Creating your account...  
 完成后，点击"Next"  
[![](http://2.bp.blogspot.com/-bjxF0ZVSXCI/Tp_oEi2WWRI/AAAAAAAAAQc/9dwomLQjVSg/s320/46.jpg)](http://2.bp.blogspot.com/-bjxF0ZVSXCI/Tp_oEi2WWRI/AAAAAAAAAQc/9dwomLQjVSg/s1600/46.jpg)
  
 45、Finalizing you setting...  
[![](http://3.bp.blogspot.com/-LOaGj-lfq3w/Tp_oE0TZKdI/AAAAAAAAAQk/KvpQFb9SO_Q/s320/47.jpg)](http://3.bp.blogspot.com/-LOaGj-lfq3w/Tp_oE0TZKdI/AAAAAAAAAQk/KvpQFb9SO_Q/s1600/47.jpg)
  
 46、漂亮的欢迎界面...  
  
[![](http://1.bp.blogspot.com/-ogwGm9WYSZg/Tp_oFpZYdXI/AAAAAAAAAQ0/FiPbEXMBa7c/s320/49.jpg)](http://1.bp.blogspot.com/-ogwGm9WYSZg/Tp_oFpZYdXI/AAAAAAAAAQ0/FiPbEXMBa7c/s1600/49.jpg)
  
 47、过后可能会黑屏一阵子（不会太久，耐心等就对了！）  
[![](http://4.bp.blogspot.com/-Omvmp5R7bmA/Tp_oF-bbe9I/AAAAAAAAAQ8/oNTuTW--TPc/s320/50.jpg)](http://4.bp.blogspot.com/-Omvmp5R7bmA/Tp_oF-bbe9I/AAAAAAAAAQ8/oNTuTW--TPc/s1600/50.jpg)
  
 48、Windows 竟然发了封电子邮件过来！  
[![](http://3.bp.blogspot.com/-60g3IN98C6s/Tp_oGZmFQ1I/AAAAAAAAARE/4iPYCfkRfn8/s320/51.jpg)](http://3.bp.blogspot.com/-60g3IN98C6s/Tp_oGZmFQ1I/AAAAAAAAARE/4iPYCfkRfn8/s1600/51.jpg)
  
 49、Please Wait...  
[![](http://4.bp.blogspot.com/-25ex0pyWNOE/Tp_oGzxIKjI/AAAAAAAAARM/kVSq_rjFJSw/s320/52.jpg)](http://4.bp.blogspot.com/-25ex0pyWNOE/Tp_oGzxIKjI/AAAAAAAAARM/kVSq_rjFJSw/s1600/52.jpg)
  
 50、哈哈～如果读者看到此界面，就代表安装成功咯！  
[![](http://1.bp.blogspot.com/-gDkY2x6mPK4/Tp_oHisEnII/AAAAAAAAARc/GX5JPSGzCE8/s320/54.jpg)](http://1.bp.blogspot.com/-gDkY2x6mPK4/Tp_oHisEnII/AAAAAAAAARc/GX5JPSGzCE8/s1600/54.jpg)
  
[![](http://1.bp.blogspot.com/-KpLacBXwzRI/Tp_oIPwI5EI/AAAAAAAAARk/YnsBI6q988Q/s320/55.jpg)](http://1.bp.blogspot.com/-KpLacBXwzRI/Tp_oIPwI5EI/AAAAAAAAARk/YnsBI6q988Q/s1600/55.jpg)
  
[![](http://2.bp.blogspot.com/-OkYgqDbb0_I/Tp_oIzSaBPI/AAAAAAAAARs/-BWdYQG7zs8/s320/56.jpg)](http://2.bp.blogspot.com/-OkYgqDbb0_I/Tp_oIzSaBPI/AAAAAAAAARs/-BWdYQG7zs8/s1600/56.jpg)
  
[![](http://3.bp.blogspot.com/-Ql3Zk5wJJlY/Tp_oJZagEQI/AAAAAAAAAR0/WOPpjF7_2ws/s320/57.jpg)](http://3.bp.blogspot.com/-Ql3Zk5wJJlY/Tp_oJZagEQI/AAAAAAAAAR0/WOPpjF7_2ws/s1600/57.jpg)
  
 51、用着IE  
[![](http://1.bp.blogspot.com/-qf9CGbvSlQc/Tp_oJ7p-tpI/AAAAAAAAAR8/xciBIaWbtS8/s320/58Ie.jpg)](http://1.bp.blogspot.com/-qf9CGbvSlQc/Tp_oJ7p-tpI/AAAAAAAAAR8/xciBIaWbtS8/s1600/58Ie.jpg)
  
 52、新版本的CMD  
[![](http://1.bp.blogspot.com/-f98OQCxnnpA/Tp_oKZ_PFgI/AAAAAAAAASE/epx0o7A3r9o/s320/59CMD.jpg)](http://1.bp.blogspot.com/-f98OQCxnnpA/Tp_oKZ_PFgI/AAAAAAAAASE/epx0o7A3r9o/s1600/59CMD.jpg)
53、好啦，就到此为止～
