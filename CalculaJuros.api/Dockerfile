FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

## First let’s build the app and publish it. 
#FROM gcr.io/cloud-builders/csharp/dotnet AS builder
#COPY . /src 
#WORKDIR /src 
#RUN dotnet restore --packages /packages
#RUN dotnet publish -c Release -o /published 
## Now let's build the app's image. 
#FROM gcr.io/google-appengine/aspnetcore:2.2
#COPY --from=builder /published /app 
#ENV ASPNETCORE_URLS=http://*:${PORT} 
#WORKDIR /app 
#ENTRYPOINT [ "dotnet", "CalculaJuros.Api.dll" ]

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