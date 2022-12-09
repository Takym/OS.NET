# OS.NET
Copyright (C) 2022 Takym.

## 概要
C# と .NET を用いて UEFI アプリケーションを開発する。
このライブラリ群は「[自作OS Advent Calendar 2022](https://adventar.org/calendars/8392)」に向けて制作した。

## 命名について
* 最初は DotNetOS (略称は DNOS) にしようと思ったが、既に使われていた為、OS.NET にした。
* <https://dotnetos.org/>

## 利用ライブラリ
* <https://www.nuget.org/packages/Microsoft.DotNet.ILCompiler/>

## 参考文献
* <https://learn.microsoft.com/dotnet/core/deploying/native-aot/>
* <https://github.com/MichalStrehovsky/zerosharp/tree/master/efi-no-runtime>
* <https://uefi.org/specs/UEFI/2.10/>
* <https://github.com/tianocore/edk2/tree/edk2-stable202211>
