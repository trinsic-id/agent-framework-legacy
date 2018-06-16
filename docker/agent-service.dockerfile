FROM streetcred/dotnet-indy

ARG ip=127.0.0.1
ARG port=5000
ARG aspnet_env=Production

WORKDIR /app

ADD . /app

WORKDIR /app/src/Example/Service

RUN dotnet restore

EXPOSE ${port}/tcp

ENV AGENT_ENDPOINT=${ip}:${port}
ENV ASPNETCORE_URLS http://*:${port}
ENV ASPNETCORE_ENVIRONMENT ${aspnet_env}

CMD [ "dotnet", "run", "--server.urls", "http://*:${port}" ]
