---
layout: post
title: '[教程][C#] Dynamic Views Blogger 安装使用SyntaxHighlighter + 其HTML Code Generator'
author: 'Gary Ng'
tags: ['C#','原创','教程']
---

折腾了那么久，发现之前发过的[【教程】【VS插件】Visual Studio Copy Code
As
HTML](http://garyngzhongbo.blogspot.com/2013/05/vsvisual-studio-copy-code-as-html.html)
又不能用了，于是花了整个下午来研究研究。  
 刚开始我突然想到了Google Code Prettify
(<http://code.google.com/p/google-code-prettify/>)，但是Blogger Dynamic
Views(动态视图)咋搞都装不上，过后在StackOverflow看到了一片文章，里面提到了SyntaxHighlighter
(<http://alexgorbatchev.com/SyntaxHighlighter/>)，之前试过了，还是不能…  

但是我灰常喜欢SyntaxHighlighter的高亮着色，又花了我N小时，终于找到了适合Blogger
动态视图的代码：  
 首先先到Blogger 管理面板 \>  模板 \> 点击 修改HTML
（以前不能修改，现在能了）  

[![image](http://lh6.ggpht.com/-9stKwoauYzw/UgJWwpm1KBI/AAAAAAAADqQ/lRZ-Ng7GfN0/image_thumb%25255B2%25255D.png?imgmax=800 "image")](http://lh6.ggpht.com/-2mWMLtbl5IE/UgJWv1NAzGI/AAAAAAAADqI/0hrJaBh50P4/s1600-h/image%25255B4%25255D.png)  
  
 然后在\<head\> 之后的空白部分加入以下代码：  

```
<link href='http://alexgorbatchev.com/pub/sh/2.1.364/styles/shCore.css' rel='stylesheet' type='text/css'/> 
<link href='http://alexgorbatchev.com/pub/sh/2.1.364/styles/shThemeDefault.css' rel='stylesheet' type='text/css'/> 
<script src='http://alexgorbatchev.com/pub/sh/2.1.364/scripts/shCore.js' type='text/javascript'></script> 
<script src='http://alexgorbatchev.com/pub/sh/2.1.364/scripts/shBrushCpp.js' type='text/javascript'></script> 
<script src='http://alexgorbatchev.com/pub/sh/2.1.364/scripts/shBrushCSharp.js' type='text/javascript'></script> 
<script src='http://alexgorbatchev.com/pub/sh/2.1.364/scripts/shBrushCss.js' type='text/javascript'></script> 
<script src='http://alexgorbatchev.com/pub/sh/2.1.364/scripts/shBrushJava.js' type='text/javascript'></script> 
<script src='http://alexgorbatchev.com/pub/sh/2.1.364/scripts/shBrushJScript.js' type='text/javascript'></script> 
<script src='http://alexgorbatchev.com/pub/sh/2.1.364/scripts/shBrushPhp.js' type='text/javascript'></script> 
<script src='http://alexgorbatchev.com/pub/sh/2.1.364/scripts/shBrushPython.js' type='text/javascript'></script> 
<script src='http://alexgorbatchev.com/pub/sh/2.1.364/scripts/shBrushRuby.js' type='text/javascript'></script> 
<script src='http://alexgorbatchev.com/pub/sh/2.1.364/scripts/shBrushSql.js' type='text/javascript'></script> 
<script src='http://alexgorbatchev.com/pub/sh/2.1.364/scripts/shBrushVb.js' type='text/javascript'></script> 
<script src='http://alexgorbatchev.com/pub/sh/2.1.364/scripts/shBrushXml.js' type='text/javascript'></script> 
<script src='http://alexgorbatchev.com/pub/sh/2.1.364/scripts/shBrushPerl.js' type='text/javascript'></script> 
<script language='javascript'> 
SyntaxHighlighter.config.bloggerMode = true;
SyntaxHighlighter.config.clipboardSwf = 'http://alexgorbatchev.com/pub/sh/2.1.364/scripts/clipboard.swf';
SyntaxHighlighter.all();
</script>
```

  

  
  
    
 当然你可以去除一些没有用到的css  
  

[![image](http://lh5.ggpht.com/-zk5xR0dBnf4/UgJWyZkBkGI/AAAAAAAADqg/evaMy6bxXS0/image_thumb%25255B3%25255D.png?imgmax=800 "image")](http://lh4.ggpht.com/-l4A2ZCnm5A4/UgJWxmlzljI/AAAAAAAADqY/Xf4QLuuVobk/s1600-h/image%25255B7%25255D.png)  
  
  
  
 然后点击保存模板！  
  
  
  
 如果你要贴代码，在Blogger 的帖子编辑器哪儿，选择HTML  
  
 先把代码HTML Encode 先（这边）  
  
 贴以下代码：  
  

```
<pre class="brush: 这边是语言">
YOUR CODE HERE << 这边放代码
</pre>
```

  
  

语言种类看这边：<http://alexgorbatchev.com/SyntaxHighlighter/manual/brushes/>  
  
 当然如果你用的是Blogger动态模板的话，你还要加入这个：  
  
  

```
<script type="text/javascript">
SyntaxHighlighter.highlight();
</script>
```

  
  
  
  
 就可以了！  
  
 另外，如果你懒惰一直找代码来贴的话，你可以下载我写的C\# 程序：  
  

[![image](http://lh5.ggpht.com/-PEQeh8QJHw4/UgJdL4unNbI/AAAAAAAADq4/Lk6EI7XRfdc/image_thumb%25255B5%25255D.png?imgmax=800 "image")](http://lh3.ggpht.com/-cf2Vwv8eqyc/UgJdLRe3mnI/AAAAAAAADqw/tUtJhqz-sPg/s1600-h/image%25255B13%25255D.png)  
  
  
  
 **\*需要.net 2.0 才能运行\***  
  
  
  
 这边是源代码（VS2010
C\#）：[Dropbox](https://dl.dropboxusercontent.com/u/43619472/%E6%89%B9%E5%A4%84%E7%90%86/C%23/SyntaxHighlighter/SyntaxHighlighter.zip)  
[MEGA](https://mega.co.nz/#!HMQhgA6B!Zymk43i0UuNMDzUMb0n2TigQwQEaNUfwGyZaeQZscGk)  
[Mediafire](http://www.mediafire.com/download/gth9g20k0k11lnu/SyntaxHighlighter.zip)  
  

这里是exe：[Dropbox](https://dl.dropboxusercontent.com/u/43619472/%E6%89%B9%E5%A4%84%E7%90%86/C%23/SyntaxHighlighter/SyntaxHighlighter.exe) 
[MEGA](https://mega.co.nz/#!jBgTURbR!UngJgUPkzb_DSiCDhgtWQG3AWAoYv8hm6v_wUNitLew) 
[MediaFire](http://www.mediafire.com/download/9ighhuqeg5u764i/SyntaxHighlighter.exe)

