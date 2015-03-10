# uWaterloo API - C# Client
---

##About
A client library created in C# that allows users to quickly jump in and start using uWaterloo's OpenData API. 
This will hopefully help create a lower barrier of entry to the API, as users will no longer have to worry about dynamics, WebClients, JSON, etc.

##Where do I get my API key?
https://api.uwaterloo.ca/

##How do I call the correct endpoint?
Simply create a `UWaterlooApi` object and call the methods corresponding to the endpoint paths outlined in https://github.com/uWaterloo/api-documentation

##Usage

```C#
UWaterlooApi myUw = new UWaterlooApi("YOUR-API-KEY");
test.foodservices.menu(); 
```

## Dependencies 
* **Newtonsoft.Json**

## Acknowledgments
* **University of Waterloo**
