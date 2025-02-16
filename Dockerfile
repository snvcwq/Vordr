FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS base
USER $APP_UID
WORKDIR /app
EXPOSE 4074

FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY Directory.Build.props ./
COPY Directory.Packages.props ./
COPY ["src/core/Web/Web.csproj", "src/core/Web/"]
COPY ["src/core/Application/Application.csproj", "src/core/Application/"]
COPY ["src/core/Domain/Domain.csproj", "src/core/Domain/"]
COPY ["src/core/Infrastructure/Infrastructure.csproj", "src/core/Infrastructure/"]
COPY ["src/monitoring/ResourcesMonitoring.Windows/ResourcesMonitoring.Windows.csproj", "src/monitoring/ResourcesMonitoring.Windows/"]
COPY ["src/core/ServiceDefaults/ServiceDefaults.csproj", "src/core/ServiceDefaults/"]
RUN dotnet restore "src/core/Web/Web.csproj"
COPY . . 
WORKDIR "/src/src/core/Web"
RUN dotnet build "Web.csproj" -c Release -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "Web.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENV ASPNETCORE_ENVIRONMENT=Development
ENTRYPOINT ["dotnet", "Vordr.Web.dll"]
