> This is a _training_ project, and code should probably not be used in production.

# qsec-time-service
The aim of this project will be to provide a small component, of a micro-services oriented architecture, that will be able to keep time. All other services in the system will rely on our service to ensure we have the same idea of time, making it critical. 

Despite common sense and logic, we will structure our service following [REST principles](https://codeplanet.io/principles-good-restful-api-design/). 

# Contribution Guidelines 
Contributions are welcome! To make sure we're all productive with this project, here are some basic rules that we've laid out: 

* Look into the issues tab of the project, to get started. We're constantly adding new issues, and makring them with relevant labels. Please prioritize the version currently in development, though.
* Each contribution needs to be recieved through a Pull Request. Make sure you clone the repository. We suggest that you create a _feature branch_ and then merge it when it's done.
* The code you contribute _should_ be covered with unit tests. Those tests will get run automatically when the CI/CD pipeline is established.

# Roadmap

## Version 1.0 [In Development]
* Provide the basic service with:
    * `GET api/time` - returning the current time as a text string
    * `GET api/date` - returning the current date as a text string

See open issues here: https://github.com/avodovnik/qsec-time-service/milestone/1

## Version 2.0 [In Planning]

* We will introduce a bit more complexity, and the service will be abl to _update_ the time and date.
* Initially, we'll only let that live for the duration of the service, but we want to persist the time skew later.

## vNext [Future]
* Service should, at this point, handle scale out scenarios, i.e. working correctly with above requirements even if server runs on many processes and/or many machines.

# Branching Strategy
When we're feature-complete for a single version, we'll create a new branch, called `release/{version}` which will serve as our source of truth for that version. We are following the VSTS strategy for [trunk based deployment](https://docs.microsoft.com/en-gb/azure/devops/repos/git/git-branching-guidance?view=vsts).