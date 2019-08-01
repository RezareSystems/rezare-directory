FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["src/presentation/Rezare.rSite.Api/Rezare.rSite.Api.csproj", "src/presentation/Rezare.rSite.Api/"]
COPY ["src/infrastructure/Rezare.rSite.Persistence/Rezare.rSite.Persistence.csproj", "src/infrastructure/Rezare.rSite.Persistence/"]
COPY ["src/core/Rezare.rSite.Application/Rezare.rSite.Application.csproj", "src/core/Rezare.rSite.Application/"]
COPY ["src/core/Rezare.rSite.Domain/Rezare.rSite.Domain.csproj", "src/core/Rezare.rSite.Domain/"]
RUN dotnet restore "src/presentation/Rezare.rSite.Api/Rezare.rSite.Api.csproj"
COPY . .
WORKDIR "/src/src/presentation/Rezare.rSite.Api"
RUN dotnet build "Rezare.rSite.Api.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Rezare.rSite.Api.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Rezare.rSite.Api.dll"]