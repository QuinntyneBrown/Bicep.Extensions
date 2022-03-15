dotnet tool uninstall -g Bicep.Extensions.Cli
dotnet pack
dotnet tool install --global --add-source ./nupkg Bicep.Extensions.Cli
