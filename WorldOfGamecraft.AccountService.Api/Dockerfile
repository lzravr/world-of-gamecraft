#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["WorldOfGamecraft.AccountService.Api/WorldOfGamecraft.AccountService.Api.csproj", "WorldOfGamecraft.AccountService.Api/"]
COPY ["WorldOfGamecraft.AccountService.Application/WorldOfGamecraft.AccountService.Application.csproj", "WorldOfGamecraft.AccountService.Application/"]
COPY ["WorldOfGamecraft.AccountService.Domain/WorldOfGamecraft.AccountService.Domain.csproj", "WorldOfGamecraft.AccountService.Domain/"]
COPY ["WorldOfGamecraft.AccountService.Infrastructure/WorldOfGamecraft.AccountService.Infrastructure.csproj", "WorldOfGamecraft.AccountService.Infrastructure/"]
RUN dotnet restore "./WorldOfGamecraft.AccountService.Api/WorldOfGamecraft.AccountService.Api.csproj"
COPY . .
WORKDIR "/src/WorldOfGamecraft.AccountService.Api"
RUN dotnet build "./WorldOfGamecraft.AccountService.Api.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./WorldOfGamecraft.AccountService.Api.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "WorldOfGamecraft.AccountService.Api.dll"]