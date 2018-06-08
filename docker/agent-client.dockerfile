FROM streetcred/dotnet-indy

WORKDIR /app

ADD . /app

WORKDIR /app/src/Example/Client

RUN dotnet restore

ENV ASPNETCORE_ENVIRONMENT "Production"

CMD [ "dotnet", "run" ]
