# Play.Common

Common libraries used by Play Economy services.

## Create and publish package

MacOS 

```shell
version='1.0.6'
owner='iga1dotnetmicroservices'
dotnet pack src/Play.Common --configuration Release -p:PackageVersion=$version -p:RepositoryUrl=https://github.com/$owner/play.common.git -o ../packages
```
Windows Powershell

```powershell
$version='1.0.6'
$owner='iga1dotnetmicroservices'
dotnet pack src/Play.Common --configuration Release -p:PackageVersion=$version -p:RepositoryUrl=https://github.com/$owner/play.common.git -o ../packages
```