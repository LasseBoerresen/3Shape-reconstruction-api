# Application

## Purpose of this layer
The application layer orchestrates the use of the domain for different use cases. Basically, its responsibility is to house all the different behaviors that are needed in the system. 

It does not concern itself with presentation or api specific formats or technical persistence details.

## Main jaw model creation flow

1. Dentist Initiates a new JawModel
   2. Either upper or lower JawPosition 
2. Dentist Adds image(s) to the JawModel
3. Dentist renders the JawModel continuously while scanning. 
4. Dentist saves or discards the model to a patient's profile