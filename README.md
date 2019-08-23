# ASP.NET SynchronizationContext Example

## ASP.NET Classic Web API

### Referencing a .NET 4.7.2 async library

| Api Call                              | Description           | Deadlock?  |
| ------------------------------------- |:---------------------:| ----------:|
| api/valuesfull                        | normal call           |        [ ] |
| api/valuesfull/async                  | async/await           |        [ ] |
| api/valuesfull/sync?configAwait=false | synchronous blocking  |        [ ] |
| api/valuesfull/sync?configAwait=true  | synchronous blocking  |        [X] |

### Referencing a .NET Standard async library

| Api Call                                  | Description           | Deadlock?  |
| ----------------------------------------- |:---------------------:| ----------:|
| api/valuesstandard                        | normal call           |        [ ] |
| api/valuesstandard/async                  | async/await           |        [ ] |
| api/valuesstandard/sync?configAwait=false | synchronous blocking  |        [ ] |
| api/valuesstandard/sync?configAwait=true  | synchronous blocking  |        [X] |

## ASP.NET Core Web API (running full framework)

### Referencing a .NET 4.7.2 async library

| Api Call                              | Description           | Deadlock?  |
| ------------------------------------- |:---------------------:| ----------:|
| api/valuesfull                        | normal call           |        [ ] |
| api/valuesfull/async                  | async/await           |        [ ] |
| api/valuesfull/sync?configAwait=false | synchronous blocking  |        [ ] |
| api/valuesfull/sync?configAwait=true  | synchronous blocking  |        [ ] |

### Referencing a .NET Standard async library

| Api Call                                  | Description           | Deadlock?  |
| ----------------------------------------- |:---------------------:| ----------:|
| api/valuesstandard                        | normal call           |        [ ] |
| api/valuesstandard/async                  | async/await           |        [ ] |
| api/valuesstandard/sync?configAwait=false | synchronous blocking  |        [ ] |
| api/valuesstandard/sync?configAwait=true  | synchronous blocking  |        [ ] |
