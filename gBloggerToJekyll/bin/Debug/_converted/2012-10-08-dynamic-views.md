---
layout: post
title: '[资源收集][教程] 部落格大翻新——Dynamic Views美化教程'
author: 'Gary Ng'
tags: ['Css','教程','资源收集']
---

各位有没有发现到本部落格换了个样子，改了个面貌啊？还不错吧？

自从Blogger 推出了新的“动态视图”（Dynamic
Views）过后，笔者鉴于他的简洁度而使用了动态视图的Sidebar模板。

[![image](http://lh6.ggpht.com/-SWv16eDn2XU/UHKvwJyn5aI/AAAAAAAACMc/xa7wgup4Z1M/image_thumb2.png?imgmax=800 "image")](http://lh3.ggpht.com/-4GBsgeIaJ1A/UHKvuy8ROUI/AAAAAAAACMU/h-KmAFJlLqI/s1600-h/image8.png)

  

但是，早期时的动态视图缺乏很多功能——比如不能使用“修改HTML”、“布局”、不能调整Sidebar大小，这一直困扰着笔者——要不要换回之前的模板呢？

直到最近，Blogger
才逐一加入并完善了这些功能，现在的动态视图也可以加入gadget了！

  

前几天，笔者找到了这个部落格——[Southern
Speakers](http://www.southernspeakers.net/)，大多数的部落格教程都是为旧版的blog写的（即非动态视图的部落格），然而[Southern
Speakers](http://www.southernspeakers.net/)
大量的教程都是以CSS代码为主，不必更改HTML
代码，所以非常适合使用动态视图的部落格，笔者在里面逛了一整天，找到了一些挺不错的教程，也将其CSS代码运用到了本部落格上～

  

## 【动态视图部落格美化】

一下的教程多数以CSS代码为主！

怎样添加自定义的CSS代码？（以新版本的Blogger管理界面为例子）

[![image](http://lh4.ggpht.com/-pzhed51544k/UHKvyK45iCI/AAAAAAAACOA/qZITKc1Jtmo/image29_thumb%25255B8%25255D.png?imgmax=800 "image")](http://lh3.ggpht.com/-JXcxyEF8VTc/UHKvxI1UVtI/AAAAAAAACN8/RNaJa5YQb6E/s1600-h/image29%25255B9%25255D.png)

逐一点击 模板——》在“博客现用图片”下的 自定义

 [![image](http://lh4.ggpht.com/-MEHBO0N2Ogg/UHKv0FbhKmI/AAAAAAAACOI/nEPo-56kVvc/image26_thumb.png?imgmax=800 "image")](http://lh6.ggpht.com/-6fKdhHXGbQU/UHKvzOJbeXI/AAAAAAAACOE/bqfrkZbU4Iw/s1600-h/image26%25255B1%25255D.png)

——》高级——》Add CSS 就可以啦！

  

**【开始！】**

  

1、有木有看到本部落Sidebar多了个漂亮的滚动条？

[![image](http://lh5.ggpht.com/-i3toIsc8Nnc/UHKv2IieZVI/AAAAAAAACOQ/O_AIqStlwDE/image35_thumb.png?imgmax=800 "image")](http://lh5.ggpht.com/-ejJ7sWAclRw/UHKv1Cs-uII/AAAAAAAACOM/8X2sEHHXdA8/s1600-h/image35%25255B1%25255D.png)

这个滚动条漂亮吧!

笔者参考了Southern Speakers的这篇教程—— [Scrollbar for Sidebar Posts in
Blogger Dynamic
Views](http://www.southernspeakers.net/2012/09/scrollbar-for-sidebar-posts-in-blogger.html)

在Add CSS 加入以下代码！

加入滚动条的代码如下：

  

  

``` prettyprint
.sidebar #sidebar, .ss{
margin-top: 12px !important;  /*12px就是滚动条距离headerbar 的距离，笔者的为0px，表示无距离*/
overflow-y: scroll !important;
}
```

  
  

更改滚动条样式的代码如下：  
  

``` prettyprint
::-webkit-scrollbar {
margin-right: 5px;
background-color: #EEE;
width: 7px; /*滚动条宽度，笔者的为10px*/
}
::-webkit-scrollbar:horizontal {
margin-right: 5px;
background-color: #EEE;
height: 7px;
}
::-webkit-scrollbar-thumb {
border: 1px #EEE solid;
border-radius: 12px;
background: #777;
-webit-box-shadow: 0 0 8px #555 inset;
box-shadow: 0 0 8px #555 inset;
-webit-transition: all .3s ease-out;
transition: all .3s ease-out;
}
::-webkit-scrollbar-track {
-webit-box-shadow: 0 0 2px #ccc;
box-shadow: 0 0 2px #ccc;
}
```

 

2、在部落格帖子下加入作者名字

[![image](http://lh5.ggpht.com/-zDTw0VJq6hI/UHLB-ZutSNI/AAAAAAAACOc/Os_OFwE740I/image_thumb.png?imgmax=800 "image")](http://lh3.ggpht.com/-MO1lkmYw_Tw/UHLB9QILtoI/AAAAAAAACOU/_zbVX2us8JY/s1600-h/image%25255B2%25255D.png)

参考了这篇文章—— [Adding Author Name Below Post Title in Blogger Dynamic
View](http://www.southernspeakers.net/2012/08/adding-author-name-below-post-title-in.html)

打开Add CSS，加入以下代码

  

  

``` prettyprint
.article .article-header h1.title:after, .ss{
content:"by XXX"; /*把XXX换成作者名字*/
display: block;
padding-top: 10px;
font-size: 14px !important;
color: grey !important;
}
```

  

3、在部落格帖子旁边显示Date Ribbon

其他的Dynamic Views 模板都有这个功能，但是只有Sidebar 没有。。

[![image](http://lh5.ggpht.com/-3ZN5nu2QyVU/UHLCA09X_ZI/AAAAAAAACOs/OpJoU_lGi8g/image_thumb%25255B1%25255D.png?imgmax=800 "image")](http://lh3.ggpht.com/-nT9PmF_NuaA/UHLB_oP68pI/AAAAAAAACOk/CB3WW15YUzA/s1600-h/image%25255B5%25255D.png)

参考了这篇文章——[Show Date Ribbon in Blogger Sidebar Dynamic
Views](http://www.southernspeakers.net/2012/07/show-date-ribbon-in-blogger-sidebar.html)

打开Add CSS 加入以下代码：  
  

``` prettyprint
.sidebar .article .article-header .date, .ss {
display: block !important;
}
```

  

  

  

4、更改Loading Icon

  

默认的Loading Icon 是这样的：

  

[![index](http://lh5.ggpht.com/-7pd0HHd3p70/UHLCDSfR7bI/AAAAAAAACO8/lkC_rtAITNs/index_thumb.gif?imgmax=800 "index")](http://lh5.ggpht.com/-EOvxiCf62Yg/UHLCBz2fpHI/AAAAAAAACOw/7-29PoxL1WM/s1600-h/index%25255B2%25255D.gif)

  

 笔者改成了：

[![](http://bit.ly/uwj9kf)](http://bit.ly/uwj9kf)

  

  

这里的源码—— [Remove Loading Gear from Blogger Dynamic
View](http://www.southernspeakers.net/2011/12/remove-loading-gear-from-blogger.html)，原本的代码是去掉Blogger
的Loading gear：

``` prettyprint
.ss,.blogger-gear{
display: none;
}
```

  

  

笔者照着这个源码改成了更改Loading Gear的代码：

``` prettyprint
.ss,.blogger-gear{
background-image: url('XXX); /*把XXX 换成自定义的载入动画
}
```

  

 

5、把Pages定位到header bar 中间

  

[![image](http://lh6.ggpht.com/-F2DSKBxM8y4/UHLCFbDigeI/AAAAAAAACPM/q95j6YDqT-I/image_thumb%25255B3%25255D.png?imgmax=800 "image")](http://lh3.ggpht.com/-bOOoRBBeoOs/UHLCEFXsN4I/AAAAAAAACPE/Y5jqhvzd8cU/s1600-h/image%25255B11%25255D.png)

  

 

参考了这篇文章——[Centering Header Links in Blogger Dynamic
Views](http://www.southernspeakers.net/2012/03/centering-header-links-in-blogger.html)

  

在Add CSS中添加以下代码：  

``` prettyprint
.tabs{
width: 80% !important;
text-align: center !important;
}
```

  

6、更改Blogger的“Add A Comment”

  

[![image](http://lh6.ggpht.com/-phZ7q40YYek/UHLCHr6tosI/AAAAAAAACPc/h5om3DtLzaY/image_thumb%25255B4%25255D.png?imgmax=800 "image")](http://lh6.ggpht.com/-rLViT-kPSOk/UHLCGl7FIcI/AAAAAAAACPU/jwz71JcBSGo/s1600-h/image%25255B14%25255D.png)

  

  

  

参考了这篇文章—— [Change “Add a Comment”in Blogger Dynamic
Views](http://www.southernspeakers.net/2012/05/change-add-comment-in-blogger-dynamic.html)

  

在Add CSS 中添加以下代码：

  

``` prettyprint
.comments-header h3{
font-size: 0px;
}
.comments-header h3:before{
content: "Drop some words!"; /*把Drop Some Words! 换成想要显示的提示信息，比如笔者的是Give Some Comments!*/
font-size: 14px;
}
```
