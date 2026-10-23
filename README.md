# .NET Linux Lab 1

This application is troubleshooting training material, not a production reference.

## Runtime

Use the .NET 10 SDK and an App Service .NET 10.0 runtime. The deployment template is maintained in [arm-templates-dotnetcore](https://github.com/azureossd/arm-templates-dotnetcore).

Build with:

```sh
dotnet build AppService.Specialist.OSS.NET.1.csproj
```

The home page intentionally creates CPU work and waits before responding. Preserve this behavior when validating runtime or dependency updates.
