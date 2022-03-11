#TweetAPI
Add appsettings.json
Example:
```
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "ConnectionStrings": {
    "ApplicationDbContext": "Server=.;Database=tweet-db;Trusted_Connection=false;MultipleActiveResultSets=true;user id=sa;pwd=password;"
  }
}
```