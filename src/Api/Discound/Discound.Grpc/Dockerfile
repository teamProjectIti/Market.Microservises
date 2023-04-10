#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["src/Api/Discound/Discound.Grpc/Discound.Grpc.csproj", "src/Api/Discound/Discound.Grpc/"]
RUN dotnet restore "src/Api/Discound/Discound.Grpc/Discound.Grpc.csproj"
COPY . .
WORKDIR "/src/src/Api/Discound/Discound.Grpc"
RUN dotnet build "Discound.Grpc.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Discound.Grpc.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Discound.Grpc.dll"]