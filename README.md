# TATNet Template Pack

As a C# developer, I developed many applications with the C# 7.3 version. After updating the C# 8.0 and continuing updates, I've felt uneasy about not being able to use my development experience and skills with new C# versions.

## Installation

There are two different installation methods for the template package source.

### 1. With Nuget Config File

```xml
<?xml version="1.0" encoding="utf-8"?>
<configuration>
  <packageSources>
    <clear />
    <add key="nuget" value="https://api.nuget.org/v3/index.json" />
    <add key="github" value="https://nuget.pkg.github.com/fatihtatoglu/index.json" />
  </packageSources>
</configuration>
```

### 2. With CLI

```bash
dotnet nuget add source --name "github" https://nuget.pkg.github.com/fatihtatoglu/index.json
```

After adding the NuGet Source for the template, to install the template package run the following command.

```bash
dotnet add package tatnet-template-pack --version 1.0.0
```

## Templates

| Group   | Name                    |  Tag                | Required Parameter |
| ------- | ----------------------- | ------------------- | ------------------ |
| License | TATNet - Apache License | tat-license-apache  | --owner (text)     |
| License | TATNet - ISC License    | tat-license-isc     | --owner (text)     |
| License | TATNet - MIT License    | tat-license-mit     | --owner (text)     |
| Library | TATNet - Class Library  | tat-classlib        |                    |
| Console | TATNet - Console App    | tat-console         |                    |
| Worker  | TATNet - Worker         | tat-worker          |                    |
| Test    | TATNet - xUnit          | tat-xunit           |                    |

## Authors

- [@fatihtatoglu](https://www.github.com/fatihtatoglu)

## License

[MIT](https://choosealicense.com/licenses/mit/)
