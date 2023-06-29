# Synaptic.NET

Synaptic.NET is heavily influenced by Moleculer.
The concept is simple: Break a system into various blocks of micro-services written into specialized processes instead of building flat Http Rest / Grpc APIs.

Not Clear ? Keep following...

## Services

A service is an unit of work, like how you'll represent yourself a micro-service in a SOA.

- A service implements the ISynapticService
- A service is made of *Actions*, *Event Handlers* And *Methods*
- A service can be exposed through a REST Api (but not ideally)

## Actions

- Actions are similar to the concept of *actions* in the MVC model. There are reponsible for processing requests and *returning result* (very important)
- Actions are the public methods of a SynapticService
- Each executing action have a bounded SynapticContext (like an HttpContext) that contains the request data and infos.

## Events Handlers

- Events Handlers are methods that responds to specific events and process them.
- Event Handlers have no return values.
- Event Handlers are essentially the protected methods of a SynapticService.
- Event Handlers can/are decorated with a 'SynapticEventHandler' attribute.
- Event handlers are generic methods of the type of event they process

## Methods

Any others private methods inside a SynapticService cannot be exposed nor accessed from outside that service. They can be used like bare function to better organize things.

---

Un micro-service est décomposé en

-Les Actions peuvent être décorées des attributs [Authorize(Roles, Policy), HttpPost, HttpGet, HttpPut, HttpPatch, HttpDelete]

-Description (propriété)
-Name (prop)
-Version (prop)
-Dependences (spécifie les dépendances sur les services) grâce à l'attribut [SynapticServiceDependency(Name, Version)]

Une SynapticEventHandler est une méthode qui traite d'un event
-est obligatoirement générique (T). T représente le type de l'événement
-retourne obligatoirement void ou Task
-Un objet de type SynapticContext disponible par défaut (recommandé de l'injecter par constructeur)

## Available Features

None

## TODOs

- Make services stateful only for the span of time they are executed in order for their state to be serializable and in some way 'restorable'
- Add Service Discovery based on a topic topology. \
*Le service publie à intervalles de temps réguliers, [sa disponibilité], [son état de santé], [les actions disponibles], [les événements écoutés]

- Add NATS Transport
- Add Grpc Transport

- Add support for a shared configuration center.
- Implement a viable Service Broker.
- Add routing specs
Peut être découpé dans des sous-sujets: *sd.availbility*, *sd.health-checks*, *sd.actions-view*, *sd.events-subs**
- Make
