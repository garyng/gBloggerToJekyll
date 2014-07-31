---
layout: post
title: '[教程][Git] 以Git Subtree 代替 Git Submodule'
author: 'Gary Ng'
tags: ['Git','原创','教程']
---

# 【何时用Submodule？】

比如说你有一个Git repo （repository ，下同）叫做web-project  
 然后你的web-project 需要用到另一个git repo 叫做 web-plugin  
 git 的 submodule 就能管理你的 子-repo ，也就是在 web-project 内clone
web-plugin ，然后你能管理、维护，就像操作普通git repo一样  
  
 可是git submodule 有点..  
 反正就是不太被大众欢迎，原因有很多.. （Google 下就有了）  
  
 然后就有了 git subtree  
  

> 注：本文章需要先了解Git

# 【使用Git Subtree】

很简单  
 现在有一个local repo ，名叫 subtreetest  
 有一个文件叫做 readme.md  
 和一个commit history  

[![image](http://lh5.ggpht.com/-nnG2u0Yx3Hs/Un3u91SItoI/AAAAAAAAFZA/u1cHiwZCqAI/image_thumb.png?imgmax=800 "image")](http://lh4.ggpht.com/-kMQ_swmldYA/Un3u9EemtnI/AAAAAAAAFY4/o959LWEVvqA/s1600-h/image%25255B2%25255D.png)  
  
 还有另一个repo  
 叫做 testing  
 （我把它push 到github 上了 - <https://github.com/garyng/testing>）  

[![image](http://lh6.ggpht.com/-DfOnYZbjR_0/Un3u_cpzrPI/AAAAAAAAFZQ/e35Ft8Lhn6M/image_thumb%25255B1%25255D.png?imgmax=800 "image")](http://lh5.ggpht.com/-WHNp23xnQK0/Un3u-jBJD3I/AAAAAAAAFZI/bznmpOMepKI/s1600-h/image%25255B5%25255D.png)  
  

## 【添加子repo】

现在我要在我的subtreetest 的 repo 内引用 testing 这个repo  
 运行  
 git subtree add --prefix=testing
<https://github.com/garyng/testing.git> master –squash  
 会看到这个：  

[![image](http://lh3.ggpht.com/-ySvaomsG9D8/Un3vAr6nVmI/AAAAAAAAFZg/3qhxRiU5BaM/image_thumb%25255B2%25255D.png?imgmax=800 "image")](http://lh6.ggpht.com/-kLrpjz_1h60/Un3u_-0NOeI/AAAAAAAAFZY/dB1aAnlxpWQ/s1600-h/image%25255B8%25255D.png)  
  
 其中的  

> --prefix 就是子目录的名称  
>  --squash 代表将子repo的所有commit都挤成一个commit

现在subtreetest这个repo的目录已经变成了：  

[![image](http://lh3.ggpht.com/-GCfjBfvE-tE/Un3vB1kmFXI/AAAAAAAAFZw/zN2CCyBNq20/image_thumb%25255B3%25255D.png?imgmax=800 "image")](http://lh3.ggpht.com/-pBr6IC6CKA8/Un3vBLfFEtI/AAAAAAAAFZo/i7oGHjycouE/s1600-h/image%25255B11%25255D.png)  
 testing 目录下：  

[![image](http://lh5.ggpht.com/-Ea9ROVQPYrg/Un3vDKeTsMI/AAAAAAAAFZ8/st5RJLTQcvA/image_thumb%25255B4%25255D.png?imgmax=800 "image")](http://lh5.ggpht.com/-WlkJWts6w5o/Un3vCWtyy7I/AAAAAAAAFZ4/chqPZ1TDG0k/s1600-h/image%25255B14%25255D.png)  
  

## 【pull下子repo的更新】

到testing 这个repo 做几个edits  
 然后在push  

[![image](http://lh3.ggpht.com/-SzzY6TjGCp4/Un3vEdsgaLI/AAAAAAAAFaQ/prbjiPxOsi0/image_thumb%25255B5%25255D.png?imgmax=800 "image")](http://lh5.ggpht.com/-aTnERCqQYLw/Un3vD4A4IiI/AAAAAAAAFaI/lSiwJlF12WY/s1600-h/image%25255B17%25255D.png)  
  
 现在 testing 已经更新了  
 如果到subtreetest 跟新它的子repo (testing)，像这样：  
 git subtree pull --prefix=testing
<https://github.com/garyng/testing.git> master --squash  

[![image](http://lh5.ggpht.com/-LouAChkFe84/Un3vF8SkoDI/AAAAAAAAFag/SPnu2WVMGPY/image_thumb%25255B6%25255D.png?imgmax=800 "image")](http://lh3.ggpht.com/-AX-queSFZig/Un3vFEV9LbI/AAAAAAAAFaY/LYJSkVvLWUI/s1600-h/image%25255B20%25255D.png)  
  
 然后commit history 就变成了  

[![image](http://lh3.ggpht.com/-H0ZkUEFCJJE/Un3vHBsN69I/AAAAAAAAFaw/LqDLtOz_2xY/image_thumb%25255B8%25255D.png?imgmax=800 "image")](http://lh6.ggpht.com/-TTmUsO3sZnQ/Un3vGlIWpsI/AAAAAAAAFao/QLMewNmclgw/s1600-h/image%25255B26%25255D.png)  
  

## 【用remote name 减少命令输入量】

有没有发现到需要输入的命令都很长？  
 现在将testing 的 pull/push URL 加入remote：  
 git remote add testing <https://github.com/garyng/testing.git>  

[![image](http://lh3.ggpht.com/-SExgYA5lP0o/Un3vIao8ilI/AAAAAAAAFbA/-ivSdGAzfms/image_thumb%25255B10%25255D.png?imgmax=800 "image")](http://lh5.ggpht.com/-jad45B3fdNA/Un3vH1xcQEI/AAAAAAAAFa4/mSq1Frh9Zt0/s1600-h/image%25255B32%25255D.png)  
  
 加入subtree 的命令就成了：  
 git subtree add --prefix=testing testing master --squash  

[![image](http://lh4.ggpht.com/-uUi521RdoGM/Un3vJ-Mr_HI/AAAAAAAAFbQ/xDdiOGzf_po/image_thumb%25255B11%25255D.png?imgmax=800 "image")](http://lh6.ggpht.com/-E0twcC_PEm8/Un3vJcDfs4I/AAAAAAAAFbI/S70AFkh63_A/s1600-h/image%25255B35%25255D.png)  
  
 subtree pull 变成：  
 git subtree pull --prefix=testing testing master --squash  

[![image](http://lh6.ggpht.com/-4tUtK5NPxQk/Un3vLWBnbmI/AAAAAAAAFbg/h-gkOTWbaYc/image_thumb%25255B12%25255D.png?imgmax=800 "image")](http://lh4.ggpht.com/-aXa1rAeH4VI/Un3vKpqU2hI/AAAAAAAAFbY/b11EV6Zfy3k/s1600-h/image%25255B38%25255D.png)  
  

## 【在subtreetest下更新testing，再push上】

现在subtreetest 下更新 testing 目录下的文件  

[![image](http://lh6.ggpht.com/-KzWMicWxySY/Un3vM9NJojI/AAAAAAAAFbw/XhKE9etVRh4/image_thumb%25255B9%25255D.png?imgmax=800 "image")](http://lh6.ggpht.com/-Et7Rj9XvG6c/Un3vMNcw6II/AAAAAAAAFbo/hTId0CKkZQ4/s1600-h/image%25255B29%25255D.png)  
  
 要push 回去的话：  
 git subtree push --prefix=testing testing master  

[![image](http://lh5.ggpht.com/-eGJrnA_z0XM/Un3vOIcfKVI/AAAAAAAAFcA/7AfCzEYuXSk/image_thumb%25255B13%25255D.png?imgmax=800 "image")](http://lh5.ggpht.com/-c-z7dzpH-LI/Un3vNQoucLI/AAAAAAAAFb4/B-HdztaegFY/s1600-h/image%25255B41%25255D.png)  
 回到testing 下  
 git pull  
 就能看到更新了！  

[![image](http://lh5.ggpht.com/-1tscRr3x1sM/Un3vmI4XHpI/AAAAAAAAFcc/Zo2UgxLpMb8/image_thumb%25255B14%25255D.png?imgmax=800 "image")](http://lh5.ggpht.com/-BA9sA7XqUYE/Un3vlkClSbI/AAAAAAAAFcI/dmtDE1S_Vas/s1600-h/image%25255B44%25255D.png)  
  
 好了！  

