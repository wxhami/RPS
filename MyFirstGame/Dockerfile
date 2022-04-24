FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["MyFirstGame/MyFirstGame.csproj", "MyFirstGame/"]
RUN dotnet restore "MyFirstGame/MyFirstGame.csproj"
COPY . .
WORKDIR "/src/MyFirstGame"
RUN dotnet build "MyFirstGame.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MyFirstGame.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MyFirstGame.dll"]
