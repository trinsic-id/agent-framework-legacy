# Agent Framework

## .NET Core based library for building modular agent services

The Agent Framework in this repo is a proof of concept for building modular and extensible agent services for the Hyperledger Indy platform. The solution provides a docker compose file that runs a node, service and a client consuming the web service.

In order to run the sample make sure you have Docker Composer installed and no other indy nodes are running. Simply clone the repo and run:

```bash
 docker-compose up
```

The sample demonstrates establishing connection by requesting a challenge, generating schema, credential definition and credential offer. The output of each container will be logged in the console.

### Framework Features

* [Message driven architecture with Protocol Buffers](#message-based-approach-using-protocol-buffers)
* [Message handler extensions](#message-handler-interface)
* [Identity Context](#identity-context)

---

#### Message based approach using protocol buffers

Protocol Buffers offers extensible and strongly typed message definition for the agent framework. The choice to use protocol buffers is based on several factors, including availability and extensibility. Protobuf offers message generation tool for most languages. This makes it very easy to work with any language, while maintaining a separate message definition. Protobufs is also protocol agnostic. It allows for easy communication over HTTP (ex: RESTful API's), message queues (ex: ZMQ), named pipes, sockets, etc. Hyperledger Sawtooth project uses protobufs for validator communication.
This allows an agent to publish multiple endpoints of communication, while having a central message processing module.
In addition, it simplifes having to rely on a standardized API endpoints for each message.

Agent messages are defined in a `.proto` files. Here's a message from `credential.proto` file:

```proto
message CredentialRequest {
    string credential_offer_json = 1;
    string credential_request_json = 2;
    string credential_values_json = 3;
}
```

#### Message wrappers using `Any` type

Before being sent for communication, each message is wrapped into `Any` message. This allows the agent service to define custom application specific messages that the agent can process.
`Any` message is a well known protobuf type that all libraries can use to pack and upack messages.
Each Any message can be identified by the type it uses and routed to the appropriate message handler.

Unserialized `Any` message looks like this:

```json
{
    "@type": "indy:agent:message/CredentialRequest"
    "@value": "[binary message data]"
}
```

Agents can optionally wrap this message into another message to indicate the type of encryption used or attach signatures to the message. For example, an approach used in this framework is to define two types that could be used to wrap the messages.

```proto
message SecureMessage {
    bytes content = 1;
    bytes signature = 2;
    MessageType type = 3;
}

message UnsecureMessage {
    google.protobuf.Any content = 1;
    bytes signature = 2;
}

enum MessageType {
    AUTH_CRYPT = 0;
    ANON_CRYPT = 1;
}
```

In the case of `SecureMessage`, the message is encryped into the `content` property and optionally signed. `UnsecureMessage` can be used in trusted networks or over protocols that don't carry sensitive data. For example, a web socket interface could use UnsecureMessage to request connection or authentication challenge that would be presented to the user.

##### Generating protobuf messages

To generate messages for the desired platform, download the [protobuf compiler](https://github.com/google/protobuf). There's a script you can run under `bin/generate-protos.sh` which generates files for C#, Swift and JavaScript.
Please refer to the protobuf documentation for installation instructions and message generation for your platform and language.

#### Message handler interface

Endpoints can be configured to support any number of messages. This is achieved using a collection of handlers, each conforming to the `IHandler` interface.

```csharp
public interface IHandler
{
    string[] SupportedMessageTypes();

    Task<Any> HandleMessage(Any msg, IdentityContext context);
}
```

Implementations of this interface can specify the resolvable `Any` type that they support for each message. These can be agent messages or application specific messages. Each message can be defined in it's own namespace (prefix).

The agent framework provides a number of extensions that define predefined sets of supported messages, based on an agent role, i.e. Issuer, Verifier, Edge Agent, etc.

#### Identity Context

The `IdentityContext` class is essential in establishing the identity relationship for the request. The controller should be able to determine which local DID's this message is intended to and, if possible, what the requesting DID/VK are. Some message handlers may require the requesting identity. This context is a way for the service to communicate identity info with the message handlers.

### Setting up a development environment

The current version of the framework uses the stable 1.4 version of libindy. In order to install it locally, checkout the 1.4 release tag of the hyperledger/indy-sdk. The reason for using this version is that the dotnet wrappers are not yet updated to the master version.

* Clone the 1.4 release tag of libindy 
  * `git clone https://github.com/hyperledger/indy-sdk.git`
  * `git checkout tags/1.4.0`
  * Build indy sdk using `cargo build` and copy the generated libraries to `/usr/local/lib`. This is required for the dotnet wrapper to work
* Clone this repository
  * `git clone https://github.com/streetcrednyc/agent-framework.git`
* Run a local indy node using docker
  * `docker build -f docker/indy-pool.dockerfile -t indy_pool .`
  * `docker run -itd -p 9701-9709:9701-9709 indy_pool`

Depending on your choice of editor, you can open and run the `AgentFramework.sln` file. There is a configuration named `Service+Client` that runs both the Service and the Client project at the same time. The Client project is set to delay execution after 15 sec. This is to allow the web service to initialize before it can start processing messages.

Note: the Service project currently is not configured to delete wallet and pool config on each run. You can always delete `~/.indy_client` directory to reset the state on your local machine.
