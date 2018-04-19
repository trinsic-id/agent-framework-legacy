FROM streetcred/dotnet-indy

ARG PORT
ARG ENDPOINT
ARG ROLE

WORKDIR /app

ADD . /app

WORKDIR /app/src

RUN dotnet restore

EXPOSE ${PORT}/tcp

ENV ASPNETCORE_URLS http://*:${PORT}
ENV AGENT_ENDPOINT ${ENDPOINT}:${PORT}
ENV ASPNETCORE_ENVIRONMENT ${ROLE}

CMD [ "dotnet", "run", "--project", "AgentService" ]
