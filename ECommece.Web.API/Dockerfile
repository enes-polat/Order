#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim AS build
WORKDIR /src
COPY ["ECommece.Web.API/ECommece.Web.API.csproj", "ECommece.Web.API/"]
#COPY ["ECommerce.Service/ECommerce.Service.csproj", "ECommerce.Service/"]
#COPY ["ECommerce.Entities/ECommerce.Entities.csproj", "ECommerce.Entities/"]
#COPY ["ECommerce.Core/ECommerce.Core.csproj", "ECommerce.Core/"]
#COPY ["ECommerce.Data/ECommerce.Data.csproj", "ECommerce.Data/"]
RUN dotnet restore "ECommece.Web.API/ECommece.Web.API.csproj"
COPY . .
WORKDIR "/src/ECommece.Web.API"
RUN dotnet build "ECommece.Web.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ECommece.Web.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ECommece.Web.API.dll"]