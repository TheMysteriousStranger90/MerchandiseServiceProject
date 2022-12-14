FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build

WORKDIR /src

COPY ["MerchandiseServiceWebAPI/MerchandiseServiceWebAPI.csproj", "MerchandiseServiceWebAPI/"]
RUN dotnet restore "MerchandiseServiceWebAPI/MerchandiseServiceWebAPI.csproj"

COPY . .
WORKDIR "/src/MerchandiseServiceWebAPI"
RUN dotnet build "MerchandiseServiceWebAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MerchandiseServiceWebAPI.csproj" -c Release -o /app/publish

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS runtime

WORKDIR /app

EXPOSE 80
EXPOSE 443

FROM runtime AS final
WORKDIR /app

COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MerchandiseServiceWebAPI.dll"]
