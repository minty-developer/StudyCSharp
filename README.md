> C# Study 실습 파일들

## 준비해야 할 것들
1. [https://dotnet.microsoft.com](https://dotnet.microsoft.com)에 들어가서 .NET SDK 다운 받기
2. PowerShell에 다음 입력하기
```PowerShell
dotnet --version
dotnet --list-sdks
```
> 모두 잘 뜨면 성공
3. 원하는 곳에 폴더 만들고 PowerShell 켜기
```PowerShell
cd ./폴더_주소
git clone https://github.com/minty-developer/StudyCSharp.git
cd ./Start
.\restore
```

## 실행 방법
- 메크로 실행
```PowerShell
.\실행할_코드_번호
```
(ex: .\1)

- 직접 실행
```PowerShell
cd ../실행할_코드_폴더
dotnet run
```