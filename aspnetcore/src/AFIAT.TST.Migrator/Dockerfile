#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["src/AFIAT.TST.Migrator/AFIAT.TST.Migrator.csproj", "src/AFIAT.TST.Migrator/"]
COPY ["src/AFIAT.TST.EntityFrameworkCore/AFIAT.TST.EntityFrameworkCore.csproj", "src/AFIAT.TST.EntityFrameworkCore/"]
COPY ["src/AFIAT.TST.Core/AFIAT.TST.Core.csproj", "src/AFIAT.TST.Core/"]
COPY ["src/AFIAT.TST.Core.Shared/AFIAT.TST.Core.Shared.csproj", "src/AFIAT.TST.Core.Shared/"]
RUN dotnet restore "src/AFIAT.TST.Migrator/AFIAT.TST.Migrator.csproj"
COPY . .
WORKDIR "/src/src/AFIAT.TST.Migrator"
RUN dotnet build "AFIAT.TST.Migrator.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "AFIAT.TST.Migrator.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "AFIAT.TST.Migrator.dll"]
