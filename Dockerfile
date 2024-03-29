#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src

COPY ["CaducaRest/CaducaRest.csproj", "CaducaRest/"]

RUN dotnet restore "CaducaRest/CaducaRest.csproj"

COPY . .
WORKDIR "/src/CaducaRest"
RUN dotnet build "CaducaRest.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "CaducaRest.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
CMD ["dotnet", "CaducaRest.dll"]
