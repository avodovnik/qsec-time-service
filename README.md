> This is a _training_ project, and code should probably not be used in production.

# qsec-time-service
The aim of this project will be to provide a small component, of a micro-services oriented architecture, that will be able to keep time. All other services in the system will rely on our service to ensure we have the same idea of time, making it critical. 

Despite common sense and logic, we will structure our service following [REST principles](https://codeplanet.io/principles-good-restful-api-design/). 

# Contribution Guidelines 

# Roadmap

## Version 1.0 [In Development]
* Provide the basic service with:
    * `GET api/time` - returning the current time as a text string
    * `GET api/date` - returning the current date as a text string

## Version 2.0 [In Planning]

* We will introduce a bit more complexity, and the service will be abl to _update_ the time and date.
* Initially, we'll only let that live for the duration of the service, but we want to persist the time skew later.

## vNext [Future]
* Service should, at this point, handle scale out scenarios, i.e. working correctly with above requirements even if server runs on many processes and/or many machines.