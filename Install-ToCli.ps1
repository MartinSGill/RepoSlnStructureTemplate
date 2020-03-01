$path = (Get-ChildItem $PSScriptRoot -Filter "content").FullName
dotnet new --install "$path"
