# image
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

#  SDK
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["Diji.csproj", "./"]
RUN dotnet restore "Diji.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "Diji.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Diji.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DijiBackend.dll"]

### NETWORK EKLENECEK !!! 
### POrtlar HTPPS sorunu cozulecek
## source code temizlenecek
### volume tasinacak