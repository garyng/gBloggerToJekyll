---
layout: post
title: '[教程][C#] 新手入门教程#17——Try..Catch..Finally'
author: 'Gary Ng'
tags: ['C#','入门','原创','教程','新手']
---

如果在玩数组的时候  
 你很鸡冻/不小心的输入：  

[![image](http://lh6.ggpht.com/-h3JYDUOGo28/Uo72ANDrczI/AAAAAAAAGPY/4Ny5C6Yd_wA/image_thumb.png?imgmax=800 "image")](http://lh6.ggpht.com/-PyKs7ICmdRY/Uo71_Yi2ysI/AAAAAAAAGPQ/0Yw1P0vKIgI/s1600-h/image%25255B2%25255D.png)  
 然后运行点击按钮时：  

[![image](http://lh6.ggpht.com/-cdbCZgNaZcU/Uo72BjH51sI/AAAAAAAAGPo/9sR8_Nb-tIc/image_thumb%25255B1%25255D.png?imgmax=800 "image")](http://lh4.ggpht.com/-0rXShI8UPbI/Uo72A2z68QI/AAAAAAAAGPg/Ehr-5gRfDPY/s1600-h/image%25255B5%25255D.png)  
  
 VS 罢工了！  

[![image](http://lh6.ggpht.com/-La06guqOpC4/Uo72DFC7lRI/AAAAAAAAGP0/TA533iz6PVM/image_thumb%25255B2%25255D.png?imgmax=800 "image")](http://lh3.ggpht.com/-oZF5S4lAHhc/Uo72CRDbx1I/AAAAAAAAGPw/RFj3-pbWzEc/s1600-h/image%25255B8%25255D.png)  
 为什么？  
 因为  

> 数组str没有index 为 2 的元素！

  
 你：我不要这东西！我不要！我不要！  
 那你该如何检查这些错误  
 然后handle 他们  
 防止整个程序挂掉呢？  
 用 try .. catch .. 结构！  

[![image](http://lh5.ggpht.com/-QncuD7xT_hc/Uo72ET65JLI/AAAAAAAAGQI/Gc2xRSMnYCM/image_thumb%25255B5%25255D.png?imgmax=800 "image")](http://lh4.ggpht.com/-skbQgf_no6A/Uo72Dvu_9nI/AAAAAAAAGQA/ttREVmJV1S8/s1600-h/image%25255B17%25255D.png)  

> try  
>  首先它会运行Code body1  
>  如果没有出错  
>  就跳过 catch 中的 code body 2  
>  如果出错的话  
>  他就会运行 code body 2

来看看例子：  

[![image](http://lh4.ggpht.com/-7XT0pF1vIh0/Uo72Ft3_7iI/AAAAAAAAGQY/biO77JgtACI/image_thumb%25255B6%25255D.png?imgmax=800 "image")](http://lh5.ggpht.com/-TQTVRwI9DZg/Uo72FPne3kI/AAAAAAAAGQM/JKE4OPMnEeI/s1600-h/image%25255B20%25255D.png)  
 如果try 中的代码出错的话  
 就会有messagebox 跳出来说：  

> 你挂了！

[![image](http://lh6.ggpht.com/-zWm8-GdBI8I/Uo72HPlTEII/AAAAAAAAGQo/kNCgbJGBHlg/image_thumb%25255B8%25255D.png?imgmax=800 "image")](http://lh3.ggpht.com/-7aL45iVHbd0/Uo72GaGPbYI/AAAAAAAAGQg/8loW78cNgqY/s1600-h/image%25255B26%25255D.png)  
 但是如果没有任何错误的话：  

> str[2] 变成 str[0] 了

[![image](http://lh4.ggpht.com/-7LRFBZfNe4Y/Uo72IZJA46I/AAAAAAAAGQ0/mXz51E28GVs/image_thumb%25255B9%25255D.png?imgmax=800 "image")](http://lh3.ggpht.com/-WQtlIaAFo40/Uo72Hm9qMKI/AAAAAAAAGQw/mlgpgZNvmac/s1600-h/image%25255B29%25255D.png)  
 运行的话  
 当然没有任何msgbox了  

[![image](http://lh4.ggpht.com/-1kDsVs1_kX4/Uo72J-ky5HI/AAAAAAAAGRI/LqD7P9sfckA/image_thumb%25255B10%25255D.png?imgmax=800 "image")](http://lh5.ggpht.com/-oNb07nX7HX0/Uo72I9WzlYI/AAAAAAAAGRA/yCoTB1IJjlc/s1600-h/image%25255B32%25255D.png)  
  
 你：可是我能让Messagebox显示什么有什么错误么？  
 我：能！  
 只要在catch 加上：  

[![image](http://lh4.ggpht.com/-OK3WPBcO1aE/Uo72LNkxf7I/AAAAAAAAGRU/fv3nCGpZydA/image_thumb%25255B13%25255D.png?imgmax=800 "image")](http://lh6.ggpht.com/-POTcYUjJSA0/Uo72KujNNrI/AAAAAAAAGRQ/ufRxLqNjm4s/s1600-h/image%25255B41%25255D.png)  

> (Exception ex)  
>  就是当有错误出现时  
>  将有关错误的信息存入变量ex 内

如果你要显示有什么错误的话：  

[![image](http://lh6.ggpht.com/-WVU1arCiT_I/Uo72MdY6hfI/AAAAAAAAGRo/VE9qkjkbV8s/image_thumb%25255B14%25255D.png?imgmax=800 "image")](http://lh4.ggpht.com/-ZRdFn6IWA2k/Uo72LmkLhiI/AAAAAAAAGRg/11tRrPxr9Nw/s1600-h/image%25255B44%25255D.png)  
 运行看看：  

[![image](http://lh4.ggpht.com/-GsDr0rcT348/Uo72N9eS_kI/AAAAAAAAGR4/LTPPYirz6kE/image_thumb%25255B15%25255D.png?imgmax=800 "image")](http://lh5.ggpht.com/-udFSOr6fuNc/Uo72M9Qn3SI/AAAAAAAAGRw/bnphh1BgIow/s1600-h/image%25255B47%25255D.png)  
 最后的  
 还有一个finally：  

[![image](http://lh5.ggpht.com/-pOBHGGEFJo4/Uo72PF0SO_I/AAAAAAAAGSI/Wq8pkAmy0ys/image_thumb%25255B17%25255D.png?imgmax=800 "image")](http://lh6.ggpht.com/-cL2zI3_-mzM/Uo72Ogshz9I/AAAAAAAAGR8/AdWfx4Vb9vQ/s1600-h/image%25255B53%25255D.png)  

> Code body3  
>  不管有没有任何错误  
>  Code body 3 都会被执行

像这个有错误的代码：  

[![image](http://lh3.ggpht.com/-xmRKMBe9dBU/Uo72QZ0r4KI/AAAAAAAAGSY/cdw7eUPVKZs/image_thumb%25255B18%25255D.png?imgmax=800 "image")](http://lh6.ggpht.com/-LzI0wt0mOEw/Uo72P_WMWHI/AAAAAAAAGSQ/HY2VJuDItzo/s1600-h/image%25255B56%25255D.png)  
 运行点击button  
 就会出现两个messagebox  
 第一个是Exception 的信息  

[![image](http://lh6.ggpht.com/-WUM6jYiCtx0/Uo72R68AJvI/AAAAAAAAGSo/291Mc0xdE20/image_thumb%25255B19%25255D.png?imgmax=800 "image")](http://lh5.ggpht.com/-jEJ7VyQfyV8/Uo72RKM-1_I/AAAAAAAAGSg/JMxU46dDS_c/s1600-h/image%25255B59%25255D.png)  
 第二个就是finally 中的 messagebo  

[![image](http://lh5.ggpht.com/-X0sMglfdqu4/Uo72TAD6XYI/AAAAAAAAGS4/hQIXK1ZyfsU/image_thumb%25255B20%25255D.png?imgmax=800 "image")](http://lh6.ggpht.com/-zi1knnBTpRk/Uo72Sj0tT6I/AAAAAAAAGSw/1ZFCtfSwqx0/s1600-h/image%25255B62%25255D.png)  
  
 但是如果try 中的代码没有错误的话：  

[![image](http://lh6.ggpht.com/-0G2DeOj2N_4/Uo72Utyl4lI/AAAAAAAAGTI/lOcX1y8bdc0/image_thumb%25255B21%25255D.png?imgmax=800 "image")](http://lh3.ggpht.com/-MX-6NeHBnWU/Uo72T8JdUrI/AAAAAAAAGTA/Dy-6DqrPfqM/s1600-h/image%25255B65%25255D.png)  
 finally 之中的代码还是一样会被执行：  

[![image](http://lh4.ggpht.com/-iipALVVbAFQ/Uo72WCfVFFI/AAAAAAAAGTY/WC6G4msY5fQ/image_thumb%25255B22%25255D.png?imgmax=800 "image")](http://lh3.ggpht.com/-O4IQvs2xOrk/Uo72VfWDDxI/AAAAAAAAGTQ/eCZDDeumZQQ/s1600-h/image%25255B68%25255D.png)

