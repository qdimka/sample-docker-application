FROM microsoft/dotnet:2.2-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 8082
EXPOSE 443

FROM microsoft/dotnet:2.2-sdk AS build
WORKDIR /src
COPY ./Sample.DockerApplication .
RUN dotnet restore 
RUN dotnet build -c Release -o /app

FROM build AS publish
RUN dotnet publish -c Release -o /app

FROM base AS final
WORKDIR /app
ENV ASPNETCORE_URLS="http://*:8082"
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Sample.DockerApplication.Web.dll"]