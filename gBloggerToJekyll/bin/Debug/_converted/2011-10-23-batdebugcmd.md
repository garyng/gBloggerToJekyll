---
layout: post
title: '[原创][BAT] DEBUG命令控制CMD窗口的颜色！'
author: 'Gary Ng'
tags: ['原创','批处理']
---

学DEBUG命令时发现的～  
  
 打开CMD  
 输入DEBUG  
  
 再输入这些：  
  
产生黑底黑字  
 F B800:00 F9F 20 00
  
产生白底黑字  
 F B800:00 F9F 20 F0[/code]
  
产生红底黑字  
 F B800:00 F9F 20 40  
  
产生绿底黑字  
 F B800:00 F9F 20 20  
  
产生蓝底黑字 
F B800:00 F9F 20 10
  
  
  
而最后两个字便是COLOR命令中的颜色代码！
“10”就是蓝底黑字
与COLOR命令一模一样！
F B800:00 F9F 20 0A
就是亮青色的字和黑底
  
  
也许有些人会想：
用COLOR命令不就好了吗？
  
可是看看：
  
如果改变
F B800:00 F9F 20 10
  
中的“20”
看看会得到什么结果：
例如：
  
F B800:00 F9F 10 10
  
就会看到：
[![](http://4.bp.blogspot.com/-vsQ8b8nfjNs/TqOrm7qzW0I/AAAAAAAAATE/DQn-E_HUNaY/s640/debug.jpg)](http://4.bp.blogspot.com/-vsQ8b8nfjNs/TqOrm7qzW0I/AAAAAAAAATE/DQn-E_HUNaY/s1600/debug.jpg)
  
  
如果改成：
  
F B800:00 F9F 12 34
  
  
  
就会看到：
  
[![](http://3.bp.blogspot.com/-gI7_lLBXQto/TqOsMmcSOMI/AAAAAAAAATM/fInfFw-zkxE/s640/debug1.jpg)](http://3.bp.blogspot.com/-gI7_lLBXQto/TqOsMmcSOMI/AAAAAAAAATM/fInfFw-zkxE/s1600/debug1.jpg)
  
  
如果再改成：
  
F B800:00 F9F 41 0F  
  
就会看到：
[![](http://1.bp.blogspot.com/-aXaEXEMl7a4/TqOtdbvHQaI/AAAAAAAAATU/RyAO0m1Ncmw/s640/debug2.jpg)](http://1.bp.blogspot.com/-aXaEXEMl7a4/TqOtdbvHQaI/AAAAAAAAATU/RyAO0m1Ncmw/s1600/debug2.jpg)
  
看出什么了吗？
对了！
对应的16进制ASCII码！
  
那单调的CMD又有新突破啦！
  
  
另外：
  
F B800:00 F9F
后面还可以添加字符哦！
  
如果输入F B800:00 F9F 41 42 43 44 45 46 47 48 49 50 
  
效果：
[![](http://2.bp.blogspot.com/-3uaQVzr6zUc/TqPJAnYICcI/AAAAAAAAATk/QhVgSNNzxhE/s640/debug4.jpg)](http://2.bp.blogspot.com/-3uaQVzr6zUc/TqPJAnYICcI/AAAAAAAAATk/QhVgSNNzxhE/s1600/debug4.jpg)
  
F B800:00 F9F  
过后的数字的个数不同，产生出来的图案也不同呢！
  
  
如果个数是个偶数的话，效果如之前那样
如果是奇数：
例如
F B800:00 F9F 41 42 43 44 45 46 47 48 49
  
效果图：
[![](http://4.bp.blogspot.com/-aP3ywj79Ap4/TqPKSaHIPgI/AAAAAAAAATs/BP4nfmWQ3RE/s640/debug5.jpg)](http://4.bp.blogspot.com/-aP3ywj79Ap4/TqPKSaHIPgI/AAAAAAAAATs/BP4nfmWQ3RE/s1600/debug5.jpg)
  
  
还有：
F B800:00 F9F 2 1  
[![](http://3.bp.blogspot.com/-Z9Buw7N5pOg/TqPMsGUyhMI/AAAAAAAAAT8/r17OLkrhMD0/s640/debug7.jpg)](http://3.bp.blogspot.com/-Z9Buw7N5pOg/TqPMsGUyhMI/AAAAAAAAAT8/r17OLkrhMD0/s1600/debug7.jpg)
  
  
F B800:00 F9F 21
[![](http://4.bp.blogspot.com/-EqMAqYeIRfk/TqPNGLebKFI/AAAAAAAAAUE/iaIjqxeTdeg/s640/debug8.jpg)](http://4.bp.blogspot.com/-EqMAqYeIRfk/TqPNGLebKFI/AAAAAAAAAUE/iaIjqxeTdeg/s1600/debug8.jpg)
这个相等于
F B800:00 F9F 21 21
  
  
  
来张玩玩的：
F B800:00 F9F 41 42 43 44 45 46 47 48 49 50 51 52 53 54 55 56 57 58 59
60 61  
[![](http://2.bp.blogspot.com/-jGdxLH26qqY/TqPK8UtHFxI/AAAAAAAAAT0/axsoSBaa-Hc/s640/debug6.jpg)](http://2.bp.blogspot.com/-jGdxLH26qqY/TqPK8UtHFxI/AAAAAAAAAT0/axsoSBaa-Hc/s1600/debug6.jpg)
  
  
  
附上：ASCII码表
  
  
  
控制字符
  
<table>
<colgroup>
<col width="16%" />
<col width="16%" />
<col width="16%" />
<col width="16%" />
<col width="16%" />
<col width="16%" />
</colgroup>
<tbody>
<tr class="odd">
<td align="left"><strong>二进制</strong>
<strong>十进制</strong>
<strong>十六进制</strong>
<strong>缩写</strong>
<strong>可以显示的表示法</strong>
<strong>名称／意义</strong></td>
<td align="left">0000 0000
0
00
NUL
␀
空字符（Null）</td>
<td align="left">0000 0001
1
01
SOH
␁
标题开始</td>
<td align="left">0000 0010
2
02
STX
␂
本文开始</td>
<td align="left">0000 0011
3
03
ETX
␃
本文结束</td>
<td align="left">0000 0100
4
04
EOT
␄
传输结束</td>
</tr>
</tbody>
</table>

  
  
可显示字符****
  
<table>
<colgroup>
<col width="20%" />
<col width="20%" />
<col width="20%" />
<col width="20%" />
<col width="20%" />
</colgroup>
<tbody>
<tr class="odd">
<td align="left"><table>
<colgroup>
<col width="25%" />
<col width="25%" />
<col width="25%" />
<col width="25%" />
</colgroup>
<tbody>
<tr class="odd">
<td align="left"><strong>二进制</strong>
<strong>十进制</strong>
<strong>十六进制</strong>
<strong>图形</strong></td>
<td align="left">0010 0000
32
20
（空格）(␠)</td>
<td align="left">0010 0001
33
21
<a href="http://zh.wikipedia.org/wiki/%E6%84%9F%E5%8F%B9%E5%8F%B7" title="感叹号">!</a></td>
<td align="left">0010 0010
34
22
&quot;</td>
</tr>
</tbody>
</table>
<br />
<table>
<colgroup>
<col width="25%" />
<col width="25%" />
<col width="25%" />
<col width="25%" />
</colgroup>
<tbody>
<tr class="odd">
<td align="left"><strong>二进制</strong>
<strong>十进制</strong>
<strong>十六进制</strong>
<strong>图形</strong></td>
<td align="left">0100 0000
64
40
@</td>
<td align="left">0100 0001
65
41
A</td>
<td align="left">0100 0010
66
42
B</td>
</tr>
</tbody>
</table>
<br />
<table>
<colgroup>
<col width="25%" />
<col width="25%" />
<col width="25%" />
<col width="25%" />
</colgroup>
<tbody>
<tr class="odd">
<td align="left"><strong>二进制</strong>
<strong>十进制</strong>
<strong>十六进制</strong>
<strong>图形</strong></td>
<td align="left">0110 0000
96
60
<a href="http://zh.wikipedia.org/wiki/%E9%87%8D%E9%9F%B3%E7%AC%A6" title="重音符">`</a></td>
<td align="left">0110 0001
97
61
a</td>
<td align="left">0110 0010
98
62
b</td>
</tr>
</tbody>
</table></td>
</tr>
</tbody>
</table>

  
  

