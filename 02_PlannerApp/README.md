# PlannerApp

- https://www.youtube.com/playlist?list=PLFJQnCcZXWjtftgq0KID4oHk6wfJrRL1r kanalı ile geliştirilen uygulama
- **Radzen UI** Componentini kullanarak geliştirildi ve `https://blazor.radzen.com/` resmi sitesidir.

## Layout Tanımlama

Razor Kod Örneği (**AuthLayout.razor**): 

```C#
@inherits LayoutComponentBase

<div class="middle-box">
    <h1>Welcome to PlannerApp</h1>
    @Body
</div>
```

- layout'un uygulandığı sayfa (**Index.razor**)

```C#
@page "/"
@layout AuthLayout

<div class="row">
    <div class="col-12">
        <h3>Simple login</h3>
    </div>
</div>
<SurveyPrompt Title="How is Blazor working for you?" />

@code {
    
}
```

## Store User Info in Local Storage
- **PlannerApp.Client/Models/** klasörünün içine LocalUserInfo modeli oluşturuldu
- `Blazor.LocalStorage` paketi yüklendi
- **Program.cs** içine `builder.Services.AddBlazoredLocalStorage();` eklendi.
- **_Imports.razor** dosyasının içine `@using Blazored.LocalStorage` eklendi. 
- **Login.razor** dosyasının içine aşağıdaki `code`bloğunu yerleştiriyoruz.

```C#
@inject ILocalStorageService storageService
@code {
  var userInfo = new LocalUserInfo()
  {
    AccessToken = result.Message,
    Email = result.UserInfo["Email"],
    FirstName = result.UserInfo["FirstName"],
    LastName = result.UserInfo["LastName"],
    Id = result.UserInfo[System.Security.Claims.ClaimTypes.NameIdentifier],
  };
}
```

## Authenticate User In Browser
- PlannerApp.Client.csproj dosyasında <PropertGroup> içine `<BlazorLinkOnBuild>false</BlazorLinkOnBuild>` eklendi.
- Paket yüklemek için `NuGet` açıldı ve `Microsoft.AspNetCore.Components.Authoriaztion` paketi yüklendi.
- `Program.cs` dosyasının içine

```C#
builder.Services.AddOptions();
builder.Services.AddAuthorizationCore();
builder.Services.AddScoped<AuthenticationStateProvider, LocalAuthenticationStateProvider>();
```
- **PlannerApp.Client** içinde LoaclAuthenticatinStateProvider.cs dosyası oluşturuldu.
- **_Imports.razor** içinde `@using Microsoft.AspNetCore.Components.Authorization` tanımlama yapıldı.
- **App.razor** dosyasında  düzenleme yapıldı.
- Authentication işlemi **Index.razor** sayfasında uygulandı.

## Notify Auth State & Redirection
- **Index.razor** dosyasında `@attribute [Authorize]` tanımlaması yapıldı.
- `@attribute [Authorize]` global olması için **_Import.razor** dosyasında `@using Microsoft.AspNetCore.Authorization`  tanımlaması yapıldı.
- **Login.razor** dosyasında login olduğunda yönlendirme için `navigationManager.NavigateTo("/");` tanımlaması yapıldı.
- **LocalAuthenticationStateProvider.cs** dosyasında aşağıdaki kod düzenlemesi yapıldı.

```C#
var state = new AuthenticationState(user); ;
NotifyAuthenticationStateChanged(Task.FromResult(state));

return state;
```
- Yapılan düzenlemenin görülebilmesi için **Login.razor** içine `await authenticationStateProvider.GetAuthenticationStateAsync();` düzenlemsi getirildi.
- Yetkisiz girişlere karşın `RedirectToLogin.razor` dosyası oluşturuldu ve **App.razor** içinde kullanıldı. 

## User & Logout Component
- **LocalAuthenticationStateProvider.cs** dosyasının içinde aşağıdaki metod tanımlandı.

```C#
public async Task LogOutAsync()
{
   await _storageService.RemoveItemAsync("User");
   NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(new ClaimsPrincipal())));
}
```

- **Shared\UserStatus.razor** dosyası oluşturuldu.
- **MainLayout.razor** dosyasında `UserStatus` componenti tanımlandı.

## Initialize Main Layout & The Menu
- **app.cs** dosyasında `.sidebar` class'ında background düzenlemesi yapıldı. (yapılan değişiklik browser'da görünmüyorsa 'cache' leme olmuştur. Bundan 
       dolayı  `Ctlr + F5` kombinasyonu ile refresh'lememiz gerekmektedir.)
- ** NavMenu.razor** dosyasında menu düzenlemesine gidildi.

## Creating Plan Models
-**02_PlannerApp\PlannerApp.Shared\Models** içinde model dosyaları oluşturuldu

## Creating Plans Service
- **PlannerApp.Shared/Services/PlansService.cs** service'i oluşturuldu.
- **PlannerApp.Client/Program.cs** içinde `PlansService` tanımlama yapıldı.

## Plans Component Get & Show Plans
- **PlannerApp.Client\Pages\Plans\Plan.razor** dosyası oluşturuldu.

## Plans Component - Paging
- **Plans.razor** dosyasında `pagination` işlemi gerçekleştirildi

## Plans Component Search Plans
- **Plans.razor** dosyasında  `search` işlemi gerçekleştirikdi.

## AddPlan Component Init & Design
- **PlannerApp.Shared\Model\PlanRequest.cs** modeli oluşturuldu.
- **PlannerApp.Shared\Services\PlansService.cs** içinde `PostPlanAsync` metodu yazıldı.
- NuGet Package Manager ile `Tewr.Blazor.FileReader` yüklendi. Dosya okumak için yüklendi.
- **Program.cs** dosyasının içinde `FileReader` tanımlaması yapıldı.
```C#
builder.Services.AddFileReaderService(options =>
{
   options.UseWasmSharedBuffer = true;
});
```
- **_Imports.razor** dosyasında `@using Blazor.FileReader;` tanımlaması yapıldı.

## 
