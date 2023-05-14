FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["src/Commo.Id.WebHost/Commo.Id.WebHost.csproj", "src/Commo.Id.WebHost/"]
RUN dotnet restore "src/Commo.Id.WebHost/Commo.Id.WebHost.csproj"
COPY . .
WORKDIR "/src/src/Commo.Id.WebHost"
RUN dotnet build "Commo.Id.WebHost.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Commo.Id.WebHost.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Commo.Id.WebHost.dll"]
