* ## Test user-secrets dotnet command
```
$> dotnet user-secrets set ConnectionStrings:DataAccessProvider "server=local
host;userid=root;password=root;database=test;"
```

* ## Test ef migrations
```
$> dotnet ef migrations add 001-initial

$> dotnet ef database update
```