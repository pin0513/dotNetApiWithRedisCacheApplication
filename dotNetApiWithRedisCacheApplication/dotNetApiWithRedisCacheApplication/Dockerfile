FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["dotNetApiWithRedisCacheApplication/dotNetApiWithRedisCacheApplication.csproj", "dotNetApiWithRedisCacheApplication/"]
RUN dotnet restore "dotNetApiWithRedisCacheApplication/dotNetApiWithRedisCacheApplication.csproj"
COPY . .
WORKDIR "/src/dotNetApiWithRedisCacheApplication"
RUN dotnet build "dotNetApiWithRedisCacheApplication.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "dotNetApiWithRedisCacheApplication.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "dotNetApiWithRedisCacheApplication.dll"]
