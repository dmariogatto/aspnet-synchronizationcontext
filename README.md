# ASP.NET SynchronizationContext Example

## ASP.NET Classic & Core Web API (running full framework)

### Referencing a .NET 4.7.2 async library

| Api Call                              | Description           | Deadlock Classic?  | Deadlock Core?  |
| ------------------------------------- |:---------------------:| ------------------:| ---------------:|
| api/valuesfull                        | normal call           |                ❌ |              ❌ |
| api/valuesfull/async                  | async/await           |                ❌ |              ❌ |
| api/valuesfull/sync?configAwait=false | synchronous blocking  |                ❌ |              ❌ |
| api/valuesfull/sync?configAwait=true  | synchronous blocking  |                ✔️ |              ❌ |

### Referencing a .NET Standard async library

| Api Call                                  | Description           | Deadlock Classic?  | Deadlock Core?  |
| ----------------------------------------- |:---------------------:| ------------------:| ---------------:|
| api/valuesstandard                        | normal call           |                ❌ |              ❌ |
| api/valuesstandard/async                  | async/await           |                ❌ |              ❌ |
| api/valuesstandard/sync?configAwait=false | synchronous blocking  |                ❌ |              ❌ |
| api/valuesstandard/sync?configAwait=true  | synchronous blocking  |                ✔️ |              ❌ |
