FROM microsoft/dotnet:2.2-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.2-sdk AS build
WORKDIR /src
COPY ["Sample.DockerApplication.Web/Sample.DockerApplication.Web.csproj", "Sample.DockerApplication.Web/"]
COPY ["Sample.DockerApplication.Dal/Sample.DockerApplication.Dal.csproj", "Sample.DockerApplication.Dal/"]
RUN dotnet restore "Sample.DockerApplication.Web/Sample.DockerApplication.Web.csproj"
COPY . .
WORKDIR "/src/Sample.DockerApplication.Web"
RUN dotnet build "Sample.DockerApplication.Web.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Sample.DockerApplication.Web.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Sample.DockerApplication.Web.dll"]