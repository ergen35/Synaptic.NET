# Synaptic.NET

Le projet est basé sur Moleculer

Le concept est simple: décomposer un système en micro-services écrits dans des containers
spécialisés plutôt que des Api Rest, Grpc ou Websocket brutes

Un micro-service implémente l'interface [ISynapticService]
Un micro-service est décomposé en
-Actions (handler de requêtes) désignent toutes les méthodes publiques d'un SynapticService
-Les Actions peuvent être décorées des attributs [Authorize(Roles, Policy), HttpPost, HttpGet, HttpPut, HttpPatch, HttpDelete]
-EventHandlers / EventProcessors décorées à l'aide de l'attribut [SynapticEventHandler]
-Methodes (au sens OO) qui sont les méthodes privées d'un SynapticService
-Description (propriété)
-Name (prop)
-Version (prop)
-Dependences (spécifie les dépendances sur les services) grâce à l'attribut [SynapticServiceDependency(Name, Version)]

Une SynapticAction est une méthode, elle peut retourner n'importe quel objet ex: un poco, etc
une SynapticAction qui retourne void est une FiniteEvaluator. Elle noie/termine une requête.
retourne une NoContentResult avec le code http correspondant.

Une SynapticAction Accepte des paramétres comme toute Action d'un controlleur MVC.
-Un objet de type ISynapticContext disponible par défaut (recommandé de l'injecter par constructeur)
-Si ajouté aux paramètres d'une action décorée avec l'attribut [SynapticAction], Synaptic.NET se chargera de l'injecter

Uen SynapticEventHandler est une méthode qui traite d'un event
-est obligatoirement générique (T). T représente le type de l'événement
-retourne obligatoirement void ou Task
-Un objet de type SynapticContext disponible par défaut (recommandé de l'injecter par constructeur)

[Version 2: Services are Stateful and State can be serialized]

## Technique

-Liste des sujets-:

-"service-discovery": Pour la découverte de services:
C'est un "subject" auquel souscrit n'importe quel service qui active sa découverte réseau.
Le service publie à intervalles de temps réguliers, [sa disponibilité], [son état de santé], [les actions disponibles], [les événements écoutés]
Peut être découpé dans des sous-sujets: *sd.availbility*, *sd.health-checks*, *sd.actions-view*, *sd.events-subs*

-""