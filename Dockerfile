FROM mcr.microsoft.com/dotnet/core/sdk:3.1
WORKDIR /app

COPY ./src .

RUN dotnet build

EXPOSE 8080

ENTRYPOINT ["dotnet", "run"]