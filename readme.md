# Solution Repository Structure Template

A solution structure template that contains my preferred
analyzers and ReSharper/Rider rules pre-configured.

## Install

Install with

```
dotnew new --install /full/path/folder/content
```

or just run `Install-ToCli.ps1`

To Uninstall just reverse the process:

```
dotnew new --uninstall /full/path/folder/content
```

## Use

```powershell
mkdir MyNewProject
cd MyNewProject
dotnet new repo-sln
```
