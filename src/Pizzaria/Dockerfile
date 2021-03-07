#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app


FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Pizzaria.WebAPI/Pizzaria.WebAPI.csproj", "Pizzaria.WebAPI/"]
COPY ["Pizzaria.Core.API/Pizzaria.Core.API.csproj", "Pizzaria.Core.API/"]
COPY ["Pizzaria.Domain/Pizzaria.Domain.csproj", "Pizzaria.Domain/"]
COPY ["Pizzaria.Core.Domain/Pizzaria.Core.Domain.csproj", "Pizzaria.Core.Domain/"]
COPY ["Pizzaria.Infra.Data/Pizzaria.Infra.Data.csproj", "Pizzaria.Infra.Data/"]
COPY ["Pizzaria.Infra.CrossCutting.IoC/Pizzaria.Infra.CrossCutting.IoC.csproj", "Pizzaria.Infra.CrossCutting.IoC/"]
RUN dotnet restore "Pizzaria.WebAPI/Pizzaria.WebAPI.csproj"
COPY . .
WORKDIR "/src/Pizzaria.WebAPI"
RUN dotnet build "Pizzaria.WebAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Pizzaria.WebAPI.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .

RUN useradd -m myappuser
USER myappuser

CMD ASPNETCORE_URLS=http://*:$PORT dotnet Pizzaria.WebAPI.dll 