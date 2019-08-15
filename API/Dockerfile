FROM mcr.microsoft.com/dotnet/core/sdk:2.2 AS builder
WORKDIR /sources

COPY *.fsproj .
RUN dotnet restore

COPY . .
RUN dotnet publish --output /app/ --configuration Release

FROM mcr.microsoft.com/dotnet/core/aspnet:2.2
WORKDIR /app
COPY --from=builder /app .
CMD ["dotnet", "API.dll"]