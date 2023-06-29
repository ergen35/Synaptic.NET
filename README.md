# Synaptic.NET

Synaptic.NET is heavily influenced by Moleculer.
The concept is simple: Break a system into various blocks of micro-services written into specialized processes instead of building flat Http Rest / Grpc APIs.

Not Clear ? Keep following...

## Services

A service is an unit of work, like how you'll represent yourself a micro-service in a SOA.

- A service implements the **ISynapticService**
- A service is made of **Actions**, **Event Handlers** And **Methods**
- A service can be exposed through a REST Api (but not ideally)

## Actions

- Actions are similar to the concept of *actions* in the MVC model. There are reponsible for processing requests and **returning result** (very important)
- Actions are the public methods of a SynapticService
- Each executing action have a bounded SynapticContext (like an HttpContext) that contains the request data and infos.

## Events Handlers

- Events Handlers are methods that responds to specific events and process them.
- Event Handlers have **no return values**
- Event Handlers are essentially the protected methods of a SynapticService.
- Event Handlers can/are decorated with a 'SynapticEventHandler' attribute.
- Event handlers are generic methods of the type of event they process

## Methods

Any others private methods inside a SynapticService cannot be exposed nor accessed from outside that service. They can be used like bare function to better organize things.

---

## Available Features

None

## TODOs

### Advanced

- Add NATS Transport
- Make services stateful only for the span of time they are executed in order for their state to be serializable and in some way 'restorable'

### Timeline

- Cleanup APIs
- Build samples and use cases
- Build client for various langages (JS/TS, Kotlin, Java, Golang, Python, etc.)
- Provide some guides for integrating with load balancers
- Integrate the REST Facade with Traefik
- Integrate the REST Facade with YARP
- Make services and actions exposable to the REST Facade
- Add the REST Facade
- Start Writing a wiki for Synaptic.NET
- Add a client for making requests to services
- Conform to security specs
<!-- - Expose ways to define custom authentication and authorization -->
- Add Support for JwtBearer authentication
- Add support for Authentication (use aspnetcore)
- Add support for Authorization via the AuthorizeAttribute  (use aspnetcore)
- Add support for the NonActionAttribute
- Add support for services dependencies via the SynapticServiceDependenciesAttribute.
- Add automated performance benchmarking
- Add various utilities to ease services building
- Finish service discovery
- Add Grpc Transport
- Add Transports
- Add support for Service Discovery (based on a topics topology)  
    Each service publish at regular time interval, it health status, available actions and listened events.
- Add support for IActionResult, ActionResult or a similar concept to wrap Action's Response
- Add Specialized Exceptions
- Add custom errors System
- Add Model Binding for databound actions/events
- Add support for a shared configuration center.
- Add routing specs  
    (*sd.availbility*, *sd.health-checks*, *sd.actions-view*, *sd.events-subs**)
- Implement a viable Service Broker
- Add Services/Actions activator
- Add Event Resolvers
- Add Actions Resolvers
- Add Synaptic.NET and associated types to the AspnetCore dependencies container
- Add Automated testing
- Add building workflow
- Define Project's Licence
- Define Issues handling process
- Define contributing Guide
