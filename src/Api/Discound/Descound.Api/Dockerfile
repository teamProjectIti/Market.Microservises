#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["src/Api/Discound/Descound.Api/Descound.Api.csproj", "src/Api/Discound/Descound.Api/"]
RUN dotnet restore "src/Api/Discound/Descound.Api/Descound.Api.csproj"
COPY . .
WORKDIR "/src/src/Api/Discound/Descound.Api"
RUN dotnet build "Descound.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Descound.Api.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Descound.Api.dll"]