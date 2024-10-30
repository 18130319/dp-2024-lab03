FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

WORKDIR /src
COPY src ./

RUN dotnet restore /src/DecoratorLab3

RUN dotnet test /src/TestDecoratorLab3

WORKDIR /src/DecoratorLab3
RUN dotnet publish -c Release -o out

ENTRYPOINT ["dotnet", "/src/DecoratorLab3/out/DecoratorLab3.dll"]