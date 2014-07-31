---
layout: post
title: '[原创][教程] 中毒后的感想+解毒步骤+工具'
author: 'Gary Ng'
tags: ['原创','教程','防毒']
---

前几天某个闪盘把剧毒带进了电脑内，几乎感染了所有的EXE文件。存放本站资源的DropBox也无能幸免（[【紧急】本站DropBox中毒了](http://garyngzhongbo.blogspot.com/2012/09/dropbox.html)）。
翻了整个橱柜，找到了几片启动光盘，里面有个N年前的AVG的Rescue
Disk，花了几个小时扫描，终于还是把大部分的病毒清除了。（笔者还不确定是不是全部都清干净了呢！）  
  
从本站DropBox下载的文件（包括[Gary’s Software Download
Zone](http://garyzone.tk/)）请顺手杀杀毒吧，如果查出是W32.Sality.Y（笔者就是中了这个毒），就千万不要运行！此病毒会很猛力的列出所有磁盘，然后在搜索exe文件，接着修改exe的入口点，把自己的感染代码复制到exe内（此动作会使exe的大小增加大概30KB），每当运行被感染的文件后，就会像他的“爸爸”那样，感染其他未感染的exe文件。就这样，笔者的电脑上的大部分的exe文件都被感染了。  
  
刚刚开始[360杀毒](http://sd.360.cn/)就猛报“W32.Sality.Y”
病毒，并且显示“病毒代码已清除”，但是治标不治本，才不到几分钟的文件，该exe又重新被感染，用XueTr（[官方网站](http://www.xuetr.com/?p=25)）查看所有的进程，却找不到任何属于病毒的进程，当360杀毒跳出“远程注入”的警告窗后，我终于知道了，这病毒是远程注入运行的！我的ctfmon.exe
被感染了，一直注入其它进程内。
然后360杀毒向我推荐了他的“[360急救箱](http://www.360.cn/jijiuxiang/index.html)”，但是越扫越遭，重启后竟然多次蓝屏。然后花了一整个晚上用360杀毒扫描（当初真的找不到其他的杀毒软件了），弹还是没有成功清除所有的病毒，反而搞到360主动防御模块也被感染了，360杀毒的N多功能也不能正常开启，360急救箱的主文件也被感染，然后看到了之前烧录的Win7PE，又看到了360为WinPE特制的360急救箱，下载了后用光盘开机，又花了N多的时间在Win7PE下用WinPE版本的360急救箱扫描了N久，却没扫出任何东东。  
  
遇到这种麻烦的情况，第一时间就是想到安全模式嘛！但是，一进入SafeMode，调皮的Windows却摆了个蓝脸个我看（如果你不知道的话，蓝脸=BSOD，Blue
Screen Of Death），真不幸运啊！突然看到了Rescue
Disk，于是顺手试试，塞进光盘内，重启，等待。。。终于进入了N年前用Sardu（什么来的？下面会说～）制作的Live
CD，选择了AVG Rescue
Disk，全盘扫描了下，总共5000++个exe文件被感染W32.Sality.Y病毒（幸好N年前的database还能扫除这类病毒），而且大多数的都是程序的exe文件、笔者的程序、还有就是本站的DropBox
资源，没办法了，只好忍心的把所有已感染的exe文件删除。
  
重启后，大部分的问题都解决了，可是电脑内的N多软件都被逼重装啊！病毒真麻烦！在这里说说下我**电脑时中毒的解决方法。**  
 **  
**
N久前在笔者混的Facebook群组[《\~大家e起学编程\~》](https://www.facebook.com/groups/179492442143038/)中的某个组员发了个病毒，连笔者也中了，但是不算什么剧毒。遇到这种情况时，请用PEid（笔者转载了官方版本的PEid
0.95
到Mediafire上，[点击这里下载](http://www.mediafire.com/?wl40w3l026l19sc)，官方网站似乎关掉了——<http://www.peid.info/>）查壳。有壳就去壳（笔者中的病毒不知道用了什么壳，找不到解压器，不会手动脱壳的说\>\<，所以壳也脱不了。）。  
  
如果幸运的话，可能会看到PEid显示该病毒是.net 写的，这是就拿出神器[.net
Reflector](http://www.mediafire.com/download.php?9dfffi6xdgaqoxm)，反汇编吧！（很好的一个软件，直接把.net写的软件反汇编后转换成代码！），赶紧分析出病毒编写者的邮件和密码吧！（似乎.net写不出大型的病毒，不可能要让受害者装个几百MB的.net
framework吧？笔者看过的就是几个盗号、键盘记录，然后保存后把信息发送到一个邮箱，而且有只要细心的分析就会找出该邮箱的密码！）
**所以只要能，就查壳、脱壳、反汇编！**其实，只要有功底的话，也可以用OllyDbg反汇编的～（[【原创】第一次使用OllyDbg](http://garyngzhongbo.blogspot.com/2012/09/ollydbg.html)）。可惜笔者功底不好、不会手动脱壳，所以只要依赖杀毒软件了。  
  
如果不能脱壳（或者你是新手哈哈），那就为电脑来个全盘扫描吧！比较推荐的防毒软件有[avast!](http://www.avast.com/)，[AVG](http://www.avg.com/ww-en/homepage)，[Avira](http://www.avira.com/en/index)，[Kaspersky](http://www.kaspersky.com/products)，还有Windows自行出品的[Windows
Security
Essentials](http://windows.microsoft.com/en-US/windows/products/security-essentials)（要安装这杀毒，Windows
必须通过正版验证！）。360旗下的软件都很不错，可是要在紧要关头时（比如说真的真的没有其他防毒软件能用了）才用吧，而且360杀毒不联网杀毒是不行的，本地的病毒库还需要改进。用杀毒软件为电脑来个全盘大扫描，把病毒通通赶出去！  
  
如果电脑能联上网络的话，也可以试试这个很出名的线上病毒查杀的工具：[VirusTotal](https://www.virustotal.com/)。支持查杀上传的文件（单个文件最大32MB）和网页URL，也可以在VirusTotal中的数据库搜索（[点击这边](https://www.virustotal.com/#search)）一个文件或者URL！VirusTotal支持42种不同的杀毒软件查杀，包括了[AhnLab-V3](http://www.ahnlab.com/)、[AntiVir](http://www.antivir.com/)、[Antiy-AVL](http://www.antiy.net/en/index.html)、[Avast](http://www.avast.com/index)、[AVG](http://www.avg.com/ww-en/homepage)、[BitDefender](http://www.bitdefender.com/)、[ByteHero](http://www.bytehero.com/)、[CAT-QuickHeal](http://www.quickheal.com/)、[ClamAV](http://www.clamav.net/lang/en/)（开源杀毒引擎！）、[Commtouch](http://www.commtouch.com/)、[Comodo](http://www.comodo.com/)、[DrWeb](http://www.drweb.com/?lng=en)、[Emsisoft](http://www.emsisoft.com/en/)、[eSafe](http://www.safenet-inc.com/)、[ESET-NOD32](http://www.eset.com/)、[F-Prot](http://www.f-prot.com/)、[F-Secure](http://www.f-secure.com/en/web/operators_my)、[Fortinet](http://www.fortinet.com/)、[GData](http://www.gdatasoftware.com/online-shop.html)、[Ikarus](http://www.ikarus.at/en/)、[Jiangmin](http://suzhi.jiangmin.com/)、[K7AntiVirus](http://www.k7computing.com/en/Product/k7-antivirusplus.php)、[Kaspersky](http://www.kaspersky.com/)、[McAfee](http://www.mcafee.com/us/)、[McAfee-GW-Edition](http://www.mcafee.com/us/mcafee-labs/technology/gateway-anti-malware-engine.aspx)、[Microsoft](http://windows.microsoft.com/en-US/windows/products/security-essentials)、[Norman](http://www.norman.com/)、[nProtect](http://www.nprotect.com/)、[Panda](http://www.pandasecurity.com/)、[PCTools](http://www.pctools.com/)、[Rising](http://www.rising.com.cn/)、[Sophos](http://www.sophos.com/en-us/)、[SUPERAntiSpyware](http://www.superantispyware.com/)、
[Symantec](http://www.symantec.com/index.jsp)、[TheHacker](http://www.hacksoft.com.pe/)、[TotalDefense](http://www.totaldefense.com/home.aspx)、[TrendMicro](http://www.trendmicro.com.my/)、[TrendMicro-HouseCall](http://housecall.trendmicro.com/)、[VBA32](http://www.anti-virus.by/en/index.shtml)、[VIPRE](http://www.vipreantivirus.com/)、ViRobot、[VirusBuster](http://www.virusbuster.hu/en)  
（点击文字即可转到该杀毒软件的官方主页）。  
  
**防毒软件是很重要的！它在个杀毒的过程中扮演者一个举足轻重的角色。通常一些不太严重的病毒都通不过杀毒软件这一关。**如果在正常的模式下不能完全去掉病毒，那就进入**安全模式**下启动杀毒软件扫描吧，安全模式加载的驱动比较少，病毒被启动的几率比较小，会比在正常模式下扫描更加简单。  
  
  
安全模式下扫描清除不了，甚至不能进入安全模式（笔者就遇到了这问题，悲剧啊）怎么办？那就只要用启动盘了！笔者有不同的启动盘比如Win7PE，BartPE（可通过PEBuilder制作，[PEBuilder的官方网站](http://www.nu2.nu/pebuilder/)），老毛桃U盘启动（[老毛桃官方网站](http://www.laomaotao.net/)），Sardu（强力推荐，[Sardu的官方网站](http://www.sarducd.it/)）等等，都是之前笔者“贪玩”时烧录的，现在终于用到了！个人比较推荐之前举例的几个因为集合了很多常用的工具比如DiskGenius、Dos工具箱、Win7PE等等，而Sardu是个万能的启动盘自作工具，支持制作ISO和启动盘。
[![image](http://lh5.ggpht.com/-VaMJR6TmnVQ/UEychguikKI/AAAAAAAAB5k/ZAqkOT8j8fk/image_thumb%25255B4%25255D.png?imgmax=800 "image")](http://lh4.ggpht.com/-bdKg9MWCYz8/UEycgtd9ehI/AAAAAAAAB5c/8_zZiN2_01A/s1600-h/image%25255B12%25255D.png)
Sardu包含了各种各样不同的工具和操作系统，分为5大类，分别是Antivirus、Utility、Linux和Windows，每个分类都包含了很多不同的工具，Antivirus下有[AVG
Rescue](http://www.avg.com/us-en/avg-rescue-cd)、[BitDefender
Rescue](http://download.bitdefender.com/rescue_cd/)、[Kaspersky
Rescue](http://rescuedisk.kaspersky-labs.com/rescuedisk/)等15种不同的防毒软件，Utility下有[Clonezilla](http://clonezilla.org/)、[Gparted](ttp://sourceforge.net/projects/gparted/files/gparted-live-stable/)、[Partition
Wizard](http://www.partitionwizard.com/download.html)、[Ophcrack](http://ophcrack.sourceforge.net/)、[Trinity
Rescue
Kit](http://trinityhome.org/Home/index.php?content=TRINITY_RESCUE_KIT_DOWNLOAD&front_id=12&lang=en&locale=en)、[Ultimate
Boot
CD](http://www.ultimatebootcd.com/download.html)等等15种常工具，Linux下有[BackTrack](http://www.backtrack-linux.org/downloads/)、[Damn
Samll Linux](http://www.damnsmalllinux.org/download.html)、[Puppy
Linux](http://puppylinux.org/main/Download%20Latest%20Release.htm)、[xPUD](http://www.xpud.org/download.en.html)、[Ubuntu](http://www.ubuntu.com/desktop/get-ubuntu/download)、[Kubuntu](http://draft.blogger.com/=http://www.kubuntu.org/getkubuntu)、[Android
x86](http://www.android-x86.org/download/)等等总共17种Linux类的操作系统，而Windows大类又分成Windows
PE、Win Recovery Disk和Win Installer 三小类，全部均属于Copyrighted
file，不能下载，要自行制作。  
  
在Sardu下制作启动盘的方法很简单，只下载相应的ISO文件，然后放到Sardu的ISO文件夹下，开启Sardu后，程序就会自动搜索ISO文件和闪盘（Pendrive），点击“Make
USB”就可以制作启动盘了！
（注：制作启动盘会格式化该闪盘！请备份重要数据！）。烧录好启动盘或者Boot
CD 后，就可以使用光盘/闪盘开机（记得在BIOS设置U盘为First Boot
Device）了，然后就选择Antivirus
目录，进入AntiVirus就可以扫毒了（在这个时候病毒应该不可能启动了吧）。  
  
**杀毒软件虽重要，启动盘也不能少，强烈建议现在开始烧录一个启动盘做备用！**有一天肯定会用到的！假如连杀毒都救不了，那只好掏钱给电脑店重装系统（其实也可以自己来的！）了。
  
  
还有，笔者之前说了本站的DropBox文件被感染了吧（[【紧急】本站DropBox中毒了](http://garyngzhongbo.blogspot.com/2012/09/dropbox.html)）？现在分享下Dropbox救了本站资料一命的功能——View
Versions。先登录网页版本的Dropbox：[www.dropbox.com](http://www.dropbox.com/)，然后在需要恢复到之前版本的文件上点击右键，在弹出的菜单上选择“Previous
Versions”，然后就会看到一个显示文件版本历史的表，点击其中一个version，按下左下角的“restore”就好啦！
[![image](http://lh4.ggpht.com/-nL1R0_Dr8Cw/UEycj_u43GI/AAAAAAAAB50/f4WpVyyaUrU/image_thumb%25255B2%25255D.png?imgmax=800 "image")](http://lh4.ggpht.com/-8FAcomo09VY/UEyci9rIH-I/AAAAAAAAB5o/6XvFmWyzUNw/s1600-h/image%25255B6%25255D.png)
[![image](http://lh4.ggpht.com/-9cQhiQ42fGA/UEycmYmaDxI/AAAAAAAAB6E/c2GPqudDnnc/image_thumb%25255B3%25255D.png?imgmax=800 "image")](http://lh6.ggpht.com/-EqL_Y4J5SA4/UEyckyEmykI/AAAAAAAAB54/VcGcdnSJC00/s1600-h/image%25255B9%25255D.png)
呼～好长的一篇文章，希望对大家有用！
