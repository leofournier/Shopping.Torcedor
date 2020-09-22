#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:2.1-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:2.1-stretch AS build
WORKDIR /src
COPY ["Shopping.Torcedor/Shopping.Torcedor.csproj", "Shopping.Torcedor/"]
RUN dotnet restore "Shopping.Torcedor/Shopping.Torcedor.csproj"
COPY . .
WORKDIR "/src/Shopping.Torcedor"
RUN dotnet build "Shopping.Torcedor.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Shopping.Torcedor.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Shopping.Torcedor.dll"]
