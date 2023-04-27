# AppSettingsDemo

This is a .Net razor page that demonstrates how to load appsettings at run-time.

To demo run the following from the Visual Studio command line.

```
C:\Users\JCK0412\demo\AppSettingsDemo\BasicDemo>set ASPNETCORE_ENVIRONMENT=Staging
C:\Users\JCK0412\demo\AppSettingsDemo\BasicDemo>dotnet run
```
point your browswer to localhost:5000
you should see the following at the top of the page:

Environment: Staging

=====================================================

Close that session, Ctrl-C and run these commands
```
C:\Users\JCK0412\demo\AppSettingsDemo\BasicDemo>set ASPNETCORE_ENVIRONMENT=Production
C:\Users\JCK0412\demo\AppSettingsDemo\BasicDemo>dotnet run
```

point your browswer to localhost:5000
you should see the following at the top of the page:

Environment: Production
