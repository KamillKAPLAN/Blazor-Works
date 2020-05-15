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