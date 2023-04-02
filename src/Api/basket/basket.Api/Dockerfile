#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["src/Api/basket/basket.Api/basket.Api.csproj", "src/Api/basket/basket.Api/"]
RUN dotnet restore "src/Api/basket/basket.Api/basket.Api.csproj"
COPY . .
WORKDIR "/src/src/Api/basket/basket.Api"
RUN dotnet build "basket.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "basket.Api.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "basket.Api.dll"]