#!/bin/bash

container_name=streetcred_origin
container_port=5005
agent_endpoint=52.224.127.162
agent_role=Origin

echo -e "\033[92m* Stopping existing containers\033[0m"

docker container stop $container_name
docker container rm $container_name

echo -e "\033[92m* Building new container: \033[1m$container_name\033[0m"

docker build . -t $container_name \
    --build-arg PORT=$container_port \
    --build-arg ENDPOINT=$agent_endpoint \
    --build-arg ROLE=$agent_role

echo -e "\033[96m* Running $container_name at $agent_endpoint:$container_port as $agent_role\033[0m"   

docker run \
    --detach \
    --publish $container_port:$container_port \
    --name $container_name \
    --volume "$(pwd)"/.indy_client/$container_name/:/root/.indy_client/ \
    $container_name
