---
layout: post
title: '[教程][C#][算法] 迷宫生成算法入门——Recursive Backtracker + 实现'
author: 'Gary Ng'
tags: ['C#','Maze','原创','教程','算法','迷宫']
---

之前在这篇（[[教程][C\#][算法]
A\*寻路算法入门——详解+实现](http://garyngzhongbo.blogspot.com/2013/11/c.html)）说到了“迷宫”  
 于是心血来潮，做了点研究，找到了几个不错的迷宫生成算法。  
  
 这篇文章不需要任何特定基础  
 你甚至可以用纸和笔直接手动生成迷宫！  
 （但是你要知道什么叫做堆栈）  
  

# 【Recursive Backtracker】

基本步骤：  

> 1、随便选一个格子  
>
> 2、在该格子的相邻4个格子中，找出4面墙壁都完好的格子，随便选一个，然后将现在的格子与相邻的格子之间的墙壁打通，将选中的相邻入栈，已访问的格子数量+1；如果在相邻的4个格子之中都找不到4面墙壁都完好的格子，出栈，然后将其设置为下一轮的选中格子  
>  3、继续一直到没有格子可选择（就是已经访问的格子等于总格子）

听得云里雾里吧？  
  

## 【例子】

假设我们有一个3\*3的正方格：  

[![image](http://lh3.ggpht.com/-BYNMtl6C7FE/Un89GemWQ-I/AAAAAAAAFc8/rpmpljYv3HY/image_thumb.png?imgmax=800 "image")](http://lh3.ggpht.com/-G0E2L71jskQ/Un89FzjEN1I/AAAAAAAAFc0/eb55D-xioY4/s1600-h/image%25255B2%25255D.png)  
 现在随便选一个格子（紫色）：  

[![image](http://lh3.ggpht.com/-Qmosa0YxQWg/Un89Hnj9mtI/AAAAAAAAFdM/ShqiN2YUvCY/image_thumb%25255B1%25255D.png?imgmax=800 "image")](http://lh4.ggpht.com/-uAksGC5lLZI/Un89HB9gPOI/AAAAAAAAFdE/WsXC5sxfJSg/s1600-h/image%25255B5%25255D.png)  
 然后找出相邻的格子（4面墙都完好的）（蓝色）：  

[![image](http://lh3.ggpht.com/-54woDsDrXLg/Un89IuXdRpI/AAAAAAAAFdc/ezSsURvrxcc/image_thumb%25255B2%25255D.png?imgmax=800 "image")](http://lh3.ggpht.com/-UJ3t5uiGNsg/Un89IM6T8rI/AAAAAAAAFdQ/ksSTYQ0skG0/s1600-h/image%25255B8%25255D.png)  
 在他们之中随便选一个（绿色）  
 将其推入堆栈  
 （这里我用号码来表示格子在堆栈内的位置  
 0为最尾端，也就是最底层）  
 将其设置为下一轮选中的格子  

[![image](http://lh3.ggpht.com/-fzj_Hd6tvdU/Un89J4_ka2I/AAAAAAAAFds/09mpAnynz9Y/image_thumb%25255B6%25255D.png?imgmax=800 "image")](http://lh4.ggpht.com/-x4RvpbPrtLU/Un89JO3g_8I/AAAAAAAAFdk/psTg1mnt8Lg/s1600-h/image%25255B20%25255D.png)  
 打通他们之间的墙，两个格子相连（紫色）：  

[![image](http://lh3.ggpht.com/-XJ_JR18Jucc/Un89K98kQ9I/AAAAAAAAFd8/06Z7QWifb38/image_thumb%25255B8%25255D.png?imgmax=800 "image")](http://lh6.ggpht.com/-kKHHpUuYQBM/Un89KdzFcZI/AAAAAAAAFd0/HSPFpMIYaOA/s1600-h/image%25255B26%25255D.png)  
 下一轮  
 找出4面墙都完好的格子  
 （刚开始的紫色框框(2,1)，已经西面的墙已经倒下，所以不选）  

[![image](http://lh6.ggpht.com/-Yw8zSacZQwo/Un89MHbyMDI/AAAAAAAAFeM/fUfIRWTafnE/image_thumb%25255B11%25255D.png?imgmax=800 "image")](http://lh5.ggpht.com/-Du7JTA96SWk/Un89LVD41yI/AAAAAAAAFeE/3Gg4aVSwUVM/s1600-h/image%25255B35%25255D.png)  
 随便选一个格子：  

[![image](http://lh4.ggpht.com/-SzFmQkSWWYo/Un89NUNz37I/AAAAAAAAFeY/E0ypSbkksOk/image_thumb%25255B13%25255D.png?imgmax=800 "image")](http://lh4.ggpht.com/-7N_IFRh-OIk/Un89Mycl-SI/AAAAAAAAFeU/SyD5PhkXSGg/s1600-h/image%25255B41%25255D.png)  
 打通墙壁：  

[![image](http://lh3.ggpht.com/-1NYSMk8CV9w/Un89OcPS1KI/AAAAAAAAFes/1cfVmLXT3BU/image_thumb%25255B14%25255D.png?imgmax=800 "image")](http://lh4.ggpht.com/-wfWMNlDuLdo/Un89N5R9XlI/AAAAAAAAFeg/NkHi-3PX_Zo/s1600-h/image%25255B44%25255D.png)  
 下一轮：  

[![image](http://lh3.ggpht.com/-BCRJCr8xNr4/Un89PqTZl9I/AAAAAAAAFe8/32bqgGZdNaU/image_thumb%25255B15%25255D.png?imgmax=800 "image")](http://lh3.ggpht.com/-eBb35h_jVJs/Un89PDCX_QI/AAAAAAAAFe0/fDuRJFcP40Q/s1600-h/image%25255B47%25255D.png)  

[![image](http://lh3.ggpht.com/-j9pGnEuuhZM/Un89Q_LoqjI/AAAAAAAAFfM/9_613FpOHcQ/image_thumb%25255B16%25255D.png?imgmax=800 "image")](http://lh5.ggpht.com/-AS84YA6DWkQ/Un89QAQVCqI/AAAAAAAAFfE/ohWeFlBMr-c/s1600-h/image%25255B50%25255D.png)  

[![image](http://lh5.ggpht.com/-agsjTdTzH98/Un89R23S3cI/AAAAAAAAFfc/wBU0nGgvg2M/image_thumb%25255B17%25255D.png?imgmax=800 "image")](http://lh4.ggpht.com/-eCz0IZvtY_s/Un89RfSfo0I/AAAAAAAAFfQ/68BZqslz8F0/s1600-h/image%25255B53%25255D.png)  
 下一轮的时候  
 你会发现到(2,0)的邻居都没有完好的4面墙了  
 所以我们把弹出堆栈，也就是(2,0) （用红色表示）  
 将其设为下一轮的选中格子  

[![image](http://lh5.ggpht.com/-8gVapJTBWCM/Un89TF6lI8I/AAAAAAAAFfs/PIi8c3eHTx4/image_thumb%25255B18%25255D.png?imgmax=800 "image")](http://lh5.ggpht.com/-VRDjxZ7_F9I/Un89SqOTYyI/AAAAAAAAFfk/qnQby8bs3Ng/s1600-h/image%25255B56%25255D.png)  
 下一轮  

[![image](http://lh5.ggpht.com/-FZ4arntuaSk/Un89UQyUwcI/AAAAAAAAFf4/FMlUeYjVgt8/image_thumb%25255B19%25255D.png?imgmax=800 "image")](http://lh5.ggpht.com/-GtxHCLiFrJ0/Un89T1GWdEI/AAAAAAAAFf0/v75OJ-cDYG0/s1600-h/image%25255B59%25255D.png)  

[![image](http://lh5.ggpht.com/-9EyWn7NlOaw/Un89WHVRdkI/AAAAAAAAFgM/ZSmWLioi0Jk/image_thumb%25255B20%25255D.png?imgmax=800 "image")](http://lh3.ggpht.com/-qlscC8HxtCU/Un89VKWzISI/AAAAAAAAFgE/TGo5D5ortfI/s1600-h/image%25255B62%25255D.png)  

[![image](http://lh6.ggpht.com/-GnBLs0-2coU/Un89XDMqSJI/AAAAAAAAFgc/r5nRNdRoWE0/image_thumb%25255B21%25255D.png?imgmax=800 "image")](http://lh4.ggpht.com/--pTpoOueuKY/Un89WssGK-I/AAAAAAAAFgU/DCzVvPOVsM8/s1600-h/image%25255B65%25255D.png)  
 下一轮：  

[![image](http://lh5.ggpht.com/-iIT5iEg469k/Un89YBPhWKI/AAAAAAAAFgs/8n66UmBtG6g/image_thumb%25255B22%25255D.png?imgmax=800 "image")](http://lh3.ggpht.com/-5OQcg2EXk60/Un89XmOtsQI/AAAAAAAAFgk/jHdTzG6zjuo/s1600-h/image%25255B68%25255D.png)  

[![image](http://lh5.ggpht.com/-IVWPxT9EkzY/Un89ZeuITmI/AAAAAAAAFg8/qCNA832fpeE/image_thumb%25255B23%25255D.png?imgmax=800 "image")](http://lh5.ggpht.com/-NnB0mkDP3cM/Un89Y_jqi0I/AAAAAAAAFg0/Eg5BmoQG8bg/s1600-h/image%25255B71%25255D.png)  

[![image](http://lh3.ggpht.com/-qwIF4zRsnlQ/Un89at09BFI/AAAAAAAAFhM/8vCj_cR5xwQ/image_thumb%25255B24%25255D.png?imgmax=800 "image")](http://lh5.ggpht.com/-DelgWibkhVE/Un89Z-rKKrI/AAAAAAAAFhE/Ivpxlzsa2zE/s1600-h/image%25255B74%25255D.png)  
 下一轮  

[![image](http://lh5.ggpht.com/-cvxbPSbeOvg/Un89bsvDZJI/AAAAAAAAFhc/jRyvOZEdLbc/image_thumb%25255B25%25255D.png?imgmax=800 "image")](http://lh4.ggpht.com/-xBfifekVjOM/Un89bNqEg0I/AAAAAAAAFhU/-WvVapqFwCI/s1600-h/image%25255B77%25255D.png)  

[![image](http://lh3.ggpht.com/-uE3ubsI-zNM/Un89czzMRvI/AAAAAAAAFhs/CiV1L71ymzE/image_thumb%25255B26%25255D.png?imgmax=800 "image")](http://lh6.ggpht.com/-3_uSyfS4ra8/Un89cXSZ9zI/AAAAAAAAFhk/zHKaMDPi4Ao/s1600-h/image%25255B80%25255D.png)  

[![image](http://lh3.ggpht.com/--Up0-pB3n-A/Un89eVICzyI/AAAAAAAAFh8/-t2uZhwGEOE/image_thumb%25255B27%25255D.png?imgmax=800 "image")](http://lh6.ggpht.com/-oZKR9viZNLQ/Un89dgUkN5I/AAAAAAAAFh0/KJBjy2PwiYw/s1600-h/image%25255B83%25255D.png)  
 下一轮  

[![image](http://lh6.ggpht.com/-fiHcmf1WbD4/Un89gEkG9GI/AAAAAAAAFiM/wIscemYEedQ/image_thumb%25255B28%25255D.png?imgmax=800 "image")](http://lh4.ggpht.com/-0HmgN7AhUJg/Un89fVnfOhI/AAAAAAAAFiE/v5nVT3h56p4/s1600-h/image%25255B86%25255D.png)  

[![image](http://lh4.ggpht.com/-RsQ-1XPKv-s/Un89h17lVoI/AAAAAAAAFic/DyFV11gfPQw/image_thumb%25255B29%25255D.png?imgmax=800 "image")](http://lh5.ggpht.com/-we8tvOMIoWU/Un89hPB1uqI/AAAAAAAAFiU/3Y5g0X5_5A0/s1600-h/image%25255B89%25255D.png)  

[![image](http://lh3.ggpht.com/-2AagTcVula8/Un89jC4z4kI/AAAAAAAAFis/30Dz0cu4FZA/image_thumb%25255B30%25255D.png?imgmax=800 "image")](http://lh5.ggpht.com/-lOYJFfPzRuI/Un89icnIGGI/AAAAAAAAFik/veeGUQ9qmF0/s1600-h/image%25255B92%25255D.png)  
 下一轮  

[![image](http://lh3.ggpht.com/-jjVg_KJWy2M/Un89kV5i4-I/AAAAAAAAFi8/BtYz-TI95HQ/image_thumb%25255B31%25255D.png?imgmax=800 "image")](http://lh5.ggpht.com/-3myi0yi9WBs/Un89j12enTI/AAAAAAAAFi0/QcT2qafI5a0/s1600-h/image%25255B95%25255D.png)  

[![image](http://lh4.ggpht.com/-dUGNrw-Tq1w/Un89mM6k3GI/AAAAAAAAFjM/peNcWbstJpA/image_thumb%25255B32%25255D.png?imgmax=800 "image")](http://lh5.ggpht.com/-HiuXxslPm9E/Un89lMq19LI/AAAAAAAAFjE/hjhz9Foy75c/s1600-h/image%25255B98%25255D.png)  

[![image](http://lh5.ggpht.com/-m89JOWW6NMo/Un89nDXd0sI/AAAAAAAAFjc/eHidSB4hUGk/image_thumb%25255B33%25255D.png?imgmax=800 "image")](http://lh3.ggpht.com/-iDNLA09-v_Q/Un89miqpWAI/AAAAAAAAFjU/dVGi_1-EJCk/s1600-h/image%25255B101%25255D.png)  
 到这里我们已经有一个很不错的迷宫了：  
 起点为黄色  

[![image](http://lh4.ggpht.com/-F2lmBPbk2Ps/Un89oT9zd0I/AAAAAAAAFjs/OvqRTBtPh0A/image_thumb%25255B34%25255D.png?imgmax=800 "image")](http://lh3.ggpht.com/-izSYkoQaDjc/Un89n2i0Q2I/AAAAAAAAFjk/Vdfh8GSI1dc/s1600-h/image%25255B104%25255D.png)  

# 【C\#实现】

全部代码已经push 到GitHub 上：

<https://github.com/garyng/Maze>

每一个格子为一个class，名为Node

```
using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;

namespace MazeGen
{
    public class Node
    {
        private bool _isFrontier;
        private List<ParentInfo> _parentInfo = new List<ParentInfo>();
        private bool _isBacktracked;

        private bool _isStart;
        private Point _pos;
        private const int _count = 4;
        private Node _down;
        private Node _up;
        private Node _right;
        private Node _left;

        /// <summary>
        /// Status of the four wall
        /// 0 = still there
        /// 1 = destroyed
        ///  ____________________
        /// |Left|Down|Right| Up |
        /// |_8__|_4__|__2__|_0__|
        /// </summary>
        private int _wall = 0;

        /// <summary>
        /// Mark the wall as destroyed
        /// </summary>
        /// <param name="index">Up = 0 Left = 1 Down = 2 Right = 3</param>
        public void UnWall(int index)
        {
            _wall |= 1 << index;
        }

        /// <summary>
        /// Get a wall's status
        /// </summary>
        /// <param name="index"></param>
        /// <returns>True = Wall destroyed </returns>
        public bool GetWall(int index)
        {
            return (_wall & (1 << index)) == (1 << index);
        }

        /// <summary>
        /// Mark the wall as not destroyed
        /// </summary>
        /// <param name="index"></param>
        public void SetWall(int index)
        {
            _wall &= ~(1 << index);
        }

        public Node this[int index]
        {
            get
            {
                return SwitchNodeProp(index);
            }
            set
            {
                SwitchNodeProp(index, value);
            }
        }

        private Node SwitchNodeProp(int index, Node value = null)
        {
            switch (index)
            {
                case 0:
                    return ReturnNodeProp(ref _up, value);
                case 1:
                    return ReturnNodeProp(ref _right, value);
                case 2:
                    return ReturnNodeProp(ref _down, value);
                case 3:
                    return ReturnNodeProp(ref _left, value);
            }

            return null;
        }
        private Node ReturnNodeProp(ref Node prop, Node value = null)
        {
            if (value == null)
            {
                return prop;
            }
            else
            {
                prop = value;
                return null;
            }
        }

        public Node Left
        {
            get
            {
                return _left;
            }
            set
            {
                _left = value;
            }
        }
        public Node Right
        {
            get
            {
                return _right;
            }
            set
            {
                _right = value;
            }
        }
        public Node Up
        {
            get
            {
                return _up;
            }
            set
            {
                _up = value;
            }
        }
        public Node Down
        {
            get
            {
                return _down;
            }
            set
            {
                _down = value;
            }
        }
        public int Count
        {
            get
            {
                return _count;
            }
        }
        public int Wall
        {
            get
            {
                return _wall;
            }
            set
            {
                _wall = value;
            }
        }
        public bool isStart
        {
            get
            {
                return _isStart;
            }
            set
            {
                _isStart = value;
            }
        }
        public Point Pos
        {
            get
            {
                return _pos;
            }
            set
            {
                _pos = value;
            }
        }

        /// <summary>
        /// For recursive backtracking and Growing Tree
        /// </summary>
        public bool isBacktracked
        {
            get
            {
                return _isBacktracked;
            }
            set
            {
                _isBacktracked = value;
            }
        }

        /// <summary>
        /// For Prim's algorithm
        /// A list of parents
        /// </summary>
        public List<ParentInfo> parentInfo
        {
            get
            {
                return _parentInfo;
            }
            set
            {
                _parentInfo = value;
            }
        }

        /// <summary>
        /// For Prim's AQlgorithm
        /// Mark a node as frontier
        /// </summary>
        public bool isFrontier
        {
            get
            {
                return _isFrontier;
            }
            set
            {
                _isFrontier = value;
            }
        }
    }
}
```

  
  

每一面墙壁的状态储存在一个Int内

  

4个bits 组成的：

  

0为墙壁还在

  

1为墙壁已摧毁

  

[![image](http://lh3.ggpht.com/-e9kjUj8YMlY/Un89p8vknrI/AAAAAAAAFj8/0waILjaPW3Q/image_thumb%25255B35%25255D.png?imgmax=800 "image")](http://lh5.ggpht.com/-CzM4W3Okjmw/Un89pAIJWkI/AAAAAAAAFj0/Pq67RhC0hJg/s1600-h/image%25255B107%25255D.png)

  

  

  
  
  
  
 迷宫生成的base class 是这样的：  

```
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace MazeGen
{
    public abstract class Maze
    {
        public delegate void ProgressChangedEventHandler(int done, int total);
        public delegate void DoneEventHandler();
        public event ProgressChangedEventHandler ProgressChanged;
        public event DoneEventHandler Completed;

        private int _selIndex = 0;
        private List<List<Node>> _nodes = new List<List<Node>>();

        public Maze(List<List<Node>> nodes)
        {
            _nodes = nodes;
        }

        /// <summary>
        /// Initialize a new 2d array of nodes
        /// </summary>
        /// <param name="width"></param>
        /// <param name="height"></param>
        public Maze(int width, int height)
        {
            for (int x = 0; x < width; x++)
            {
                List<Node> nX = new List<Node>();
                for (int y = 0; y < height; y++)
                {
                    Node nY = new Node();
                    nY.Pos = new Point(x, y);
                    if (y > 0)
                    {
                        nY.Up = nX[y - 1];
                        nX[y - 1].Down = nY;
                    }
                    if (x > 0)
                    {
                        nY.Left = _nodes[x - 1][y];
                        _nodes[x - 1][y].Right = nY;
                    }
                    nX.Add(nY);
                }
                _nodes.Add(nX);
            }
        }

        /// <summary>
        /// Visualize nodes
        /// </summary>
        /// <param name="sz">The size of a node</param>
        /// <returns></returns>
        public Bitmap Visualize(Size sz)
        {
            Bitmap b = new Bitmap(_nodes.Count * sz.Width + 1, _nodes[0].Count * sz.Height + 1);
            using (Graphics g = Graphics.FromImage(b))
            {
                for (int x = 0; x < _nodes.Count; x++)
                {
                    for (int y = 0; y < _nodes[x].Count; y++)
                    {
                        if (!_nodes[x][y].GetWall(0))
                        {
                            //Up
                            g.DrawLine(Pens.Black, sz.Height * x, sz.Width * y, sz.Height * (x + 1), sz.Width * y);
                        }
                        if (!_nodes[x][y].GetWall(3))
                        {
                            //Left
                            g.DrawLine(Pens.Black, sz.Height * x, sz.Width * y, sz.Height * x, sz.Width * (y + 1));
                        }
                        if (!_nodes[x][y].GetWall(1))
                        {
                            //Right
                            g.DrawLine(Pens.Black, sz.Height * (x + 1), sz.Width * y, sz.Height * (x + 1), sz.Width * (y + 1));
                        }
                        if (!_nodes[x][y].GetWall(2))
                        {
                            //Down
                            g.DrawLine(Pens.Black, sz.Height * x, sz.Width * (y + 1), sz.Height * (x + 1), sz.Width * (y + 1));
                        }
                        if (_nodes[x][y].isBacktracked)
                        {
                            g.FillRectangle(new SolidBrush(Color.FromArgb(100, Color.Pink)), sz.Height * x, sz.Width * y, sz.Width, sz.Height);
                        }
                        if (_nodes[x][y].isFrontier)
                        {
                            g.FillRectangle(new SolidBrush(Color.FromArgb(100, Color.Purple)), sz.Height * x, sz.Width * y, sz.Width, sz.Height);
                        }
                        if (_nodes[x][y].isStart)
                        {
                            g.FillRectangle(new SolidBrush(Color.FromArgb(100, Color.Blue)), sz.Height * x, sz.Width * y, sz.Width, sz.Height);
                        }
                    }

                }
            };
            return b;
        }

        protected virtual void OnProgressChanged(int done, int total)
        {
            if (ProgressChanged != null)
            {
                ProgressChanged(done, total);
            }
        }

        protected virtual void OnComplete()
        {
            if (Completed != null)
            {
                Completed();
            }
        }

        /// <summary>
        /// Generate a new maze
        /// </summary>
        public virtual void Generate()
        {
        }

        /// <summary>
        /// Get the 2d list of nodes
        /// </summary>
        public List<List<Node>> Nodes
        {
            get
            {
                return _nodes;
            }
        }

        public virtual string Name
        {
            get
            {
                return "";
            }
        }

        /// <summary>
        /// For Growing Tree Algorithm
        /// </summary>
        public int SelectionMethod
        {
            get
            {
                return _selIndex;
            }
            set
            {
                _selIndex = value;
            }
        }
    }
}
```

  
  
 Visualize 负责将整个迷宫画出来  
  
 这个是Recursive Backtracker 的实现核心（在Generate 函数内）  

```
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace MazeGen
{
    /// <summary>
    /// Recursive Backtracking - Maze Generation
    /// </summary>
    public class MazeRec : Maze
    {
        public MazeRec(List<List<Node>> nodes)
            : base(nodes)
        {
        }

        /// <summary>
        /// Initialize a new 2d array of nodes
        /// </summary>
        /// <param name="width"></param>
        /// <param name="height"></param>
        public MazeRec(int width, int height)
            : base(width, height)
        {
        }

        public override void Generate()
        {
            int visitedCount = 1;
            int total = this.Nodes.Count * this.Nodes[0].Count;
            Stack<Node> visitedCell = new Stack<Node>();

            Random r = new Random();
            //Node current = this.Nodes[r.Next(this.Nodes.Count-1)][r.Next(this.Nodes[0].Count-1)];
            Node current = this.Nodes[(int)(r.NextDouble() * this.Nodes.Count * 10) % this.Nodes.Count][(int)(r.NextDouble() * this.Nodes[0].Count * 10) % this.Nodes.Count];
            current.isStart = true;

            //Node end = this.End.X == -1 ? this.Nodes[(int)(r.NextDouble() * this.Nodes.Count * 10) % this.Nodes.Count][(int)(r.NextDouble() * this.Nodes[0].Count * 10) % this.Nodes.Count] : this.Nodes[this.End.X][this.End.Y];
            //end.isEnd = true;

            while (visitedCount < total)
            {
                //List all available neighbour cells
                List<Node> readyNeighbourCells = new List<Node>();
                //Store the index of the neighbour cells
                List<int> readyNeighbourCellsIndex = new List<int>();
                for (int i = 0; i < current.Count; i++)
                {
                    if (current[i] != null && current[i].Wall == 0)
                    {
                        readyNeighbourCells.Add(current[i]);
                        readyNeighbourCellsIndex.Add(i);
                    }

                }
                //no cells found
                if (readyNeighbourCells.Count == 0)
                {
                    current = visitedCell.Pop();
                    current.isBacktracked = true;
                    OnProgressChanged(visitedCount, total);
                    continue;
                }

                //Random select a cell
                int randIndex = (int)(r.NextDouble() * 10) % readyNeighbourCells.Count;
                int index = readyNeighbourCellsIndex[randIndex];
                Node neighbour = readyNeighbourCells[randIndex];

                // Knock the wall
                // 0-2 1-3
                current.UnWall(index);
                neighbour.UnWall((index + 2) % 4);
                visitedCell.Push(neighbour);
                current = neighbour;
                visitedCount++;

                OnProgressChanged(visitedCount, total);
            }

            //Backtrack to start point
            while (visitedCell.Count>0)
            {
                 current = visitedCell.Pop();
                 current.isBacktracked = true;
                 OnProgressChanged(visitedCount, total);
            }

            OnComplete();
        }

        public override string Name
        {
            get
            {
                return "Recursive Backtracker";
            }
        }
    }
}
```

  
  

## 【截图】

  
 无图无真相  
  
 （会animate 整个迷宫生成的过程）  
  

[![image](http://lh6.ggpht.com/-aTRFLf_gvzk/Un89rb1RLOI/AAAAAAAAFkM/GiAhTFrqeO4/image_thumb%25255B36%25255D.png?imgmax=800 "image")](http://lh4.ggpht.com/-RE1dFUK8d84/Un89q_Zp0jI/AAAAAAAAFkE/R0HRF-SlbP8/s1600-h/image%25255B110%25255D.png)  
  

[![image](http://lh3.ggpht.com/-KkJefprtklI/Un89s5VIfQI/AAAAAAAAFkc/biShjideSq4/image_thumb%25255B38%25255D.png?imgmax=800 "image")](http://lh4.ggpht.com/-djlVq0jxOK0/Un89sAZ8rcI/AAAAAAAAFkU/FXVC46ojAXA/s1600-h/image%25255B116%25255D.png)  
  

[![image](http://lh4.ggpht.com/-DzpQtyET_bU/Un89uVtDSjI/AAAAAAAAFks/oBm_gS4A94g/image_thumb%25255B39%25255D.png?imgmax=800 "image")](http://lh4.ggpht.com/-LaMMX4WVfS8/Un89tsz6xiI/AAAAAAAAFkk/AG9fS-fi098/s1600-h/image%25255B119%25255D.png)  
  

[![image](http://lh6.ggpht.com/-iXbYHmRlXo0/Un89v0wjeXI/AAAAAAAAFk8/2Htq7nb8bjo/image_thumb%25255B40%25255D.png?imgmax=800 "image")](http://lh3.ggpht.com/-soQ6zwngLJ8/Un89vJY_1ZI/AAAAAAAAFk0/Wl5NTid3igQ/s1600-h/image%25255B122%25255D.png)  
  
  
  
  
  
 右击迷宫能保存  
  

[![image](http://lh5.ggpht.com/-RU9Vbia6YTo/Un89xUVoFVI/AAAAAAAAFlM/eIJGQkkQqB8/image_thumb%25255B41%25255D.png?imgmax=800 "image")](http://lh3.ggpht.com/-YR-7V5ebj2c/Un89wrFBPSI/AAAAAAAAFlE/tzDUuYkjaeI/s1600-h/image%25255B125%25255D.png)  
  
  
  
 好啦就这样！

