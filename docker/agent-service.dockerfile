FROM streetcred/dotnet-indy

ARG ip=127.0.0.1
ARG port=5000

WORKDIR /app

ADD . /app

WORKDIR /app/src/Example/Service

RUN dotnet restore

EXPOSE ${port}/tcp

ENV AGENT_ENDPOINT=${ip}:${port}
ENV ASPNETCORE_URLS http://*:${port}
ENV ASPNETCORE_ENVIRONMENT "Production"

CMD [ "dotnet", "run", "--server.urls", "http://*:${port}" ]
