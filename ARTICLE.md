# .NET/C# を UEFI 上で動かす事はできるか？
Copyright (C) 2022 Takym.

## 目的
* この記事は「[自作OS Advent Calendar 2022](https://adventar.org/calendars/8392)」の12月25日に向けて執筆した。

<!-- TODO: ここから書き掛け -->

## 対象
* UEFI の仕組みをある程度理解している。
* .NET の仕組みをある程度理解している。

## Native AOT を使う方法

### 利点
* 一番簡単な方法

### 欠点
* ランタイムライブラリを使用できない

## 最小の Linux カーネルを使う方法

### 利点
* ランタイムライブラリを使用できる

### 欠点
* UEFI 上で動かした事にはならない
* 自作 OS と言えるかどうかも微妙

## .NET ランタイムを移植する方法

### 利点
* ランタイムライブラリを使用できる

### 欠点
* 完成までに長い時間を要する

## 結論

## 感想

## 出典・参考文献

<!-- TODO: ここまで書き掛け -->

## 余談
* これまでの記事は敬体で書いていましたが、今回は常体で書きました。そのため少し不安が残ります。
	* 感想はとても個人的な内容になりますので敬体で書きました。
	* 分かり易くする為に事実と感想で文体を別ける様に心掛けています。
* 自分の過去の記事を再読してみましたが、今思うと拙作であったと感じます。

## 過去の記事の紹介
* 2019年12月25日
	* [TakymSystems](https://takymsystems.blog.fc2.com/blog-entry-92.html)
	* [takym.code.blog](https://takym.code.blog/2019/12/25/%e3%83%87%e3%82%a3%e3%82%b9%e3%82%af%e3%83%95%e3%82%a9%e3%83%bc%e3%83%9e%e3%83%83%e3%83%88%e3%81%ae%e4%bb%95%e6%a7%98%e6%9b%b8%e3%82%92%e6%9b%b8%e3%81%8d%e3%81%be%e3%81%97%e3%81%9f%e3%80%82/)
* 2019年12月24日
	* [TakymSystems](https://takymsystems.blog.fc2.com/blog-entry-90.html)
	* [takym.code.blog](https://takym.code.blog/2019/12/24/os-developer-ide-%e3%82%92%e9%80%a0%e3%82%8d%e3%81%86%e3%81%a8%e3%81%97%e3%81%a6%e5%a4%b1%e6%95%97%e3%81%97%e3%81%9f%e3%80%82/)
* 2018年12月25日
	* [TakymSystems](https://takymsystems.blog.fc2.com/blog-entry-86.html)
	* [takym.code.blog](https://takym.code.blog/2018/12/25/os%e3%81%af%e3%82%aa%e3%83%bc%e3%83%97%e3%83%b3%e3%82%bd%e3%83%bc%e3%82%b9%e3%81%ab%e3%81%99%e3%81%b9%e3%81%8d%e3%81%8b%ef%bc%9f/)
