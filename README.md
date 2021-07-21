# Workfall-Restaurant

it consists of 2 main components 
-Frontend 
  +SPA using angular template in VS 2019 for ease of deploying it to azure
-Backend 
  I follow the microservices architecture, so each compnetent ill have it's own api and entity like the example of the order

  +.net core api for the interface
  +class library for order entites 
 
 I also finished it first using database cosmos db till i get the note that no db needed so i swithced it to saving the data in session whihc is presisted for 10 min
  
For running the application, please make sure that the solution set to run multiple apps - api & spa - 
