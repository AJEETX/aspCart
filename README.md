
aspCart
=========

aspCart is a basic ecommerce websites using ASP.NET Core MVC.
This repo is just a demo project that I've been working as I learn ASP.NET Core MVC.
All product details are either from newegg, amazon or from the product website.
This project design is inspired by nopcommerce, opencart, newegg and amazon.

## Live demo

[Store Front][d1] <br />
[Admin Dashboard][d2]

## License

MIT

[d1]: https://aspcart.azurewebsites.net
[d2]: https://aspcart.azurewebsites.net/Admin




<Project Sdk="Microsoft.NET.Sdk.Web">

  <PropertyGroup>
    <TargetFramework>netcoreapp2.1</TargetFramework>
  </PropertyGroup>

  <ItemGroup>
    <PackageReference Include="AutoMapper" Version="10.1.1" />
    <PackageReference Include="Microsoft.AspNetCore.App" />
    <PackageReference Include="Microsoft.AspNetCore.Identity.EntityFrameworkCore" Version="2.1.1" />
    <PackageReference Include="Microsoft.AspNetCore.Razor.Design" Version="2.1.2" PrivateAssets="All" />
    <PackageReference Include="Microsoft.AspNetCore.Rewrite" Version="2.1.1" />
    <PackageReference Include="Microsoft.EntityFrameworkCore" Version="2.1.1" />
    <PackageReference Include="Microsoft.EntityFrameworkCore.SqlServer" Version="2.1.1" />
    <PackageReference Include="Microsoft.VisualStudio.Web.BrowserLink.Loader" Version="14.1.0" />
    <PackageReference Include="SendGrid" Version="9.23.2" />
    <PackageReference Include="SkiaSharp" Version="2.80.2" />
  </ItemGroup>

</Project>

