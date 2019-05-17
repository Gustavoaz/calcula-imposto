FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["CalculaJuros.api/CalculaJuros.Api.csproj", "CalculaJuros.api/"]
RUN dotnet restore "CalculaJuros.api/CalculaJuros.Api.csproj"
COPY . .
WORKDIR "/src/CalculaJuros.api"
RUN dotnet build "CalculaJuros.Api.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "CalculaJuros.Api.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "CalculaJuros.Api.dll"]