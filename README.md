# ASP.NET SynchronizationContext Example

## ASP.NET Classic & Core Web API (running full framework)

### Referencing a .NET 4.7.2 async library

| Api Call                                    | Description           | Deadlock Classic?  | Deadlock Core?  |
| ------------------------------------------- |:---------------------:| ------------------:| ---------------:|
| api/values                                  | normal call           |                ❌ |              ❌ |
| api/values/framework/async                  | async/await           |                ❌ |              ❌ |
| api/values/framework/sync?configAwait=false | synchronous blocking  |                ❌ |              ❌ |
| api/values/framework/sync?configAwait=true  | synchronous blocking  |                ✔️ |              ❌ |

### Referencing a .NET Standard async library

| Api Call                                   | Description           | Deadlock Classic?  | Deadlock Core?  |
| ------------------------------------------ |:---------------------:| ------------------:| ---------------:|
| api/values                                 | normal call           |                ❌ |              ❌ |
| api/values/standard/async                  | async/await           |                ❌ |              ❌ |
| api/values/standard/sync?configAwait=false | synchronous blocking  |                ❌ |              ❌ |
| api/values/standard/sync?configAwait=true  | synchronous blocking  |                ✔️ |              ❌ |


Simply, `ConfigureAwait(false)` is not required in an ASP.NET Core application (regardless of whether it's running with the full framework or core). This is because the [SynchronizationContext is not determined by the runtime](https://blog.stephencleary.com/2017/03/aspnetcore-synchronization-context.html#comment-cb00d154-b44b-3ee7-b2b9-d08ccea10531)!
