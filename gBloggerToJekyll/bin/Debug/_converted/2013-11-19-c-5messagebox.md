---
layout: post
title: '[教程][C#] 新手入门教程#5——开始写代码：MessageBox'
author: 'Gary Ng'
tags: ['C#','入门','原创','教程','新手']
---

现在进入灰常好玩的地方——我们开始写代码！（这让我想起——【[题外话】一首诗歌-写代码](http://garyngzhongbo.blogspot.com/2011/12/blog-post.html)）  
  

# 【如何显示代码编辑器】

如果你忘了——点击form，按下F7  
 或者是右键点击form \> 点击View Code  

[![image](http://lh6.ggpht.com/-ZWMAv4z_Yc0/UhnmIR3LneI/AAAAAAAAEGo/qDDMk5mgiOk/image_thumb2.png?imgmax=800 "image")](http://lh6.ggpht.com/-tmavjX9GcKw/UhnmIC40cQI/AAAAAAAAEGg/XOA-wuPkysg/s1600-h/image8.png)  
 就会有这个了：  

[![image](http://lh4.ggpht.com/-00cpJhcY858/UhnmJtaIEPI/AAAAAAAAEG4/WdMXAl3VKqs/image_thumb1.png?imgmax=800 "image")](http://lh5.ggpht.com/-1u-rjvx1yDk/UhnmJG6HNNI/AAAAAAAAEGw/BjEPufUaBNg/s1600-h/image5.png)  
  

# 【基本设置】

先不谈代码，往form添加一个新的button，然后更改text 为 "Click Me!"

[![image](http://lh6.ggpht.com/-30-XSG6ubN8/UhnmKqT2lmI/AAAAAAAAEHI/ZXYLf3hxCRI/image_thumb3.png?imgmax=800 "image")](http://lh4.ggpht.com/-HWmRw5szKfU/UhnmKFoG3UI/AAAAAAAAEHA/aVErmflHuW0/s1600-h/image11.png)

# 【初探Function】

双击button，你会看到在原本的代码上加了新的代码：

[![image](http://lh3.ggpht.com/-oAx_rXkiIQc/UhnmLgVP2uI/AAAAAAAAEHY/vKPGnw7t2tY/image_thumb.png?imgmax=800 "image")](http://lh5.ggpht.com/-nEHaT3ostSI/UhnmLE5zvPI/AAAAAAAAEHQ/fwxB-rcN-Oc/s1600-h/image%25255B2%25255D.png)

     

    这就是一个标准的function （其实是个event的function，先别管这些）

    private、void 等等这些东西先别管，免得混淆了（你只要知道这是一个function就就对了）

    我们来看看button1_click，很明显吧？

    就是button1 被click 的时候，这个function就会被运行，至于括弧里面的是参数

    运行？运行什么？就是运行在花括号内{}的代码！

     

  

# 【初探Intellisense】

  

消息框的英文是啥？

  

Message Box！ 所以要显示message box 就必须呼叫message box！

  

于是兴致勃勃的打下message box

  

咦？等等，VS跳出来的这东西是啥？

  

[![image](http://lh3.ggpht.com/-L4qBNgKkTgA/UhnmM8DK4FI/AAAAAAAAEHo/X-0vEyv9GgQ/image_thumb%25255B1%25255D.png?imgmax=800 "image")](http://lh5.ggpht.com/-i1-I1uhl6cc/UhnmMQ9ecII/AAAAAAAAEHg/1kvBwffurVg/s1600-h/image%25255B5%25255D.png)

  
 这就是Intellisense，华文叫啥？我不知道！  
  
 总之它是auto-complete的好帮手  
  
 看到VS帮你focus在
MessageBox上了么？直接按下Enter键，它就会帮你打好了！（快吧！）  
  

[![image](http://lh4.ggpht.com/-fSnJHNCm23s/UhnmN4ujU8I/AAAAAAAAEH4/vrAxcLGEtUo/image_thumb%25255B2%25255D.png?imgmax=800 "image")](http://lh6.ggpht.com/-1S1eDazlq0I/UhnmNWWHaJI/AAAAAAAAEHw/V1bkpLGReKU/s1600-h/image%25255B8%25255D.png)  
  
  
  

# 【显示MessageBox】

  
 OK，现在我们有MessageBox了，要咋才能跳出一个框框？  
  
 我：显示的英文叫啥？  
  
 你：Show！  
  
 我：所以显示MessageBox叫啥？  
  
 你：Show MessageBox！  
  
 我：我汗！  
  
 好啦好啦，对了差不对一半了  
  
 正确的是MessageBox.Show，因为要show的是MessageBox
，MessageBox为主，show为副，所以就MessageBox.Show啦！  
  
 看到了没？可爱的Intellisense又出来了，猛打enter！  
  

[![image](http://lh4.ggpht.com/--BKY2e1FN4I/UhnmPPoaaJI/AAAAAAAAEII/0iVzVkJLYDs/image_thumb%25255B3%25255D.png?imgmax=800 "image")](http://lh4.ggpht.com/-80uPKnf6QJk/UhnmOTXJNzI/AAAAAAAAEIA/RE0LOsKNqNQ/s1600-h/image%25255B11%25255D.png)  
  
  
  
 你：等等！我要显示的字串放哪里啊？  
  
 恩..这问题问得好！  
  
 之前已经打了MessageBox.Show对吧：  
  

[![image](http://lh5.ggpht.com/-tjl_qGElvgk/UhnmP0_Mh8I/AAAAAAAAEIY/rrt20lYPW8w/image_thumb%25255B4%25255D.png?imgmax=800 "image")](http://lh3.ggpht.com/-0-8hG1Id3LA/UhnmPSHIxXI/AAAAAAAAEIQ/72zaEXFtycY/s1600-h/image%25255B14%25255D.png)  
  
  
  
 就如function的括弧一样，在打下一个括弧  
  
 然后Intellisense又出来了！  
  

[![image](http://lh3.ggpht.com/-HbyblNVg3Kc/UhnmRCjdB4I/AAAAAAAAEIo/Ir7o1OhhFYQ/image_thumb%25255B5%25255D.png?imgmax=800 "image")](http://lh4.ggpht.com/-Gumi0MAfZG8/UhnmQVBNwoI/AAAAAAAAEIg/p_4zVaRakpY/s1600-h/image%25255B17%25255D.png)  
  
  
  
 System.Windows.Forms.DialogResult MessageBox.Show(string text)  
  
 string text是啥？  
  
 就是一个为类型为string（顾名思义就是字串啦！）的变量text！  
  
 你：所以呢？  
  
 我：汗！那么明显了看不出来么..  
  
 就是把要显示的字串放在括弧之间啦！  
  
 然后你又兴致勃勃地打入MessageBox.Show(Hello,World!)  
  
 接着VS就帮你画了个很漂亮的波浪线给你：  
  

[![image](http://lh6.ggpht.com/-TfEKhcMDC-U/UhnmSE2kNrI/AAAAAAAAEI4/L545qPFuRk0/image_thumb%25255B6%25255D.png?imgmax=800 "image")](http://lh3.ggpht.com/-dsjuT9maBXA/UhnmRT4U1HI/AAAAAAAAEIw/ZfyOfV9NyWM/s1600-h/image%25255B20%25255D.png)  
  
  
  
 你：这是神马状况？是神马状况？你说啊你说啊！  
  

为什么会有红色波浪线？因为VS把Hello,World!当成是一个代码了，然后它很努力的往他的脑袋搜索Hello,World!代表着什么，N秒后发现到脑袋内竟然没有这个东东，于是弱弱的画了波浪线给你（很像老师批改考卷吧？）  
  
 你：说重点！  
  

好好好，记住了：所有的非代码（就是不要VS往脑里搜的，这里是指字串，string），都要加上开关引号——""（如果你不知道开关引号是啥：就是在Enter旁边的那个按键xD）  
  
 于是你打下了MessageBox.Show(“Hello,World!”)  
  

[![image](http://lh5.ggpht.com/-7aULF7DLjxo/UhnmTUHSHHI/AAAAAAAAEJI/Zgnzkis1a0w/image_thumb%25255B7%25255D.png?imgmax=800 "image")](http://lh6.ggpht.com/-LGEQ0aOIMnE/UhnmSeBb_kI/AAAAAAAAEJA/B9xUx8yr77Q/s1600-h/image%25255B23%25255D.png)  
  
  
  
 你：这又是神马情况？为啥还有波浪的！  
  
 我：为什么会有波浪线？因为VS..  
  
 你：说重点！  
  
 记住了：所有的代码（当然有一些除外），末端要加上一个分号;
（如果你又不知道分号是啥，就是那个在Enter的旁边的旁边那个按键xDD）  
  
 因为你要让VS知道该代码在那一行停下，就是我们的句号那样 "。"  
  
 所以正确的代码就是：  
  

[![image](http://lh4.ggpht.com/-F-OrH-graX8/UhnmUheELEI/AAAAAAAAEJY/mnU0hSfbKjE/image_thumb%25255B8%25255D.png?imgmax=800 "image")](http://lh6.ggpht.com/-Fga9wXwu2iA/UhnmUBAIgcI/AAAAAAAAEJQ/yO_fVmq8BUc/s1600-h/image%25255B26%25255D.png)  
  
  
  
 你：然后呢？  
  
 我：按下那个代表着成功的按键！  
  
 你：啥？  
  

就是debug键啦——F5或者是上方的[![image](http://lh3.ggpht.com/-x7UH1AuagII/UhnmV7kCLUI/AAAAAAAAEJo/46HfjjLPULY/image_thumb%25255B9%25255D.png?imgmax=800 "image")](http://lh6.ggpht.com/-8RZTS2ejzpQ/UhnmVZortDI/AAAAAAAAEJg/AAbc_7VOeqg/s1600-h/image%25255B29%25255D.png)  
  

[![image](http://lh3.ggpht.com/-RlV1-fzE1Js/UhnmW-s-9EI/AAAAAAAAEJ4/S-9u8b57-QA/image_thumb%25255B10%25255D.png?imgmax=800 "image")](http://lh3.ggpht.com/-GLqDSZn7HrU/UhnmWX0EnkI/AAAAAAAAEJw/lFR-iv1xYOk/s1600-h/image%25255B32%25255D.png)  
  
  
  
 然后就会看到这个：  
  

[![image](http://lh3.ggpht.com/-jeiF6X7P4fA/UhnmYIVpLcI/AAAAAAAAEKI/GERuaqRAA9k/image_thumb%25255B11%25255D.png?imgmax=800 "image")](http://lh6.ggpht.com/-wEoHxWiHBi4/UhnmXklOa5I/AAAAAAAAEKA/Oc_q4HlJ4YM/s1600-h/image%25255B35%25255D.png)  
  
  
  
 看到button了么？  
  
 用尽全力点下他！  
  

[![image](http://lh4.ggpht.com/-NPkMyZKBKUw/UhnmZPx6rgI/AAAAAAAAEKY/xAyNL-FKbhY/image_thumb%25255B12%25255D.png?imgmax=800 "image")](http://lh3.ggpht.com/-Wnw73mmL2c4/UhnmYq5jwwI/AAAAAAAAEKQ/ZvC3RM9caTI/s1600-h/image%25255B38%25255D.png)  
  
  
  
 你成功了！  
  
  
  

## 【更换标题】

  
  
  
 你：为啥没有标题的？  
  
 恩..good question!  
  
 现在点击"Hello,World!"后面（括号前面），然后输入一个逗号,  
  
 然后救世主出来了：  
  

[![image](http://lh5.ggpht.com/-cVglNjNLL1w/UhnulGeb1ZI/AAAAAAAAEKw/ILmLj3mlx3E/image_thumb%25255B13%25255D.png?imgmax=800 "image")](http://lh3.ggpht.com/-RQr4Orcq9M0/UhnukrbTUPI/AAAAAAAAEKo/ZygqkNX2MnA/s1600-h/image%25255B41%25255D.png)  
  
  
  

看到旁边的[![image](http://lh3.ggpht.com/-ptQRXI9YRj0/UhnumMNpZFI/AAAAAAAAELA/OyVeO4YpRJA/image_thumb%25255B14%25255D.png?imgmax=800 "image")](http://lh5.ggpht.com/-j7RNgVnzbP4/UhnulkW5q-I/AAAAAAAAEK4/HniNve3DnOc/s1600-h/image%25255B44%25255D.png)么？  
  
 现在按“下”键（不是下x贱…，是那个方向键），一直到你看到这个：  
  

[![image](http://lh3.ggpht.com/-0adTVhAkH4E/UhnunO7NOiI/AAAAAAAAELQ/4sH7XBIzAl8/image_thumb%25255B15%25255D.png?imgmax=800 "image")](http://lh3.ggpht.com/-iuuCilOkLFo/Uhnumtt_ybI/AAAAAAAAELI/5qu6qDaAWyE/s1600-h/image%25255B47%25255D.png)  
  
  
  
 caption是啥？标题！  
  
 然后..你懂的：  
  

[![image](http://lh5.ggpht.com/-DZMiVJOonZ0/UhnuoEsH2vI/AAAAAAAAELg/0BOf13qYp-M/image_thumb%25255B16%25255D.png?imgmax=800 "image")](http://lh3.ggpht.com/-qzwJ5Tmiv78/Uhnunjvb8tI/AAAAAAAAELY/uVvE94_VpEA/s1600-h/image%25255B50%25255D.png)  
  
 然后编译，点击button：  
  

[![image](http://lh6.ggpht.com/-QdLXJwIkrDc/UhnupDlEgDI/AAAAAAAAELw/dwt8F8q1HdY/image_thumb%25255B17%25255D.png?imgmax=800 "image")](http://lh4.ggpht.com/-IS_IWmJZUL8/UhnuonJMClI/AAAAAAAAELo/hjuilVZagCs/s1600-h/image%25255B53%25255D.png)  
  
  
  
 有木有觉得很有成就感？  
  
  
  

## 【更换按钮】

  
  
  
 你：我可以换掉那个OK按钮么？能不能放"Hello,World!"？  
  
 我：..你怎么发现了 不！！  
  
 是不是MessageBox的OK按钮很单调、无聊？按钮是可以改的，.net
给你了一堆option让你更改MessageBox显示的按钮，至于更换成"Hello,World!"的话..对不起，暂时没有
xD  
  
 在加个逗号，按下N次下键后，你会看到这个：  
  

[![image](http://lh4.ggpht.com/-u1vmbeqqEn8/UiATBPtHDNI/AAAAAAAAEOY/xWnzVnjzu70/image_thumb%25255B1%25255D.png?imgmax=800 "image")](http://lh5.ggpht.com/-6wLa5DpKPeo/UiATAYy7iJI/AAAAAAAAEOQ/cGmRgdiK7BU/s1600-h/image%25255B3%25255D.png)  
  
  
  
 你：MessageBoxButtons是来的？  
  
 MessageBoxButtons 是一个enum，至于enum是啥..恩..现在不说先xD  
  
 只要输入 MessageBoxButtons然后加上一个 .  就会看到N个种类：  
  

[![image](http://lh4.ggpht.com/-NW46XpevOMM/UiATCLBzHXI/AAAAAAAAEOo/zL8SKfsG4rU/image_thumb%25255B2%25255D.png?imgmax=800 "image")](http://lh3.ggpht.com/-Cj2X4-Yo1uU/UiATBvzYJ0I/AAAAAAAAEOg/3JXINaW2dPw/s1600-h/image%25255B6%25255D.png)  
  
  
  
  
 看到了没？  
  
 有AbortRetryIgnore,OK,OKCancel,RetryCancel,YesNo,YesNoCancel  
  
 比如说OK，MessageBox上面就只是显示OK  
  
 YesNo呢，就是Yes 和 No 咯！  
  
 咱们试试YesNo看看：  
  

[![image](http://lh6.ggpht.com/-pjwVSiREd4w/UiATDj8zf0I/AAAAAAAAEO4/6vEIMDeKWW0/image_thumb%25255B3%25255D.png?imgmax=800 "image")](http://lh4.ggpht.com/-IDhJsBzGtYY/UiATCn7BwuI/AAAAAAAAEOw/uUHQHDbu7wA/s1600-h/image%25255B9%25255D.png)  
  
  
  
 然后编译、运行：  
  

[![image](http://lh6.ggpht.com/-yEqgj-E6j6o/UiATEwVah3I/AAAAAAAAEPI/MbjksS0dMds/image_thumb%25255B4%25255D.png?imgmax=800 "image")](http://lh6.ggpht.com/-BWabcUvfxjw/UiATET-4zqI/AAAAAAAAEPA/KMp2UVM3wrE/s1600-h/image%25255B12%25255D.png)  
  
  
  
 你佩服自己么？  
  
  
  

## 【更换Form标题】

  
  
  
 你：在弱弱问一个：能不能更换那个Form的标题啊？我不要Form1..  
  
 我：Properties!Properties!  
  
 点击Form 找到Text 属性！更改！（激动中）  
  

[![image](http://lh5.ggpht.com/-YLUdVEE_esM/UiATHeUXB-I/AAAAAAAAEPY/wW2T6CkIhAQ/image_thumb%25255B5%25255D.png?imgmax=800 "image")](http://lh6.ggpht.com/-8Zo7djsqyUo/UiATFkeH8mI/AAAAAAAAEPQ/vaV3qYasovo/s1600-h/image%25255B15%25255D.png)  
  
  
  
  
  
 好了..MessageBox教到此.. 再见！

