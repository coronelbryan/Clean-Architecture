This project is base on this documentation
https://learn.microsoft.com/en-us/dotnet/architecture/modern-web-apps-azure/common-web-application-architectures#infrastructure-types

EF create migration
dotnet ef migrations add --output-dir .\Infrastructure\Data --startup-project .\Web\ --project .\Infrastructure\ init

EF update Database
dotnet ef database update --startup-project .\Web\ --project .\Infrastructure\
