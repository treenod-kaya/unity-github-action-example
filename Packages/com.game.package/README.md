# 패키지에 대한 설명

개발자 패키지 문서입니다. 이러한 문서는 일반적으로 개발자가 패키지를 수정하거나 패키지 마스터 소스 저장소에 새로운 변경 사항을 적용할 때 참조하면 도움이 됩니다.

- https://docs.unity3d.com/kr/2019.4/Manual/cus-layout.html


패키지 기본 레이아웃
```
<root>
  ├── package.json
  ├── README.md
  ├── CHANGELOG.md
  ├── LICENSE.md
  ├── Editor
  │   ├── Unity.[YourPackageName].Editor.asmdef
  │   └── EditorExample.cs
  ├── Runtime
  │   ├── Unity.[YourPackageName].asmdef
  │   └── RuntimeExample.cs
  ├── Tests
  │   ├── Editor
  │   │   ├── Unity.[YourPackageName].Editor.Tests.asmdef
  │   │   └── EditorExampleTest.cs
  │   └── Runtime
  │        ├── Unity.[YourPackageName].Tests.asmdef
  │        └── RuntimeExampleTest.cs
  └── Documentation~
       └── [YourPackageName].md
```