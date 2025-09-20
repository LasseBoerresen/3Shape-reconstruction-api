# Api

## Purpose of this architectural layer
The single responsibility of the Api layer, is to be an interface between the client of this library and the application layer, where use cases and business logic are actually executed. 

It should translate from whatever format is most useful or convenient for the client, into the format that is most useful and elegant for the application, because those do not always align. Especially since we want the application to be stable, yet client interface needs may vary independent of the core behavior of the system.  