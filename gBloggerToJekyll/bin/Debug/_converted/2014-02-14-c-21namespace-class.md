---
layout: post
title: '[教程][C#] 新手入门教程#21——Namespace 和 Class'
author: 'Gary Ng'
tags: ['C#','入门','原创','教程','新手']
---

namespace 是什么？  
 它能很有层次的管理全部代码的结构  
 你可以用namespace 将各种各样的 class 分类  
 让你很直观的了解每一个class 中method、properties 的功用  
  
 你：namespace 用在哪里的啊？  
 其实namespace 和 class 一直在你左右！  
 每当你创建一个新的 project 的时候：  

[![image](http://lh6.ggpht.com/-JWDPLy1KCmc/UpbWxcfeF5I/AAAAAAAAGgs/Io61Yln3QH0/image_thumb.png?imgmax=800 "image")](http://lh3.ggpht.com/-8Jb26Bw9geo/UpbWwr0C0AI/AAAAAAAAGgk/tnpvyOZZgRg/s1600-h/image2.png)  

> 最上方的using 就是引用特定的namespace

> 而namespace WindowsFormsApplication1  
>  就是创建一个namespace了！

你：哪里都可以创建很多个namespace？  

[![image](http://lh5.ggpht.com/-0ly6Gy24aTY/UpbWy00HfWI/AAAAAAAAGg8/sI4VCEVbjZA/image_thumb1.png?imgmax=800 "image")](http://lh6.ggpht.com/-FXWYMgQdsCM/UpbWyHF_p5I/AAAAAAAAGg0/zeycnak75yo/s1600-h/image5.png)  
 几乎哪里都可以  
 你可以在namespace 里面  
 也可以在外面  
  
 但是你不可以在class 内定义namespace  
  
 你：class 又在哪里？  

[![image](http://lh3.ggpht.com/-SV8JoTek1lk/UpbW0rzOBBI/AAAAAAAAGhM/IG5nBTl1_6I/image_thumb2.png?imgmax=800 "image")](http://lh5.ggpht.com/-F7Soy_Wq2Qk/UpbWzthEOBI/AAAAAAAAGhE/-WH7rq1wj7E/s1600-h/image8.png)  
  
 class 可以定义在一个namespace 里面  
 也可以嵌在另一个class 里面  

[![image](http://lh5.ggpht.com/-QpdWXMGeeJ4/UpbW2ON2zbI/AAAAAAAAGhc/KsyiJ1cxkDU/image_thumb3.png?imgmax=800 "image")](http://lh6.ggpht.com/-ZMVEJ4-rqTg/UpbW1bEiRMI/AAAAAAAAGhU/mGtX_TxCO1M/s1600-h/image11.png)  
  
 你：如何创建一个class？  
 你有两种方法：  

> 1、就是在同一个文件内  
>  然后有不同的class  
>  2、在不同的文件内  
>  有不同的class  
>  或namespace

方法2：  
 首先要添加一个新的文件：  
 先右击你的solution  
 然后选择Add  
 再选择New Item  

> 或者你可以直接按下Ctrl + Shift + A

[![image](http://lh4.ggpht.com/-WPfokDvdgmM/UpbW3sjfXMI/AAAAAAAAGhs/e9zgu9z0NbI/image_thumb4.png?imgmax=800 "image")](http://lh4.ggpht.com/-yjjKzu7tcOM/UpbW2-Oeg3I/AAAAAAAAGhk/k-JTN7K-5k8/s1600-h/image14.png)  
  
 选择class  
 然后为你的class 取个名字  

> 尽量取一个一看就知道这个class的功能的名字  
>
> > 千万不要放 Class1 Class2等等！

 [![image](http://lh6.ggpht.com/-4QI-bOxsUwE/UpbW5ptR4gI/AAAAAAAAGh8/9iRQATdAjSg/image_thumb5.png?imgmax=800 "image")](http://lh6.ggpht.com/-II3GswEVpZs/UpbW4heZDbI/AAAAAAAAGh0/KJ5fu-QoP0g/s1600-h/image17.png)  
 然后你就有一个自己的class了！  

[![image](http://lh4.ggpht.com/-sdgXU2NAl-I/UpbW7P7FTxI/AAAAAAAAGiM/fykNBiO9xyk/image_thumb6.png?imgmax=800 "image")](http://lh6.ggpht.com/-v5wo5InMhSE/UpbW6bliMpI/AAAAAAAAGiE/zZ0bDjGuhWo/s1600-h/image20.png)  

> 在这里，namespace 默认是跟整个project 的 namespace 一样的

你：如何使用一个namespace 里面的class  
 如果现在的namespace跟目标namespace 一样的话  
 就代表可以直接使用MyClass  
 直接输入MyClass：  

[![image](http://lh5.ggpht.com/-0SQeKYEUAic/UpbW8z_DxsI/AAAAAAAAGic/3bsw-iD0yl4/image_thumb7.png?imgmax=800 "image")](http://lh6.ggpht.com/-xkwxH7gXPNw/UpbW7yD8p6I/AAAAAAAAGiU/gUaYNv8Pu6A/s1600-h/image23.png)  
 你就可以直接使用MyClass里面的函数了！  
 如果namespace 不同的话：  

[![image](http://lh5.ggpht.com/-dPy5GwC2ZxU/UpbW-Pie_KI/AAAAAAAAGis/v61y4qYOcEk/image_thumb8.png?imgmax=800 "image")](http://lh4.ggpht.com/-RO8pa3iaE50/UpbW9VncPBI/AAAAAAAAGik/2tfEKbT4ccY/s1600-h/image26.png)  
 当你要用到MyClass 的时候：  

[![image](http://lh3.ggpht.com/-j80AUaghw74/UpbXAKfAz2I/AAAAAAAAGi8/ptRx8Qkn8Zc/image_thumb12.png?imgmax=800 "image")](http://lh6.ggpht.com/-AnAFkfX7j2A/UpbW_XTeQbI/AAAAAAAAGi0/yS1jP5_u95Y/s1600-h/image38.png)  
 你会发现到VS画了波浪线给你  

[![image](http://lh6.ggpht.com/-OgO6mbyFrrQ/UpbXBqNJ4PI/AAAAAAAAGjI/c_T1ddEUpZQ/image_thumb13.png?imgmax=800 "image")](http://lh3.ggpht.com/-XFyRCA6dFTA/UpbXAyAxGvI/AAAAAAAAGjE/oCnA8x9LgCg/s1600-h/image41.png)  
 这个时候就需要用到using 了  
 输入using 然后跟着 namespace 的名称：  

[![image](http://lh4.ggpht.com/-nNHxGXSzrjE/UpbXCwcKZBI/AAAAAAAAGjc/1akKXO3lBbA/image_thumb9.png?imgmax=800 "image")](http://lh5.ggpht.com/-rxMDl_TVxSw/UpbXCOaakKI/AAAAAAAAGjU/OeNeR70HvJQ/s1600-h/image29.png)  
 然后在加上一个;  

[![image](http://lh4.ggpht.com/-PaN0xKrkcEc/UpbXEJdV9XI/AAAAAAAAGjs/EkU9YvAR_JM/image_thumb10.png?imgmax=800 "image")](http://lh4.ggpht.com/-LWbx0uHCj9U/UpbXDQbgn1I/AAAAAAAAGjk/_zHgtYdK1sQ/s1600-h/image32.png)  
 就完成namespace 的引用了：  

[![image](http://lh5.ggpht.com/-QrkxMFGQxTw/UpbXFSlRKuI/AAAAAAAAGj4/b9K4r457mJU/image_thumb11.png?imgmax=800 "image")](http://lh3.ggpht.com/-M9XKW7VqqEY/UpbXE3ad6SI/AAAAAAAAGjw/iRycL6Z8g7U/s1600-h/image35.png)  
 你也可以直接用：  

> namespace.class的表示发来引用一个class

[![image](http://lh3.ggpht.com/-BuY9mxVxKgs/UpbXGnMKCAI/AAAAAAAAGkI/AdNYm_uFbyo/image_thumb14.png?imgmax=800 "image")](http://lh4.ggpht.com/-zdBNwk-HcLU/UpbXF77S6rI/AAAAAAAAGkE/42qpw5qDdhM/s1600-h/image44.png)  
  
 using 的用法还有一个  

> 就是为一个namespace 取一个别名

比如说你有一个名字很长很长的namespace：  

[![image](http://lh4.ggpht.com/-EKg3yWvVVSU/UpbXH5SysGI/AAAAAAAAGkc/MJpNuSPdfAU/image_thumb15.png?imgmax=800 "image")](http://lh5.ggpht.com/-CqsJeRoWUIQ/UpbXHAme-rI/AAAAAAAAGkU/3p86paJATyM/s1600-h/image47.png)  
 然后你可以这样：  

[![image](http://lh4.ggpht.com/-PjruqvLv4hw/UpbXJJ6NubI/AAAAAAAAGks/pZPMn5XRijg/image_thumb16.png?imgmax=800 "image")](http://lh4.ggpht.com/-EiS1PtAohl4/UpbXIqDzBuI/AAAAAAAAGkk/de35iypTfQo/s1600-h/image50.png)  
 格式很简单  

> using \<别名\> = \<namespace名\>;

然后就可以直接：  

[![image](http://lh3.ggpht.com/-3p_1QSxBUUw/UpbXKjj6cmI/AAAAAAAAGk8/PoyzPCuS5wk/image_thumb17.png?imgmax=800 "image")](http://lh5.ggpht.com/-GaqKO2v40T0/UpbXJxkfzUI/AAAAAAAAGk0/hBEvb-hg5kk/s1600-h/image53.png)  
  
 如果是嵌套的namespace的话：  

[![image](http://lh6.ggpht.com/-5LkMcY18XH4/UpbXMUXu8-I/AAAAAAAAGlI/PJMJZN-NjKo/image_thumb18.png?imgmax=800 "image")](http://lh6.ggpht.com/-uB4XP7v9cdY/UpbXLrTpN7I/AAAAAAAAGlE/94XppJGjeA4/s1600-h/image56.png)  
 using 的写法如下：  

[![image](http://lh6.ggpht.com/-DhCz67cjQME/UpbXNtiJDPI/AAAAAAAAGlc/RBQMJPWf9Xo/image_thumb19.png?imgmax=800 "image")](http://lh6.ggpht.com/-z00xR5JNpLc/UpbXM_m8cHI/AAAAAAAAGlU/D8seEMS3DHE/s1600-h/image59.png)  
 简单吧？  

> using \<namespace\>.\<sub namespace\>. …
