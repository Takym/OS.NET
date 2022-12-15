# .NET 7 と C# を用いて OS を開発する事はできるのか？
Copyright (C) 2022 Takym.

## 目的
* この記事は「[自作OS Advent Calendar 2022](https://adventar.org/calendars/8392)」の12月25日に向けて執筆した。

## 対象読者
* UEFI の仕組みをある程度理解している。
* .NET の仕組みをある程度理解している。

## 動機
* オペレーティングシステム（以下、OS）は C/C++ や Rust などの[事前コンパイル](https://ja.wikipedia.org/wiki/%E4%BA%8B%E5%89%8D%E3%82%B3%E3%83%B3%E3%83%91%E3%82%A4%E3%83%A9)型言語（Ahead-Of-Time Compiled Language; AOT Compiled Language）を用いて開発する事が多い。
* C# は[実行時コンパイル](https://ja.wikipedia.org/wiki/%E5%AE%9F%E8%A1%8C%E6%99%82%E3%82%B3%E3%83%B3%E3%83%91%E3%82%A4%E3%83%A9)型言語（Just-In-Time Compiled Language; JIT Compiled Language）である為、OS 開発には向かないと考えられてきた。
* .NET 7 から [Native AOT](https://learn.microsoft.com/dotnet/core/deploying/native-aot/) が正式にサポートされたため、C# でも UEFI 向けのアプリケーションを生成できる様になった。
* C# の様な高機能オブジェクト指向プログラミング言語を用いてより効率的に OS 開発を行えるのではないかと考えた。
* また、.NET 7 の膨大なランタイムライブラリを使えば、車輪の再発明をせずに新規の OS を開発できるのではないかと考えた。
* 本記事では .NET 7 及び C# を用いた OS 開発の手法の利点と欠点を考察する。

## Native AOT を使う方法
* 冒頭でも説明した Native AOT を使う方法の利点と欠点を考察する。
* Native AOT を用いた UEFI アプリケーションの実装例は [zerosharp/efi-no-runtime](https://github.com/MichalStrehovsky/zerosharp/tree/master/efi-no-runtime) がある。

### 利点
* 他の方法よりも直観的である。
* UEFI の API を直接触る事ができる。

### 欠点
* UEFI アプリケーションの制約で、ライブラリを動的にリンクする事ができない。
* ランタイムライブラリを使用できない。
	* `System.Object` や `System.String` 等の基本的な型も定義する必要がある。
	* 定義しなければならない基本型の数は多い。
* ビルド時に解析ツールが型情報の互換性に関するエラーを発生させる場合がある。

## .NET 7 ランタイムを移植する方法
* 次に .NET 7 ランライムそのものを UEFI に移植する方法を考察する。
* .NET 7 ランタイムはオープンソースである為、自力で移植する事ができる。

### 利点
* 完全なランタイムライブラリが使用できる。
* .NET 7 が「最小のカーネル」の様な役割を果たしてくれる為、動的リンクが可能になる。

### 欠点
* .NET 7 のソースコードは膨大である為、移植には長い時間を要する。
* UEFI の API を直接触る事ができない。

## .NET 7 のランタイムライブラリのソースコードの一部をコピーする方法
* ランタイムライブラリから必要な部分のソースコードのみをコピーし、Native AOT を用いる方法を考察する。

### 利点
* ランタイムライブラリの一部が使用できる。
	* 基本型の定義が不必要になる。
* コピーするコードは一部で良いので、移植に掛かる時間が短くなる。
* UEFI の API を直接触る事ができる。

### 欠点
* ランタイムライブラリの更新に手間が掛かる。
	* ライブラリに更新があった際は、再びソースコードをコピーする必要がある。
* 動的リンクができない。

## 最小の Linux カーネルを使う方法
* 最小の Linux カーネルの上で .NET 7 を実行する方法を考察する。
* これは .NET 7 と C# を用いて Linux ディストリビューションを開発する方法であると言える。

### 利点
* 完全なランタイムライブラリを使用できる。
* 動的リンクができる。
* NuGet を用いたライブラリの自動更新ができる。
* .NET 7 は Linux に対応しており、互換性の問題は殆ど無い。

### 欠点
* カーネルそのものは開発しないので、自作 OS の開発であると言えるか微妙である。

## COSMOS を使う方法
* [COSMOS](https://www.gocosmos.org/) と呼ばれる C# で OS を開発する為のフレームワークがある。

### 利点
* サードパーティー製のフレームワークを用いても良いのであれば、最も簡単な方法である。

### 欠点
* インストール作業に手間が掛かる。
	* インストール作業の手間を無視すれば、実質的には欠点は無いと考えられる。

## 結論
* .NET 7 と C# を用いて OS を開発する事は可能である。
* ただし、選択した方法によっては、C/C++ で開発する時よりも多くのコードを書く必要性が生じる場合もある。
* .NET 7 と C# は OS 開発に利用される事が想定されていないという点を注意する必要がある。

## 出典・参考文献
* [コンパイル型言語 - Wikipedia](https://ja.wikipedia.org/wiki/%E3%82%B3%E3%83%B3%E3%83%91%E3%82%A4%E3%83%AB%E5%9E%8B%E8%A8%80%E8%AA%9E)
* [事前コンパイラ - Wikipedia](https://ja.wikipedia.org/wiki/%E4%BA%8B%E5%89%8D%E3%82%B3%E3%83%B3%E3%83%91%E3%82%A4%E3%83%A9)
* [実行時コンパイラ - Wikipedia](https://ja.wikipedia.org/wiki/%E5%AE%9F%E8%A1%8C%E6%99%82%E3%82%B3%E3%83%B3%E3%83%91%E3%82%A4%E3%83%A9)
* [C# 関連のドキュメント - はじめに、チュートリアル、リファレンス。 | Microsoft Learn](https://learn.microsoft.com/dotnet/csharp/)
* [Native AOT deployment overview - .NET | Microsoft Learn](https://learn.microsoft.com/dotnet/core/deploying/native-aot/)
* [dotnet-5.0におけるNativeAOTについて - Qiita](https://qiita.com/skitoy4321/items/2c746446e48672b5c735)
* [dotnet-6.0におけるNativeAOTについて - Qiita](https://qiita.com/yaju/items/d5a771f3f00672aa19ff)
* [zerosharp/efi-no-runtime at master · MichalStrehovsky/zerosharp](https://github.com/MichalStrehovsky/zerosharp/tree/master/efi-no-runtime)
* [COSMOS - COSMOS](https://www.gocosmos.org/)

## 余談
* これまでの記事は敬体で書いていましたが、今回は常体で書きました。そのため少し不安が残ります。
	* 余談はとても個人的な内容になりますので敬体で書きました。
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
