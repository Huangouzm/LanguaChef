# 零、开发资源与调研内容

## 0.1 学习网站

[PICO Unity 开发指南](https://developer-cn.pico-interactive.com/document/unity/)

[中文教学视频 讲Unity3D和各种编程语言](https://www.afanihao.cn/game) 

[英文教学视频 Unity教学](https://unity.com/learn#explore-how-you-can-develop-your-skills)

相关技术手册、资源
https://store.unity.com/academic/unity-student
http://c.biancheng.net/unity3d/
https://docs.unity3d.com/Manual/index.html

[Unity 网站上的VR学习视频](https://learn.unity.com/course/create-with-vr)

## 0.2 资源网站

[**Unity的资源商店**](https://assetstore.unity.com/)

[3D模型库](https://www.cgmodel.com/model/)

[微元素-CG资源创作平台](https://www.element3ds.com/)

[模型转换为 FBX](http://www.3dwhere.com/conv/all2fbx)

## 0.3 案例

这个是另一个仿照code monkey的做的工程文件，但是有所修改。同理你可能也可以在GitHub找一些现成的VR project

https://www.tiktok.com/@kitchenchaosrblx/video/7241329821748350250

https://www.roblox.com/games/1065834266/Kitchen-Chaos

https://github.com/HyagoOliveira/KitchenChaos



**3DoF的烹饪游戏《cook-out》：**

体验视频：[VR烹饪游戏《Cook-Out: A Sandwich Tale》](https://www.bilibili.com/video/BV1Gk4y1y7rD/?spm_id_from=333.337.search-card.all.click&vd_source=29d074918f3e47ac0fcc0ed2c870d98f)

宣传片：[《cook-out》VR版分手厨房](https://www.bilibili.com/video/BV1NX4y1N7BC/?spm_id_from=333.337.search-card.all.click&vd_source=29d074918f3e47ac0fcc0ed2c870d98f)

超级多食材可以分关卡

**6DoF的烹饪游戏《Cooking Simulator VR》：**

体验视频：[别在VR里研究分手厨房啊！！！](https://www.bilibili.com/video/BV1V8411e7ir/?spm_id_from=333.788&vd_source=29d074918f3e47ac0fcc0ed2c870d98f)

超级多食材可以直接解决

[【VR开发教程2022】Unity Quest2 二：OpenXR手部教程](https://www.bilibili.com/video/BV1TF411G7w6/?spm_id_from=333.788&vd_source=29d074918f3e47ac0fcc0ed2c870d98f)

[我是如何在没有头盔的情况下进行Unity VR项目开发和测试的](https://www.bilibili.com/video/BV1bN4y1G7tA/?spm_id_from=333.337.search-card.all.click&vd_source=29d074918f3e47ac0fcc0ed2c870d98f)

## 0.4 设备

### 0.4.1 Meta Quest2

[Unity关于Oculus Quest2 入门开发：注意事项](https://blog.csdn.net/weixin_43750989/article/details/115228765)

财力支持：扎克伯格

安卓开发

CPU：高通XR2（多核多线程）（协程：比线程更轻量级的执行单位，可以创建多个协程来实现并发的逻辑，而不需要使用多线程的复杂性和开销。优势在于可以减少并发编程中的一些复杂性问题，如锁、线程同步等）

GPU：集成在CPU里了，但是有其他解决渲染问题的方法

一体机 & 串流：

+ 一体机：下载到设备里，无需网络就能进行游玩**（不联外网的多人版）**
+ **串流：类似于投屏，有线串流和无线串流。**(受试者视角)

### 0.4.2 PICO4

财力支持：字节跳动

安卓开发

国内现在在努力地打造PICO或者说是VR的生态环境，但是雀食还有一定差距。体现在生态上的距离就是，国内的生态中缺少大作，PICO也引入了很多Quest上的游戏和作品（甚至有些还是同期发布的）

在色彩透视上，PICO4只有一个彩色摄像头（没有立体视，会有一种很虚幻的感觉）。从MR的角度来讲，效果很差；从Quest 20年-23年的变化来看，PICO4做安全区识别、安全区透视，已经算得上是天花板了。

从串流来看，PICO的有线串流和无线串流差不多，但是Quest的有线串流吊打PICO的串流。当然，串流的延迟和画质还取决于电脑的显卡等因素，这里讨论的是电脑显卡拉满的情况（4090）。所以当电脑显卡跟不那么上，比如30系列，可能还是以一个轻便快捷为主。在无线串流上，PICO也是可以用VD的（Virtual Desktop）。但是如果有线串流一定要考虑延迟和画质的综合，就不如Quest了。

从生态上来讲，PICO一直主打一个视频生态，所以在一些VR直播、VR演唱会之类的视频中，还是比较能打的。在游戏生态上，虽然大作不如Quest多，同时也缺乏优质的第一方工作室，但是进入2023年以后，游戏的制作速度急剧上升，有很多游戏的效果也挺不错的。在23年5月的时候，PICO商店有392款游戏，Quest商店有466款游戏。在社交生态上，PICO推出的轻世界其实可以对标Quest的Horizon World。鉴于国内的用户应该接触不到Horizon World，就算接触到了可能也会有一个比较高的延迟，所以能够感受到轻世界应该是近半年来PICO整得比较好的一个活。

从这个生态来讲，就能反映出这次PICO开发者太赛的用心之一。

![image-20231002125824343](C:\Users\50432\AppData\Roaming\Typora\typora-user-images\image-20231002125824343.png)

![image-20231002125846432](C:\Users\50432\AppData\Roaming\Typora\typora-user-images\image-20231002125846432.png)

### 0.4.3 HTC vive pro eye

传感器：SteamV 追踪、重力传感器、陀螺仪、接近度、瞳距传感器、眼动追踪

---

**眼动追踪规格**

注视数据输出频率（双目）：120Hz

校准：5点

数据输出（眼睛信息）：

> 时间戳（设备和系统）
>
> 凝视原点
>
> 凝视方向
>
> 瞳孔位置
>
> 瞳孔大小
>
> 睁眼度

接口：HTC SRanipal SDK

---

**控制器规格**

传感器：SteamVR 追踪2.0

输入：多功能触控板、手柄按钮、双级触发器、系统按钮、菜单按钮

---

**最低计算机规格**

![image-20231123234250182](C:\Users\50432\AppData\Roaming\Typora\typora-user-images\image-20231123234250182.png)

视频输出：DisplayPort 1.2或更高版本

## 0.5 注意事项

1. UI分辨率和画质：尽量使用粗体
2. 考虑使用剧情型的UI：传统的项目中，UI元素通常是在显示器的顶部 包括：生命值‘得分的等，用户界面与游戏界面没有关联，但是对游戏玩家有一定的影响。这就是“非剧情型UI”但是这种UI界面对VR基本不适用，因为我们的眼镜无法聚焦在太近的物体上，因此我们需要考虑使用剧情型UI，具体形式可能是墙上的闹钟、电视、计算机屏幕等或者全息展示
3. 考虑UI元素的放置位置：将UI元素放在什么位置，让用户更容易观察，太靠近用户会导致眼部疲劳，离得太远会感觉聚焦在地平线上，这里需要考虑UI元素的比例大小：一般采用2的N倍大小，例如512 1024 2048；
4. 避免移动摄像机，因为在VR中移动 用户本身没有移动，这就会造成用户眩晕，我们可以为用户提供一个固定参考物，例如：驾驶室 ；一般传送位置 使用Teleport（瞬移）传送；
5. 因为对于VR游戏来说，需要在90-120fps的帧速率现实画面才流畅，如果优化不给力，很有可能在5分钟内用户就会产生眩晕感。time.deltatime * speed
6. 《头号玩家》：要么追踪，要么传感器。

# 一、环境搭建

## 1.1 PICO开发“快速开始”

Unity版本：2022.2.1f1（国际版）

PICO开发“快速开始”文档：[快速开始 | PICO 开发者平台 (pico-interactive.com)](https://developer-cn.pico-interactive.com/document/unity/create-a-developer-account-organization-and-app/)

分为以下步骤：

1. 创建开发者账号、组织和应用

   开发者管理平台-应用界面：[Developer Platform (pico-interactive.com)](https://developer-cn.pico-interactive.com/console/#/app/overview/7270398343254425619/7274113741543981092)

2. 配置开发环境

3. 导入SDK

   [PICO Unity Integration SDK](https://developer-cn.pico-interactive.com/resources/#sdk)

   版本：v2.3.0

   PICO官方文档：

   + Unity的SDK支持的最低Unity编辑版本为2020.3.21，支持的最高Unity编辑器版本为2022.2.14。但是使用下来发现，2022.3也行。
   + 若想使用Unity2022开发PICO应用，请确保使用的SDK为2.1.5或更高版本，且PICO设备系统版本为5.5.0或更高版本。

4. 完成项目配置

5. XR场景创建

6. 打包运行

7. 应用分发

## 1.2 预览场景并调试

参考文档：[实时预览应用场景 | PICO 开发者平台 (pico-interactive.com)](https://developer-cn.pico-interactive.com/document/unity/preview-app-scenes/)

## 1.3 GitHub

虽然但是，弄好了已经。https://github.com/Huangouzm/LanguaChef.git

特别讲一下里面的分支：

> main：用于合并已经稳定运行的版本
>
> > develop：用于合并当前正在开发的版本
> >
> > > hzmother：用于个人开发

## 1.4 HTC vive pro eye 开发手册

HTC vive unity 开发手册：[Overview: OpenXR for Unity - Developer Resources (vive.com)](https://developer.vive.com/resources/openxr/unity/overview/?_login=true)

## 1.5 XR 相关的包

XR Interaction Toolkit：2.3.2

XR Plugin Management：4.4.0

两个版本都不是**稳定适配**unity2022.2.1f1的版本，但是管他的先用再说。

# 二、Unity VR开发学习

参考链接：[【UnityVR开发系列】](https://www.bilibili.com/video/BV1TX4y1H7kV/?spm_id_from=333.999.0.0&vd_source=29d074918f3e47ac0fcc0ed2c870d98f)

![image-20230928161325594](C:\Users\50432\AppData\Roaming\Typora\typora-user-images\image-20230928161325594.png)

Unity 3D 和 Unity VR 的最大区别就在**事件和交互**

## 2.1 VR Locomotion - VR中实现运动的各种方式

参考链接：[VRLocomotion-VR中实现运动的各种方式](https://www.bilibili.com/video/BV1ak4y137W5/?spm_id_from=pageDriver&vd_source=29d074918f3e47ac0fcc0ed2c870d98f)

![image-20230929135815245](C:\Users\50432\AppData\Roaming\Typora\typora-user-images\image-20230929135815245.png)

注意：红色的文本，很容易引起“晕动症”。手臂摆动是介于连续移动和瞬移之间的一种移动方式，但是还是可能会产生晕动症。

一种很好的解决晕动症的方式就是使用体感设备：

+ 传感器套件：通过记录人体的关节关键点，来简易捕捉动作。例如，手腕、脚踝、腰部（人体重心）等。举例：这样就可以把手臂摆动转换为抬腿移动，就会减轻晕动的症状。
+ 鞋：鞋子底部有万向轮，可以部分抵消人体的移动，使人在原地但是能达到移动的效果。
+ 跑步机：实现任意移动。

### 2.1.1 VR Locomotion - 两种转向

参考链接：[VRLocomotion两种转向](https://www.bilibili.com/video/BV1Dx4y1X7uH/?spm_id_from=pageDriver&vd_source=29d074918f3e47ac0fcc0ed2c870d98f)

自从Unity发布了XR Interaction Toolkit和XR SDK后，所有硬件厂商都按照这个标准来进行配置开发。所以只需要在Unity里面实现自身的XR组件，就可以很方便地发布到不同地VR硬件上。

所以我们会考虑到三种不同情况：无设备的模拟器、PICO设备和Quest设备。在实际开发过程中根据需要进行选择就好。

**开发过程：**

创建新的Locomotion Scene，搭建一个简单的场景，从Unity Assets Store上找一些资源来让场景变得更好看。

![image-20230930220038455](C:\Users\50432\AppData\Roaming\Typora\typora-user-images\image-20230930220038455.png)

在XR Origin的Tracking Origin Mode中选择Floor（站着玩）。如果选择Device的话，坐着玩。实际上是6DoF和3DoF的区别。

![image-20230930220205284](C:\Users\50432\AppData\Roaming\Typora\typora-user-images\image-20230930220205284.png)

为两个Controller设置输入配置

![image-20230930220253088](C:\Users\50432\AppData\Roaming\Typora\typora-user-images\image-20230930220253088.png)

接下来添加Locomotion System以及两个不同的转向系统

Locomotion的添加位置可以根据不同的思路有不同的添加方案。通常是添加在XR Origin下面，但是这里为了突出VRLocomotion的一些特点，所以单独把他拿出来。

在很多开发项目中，通常把VRLocomotion放在了VR Origin下面，但是当前的学习路线发现，如果把Locomotion拿出来单独放置，也是完全ok的。

![image-20230930220332869](C:\Users\50432\AppData\Roaming\Typora\typora-user-images\image-20230930220332869.png)

接下来就是配置三种不同的方案：

1. 模拟器

   因为模拟器自带了转向操作，所以做不做上面的操作都可以正常转向。如果需要使用模拟器的话，需要将XR Interaction Toolkit更新到一定版本以上。这里讲怎么更新。

   ---

   **怎么更新包？**

   ![image-20231002153555129](C:\Users\50432\AppData\Roaming\Typora\typora-user-images\image-20231002153555129.png)

   在window -> package manger -> add package by name下，将对应的包名放入。输入版本号，如果不写的话默认添加最新版本。

   **为什么这里不能想其他的包一样，出现更新箭头点更新就好呢？**

   因为 Unity 有不同的编辑器，他这里给出来的包的版本是和当前使用的编辑器能够稳定适配的版本。如果有更新，他给你的更新的版本也是能够稳定适配的版本。就比如下图是一个2022.3的编辑器，所以这里的稳定版本是2.3.2，而我在开发过程中用到的是2022.2.1f1，它给出的版本就是2.1.1。也就是说，当你想用更新版本的package时，得通过上面的这种方式进行更新。

   ![image-20231002160043753](C:\Users\50432\AppData\Roaming\Typora\typora-user-images\image-20231002160043753.png)

   使用更新版本的包可以体验到更新的功能，就比如2.1.1是不能使用模拟器的，而2.3.2就可以。但是对于一个大型的、有稳定性要求的项目来说，肯定最好是使用稳定版本。在开发过程中，适当的使用更新版本也没有什么问题，因为可以随时回退。

   ---

   ![image-20230929151208590](C:\Users\50432\AppData\Roaming\Typora\typora-user-images\image-20230929151208590.png)

   ![image-20231002153933566](C:\Users\50432\AppData\Roaming\Typora\typora-user-images\image-20231002153933566.png)

   这时，就可以实现用模拟器进行模拟的操作了。（但是此时的效果基本正常，除了控制器本身的移动不跟鼠标。考虑到这不是重点，所以暂时也就不管了）

   在使用其他模拟方式的时候，需要进入edit -> project settings -> XR Plug-in Management -> XR Interaction Toolkit中，将Use XR Device Simulator in scenes取消勾选，才可以使用

2. Quest2

![image-20230929194413787](C:\Users\50432\AppData\Roaming\Typora\typora-user-images\image-20230929194413787.png)

因为turn provider只允许一个，所以当需要使用其他方法的时候，需要将当前方法先禁用掉

+ turn amount：一次旋转的角度
+ debounce time：去抖时间，开始下一次转向时中间需要间隔的时间
+ enable turn left right：向左转向右转
+ enable turn around：是否允许180°的急转（一般不要这样）
+ delay time：延迟

3. Pico

   ![image-20230929200000212](C:\Users\50432\AppData\Roaming\Typora\typora-user-images\image-20230929200000212.png)

Pico的预览在使用过程中会有抖动，这是因为插件本身还不够成熟的原因。当打包到设备中单独运行的时候，就不会有这个问题了。

**如何调整视角高度？**

调整XR Origin下的Transform

![image-20231001144112485](C:\Users\50432\AppData\Roaming\Typora\typora-user-images\image-20231001144112485.png)

### 2.1.2 VRLocomotion - 连续移动&角色控制

参考链接：[VRLocomotion连续移动&角色控制](https://www.bilibili.com/video/BV1Jm4y1H7KU/?spm_id_from=pageDriver&vd_source=29d074918f3e47ac0fcc0ed2c870d98f)

首先是让左手控制器可以实现基础的移动

![image-20230930135932987](C:\Users\50432\AppData\Roaming\Typora\typora-user-images\image-20230930135932987.png)

Snap Turn Provider 和 Continuous Move Provider 里的 Left/Right Hand Move Action 里的Reference都选![image-20231002154740313](C:\Users\50432\AppData\Roaming\Typora\typora-user-images\image-20231002154740313.png)就行。以前的snap turn应该是在版本更新中被迭代掉了。

此时会发现视角是可以穿透物体的，所以我们此时要加上一些碰撞和物理逻辑。此时还需要一个character manager。但是和VRLocomotion不一样，如果这个character manager不放在XR Origin下，就会出现问题。

![image-20230930141958915](C:\Users\50432\AppData\Roaming\Typora\typora-user-images\image-20230930141958915.png)

这个character controller driver是XR interaction toolkit里的一个新组件，实际上是把VR locomotion和character controller建立一个管道连接的中间角色。

接下来放入一些collider，记得给地板也加一个collider，不然人直接掉下去了。

### 2.1.3 VR Locomotion - Teleport 传送移动

参考链接：[VRLocomotion-Teleport传送移动](https://www.bilibili.com/video/BV1wG411Z7pV/?spm_id_from=pageDriver&vd_source=29d074918f3e47ac0fcc0ed2c870d98f)

在VR的移动中，最推荐的当然就是传送，因为它可以很好地避免晕动症。但是传送移动当然也就复杂很多。在XR Interaction Toolkit中其实只包含两大部分，一个是Locomotion运动体系，另一个是Interaction交互体系。而传送是结合两者的一个过渡。

---

**Unity XR Toolkit —— VR Teleport Movement 的组成：**

+ Locomotion系统：
  + Teleportation Provider（管理XR Origin的移动）
+ Interaction系统：（管理交互双方要挂接的不同组件）
  + Interactor（交互的发出者，挂在控制器上）
    + XR Ray Interactor（手柄射线）
  + Interactable（交互的接收者，挂在要传送到的位置）
    + XR Teleportation Area（地面）
    + XR Teleportation Anchor（特定传送点）

---

#### 2.1.3.1 Locomotion系统：

![image-20230930145134296](C:\Users\50432\AppData\Roaming\Typora\typora-user-images\image-20230930145134296.png)

#### 2.1.3.2 Interaction系统：

之前是左手负责移动，所以现在可以让右手负责传送。这里的交互逻辑使用的是当XR Ray Interactor碰到一个Interactable的东西的时候，再看要不要交互移动过去。

**Interactor：交互的发出者**

![image-20230930164652145](C:\Users\50432\AppData\Roaming\Typora\typora-user-images\image-20230930164652145.png)

![image-20230930165310440](C:\Users\50432\AppData\Roaming\Typora\typora-user-images\image-20230930165310440.png)

![image-20230930165833284](C:\Users\50432\AppData\Roaming\Typora\typora-user-images\image-20230930165833284.png)

**Interactable：交互的接收者**

分为点转送和面传送，二者逻辑相似

1. XR Teleportation Area（面）

   ![image-20230930170836248](C:\Users\50432\AppData\Roaming\Typora\typora-user-images\image-20230930170836248.png)

   加上之前的一些设置，这个时候会发现，当右手控制器的射线移动到这个cube上的时候，会变成一个激活的状态，这个时候点击一下手柄上的选择键，就可以传送上去。

2. XR Teleportation Anchor（点）

   这里我们考虑制作一系列的传送点，所以这里就把转送点做成prefab。其他的和面是一样的。

   ![image-20230930201503814](C:\Users\50432\AppData\Roaming\Typora\typora-user-images\image-20230930201503814.png)

### 2.1.4 VRLocomotion - Teleport 更改输入&添加准星

参考链接：[VRLocomotion-Teleport更改输入&添加准星](https://www.bilibili.com/video/BV12p4y1N75i/?spm_id_from=333.788&vd_source=29d074918f3e47ac0fcc0ed2c870d98f)

**更改输入：从按键传送变成手柄向前推**

![image-20230930204143734](C:\Users\50432\AppData\Roaming\Typora\typora-user-images\image-20230930204143734.png)

所以只需要，

![image-20230930204248557](C:\Users\50432\AppData\Roaming\Typora\typora-user-images\image-20230930204248557.png)

**添加准心**

![image-20230930210207032](C:\Users\50432\AppData\Roaming\Typora\typora-user-images\image-20230930210207032.png)

但是就用一个球来做准心其实还是不好看，所以也考虑对于一些比较好看的特效、动画或者图标，可以用blender来做

## 2.2 VR手型控制器输入及动画

参考链接：[VR手型控制器输入及动画](https://www.bilibili.com/video/BV1ZG41197TA/?spm_id_from=pageDriver&vd_source=29d074918f3e47ac0fcc0ed2c870d98f)

![image-20230930211108036](C:\Users\50432\AppData\Roaming\Typora\typora-user-images\image-20230930211108036.png)

XR Controller Hand Visual：通过控制器来模拟手

XR Hand Tracking：（现在的头显设备都可以直接显示现实了）通过对手部的跟踪和对应的手势来进行交互，直接显示的就是人手，或者对人手进行一些处理再展示。基于的是头显上的摄像头进行的动作捕捉。PICO也可以实现手追，但是效果不是特别好。（应该是受限于场地了）

在参考链接的视频中是用的Quest进行展示的，而Quest的包里内置了很多的手型以及对应的切换动画。这里也发现了PICO内置的虽然只有手型和几款设备的控制器，并且手型没有做动画。（这里的手部模型用在手部追踪了）但是可以发现他的手型也是很细的。所以如果要靠自己去抠动画，完全也是有可能的。只不过会很花时间。

![image-20230930213029421](C:\Users\50432\AppData\Roaming\Typora\typora-user-images\image-20230930213029421.png)

但是因为我们还没有确定最后的开发形式和素材，所以这里暂时都先不做。



## 2.3 VR交互系统 —— Unity XR Interaction System

![image-20230930214805327](C:\Users\50432\AppData\Roaming\Typora\typora-user-images\image-20230930214805327.png)

### 2.3.1 交互时的三种状态（三个操作）

+ Hover 悬停：Interactor Ray 射线或 Collider 和 Interactable 碰撞时，处于 Hover 状态。不需要控制器按键，只需要控制器处于特定位置，使碰撞（射线碰撞或碰撞体碰撞）生效
+ Select 选择：通常发生在 Hover 前提之下，可以由 Hover 转换为 Select ，通常绑定的是控制器的 Grip 键。当 Grip 键被按下，即 GripPressed 时触发。
+ Activate 激活：通常发生在 Select 前提之下，由 Select 转为 Activate ，通常绑定的是控制器的 Trigger 键。
  当 Trigger 键被按下，即 TriggerPressed 时触发

### 2.3.2 Direct Interactor 直接交互

参考链接：[VR交互 Direct Interactor](https://www.bilibili.com/video/BV1SN411v7ih/?spm_id_from=pageDriver&vd_source=29d074918f3e47ac0fcc0ed2c870d98f)

#### 2.3.2.1 具体实现

首先，给左右手控制器都加上XR Direct Interactor组件

![image-20231001135200153](C:\Users\50432\AppData\Roaming\Typora\typora-user-images\image-20231001135200153.png)

直接交互的原理是**碰撞**，所以要给控制器加上碰撞体，这里最合适的是球体

![image-20231001135603491](C:\Users\50432\AppData\Roaming\Typora\typora-user-images\image-20231001135603491.png)

有了这两个组件，一些基础的直接交互就已经可以完成了

#### 2.3.2.2 Interactor 详解

参考链接：[XR Interactor 属性详解](https://www.bilibili.com/video/BV1w8411z7fF/?p=13&spm_id_from=pageDriver)

![image-20231001155239056](C:\Users\50432\AppData\Roaming\Typora\typora-user-images\image-20231001155239056.png)

1. Interaction Manager 交互管理器

   整个交互系统底层实现的基础，最核心的组件，是 Interactor 和 Interactable 中介机构，实现二者之间的通信。

   填入了交互管理器后，Interactor 和 Interactable都会向 Manager 进行一个注册。如果这里没有填的话，它会到系统中去找，并且完成注册。但是所有被加载的场景中，必须至少有一个交互管理器。允许有多个，但是如果没有的话，所有交互都不可能完成。如果有多个的话，就必须手动指定由哪个交互管理器来管理。如果Interactor和Interactable注册到了不同的交互管理器上的话，那么就无法进行交互了。

   交互器和交互对象上的方法都是由交互管理器进行调用的，而不是事件发生时自己调用自己的方法。当事件发生的时候，是由交互管理器通知交互器和交互对象调用对应的方法。这样的好处是保持交互事件两个目标之间的一致性。不会出现一个发生一个不发生，或者有时差的情况。

   想要吃透XR Interaction，要去结合API文档和源码进行学习。

2. Interaction Layer Mask

   设置专属的交互层，用来对不同类型的交互进行区分和分隔，在同一层中的交互器和交互对象才能进行交互。不同层的交互器和交互对象不相互影响。

   注意，这个交互层跟游戏对象所在的Layer层是不一样的。

   Default是任何层都交互。

   如果要设置一个很复杂的交互逻辑的话，这个是很有用的。比如我可以设置一个teleport层和一个interaction层，这样就不会把传送的地点设置到我可以交互的物体上。

3. Attach Transform

   这是用来挂接交互接触点的位置。在Interactable上也有这个属性，一般是设置Interactable上面的。不同的可交互物体，交互方式不同，交互位置不同。

   如果要放到Interactor上，除非是一些比较特殊的情况。它可以用来调整整体的抓握位置。

4. Select Action Trigger

   里面有四个属性，用来选择Unity如何解释来自控制器的选择输入操作。一般推荐State Change。State和State Change的共同点是按下默认select对应的按钮以后，激发选择操作。

   + State：只要Select操作对应按键处于激活状态，Unity就会认为输入处于活动状态。会导致每帧都触发选择交互事件，比较耗费性能。
   + State Change：只有在按下按钮的那一帧，Unity才会认为输入处于活动状态。用户必须在可以进行交互时按下按钮，才会触发交互。如果用户在可进行交互之前就按下按键，是不会触发交互的。
   + Toggle：按下进入激活状态，直到第二次按键才能取消，比如玩家抓取一个物体后，不想一直按着 grip 键就能保持 selected 状态，就可以设定为这个选项
   + Sticky：按下进入激活状态，直到第二次按键松开才能取消

5. Keep Selected Target Valid

   在最初选择一个交互对象后，即使该对象不再是有效目标，是否仍要继续选择该对象。通常，在抓取操作时，设置为 true；在传送操作时，设置位 false

6. Hide Controller On Select

   当前的 Interactor 在 处于选中状态时，是否隐藏控制器模型。设置位 TRUE 可以简化项目，省去手部动画

7. Allow Hovered Activate

   当前的 Interactor 在 Hovered 状态，但是，没有处于 Selected 状态时，是否要发送 activate 和 deactivate 事件给 Interactable 对象。默认是只有处于 Selected 状态时，Interactor 才允许发送activate 和 deactivate 事件给 Interactable 对象。一般保持默认false就行

8. Starting Selected Interactable

   起始选中的交互对象。一般留空

### 2.3.3 Interactable 两种方式

接下来设置Interactable的物体

![image-20231001141723741](C:\Users\50432\AppData\Roaming\Typora\typora-user-images\image-20231001141723741.png)

Interactable分为两种，一种是XR Sample Interactable，另一种是XR Grab Interactable。

#### 2.3.3.1 XR Sample Interactable

![image-20231001142459848](C:\Users\50432\AppData\Roaming\Typora\typora-user-images\image-20231001142459848.png)

到这里其实已经可以实现交互了，但是和下面将要介绍的Grab Interactable不一样，Interactable的物体没有绑定事件，所以这里的交互将没有任何反映。所以这里可以对Interactor和Interactable分别绑定一些事件。

在这里我想实现一个效果，就是当物体被选中的时候，可以有一个选中描边的效果。如果单纯靠自己实现的话，其实是很复杂的。所以这里我们用到了Unity Assets里的一个插件：Quick Outline。

![image-20231001143231077](C:\Users\50432\AppData\Roaming\Typora\typora-user-images\image-20231001143231077.png)

在使用过程中只需要将这个脚本拖拽到对应的物体下，再改一改参数就行了。

现在unity里的事件管理都很方便了，在这里我们使用一种完全避开代码的方式进行操作。

![image-20231001143554023](C:\Users\50432\AppData\Roaming\Typora\typora-user-images\image-20231001143554023.png)

此时我们再给Interactor加一个事件

![image-20231001143838269](C:\Users\50432\AppData\Roaming\Typora\typora-user-images\image-20231001143838269.png)

这里有一个很乌龙的情况：在测试过程中，到底XR Origin里的摄像头里桌子有多远？因为测试的时候我以为是哪里出了错，所以无法出现被选中时的描边，但是实际情况是人离Interactable太远了，使得我以为碰到了，其实根本没碰到。

#### 2.3.3.2 XR Grab Interactable

要实现抓取的交互方式，只需要加入XR Grab Interactable组件就行了（当然还有碰撞体和刚体都要有）一些事件的绑定方式和上述是一样的

![image-20231001154558855](C:\Users\50432\AppData\Roaming\Typora\typora-user-images\image-20231001154558855.png)

---

**Interactable 属性详解：**

1. 通用属性

   - Interaction Manager
     交互管理器，连接交互器和交互对象的桥梁，所有交互操作都通过这里发出
   - Interaction Layer Mask
     设置专属的交互层，来对不同类型的交互分割开，同一层的交互层的 Interactor 和 Interactable 才能交互，不同层互不影响。注意，这个和普通的 Layer 无关
   - Colliders：
     碰撞体。用来跟 Interactor 中碰撞体碰撞的组件，是实现交互的基础。碰撞体碰撞后，才会引发 Hover 状态的产生。如果当前游戏对象上有碰撞体，可以不填留空，Unity 会自动绑定
   - Distance Calculation Mode 设定计算与 Interactor 距离的算法模式，从最快到最精确。
     如果当前 Interactable 使用 Mesh Collider，则碰撞体的体积仅当设定为 Convex 时才有效
     - Transform Position ：
       直接使用 Interactable 的 Transform 中的属性来计算距离。
       消耗最小。
       但对某些对象而言，其距离计算精度可能较低。
     - Collider Position ：
       使用 Interactable 对象上的 Colliders List ，分别计算每个碰撞体 跟 Interactor 的最短距离。
       该选项的性能成本适中，对于大多数对象而言，距离计算的精确度也应适中。
     - Collider Volume ：
       使用 Interactable 的 Colliders 列表计算距离，使用到每个对撞机最近点（表面或对撞机内部）的最短距离。
       该选项的性能成本较高，但距离计算精度较高。
   - Custom Reticle
     自定义准星，这个投射在 Interaction 表面上的准星，一般设置位 2D 的图片
   - Select Mode
     表示 Interactable 的选择策略。它控制有多少个交互者可以选择该交互对象。
     只有在尝试选择时，交互管理器才会读取该值，因此将该值从 "多个 "改为 "单个 "不会导致退出选择。
     - Single:
       防止同时有多个互动者进行额外的同步选择。
     - Multiple:
       允许同时从多个交互器中选择交互对象。
   - Focus Mode 指定此交互对象的焦点策略。
     - None: 将 "焦点模式 "设置为 "无 "可禁用可交互对象的 "焦点 "状态。
     - Single: 允许单个交互组的交互者关注该交互对象。
     - Multiple:
       允许多个交互组的交互者关注该交互对象。
   - Gaze Configuration
     是否允许瞳孔跟踪交互

2. Grab Interactable 特有属性

   - Movement Type:
     指定该对象在被选中时的移动方式，可以通过设置刚体的速度、在固定更新时移动运动学刚体或在每帧直接更新变换。

     - Velocity Tracking (速度跟踪 —— 不穿模):

       通过设置刚体的速度和角速度来移动可交互对象。

       如果不想让交互物体跟随交互对象移动时，穿过其他没有设置刚体的碰撞器，可以使用这种方法. 但这样做的代价是物体会显得滞后，无法像瞬时物体那样平滑移动。

       - Angular Velocity Damping： Unity 在跟踪 Interactor 旋转时抑制现有角速度的比例因子。数值越小，角速度衰减的时间越长。
       - Angular Velocity Scale：
         统一缩放因子，用于在跟踪交互体旋转时更新刚体的跟踪角速度。

     - Kinematic （运动学 —— 穿模）:
       通过向目标位置和方向移动 Kinematic Rigidbody 来移动可交互对象。
       如果希望视觉效果与物理状态保持同步，并且希望物体在跟随交互对象移动时能够穿过其他不使用刚体的碰撞器，则可以使用此方法。

     - Instantaneous（瞬时 —— 穿模）:
       通过在每一帧设置 Transform 的位置和旋转来移动可交互对象。
       如果您希望每帧都更新可视化表示，尽量减少延迟，则可以使用此方法，但当它跟随交互对象移动时，可以穿过其他不使用刚体碰撞器。

   - Retain Transform Parent
     启用时，在此对象被抛下后，使Unity能够将此对象的父对象重新设置为其最初的父对象。

   - Track Position:
     启用后，该对象在 Selected 时会跟随 Interactor 交互对象的位置移动。

     - Smooth Position:

       启用后，会在跟随 Interactor 的位置移动时应用平滑处理。

       - Smooth Position Amount：
         缩放因子，用于在选中时跟随交互界面的位置进行平滑处理的程度。
         该值越大，该对象就越接近互动者的位置。
       - Tighten Position：
         减少使用平滑处理时的最大跟随位置差。
         使用平滑处理时，平滑处理后的位置应与交互作用器位置保持多接近的分数。
         数值范围从 0 表示平滑后的跟随距离没有偏差，到 1 表示实际上完全没有平滑。

   - Track Rotation:
     启用后，该对象在 Selected 时会跟随 Interactor 交互对象的转动。

     - Smooth Rotation:

       启用后，会在跟随 Interactor 转动时应用平滑处理。

       - Smooth Rotation Amount：
         缩放因子，用于在选中时跟随交互器 Interactor 的旋转进行平滑处理的程度。
         该值越大，该对象就越接近互动者的旋转。
       - Tighten Rotation：
         减少使用平滑处理时的最大跟随旋转差。
         使用平滑处理时，平滑处理后的旋转应与交互作用器旋转保持多接近的分数。
         数值范围从 0 表示平滑后的跟随旋转没有偏差，到 1 表示实际上完全没有平滑。

   - Track Scale:
     启用后，该对象在 Selected 时会跟随 Interactor 交互对象的缩放。

     - Smooth Scale:

       启用后，会在跟随 Interactor 缩放时应用平滑处理。

       - Smooth Scale Amount：
         缩放因子，用于在选中时跟随交互界面的缩放进行平滑处理的程度。
         该值越大，该对象就越接近互动者的缩放。
       - Tighten Scale：
         减少使用平滑处理时的最大跟随缩放差。
         使用平滑处理时，平滑处理后的缩放应与交互作用器缩放保持多接近的分数。
         数值范围从 0 表示平滑后的跟随距离没有偏差，到 1 表示实际上完全没有平滑。

   - Throw On Detach：
     启用后，该对象在释放时将继承 Interactor 的速度 velocity 。运动学刚体(kinematic Rigidbody)不支持此功能

     - Throw Smoothing Duration
       该值表示采集的采样用于速度计算的时间（最多 20 个前帧，取决于平滑持续时间和帧频）。
       例如，如果该值设置为 0.25，位置和速度值将取过去 0.25 秒的平均值。
       这些值的权重（乘以）也是由投掷平滑曲线决定的。
     - Throw Smoothing Curve
       投掷时用于加权速度平滑的曲线（最近帧在右侧）。
       默认情况下，该曲线的值为 1.0，因此在平滑持续时间内，所有平滑值都会被同等对待。
     - Throw Velocity Scale
       投掷速度缩放：Unity 将在释放时应用于该对象从 Interactor 继承的速度缩放因子。
     - Throw Angular Velocity Scale
       投掷角速度缩放：投掷时，Unity 将对该对象从交互作用器继承的角速度应用的缩放因子

   - Force Gravity On Detach
     强制此对象在释放时具有重力（如果此值为 false/未选中，则仍将使用抓取前的值）

   - Attach Transform
     在此 Interactable 上使用的抓握连接点（如果未设置，则使用此对象的位置）。

   - Secondary Attach Transform
     该 Interactable 上用于双手交互的第二个附着点。(如果不设置此属性，Unity 会使用第二个 Interactor 的 attach Transform）。

   - Use Dynamic Attach
     启用后，在选择时将根据 Interactor 的姿势(pose)来确定有效连接点。

     - Match Position:
       在初始化抓取时，与 Interactor 的附着点位置相匹配。
       这将覆盖当前组件 Attach Transform 属性。
     - Match Rotation:
       在初始化抓取时，与 Interactor 的附着点旋转相匹配。
       这将覆盖当前组件 Attach Transform 属性。
     - Snap To Collider Volume:
       调整动态连接点，使其位于此对象上的 collider 上或内侧。
     - Reinitialize Every Single Grab:
       当从多个抓取变回单个抓取时，重新初始化动态附着姿势。
       如果您想在释放第二只手后保持对象的当前姿势，而不是恢复到最初抓取时的附着姿势，请使用此功能。

   - Attach Ease In Time
     当前对象被 Selected 时，缓和（eases in）的时间（以秒为单位）（数值为 0 表示不缓和）。

   - Attach Point Compatibility Mode 控制计算对象目标位置时使用的方法。
     使用 AttachPointCompatibilityMode.Default 可使所有 XRBaseInteractable.MovementType 值之间的附着点保持一致。

     - Default(Recommended)

   - Grab Transformers Configuration:
     抓握 Transformers 设置

     - Add Default Grab Transform
       如果 "单个抓取变换器 "或 "多个抓取变换器 "列表为空，Unity 是否会添加默认的抓取变换器集（default set of grab transformers）。
     - Starting Multiple Grab Transformers
       此 Interactable 启动时自动链接的抓取变换器（可选，可能为空）。
       用于选择多个交互对象。启动后，此属性将不再使用。
       当需要处理多个抓取变换器并指定顺序时，该属性非常有用。
     - Starting Single Grab Transformers
       此 Interactable 启动时自动链接的抓取变换器（可选，可能为空）。
       用于单个交互对象的选择。启动后，此属性将不再使用。
       当需要处理多个抓取变换器并指定顺序时，该属性非常有用。

---

### 2.3.4 XR Ray Interactor

参考链接：[XR RAY Interactor 详解](https://www.bilibili.com/video/BV1q94y1W74k/?spm_id_from=pageDriver&vd_source=29d074918f3e47ac0fcc0ed2c870d98f)

注意：一个控制器只能挂一个XR Interactor，而XR Ray Interactor和XR Direct Interactor都是继承自XR Base Interactor的。所以我们可以在控制器下新建一个空对象，专门用来放各种各样的Interactor。

Ray Interactor 使用射线投射和 Interactable 的 Collider 碰撞，从而产生交互事件。所以它在使用时，必须配上能显示、并调整射线外观的配套组件：

![image-20231002161742309](C:\Users\50432\AppData\Roaming\Typora\typora-user-images\image-20231002161742309.png)

---

+ Line Render 射线渲染器

  Unity 中，设置线显示数据的组件。和大多数 Unity 中的渲染器组件类似，其中包含 材质、阴影设置、光探针 等相关渲染呈现所需要的元数据。

  ![image-20231002162151180](C:\Users\50432\AppData\Roaming\Typora\typora-user-images\image-20231002162151180.png)

  这里先将材质设置为Default-Line，可以让射线正常展示。

+ XR Interactor Line Visual 交互器射线显示配置组件

  用来配置交互射线的一些外观属性。如 颜色、线宽等

  ![image-20231002163228329](C:\Users\50432\AppData\Roaming\Typora\typora-user-images\image-20231002163228329.png)

+ Sorting Group 排序组

  ![image-20231002163246506](C:\Users\50432\AppData\Roaming\Typora\typora-user-images\image-20231002163246506.png)

---

到这里这个Ray Interactor就可以用了。但是这个时候会发现一个情况：

<img src="C:\Users\50432\AppData\Roaming\Typora\typora-user-images\image-20231002162809606.png" alt="image-20231002162809606"  /><img src="C:\Users\50432\AppData\Roaming\Typora\typora-user-images\image-20231002162931685.png" alt="image-20231002162931685"  />

那这个线到底有多宽呢？实际上，在开发时的scene里，看到的线的宽度是由line renderer里的宽度决定的（所以说这里会看到一个平面）而在程序运行过程中，射线的Visual是由下面这个组件决定的。

---

**XR Ray Intercator 的特别属性：**

![image-20231002163628632](C:\Users\50432\AppData\Roaming\Typora\typora-user-images\image-20231002163628632.png)

1. Enable Interaction with UI Game Objects 是否允许和UI元素进行交互

   如果取消了的话，当前的Ray Interactor就只能用于物体交互，不能用于UI交互。例如，和Canvas进行交互。

2. Force Grab 必须抓握

   如果开启的话，交互之后对应物体会跑到attach point（如果有）上去；如果不开启的话，交互之后会保持交互瞬间的相对位置。

3. Anchor Control 是否允许用户使用操纵杆来移动连接锚点点位

   如果打开的话，可以用摇杆来控制物体的远近和旋转角度。

   + Translate Speed 锚点平移的速度

   + Rotate Reference Frame

     用于在旋转附加锚点时定义向上轴。未设置时，将围绕附加变换的本地向上轴旋转。

   + Rotation Mode

     指定如何控制锚点旋转

     + Rotate Over Time 随时间旋转

       可在旋转输入激活时控制锚点随时间旋转。

     + Match Direction 匹配方向

       以便将锚点旋转与二维旋转输入的方向相匹配。

   + Rotation Speed 锚点旋转的速度

4. Ray Origin Transform

   任何射线投射的起始位置和方向。 如果无，则在唤醒时自动实例化和设置，并使用 XRBaseInteractor.attachTransform 的姿势进行初始化。设置后不会自动销毁前一个对象。

5. Raycast Configuration

   射线根据 Line Type 分为三种，每种的属性和设置都不同

   1. Line Type

      1. Straight Line 直线

         + Max Raycast Distance 射线最大长度（如果隔空取物的距离没那么长的话就在这里设置）

      2. Projectile Curve 抛物线

         符合物理准则，需要参数得到公式。通常用于使得你抛出去的东西符合一个物理准则。

         - Reference Frame : 仅在线条类型为抛物线或贝塞尔曲线时使用和显示。 用于定义地平面和向上的曲线参考框架。如果未在启动时设置，它将尝试查找 XROrigin.Origin 游戏对象，如果该对象不存在，它将默认使用全局向上和原点。
           说白了就是定义曲线的原点的弯曲方向
         - Velocity ：
           仅在线条类型为抛物线时使用和显示。初始速度。
           增大该值会使曲线延伸得更远。
         - Acceleration ： 重力
         - Additional Ground Height：
           在地面以下继续飞行的额外高度。
           增加该值会使终点下降的高度降低。
         - Additional Flight Time：
           降落到调整后的地面高度后的额外飞行时间。
           增加该值会使终点高度降低。
         - Sample Frequency：
           Unity 用于近似曲线路径的采样点数量。
           数值越大，近似的质量越高，但由于射线投射的次数增多，性能会有所降低。
           数值为 n 时，射线投射将产生 n - 1 个线段。 说白了，就是数量越大，线越圆润，但越消耗资源

      3. Bezier Curve 贝塞尔曲线

         参考文档：[贝塞尔曲线](https://zhuanlan.zhihu.com/p/136647181)

         可控性更强，可以自定义曲线的样子。通常用于传送。

         - Reference Frame ：
           同上
         - End Point Distance：
           末端距离。
           增大该值距离，可使曲线终点距离起点更远。
         - End Point Height：
           末端高度。
           减小该值可使曲线末端相对于起点下降得更低。
         - Control Point Distance：
           增大该值可使曲线峰值离起点更远。
         - Control Point Height：
           增加该值可使曲线峰值相对于起点更高。
         - Sample Frequency：
           同上

   2. Raycast Mask

      用于限制光线投射目标的图层蒙板。

   3. Raycast Trigger Interaction

      通过射线投射与触发碰撞器的交互类型。

   4. Raycast Snap Volume Interaction

      即使射线投射已设置为忽略触发器，射线投射是否仍应包括或忽略对触发器碰撞器（即快速体积碰撞器）的命中。如果不使用凝视辅助或 XR 可交互快照体积组件，则应将此属性设置为忽略，以避免性能代价。

   5. Hit Detection Type

      射线碰撞类型，有以下三个选项：

      + Raycast：使用物理Raycast监测碰撞
      + Sphere Cast：使用物理球形Cast监测碰撞
      + Cone Cast：使用锥形来监测碰撞

   6. Hit Closest Only

      Unity 是否只将最近的交互对象视为有效的交互目标。
      启用此选项可使只有最近的交互对象接收悬停事件。
      否则，所有被击中的交互对象都将被视为有效目标，并且此交互对象将多重悬停。

   7. Blend Visual Line Points

      将 Unity 用于射线投射的线条采样点与控制器的当前姿势混合。使用此方法可使线条视觉效果与控制器保持连接，而不是滞后。
      当控制器被配置为在渲染前直接采样跟踪输入以减少输入延迟时，控制器可能会处于相对于光线投射所用采样曲线起点的新位置或旋转位置。
      如果值为 false，则视觉线将保持在固定的参考帧上，而不会向光线投射线的末端弯曲。

---

### 2.3.5 XR Socket Interactor

顾名思义，插孔交互器 Socket Interactor 是用来做一个可以让交互对象 Interactable 插进去，快速定位用的特殊交互器。

举个栗子，比如：在玩家身上挂武器、在墙上或武器架上挂陈列的兵器，等等；挂接的位置是一个 Socket Interactor，武器就是 Interactable；又比如：钥匙的钥匙孔或电池的电池插座，都可以用 Socket Interactor 来实现

该组件的设计目的不是附加到控制器上（因此与 XR Direct Interactor 和 XR Ray Interactor 不同，它不是从 XR Base Controller Interactor 派生的），而是始终尝试选择悬停在其上的可交互对象（尽管不会对该可交互对象执行排他性选择）

![image-20231003115906999](C:\Users\50432\AppData\Roaming\Typora\typora-user-images\image-20231003115906999.png)

**实操：**

直接在想要添加Socket Interactor的地方 Create 一个 Socket Interactor 就行。

<img src="C:\Users\50432\AppData\Roaming\Typora\typora-user-images\image-20231003120200120.png" alt="image-20231003120200120"  />

![image-20231003120655190](C:\Users\50432\AppData\Roaming\Typora\typora-user-images\image-20231003120655190.png)

逻辑：当物体的碰撞体与Socket Interactor的碰撞体碰撞的时候，这个时候松开选择键，物体就会被自动吸附到Socket Interactor上。

![image-20231003121244057](C:\Users\50432\AppData\Roaming\Typora\typora-user-images\image-20231003121244057.png)

最终这个摆放的角度和位置通过 Attach Transform 来确定。

![image-20231003122354377](C:\Users\50432\AppData\Roaming\Typora\typora-user-images\image-20231003122354377.png)

---

**独有属性**

- Show Interactable Hover Meshes:

  当交互对象悬停在交互器上时，是否显示交互器网格（交互器外观）也就是上图蓝色的肉饼。

  - Hover Mesh Material：
    悬停时，交互器所有材质
  - Can't Hover Mesh Material：
    当插座中已有选定对象时，用于在悬停时渲染可交互网格的材质（如果没有提供材质，则将创建默认材质）。
  - Hover Scale：
    悬停时缩放

- Hover Socket Snapping ： 决定悬停时，交互对象是否应紧贴 socket Interactor 的附着变换 attach transform。
  请注意，这会导致 hover mesh 视觉效果发生 Z 打架(z-fighting)，因此不建议同时使用这两个选项。 如果启用，则会禁用悬停回收延迟功能(hover recycle delay)。

- Socket Scale Mode:

  缩放模式，用于计算悬停时应用于可交互对象的缩放因子

  - None : 不缩放
  - Fixed ： 设置具体的缩放比例，三个轴都可单独设置
  - Stretched to Fit Size : 当缩放模式设置为 "按尺寸拉伸 "时，用于计算应用于可交互对象的缩放因子的边界尺寸

- Socket Active : 插孔是否可用。我也可以直接把这个组件disable，区别在于内存上的处理。

- Recycle Delay Time:
  设置对象移除后 socket 拒绝悬停的时间。如果已启用 Hover Socket Snapping 捕捉，则此属性不起任何作用。

**Socket Interactor 使用时注意点：**

Socket Interactor 一般来说，在同一个GameObject 上，要搭配以下组件一同使用：

- Collider:
  用来实现交互检测，但一定要设置为 Trigger。（Is Trigger 属性为 True）

---

### 2.3.6 XR Poke Interactor 戳（手指）交互器

