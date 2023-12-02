$path = (Get-ChildItem $PSScriptRoot -Filter "content").FullName
dotnet new uninstall $path
dotnet new install $path
