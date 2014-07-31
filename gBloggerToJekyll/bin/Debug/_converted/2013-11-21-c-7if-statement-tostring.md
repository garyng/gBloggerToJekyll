---
layout: post
title: '[教程][C#] 新手入门教程#7——初识If Statement + .ToString() 方法'
author: 'Gary Ng'
tags: ['C#','入门','原创','教程','新手']
---

之前在教程\#5
你认识了那帅帅的MessageBox，而且知道了如何更改MessageBox的显示按钮（OK、Yes、No等等），于是你又问问题了  

你：如果用户按下Yes的话，我就MessageBox弹出“Yes”，按下No的话，就MessageBox显示“No”要肿么样呢？  
 我们来分析（或者说写“伪代码”，就是不是代码的代码）：  

> 如果 用户按下“Yes”按钮  
>  让 MessageBox 显示“Yes”  
>  如果 用户按下“No”按钮  
>  让 MessageBox 显示“No”

我：如果的英文叫啥？  
 你：If！  
 我：厉害厉害！  
 先让我们看看MessageBox的代码咋写：  
 在Windows Form 上添加一个Button  
 然后双击Button  
 先写个MessageBox，显示“Yes/No”  
 标题为“If Tests!”  
 然后设置显示的按钮是Yes和No罢了：  

[![image](http://lh4.ggpht.com/-2WCdeKdQMM4/Uk2ELK_et1I/AAAAAAAAEik/qcYA7WoU5Qs/image_thumb.png?imgmax=800 "image")](http://lh4.ggpht.com/-7G-PR1SNPuo/Uk2EKk58MxI/AAAAAAAAEic/037s_0hx2mg/s1600-h/image%25255B2%25255D.png)  
  
 MessageBox 在用户点击的时候就会返回一个enum（先别管这个是啥）  
 用来表示用户点击了啥按钮  
 用来看MessageBox点击了什么按钮的方法就是：在用一个MessageBox来显示！  

[![image](http://lh4.ggpht.com/-8oi4BHcPbOU/Uk2EMy3b9uI/AAAAAAAAEi0/s1WXrMfn50Q/image_thumb%25255B1%25255D.png?imgmax=800 "image")](http://lh4.ggpht.com/-Iz_pP1omXKk/Uk2EMDYKNgI/AAAAAAAAEis/wZt4vU1LVbg/s1600-h/image%25255B5%25255D.png)  

这里的.ToString()是一个方法（Method，或者是Function），它能（很神奇的）把所有object
转成String，为什么要转成String呢?因为MessageBox只接受String咯！  
 按下F5编译运行试试看：  
 点击Button就会看到这个MessageBox：  

[![image](http://lh3.ggpht.com/-yMDUs2Jcrnc/Uk2EOPIxwHI/AAAAAAAAEjE/2RsYO_zbPnw/image_thumb%25255B2%25255D.png?imgmax=800 "image")](http://lh6.ggpht.com/-9pMNVFR-Zm4/Uk2ENQx7AGI/AAAAAAAAEi8/gtzZSjOXQqk/s1600-h/image%25255B8%25255D.png)  
 试试看点击“Yes”  
 就会有另外个MessageBox弹出，显示你刚才点击的按钮：  

[![image](http://lh4.ggpht.com/-MNuX4PPELhc/Uk2EPbgt9kI/AAAAAAAAEjU/vsifOMN_hxA/image_thumb%25255B4%25255D.png?imgmax=800 "image")](http://lh3.ggpht.com/-lF9s-WHNjmQ/Uk2EOj0vArI/AAAAAAAAEjM/O9bfEqV_8cc/s1600-h/image%25255B14%25255D.png)  
 雷吧？  
 你：我不要MessageBox里面又有MessageBox的啦！我不要我不要！  
 好吧，教程\#5教过用变量了吧？  
 现在用吧！  
 我们知道  

```
MessageBox.Show("Yes/No","If tests..",MessageBoxButtons.YesNo).ToString() 
```

  

  
  
  
 是string吧！创建一个string变量来储存MessageBox返回的参数  
 然后在用MessageBox show 那个变量里面的值：  

[![image](http://lh3.ggpht.com/-5yK3CpasFEU/Uk2EQfloLlI/AAAAAAAAEjk/DUytjKT0XMo/image_thumb%25255B6%25255D.png?imgmax=800 "image")](http://lh6.ggpht.com/-Iyx40U6dWrg/Uk2EP5fJ4wI/AAAAAAAAEjc/-Kg7T0dkjc8/s1600-h/image%25255B20%25255D.png)  
 好啦好啦：  

[![image](http://lh3.ggpht.com/-eEWSssRhsWY/Uk2ER-DiKBI/AAAAAAAAEj0/DrcO5Fib6yo/image_thumb%25255B7%25255D.png?imgmax=800 "image")](http://lh3.ggpht.com/-i-B5zCwg2xw/Uk2ERT7wQCI/AAAAAAAAEjs/wi7FB0uyf9U/s1600-h/image%25255B23%25255D.png)  
 运行！  

[![image](http://lh6.ggpht.com/-rzn1hQSr2sg/Uk2ETTLvW_I/AAAAAAAAEkE/bP3Q4djS92U/image_thumb%25255B8%25255D.png?imgmax=800 "image")](http://lh4.ggpht.com/-73AcMDdLIh0/Uk2ESivERiI/AAAAAAAAEj8/i0YpaHwFTUY/s1600-h/image%25255B26%25255D.png)  
 然后：  

[![image](http://lh3.ggpht.com/-08f8yji7QSo/Uk2EUn_PW9I/AAAAAAAAEkU/hR2IWdMjuew/image_thumb%25255B9%25255D.png?imgmax=800 "image")](http://lh5.ggpht.com/-1YbY--XyrDk/Uk2ET6qQmdI/AAAAAAAAEkM/cnVWWjhBoeY/s1600-h/image%25255B29%25255D.png)  
  
 你：Where is my IF ?  
 正题来了，先删除之前写过的代码，我们“砍掉”重练！  
 if 的格式是这样的：  

```
if ( Boolean Expression)
{
    //Body
}
```

而  

```
//Body
```

里面就是当Boolean Expression 为True 时运行的代码  
 你：Boolean Expression是啥？  
 Boolean Expression就是多个relational operator 组成的“公式”：  
 假设我用有  

> 变量A = 20  
>  变量B = 30

  

<table>
<colgroup>
<col width="33%" />
<col width="33%" />
<col width="33%" />
</colgroup>
<tbody>
<tr class="odd">
<td align="left">Operators
Description
Example</td>
<td align="left">==
如果两边（就是'=='的之前和之后）<strong>相等</strong>，就返回True
(A == B) 为 False ，A 不等于 B</td>
<td align="left">!=
如果两边<strong>不相等</strong>，返回True
(A != B) 为 True，A 不等于B</td>
</tr>
</tbody>
</table>

  
 很像数学对吧？  
 现在来看看基本的if 如何写：  
 定义两个int 变量，  

> A 为 20  
>  B 为 30

（就像上面那样）  

[![image](http://lh4.ggpht.com/-yCnHDK1MDsM/Uk2EVvGgdgI/AAAAAAAAEkg/cWXbmzJsI7o/image_thumb%25255B10%25255D.png?imgmax=800 "image")](http://lh3.ggpht.com/-nt1BNVu2moI/Uk2EVLFRZSI/AAAAAAAAEkc/x4gAKdkFoGs/s1600-h/image%25255B32%25255D.png)  

    现在来看看 == 运算符吧

     

    然后运行看看

    MessageBox 并没有弹出来

    你：为啥？

    我：因为A 不等于 B 咯！

  
 再试试!= 看看：  
  

[![image](http://lh6.ggpht.com/-LTh3-sJLTWI/Uk2EX45BC6I/AAAAAAAAElE/AAYQIqcktbA/image_thumb%25255B13%25255D.png?imgmax=800 "image")](http://lh5.ggpht.com/-x3VKy88Gkx4/Uk2EXWayTHI/AAAAAAAAEk8/acvI2heg9sg/s1600-h/image%25255B41%25255D.png)  
  
 然后运行：  
  

[![image](http://lh4.ggpht.com/-CaGi6f5MbN8/Uk2EZFsS2PI/AAAAAAAAElU/igRpfvoWFls/image_thumb%25255B14%25255D.png?imgmax=800 "image")](http://lh4.ggpht.com/-CFejWGCyHHg/Uk2EYYGBnxI/AAAAAAAAElM/69rAkcZqZqM/s1600-h/image%25255B44%25255D.png)  
  
 明白了么？  
  
  
  
 要如何判断用户点击了Message Box 上的什么按钮呢？  
  
 你可能会兴奋地写出：  
  

[![image](http://lh6.ggpht.com/-FbgKcZr2zLE/Uk2EaKMcU9I/AAAAAAAAElk/I9QFI2Z4zuM/image_thumb%25255B21%25255D.png?imgmax=800 "image")](http://lh3.ggpht.com/-hALF1IWSIe8/Uk2EZpLX61I/AAAAAAAAElc/zn_t_a5dqvU/s1600-h/image%25255B65%25255D.png)  
  
 恩！  
  
 很好！  
  
 但是还能更好！  
  
 Message Box 返回的value 是一个 DialogResult  
  
 像这样：  
  

[![image](http://lh4.ggpht.com/-Azqnl6bnUyk/Uk2EbW6VrAI/AAAAAAAAEl0/SKpEg8S1-Fk/image_thumb%25255B24%25255D.png?imgmax=800 "image")](http://lh3.ggpht.com/-gfuy7BcbMP4/Uk2Ea2KusAI/AAAAAAAAEls/LVMFV6tz9lc/s1600-h/image%25255B74%25255D.png)  
  
 DialogResult 里面有很多成员（members），我们要的是Yes：  
  

[![image](http://lh6.ggpht.com/-CNP2ObA_EWk/Uk2EcVlL3YI/AAAAAAAAEmE/yEDcn_3A4EE/image_thumb%25255B25%25255D.png?imgmax=800 "image")](http://lh3.ggpht.com/-XNkk3JhfUBU/Uk2Eb0TaN_I/AAAAAAAAEl8/16EC1nzMCUo/s1600-h/image%25255B77%25255D.png)  
  
 然后显示一个MessageBox：  
  

[![image](http://lh4.ggpht.com/-KBij2oA9O0c/Uk2EdhpAOgI/AAAAAAAAEmU/azuyb-Y5xpM/image_thumb%25255B26%25255D.png?imgmax=800 "image")](http://lh5.ggpht.com/-J6NWphMDf38/Uk2EdPTzCfI/AAAAAAAAEmM/ggqYluanYQ4/s1600-h/image%25255B80%25255D.png)  
  
 当然别忘了处理用户按了 No 按钮：  
  

[![image](http://lh5.ggpht.com/-Btf6uScWH68/Uk2Ee2HUhOI/AAAAAAAAEmk/_tkYo_pU2PE/image_thumb%25255B27%25255D.png?imgmax=800 "image")](http://lh6.ggpht.com/-fR1Znbc-wKI/Uk2EeQ2rzqI/AAAAAAAAEmc/fkdybP-oDAk/s1600-h/image%25255B83%25255D.png)  
  
 F5 编译运行后，你会发现**竟然有2个MessageBox 跳出来！**  
  
 为啥？  
  
 因为我们打了2次MessageBox.Show啊！  
  
 所以要用变量！变量！  
  
 你：MessageBox 返回是什么类型的啊？  
  
 我：就是DialogResult啊！  
  
 所以我们的变量类型是DialogResult！（有点点奇怪对吧？）  
  
  
  

[![image](http://lh4.ggpht.com/-f9Rjwi6aTio/Uk2EgBFGd2I/AAAAAAAAEm0/BQrOPhZ4jWw/image_thumb%25255B28%25255D.png?imgmax=800 "image")](http://lh5.ggpht.com/-9z43Kl9jeBM/Uk2EfirlpjI/AAAAAAAAEms/mrxPXkPSh8w/s1600-h/image%25255B86%25255D.png)  
  
 然后把两个if 里面的 MessageBox.show 换成 msg 变量：  
  

[![image](http://lh5.ggpht.com/-bMmu8YuusFw/Uk2EhttlJII/AAAAAAAAEnE/qqzax6agd14/image_thumb%25255B29%25255D.png?imgmax=800 "image")](http://lh3.ggpht.com/-sg1jF_GTDUY/Uk2Eg0_aWuI/AAAAAAAAEm8/n6V8J-bGL1E/s1600-h/image%25255B89%25255D.png)  
  
  
  
 完美运行！  
  

[![image](http://lh3.ggpht.com/-Asul9Vqr3cA/Uk2Ei2MOOxI/AAAAAAAAEnU/7ldl3YzG83I/image_thumb%25255B30%25255D.png?imgmax=800 "image")](http://lh5.ggpht.com/-pSR7YuxucGQ/Uk2EiFtXjBI/AAAAAAAAEnM/CZY_XBll2ng/s1600-h/image%25255B92%25255D.png)  
  

[![image](http://lh6.ggpht.com/-hVxGD1Hiu00/Uk2Ej3NhfbI/AAAAAAAAEnk/ah64t434BpA/image_thumb%25255B31%25255D.png?imgmax=800 "image")](http://lh5.ggpht.com/-C54tPL-2aUk/Uk2EjfSeIWI/AAAAAAAAEnc/uNKeMTceTl4/s1600-h/image%25255B95%25255D.png)  
  
  
  
 PS: 我是不会让你知道其实还有**更简单**的**if.. else..** 写法！  
  
  
  
  
  

